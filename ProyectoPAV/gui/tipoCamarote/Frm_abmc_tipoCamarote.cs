using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPAV.gui.tipoCamarote
{
    public partial class Frm_abmc_tipoCamarote : Form
    {
        public Frm_abmc_tipoCamarote()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_abmc_tipoCamarote_Load(object sender, EventArgs e)
        {

        }

        private void bttn_crear_Click(object sender, EventArgs e)
        {
            Frm_alta_tipoCamarote frm_Alta_Tipo = new Frm_alta_tipoCamarote();
            frm_Alta_Tipo.ShowDialog();
        }
    }
}
