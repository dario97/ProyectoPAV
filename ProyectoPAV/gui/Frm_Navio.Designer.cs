namespace ProyectoPAV.gui
{
    partial class Frm_Navio
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
            this.SuspendLayout();
            // 
            // Frm_Navio
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Frm_Navio";
            this.Load += new System.EventHandler(this.Frm_Navio_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_Consultar;
        private System.Windows.Forms.Button cmd_Agregar;
        private System.Windows.Forms.TextBox txt_navio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_todos;
        private System.Windows.Forms.DataGridView dgvl;
        private System.Windows.Forms.Button cmd_Modificar;
        private System.Windows.Forms.Button cmd_Eliminar;
        private System.Windows.Forms.Button cmd_Salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autonomia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desplazamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eslora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacidad_Maxima_de_Pasajeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_de_Tripulantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clasificación;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_de_Motores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}