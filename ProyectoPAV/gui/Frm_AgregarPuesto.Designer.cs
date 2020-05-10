namespace ProyectoPAV.gui
{
    partial class Frm_AgregarPuesto
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NombrePuesto = new System.Windows.Forms.TextBox();
            this.cmd_ConfirmaAgregarPuesto = new System.Windows.Forms.Button();
            this.cmd_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "AGREGAR PUESTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de Puesto :";
            // 
            // txt_NombrePuesto
            // 
            this.txt_NombrePuesto.Location = new System.Drawing.Point(122, 75);
            this.txt_NombrePuesto.Name = "txt_NombrePuesto";
            this.txt_NombrePuesto.Size = new System.Drawing.Size(156, 20);
            this.txt_NombrePuesto.TabIndex = 0;
            // 
            // cmd_ConfirmaAgregarPuesto
            // 
            this.cmd_ConfirmaAgregarPuesto.Location = new System.Drawing.Point(122, 118);
            this.cmd_ConfirmaAgregarPuesto.Name = "cmd_ConfirmaAgregarPuesto";
            this.cmd_ConfirmaAgregarPuesto.Size = new System.Drawing.Size(75, 23);
            this.cmd_ConfirmaAgregarPuesto.TabIndex = 1;
            this.cmd_ConfirmaAgregarPuesto.Text = "Agregar";
            this.cmd_ConfirmaAgregarPuesto.UseVisualStyleBackColor = true;
            // 
            // cmd_Salir
            // 
            this.cmd_Salir.Location = new System.Drawing.Point(203, 118);
            this.cmd_Salir.Name = "cmd_Salir";
            this.cmd_Salir.Size = new System.Drawing.Size(75, 23);
            this.cmd_Salir.TabIndex = 2;
            this.cmd_Salir.Text = "Salir";
            this.cmd_Salir.UseVisualStyleBackColor = true;
            this.cmd_Salir.Click += new System.EventHandler(this.cmd_Salir_Click);
            // 
            // Frm_AgregarPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 160);
            this.Controls.Add(this.cmd_Salir);
            this.Controls.Add(this.cmd_ConfirmaAgregarPuesto);
            this.Controls.Add(this.txt_NombrePuesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_AgregarPuesto";
            this.Text = "Agregar Puesto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NombrePuesto;
        private System.Windows.Forms.Button cmd_ConfirmaAgregarPuesto;
        private System.Windows.Forms.Button cmd_Salir;
    }
}