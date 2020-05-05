namespace ProyectoPAV.gui
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
            this.botonConsultar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.registrarTipo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_tipoNavio = new System.Windows.Forms.Label();
            this.txt_tipoNavio = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonConsultar
            // 
            this.botonConsultar.Location = new System.Drawing.Point(289, 34);
            this.botonConsultar.Name = "botonConsultar";
            this.botonConsultar.Size = new System.Drawing.Size(75, 23);
            this.botonConsultar.TabIndex = 0;
            this.botonConsultar.Text = "Consultar";
            this.botonConsultar.UseVisualStyleBackColor = true;
            this.botonConsultar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.registrarTipo);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label_tipoNavio);
            this.groupBox1.Controls.Add(this.txt_tipoNavio);
            this.groupBox1.Controls.Add(this.botonConsultar);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 307);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos de Navios";
            // 
            // registrarTipo
            // 
            this.registrarTipo.Location = new System.Drawing.Point(6, 219);
            this.registrarTipo.Name = "registrarTipo";
            this.registrarTipo.Size = new System.Drawing.Size(75, 23);
            this.registrarTipo.TabIndex = 4;
            this.registrarTipo.Text = "Crear Tipo";
            this.registrarTipo.UseVisualStyleBackColor = true;
            this.registrarTipo.Click += new System.EventHandler(this.registrarTipo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(358, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // label_tipoNavio
            // 
            this.label_tipoNavio.AutoSize = true;
            this.label_tipoNavio.Location = new System.Drawing.Point(30, 40);
            this.label_tipoNavio.Name = "label_tipoNavio";
            this.label_tipoNavio.Size = new System.Drawing.Size(74, 13);
            this.label_tipoNavio.TabIndex = 2;
            this.label_tipoNavio.Text = "Tipo de navío";
            // 
            // txt_tipoNavio
            // 
            this.txt_tipoNavio.Location = new System.Drawing.Point(110, 37);
            this.txt_tipoNavio.Name = "txt_tipoNavio";
            this.txt_tipoNavio.Size = new System.Drawing.Size(173, 20);
            this.txt_tipoNavio.TabIndex = 1;
            // 
            // frm_abmc_tipoNavio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_abmc_tipoNavio";
            this.Text = "frm_abmc_tipoNavio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonConsultar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_tipoNavio;
        private System.Windows.Forms.TextBox txt_tipoNavio;
        private System.Windows.Forms.Button registrarTipo;
    }
}