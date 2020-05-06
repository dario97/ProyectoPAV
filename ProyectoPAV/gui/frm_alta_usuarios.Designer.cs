namespace ProyectoPAV.gui
{
    partial class frm_alta_usuarios
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
            this.cmd_tipoDoc = new System.Windows.Forms.ComboBox();
            this.txt_nroDoc = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmd_crear = new System.Windows.Forms.Button();
            this.cmd_cancelar = new System.Windows.Forms.Button();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pais = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREAR NUEVO USUARIO";
            // 
            // cmd_tipoDoc
            // 
            this.cmd_tipoDoc.FormattingEnabled = true;
            this.cmd_tipoDoc.Location = new System.Drawing.Point(133, 125);
            this.cmd_tipoDoc.Name = "cmd_tipoDoc";
            this.cmd_tipoDoc.Size = new System.Drawing.Size(164, 21);
            this.cmd_tipoDoc.TabIndex = 1;
            // 
            // txt_nroDoc
            // 
            this.txt_nroDoc.Location = new System.Drawing.Point(133, 99);
            this.txt_nroDoc.Name = "txt_nroDoc";
            this.txt_nroDoc.Size = new System.Drawing.Size(164, 20);
            this.txt_nroDoc.TabIndex = 2;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(133, 73);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(164, 20);
            this.txt_nombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nro Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo Documento";
            // 
            // cmd_crear
            // 
            this.cmd_crear.Location = new System.Drawing.Point(133, 224);
            this.cmd_crear.Name = "cmd_crear";
            this.cmd_crear.Size = new System.Drawing.Size(75, 23);
            this.cmd_crear.TabIndex = 7;
            this.cmd_crear.Text = "Crear";
            this.cmd_crear.UseVisualStyleBackColor = true;
            // 
            // cmd_cancelar
            // 
            this.cmd_cancelar.Location = new System.Drawing.Point(223, 224);
            this.cmd_cancelar.Name = "cmd_cancelar";
            this.cmd_cancelar.Size = new System.Drawing.Size(75, 23);
            this.cmd_cancelar.TabIndex = 8;
            this.cmd_cancelar.Text = "Cancelar";
            this.cmd_cancelar.UseVisualStyleBackColor = true;
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Location = new System.Drawing.Point(133, 152);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(165, 20);
            this.txt_ciudad.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ciudad de procedencia";
            // 
            // txt_pais
            // 
            this.txt_pais.Location = new System.Drawing.Point(133, 183);
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.Size = new System.Drawing.Size(164, 20);
            this.txt_pais.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pais de procdenencia";
            // 
            // frm_alta_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 266);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_pais);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ciudad);
            this.Controls.Add(this.cmd_cancelar);
            this.Controls.Add(this.cmd_crear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_nroDoc);
            this.Controls.Add(this.cmd_tipoDoc);
            this.Controls.Add(this.label1);
            this.Name = "frm_alta_usuarios";
            this.Text = "frm_alta_usuarios";
            this.Load += new System.EventHandler(this.frm_alta_usuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmd_tipoDoc;
        private System.Windows.Forms.TextBox txt_nroDoc;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmd_crear;
        private System.Windows.Forms.Button cmd_cancelar;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_pais;
        private System.Windows.Forms.Label label6;
    }
}