namespace ProyectoPAV.gui
{
    partial class Frm_Modificar_Usuario
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
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pais = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.cmd_cancelar = new System.Windows.Forms.Button();
            this.cmd_aceptar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_nroDoc = new System.Windows.Forms.TextBox();
            this.cmd_tipoDoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pais de procdenencia";
            // 
            // txt_pais
            // 
            this.txt_pais.Location = new System.Drawing.Point(172, 198);
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.Size = new System.Drawing.Size(164, 20);
            this.txt_pais.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ciudad de procedencia";
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Location = new System.Drawing.Point(172, 167);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(165, 20);
            this.txt_ciudad.TabIndex = 4;
            // 
            // cmd_cancelar
            // 
            this.cmd_cancelar.Location = new System.Drawing.Point(262, 239);
            this.cmd_cancelar.Name = "cmd_cancelar";
            this.cmd_cancelar.Size = new System.Drawing.Size(75, 23);
            this.cmd_cancelar.TabIndex = 7;
            this.cmd_cancelar.Text = "Cancelar";
            this.cmd_cancelar.UseVisualStyleBackColor = true;
            // 
            // cmd_aceptar
            // 
            this.cmd_aceptar.Location = new System.Drawing.Point(172, 239);
            this.cmd_aceptar.Name = "cmd_aceptar";
            this.cmd_aceptar.Size = new System.Drawing.Size(75, 23);
            this.cmd_aceptar.TabIndex = 6;
            this.cmd_aceptar.Text = "Aceptar";
            this.cmd_aceptar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tipo Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nro Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(172, 88);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(164, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // txt_nroDoc
            // 
            this.txt_nroDoc.Location = new System.Drawing.Point(172, 114);
            this.txt_nroDoc.Name = "txt_nroDoc";
            this.txt_nroDoc.Size = new System.Drawing.Size(164, 20);
            this.txt_nroDoc.TabIndex = 2;
            // 
            // cmd_tipoDoc
            // 
            this.cmd_tipoDoc.FormattingEnabled = true;
            this.cmd_tipoDoc.Location = new System.Drawing.Point(172, 140);
            this.cmd_tipoDoc.Name = "cmd_tipoDoc";
            this.cmd_tipoDoc.Size = new System.Drawing.Size(164, 21);
            this.cmd_tipoDoc.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "MODIFICAR USUARIO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Frm_Modificar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 306);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_pais);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ciudad);
            this.Controls.Add(this.cmd_cancelar);
            this.Controls.Add(this.cmd_aceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_nroDoc);
            this.Controls.Add(this.cmd_tipoDoc);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Modificar_Usuario";
            this.Text = "3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_pais;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.Button cmd_cancelar;
        private System.Windows.Forms.Button cmd_aceptar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_nroDoc;
        private System.Windows.Forms.ComboBox cmd_tipoDoc;
        private System.Windows.Forms.Label label1;
    }
}