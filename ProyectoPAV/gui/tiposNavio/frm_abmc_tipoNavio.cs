using ProyectoPAV.entidades;
using ProyectoPAV.negocio.servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
            List<TipoClasificacionNavio> tiposNavios = new List<TipoClasificacionNavio>();

            if (txt_tipoNavio.Text == ""
                && chk_todos.Checked == false)
            {
                MessageBox.Show("No se cargó ningún dato", "importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txt_tipoNavio.Focus();
            }

            if (txt_tipoNavio.Text != ""
                && chk_todos.Checked == false)
            {
                tiposNavios = tipoService.GetByName(txt_tipoNavio.Text);
                if (tiposNavios.Count == 0)
                {
                    MessageBox.Show("No se encontró ningún tipo de clasificacion con ese nombre.");
                }
            }

            if (chk_todos.Checked == true)
            {
                tiposNavios = tipoService.GetAll();
            }
            cargar_grilla(tiposNavios);

        }

        private void cargar_grilla(List<TipoClasificacionNavio> tiposNavios)
        {
            dgv1.Rows.Clear();
            for (int i = 0; i < tiposNavios.Count; i++)
            {
                dgv1.Rows.Add();
                dgv1.Rows[i].Cells[0].Value = tiposNavios[i].CodigoClasificacion.ToString();
                dgv1.Rows[i].Cells[1].Value = tiposNavios[i].Descripcion.ToString();

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
                try
                {
                    tipoService.DeleteTipoNavioById(tipoId);
                }catch(OleDbException exception)
                {
                    if(exception.ErrorCode == -2147217873)
                    {
                        MessageBox.Show("No puede eliminar el tipo de navio ya que existen navíos con esta clasificación.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                
                
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
