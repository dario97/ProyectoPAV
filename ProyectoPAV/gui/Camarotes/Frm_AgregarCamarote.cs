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

        }

        private void cmd_aceptar_Click(object sender, EventArgs e)
        {
            if (_camarote.consultarCamarote(this.txt_codigo.Text, this.txt_cubierta.Text, this.txt_numcam.Text).Rows.Count == 0)
            {
                int codNavio = Convert.ToInt32(this.txt_codigo.Text);
                int numCubierta = Convert.ToInt32(this.txt_cubierta.Text);
                int numCamarote = Convert.ToInt32(this.txt_numcam.Text);
                int tipo = Convert.ToInt32(this.txt_tipo.Text);
                string ubicacion = this.txt_ubicacion.Text;
                int cantCamas = Convert.ToInt32(this.txt_camas.Text);

                Camarote camarote = new Camarote(codNavio, numCubierta, numCamarote, tipo, ubicacion, cantCamas);

                _camarote.crearCamarote(camarote);

                MessageBox.Show("El Camarote se guardó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Close();
            }
            else
            {
                MessageBox.Show("El camarote ya existe, verifique los datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
