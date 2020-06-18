namespace ProyectoPAV.gui
{
    partial class frm_menu
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
            this.cmd_gestionPuestos = new System.Windows.Forms.Button();
            this.cmd_gestionTipoNavio = new System.Windows.Forms.Button();
            this.cmd_gestionPuertos = new System.Windows.Forms.Button();
            this.cmd_gestionNavios = new System.Windows.Forms.Button();
            this.cmd_gestionUsuarios = new System.Windows.Forms.Button();
            this.cmd_gestionCamarote = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmd_tiposDeCamarote = new System.Windows.Forms.Button();
            this.cmd_gestionCubierta = new System.Windows.Forms.Button();
            this.cmd_itinerarios = new System.Windows.Forms.Button();
            this.cmd_reportes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmd_gestionPuestos
            // 
            this.cmd_gestionPuestos.BackColor = System.Drawing.Color.Silver;
            this.cmd_gestionPuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_gestionPuestos.Location = new System.Drawing.Point(252, 190);
            this.cmd_gestionPuestos.Name = "cmd_gestionPuestos";
            this.cmd_gestionPuestos.Size = new System.Drawing.Size(188, 88);
            this.cmd_gestionPuestos.TabIndex = 0;
            this.cmd_gestionPuestos.Text = "GESTIÓN DE PUESTOS";
            this.cmd_gestionPuestos.UseVisualStyleBackColor = false;
            this.cmd_gestionPuestos.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmd_gestionTipoNavio
            // 
            this.cmd_gestionTipoNavio.BackColor = System.Drawing.Color.Silver;
            this.cmd_gestionTipoNavio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmd_gestionTipoNavio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_gestionTipoNavio.Location = new System.Drawing.Point(23, 293);
            this.cmd_gestionTipoNavio.Name = "cmd_gestionTipoNavio";
            this.cmd_gestionTipoNavio.Size = new System.Drawing.Size(188, 88);
            this.cmd_gestionTipoNavio.TabIndex = 4;
            this.cmd_gestionTipoNavio.Text = "GESTIÓN DE TIPOS DE NAVIOS";
            this.cmd_gestionTipoNavio.UseVisualStyleBackColor = false;
            this.cmd_gestionTipoNavio.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmd_gestionPuertos
            // 
            this.cmd_gestionPuertos.BackColor = System.Drawing.Color.Silver;
            this.cmd_gestionPuertos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmd_gestionPuertos.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmd_gestionPuertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_gestionPuertos.Location = new System.Drawing.Point(252, 293);
            this.cmd_gestionPuertos.Name = "cmd_gestionPuertos";
            this.cmd_gestionPuertos.Size = new System.Drawing.Size(188, 88);
            this.cmd_gestionPuertos.TabIndex = 3;
            this.cmd_gestionPuertos.Text = "GESTIÓN DE PUERTOS";
            this.cmd_gestionPuertos.UseVisualStyleBackColor = false;
            this.cmd_gestionPuertos.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmd_gestionNavios
            // 
            this.cmd_gestionNavios.BackColor = System.Drawing.Color.Silver;
            this.cmd_gestionNavios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_gestionNavios.Location = new System.Drawing.Point(252, 86);
            this.cmd_gestionNavios.Name = "cmd_gestionNavios";
            this.cmd_gestionNavios.Size = new System.Drawing.Size(188, 88);
            this.cmd_gestionNavios.TabIndex = 2;
            this.cmd_gestionNavios.Text = "GESTIÓN DE NAVIOS";
            this.cmd_gestionNavios.UseVisualStyleBackColor = false;
            this.cmd_gestionNavios.Click += new System.EventHandler(this.button4_Click);
            // 
            // cmd_gestionUsuarios
            // 
            this.cmd_gestionUsuarios.BackColor = System.Drawing.Color.Silver;
            this.cmd_gestionUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_gestionUsuarios.Location = new System.Drawing.Point(23, 86);
            this.cmd_gestionUsuarios.Name = "cmd_gestionUsuarios";
            this.cmd_gestionUsuarios.Size = new System.Drawing.Size(188, 88);
            this.cmd_gestionUsuarios.TabIndex = 1;
            this.cmd_gestionUsuarios.Text = "GESTIÓN DE USUARIOS";
            this.cmd_gestionUsuarios.UseVisualStyleBackColor = false;
            this.cmd_gestionUsuarios.Click += new System.EventHandler(this.button6_Click);
            // 
            // cmd_gestionCamarote
            // 
            this.cmd_gestionCamarote.BackColor = System.Drawing.Color.Silver;
            this.cmd_gestionCamarote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_gestionCamarote.Location = new System.Drawing.Point(23, 190);
            this.cmd_gestionCamarote.Name = "cmd_gestionCamarote";
            this.cmd_gestionCamarote.Size = new System.Drawing.Size(188, 88);
            this.cmd_gestionCamarote.TabIndex = 5;
            this.cmd_gestionCamarote.Text = "GESTIÓN DE CAMAROTE";
            this.cmd_gestionCamarote.UseVisualStyleBackColor = false;
            this.cmd_gestionCamarote.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(124, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 58);
            this.panel1.TabIndex = 8;
            // 
            // cmd_tiposDeCamarote
            // 
            this.cmd_tiposDeCamarote.BackColor = System.Drawing.Color.Silver;
            this.cmd_tiposDeCamarote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_tiposDeCamarote.Location = new System.Drawing.Point(23, 396);
            this.cmd_tiposDeCamarote.Name = "cmd_tiposDeCamarote";
            this.cmd_tiposDeCamarote.Size = new System.Drawing.Size(188, 88);
            this.cmd_tiposDeCamarote.TabIndex = 9;
            this.cmd_tiposDeCamarote.Text = "GESTIÓN TIPOS DE CAMAROTE";
            this.cmd_tiposDeCamarote.UseVisualStyleBackColor = false;
            this.cmd_tiposDeCamarote.Click += new System.EventHandler(this.bttn_tiposDeCamarote_Click);
            // 
            // cmd_gestionCubierta
            // 
            this.cmd_gestionCubierta.BackColor = System.Drawing.Color.Silver;
            this.cmd_gestionCubierta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_gestionCubierta.Location = new System.Drawing.Point(252, 399);
            this.cmd_gestionCubierta.Name = "cmd_gestionCubierta";
            this.cmd_gestionCubierta.Size = new System.Drawing.Size(188, 88);
            this.cmd_gestionCubierta.TabIndex = 10;
            this.cmd_gestionCubierta.Text = "GESTIÓN DE CUBIERTAS";
            this.cmd_gestionCubierta.UseVisualStyleBackColor = false;
            this.cmd_gestionCubierta.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cmd_itinerarios
            // 
            this.cmd_itinerarios.BackColor = System.Drawing.Color.Silver;
            this.cmd_itinerarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_itinerarios.Location = new System.Drawing.Point(446, 86);
            this.cmd_itinerarios.Name = "cmd_itinerarios";
            this.cmd_itinerarios.Size = new System.Drawing.Size(188, 88);
            this.cmd_itinerarios.TabIndex = 12;
            this.cmd_itinerarios.Text = "GESTIÓN DE ITINERARIOS";
            this.cmd_itinerarios.UseVisualStyleBackColor = false;
            this.cmd_itinerarios.Click += new System.EventHandler(this.bttn_itinerarios_Click);
            // 
            // cmd_reportes
            // 
            this.cmd_reportes.BackColor = System.Drawing.Color.Silver;
            this.cmd_reportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_reportes.Location = new System.Drawing.Point(446, 190);
            this.cmd_reportes.Name = "cmd_reportes";
            this.cmd_reportes.Size = new System.Drawing.Size(188, 88);
            this.cmd_reportes.TabIndex = 14;
            this.cmd_reportes.Text = "LISTADOS Y ETADÍSTICAS";
            this.cmd_reportes.UseVisualStyleBackColor = false;
            this.cmd_reportes.Click += new System.EventHandler(this.cmd_reportes_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(652, 510);
            this.Controls.Add(this.cmd_reportes);
            this.Controls.Add(this.cmd_itinerarios);
            this.Controls.Add(this.cmd_gestionCubierta);
            this.Controls.Add(this.cmd_tiposDeCamarote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd_gestionCamarote);
            this.Controls.Add(this.cmd_gestionUsuarios);
            this.Controls.Add(this.cmd_gestionNavios);
            this.Controls.Add(this.cmd_gestionPuertos);
            this.Controls.Add(this.cmd_gestionTipoNavio);
            this.Controls.Add(this.cmd_gestionPuestos);
            this.Controls.Add(this.panel1);
            this.Name = "frm_menu";
            this.Text = "Menú";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_gestionPuestos;
        private System.Windows.Forms.Button cmd_gestionTipoNavio;
        private System.Windows.Forms.Button cmd_gestionPuertos;
        private System.Windows.Forms.Button cmd_gestionNavios;
        private System.Windows.Forms.Button cmd_gestionUsuarios;
        private System.Windows.Forms.Button cmd_gestionCamarote;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmd_tiposDeCamarote;
        private System.Windows.Forms.Button cmd_gestionCubierta;
        private System.Windows.Forms.Button cmd_itinerarios;
        private System.Windows.Forms.Button cmd_reportes;
    }
}