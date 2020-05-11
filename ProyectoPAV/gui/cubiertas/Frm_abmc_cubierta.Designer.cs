namespace ProyectoPAV.gui
{
    partial class Frm_abmc_cubierta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_abmc_cubierta));
            this.dvg1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_nroCubierta = new System.Windows.Forms.TextBox();
            this.txt_idNavio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmd_agregar = new System.Windows.Forms.Button();
            this.cmd_editar = new System.Windows.Forms.Button();
            this.cmd_consultar = new System.Windows.Forms.Button();
            this.cmd_eliminar = new System.Windows.Forms.Button();
            this.cmd_salir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chk_todos = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvg1
            // 
            this.dvg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dvg1.Location = new System.Drawing.Point(24, 153);
            this.dvg1.Name = "dvg1";
            this.dvg1.Size = new System.Drawing.Size(543, 178);
            this.dvg1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id Navio";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nro Cubierta";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Descipcion";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Descripcion";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Legajo encargado";
            this.Column5.Name = "Column5";
            // 
            // txt_nroCubierta
            // 
            this.txt_nroCubierta.Location = new System.Drawing.Point(125, 50);
            this.txt_nroCubierta.Name = "txt_nroCubierta";
            this.txt_nroCubierta.Size = new System.Drawing.Size(124, 20);
            this.txt_nroCubierta.TabIndex = 1;
            // 
            // txt_idNavio
            // 
            this.txt_idNavio.Location = new System.Drawing.Point(125, 24);
            this.txt_idNavio.Name = "txt_idNavio";
            this.txt_idNavio.Size = new System.Drawing.Size(124, 20);
            this.txt_idNavio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codigo de navio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero de cubierta";
            // 
            // cmd_agregar
            // 
            this.cmd_agregar.BackColor = System.Drawing.SystemColors.Control;
            this.cmd_agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_agregar.BackgroundImage")));
            this.cmd_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_agregar.Location = new System.Drawing.Point(24, 348);
            this.cmd_agregar.Name = "cmd_agregar";
            this.cmd_agregar.Size = new System.Drawing.Size(63, 60);
            this.cmd_agregar.TabIndex = 5;
            this.cmd_agregar.UseVisualStyleBackColor = false;
            this.cmd_agregar.Click += new System.EventHandler(this.cmd_agregar_Click);
            // 
            // cmd_editar
            // 
            this.cmd_editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_editar.BackgroundImage")));
            this.cmd_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_editar.Location = new System.Drawing.Point(93, 348);
            this.cmd_editar.Name = "cmd_editar";
            this.cmd_editar.Size = new System.Drawing.Size(63, 60);
            this.cmd_editar.TabIndex = 6;
            this.cmd_editar.UseVisualStyleBackColor = true;
            this.cmd_editar.Click += new System.EventHandler(this.cmd_editar_Click);
            // 
            // cmd_consultar
            // 
            this.cmd_consultar.Location = new System.Drawing.Point(455, 106);
            this.cmd_consultar.Name = "cmd_consultar";
            this.cmd_consultar.Size = new System.Drawing.Size(75, 23);
            this.cmd_consultar.TabIndex = 7;
            this.cmd_consultar.Text = "Consultar";
            this.cmd_consultar.UseVisualStyleBackColor = true;
            this.cmd_consultar.Click += new System.EventHandler(this.cmd_consultar_Click);
            // 
            // cmd_eliminar
            // 
            this.cmd_eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_eliminar.BackgroundImage")));
            this.cmd_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_eliminar.Location = new System.Drawing.Point(162, 348);
            this.cmd_eliminar.Name = "cmd_eliminar";
            this.cmd_eliminar.Size = new System.Drawing.Size(63, 60);
            this.cmd_eliminar.TabIndex = 8;
            this.cmd_eliminar.UseVisualStyleBackColor = true;
            this.cmd_eliminar.Click += new System.EventHandler(this.cmd_eliminar_Click);
            // 
            // cmd_salir
            // 
            this.cmd_salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_salir.BackgroundImage")));
            this.cmd_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_salir.Location = new System.Drawing.Point(504, 348);
            this.cmd_salir.Name = "cmd_salir";
            this.cmd_salir.Size = new System.Drawing.Size(63, 60);
            this.cmd_salir.TabIndex = 9;
            this.cmd_salir.UseVisualStyleBackColor = true;
            this.cmd_salir.Click += new System.EventHandler(this.cmd_salir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "GESTION DE CUBIERTAS";
            // 
            // chk_todos
            // 
            this.chk_todos.AutoSize = true;
            this.chk_todos.Location = new System.Drawing.Point(125, 77);
            this.chk_todos.Name = "chk_todos";
            this.chk_todos.Size = new System.Drawing.Size(56, 17);
            this.chk_todos.TabIndex = 11;
            this.chk_todos.Text = "Todos";
            this.chk_todos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_todos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_idNavio);
            this.groupBox1.Controls.Add(this.txt_nroCubierta);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 289);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // Frm_abmc_cubierta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 422);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmd_salir);
            this.Controls.Add(this.cmd_eliminar);
            this.Controls.Add(this.cmd_consultar);
            this.Controls.Add(this.cmd_editar);
            this.Controls.Add(this.cmd_agregar);
            this.Controls.Add(this.dvg1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_abmc_cubierta";
            this.Text = "Frm_abmc_cubierta";
            this.Load += new System.EventHandler(this.Frm_abmc_cubierta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvg1;
        private System.Windows.Forms.TextBox txt_nroCubierta;
        private System.Windows.Forms.TextBox txt_idNavio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button cmd_agregar;
        private System.Windows.Forms.Button cmd_editar;
        private System.Windows.Forms.Button cmd_consultar;
        private System.Windows.Forms.Button cmd_eliminar;
        private System.Windows.Forms.Button cmd_salir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk_todos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip tooltip;
    }
}