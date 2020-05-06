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
                && checkBox_todos.Checked==false);
            {
                MessageBox.Show("No se cargó ningún dato", "importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txt_navio.Focus();
            }

            if (txt_navio.Text != ""
                && checkBox_todos.Checked == false) ;
            {
                tabla = navio.consultarPorNombre(txt_navio.Text);
                if (tabla.Rows.Count == 0) ;
                {
                    MessageBox.Show("No se encontró ningún navío con ese nombre.");
                }
            }

            if (checkBox_todos.Checked == true);
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
                dgvl.Rows[i].Cells[0].Value = tabla.Rows[i]["codigoNavio"].ToString();
                dgvl.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre"].ToString();
                dgvl.Rows[i].Cells[2].Value = tabla.Rows[i]["altura"].ToString();
                dgvl.Rows[i].Cells[3].Value = tabla.Rows[i]["autonomia"].ToString();
                dgvl.Rows[i].Cells[4].Value = tabla.Rows[i]["desplazamiento"].ToString();
                dgvl.Rows[i].Cells[5].Value = tabla.Rows[i]["eslora"].ToString();
                dgvl.Rows[i].Cells[6].Value = tabla.Rows[i]["manga"].ToString();
                dgvl.Rows[i].Cells[7].Value = tabla.Rows[i]["cantMaxPasjeros"].ToString();
                dgvl.Rows[i].Cells[8].Value = tabla.Rows[i]["cantTripulantes"].ToString();
                dgvl.Rows[i].Cells[9].Value = tabla.Rows[i]["tipoClasificacion"].ToString();
                dgvl.Rows[i].Cells[10].Value = tabla.Rows[i]["cantMotores"].ToString();
              
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

        private void cmd_Modificar_Click(object sender, EventArgs e)
        {
        ///Frm_Modificar_Navio frm_modif = new Frm_Modificar_Navio();
        ///frm_modif.pp_id_usuario = this.dgvl.CurrentRow.Cells["ID"].Value.ToString();
        ///frm_modif.ShowDialog();
        }
    }
}

