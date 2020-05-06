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
    public partial class frm_abmc_tipoNavio : Form
    {
        public frm_abmc_tipoNavio()
        {
            InitializeComponent();
        }

        private void botonConsultar_Click(object sender, EventArgs e)
        {
            TipoClasificacionNavioService tipoService = new TipoClasificacionNavioService();
            DataTable tabla = new DataTable();

            if (txt_tipoNavio.Text == ""
                && chk_todos.Checked == false)
            {
                MessageBox.Show("No se cargó ningún dato", "importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txt_tipoNavio.Focus();
            }

            if (txt_tipoNavio.Text != ""
                && chk_todos.Checked == false)
            {
                tabla = tipoService.consultarPorNombre(txt_tipoNavio.Text);
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ningún tipo de clasificacion con ese nombre.");
                }
            }

            if (chk_todos.Checked == true)
            {
                tabla = tipoService.consultarTodos();
            }
            cargar_grilla(tabla);

        }

        private void cargar_grilla(DataTable tabla)
        {
            dgv1.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgv1.Rows.Add();
                dgv1.Rows[i].Cells[0].Value = tabla.Rows[i]["Cod_clasificacion"].ToString();
                dgv1.Rows[i].Cells[1].Value = tabla.Rows[i]["Descripcion"].ToString();

            }
        }

        private void registrarTipo_Click(object sender, EventArgs e)
        {
            frm_alta_TipoNavio frmAlta = new frm_alta_TipoNavio();
            frmAlta.ShowDialog();
        }
        private void botonEliminar_Click(object sender, EventArgs e)
        {
            TipoClasificacionNavioService tipoService = new TipoClasificacionNavioService();
            int tipoId = -1;
            tipoId = Convert.ToInt32(this.dgv1.CurrentRow.Cells["ID"].Value.ToString());
            
            if(tipoId != -1)
            {
                tipoService.eliminarTipoPorID(tipoId);
                
            }
            
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dgv1.CurrentRow.Cells["ID"].Value.ToString());
            string descripcion = this.dgv1.CurrentRow.Cells["Descripcion"].Value.ToString();

       
            Frm_modificacion_tipoNavio frmModificacion = new Frm_modificacion_tipoNavio(id, descripcion);
            frmModificacion.ShowDialog();
            
        }

        private void frm_abmc_tipoNavio_Load(object sender, EventArgs e)
        {

        }
    }
}
