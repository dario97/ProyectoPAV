using ProyectoPAV.entidades;
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
    public partial class frm_abmc_puertos : Form
    {
        public frm_abmc_puertos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_alta_puertos abrir = new frm_alta_puertos();
            abrir.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_modificar_puertos abrir1 = new frm_modificar_puertos();
            abrir1.ShowDialog();
        }
    }
}
