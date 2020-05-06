namespace ProyectoPAV.gui
{
    partial class Frm_Baja_Puerto
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
            this.txt_nombre = new ProyectoPAV.entidades.TextBox01();
            this.cmd_aceptar = new System.Windows.Forms.Button();
            this.cmd_cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_nombre.Location = new System.Drawing.Point(134, 42);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.pp_mensaje_error = null;
            this.txt_nombre.pp_nombre_campo = null;
            this.txt_nombre.pp_nombre_tabla = null;
            this.txt_nombre.pp_validar = false;
            this.txt_nombre.Size = new System.Drawing.Size(100, 23);
            this.txt_nombre.TabIndex = 0;
            // 
            // cmd_aceptar
            // 
            this.cmd_aceptar.Location = new System.Drawing.Point(47, 138);
            this.cmd_aceptar.Name = "cmd_aceptar";
            this.cmd_aceptar.Size = new System.Drawing.Size(75, 23);
            this.cmd_aceptar.TabIndex = 1;
            this.cmd_aceptar.Text = "Aceptar";
            this.cmd_aceptar.UseVisualStyleBackColor = true;
            // 
            // cmd_cancelar
            // 
            this.cmd_cancelar.Location = new System.Drawing.Point(175, 138);
            this.cmd_cancelar.Name = "cmd_cancelar";
            this.cmd_cancelar.Size = new System.Drawing.Size(75, 23);
            this.cmd_cancelar.TabIndex = 2;
            this.cmd_cancelar.Text = "Cancelar";
            this.cmd_cancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // Frm_Baja_Puerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 206);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd_cancelar);
            this.Controls.Add(this.cmd_aceptar);
            this.Controls.Add(this.txt_nombre);
            this.Name = "Frm_Baja_Puerto";
            this.Text = "Eliminar Puerto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private entidades.TextBox01 txt_nombre;
        private System.Windows.Forms.Button cmd_aceptar;
        private System.Windows.Forms.Button cmd_cancelar;
        private System.Windows.Forms.Label label1;
    }
}