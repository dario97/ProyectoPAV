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
    public partial class frm_abmc_usuarios : Form
    {
        public frm_abmc_usuarios()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_alta_usuarios ventana = new frm_alta_usuarios();
            ventana.ShowDialog();
        }

        private void cmd_editar_Click(object sender, EventArgs e)
        {
            Frm_Modificar_Usuario ventana1 = new Frm_Modificar_Usuario();
            ventana1.ShowDialog();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
