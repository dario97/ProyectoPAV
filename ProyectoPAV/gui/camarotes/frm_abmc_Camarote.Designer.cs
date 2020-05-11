namespace ProyectoPAV.gui
{
    partial class frm_abmc_TiposCamarote
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_abmc_TiposCamarote));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nroCamarote = new System.Windows.Forms.TextBox();
            this.txt_nroCubierta = new System.Windows.Forms.TextBox();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cmd_buscar = new System.Windows.Forms.Button();
            this.cmd_agregar = new System.Windows.Forms.Button();
            this.cmd_modificar = new System.Windows.Forms.Button();
            this.cmd_salir = new System.Windows.Forms.Button();
            this.cmd_eliminar = new System.Windows.Forms.Button();
            this.chbx = new System.Windows.Forms.CheckBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoNavio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_navio = new ProyectoPAV.gui.clases.MiCombito();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            label1.Location = new System.Drawing.Point(97, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(320, 31);
            label1.TabIndex = 0;
            label1.Text = "GESTION DE CAMAROTES";
            label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Navío:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número de Camarote :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número de Cubierta :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_nroCamarote
            // 
            this.txt_nroCamarote.Location = new System.Drawing.Point(148, 172);
            this.txt_nroCamarote.Name = "txt_nroCamarote";
            this.txt_nroCamarote.Size = new System.Drawing.Size(100, 20);
            this.txt_nroCamarote.TabIndex = 2;
            // 
            // txt_nroCubierta
            // 
            this.txt_nroCubierta.Location = new System.Drawing.Point(148, 136);
            this.txt_nroCubierta.Name = "txt_nroCubierta";
            this.txt_nroCubierta.Size = new System.Drawing.Size(100, 20);
            this.txt_nroCubierta.TabIndex = 1;
            // 
            // dgv3
            // 
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.codigoNavio,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv3.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgv3.Location = new System.Drawing.Point(32, 239);
            this.dgv3.Name = "dgv3";
            this.dgv3.Size = new System.Drawing.Size(474, 133);
            this.dgv3.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label5.Location = new System.Drawing.Point(33, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Datos :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmd_buscar
            // 
            this.cmd_buscar.BackColor = System.Drawing.SystemColors.Control;
            this.cmd_buscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_buscar.Location = new System.Drawing.Point(413, 166);
            this.cmd_buscar.Name = "cmd_buscar";
            this.cmd_buscar.Size = new System.Drawing.Size(81, 26);
            this.cmd_buscar.TabIndex = 4;
            this.cmd_buscar.Text = "Consultar";
            this.cmd_buscar.UseVisualStyleBackColor = true;
            this.cmd_buscar.Click += new System.EventHandler(this.cmd_buscar_Click);
            // 
            // cmd_agregar
            // 
            this.cmd_agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_agregar.BackgroundImage")));
            this.cmd_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_agregar.Location = new System.Drawing.Point(32, 378);
            this.cmd_agregar.Name = "cmd_agregar";
            this.cmd_agregar.Size = new System.Drawing.Size(58, 47);
            this.cmd_agregar.TabIndex = 6;
            this.cmd_agregar.UseVisualStyleBackColor = true;
            this.cmd_agregar.Click += new System.EventHandler(this.cmd_agregar_Click);
            // 
            // cmd_modificar
            // 
            this.cmd_modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_modificar.BackgroundImage")));
            this.cmd_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_modificar.Location = new System.Drawing.Point(114, 378);
            this.cmd_modificar.Name = "cmd_modificar";
            this.cmd_modificar.Size = new System.Drawing.Size(55, 47);
            this.cmd_modificar.TabIndex = 7;
            this.cmd_modificar.UseVisualStyleBackColor = true;
            this.cmd_modificar.Click += new System.EventHandler(this.cmd_modificar_Click);
            // 
            // cmd_salir
            // 
            this.cmd_salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_salir.BackgroundImage")));
            this.cmd_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_salir.Location = new System.Drawing.Point(444, 378);
            this.cmd_salir.Name = "cmd_salir";
            this.cmd_salir.Size = new System.Drawing.Size(62, 47);
            this.cmd_salir.TabIndex = 9;
            this.cmd_salir.UseVisualStyleBackColor = true;
            this.cmd_salir.Click += new System.EventHandler(this.cmd_salir_Click);
            // 
            // cmd_eliminar
            // 
            this.cmd_eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_eliminar.BackgroundImage")));
            this.cmd_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmd_eliminar.Location = new System.Drawing.Point(187, 378);
            this.cmd_eliminar.Name = "cmd_eliminar";
            this.cmd_eliminar.Size = new System.Drawing.Size(61, 47);
            this.cmd_eliminar.TabIndex = 8;
            this.cmd_eliminar.UseVisualStyleBackColor = true;
            this.cmd_eliminar.Click += new System.EventHandler(this.cmd_eliminar_Click);
            // 
            // chbx
            // 
            this.chbx.AutoSize = true;
            this.chbx.Location = new System.Drawing.Point(148, 207);
            this.chbx.Name = "chbx";
            this.chbx.Size = new System.Drawing.Size(88, 17);
            this.chbx.TabIndex = 3;
            this.chbx.Text = "Buscar todos";
            this.chbx.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.chbx.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // codigoNavio
            // 
            this.codigoNavio.HeaderText = "Código Navío";
            this.codigoNavio.Name = "codigoNavio";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Num.Cubierta";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Num.Camarote";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tipo";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ubicacion";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cant.Camas";
            this.Column5.Name = "Column5";
            // 
            // cmb_navio
            // 
            this.cmb_navio.FormattingEnabled = true;
            this.cmb_navio.Location = new System.Drawing.Point(148, 102);
            this.cmb_navio.Name = "cmb_navio";
            this.cmb_navio.pp_descriptor_tabla_cargar = "Nombre_navio";
            this.cmb_navio.pp_nombre_campo = null;
            this.cmb_navio.pp_nombre_tabla = null;
            this.cmb_navio.pp_nombre_tabla_cargar = "NAVIOS";
            this.cmb_navio.pp_pk_tabla_cargar = "Cod_navio";
            this.cmb_navio.pp_validar = false;
            this.cmb_navio.Size = new System.Drawing.Size(100, 21);
            this.cmb_navio.TabIndex = 10;
            // 
            // frm_abmc_TiposCamarote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(542, 437);
            this.Controls.Add(this.cmb_navio);
            this.Controls.Add(this.chbx);
            this.Controls.Add(this.cmd_eliminar);
            this.Controls.Add(this.cmd_salir);
            this.Controls.Add(this.cmd_modificar);
            this.Controls.Add(this.cmd_agregar);
            this.Controls.Add(this.cmd_buscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv3);
            this.Controls.Add(this.txt_nroCubierta);
            this.Controls.Add(this.txt_nroCamarote);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frm_abmc_TiposCamarote";
            this.Text = "Camarotes";
            this.Load += new System.EventHandler(this.frm_abmc_TiposCamarote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nroCamarote;
        private System.Windows.Forms.TextBox txt_nroCubierta;
        private System.Windows.Forms.DataGridView dgv3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmd_buscar;
        private System.Windows.Forms.Button cmd_agregar;
        private System.Windows.Forms.Button cmd_modificar;
        private System.Windows.Forms.Button cmd_salir;
        private System.Windows.Forms.Button cmd_eliminar;
        private System.Windows.Forms.CheckBox chbx;
        private clases.MiCombito cmb_navio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoNavio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}