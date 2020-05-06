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
    public partial class frm_abmc_tipoNavio : Form
    {
        public frm_abmc_tipoNavio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void registrarTipo_Click(object sender, EventArgs e)
        {
            frm_alta_TipoNavio frmAlta = new frm_alta_TipoNavio();
            frmAlta.ShowDialog();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
