﻿namespace ProyectoPAV.gui.tipoCamarote
{
    partial class Frm_abmc_tipoCamarote
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttn_buscar = new System.Windows.Forms.Button();
            this.dgv_tipoCamarote = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_todos = new System.Windows.Forms.CheckBox();
            this.Tipo = new System.Windows.Forms.Label();
            this.bttn_crear = new System.Windows.Forms.Button();
            this.bttn_eliminar = new System.Windows.Forms.Button();
            this.bttn_salir = new System.Windows.Forms.Button();
            this.miCombito1 = new ProyectoPAV.gui.clases.MiCombito();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipoCamarote)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de Tipos de Camarote";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.miCombito1);
            this.groupBox1.Controls.Add(this.bttn_buscar);
            this.groupBox1.Controls.Add(this.dgv_tipoCamarote);
            this.groupBox1.Controls.Add(this.chk_todos);
            this.groupBox1.Controls.Add(this.Tipo);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 197);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // bttn_buscar
            // 
            this.bttn_buscar.Location = new System.Drawing.Point(220, 12);
            this.bttn_buscar.Name = "bttn_buscar";
            this.bttn_buscar.Size = new System.Drawing.Size(75, 21);
            this.bttn_buscar.TabIndex = 5;
            this.bttn_buscar.Text = "Buscar";
            this.bttn_buscar.UseVisualStyleBackColor = true;
            this.bttn_buscar.Click += new System.EventHandler(this.bttn_buscar_Click);
            // 
            // dgv_tipoCamarote
            // 
            this.dgv_tipoCamarote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tipoCamarote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre});
            this.dgv_tipoCamarote.Location = new System.Drawing.Point(6, 67);
            this.dgv_tipoCamarote.Name = "dgv_tipoCamarote";
            this.dgv_tipoCamarote.Size = new System.Drawing.Size(341, 120);
            this.dgv_tipoCamarote.TabIndex = 4;
            this.dgv_tipoCamarote.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // chk_todos
            // 
            this.chk_todos.AutoSize = true;
            this.chk_todos.Location = new System.Drawing.Point(93, 40);
            this.chk_todos.Name = "chk_todos";
            this.chk_todos.Size = new System.Drawing.Size(88, 17);
            this.chk_todos.TabIndex = 3;
            this.chk_todos.Text = "Buscar todos";
            this.chk_todos.UseVisualStyleBackColor = true;
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipo.Location = new System.Drawing.Point(48, 14);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(39, 20);
            this.Tipo.TabIndex = 1;
            this.Tipo.Text = "Tipo";
            // 
            // bttn_crear
            // 
            this.bttn_crear.Location = new System.Drawing.Point(12, 248);
            this.bttn_crear.Name = "bttn_crear";
            this.bttn_crear.Size = new System.Drawing.Size(90, 26);
            this.bttn_crear.TabIndex = 2;
            this.bttn_crear.Text = "Crear";
            this.bttn_crear.UseVisualStyleBackColor = true;
            this.bttn_crear.Click += new System.EventHandler(this.bttn_crear_Click);
            // 
            // bttn_eliminar
            // 
            this.bttn_eliminar.Location = new System.Drawing.Point(108, 248);
            this.bttn_eliminar.Name = "bttn_eliminar";
            this.bttn_eliminar.Size = new System.Drawing.Size(75, 26);
            this.bttn_eliminar.TabIndex = 4;
            this.bttn_eliminar.Text = "Eliminar";
            this.bttn_eliminar.UseVisualStyleBackColor = true;
            this.bttn_eliminar.Click += new System.EventHandler(this.bttn_eliminar_Click);
            // 
            // bttn_salir
            // 
            this.bttn_salir.Location = new System.Drawing.Point(289, 286);
            this.bttn_salir.Name = "bttn_salir";
            this.bttn_salir.Size = new System.Drawing.Size(75, 23);
            this.bttn_salir.TabIndex = 5;
            this.bttn_salir.Text = "Salir";
            this.bttn_salir.UseVisualStyleBackColor = true;
            this.bttn_salir.Click += new System.EventHandler(this.bttn_salir_Click);
            // 
            // miCombito1
            // 
            this.miCombito1.FormattingEnabled = true;
            this.miCombito1.Location = new System.Drawing.Point(93, 13);
            this.miCombito1.Name = "miCombito1";
            this.miCombito1.pp_descriptor_tabla_cargar = "Nombre";
            this.miCombito1.pp_nombre_campo = null;
            this.miCombito1.pp_nombre_tabla = "";
            this.miCombito1.pp_nombre_tabla_cargar = "TIPO_CAMAROTE";
            this.miCombito1.pp_pk_tabla_cargar = "Tipo";
            this.miCombito1.pp_validar = false;
            this.miCombito1.Size = new System.Drawing.Size(121, 21);
            this.miCombito1.TabIndex = 7;
            // 
            // Frm_abmc_tipoCamarote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 312);
            this.Controls.Add(this.bttn_salir);
            this.Controls.Add(this.bttn_eliminar);
            this.Controls.Add(this.bttn_crear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_abmc_tipoCamarote";
            this.Text = "Gestión de Tipos de Camarotes";
            this.Load += new System.EventHandler(this.Frm_abmc_tipoCamarote_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipoCamarote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttn_buscar;
        private System.Windows.Forms.DataGridView dgv_tipoCamarote;
        private System.Windows.Forms.CheckBox chk_todos;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.Button bttn_crear;
        private System.Windows.Forms.Button bttn_eliminar;
        private System.Windows.Forms.Button bttn_salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private clases.MiCombito miCombito1;
    }
}