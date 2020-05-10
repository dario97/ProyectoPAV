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
            this.miCombito1.cargar();
        }

        private void bttn_crear_Click(object sender, EventArgs e)
        {
            Frm_alta_tipoCamarote frm_Alta_Tipo = new Frm_alta_tipoCamarote();
            frm_Alta_Tipo.ShowDialog();
        
        }

        private void bttn_buscar_Click(object sender, EventArgs e)
        {
            TipoCamaroteService tipoCamaroteService = new TipoCamaroteService();
            DataTable tabla = new DataTable();

            if (this.txt_tipo.Text == ""
                && chk_todos.Checked == false)
            {
                MessageBox.Show("No se cargó ningún dato", "importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txt_tipo.Focus();
            }

            if (txt_tipo.Text != ""
                && chk_todos.Checked == false)
            {
                tabla = tipoCamaroteService.consultarPorNombre(txt_tipo.Text);
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ningún navío con ese nombre.");
                }
            }

            if (chk_todos.Checked == true)
            {
                tabla = tipoCamaroteService.consultarTodos();
            }
            cargar_grilla(tabla);
        }

        private void cargar_grilla(DataTable tabla)
        {
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgv_tipoCamarote.Rows.Add();
                dgv_tipoCamarote.Rows[i].Cells[0].Value = tabla.Rows[i]["Tipo"].ToString();
                dgv_tipoCamarote.Rows[i].Cells[1].Value = tabla.Rows[i]["Nombre"].ToString();
                
            }
        }
    }
}
