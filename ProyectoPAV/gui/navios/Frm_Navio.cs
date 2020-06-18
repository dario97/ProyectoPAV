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
            NavioService navioService = new NavioService();
            List<Navio> navios = new List<Navio>();

            if (txt_navio.Text == ""
                && checkBox_todos.Checked==false)
            {
                MessageBox.Show("No se cargó ningún dato", "importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txt_navio.Focus();
            }

            if (txt_navio.Text != ""
                && checkBox_todos.Checked == false)
            {
                navios = navioService.GetByName(txt_navio.Text);
                if (navios.Count == 0)
                {
                    MessageBox.Show("No se encontró ningún navío con ese nombre.");
                }
            }

            if (checkBox_todos.Checked == true)
            {
                navios = navioService.GetAll();
            }
            cargar_grilla(navios);
        }

        private void cargar_grilla(List<Navio> navios)
        {
            dgvl.Rows.Clear();
            for (int i = 0; i < navios.Count; i++)
            {
                dgvl.Rows.Add();
                dgvl.Rows[i].Cells[0].Value = navios[i].CodigoNavio.ToString();
                dgvl.Rows[i].Cells[1].Value = navios[i].Nombre.ToString();
                dgvl.Rows[i].Cells[2].Value = navios[i].Altura.ToString();
                dgvl.Rows[i].Cells[3].Value = navios[i].Autonomia.ToString();
                dgvl.Rows[i].Cells[4].Value = navios[i].Desplazamiento.ToString();
                dgvl.Rows[i].Cells[5].Value = navios[i].Eslora.ToString();
                dgvl.Rows[i].Cells[6].Value = navios[i].Manga.ToString();
                dgvl.Rows[i].Cells[7].Value = navios[i].CantMaxPasjeros.ToString();
                dgvl.Rows[i].Cells[8].Value = navios[i].CantTripulantes.ToString();
                dgvl.Rows[i].Cells[9].Value = navios[i].GetTipoNavio().Descripcion;
                dgvl.Rows[i].Cells[10].Value = navios[i].CantMotores.ToString();
              
            }
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
                navioelim.DeleteNavioById(tipocodigo);
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
