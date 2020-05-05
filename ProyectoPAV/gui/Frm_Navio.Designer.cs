namespace ProyectoPAV.gui
{
    partial class Frm_Navio
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
            this.cmd_Consultar = new System.Windows.Forms.Button();
            this.cmd_Agregar = new System.Windows.Forms.Button();
            this.txt_navio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_todos = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eslora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desplazamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autonomia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_de_Camarotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidad_Maxima_de_Pasajeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_de_Motores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_de_Tripulantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clasificación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cubiertas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmd_Modificar = new System.Windows.Forms.Button();
            this.cmd_Eliminar = new System.Windows.Forms.Button();
            this.cmd_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_Consultar
            // 
            this.cmd_Consultar.Location = new System.Drawing.Point(643, 105);
            this.cmd_Consultar.Name = "cmd_Consultar";
            this.cmd_Consultar.Size = new System.Drawing.Size(75, 23);
            this.cmd_Consultar.TabIndex = 0;
            this.cmd_Consultar.Text = "Consultar";
            this.cmd_Consultar.UseVisualStyleBackColor = true;
            this.cmd_Consultar.Click += new System.EventHandler(this.cmd_Consultar_Click);
            // 
            // cmd_Agregar
            // 
            this.cmd_Agregar.Location = new System.Drawing.Point(30, 403);
            this.cmd_Agregar.Name = "cmd_Agregar";
            this.cmd_Agregar.Size = new System.Drawing.Size(75, 23);
            this.cmd_Agregar.TabIndex = 1;
            this.cmd_Agregar.Text = "Agregar";
            this.cmd_Agregar.UseVisualStyleBackColor = true;
            this.cmd_Agregar.Click += new System.EventHandler(this.cmd_Agregar_Click);
            // 
            // txt_navio
            // 
            this.txt_navio.AccessibleName = "txt_navio";
            this.txt_navio.Location = new System.Drawing.Point(251, 70);
            this.txt_navio.Name = "txt_navio";
            this.txt_navio.Size = new System.Drawing.Size(100, 20);
            this.txt_navio.TabIndex = 2;
            this.txt_navio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Navío";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBox_todos
            // 
            this.checkBox_todos.AutoSize = true;
            this.checkBox_todos.Location = new System.Drawing.Point(251, 111);
            this.checkBox_todos.Name = "checkBox_todos";
            this.checkBox_todos.Size = new System.Drawing.Size(56, 17);
            this.checkBox_todos.TabIndex = 5;
            this.checkBox_todos.Text = "Todos";
            this.checkBox_todos.UseVisualStyleBackColor = true;
            this.checkBox_todos.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Altura,
            this.Eslora,
            this.Manga,
            this.Desplazamiento,
            this.Autonomia,
            this.Cantidad_de_Camarotes,
            this.Capacidad_Maxima_de_Pasajeros,
            this.Cantidad_de_Motores,
            this.Cantidad_de_Tripulantes,
            this.Clasificación,
            this.Cubiertas});
            this.dataGridView1.Location = new System.Drawing.Point(30, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 214);
            this.dataGridView1.TabIndex = 6;
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
            // 
            // Altura
            // 
            this.Altura.HeaderText = "Altura";
            this.Altura.Name = "Altura";
            // 
            // Eslora
            // 
            this.Eslora.HeaderText = "Eslora";
            this.Eslora.Name = "Eslora";
            // 
            // Manga
            // 
            this.Manga.HeaderText = "Manga";
            this.Manga.Name = "Manga";
            // 
            // Desplazamiento
            // 
            this.Desplazamiento.HeaderText = "Desplazamiento";
            this.Desplazamiento.Name = "Desplazamiento";
            // 
            // Autonomia
            // 
            this.Autonomia.HeaderText = "Autonomia";
            this.Autonomia.Name = "Autonomia";
            // 
            // Cantidad_de_Camarotes
            // 
            this.Cantidad_de_Camarotes.HeaderText = "Camarotes";
            this.Cantidad_de_Camarotes.Name = "Cantidad_de_Camarotes";
            // 
            // Capacidad_Maxima_de_Pasajeros
            // 
            this.Capacidad_Maxima_de_Pasajeros.HeaderText = "Pasajeros";
            this.Capacidad_Maxima_de_Pasajeros.Name = "Capacidad_Maxima_de_Pasajeros";
            // 
            // Cantidad_de_Motores
            // 
            this.Cantidad_de_Motores.HeaderText = "Motores";
            this.Cantidad_de_Motores.Name = "Cantidad_de_Motores";
            // 
            // Cantidad_de_Tripulantes
            // 
            this.Cantidad_de_Tripulantes.HeaderText = "Tripulantes";
            this.Cantidad_de_Tripulantes.Name = "Cantidad_de_Tripulantes";
            // 
            // Clasificación
            // 
            this.Clasificación.HeaderText = "Clasificacion";
            this.Clasificación.Name = "Clasificación";
            // 
            // Cubiertas
            // 
            this.Cubiertas.HeaderText = "Cubiertas";
            this.Cubiertas.Name = "Cubiertas";
            // 
            // cmd_Modificar
            // 
            this.cmd_Modificar.Location = new System.Drawing.Point(127, 402);
            this.cmd_Modificar.Name = "cmd_Modificar";
            this.cmd_Modificar.Size = new System.Drawing.Size(75, 23);
            this.cmd_Modificar.TabIndex = 7;
            this.cmd_Modificar.Text = "Modificar";
            this.cmd_Modificar.UseVisualStyleBackColor = true;
            // 
            // cmd_Eliminar
            // 
            this.cmd_Eliminar.Location = new System.Drawing.Point(231, 401);
            this.cmd_Eliminar.Name = "cmd_Eliminar";
            this.cmd_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.cmd_Eliminar.TabIndex = 8;
            this.cmd_Eliminar.Text = "Eliminar";
            this.cmd_Eliminar.UseVisualStyleBackColor = true;
            // 
            // cmd_Salir
            // 
            this.cmd_Salir.Location = new System.Drawing.Point(722, 402);
            this.cmd_Salir.Name = "cmd_Salir";
            this.cmd_Salir.Size = new System.Drawing.Size(75, 23);
            this.cmd_Salir.TabIndex = 9;
            this.cmd_Salir.Text = "Salir";
            this.cmd_Salir.UseVisualStyleBackColor = true;
            // 
            // Frm_Navio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmd_Salir);
            this.Controls.Add(this.cmd_Eliminar);
            this.Controls.Add(this.cmd_Modificar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBox_todos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_navio);
            this.Controls.Add(this.cmd_Agregar);
            this.Controls.Add(this.cmd_Consultar);
            this.Name = "Frm_Navio";
            this.Text = "Frm_Navio";
            this.Load += new System.EventHandler(this.Frm_Navio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_Consultar;
        private System.Windows.Forms.Button cmd_Agregar;
        private System.Windows.Forms.TextBox txt_navio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_todos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eslora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desplazamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autonomia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_de_Camarotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacidad_Maxima_de_Pasajeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_de_Motores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_de_Tripulantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clasificación;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cubiertas;
        private System.Windows.Forms.Button cmd_Modificar;
        private System.Windows.Forms.Button cmd_Eliminar;
        private System.Windows.Forms.Button cmd_Salir;
    }
}