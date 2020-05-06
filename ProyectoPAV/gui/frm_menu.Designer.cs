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
            this.button2 = new System.Windows.Forms.Button();
            this.cmd_gestionPuertos = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO";
            // 
            // cmd_gestionPuestos
            // 
            this.cmd_gestionPuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_gestionPuestos.Location = new System.Drawing.Point(34, 78);
            this.cmd_gestionPuestos.Name = "cmd_gestionPuestos";
            this.cmd_gestionPuestos.Size = new System.Drawing.Size(159, 64);
            this.cmd_gestionPuestos.TabIndex = 1;
            this.cmd_gestionPuestos.Text = "GESTION DE PUESTOS";
            this.cmd_gestionPuestos.UseVisualStyleBackColor = true;
            this.cmd_gestionPuestos.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(34, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 85);
            this.button2.TabIndex = 2;
            this.button2.Text = "GESTION DE TIPOS DE NAVIOS";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cmd_gestionPuertos
            // 
            this.cmd_gestionPuertos.BackColor = System.Drawing.Color.Yellow;
            this.cmd_gestionPuertos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmd_gestionPuertos.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmd_gestionPuertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_gestionPuertos.Location = new System.Drawing.Point(266, 78);
            this.cmd_gestionPuertos.Name = "cmd_gestionPuertos";
            this.cmd_gestionPuertos.Size = new System.Drawing.Size(159, 64);
            this.cmd_gestionPuertos.TabIndex = 3;
            this.cmd_gestionPuertos.Text = "GESTION DE PUERTOS";
            this.cmd_gestionPuertos.UseVisualStyleBackColor = false;
            this.cmd_gestionPuertos.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(34, 184);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 64);
            this.button4.TabIndex = 4;
            this.button4.Text = "GESTION DE NAVIOS";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(139, 385);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 64);
            this.button5.TabIndex = 5;
            this.button5.Text = "GESTION DE CUBIERTAS";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(266, 184);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(159, 64);
            this.button6.TabIndex = 6;
            this.button6.Text = "GESTION DE USUARIOS";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(266, 272);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(159, 85);
            this.button7.TabIndex = 7;
            this.button7.Text = "GESTION DE TIPO DE CAMAROTES";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(452, 477);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cmd_gestionPuertos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmd_gestionPuestos);
            this.Controls.Add(this.label1);
            this.Name = "frm_menu";
            this.Text = "frm_menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_gestionPuestos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cmd_gestionPuertos;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}