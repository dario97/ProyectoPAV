namespace ProyectoPAV.gui.reportes
{
    partial class Frm_listado_navios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.naviosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_listado_navios = new ProyectoPAV.gui.reportes.listado_de_navios.ds_listado_navios();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_todos = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_generar = new System.Windows.Forms.Button();
            this.rv_listado_navio = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart_tipoNavioBarras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmd_generar_estadTipoNavio = new System.Windows.Forms.Button();
            this.chart_tiposNavio = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmd_generarEstNavios = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_campos = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb_top10 = new System.Windows.Forms.RadioButton();
            this.rdb_top5 = new System.Windows.Forms.RadioButton();
            this.chart_navios = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmb_tipoNavio = new ProyectoPAV.gui.clases.MiCombito();
            ((System.ComponentModel.ISupportInitialize)(this.naviosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_listado_navios)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_tipoNavioBarras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_tiposNavio)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_navios)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // naviosBindingSource
            // 
            this.naviosBindingSource.DataMember = "Navios";
            this.naviosBindingSource.DataSource = this.ds_listado_navios;
            // 
            // ds_listado_navios
            // 
            this.ds_listado_navios.DataSetName = "ds_listado_navios";
            this.ds_listado_navios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(936, 550);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.rv_listado_navio);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(928, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado de Navios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_todos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_tipoNavio);
            this.groupBox1.Controls.Add(this.cmd_generar);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 87);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // chk_todos
            // 
            this.chk_todos.AutoSize = true;
            this.chk_todos.Location = new System.Drawing.Point(9, 63);
            this.chk_todos.Name = "chk_todos";
            this.chk_todos.Size = new System.Drawing.Size(88, 17);
            this.chk_todos.TabIndex = 4;
            this.chk_todos.Text = "Buscar todos";
            this.chk_todos.UseVisualStyleBackColor = true;
            this.chk_todos.CheckedChanged += new System.EventHandler(this.chk_todos_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de Navio";
            // 
            // cmd_generar
            // 
            this.cmd_generar.Location = new System.Drawing.Point(152, 36);
            this.cmd_generar.Name = "cmd_generar";
            this.cmd_generar.Size = new System.Drawing.Size(75, 23);
            this.cmd_generar.TabIndex = 1;
            this.cmd_generar.Text = "Generar";
            this.cmd_generar.UseVisualStyleBackColor = true;
            this.cmd_generar.Click += new System.EventHandler(this.cmd_generar_Click);
            // 
            // rv_listado_navio
            // 
            this.rv_listado_navio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv_listado_navio.DocumentMapWidth = 84;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.naviosBindingSource;
            this.rv_listado_navio.LocalReport.DataSources.Add(reportDataSource1);
            this.rv_listado_navio.LocalReport.ReportEmbeddedResource = "ProyectoPAV.gui.reportes.listado_de_navios.report_design.Listado_navios.rdlc";
            this.rv_listado_navio.Location = new System.Drawing.Point(6, 99);
            this.rv_listado_navio.Name = "rv_listado_navio";
            this.rv_listado_navio.ServerReport.BearerToken = null;
            this.rv_listado_navio.Size = new System.Drawing.Size(916, 419);
            this.rv_listado_navio.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(928, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Estadística Tipos de Navio";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart_tipoNavioBarras
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_tipoNavioBarras.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_tipoNavioBarras.Legends.Add(legend2);
            this.chart_tipoNavioBarras.Location = new System.Drawing.Point(339, 25);
            this.chart_tipoNavioBarras.Name = "chart_tipoNavioBarras";
            series2.ChartArea = "ChartArea1";
            series2.LabelBackColor = System.Drawing.Color.SteelBlue;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_tipoNavioBarras.Series.Add(series2);
            this.chart_tipoNavioBarras.Size = new System.Drawing.Size(300, 300);
            this.chart_tipoNavioBarras.TabIndex = 2;
            this.chart_tipoNavioBarras.Text = "chart1";
            // 
            // cmd_generar_estadTipoNavio
            // 
            this.cmd_generar_estadTipoNavio.Location = new System.Drawing.Point(752, 329);
            this.cmd_generar_estadTipoNavio.Name = "cmd_generar_estadTipoNavio";
            this.cmd_generar_estadTipoNavio.Size = new System.Drawing.Size(75, 23);
            this.cmd_generar_estadTipoNavio.TabIndex = 1;
            this.cmd_generar_estadTipoNavio.Text = "Generar";
            this.cmd_generar_estadTipoNavio.UseVisualStyleBackColor = true;
            this.cmd_generar_estadTipoNavio.Click += new System.EventHandler(this.cmd_generar_estadTipoNavio_Click);
            // 
            // chart_tiposNavio
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_tiposNavio.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_tiposNavio.Legends.Add(legend1);
            this.chart_tiposNavio.Location = new System.Drawing.Point(33, 25);
            this.chart_tiposNavio.Name = "chart_tiposNavio";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1231";
            this.chart_tiposNavio.Series.Add(series1);
            this.chart_tiposNavio.Size = new System.Drawing.Size(300, 300);
            this.chart_tiposNavio.TabIndex = 0;
            this.chart_tiposNavio.Text = "chart1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.chart_navios);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(928, 524);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Estadísticas Navios";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmd_generarEstNavios);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmb_campos);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(17, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 176);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selección";
            // 
            // cmd_generarEstNavios
            // 
            this.cmd_generarEstNavios.Location = new System.Drawing.Point(325, 147);
            this.cmd_generarEstNavios.Name = "cmd_generarEstNavios";
            this.cmd_generarEstNavios.Size = new System.Drawing.Size(75, 23);
            this.cmd_generarEstNavios.TabIndex = 3;
            this.cmd_generarEstNavios.Text = "Generar";
            this.cmd_generarEstNavios.UseVisualStyleBackColor = true;
            this.cmd_generarEstNavios.Click += new System.EventHandler(this.cmd_generarEstNavios_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Campo de selecciòn";
            // 
            // cmb_campos
            // 
            this.cmb_campos.FormattingEnabled = true;
            this.cmb_campos.Items.AddRange(new object[] {
            "Autonomia",
            "Cantidad de pasajeros",
            "Cantidad de tripulantes"});
            this.cmb_campos.Location = new System.Drawing.Point(6, 39);
            this.cmb_campos.Name = "cmb_campos";
            this.cmb_campos.Size = new System.Drawing.Size(121, 21);
            this.cmb_campos.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdb_top10);
            this.groupBox2.Controls.Add(this.rdb_top5);
            this.groupBox2.Location = new System.Drawing.Point(6, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Top";
            // 
            // rdb_top10
            // 
            this.rdb_top10.AutoSize = true;
            this.rdb_top10.Location = new System.Drawing.Point(26, 57);
            this.rdb_top10.Name = "rdb_top10";
            this.rdb_top10.Size = new System.Drawing.Size(80, 17);
            this.rdb_top10.TabIndex = 1;
            this.rdb_top10.TabStop = true;
            this.rdb_top10.Text = "Primeros 10";
            this.rdb_top10.UseVisualStyleBackColor = true;
            // 
            // rdb_top5
            // 
            this.rdb_top5.AutoSize = true;
            this.rdb_top5.Location = new System.Drawing.Point(26, 33);
            this.rdb_top5.Name = "rdb_top5";
            this.rdb_top5.Size = new System.Drawing.Size(74, 17);
            this.rdb_top5.TabIndex = 0;
            this.rdb_top5.TabStop = true;
            this.rdb_top5.Text = "Primeros 5";
            this.rdb_top5.UseVisualStyleBackColor = true;
            // 
            // chart_navios
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_navios.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_navios.Legends.Add(legend3);
            this.chart_navios.Location = new System.Drawing.Point(452, 17);
            this.chart_navios.Name = "chart_navios";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.LabelBackColor = System.Drawing.SystemColors.MenuHighlight;
            series3.LabelBorderWidth = 4;
            series3.Legend = "Legend1";
            series3.Name = "Navios";
            this.chart_navios.Series.Add(series3);
            this.chart_navios.Size = new System.Drawing.Size(473, 437);
            this.chart_navios.TabIndex = 0;
            this.chart_navios.Text = "chart1";
            title1.Name = "dsadas";
            this.chart_navios.Titles.Add(title1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Estadísticas de Tipo de Navios";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chart_tiposNavio);
            this.groupBox4.Controls.Add(this.chart_tipoNavioBarras);
            this.groupBox4.Controls.Add(this.cmd_generar_estadTipoNavio);
            this.groupBox4.Location = new System.Drawing.Point(31, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(833, 358);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gráficos";
            // 
            // cmb_tipoNavio
            // 
            this.cmb_tipoNavio.FormattingEnabled = true;
            this.cmb_tipoNavio.Location = new System.Drawing.Point(9, 36);
            this.cmb_tipoNavio.Name = "cmb_tipoNavio";
            this.cmb_tipoNavio.pp_descriptor_tabla_cargar = "Descripcion";
            this.cmb_tipoNavio.pp_nombre_campo = null;
            this.cmb_tipoNavio.pp_nombre_tabla = null;
            this.cmb_tipoNavio.pp_nombre_tabla_cargar = "CLASIFICACION_NAVIO";
            this.cmb_tipoNavio.pp_pk_tabla_cargar = "Cod_clasificacion";
            this.cmb_tipoNavio.pp_validar = false;
            this.cmb_tipoNavio.Size = new System.Drawing.Size(121, 21);
            this.cmb_tipoNavio.TabIndex = 2;
            // 
            // Frm_listado_navios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 574);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_listado_navios";
            this.Text = "Reportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.naviosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_listado_navios)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_tipoNavioBarras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_tiposNavio)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_navios)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer rv_listado_navio;
        private System.Windows.Forms.BindingSource naviosBindingSource;
        private listado_de_navios.ds_listado_navios ds_listado_navios;
        private System.Windows.Forms.GroupBox groupBox1;
        private clases.MiCombito cmb_tipoNavio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_generar;
        private System.Windows.Forms.CheckBox chk_todos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button cmd_generar_estadTipoNavio;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_tiposNavio;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_tipoNavioBarras;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmd_generarEstNavios;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdb_top10;
        private System.Windows.Forms.RadioButton rdb_top5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_navios;
        private System.Windows.Forms.ComboBox cmb_campos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}