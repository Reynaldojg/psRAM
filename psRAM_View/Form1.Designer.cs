namespace psRAM_View
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Controles principales
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblRiskScore;
        private System.Windows.Forms.DataGridView dgvProcesos;
        private System.Windows.Forms.DataGridView dgvArchivos;
        private System.Windows.Forms.DataGridView dgvConexiones;
        private System.Windows.Forms.DataGridView dgvModulos;
        private System.Windows.Forms.DataGridView dgvPlugins;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRiesgo;

        // NUEVO: DataGridView para desglose de riesgo
        private System.Windows.Forms.DataGridView dgvDesgloseRiesgo;

        // TabControl y Tabs
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.TabPage tabProcesos;
        private System.Windows.Forms.TabPage tabArchivos;
        private System.Windows.Forms.TabPage tabConexiones;
        private System.Windows.Forms.TabPage tabModulos;
        private System.Windows.Forms.TabPage tabPlugins;
        private System.Windows.Forms.TabPage tabRiesgo;

        // Controles para info general
        private System.Windows.Forms.Panel panelInfoGeneral;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblSO;
        private System.Windows.Forms.Label lblHash;
        private System.Windows.Forms.Label lblFechaValor;
        private System.Windows.Forms.Label lblSOValor;
        private System.Windows.Forms.Label lblHashValor;

        // Controles para filtro
        private System.Windows.Forms.ComboBox cmbFiltroCampo;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnAplicarFiltro;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.Label lblFiltro;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblRiskScore = new System.Windows.Forms.Label();
            this.dgvProcesos = new System.Windows.Forms.DataGridView();
            this.dgvArchivos = new System.Windows.Forms.DataGridView();
            this.dgvConexiones = new System.Windows.Forms.DataGridView();
            this.dgvModulos = new System.Windows.Forms.DataGridView();
            this.dgvPlugins = new System.Windows.Forms.DataGridView();
            this.dgvDesgloseRiesgo = new System.Windows.Forms.DataGridView();
            this.chartRiesgo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.tabProcesos = new System.Windows.Forms.TabPage();
            this.tabArchivos = new System.Windows.Forms.TabPage();
            this.tabConexiones = new System.Windows.Forms.TabPage();
            this.tabModulos = new System.Windows.Forms.TabPage();
            this.tabPlugins = new System.Windows.Forms.TabPage();
            this.tabRiesgo = new System.Windows.Forms.TabPage();

            // Controles para info general
            this.panelInfoGeneral = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblSO = new System.Windows.Forms.Label();
            this.lblHash = new System.Windows.Forms.Label();
            this.lblFechaValor = new System.Windows.Forms.Label();
            this.lblSOValor = new System.Windows.Forms.Label();
            this.lblHashValor = new System.Windows.Forms.Label();

            // Controles para filtro
            this.cmbFiltroCampo = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnAplicarFiltro = new System.Windows.Forms.Button();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConexiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlugins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesgloseRiesgo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRiesgo)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.tabProcesos.SuspendLayout();
            this.tabRiesgo.SuspendLayout();
            this.SuspendLayout();

            // 
            // Configuración de colores oscuros modernos
            // 
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);

            // 
            // btnAnalizar
            // 
            this.btnAnalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAnalizar.Location = new System.Drawing.Point(20, 20);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(180, 40);
            this.btnAnalizar.TabIndex = 0;
            this.btnAnalizar.Text = "🔍 Analizar Memory Dump";
            this.btnAnalizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAnalizar.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnAnalizar.ForeColor = System.Drawing.Color.White;
            this.btnAnalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalizar.FlatAppearance.BorderSize = 0;
            this.btnAnalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);

            // 
            // lblResultado
            // 
            this.lblResultado.Visible = false;

            // 
            // lblRiskScore
            // 
            this.lblRiskScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRiskScore.Location = new System.Drawing.Point(220, 20);
            this.lblRiskScore.Name = "lblRiskScore";
            this.lblRiskScore.Size = new System.Drawing.Size(760, 40);
            this.lblRiskScore.TabIndex = 2;
            this.lblRiskScore.Text = "Risk Score:";
            this.lblRiskScore.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRiskScore.ForeColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.lblRiskScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // dgvProcesos - Estilo oscuro
            // 
            this.dgvProcesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesos.BackgroundColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.dgvProcesos.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvProcesos.GridColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.dgvProcesos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProcesos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProcesos.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.dgvProcesos.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProcesos.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvProcesos.ColumnHeadersHeight = 35;
            this.dgvProcesos.EnableHeadersVisualStyles = false;
            this.dgvProcesos.RowHeadersVisible = false;
            this.dgvProcesos.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.dgvProcesos.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvProcesos.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.dgvProcesos.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProcesos.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.dgvProcesos.AllowUserToAddRows = false;
            this.dgvProcesos.ReadOnly = true;
            this.dgvProcesos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // dgvArchivos - Mismo estilo
            // 
            this.dgvArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArchivos.BackgroundColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.dgvArchivos.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvArchivos.GridColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.dgvArchivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArchivos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvArchivos.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.dgvArchivos.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvArchivos.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvArchivos.ColumnHeadersHeight = 35;
            this.dgvArchivos.EnableHeadersVisualStyles = false;
            this.dgvArchivos.RowHeadersVisible = false;
            this.dgvArchivos.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.dgvArchivos.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvArchivos.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.dgvArchivos.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvArchivos.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.dgvArchivos.AllowUserToAddRows = false;
            this.dgvArchivos.ReadOnly = true;
            this.dgvArchivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // dgvConexiones - Mismo estilo
            // 
            this.dgvConexiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConexiones.BackgroundColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.dgvConexiones.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvConexiones.GridColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.dgvConexiones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConexiones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvConexiones.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.dgvConexiones.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvConexiones.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvConexiones.ColumnHeadersHeight = 35;
            this.dgvConexiones.EnableHeadersVisualStyles = false;
            this.dgvConexiones.RowHeadersVisible = false;
            this.dgvConexiones.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.dgvConexiones.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvConexiones.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.dgvConexiones.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvConexiones.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.dgvConexiones.AllowUserToAddRows = false;
            this.dgvConexiones.ReadOnly = true;
            this.dgvConexiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // dgvModulos - Mismo estilo
            // 
            this.dgvModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModulos.BackgroundColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.dgvModulos.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvModulos.GridColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.dgvModulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvModulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvModulos.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.dgvModulos.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvModulos.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvModulos.ColumnHeadersHeight = 35;
            this.dgvModulos.EnableHeadersVisualStyles = false;
            this.dgvModulos.RowHeadersVisible = false;
            this.dgvModulos.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.dgvModulos.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvModulos.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.dgvModulos.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvModulos.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.dgvModulos.AllowUserToAddRows = false;
            this.dgvModulos.ReadOnly = true;
            this.dgvModulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // dgvPlugins - Mismo estilo
            // 
            this.dgvPlugins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlugins.BackgroundColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.dgvPlugins.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvPlugins.GridColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.dgvPlugins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPlugins.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPlugins.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.dgvPlugins.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPlugins.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvPlugins.ColumnHeadersHeight = 35;
            this.dgvPlugins.EnableHeadersVisualStyles = false;
            this.dgvPlugins.RowHeadersVisible = false;
            this.dgvPlugins.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.dgvPlugins.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvPlugins.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.dgvPlugins.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPlugins.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.dgvPlugins.AllowUserToAddRows = false;
            this.dgvPlugins.ReadOnly = true;
            this.dgvPlugins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // dgvDesgloseRiesgo - NUEVO DataGridView con mismo estilo
            // 
            this.dgvDesgloseRiesgo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDesgloseRiesgo.BackgroundColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.dgvDesgloseRiesgo.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvDesgloseRiesgo.GridColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.dgvDesgloseRiesgo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDesgloseRiesgo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDesgloseRiesgo.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.dgvDesgloseRiesgo.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDesgloseRiesgo.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvDesgloseRiesgo.ColumnHeadersHeight = 35;
            this.dgvDesgloseRiesgo.EnableHeadersVisualStyles = false;
            this.dgvDesgloseRiesgo.RowHeadersVisible = false;
            this.dgvDesgloseRiesgo.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.dgvDesgloseRiesgo.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvDesgloseRiesgo.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.dgvDesgloseRiesgo.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDesgloseRiesgo.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.dgvDesgloseRiesgo.AllowUserToAddRows = false;
            this.dgvDesgloseRiesgo.ReadOnly = true;
            this.dgvDesgloseRiesgo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabInfo);
            this.tabControl.Controls.Add(this.tabProcesos);
            this.tabControl.Controls.Add(this.tabArchivos);
            this.tabControl.Controls.Add(this.tabConexiones);
            this.tabControl.Controls.Add(this.tabModulos);
            this.tabControl.Controls.Add(this.tabPlugins);
            this.tabControl.Controls.Add(this.tabRiesgo);
            this.tabControl.Location = new System.Drawing.Point(20, 70);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(960, 470);
            this.tabControl.TabIndex = 9;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.tabControl.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);

            // 
            // tabInfo
            // 
            this.tabInfo.Location = new System.Drawing.Point(4, 26);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(952, 440);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.Text = "📋 Información General";
            this.tabInfo.UseVisualStyleBackColor = true;
            this.tabInfo.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.tabInfo.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);

            // 
            // panelInfoGeneral
            // 
            this.panelInfoGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfoGeneral.Location = new System.Drawing.Point(10, 10);
            this.panelInfoGeneral.Name = "panelInfoGeneral";
            this.panelInfoGeneral.Size = new System.Drawing.Size(930, 420);
            this.panelInfoGeneral.TabIndex = 0;
            this.panelInfoGeneral.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.panelInfoGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(15, 15);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(120, 30);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "📅 Fecha:";
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.panelInfoGeneral.Controls.Add(this.lblFecha);

            // 
            // lblFechaValor
            // 
            this.lblFechaValor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaValor.Location = new System.Drawing.Point(140, 15);
            this.lblFechaValor.Name = "lblFechaValor";
            this.lblFechaValor.Size = new System.Drawing.Size(770, 30);
            this.lblFechaValor.TabIndex = 1;
            this.lblFechaValor.Text = "No disponible";
            this.lblFechaValor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblFechaValor.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.panelInfoGeneral.Controls.Add(this.lblFechaValor);

            // 
            // lblSO
            // 
            this.lblSO.Location = new System.Drawing.Point(15, 55);
            this.lblSO.Name = "lblSO";
            this.lblSO.Size = new System.Drawing.Size(120, 30);
            this.lblSO.TabIndex = 2;
            this.lblSO.Text = "💻 Sistema O:";
            this.lblSO.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSO.ForeColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.panelInfoGeneral.Controls.Add(this.lblSO);

            // 
            // lblSOValor
            // 
            this.lblSOValor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSOValor.Location = new System.Drawing.Point(140, 55);
            this.lblSOValor.Name = "lblSOValor";
            this.lblSOValor.Size = new System.Drawing.Size(770, 30);
            this.lblSOValor.TabIndex = 3;
            this.lblSOValor.Text = "No disponible";
            this.lblSOValor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSOValor.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.panelInfoGeneral.Controls.Add(this.lblSOValor);

            // 
            // lblHash
            // 
            this.lblHash.Location = new System.Drawing.Point(15, 95);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(120, 30);
            this.lblHash.TabIndex = 4;
            this.lblHash.Text = "🔑 Hash MD5:";
            this.lblHash.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHash.ForeColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.panelInfoGeneral.Controls.Add(this.lblHash);

            // 
            // lblHashValor
            // 
            this.lblHashValor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHashValor.Location = new System.Drawing.Point(140, 95);
            this.lblHashValor.Name = "lblHashValor";
            this.lblHashValor.Size = new System.Drawing.Size(770, 310);
            this.lblHashValor.TabIndex = 5;
            this.lblHashValor.Text = "No disponible";
            this.lblHashValor.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblHashValor.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.lblHashValor.AutoEllipsis = true;
            this.panelInfoGeneral.Controls.Add(this.lblHashValor);

            this.tabInfo.Controls.Add(this.panelInfoGeneral);

            // 
            // tabProcesos
            // 
            this.tabProcesos.Controls.Add(this.dgvProcesos);
            this.tabProcesos.Controls.Add(this.cmbFiltroCampo);
            this.tabProcesos.Controls.Add(this.lblFiltro);
            this.tabProcesos.Controls.Add(this.txtFiltro);
            this.tabProcesos.Controls.Add(this.btnAplicarFiltro);
            this.tabProcesos.Controls.Add(this.btnLimpiarFiltro);
            this.tabProcesos.Location = new System.Drawing.Point(4, 26);
            this.tabProcesos.Name = "tabProcesos";
            this.tabProcesos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcesos.Size = new System.Drawing.Size(952, 440);
            this.tabProcesos.TabIndex = 1;
            this.tabProcesos.Text = "⚙️ Procesos";
            this.tabProcesos.UseVisualStyleBackColor = true;
            this.tabProcesos.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.tabProcesos.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);

            // 
            // cmbFiltroCampo
            // 
            this.cmbFiltroCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroCampo.Location = new System.Drawing.Point(10, 10);
            this.cmbFiltroCampo.Name = "cmbFiltroCampo";
            this.cmbFiltroCampo.Size = new System.Drawing.Size(150, 25);
            this.cmbFiltroCampo.TabIndex = 0;
            this.cmbFiltroCampo.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.cmbFiltroCampo.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.cmbFiltroCampo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // 
            // lblFiltro
            // 
            this.lblFiltro.Location = new System.Drawing.Point(10, 40);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(80, 25);
            this.lblFiltro.Text = "Filtrar por:";
            this.lblFiltro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFiltro.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.lblFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltro.Location = new System.Drawing.Point(90, 40);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(200, 25);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.txtFiltro.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // 
            // btnAplicarFiltro
            // 
            this.btnAplicarFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplicarFiltro.Location = new System.Drawing.Point(738, 40);
            this.btnAplicarFiltro.Name = "btnAplicarFiltro";
            this.btnAplicarFiltro.Size = new System.Drawing.Size(100, 27);
            this.btnAplicarFiltro.TabIndex = 2;
            this.btnAplicarFiltro.Text = "🔍 Aplicar";
            this.btnAplicarFiltro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAplicarFiltro.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnAplicarFiltro.ForeColor = System.Drawing.Color.White;
            this.btnAplicarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicarFiltro.FlatAppearance.BorderSize = 0;
            this.btnAplicarFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAplicarFiltro.Click += new System.EventHandler(this.btnAplicarFiltro_Click);

            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(844, 40);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(100, 27);
            this.btnLimpiarFiltro.TabIndex = 3;
            this.btnLimpiarFiltro.Text = "🗑️ Limpiar";
            this.btnLimpiarFiltro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarFiltro.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnLimpiarFiltro.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltro.FlatAppearance.BorderSize = 0;
            this.btnLimpiarFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);

            // 
            // dgvProcesos
            // 
            this.dgvProcesos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProcesos.Location = new System.Drawing.Point(3, 80);
            this.dgvProcesos.Name = "dgvProcesos";
            this.dgvProcesos.Size = new System.Drawing.Size(946, 357);
            // Las demás propiedades del dgvProcesos ya están configuradas arriba

            // 
            // tabArchivos
            // 
            this.tabArchivos.Location = new System.Drawing.Point(4, 26);
            this.tabArchivos.Name = "tabArchivos";
            this.tabArchivos.Padding = new System.Windows.Forms.Padding(3);
            this.tabArchivos.Size = new System.Drawing.Size(952, 440);
            this.tabArchivos.TabIndex = 2;
            this.tabArchivos.Text = "📁 Archivos";
            this.tabArchivos.UseVisualStyleBackColor = true;
            this.tabArchivos.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.tabArchivos.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvArchivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabArchivos.Controls.Add(this.dgvArchivos);

            // 
            // tabConexiones
            // 
            this.tabConexiones.Location = new System.Drawing.Point(4, 26);
            this.tabConexiones.Name = "tabConexiones";
            this.tabConexiones.Padding = new System.Windows.Forms.Padding(3);
            this.tabConexiones.Size = new System.Drawing.Size(952, 440);
            this.tabConexiones.TabIndex = 3;
            this.tabConexiones.Text = "🌐 Conexiones";
            this.tabConexiones.UseVisualStyleBackColor = true;
            this.tabConexiones.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.tabConexiones.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvConexiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabConexiones.Controls.Add(this.dgvConexiones);

            // 
            // tabModulos
            // 
            this.tabModulos.Location = new System.Drawing.Point(4, 26);
            this.tabModulos.Name = "tabModulos";
            this.tabModulos.Padding = new System.Windows.Forms.Padding(3);
            this.tabModulos.Size = new System.Drawing.Size(952, 440);
            this.tabModulos.TabIndex = 4;
            this.tabModulos.Text = "🧩 Módulos";
            this.tabModulos.UseVisualStyleBackColor = true;
            this.tabModulos.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.tabModulos.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvModulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabModulos.Controls.Add(this.dgvModulos);

            // 
            // tabPlugins
            // 
            this.tabPlugins.Location = new System.Drawing.Point(4, 26);
            this.tabPlugins.Name = "tabPlugins";
            this.tabPlugins.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlugins.Size = new System.Drawing.Size(952, 440);
            this.tabPlugins.TabIndex = 5;
            this.tabPlugins.Text = "🔌 Plugins";
            this.tabPlugins.UseVisualStyleBackColor = true;
            this.tabPlugins.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.tabPlugins.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvPlugins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPlugins.Controls.Add(this.dgvPlugins);

            // 
            // tabRiesgo
            // 
            this.tabRiesgo.Controls.Add(this.chartRiesgo);
            this.tabRiesgo.Controls.Add(this.dgvDesgloseRiesgo);
            this.tabRiesgo.Location = new System.Drawing.Point(4, 26);
            this.tabRiesgo.Name = "tabRiesgo";
            this.tabRiesgo.Padding = new System.Windows.Forms.Padding(3);
            this.tabRiesgo.Size = new System.Drawing.Size(952, 440);
            this.tabRiesgo.TabIndex = 6;
            this.tabRiesgo.Text = "⚠️ Evaluación Riesgo";
            this.tabRiesgo.UseVisualStyleBackColor = true;
            this.tabRiesgo.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.tabRiesgo.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);

            // 
            // chartRiesgo
            // 
            this.chartRiesgo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartRiesgo.Location = new System.Drawing.Point(10, 10);
            this.chartRiesgo.Name = "chartRiesgo";
            this.chartRiesgo.Size = new System.Drawing.Size(932, 200);
            this.chartRiesgo.TabIndex = 0;
            this.chartRiesgo.Text = "chartRiesgo";
            this.chartRiesgo.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);

            // 
            // dgvDesgloseRiesgo
            // 
            this.dgvDesgloseRiesgo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDesgloseRiesgo.Location = new System.Drawing.Point(10, 220);
            this.dgvDesgloseRiesgo.Name = "dgvDesgloseRiesgo";
            this.dgvDesgloseRiesgo.Size = new System.Drawing.Size(932, 210);
            this.dgvDesgloseRiesgo.TabIndex = 1;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 560);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblRiskScore);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.lblResultado);
            this.Name = "Form1";
            this.Text = "psRAM_View - Memory Analyzer [Dark Mode]";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; // 👈 NUEVO: Inicia maximizado

            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConexiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlugins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesgloseRiesgo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRiesgo)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabProcesos.ResumeLayout(false);
            this.tabProcesos.PerformLayout();
            this.tabRiesgo.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}