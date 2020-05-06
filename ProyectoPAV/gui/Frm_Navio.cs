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
    public partial class Frm_Navio : Form
    {
        public Frm_Navio()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Navio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmd_Consultar_Click(object sender, EventArgs e)
        {
            NavioService navio = new NavioService();
            DataTable tabla = new DataTable();

            if (txt_navio.Text == ""
                && checkBox_todos.Checked==false)
            {
                MessageBox.Show("No se cargó ningún dato", "importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txt_navio.Focus();
            }

            if (txt_navio.Text != ""
                && checkBox_todos.Checked == false)
            {
                tabla = navio.consultarPorNombre(txt_navio.Text);
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ningún navío con ese nombre.");
                }
            }

            if (checkBox_todos.Checked == true)
            {
                tabla = navio.consultarTodos();
            }
            cargar_grilla(tabla);
        }

        private void cargar_grilla(DataTable tabla)
        {
            dgvl.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgvl.Rows.Add();
                dgvl.Rows[i].Cells[0].Value = tabla.Rows[i]["Cod_navio"].ToString();
                dgvl.Rows[i].Cells[1].Value = tabla.Rows[i]["Nombre_navio"].ToString();
                dgvl.Rows[i].Cells[2].Value = tabla.Rows[i]["Altura"].ToString();
                dgvl.Rows[i].Cells[3].Value = tabla.Rows[i]["Autonomia"].ToString();
                dgvl.Rows[i].Cells[4].Value = tabla.Rows[i]["Desplazamiento"].ToString();
                dgvl.Rows[i].Cells[5].Value = tabla.Rows[i]["Eslora"].ToString();
                dgvl.Rows[i].Cells[6].Value = tabla.Rows[i]["Manga"].ToString();
                dgvl.Rows[i].Cells[7].Value = tabla.Rows[i]["Cant_max_pasajeros"].ToString();
                dgvl.Rows[i].Cells[8].Value = tabla.Rows[i]["Cant_tripulantes"].ToString();
                dgvl.Rows[i].Cells[9].Value = tabla.Rows[i]["Tipo_clasificacion"].ToString();
                dgvl.Rows[i].Cells[10].Value = tabla.Rows[i]["Cant_motores"].ToString();
              
            }
        }
       

        private NavioService NavioService()
        {
            throw new NotImplementedException();
        }

        private void cmd_Agregar_Click(object sender, EventArgs e)
        {

            Frm_Alta_Navio frmAlta = new Frm_Alta_Navio();
            frmAlta.ShowDialog();
        }
        private void cmd_Eliminar_Click(object sender, EventArgs e)
        {
            NavioService navioelim = new NavioService();
            int tipocodigo = -1;
            tipocodigo = Convert.ToInt32(this.dgvl.CurrentRow.Cells["ID"].Value.ToString());

            if(tipocodigo != -1)
            {
                navioelim.eliminarNavio(tipocodigo);
                MessageBox.Show("El navío fue correctamente eliminado", "mensaje", MessageBoxButtons.OK);
            }
             
        }

        private void cmd_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Navio_Load_1(object sender, EventArgs e)
        {

        }

        private void dgvl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmd_Modificar_Click(object sender, EventArgs e)
        {
            int codigoNavio = Convert.ToInt32(this.dgvl.CurrentRow.Cells["ID"].Value.ToString());
            string nombre = this.dgvl.CurrentRow.Cells["Nombre"].Value.ToString();
            float altura = Convert.ToSingle(this.dgvl.CurrentRow.Cells["Altura"].Value.ToString());
            float autonomia = Convert.ToSingle(this.dgvl.CurrentRow.Cells["Autonomia"].Value.ToString());
            float desplazamiento = Convert.ToSingle(this.dgvl.CurrentRow.Cells["Desplazamiento"].Value.ToString());
            float eslora = Convert.ToSingle(this.dgvl.CurrentRow.Cells["Eslora"].Value.ToString());
            float manga = Convert.ToSingle(this.dgvl.CurrentRow.Cells["Manga"].Value.ToString());
            int cantMaxPasajeros = Convert.ToInt32(this.dgvl.CurrentRow.Cells["Pasajeros"].Value.ToString());
            int cantTripulantes = Convert.ToInt32(this.dgvl.CurrentRow.Cells["Tripulantes"].Value.ToString());
            int tipoClasificacion = Convert.ToInt32(this.dgvl.CurrentRow.Cells["Clasificacion"].Value.ToString());
            int cantMotores = Convert.ToInt32(this.dgvl.CurrentRow.Cells["Motores"].Value.ToString());

            Frm_Modificar_Navio formModificar = new Frm_Modificar_Navio(codigoNavio, nombre, altura, autonomia, desplazamiento, eslora, manga, cantMaxPasajeros, cantTripulantes, tipoClasificacion, cantMotores);
            formModificar.ShowDialog();
        }
    }
}
