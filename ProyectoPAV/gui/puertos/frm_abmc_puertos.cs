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
            int id = Convert.ToInt32(this.dvg2.CurrentRow.Cells["Id"].Value.ToString());
            string nombre = this.dvg2.CurrentRow.Cells["Descripcion"].Value.ToString();


            frm_modificar_puertos abrir1 = new frm_modificar_puertos(id, nombre);
            abrir1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //PuertoService puerto3 = new PuertoService();
            //in
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
