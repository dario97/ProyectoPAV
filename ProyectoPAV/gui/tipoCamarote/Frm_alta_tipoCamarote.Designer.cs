namespace ProyectoPAV.gui.tipoCamarote
{
    partial class Frm_alta_tipoCamarote
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
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.bttn_aceptar = new System.Windows.Forms.Button();
            this.bttn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Tipo de Camarote";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo";
            // 
            // txt_tipo
            // 
            this.txt_tipo.Location = new System.Drawing.Point(62, 50);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(156, 20);
            this.txt_tipo.TabIndex = 2;
            // 
            // bttn_aceptar
            // 
            this.bttn_aceptar.Location = new System.Drawing.Point(62, 85);
            this.bttn_aceptar.Name = "bttn_aceptar";
            this.bttn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.bttn_aceptar.TabIndex = 3;
            this.bttn_aceptar.Text = "Crear";
            this.bttn_aceptar.UseVisualStyleBackColor = true;
            this.bttn_aceptar.Click += new System.EventHandler(this.bttn_aceptar_Click);
            // 
            // bttn_cancelar
            // 
            this.bttn_cancelar.Location = new System.Drawing.Point(143, 85);
            this.bttn_cancelar.Name = "bttn_cancelar";
            this.bttn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bttn_cancelar.TabIndex = 4;
            this.bttn_cancelar.Text = "Cancelar";
            this.bttn_cancelar.UseVisualStyleBackColor = true;
            this.bttn_cancelar.Click += new System.EventHandler(this.bttn_cancelar_Click);
            // 
            // Frm_alta_tipoCamarote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 126);
            this.Controls.Add(this.bttn_cancelar);
            this.Controls.Add(this.bttn_aceptar);
            this.Controls.Add(this.txt_tipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_alta_tipoCamarote";
            this.Text = "Frm_alta_tipoCamarote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.Button bttn_aceptar;
        private System.Windows.Forms.Button bttn_cancelar;
    }
}