using psRAM_Application.Interfaces.IServices.IAnalisis;
using psRAM_Application.Services;
using psRAM_Domain.Enums;
using psRAM_View.Entidades_Auxiliar;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace psRAM_View
{
    public partial class Form1 : Form
    {
        private readonly IPythonAnalisisService _pythonService;
        private AnalisisResponse ultimoResultado; // <-- Aquí se añade el nuevo campo
     

        public Form1()
        {
            InitializeComponent();
            _pythonService = new PythonAnalisisService(new System.Net.Http.HttpClient());

            // Conectar eventos para pintar filas
            this.dgvProcesos.RowPrePaint += dgvProcesos_RowPrePaint;
            this.dgvArchivos.RowPrePaint += dgvArchivos_RowPrePaint;
            this.dgvConexiones.RowPrePaint += dgvConexiones_RowPrePaint;
            this.dgvModulos.RowPrePaint += dgvModulos_RowPrePaint;
            this.dgvPlugins.RowPrePaint += dgvPlugins_RowPrePaint;

            // Configurar la gráfica
            ConfigurarGrafica();
        }

        private void ConfigurarGrafica()
        {
            // Limpiar series existentes
            chartRiesgo.Series.Clear();

            // Asegurar que existe ChartArea
            if (chartRiesgo.ChartAreas.Count == 0)
                chartRiesgo.ChartAreas.Add(new ChartArea("Default"));

            var chartArea = chartRiesgo.ChartAreas[0];

            // Configurar colores para tema oscuro
            chartArea.BackColor = Color.FromArgb(45, 45, 45);
            chartArea.AxisX.LabelStyle.ForeColor = Color.White;
            chartArea.AxisX.TitleForeColor = Color.White;
            chartArea.AxisX.LineColor = Color.Gray;
            chartArea.AxisX.MajorGrid.LineColor = Color.FromArgb(80, 80, 80);
            chartArea.AxisX.Interval = 1;

            chartArea.AxisY.LabelStyle.ForeColor = Color.White;
            chartArea.AxisY.TitleForeColor = Color.White;
            chartArea.AxisY.LineColor = Color.Gray;
            chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(80, 80, 80);
            chartArea.AxisY.Title = "Nivel de Riesgo";

            chartArea.AxisX.Title = "Archivo Analizado";

            // Crear serie inicial vacía
            var serie = new Series("Riesgo Global");
            serie.ChartType = SeriesChartType.Column;
            serie.IsValueShownAsLabel = true;
            serie.LabelForeColor = Color.White;
            chartRiesgo.Series.Add(serie);
        }

        private async void btnAnalizar_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog
            {
                Filter = "Todos los archivos (*.*)|*.*",
                Title = "Seleccionar archivo(s) para analizar",
                Multiselect = true,
                CheckFileExists = true,
                CheckPathExists = true
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Cursor = Cursors.WaitCursor;
                    btnAnalizar.Enabled = false;
                    btnAnalizar.Text = "Analizando...";

                    foreach (var filePath in dialog.FileNames)
                    {
                        // 🔹 Llamada a tu servicio que consume la API Python
                        var resultado = await _pythonService.AnalizarMemoriaAsync(filePath);
                        ultimoResultado = resultado;

                        if (resultado != null)
                        {
                            // Información general (no está directo en AnalisisResponse, así que usamos DateTime.Now y datos de Resultados)
                            lblFechaValor.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            lblSOValor.Text = resultado.Resultados?.Procesos?.FirstOrDefault()?.Usuario ?? "No disponible";
                            lblHashValor.Text = resultado.Resultados?.Archivos?.FirstOrDefault()?.HashMD5 ?? "No disponible";

                            // DataGridViews (usando tus DTOs dentro de Resultados)
                            dgvProcesos.DataSource = resultado.Resultados?.Procesos?.ToList();
                            dgvArchivos.DataSource = resultado.Resultados?.Archivos?.ToList();
                            dgvConexiones.DataSource = resultado.Resultados?.Conexiones?.ToList();
                            dgvModulos.DataSource = resultado.Resultados?.Modulos?.ToList();
                            dgvPlugins.DataSource = resultado.Resultados?.Plugins?.ToList();

                            // 🔹 Para el desglose de riesgo, conviértelo a lista
                            if (resultado.DesgloseRiesgo != null)
                            {
                                dgvDesgloseRiesgo.DataSource = resultado.DesgloseRiesgo
                                    .Select(kvp => new { Categoria = kvp.Key, Valor = kvp.Value.Valor, Nivel = kvp.Value.Nivel })
                                    .ToList();
                            }

                            // Campos de filtro
                            CargarCamposFiltro();

                            // Risk Score (usa RiesgoGlobal en lugar de RiskScore)
                            lblRiskScore.Text = $"Riesgo Global: {resultado.RiesgoGlobal}";
                            ActualizarGrafica(filePath, resultado);
                        }
                        else
                        {
                            lblResultado.Text = "No se recibió respuesta de la API.";
                            lblFechaValor.Text = "Error";
                            lblSOValor.Text = "Error";
                            lblHashValor.Text = "Error";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al analizar: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Cursor = Cursors.Default;
                    btnAnalizar.Enabled = true;
                    btnAnalizar.Text = "Analizar Memory Dump";
                }
            }
        }


        private void btnAplicarFiltro_Click(object sender, EventArgs e)
        {
            string campo = cmbFiltroCampo.SelectedItem?.ToString();
            string valor = txtFiltro.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(campo) || string.IsNullOrEmpty(valor) || ultimoResultado == null)
                return;

            // Filtrar procesos
            var procesosFiltrados = ultimoResultado.Resultados?.Procesos
                ?.Where(p => ObtenerValorCampo(p, campo).ToLower().Contains(valor))
                .ToList();

            dgvProcesos.DataSource = null;
            dgvProcesos.DataSource = procesosFiltrados;
        }

        // NUEVO: Event handler para limpiar filtro
        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            cmbFiltroCampo.SelectedIndex = -1;

            if (ultimoResultado?.Resultados?.Procesos != null)
            {
                dgvProcesos.DataSource = null;
                dgvProcesos.DataSource = ultimoResultado.Resultados.Procesos.ToList();
            }
        }

        // NUEVO: Método auxiliar para obtener valores de propiedades
        private string ObtenerValorCampo(object obj, string campo)
        {
            var prop = obj.GetType().GetProperty(campo);
            if (prop != null)
            {
                var val = prop.GetValue(obj);
                return val?.ToString() ?? "";
            }
            return "";
        }

        // NUEVO: Método para cargar los campos en el ComboBox (llamar después de cargar datos)
        private void CargarCamposFiltro()
        {
            if (ultimoResultado?.Resultados?.Procesos != null && ultimoResultado.Resultados.Procesos.Count > 0)
            {
                var propiedades = ultimoResultado.Resultados.Procesos.First().GetType().GetProperties()
                    .Select(p => p.Name)
                    .ToArray();

                cmbFiltroCampo.Items.Clear();
                cmbFiltroCampo.Items.AddRange(propiedades);

                // Opcional: seleccionar el primer item por defecto
                if (cmbFiltroCampo.Items.Count > 0)
                    cmbFiltroCampo.SelectedIndex = 0;
            }
        }

        private void ActualizarGrafica(string filePath, AnalisisResponse resultado)
        {
            // Limpiar series existentes
            chartRiesgo.Series.Clear();

            // Crear nueva serie
            var serie = new Series("Riesgo Global");
            serie.ChartType = SeriesChartType.Column;
            serie.IsValueShownAsLabel = true;
            serie.LabelForeColor = Color.White;
            serie.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            // Obtener nombre del archivo sin la ruta completa
            string nombreArchivo = System.IO.Path.GetFileName(filePath);

            // Agregar punto con el valor de riesgo global
            int pointIndex = serie.Points.AddXY(nombreArchivo, resultado.RiesgoGlobal);

            // Colorear la barra según nivel de riesgo global
            if (resultado.RiesgoGlobal >= 70) // ejemplo: alto
                serie.Points[pointIndex].Color = Color.IndianRed;
            else if (resultado.RiesgoGlobal >= 40) // ejemplo: medio
                serie.Points[pointIndex].Color = Color.Goldenrod;
            else
                serie.Points[pointIndex].Color = Color.ForestGreen;

            // Agregar la serie al chart
            chartRiesgo.Series.Add(serie);

            // Ajustar el eje Y para que muestre un rango apropiado
            double maxValue = resultado.RiesgoGlobal * 1.2; // 20% más que el valor actual
            chartRiesgo.ChartAreas[0].AxisY.Maximum = Math.Max(10, maxValue);
        }

        // Métodos para pintar filas según riesgo global
        private void dgvProcesos_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            PintarFila(dgvProcesos.Rows[e.RowIndex]);
        }

        private void dgvArchivos_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            PintarFila(dgvArchivos.Rows[e.RowIndex]);
        }

        private void dgvConexiones_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            PintarFila(dgvConexiones.Rows[e.RowIndex]);
        }

        private void dgvModulos_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            PintarFila(dgvModulos.Rows[e.RowIndex]);
        }

        private void dgvPlugins_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            PintarFila(dgvPlugins.Rows[e.RowIndex]);
        }

        private void PintarFila(DataGridViewRow row)
        {
            if (row != null && ultimoResultado != null)
    {
        // Use RiesgoGlobal to determine the risk level
        var riesgoGlobal = ultimoResultado.RiesgoGlobal;
        NivelRiesgo nivel;

        if (riesgoGlobal >= 70)
            nivel = NivelRiesgo.Alto;
        else if (riesgoGlobal >= 40)
            nivel = NivelRiesgo.Medio;
        else
            nivel = NivelRiesgo.Bajo;

        if (nivel == NivelRiesgo.Alto)
            row.DefaultCellStyle.BackColor = Color.IndianRed;
        else if (nivel == NivelRiesgo.Medio)
            row.DefaultCellStyle.BackColor = Color.Goldenrod;
        else
            row.DefaultCellStyle.BackColor = Color.ForestGreen;

        row.DefaultCellStyle.ForeColor = Color.White;
        row.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
    }
}
    }
}