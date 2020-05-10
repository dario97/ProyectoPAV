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
            this.dvg1 = new System.Windows.Forms.DataGridView();
            this.txt_nroCubierta = new System.Windows.Forms.TextBox();
            this.txt_idNavio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).BeginInit();
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
            this.dvg1.Location = new System.Drawing.Point(24, 162);
            this.dvg1.Name = "dvg1";
            this.dvg1.Size = new System.Drawing.Size(516, 150);
            this.dvg1.TabIndex = 0;
            // 
            // txt_nroCubierta
            // 
            this.txt_nroCubierta.Location = new System.Drawing.Point(199, 103);
            this.txt_nroCubierta.Name = "txt_nroCubierta";
            this.txt_nroCubierta.Size = new System.Drawing.Size(100, 20);
            this.txt_nroCubierta.TabIndex = 1;
            // 
            // txt_idNavio
            // 
            this.txt_idNavio.Location = new System.Drawing.Point(199, 77);
            this.txt_idNavio.Name = "txt_idNavio";
            this.txt_idNavio.Size = new System.Drawing.Size(100, 20);
            this.txt_idNavio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codigo de navio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero de cubierta";
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
            // Frm_abmc_cubierta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_idNavio);
            this.Controls.Add(this.txt_nroCubierta);
            this.Controls.Add(this.dvg1);
            this.Name = "Frm_abmc_cubierta";
            this.Text = "Frm_abmc_cubierta";
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).EndInit();
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
    }
}