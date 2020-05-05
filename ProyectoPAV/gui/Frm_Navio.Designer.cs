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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_navio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(251, 111);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Todos";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            this.dataGridView1.Location = new System.Drawing.Point(30, 155);
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
            // Frm_Navio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_navio);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Frm_Navio";
            this.Text = "Frm_Navio";
            this.Load += new System.EventHandler(this.Frm_Navio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_navio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
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
    }
}