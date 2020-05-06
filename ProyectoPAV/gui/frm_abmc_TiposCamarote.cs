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
    public partial class frm_abmc_TiposCamarote : Form
    {
        public frm_abmc_TiposCamarote()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_AgregarCamarote ventana = new Frm_AgregarCamarote();
            ventana.ShowDialog();
       
        }

        private void cmd_eliminar_Click(object sender, EventArgs e)
        {
            //frm_eliminar_camarote ventana2 = new frm_eliminar_camarote();
            //ventana2.ShowDialog();
        }

        private void cmd_modificar_Click(object sender, EventArgs e)
        {
            //frm_editar_camarote ventana3 = new frm_editar_camarote();
            //ventana3.ShowDialog();
        }
    }
}
