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
                puerto3.eliminarPuerto(puertoid);
            }
            
        }

        private void cmd_consulta_Click(object sender, EventArgs e)
        {
            PuertoService puerto = new PuertoService();
            DataTable tabla = new DataTable();

            if (txt_nombre.Text == ""
                && chbx1.Checked == false)
            {
                MessageBox.Show("No se cargó ningun dato", "mensaje", MessageBoxButtons.OK);
           
            }

            if (txt_nombre.Text != ""
                && chbx1.Checked == false)
            {
                tabla = puerto.consultarPorNombre(txt_nombre.Text);
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ningun puerto con ese nombre", " Mensaje", MessageBoxButtons.OK);
                }
            }

            if (chbx1.Checked == true)
            {
                tabla = puerto.consultarTodos();

            }
            cargar_grilla(tabla);

        }

        private void cargar_grilla(DataTable tabla)
        {
            dgv4.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgv4.Rows.Add();
                dgv4.Rows[i].Cells[0].Value = tabla.Rows[i]["Cod_puerto"].ToString();
                dgv4.Rows[i].Cells[1].Value = tabla.Rows[i]["Nombre"].ToString();

            }
        }
    }
}
