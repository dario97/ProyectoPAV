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
    public partial class Frm_AgregarCamarote : Form
    {
        private static CamaroteService _camarote = new CamaroteService(); 

        public Frm_AgregarCamarote()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_AgregarCamarote_Load(object sender, EventArgs e)
        {
            this.cmb_tipo.cargar();
            this.cmb_tipo.SelectedIndex = -1;
            this.cmb_navio.cargar();
            this.cmb_navio.SelectedIndex = -1;
        }

        private void cmd_aceptar_Click(object sender, EventArgs e)
        {
            if (_camarote.GetByPrimaryKey(Convert.ToInt32(this.cmb_navio.SelectedValue.ToString()),Convert.ToInt32(this.txt_cubierta.Text),Convert.ToInt32(this.txt_numcam.Text)) == null)
            {

                int codNavio = Convert.ToInt32(this.cmb_navio.SelectedValue.ToString());
                int numCubierta = Convert.ToInt32(this.txt_cubierta.Text);
                int numCamarote = Convert.ToInt32(this.txt_numcam.Text);
                int tipo = Convert.ToInt32(this.cmb_tipo.SelectedValue.ToString());
                string ubicacion = this.txt_ubicacion.Text;
                int cantCamas = Convert.ToInt32(this.txt_camas.Text);

                Camarote camarote = new Camarote(codNavio, numCubierta, numCamarote, tipo, ubicacion, cantCamas);

            

                _camarote.CrearCamarote(camarote);

                MessageBox.Show("El Camarote se guardó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Close();
            }
            else
            {
                MessageBox.Show("El camarote ya existe, verifique los datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_navio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
