namespace ProyectoPAV.gui
{
    partial class Frm_modificacion_tipoNavio
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
            this.botonConfirmar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.txt_tipo = new ProyectoPAV.entidades.TextBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de navío";
            // 
            // botonConfirmar
            // 
            this.botonConfirmar.Location = new System.Drawing.Point(37, 101);
            this.botonConfirmar.Name = "botonConfirmar";
            this.botonConfirmar.Size = new System.Drawing.Size(112, 23);
            this.botonConfirmar.TabIndex = 2;
            this.botonConfirmar.Text = "Confirmar";
            this.botonConfirmar.UseVisualStyleBackColor = true;
            this.botonConfirmar.Click += new System.EventHandler(this.botonConfirmar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(155, 101);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(106, 23);
            this.botonCancelar.TabIndex = 3;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // txt_tipo
            // 
            this.txt_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_tipo.Location = new System.Drawing.Point(126, 59);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.pp_mensaje_error = null;
            this.txt_tipo.pp_nombre_campo = null;
            this.txt_tipo.pp_nombre_tabla = null;
            this.txt_tipo.pp_validar = false;
            this.txt_tipo.Size = new System.Drawing.Size(134, 23);
            this.txt_tipo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(30, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "MODIFICAR TIPO DE NAVIO";
            // 
            // Frm_modificacion_tipoNavio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(301, 147);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tipo);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonConfirmar);
            this.Controls.Add(this.label1);
            this.Name = "Frm_modificacion_tipoNavio";
            this.Text = "Modificar Tipo de Navio";
            this.Load += new System.EventHandler(this.Frm_modificacion_tipoNavio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonConfirmar;
        private System.Windows.Forms.Button botonCancelar;
        private entidades.TextBox01 txt_tipo;
        private System.Windows.Forms.Label label2;
    }
}