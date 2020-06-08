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
            int id = Convert.ToInt32(this.dgv4.CurrentRow.Cells["Id"].Value.ToString());
            string nombre = this.dgv4.CurrentRow.Cells["Nombre"].Value.ToString();


            frm_modificar_puertos abrir1 = new frm_modificar_puertos(id, nombre);
            abrir1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PuertoService puerto3 = new PuertoService();
            int puertoid = -1;
            puertoid = Convert.ToInt32(this.dgv4.CurrentRow.Cells["Id"].Value.ToString());
            if (puertoid != -1)
            {
                puerto3.DeletePuertoById(puertoid);
                MessageBox.Show("La eliminación se realizó con éxito", "mensaje", MessageBoxButtons.OK);
            }
            
        }

        private void cmd_consulta_Click(object sender, EventArgs e)
        {
            PuertoService puertosService = new PuertoService();
            DataTable tabla = new DataTable();
            List<Puerto> puertos = new List<Puerto>();

            if (txt_nombre.Text == ""
                && chbx1.Checked == false)
            {
                MessageBox.Show("No se cargó ningun dato", "mensaje", MessageBoxButtons.OK);
           
            }

            if (txt_nombre.Text != ""
                && chbx1.Checked == false)
            {
                puertos = puertosService.GetByName(txt_nombre.Text);
                if (puertos.Count == 0)
                {
                    MessageBox.Show("No se encontró ningun puerto con ese nombre", " Mensaje", MessageBoxButtons.OK);
                }
            }

            if (chbx1.Checked == true)
            {
                puertos = puertosService.GetAll();

            }
            cargar_grilla(puertos);

        }

        private void cargar_grilla(List<Puerto> puertos)
        {
            dgv4.Rows.Clear();
            for (int i = 0; i < puertos.Count; i++)
            {
                dgv4.Rows.Add();
                dgv4.Rows[i].Cells[0].Value = puertos[i].CodigoPuerto.ToString();
                dgv4.Rows[i].Cells[1].Value = puertos[i].Nombre.ToString();

            }
        }
    }
}
