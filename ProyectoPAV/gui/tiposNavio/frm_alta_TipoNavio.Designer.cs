namespace ProyectoPAV.gui
{
    partial class frm_alta_TipoNavio
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
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botonCrear = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_tipo
            // 
            this.txt_tipo.Location = new System.Drawing.Point(130, 59);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(166, 20);
            this.txt_tipo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(10, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Navío:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(38, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "AGREGAR TIPO DE NAVIO";
            // 
            // botonCrear
            // 
            this.botonCrear.Location = new System.Drawing.Point(130, 94);
            this.botonCrear.Name = "botonCrear";
            this.botonCrear.Size = new System.Drawing.Size(81, 23);
            this.botonCrear.TabIndex = 1;
            this.botonCrear.Text = "Aceptar";
            this.botonCrear.UseVisualStyleBackColor = true;
            this.botonCrear.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(221, 94);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 2;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // frm_alta_TipoNavio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 148);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonCrear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tipo);
            this.Name = "frm_alta_TipoNavio";
            this.Text = "Crear tipo de navío";
            this.Load += new System.EventHandler(this.frm_alta_TipoNavio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonCrear;
        private System.Windows.Forms.Button botonCancelar;
    }
}