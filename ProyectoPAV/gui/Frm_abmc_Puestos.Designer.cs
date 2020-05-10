namespace ProyectoPAV.gui
{
    partial class Frm_abmc_Puestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_abmc_Puestos));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NombrePuesto = new System.Windows.Forms.TextBox();
            this.cmd_BuscarNombrePuesto = new System.Windows.Forms.Button();
            this.cmd_AgregarPuesto = new System.Windows.Forms.Button();
            this.cmd_BorrarPuesto = new System.Windows.Forms.Button();
            this.cmd_SeleccionarPuesto = new System.Windows.Forms.Button();
            this.cmd_Salir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_seleccion = new System.Windows.Forms.CheckBox();
            this.dvg_MostrarPuestos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_MostrarPuestos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Puesto :";
            // 
            // txt_NombrePuesto
            // 
            this.txt_NombrePuesto.Location = new System.Drawing.Point(137, 70);
            this.txt_NombrePuesto.Name = "txt_NombrePuesto";
            this.txt_NombrePuesto.Size = new System.Drawing.Size(136, 20);
            this.txt_NombrePuesto.TabIndex = 0;
            // 
            // cmd_BuscarNombrePuesto
            // 
            this.cmd_BuscarNombrePuesto.Location = new System.Drawing.Point(298, 67);
            this.cmd_BuscarNombrePuesto.Name = "cmd_BuscarNombrePuesto";
            this.cmd_BuscarNombrePuesto.Size = new System.Drawing.Size(75, 23);
            this.cmd_BuscarNombrePuesto.TabIndex = 1;
            this.cmd_BuscarNombrePuesto.Text = "Consultar";
            this.cmd_BuscarNombrePuesto.UseVisualStyleBackColor = true;
            this.cmd_BuscarNombrePuesto.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmd_AgregarPuesto
            // 
            this.cmd_AgregarPuesto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_AgregarPuesto.BackgroundImage")));
            this.cmd_AgregarPuesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_AgregarPuesto.Location = new System.Drawing.Point(33, 288);
            this.cmd_AgregarPuesto.Name = "cmd_AgregarPuesto";
            this.cmd_AgregarPuesto.Size = new System.Drawing.Size(65, 57);
            this.cmd_AgregarPuesto.TabIndex = 3;
            this.cmd_AgregarPuesto.UseVisualStyleBackColor = true;
            this.cmd_AgregarPuesto.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmd_BorrarPuesto
            // 
            this.cmd_BorrarPuesto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_BorrarPuesto.BackgroundImage")));
            this.cmd_BorrarPuesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_BorrarPuesto.Location = new System.Drawing.Point(175, 288);
            this.cmd_BorrarPuesto.Name = "cmd_BorrarPuesto";
            this.cmd_BorrarPuesto.Size = new System.Drawing.Size(65, 57);
            this.cmd_BorrarPuesto.TabIndex = 4;
            this.cmd_BorrarPuesto.UseVisualStyleBackColor = true;
            // 
            // cmd_SeleccionarPuesto
            // 
            this.cmd_SeleccionarPuesto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_SeleccionarPuesto.BackgroundImage")));
            this.cmd_SeleccionarPuesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_SeleccionarPuesto.Location = new System.Drawing.Point(104, 288);
            this.cmd_SeleccionarPuesto.Name = "cmd_SeleccionarPuesto";
            this.cmd_SeleccionarPuesto.Size = new System.Drawing.Size(65, 57);
            this.cmd_SeleccionarPuesto.TabIndex = 5;
            this.cmd_SeleccionarPuesto.UseVisualStyleBackColor = true;
            this.cmd_SeleccionarPuesto.Click += new System.EventHandler(this.cmd_SeleccionarPuesto_Click);
            // 
            // cmd_Salir
            // 
            this.cmd_Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_Salir.BackgroundImage")));
            this.cmd_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_Salir.Location = new System.Drawing.Point(308, 288);
            this.cmd_Salir.Name = "cmd_Salir";
            this.cmd_Salir.Size = new System.Drawing.Size(65, 57);
            this.cmd_Salir.TabIndex = 6;
            this.cmd_Salir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "GESTION DE PUESTOS";
            // 
            // chk_seleccion
            // 
            this.chk_seleccion.AutoSize = true;
            this.chk_seleccion.Location = new System.Drawing.Point(137, 100);
            this.chk_seleccion.Name = "chk_seleccion";
            this.chk_seleccion.Size = new System.Drawing.Size(56, 17);
            this.chk_seleccion.TabIndex = 7;
            this.chk_seleccion.Text = "Todos";
            this.chk_seleccion.UseVisualStyleBackColor = true;
            // 
            // dvg_MostrarPuestos
            // 
            this.dvg_MostrarPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_MostrarPuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dvg_MostrarPuestos.Location = new System.Drawing.Point(21, 75);
            this.dvg_MostrarPuestos.Name = "dvg_MostrarPuestos";
            this.dvg_MostrarPuestos.Size = new System.Drawing.Size(340, 150);
            this.dvg_MostrarPuestos.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvg_MostrarPuestos);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 234);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // Frm_abmc_Puestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(396, 357);
            this.Controls.Add(this.chk_seleccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmd_Salir);
            this.Controls.Add(this.cmd_SeleccionarPuesto);
            this.Controls.Add(this.cmd_BorrarPuesto);
            this.Controls.Add(this.cmd_AgregarPuesto);
            this.Controls.Add(this.cmd_BuscarNombrePuesto);
            this.Controls.Add(this.txt_NombrePuesto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_abmc_Puestos";
            this.Text = "Puestos";
            ((System.ComponentModel.ISupportInitialize)(this.dvg_MostrarPuestos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NombrePuesto;
        private System.Windows.Forms.Button cmd_BuscarNombrePuesto;
        private System.Windows.Forms.Button cmd_AgregarPuesto;
        private System.Windows.Forms.Button cmd_BorrarPuesto;
        private System.Windows.Forms.Button cmd_SeleccionarPuesto;
        private System.Windows.Forms.Button cmd_Salir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk_seleccion;
        private System.Windows.Forms.DataGridView dvg_MostrarPuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}