namespace ProyectoPAV.gui.itinerarios
{
    partial class Frm_gestionarItinerarios
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
            this.cmb_itinerarios = new ProyectoPAV.gui.clases.MiCombito();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_itinerarios = new System.Windows.Forms.DataGridView();
            this.Cod_itinerario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_escalas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmd_Buscar = new System.Windows.Forms.Button();
            this.cmd_agregar = new System.Windows.Forms.Button();
            this.cmd_modificar = new System.Windows.Forms.Button();
            this.cmd_eliminar = new System.Windows.Forms.Button();
            this.cmd_salir = new System.Windows.Forms.Button();
            this.chk_todos = new System.Windows.Forms.CheckBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_escala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_puerto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itinerarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_escalas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "GESTIÓN DE ITINERARIOS";
            // 
            // cmb_itinerarios
            // 
            this.cmb_itinerarios.FormattingEnabled = true;
            this.cmb_itinerarios.Location = new System.Drawing.Point(104, 67);
            this.cmb_itinerarios.Name = "cmb_itinerarios";
            this.cmb_itinerarios.pp_descriptor_tabla_cargar = "Descripcion";
            this.cmb_itinerarios.pp_nombre_campo = null;
            this.cmb_itinerarios.pp_nombre_tabla = null;
            this.cmb_itinerarios.pp_nombre_tabla_cargar = "ITINERARIOS";
            this.cmb_itinerarios.pp_pk_tabla_cargar = "Cod_itinerario";
            this.cmb_itinerarios.pp_validar = false;
            this.cmb_itinerarios.Size = new System.Drawing.Size(121, 21);
            this.cmb_itinerarios.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Itinerario";
            // 
            // dgv_itinerarios
            // 
            this.dgv_itinerarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_itinerarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_itinerario,
            this.Descripcion,
            this.Categoria});
            this.dgv_itinerarios.Location = new System.Drawing.Point(37, 142);
            this.dgv_itinerarios.Name = "dgv_itinerarios";
            this.dgv_itinerarios.Size = new System.Drawing.Size(342, 150);
            this.dgv_itinerarios.TabIndex = 4;
            // 
            // Cod_itinerario
            // 
            this.Cod_itinerario.HeaderText = "Cod. Itinerario";
            this.Cod_itinerario.Name = "Cod_itinerario";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.Name = "Categoria";
            // 
            // dgv_escalas
            // 
            this.dgv_escalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_escalas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Num_escala,
            this.Cod_puerto});
            this.dgv_escalas.Location = new System.Drawing.Point(38, 318);
            this.dgv_escalas.Name = "dgv_escalas";
            this.dgv_escalas.Size = new System.Drawing.Size(342, 150);
            this.dgv_escalas.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Escalas";
            // 
            // cmd_Buscar
            // 
            this.cmd_Buscar.Location = new System.Drawing.Point(231, 65);
            this.cmd_Buscar.Name = "cmd_Buscar";
            this.cmd_Buscar.Size = new System.Drawing.Size(75, 23);
            this.cmd_Buscar.TabIndex = 7;
            this.cmd_Buscar.Text = "Buscar";
            this.cmd_Buscar.UseVisualStyleBackColor = true;
            this.cmd_Buscar.Click += new System.EventHandler(this.cmd_Buscar_Click);
            // 
            // cmd_agregar
            // 
            this.cmd_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_agregar.Location = new System.Drawing.Point(38, 474);
            this.cmd_agregar.Name = "cmd_agregar";
            this.cmd_agregar.Size = new System.Drawing.Size(75, 38);
            this.cmd_agregar.TabIndex = 8;
            this.cmd_agregar.Text = "Registrar Itinerario";
            this.cmd_agregar.UseVisualStyleBackColor = true;
            this.cmd_agregar.Click += new System.EventHandler(this.cmd_agregar_Click);
            // 
            // cmd_modificar
            // 
            this.cmd_modificar.Location = new System.Drawing.Point(121, 474);
            this.cmd_modificar.Name = "cmd_modificar";
            this.cmd_modificar.Size = new System.Drawing.Size(75, 38);
            this.cmd_modificar.TabIndex = 9;
            this.cmd_modificar.Text = "Modificar Itinerario";
            this.cmd_modificar.UseVisualStyleBackColor = true;
            // 
            // cmd_eliminar
            // 
            this.cmd_eliminar.Location = new System.Drawing.Point(202, 474);
            this.cmd_eliminar.Name = "cmd_eliminar";
            this.cmd_eliminar.Size = new System.Drawing.Size(75, 38);
            this.cmd_eliminar.TabIndex = 10;
            this.cmd_eliminar.Text = "Eliminar Itinerario";
            this.cmd_eliminar.UseVisualStyleBackColor = true;
            // 
            // cmd_salir
            // 
            this.cmd_salir.Location = new System.Drawing.Point(305, 473);
            this.cmd_salir.Name = "cmd_salir";
            this.cmd_salir.Size = new System.Drawing.Size(75, 39);
            this.cmd_salir.TabIndex = 11;
            this.cmd_salir.Text = "Salir";
            this.cmd_salir.UseVisualStyleBackColor = true;
            // 
            // chk_todos
            // 
            this.chk_todos.AutoSize = true;
            this.chk_todos.Location = new System.Drawing.Point(104, 94);
            this.chk_todos.Name = "chk_todos";
            this.chk_todos.Size = new System.Drawing.Size(88, 17);
            this.chk_todos.TabIndex = 12;
            this.chk_todos.Text = "Buscar todos";
            this.chk_todos.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // Num_escala
            // 
            this.Num_escala.HeaderText = "Núm. Escala";
            this.Num_escala.Name = "Num_escala";
            // 
            // Cod_puerto
            // 
            this.Cod_puerto.HeaderText = "Puerto";
            this.Cod_puerto.Name = "Cod_puerto";
            // 
            // Frm_gestionarItinerarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 568);
            this.Controls.Add(this.chk_todos);
            this.Controls.Add(this.cmd_salir);
            this.Controls.Add(this.cmd_eliminar);
            this.Controls.Add(this.cmd_modificar);
            this.Controls.Add(this.cmd_agregar);
            this.Controls.Add(this.cmd_Buscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_escalas);
            this.Controls.Add(this.dgv_itinerarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_itinerarios);
            this.Controls.Add(this.label1);
            this.Name = "Frm_gestionarItinerarios";
            this.Text = "Gestión de Itinerarios";
            this.Load += new System.EventHandler(this.Frm_gestionarItinerarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itinerarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_escalas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private clases.MiCombito cmb_itinerarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_itinerarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_itinerario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridView dgv_escalas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmd_Buscar;
        private System.Windows.Forms.Button cmd_agregar;
        private System.Windows.Forms.Button cmd_modificar;
        private System.Windows.Forms.Button cmd_eliminar;
        private System.Windows.Forms.Button cmd_salir;
        private System.Windows.Forms.CheckBox chk_todos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_escala;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_puerto;
    }
}