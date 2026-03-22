using psRAM_Application.DTOS.ArtefactosDtos;
using psRAM_Application.Interfaces.IServices;
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
        private AnalisisResponse? ultimoResultado;

        public Form1()
        {
            InitializeComponent();
            _pythonService = new PythonAnalisisService(new System.Net.Http.HttpClient());

            // Configurar DataGridViews con AutoGenerateColumns = false para control total
            ConfigurarDataGridViews();

            // Conectar eventos para pintar filas
            if (dgvProcesos != null)
                dgvProcesos.RowPrePaint += dgvProcesos_RowPrePaint;
            if (dgvArchivos != null)
                dgvArchivos.RowPrePaint += dgvArchivos_RowPrePaint;
            if (dgvConexiones != null)
                dgvConexiones.RowPrePaint += dgvConexiones_RowPrePaint;
            if (dgvModulos != null)
                dgvModulos.RowPrePaint += dgvModulos_RowPrePaint;
            if (dgvPlugins != null)
                dgvPlugins.RowPrePaint += dgvPlugins_RowPrePaint;

            // Configurar la gráfica
            ConfigurarGrafica();
        }

        private void ConfigurarDataGridViews()
        {
            // Configurar DataGridView de Procesos
            if (dgvProcesos != null)
            {
                dgvProcesos.AutoGenerateColumns = false;
                dgvProcesos.AllowUserToAddRows = false;
                dgvProcesos.ReadOnly = true;
                dgvProcesos.RowHeadersVisible = false;

                // Crear columnas manualmente
                dgvProcesos.Columns.Clear();
                dgvProcesos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Pid", HeaderText = "PID", DataPropertyName = "Pid", Width = 80 });
                dgvProcesos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nombre", HeaderText = "Nombre Proceso", DataPropertyName = "Nombre", Width = 200 });
                dgvProcesos.Columns.Add(new DataGridViewTextBoxColumn { Name = "ParentPid", HeaderText = "PID Padre", DataPropertyName = "ParentPid", Width = 80 });
                dgvProcesos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Usuario", HeaderText = "Usuario", DataPropertyName = "Usuario", Width = 100 });
                dgvProcesos.Columns.Add(new DataGridViewTextBoxColumn { Name = "HashMD5", HeaderText = "Hash MD5", DataPropertyName = "HashMD5", Width = 150 });
                dgvProcesos.Columns["HashMD5"].Visible = false; // Ocultar por defecto
                dgvProcesos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            // Configurar DataGridView de Conexiones
            if (dgvConexiones != null)
            {
                dgvConexiones.AutoGenerateColumns = false;
                dgvConexiones.AllowUserToAddRows = false;
                dgvConexiones.ReadOnly = true;
                dgvConexiones.RowHeadersVisible = false;

                dgvConexiones.Columns.Clear();
                dgvConexiones.Columns.Add(new DataGridViewTextBoxColumn { Name = "IpOrigen", HeaderText = "IP Origen", DataPropertyName = "IpOrigen", Width = 120 });
                dgvConexiones.Columns.Add(new DataGridViewTextBoxColumn { Name = "PuertoOrigen", HeaderText = "Puerto Origen", DataPropertyName = "PuertoOrigen", Width = 80 });
                dgvConexiones.Columns.Add(new DataGridViewTextBoxColumn { Name = "IpDestino", HeaderText = "IP Destino", DataPropertyName = "IpDestino", Width = 120 });
                dgvConexiones.Columns.Add(new DataGridViewTextBoxColumn { Name = "PuertoDestino", HeaderText = "Puerto Destino", DataPropertyName = "PuertoDestino", Width = 80 });
                dgvConexiones.Columns.Add(new DataGridViewTextBoxColumn { Name = "Protocolo", HeaderText = "Protocolo", DataPropertyName = "Protocolo", Width = 60 });
                dgvConexiones.Columns.Add(new DataGridViewTextBoxColumn { Name = "Pid", HeaderText = "PID", DataPropertyName = "Pid", Width = 80 });
                dgvConexiones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            // Configurar DataGridView de Módulos
            if (dgvModulos != null)
            {
                dgvModulos.AutoGenerateColumns = false;
                dgvModulos.AllowUserToAddRows = false;
                dgvModulos.ReadOnly = true;
                dgvModulos.RowHeadersVisible = false;

                dgvModulos.Columns.Clear();
                dgvModulos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nombre", HeaderText = "Módulo", DataPropertyName = "Nombre", Width = 200 });
                dgvModulos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Ruta", HeaderText = "Ruta", DataPropertyName = "Ruta", Width = 300 });
                dgvModulos.Columns.Add(new DataGridViewTextBoxColumn { Name = "HashMD5", HeaderText = "Hash MD5", DataPropertyName = "HashMD5", Width = 150 });
                dgvModulos.Columns["HashMD5"].Visible = false;
                dgvModulos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Pid", HeaderText = "PID", DataPropertyName = "Pid", Width = 80 });
                dgvModulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            // Configurar DataGridView de Archivos
            if (dgvArchivos != null)
            {
                dgvArchivos.AutoGenerateColumns = false;
                dgvArchivos.AllowUserToAddRows = false;
                dgvArchivos.ReadOnly = true;
                dgvArchivos.RowHeadersVisible = false;

                dgvArchivos.Columns.Clear();
                dgvArchivos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nombre", HeaderText = "Archivo", DataPropertyName = "Nombre", Width = 200 });
                dgvArchivos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Ruta", HeaderText = "Ruta", DataPropertyName = "Ruta", Width = 300 });
                dgvArchivos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Extension", HeaderText = "Extensión", DataPropertyName = "Extension", Width = 80 });
                dgvArchivos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            // Configurar DataGridView de Plugins
            if (dgvPlugins != null)
            {
                dgvPlugins.AutoGenerateColumns = false;
                dgvPlugins.AllowUserToAddRows = false;
                dgvPlugins.ReadOnly = true;
                dgvPlugins.RowHeadersVisible = false;

                dgvPlugins.Columns.Clear();
                dgvPlugins.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nombre", HeaderText = "Plugin", DataPropertyName = "Nombre", Width = 150 });
                dgvPlugins.Columns.Add(new DataGridViewTextBoxColumn { Name = "Descripcion", HeaderText = "Descripción", DataPropertyName = "Descripcion", Width = 200 });
                dgvPlugins.Columns.Add(new DataGridViewTextBoxColumn { Name = "Estado", HeaderText = "Estado", DataPropertyName = "Estado", Width = 150 });
                dgvPlugins.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void ConfigurarGrafica()
        {
            if (chartRiesgo == null) return;

            chartRiesgo.Series.Clear();

            if (chartRiesgo.ChartAreas.Count == 0)
                chartRiesgo.ChartAreas.Add(new ChartArea("Default"));

            var chartArea = chartRiesgo.ChartAreas[0];

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
                Filter = "Memory Dumps (*.raw;*.dmp;*.vmem;*.*)|*.raw;*.dmp;*.vmem;*.*",
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
                        var resultado = await _pythonService.AnalizarMemoriaAsync(filePath);
                        ultimoResultado = resultado;

                        if (resultado != null)
                        {
                            // Información general
                            lblFechaValor.Text = resultado.Fecha ?? DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            lblSOValor.Text = resultado.SistemaOperativo ?? "Windows";
                            lblHashValor.Text = !string.IsNullOrEmpty(resultado.HashImagen)
                                ? resultado.HashImagen
                                : (resultado.Procesos?.FirstOrDefault()?.HashMD5 ?? "No disponible");

                            // Cargar datos en DataGridViews (con AutoGenerateColumns = false, las columnas ya existen)
                            if (dgvProcesos != null)
                            {
                                dgvProcesos.DataSource = null;
                                dgvProcesos.DataSource = resultado.Procesos?.ToList() ?? new System.Collections.Generic.List<ProcesoDtos>();
                            }

                            if (dgvConexiones != null)
                            {
                                dgvConexiones.DataSource = null;
                                dgvConexiones.DataSource = resultado.Conexiones?.ToList() ?? new System.Collections.Generic.List<ConexionRedDtos>();
                            }

                            if (dgvModulos != null)
                            {
                                dgvModulos.DataSource = null;
                                dgvModulos.DataSource = resultado.Modulos?.ToList() ?? new System.Collections.Generic.List<ModuloMaliciosoDtos>();
                            }

                            // Archivos (datos derivados)
                            if (dgvArchivos != null)
                            {
                                var archivosList = new System.Collections.Generic.List<object>();

                                if (resultado.Procesos != null && resultado.Procesos.Any())
                                {
                                    foreach (var proc in resultado.Procesos)
                                    {
                                        archivosList.Add(new
                                        {
                                            Nombre = proc.Nombre,
                                            Ruta = $"Proceso en memoria: {proc.Nombre}",
                                            Extension = System.IO.Path.GetExtension(proc.Nombre)
                                        });
                                    }
                                }

                                dgvArchivos.DataSource = null;
                                dgvArchivos.DataSource = archivosList;
                            }

                            // Plugins
                            if (dgvPlugins != null)
                            {
                                var pluginsList = new System.Collections.Generic.List<object>();

                                pluginsList.Add(new
                                {
                                    Nombre = "windows.pslist",
                                    Descripcion = "Lista de procesos",
                                    Estado = resultado.Procesos != null ? $"Éxito ({resultado.Procesos.Count} procesos)" : "No ejecutado"
                                });

                                pluginsList.Add(new
                                {
                                    Nombre = "windows.netscan",
                                    Descripcion = "Conexiones de red",
                                    Estado = resultado.Conexiones != null ? $"Éxito ({resultado.Conexiones.Count} conexiones)" : "No ejecutado"
                                });

                                pluginsList.Add(new
                                {
                                    Nombre = "windows.dlllist",
                                    Descripcion = "Módulos DLL cargados",
                                    Estado = resultado.Modulos != null ? $"Éxito ({resultado.Modulos.Count} módulos)" : "No ejecutado"
                                });

                                dgvPlugins.DataSource = null;
                                dgvPlugins.DataSource = pluginsList;
                            }

                            // Desglose de riesgo
                            if (dgvDesgloseRiesgo != null && resultado.DesgloseRiesgo != null)
                            {
                                dgvDesgloseRiesgo.DataSource = null;
                                dgvDesgloseRiesgo.DataSource = resultado.DesgloseRiesgo
                                    .Select(kvp => new
                                    {
                                        Categoria = kvp.Key,
                                        Valor = kvp.Value.Valor,
                                        Nivel = kvp.Value.Nivel
                                    })
                                    .ToList();
                            }

                            // Campos de filtro
                            CargarCamposFiltro();

                            // Risk Score
                            if (lblRiskScore != null)
                                lblRiskScore.Text = $"Risk Score: {resultado.RiskScore}";

                            // Mostrar IoCs
                            MostrarIoCs(resultado.IoCs);

                            // Mostrar YARA Report
                            MostrarYaraReport(resultado.YaraReport);

                            // Actualizar gráfica
                            ActualizarGrafica(filePath, resultado);
                        }
                        else
                        {
                            if (lblResultado != null)
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

        private void MostrarIoCs(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> iocs)
        {
            var lstIoCs = this.Controls.Find("lstIoCs", true).FirstOrDefault() as ListBox;
            if (lstIoCs != null && iocs != null)
            {
                lstIoCs.Items.Clear();

                if (iocs.Any())
                {
                    foreach (var categoria in iocs)
                    {
                        if (categoria.Value != null && categoria.Value.Any())
                        {
                            lstIoCs.Items.Add($"━━━ {categoria.Key.ToUpper()} ━━━");
                            foreach (var ioc in categoria.Value)
                            {
                                lstIoCs.Items.Add($"  ⚠️ {ioc}");
                            }
                            lstIoCs.Items.Add("");
                        }
                    }
                }
                else
                {
                    lstIoCs.Items.Add("No se encontraron IoCs");
                }
            }
        }

        private void MostrarYaraReport(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> yaraReport)
        {
            var lstYara = this.Controls.Find("lstYara", true).FirstOrDefault() as ListBox;
            if (lstYara != null && yaraReport != null)
            {
                lstYara.Items.Clear();
                lstYara.Items.Add("━━━ ANÁLISIS YARA ━━━");

                if (yaraReport.ContainsKey("matches") && yaraReport["matches"] != null && yaraReport["matches"].Any())
                {
                    foreach (var match in yaraReport["matches"])
                    {
                        lstYara.Items.Add($"🔍 {match}");
                    }
                }
                else if (yaraReport.ContainsKey("error"))
                {
                    lstYara.Items.Add($"❌ Error: {yaraReport["error"]}");
                }
                else
                {
                    lstYara.Items.Add("✅ No se encontraron coincidencias YARA");
                }
            }
        }

        private void btnAplicarFiltro_Click(object sender, EventArgs e)
        {
            if (cmbFiltroCampo == null || txtFiltro == null || ultimoResultado == null)
                return;

            string campo = cmbFiltroCampo.SelectedItem?.ToString();
            string valor = txtFiltro.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(campo) || string.IsNullOrEmpty(valor))
                return;

            var procesosFiltrados = ultimoResultado.Procesos
                ?.Where(p => ObtenerValorCampo(p, campo).ToLower().Contains(valor))
                .ToList();

            if (dgvProcesos != null)
            {
                dgvProcesos.DataSource = null;
                dgvProcesos.DataSource = procesosFiltrados;
            }
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            if (txtFiltro != null)
                txtFiltro.Clear();
            if (cmbFiltroCampo != null)
                cmbFiltroCampo.SelectedIndex = -1;

            if (ultimoResultado?.Procesos != null && dgvProcesos != null)
            {
                dgvProcesos.DataSource = null;
                dgvProcesos.DataSource = ultimoResultado.Procesos.ToList();
            }
        }

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

        private void CargarCamposFiltro()
        {
            if (cmbFiltroCampo == null) return;

            if (ultimoResultado?.Procesos != null && ultimoResultado.Procesos.Count > 0)
            {
                var propiedades = ultimoResultado.Procesos.First().GetType().GetProperties()
                    .Select(p => p.Name)
                    .ToArray();

                cmbFiltroCampo.Items.Clear();
                cmbFiltroCampo.Items.AddRange(propiedades);

                if (cmbFiltroCampo.Items.Count > 0)
                    cmbFiltroCampo.SelectedIndex = 0;
            }
        }

        private void ActualizarGrafica(string filePath, AnalisisResponse resultado)
        {
            if (chartRiesgo == null) return;

            chartRiesgo.Series.Clear();

            var serie = new Series("Riesgo Global");
            serie.ChartType = SeriesChartType.Column;
            serie.IsValueShownAsLabel = true;
            serie.LabelForeColor = Color.White;
            serie.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            string nombreArchivo = System.IO.Path.GetFileName(filePath);
            int pointIndex = serie.Points.AddXY(nombreArchivo, resultado.RiskScore);

            if (resultado.RiskScore >= 70)
                serie.Points[pointIndex].Color = Color.IndianRed;
            else if (resultado.RiskScore >= 40)
                serie.Points[pointIndex].Color = Color.Goldenrod;
            else
                serie.Points[pointIndex].Color = Color.ForestGreen;

            chartRiesgo.Series.Add(serie);

            double maxValue = Math.Max(100, resultado.RiskScore * 1.2);
            if (chartRiesgo.ChartAreas.Count > 0)
                chartRiesgo.ChartAreas[0].AxisY.Maximum = maxValue;
        }

        private void dgvProcesos_RowPrePaint(object? sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dgvProcesos != null && e.RowIndex < dgvProcesos.Rows.Count)
                PintarFila(dgvProcesos.Rows[e.RowIndex]);
        }

        private void dgvArchivos_RowPrePaint(object? sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dgvArchivos != null && e.RowIndex < dgvArchivos.Rows.Count)
                PintarFila(dgvArchivos.Rows[e.RowIndex]);
        }

        private void dgvConexiones_RowPrePaint(object? sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dgvConexiones != null && e.RowIndex < dgvConexiones.Rows.Count)
                PintarFila(dgvConexiones.Rows[e.RowIndex]);
        }

        private void dgvModulos_RowPrePaint(object? sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dgvModulos != null && e.RowIndex < dgvModulos.Rows.Count)
                PintarFila(dgvModulos.Rows[e.RowIndex]);
        }

        private void dgvPlugins_RowPrePaint(object? sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dgvPlugins != null && e.RowIndex < dgvPlugins.Rows.Count)
                PintarFila(dgvPlugins.Rows[e.RowIndex]);
        }

        private void PintarFila(DataGridViewRow row)
        {
            if (row != null && ultimoResultado != null)
            {
                var riesgoGlobal = ultimoResultado.RiskScore;
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