﻿namespace ProyectoPAV.gui
{
    partial class frm_abmc_tipoNavio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_abmc_tipoNavio));
            this.botonConsultar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_todos = new System.Windows.Forms.CheckBox();
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonModificar = new System.Windows.Forms.Button();
            this.registrarTipo = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_tipoNavio = new System.Windows.Forms.Label();
            this.txt_tipoNavio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonConsultar
            // 
            this.botonConsultar.Location = new System.Drawing.Point(289, 34);
            this.botonConsultar.Name = "botonConsultar";
            this.botonConsultar.Size = new System.Drawing.Size(75, 23);
            this.botonConsultar.TabIndex = 1;
            this.botonConsultar.Text = "Consultar";
            this.botonConsultar.UseVisualStyleBackColor = true;
            this.botonConsultar.Click += new System.EventHandler(this.botonConsultar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_todos);
            this.groupBox1.Controls.Add(this.botonSalir);
            this.groupBox1.Controls.Add(this.botonEliminar);
            this.groupBox1.Controls.Add(this.botonModificar);
            this.groupBox1.Controls.Add(this.registrarTipo);
            this.groupBox1.Controls.Add(this.dgv1);
            this.groupBox1.Controls.Add(this.label_tipoNavio);
            this.groupBox1.Controls.Add(this.txt_tipoNavio);
            this.groupBox1.Controls.Add(this.botonConsultar);
            this.groupBox1.Location = new System.Drawing.Point(23, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos de Navios";
            // 
            // chk_todos
            // 
            this.chk_todos.AutoSize = true;
            this.chk_todos.Location = new System.Drawing.Point(110, 64);
            this.chk_todos.Name = "chk_todos";
            this.chk_todos.Size = new System.Drawing.Size(56, 17);
            this.chk_todos.TabIndex = 2;
            this.chk_todos.Text = "Todos";
            this.chk_todos.UseVisualStyleBackColor = true;
            // 
            // botonSalir
            // 
            this.botonSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonSalir.BackgroundImage")));
            this.botonSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonSalir.Location = new System.Drawing.Point(315, 243);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(58, 46);
            this.botonSalir.TabIndex = 7;
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonEliminar.BackgroundImage")));
            this.botonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonEliminar.Location = new System.Drawing.Point(141, 242);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(58, 47);
            this.botonEliminar.TabIndex = 6;
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonModificar
            // 
            this.botonModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonModificar.BackgroundImage")));
            this.botonModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonModificar.Location = new System.Drawing.Point(79, 243);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(56, 47);
            this.botonModificar.TabIndex = 5;
            this.botonModificar.UseVisualStyleBackColor = true;
            this.botonModificar.Click += new System.EventHandler(this.botonModificar_Click);
            // 
            // registrarTipo
            // 
            this.registrarTipo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("registrarTipo.BackgroundImage")));
            this.registrarTipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.registrarTipo.Location = new System.Drawing.Point(15, 243);
            this.registrarTipo.Name = "registrarTipo";
            this.registrarTipo.Size = new System.Drawing.Size(58, 47);
            this.registrarTipo.TabIndex = 4;
            this.registrarTipo.UseVisualStyleBackColor = true;
            this.registrarTipo.Click += new System.EventHandler(this.registrarTipo_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion});
            this.dgv1.Location = new System.Drawing.Point(15, 87);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(358, 150);
            this.dgv1.TabIndex = 3;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 400;
            // 
            // label_tipoNavio
            // 
            this.label_tipoNavio.AutoSize = true;
            this.label_tipoNavio.Location = new System.Drawing.Point(30, 40);
            this.label_tipoNavio.Name = "label_tipoNavio";
            this.label_tipoNavio.Size = new System.Drawing.Size(74, 13);
            this.label_tipoNavio.TabIndex = 0;
            this.label_tipoNavio.Text = "Tipo de navío";
            // 
            // txt_tipoNavio
            // 
            this.txt_tipoNavio.Location = new System.Drawing.Point(110, 37);
            this.txt_tipoNavio.Name = "txt_tipoNavio";
            this.txt_tipoNavio.Size = new System.Drawing.Size(173, 20);
            this.txt_tipoNavio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "GESTION DE TIPO NAVIOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frm_abmc_tipoNavio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 377);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_abmc_tipoNavio";
            this.Text = "Buscar Navio";
            //this.Load += new System.EventHandler(this.frm_abmc_tipoNavio_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonConsultar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label_tipoNavio;
        private System.Windows.Forms.TextBox txt_tipoNavio;
        private System.Windows.Forms.Button registrarTipo;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.CheckBox chk_todos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Label label1;
    }
}