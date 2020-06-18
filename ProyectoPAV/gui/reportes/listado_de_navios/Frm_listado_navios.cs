using ProyectoPAV.entidades;
using ProyectoPAV.negocio.controllers;
using ProyectoPAV.negocio.servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPAV.gui.reportes
{
    public partial class Frm_listado_navios : Form
    {
        private static NavioService navioService = new NavioService();
        
        public Frm_listado_navios()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.rv_listado_navio.RefreshReport();

            this.cmb_tipoNavio.cargar();
            this.cmb_tipoNavio.SelectedIndex = -1;


            this.rv_listado_navio.RefreshReport();
        }

        private void cmd_generar_Click(object sender, EventArgs e)
        {
            
            GenerarListadoNavioController generarListadoNavioController = new GenerarListadoNavioController();

            
            this.rv_listado_navio.RefreshReport();
            generarListadoNavioController.tomarSeleccionTipoNavio(Convert.ToInt32(this.cmb_tipoNavio.SelectedValue));
        
            naviosBindingSource.DataSource = generarListadoNavioController.tomarConfirmacionGenerarListado();
            rv_listado_navio.RefreshReport();
        }

        private void chk_todos_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_todos.Checked)
            {
                this.cmb_tipoNavio.SelectedIndex = -1;
                this.cmb_tipoNavio.Enabled = false;

            }
            else
            {
                this.cmb_tipoNavio.Enabled = true;
            }
        }
    }
}

