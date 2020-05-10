namespace ProyectoPAV.gui
{
    partial class frm_abmc_usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_abmc_usuarios));
            this.cmd_agregar = new System.Windows.Forms.Button();
            this.cmd_editar = new System.Windows.Forms.Button();
            this.cmd_salir = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dvg1 = new System.Windows.Forms.DataGridView();
            this.chk_seleccion = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nroDoc = new System.Windows.Forms.TextBox();
            this.cmd_eliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmd_tipoDoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmd_agregar
            // 
            this.cmd_agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_agregar.BackgroundImage")));
            this.cmd_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_agregar.Location = new System.Drawing.Point(12, 393);
            this.cmd_agregar.Name = "cmd_agregar";
            this.cmd_agregar.Size = new System.Drawing.Size(54, 45);
            this.cmd_agregar.TabIndex = 2;
            this.cmd_agregar.UseVisualStyleBackColor = true;
            this.cmd_agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmd_editar
            // 
            this.cmd_editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_editar.BackgroundImage")));
            this.cmd_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_editar.Location = new System.Drawing.Point(72, 393);
            this.cmd_editar.Name = "cmd_editar";
            this.cmd_editar.Size = new System.Drawing.Size(54, 45);
            this.cmd_editar.TabIndex = 3;
            this.cmd_editar.UseVisualStyleBackColor = true;
            this.cmd_editar.Click += new System.EventHandler(this.cmd_editar_Click);
            // 
            // cmd_salir
            // 
            this.cmd_salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_salir.BackgroundImage")));
            this.cmd_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_salir.Location = new System.Drawing.Point(543, 393);
            this.cmd_salir.Name = "cmd_salir";
            this.cmd_salir.Size = new System.Drawing.Size(54, 45);
            this.cmd_salir.TabIndex = 5;
            this.cmd_salir.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(644, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dvg1
            // 
            this.dvg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg1.Location = new System.Drawing.Point(18, 171);
            this.dvg1.Name = "dvg1";
            this.dvg1.Size = new System.Drawing.Size(573, 210);
            this.dvg1.TabIndex = 1;
            this.dvg1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // chk_seleccion
            // 
            this.chk_seleccion.AutoSize = true;
            this.chk_seleccion.Location = new System.Drawing.Point(78, 148);
            this.chk_seleccion.Name = "chk_seleccion";
            this.chk_seleccion.Size = new System.Drawing.Size(115, 17);
            this.chk_seleccion.TabIndex = 5;
            this.chk_seleccion.Text = "Seleccionar Todos";
            this.chk_seleccion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nro Documento";
            // 
            // txt_nroDoc
            // 
            this.txt_nroDoc.Location = new System.Drawing.Point(167, 122);
            this.txt_nroDoc.Name = "txt_nroDoc";
            this.txt_nroDoc.Size = new System.Drawing.Size(143, 20);
            this.txt_nroDoc.TabIndex = 0;
            // 
            // cmd_eliminar
            // 
            this.cmd_eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_eliminar.BackgroundImage")));
            this.cmd_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_eliminar.Location = new System.Drawing.Point(132, 393);
            this.cmd_eliminar.Name = "cmd_eliminar";
            this.cmd_eliminar.Size = new System.Drawing.Size(54, 45);
            this.cmd_eliminar.TabIndex = 4;
            this.cmd_eliminar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmd_tipoDoc);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 308);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmd_tipoDoc
            // 
            this.cmd_tipoDoc.FormattingEnabled = true;
            this.cmd_tipoDoc.Location = new System.Drawing.Point(155, 17);
            this.cmd_tipoDoc.Name = "cmd_tipoDoc";
            this.cmd_tipoDoc.Size = new System.Drawing.Size(143, 21);
            this.cmd_tipoDoc.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "GESTION DE USUARIOS";
            // 
            // frm_abmc_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmd_eliminar);
            this.Controls.Add(this.txt_nroDoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chk_seleccion);
            this.Controls.Add(this.dvg1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cmd_salir);
            this.Controls.Add(this.cmd_editar);
            this.Controls.Add(this.cmd_agregar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_abmc_usuarios";
            this.Text = "frm_abmc_usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_agregar;
        private System.Windows.Forms.Button cmd_editar;
        private System.Windows.Forms.Button cmd_salir;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dvg1;
        private System.Windows.Forms.CheckBox chk_seleccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nroDoc;
        private System.Windows.Forms.Button cmd_eliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmd_tipoDoc;
        private System.Windows.Forms.Button button1;
    }
}