namespace ProyectoPAV.gui
{
    partial class frm_abmc_itinerario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_abmc_itinerario));
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_consultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.cmd_agregar = new System.Windows.Forms.Button();
            this.cmd_eliminar = new System.Windows.Forms.Button();
            this.cmd_editar = new System.Windows.Forms.Button();
            this.cmd_salir = new System.Windows.Forms.Button();
            this.chk_todos = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTION DE ITINERARIOS";
            // 
            // cmd_consultar
            // 
            this.cmd_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmd_consultar.Location = new System.Drawing.Point(292, 91);
            this.cmd_consultar.Name = "cmd_consultar";
            this.cmd_consultar.Size = new System.Drawing.Size(75, 23);
            this.cmd_consultar.TabIndex = 2;
            this.cmd_consultar.Text = "Consultar";
            this.cmd_consultar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(24, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cod_itinerario";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripcion";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Categoria";
            this.Column3.Name = "Column3";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(90, 69);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(100, 20);
            this.txt_descripcion.TabIndex = 0;
            // 
            // cmd_agregar
            // 
            this.cmd_agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_agregar.BackgroundImage")));
            this.cmd_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_agregar.Location = new System.Drawing.Point(24, 284);
            this.cmd_agregar.Name = "cmd_agregar";
            this.cmd_agregar.Size = new System.Drawing.Size(51, 48);
            this.cmd_agregar.TabIndex = 3;
            this.cmd_agregar.UseVisualStyleBackColor = true;
            // 
            // cmd_eliminar
            // 
            this.cmd_eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_eliminar.BackgroundImage")));
            this.cmd_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_eliminar.Location = new System.Drawing.Point(138, 284);
            this.cmd_eliminar.Name = "cmd_eliminar";
            this.cmd_eliminar.Size = new System.Drawing.Size(52, 48);
            this.cmd_eliminar.TabIndex = 5;
            this.cmd_eliminar.UseVisualStyleBackColor = true;
            // 
            // cmd_editar
            // 
            this.cmd_editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_editar.BackgroundImage")));
            this.cmd_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_editar.Location = new System.Drawing.Point(81, 284);
            this.cmd_editar.Name = "cmd_editar";
            this.cmd_editar.Size = new System.Drawing.Size(51, 48);
            this.cmd_editar.TabIndex = 4;
            this.cmd_editar.UseVisualStyleBackColor = true;
            // 
            // cmd_salir
            // 
            this.cmd_salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_salir.BackgroundImage")));
            this.cmd_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_salir.Location = new System.Drawing.Point(315, 284);
            this.cmd_salir.Name = "cmd_salir";
            this.cmd_salir.Size = new System.Drawing.Size(52, 48);
            this.cmd_salir.TabIndex = 6;
            this.cmd_salir.UseVisualStyleBackColor = true;
            // 
            // chk_todos
            // 
            this.chk_todos.AutoSize = true;
            this.chk_todos.Location = new System.Drawing.Point(90, 95);
            this.chk_todos.Name = "chk_todos";
            this.chk_todos.Size = new System.Drawing.Size(56, 17);
            this.chk_todos.TabIndex = 1;
            this.chk_todos.Text = "Todos";
            this.chk_todos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 225);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // frm_abmc_itinerario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 344);
            this.Controls.Add(this.chk_todos);
            this.Controls.Add(this.cmd_salir);
            this.Controls.Add(this.cmd_editar);
            this.Controls.Add(this.cmd_eliminar);
            this.Controls.Add(this.cmd_agregar);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmd_consultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_abmc_itinerario";
            this.Text = "frm_abmc_itinerario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_consultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Button cmd_agregar;
        private System.Windows.Forms.Button cmd_eliminar;
        private System.Windows.Forms.Button cmd_editar;
        private System.Windows.Forms.Button cmd_salir;
        private System.Windows.Forms.CheckBox chk_todos;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}