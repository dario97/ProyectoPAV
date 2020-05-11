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
            this.miCombito1.SelectedIndex = -1;
        }

        private void bttn_crear_Click(object sender, EventArgs e)
        {
            Frm_alta_tipoCamarote frm_Alta_Tipo = new Frm_alta_tipoCamarote();
            frm_Alta_Tipo.ShowDialog();
        
        }

        private void bttn_buscar_Click(object sender, EventArgs e)
        {
            TipoCamaroteService tipoCamaroteService = new TipoCamaroteService();
            TipoCamarote tipoCamarote;
            List<TipoCamarote> listaTipos = new List<TipoCamarote>();

            if (this.miCombito1.SelectedIndex == -1
                && chk_todos.Checked == false)
            {
                MessageBox.Show("No se cargó ningún dato", "importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                miCombito1.Focus();
            }

            if (miCombito1.SelectedIndex != -1
                && chk_todos.Checked == false)
            {
                tipoCamarote = tipoCamaroteService.getById(Convert.ToInt32(this.miCombito1.SelectedValue));
                listaTipos.Add(tipoCamarote);

                if (tipoCamarote == null)
                {
                    MessageBox.Show("No se encontró ningún navío con ese nombre.");
                }
            }

            if (chk_todos.Checked == true)
            {
                listaTipos = tipoCamaroteService.getAll();
            }
            cargar_grilla(listaTipos);
        }

        private void cargar_grilla(List<TipoCamarote> listTiposCamarote)
        {
        
            dgv_tipoCamarote.Rows.Clear();
            for (int i = 0; i < listTiposCamarote.Count; i++)
            {
                dgv_tipoCamarote.Rows.Add();
                dgv_tipoCamarote.Rows[i].Cells[0].Value = listTiposCamarote[i].IdTipo;
                dgv_tipoCamarote.Rows[i].Cells[1].Value = listTiposCamarote[i].Nombre;

            }
        }

        private void bttn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttn_eliminar_Click(object sender, EventArgs e)
        {
            TipoCamaroteService tipoCamaroteService = new TipoCamaroteService();
            int tipoId = -1;
            tipoId = Convert.ToInt32(this.dgv_tipoCamarote.CurrentRow.Cells["ID"].Value.ToString());

            if (tipoId != -1)
            {
                tipoCamaroteService.eliminar(tipoId);
                MessageBox.Show("Se eliminó con éxito");

            }
        }
    }
}
