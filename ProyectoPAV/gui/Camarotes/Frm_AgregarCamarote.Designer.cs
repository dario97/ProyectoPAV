namespace ProyectoPAV.gui
{
    partial class Frm_AgregarCamarote
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_cubierta = new System.Windows.Forms.TextBox();
            this.txt_numcam = new System.Windows.Forms.TextBox();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.txt_ubicacion = new System.Windows.Forms.TextBox();
            this.txt_camas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmd_aceptar = new System.Windows.Forms.Button();
            this.cmd_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "AGREGAR CAMAROTE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo de Navio :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de Cubierta :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero de Camarote :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ubicacion :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cantidad de Camas :";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(143, 127);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 0;
            // 
            // txt_cubierta
            // 
            this.txt_cubierta.Location = new System.Drawing.Point(143, 162);
            this.txt_cubierta.Name = "txt_cubierta";
            this.txt_cubierta.Size = new System.Drawing.Size(100, 20);
            this.txt_cubierta.TabIndex = 1;
            // 
            // txt_numcam
            // 
            this.txt_numcam.Location = new System.Drawing.Point(143, 202);
            this.txt_numcam.Name = "txt_numcam";
            this.txt_numcam.Size = new System.Drawing.Size(100, 20);
            this.txt_numcam.TabIndex = 2;
            // 
            // txt_tipo
            // 
            this.txt_tipo.Location = new System.Drawing.Point(410, 127);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(100, 20);
            this.txt_tipo.TabIndex = 3;
            // 
            // txt_ubicacion
            // 
            this.txt_ubicacion.Location = new System.Drawing.Point(410, 159);
            this.txt_ubicacion.Name = "txt_ubicacion";
            this.txt_ubicacion.Size = new System.Drawing.Size(100, 20);
            this.txt_ubicacion.TabIndex = 4;
            // 
            // txt_camas
            // 
            this.txt_camas.Location = new System.Drawing.Point(410, 194);
            this.txt_camas.Name = "txt_camas";
            this.txt_camas.Size = new System.Drawing.Size(100, 20);
            this.txt_camas.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(27, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Datos :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(296, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Caracteristicas :";
            // 
            // cmd_aceptar
            // 
            this.cmd_aceptar.BackColor = System.Drawing.SystemColors.Control;
            this.cmd_aceptar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_aceptar.Location = new System.Drawing.Point(313, 266);
            this.cmd_aceptar.Name = "cmd_aceptar";
            this.cmd_aceptar.Size = new System.Drawing.Size(90, 31);
            this.cmd_aceptar.TabIndex = 6;
            this.cmd_aceptar.Text = "Aceptar";
            this.cmd_aceptar.UseVisualStyleBackColor = true;
            this.cmd_aceptar.Click += new System.EventHandler(this.cmd_aceptar_Click);
            // 
            // cmd_salir
            // 
            this.cmd_salir.BackColor = System.Drawing.SystemColors.Control;
            this.cmd_salir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_salir.Location = new System.Drawing.Point(420, 266);
            this.cmd_salir.Name = "cmd_salir";
            this.cmd_salir.Size = new System.Drawing.Size(90, 31);
            this.cmd_salir.TabIndex = 7;
            this.cmd_salir.Text = "Salir";
            this.cmd_salir.UseVisualStyleBackColor = true;
            this.cmd_salir.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frm_AgregarCamarote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 323);
            this.Controls.Add(this.cmd_salir);
            this.Controls.Add(this.cmd_aceptar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_camas);
            this.Controls.Add(this.txt_ubicacion);
            this.Controls.Add(this.txt_tipo);
            this.Controls.Add(this.txt_numcam);
            this.Controls.Add(this.txt_cubierta);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_AgregarCamarote";
            this.Text = "Agregar Camarote";
            this.Load += new System.EventHandler(this.Frm_AgregarCamarote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_cubierta;
        private System.Windows.Forms.TextBox txt_numcam;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.TextBox txt_ubicacion;
        private System.Windows.Forms.TextBox txt_camas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cmd_aceptar;
        private System.Windows.Forms.Button cmd_salir;
    }
}