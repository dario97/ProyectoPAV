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
            this.chk_todos = new System.Windows.Forms.CheckBox();
            this.cmd_consultar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.cmd_agregar = new System.Windows.Forms.Button();
            this.cmd_salir = new System.Windows.Forms.Button();
            this.cmd_borrar = new System.Windows.Forms.Button();
            this.cmd_editar = new System.Windows.Forms.Button();
            this.txt_NroCubierta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IdNavio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // chk_todos
            // 
            this.chk_todos.AutoSize = true;
            this.chk_todos.Location = new System.Drawing.Point(130, 88);
            this.chk_todos.Name = "chk_todos";
            this.chk_todos.Size = new System.Drawing.Size(56, 17);
            this.chk_todos.TabIndex = 0;
            this.chk_todos.Text = "Todos";
            this.chk_todos.UseVisualStyleBackColor = true;
            // 
            // cmd_consultar
            // 
            this.cmd_consultar.Location = new System.Drawing.Point(379, 80);
            this.cmd_consultar.Name = "cmd_consultar";
            this.cmd_consultar.Size = new System.Drawing.Size(75, 23);
            this.cmd_consultar.TabIndex = 1;
            this.cmd_consultar.Text = "Consultar";
            this.cmd_consultar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmd_consultar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chk_todos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_IdNavio);
            this.groupBox1.Controls.Add(this.txt_NroCubierta);
            this.groupBox1.Location = new System.Drawing.Point(13, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 276);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv1.Location = new System.Drawing.Point(24, 167);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(443, 150);
            this.dgv1.TabIndex = 3;
            // 
            // cmd_agregar
            // 
            this.cmd_agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_agregar.BackgroundImage")));
            this.cmd_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_agregar.Location = new System.Drawing.Point(24, 342);
            this.cmd_agregar.Name = "cmd_agregar";
            this.cmd_agregar.Size = new System.Drawing.Size(60, 57);
            this.cmd_agregar.TabIndex = 4;
            this.cmd_agregar.UseVisualStyleBackColor = true;
            // 
            // cmd_salir
            // 
            this.cmd_salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_salir.BackgroundImage")));
            this.cmd_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_salir.Location = new System.Drawing.Point(407, 342);
            this.cmd_salir.Name = "cmd_salir";
            this.cmd_salir.Size = new System.Drawing.Size(60, 57);
            this.cmd_salir.TabIndex = 5;
            this.cmd_salir.UseVisualStyleBackColor = true;
            // 
            // cmd_borrar
            // 
            this.cmd_borrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_borrar.BackgroundImage")));
            this.cmd_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_borrar.Location = new System.Drawing.Point(169, 342);
            this.cmd_borrar.Name = "cmd_borrar";
            this.cmd_borrar.Size = new System.Drawing.Size(60, 57);
            this.cmd_borrar.TabIndex = 6;
            this.cmd_borrar.UseVisualStyleBackColor = true;
            // 
            // cmd_editar
            // 
            this.cmd_editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_editar.BackgroundImage")));
            this.cmd_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_editar.Location = new System.Drawing.Point(94, 342);
            this.cmd_editar.Name = "cmd_editar";
            this.cmd_editar.Size = new System.Drawing.Size(60, 57);
            this.cmd_editar.TabIndex = 7;
            this.cmd_editar.UseVisualStyleBackColor = true;
            // 
            // txt_NroCubierta
            // 
            this.txt_NroCubierta.Location = new System.Drawing.Point(130, 62);
            this.txt_NroCubierta.Name = "txt_NroCubierta";
            this.txt_NroCubierta.Size = new System.Drawing.Size(100, 20);
            this.txt_NroCubierta.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Numero de cubierta";
            // 
            // txt_IdNavio
            // 
            this.txt_IdNavio.Location = new System.Drawing.Point(130, 36);
            this.txt_IdNavio.Name = "txt_IdNavio";
            this.txt_IdNavio.Size = new System.Drawing.Size(100, 20);
            this.txt_IdNavio.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Codigo de navio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "GESTION DE CUBIERTAS";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id Navio";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nro cubierta";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Descripcion";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Legajo encargado";
            this.Column4.Name = "Column4";
            // 
            // Frm_abmc_cubierta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 425);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmd_editar);
            this.Controls.Add(this.cmd_borrar);
            this.Controls.Add(this.cmd_salir);
            this.Controls.Add(this.cmd_agregar);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_abmc_cubierta";
            this.Text = "Frm_abmc_cubierta";
            this.Load += new System.EventHandler(this.Frm_abmc_cubierta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_todos;
        private System.Windows.Forms.Button cmd_consultar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button cmd_agregar;
        private System.Windows.Forms.Button cmd_salir;
        private System.Windows.Forms.Button cmd_borrar;
        private System.Windows.Forms.Button cmd_editar;
        private System.Windows.Forms.TextBox txt_NroCubierta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IdNavio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ToolTip tooltip;
    }
}