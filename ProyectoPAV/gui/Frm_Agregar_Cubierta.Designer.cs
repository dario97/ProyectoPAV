namespace ProyectoPAV.gui
{
    partial class Frm_Agregar_Cubierta
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
            this.txt_codNavio = new System.Windows.Forms.TextBox();
            this.txt_numCubierta = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_legEncargado = new System.Windows.Forms.TextBox();
            this.cmd_aceptar = new System.Windows.Forms.Button();
            this.cmd_cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "AGREGAR CUBIERTA";
            // 
            // txt_codNavio
            // 
            this.txt_codNavio.Location = new System.Drawing.Point(140, 66);
            this.txt_codNavio.Name = "txt_codNavio";
            this.txt_codNavio.Size = new System.Drawing.Size(144, 20);
            this.txt_codNavio.TabIndex = 1;
            // 
            // txt_numCubierta
            // 
            this.txt_numCubierta.Location = new System.Drawing.Point(140, 92);
            this.txt_numCubierta.Name = "txt_numCubierta";
            this.txt_numCubierta.Size = new System.Drawing.Size(144, 20);
            this.txt_numCubierta.TabIndex = 2;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(140, 118);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(144, 20);
            this.txt_descripcion.TabIndex = 3;
            // 
            // txt_legEncargado
            // 
            this.txt_legEncargado.Location = new System.Drawing.Point(140, 144);
            this.txt_legEncargado.Name = "txt_legEncargado";
            this.txt_legEncargado.Size = new System.Drawing.Size(144, 20);
            this.txt_legEncargado.TabIndex = 4;
            // 
            // cmd_aceptar
            // 
            this.cmd_aceptar.Location = new System.Drawing.Point(128, 202);
            this.cmd_aceptar.Name = "cmd_aceptar";
            this.cmd_aceptar.Size = new System.Drawing.Size(75, 23);
            this.cmd_aceptar.TabIndex = 5;
            this.cmd_aceptar.Text = "Aceptar";
            this.cmd_aceptar.UseVisualStyleBackColor = true;
            // 
            // cmd_cancelar
            // 
            this.cmd_cancelar.Location = new System.Drawing.Point(209, 202);
            this.cmd_cancelar.Name = "cmd_cancelar";
            this.cmd_cancelar.Size = new System.Drawing.Size(75, 23);
            this.cmd_cancelar.TabIndex = 6;
            this.cmd_cancelar.Text = "Cancelar";
            this.cmd_cancelar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(52, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Navio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(52, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(52, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(52, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Encargado";
            // 
            // Frm_Agregar_Cubierta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmd_cancelar);
            this.Controls.Add(this.cmd_aceptar);
            this.Controls.Add(this.txt_legEncargado);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_numCubierta);
            this.Controls.Add(this.txt_codNavio);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Agregar_Cubierta";
            this.Text = "Frm_Agregar_Cubierta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_codNavio;
        private System.Windows.Forms.TextBox txt_numCubierta;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_legEncargado;
        private System.Windows.Forms.Button cmd_aceptar;
        private System.Windows.Forms.Button cmd_cancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}