namespace ProyectoPAV.gui
{
    partial class Frm_Agregar_Itinerario
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
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_categoria = new System.Windows.Forms.TextBox();
            this.cmd_agregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_escalas = new System.Windows.Forms.DataGridView();
            this.num_escala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_puerto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmd_aceptar = new System.Windows.Forms.Button();
            this.cmd_cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_numEscala = new System.Windows.Forms.TextBox();
            this.cmb_puerto = new ProyectoPAV.gui.clases.MiCombito();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_escalas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(123, 46);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(168, 20);
            this.txt_descripcion.TabIndex = 0;
            this.txt_descripcion.TextChanged += new System.EventHandler(this.txt_descripcion_TextChanged);
            // 
            // txt_categoria
            // 
            this.txt_categoria.Location = new System.Drawing.Point(123, 73);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(168, 20);
            this.txt_categoria.TabIndex = 1;
            this.txt_categoria.TextChanged += new System.EventHandler(this.txt_categoria_TextChanged);
            // 
            // cmd_agregar
            // 
            this.cmd_agregar.Location = new System.Drawing.Point(262, 35);
            this.cmd_agregar.Name = "cmd_agregar";
            this.cmd_agregar.Size = new System.Drawing.Size(75, 32);
            this.cmd_agregar.TabIndex = 3;
            this.cmd_agregar.Text = "Agregar";
            this.cmd_agregar.UseVisualStyleBackColor = true;
            this.cmd_agregar.Click += new System.EventHandler(this.cmd_agregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "AGREGAR ITINERARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categoría";
            // 
            // dgv_escalas
            // 
            this.dgv_escalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_escalas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_escala,
            this.cod_puerto});
            this.dgv_escalas.Location = new System.Drawing.Point(35, 196);
            this.dgv_escalas.Name = "dgv_escalas";
            this.dgv_escalas.Size = new System.Drawing.Size(349, 150);
            this.dgv_escalas.TabIndex = 9;
            // 
            // num_escala
            // 
            this.num_escala.HeaderText = "Numero de escala";
            this.num_escala.Name = "num_escala";
            this.num_escala.Width = 130;
            // 
            // cod_puerto
            // 
            this.cod_puerto.HeaderText = "Código de puerto";
            this.cod_puerto.Name = "cod_puerto";
            this.cod_puerto.Width = 190;
            // 
            // cmd_aceptar
            // 
            this.cmd_aceptar.Location = new System.Drawing.Point(35, 352);
            this.cmd_aceptar.Name = "cmd_aceptar";
            this.cmd_aceptar.Size = new System.Drawing.Size(75, 23);
            this.cmd_aceptar.TabIndex = 10;
            this.cmd_aceptar.Text = "Confirmar";
            this.cmd_aceptar.UseVisualStyleBackColor = true;
            this.cmd_aceptar.Click += new System.EventHandler(this.cmd_aceptar_Click);
            // 
            // cmd_cancelar
            // 
            this.cmd_cancelar.Location = new System.Drawing.Point(116, 352);
            this.cmd_cancelar.Name = "cmd_cancelar";
            this.cmd_cancelar.Size = new System.Drawing.Size(75, 23);
            this.cmd_cancelar.TabIndex = 11;
            this.cmd_cancelar.Text = "Cancelar";
            this.cmd_cancelar.UseVisualStyleBackColor = true;
            this.cmd_cancelar.Click += new System.EventHandler(this.cmd_cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmb_puerto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_numEscala);
            this.groupBox1.Controls.Add(this.cmd_agregar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 78);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar escalas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(135, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Puerto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Número de escala";
            // 
            // txt_numEscala
            // 
            this.txt_numEscala.Location = new System.Drawing.Point(9, 40);
            this.txt_numEscala.Name = "txt_numEscala";
            this.txt_numEscala.Size = new System.Drawing.Size(120, 23);
            this.txt_numEscala.TabIndex = 0;
            this.txt_numEscala.TextChanged += new System.EventHandler(this.txt_numEscala_TextChanged);
            // 
            // cmb_puerto
            // 
            this.cmb_puerto.FormattingEnabled = true;
            this.cmb_puerto.Location = new System.Drawing.Point(135, 40);
            this.cmb_puerto.Name = "cmb_puerto";
            this.cmb_puerto.pp_descriptor_tabla_cargar = "Nombre";
            this.cmb_puerto.pp_nombre_campo = null;
            this.cmb_puerto.pp_nombre_tabla = null;
            this.cmb_puerto.pp_nombre_tabla_cargar = "PUERTOS";
            this.cmb_puerto.pp_pk_tabla_cargar = "Cod_puerto";
            this.cmb_puerto.pp_validar = false;
            this.cmb_puerto.Size = new System.Drawing.Size(121, 24);
            this.cmb_puerto.TabIndex = 2;
            this.cmb_puerto.SelectedValueChanged += new System.EventHandler(this.cmb_puerto_SelectedValueChanged);
            // 
            // Frm_Agregar_Itinerario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 430);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmd_cancelar);
            this.Controls.Add(this.cmd_aceptar);
            this.Controls.Add(this.dgv_escalas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_categoria);
            this.Controls.Add(this.txt_descripcion);
            this.Name = "Frm_Agregar_Itinerario";
            this.Text = "Frm_Agregar_Itinerario";
            this.Load += new System.EventHandler(this.Frm_Agregar_Itinerario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_escalas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_categoria;
        private System.Windows.Forms.Button cmd_agregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_escalas;
        private System.Windows.Forms.Button cmd_aceptar;
        private System.Windows.Forms.Button cmd_cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_numEscala;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_escala;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_puerto;
        private System.Windows.Forms.Label label6;
        private clases.MiCombito cmb_puerto;
    }
}