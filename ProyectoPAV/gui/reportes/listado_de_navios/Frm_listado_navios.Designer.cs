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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.naviosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_listado_navios = new ProyectoPAV.gui.reportes.listado_de_navios.ds_listado_navios();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_todos = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_tipoNavio = new ProyectoPAV.gui.clases.MiCombito();
            this.cmd_generar = new System.Windows.Forms.Button();
            this.rv_listado_navio = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.naviosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_listado_navios)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(936, 550);
            this.tabControl1.TabIndex = 0;
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
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.naviosBindingSource;
            this.rv_listado_navio.LocalReport.DataSources.Add(reportDataSource2);
            this.rv_listado_navio.LocalReport.ReportEmbeddedResource = "ProyectoPAV.gui.reportes.listado_de_navios.report_design.Listado_navios.rdlc";
            this.rv_listado_navio.Location = new System.Drawing.Point(6, 99);
            this.rv_listado_navio.Name = "rv_listado_navio";
            this.rv_listado_navio.ServerReport.BearerToken = null;
            this.rv_listado_navio.Size = new System.Drawing.Size(916, 419);
            this.rv_listado_navio.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(928, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Estadística Tipos de Navio";
            this.tabPage2.UseVisualStyleBackColor = true;
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
    }
}