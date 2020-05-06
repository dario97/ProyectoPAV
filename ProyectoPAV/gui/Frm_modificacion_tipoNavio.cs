using ProyectoPAV.entidades;
using ProyectoPAV.negocio.servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPAV.gui
{
    public partial class Frm_modificacion_tipoNavio : Form
    {


        private int pp_id;
        private string pp_descripcion;

        TipoClasificacionNavioService tipoService = new TipoClasificacionNavioService();
        
        public Frm_modificacion_tipoNavio(int pp_id, string pp_descripcion)
        {
            this.pp_id = pp_id;
            this.pp_descripcion = pp_descripcion;

            InitializeComponent();
        }

        private void botonConfirmar_Click(object sender, EventArgs e)
        {
            TipoClasificacionNavio tipo = new TipoClasificacionNavio(pp_id, this.txt_tipo.Text);
            tipoService.modificarTipoClasificacionNavio(tipo);
            MessageBox.Show("El tipo se modificó con exito", "Mensaje", MessageBoxButtons.OK);
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_modificacion_tipoNavio_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}


