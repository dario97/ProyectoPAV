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
    public partial class frm_abmc_TiposCamarote : Form
    {
        public frm_abmc_TiposCamarote()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmd_buscar_Click(object sender, EventArgs e)
        {
            CamaroteService camarotes = new CamaroteService();
            DataTable tabla = new DataTable();

            //if (txt_codigoNavio.Text == ""
            //    && txt_nroCamarote.Text == ""
            //    && txt_nroCubierta.Text == ""
            //    && chbx.Checked == false)
            //{
            //    MessageBox.Show("No se cargó ningún dato", "Mensaje", MessageBoxButtons.OK);
            //}

            //if(txt_codigoNavio.Text != ""
            //    && txt_nroCamarote.Text != ""
            //    && txt_nroCubierta.Text != ""
            //    && chbx.Checked == false)
            //{
            //    tabla = camarotes.consultarCamarote(Convert.ToInt32(txt_codigoNavio.Text),Convert.ToInt32(txt_nroCubierta.Text),Convert.ToInt32(txt_nroCamarote.Text));
            //    if (tabla.Rows.Count == 0)
            //    {
            //        MessageBox.Show("No se encontró ningún camarote con esos datos", " Mensaje", MessageBoxButtons.OK);
            //    }
            //}


            //if (chbx.Checked == true)
            //{
            //    tabla = camarotes.consultarTodos();
            //}

            //cargar_grilla(tabla);

           
        }

        private void cargar_grilla(DataTable tabla)
        {
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgv3.Rows.Add();
                dgv3.Rows[i].Cells[0].Value = tabla.Rows[i]["Cod_Camarote"].ToString();
                dgv3.Rows[i].Cells[1].Value = tabla.Rows[i]["Num_Cubierta"].ToString();
                dgv3.Rows[i].Cells[2].Value = tabla.Rows[i]["Num_Camarote"].ToString();
                dgv3.Rows[i].Cells[3].Value = tabla.Rows[i]["Tipo_Camarote"].ToString();
                dgv3.Rows[i].Cells[4].Value = tabla.Rows[i]["Ubicacion"].ToString();
                dgv3.Rows[i].Cells[5].Value = tabla.Rows[i]["Cant_Camas"].ToString();
            }
        }

        private void cmd_agregar_Click(object sender, EventArgs e)
        {
            Frm_AgregarCamarote ventana = new Frm_AgregarCamarote();
            ventana.ShowDialog();

        }

        
        private void cmd_eliminar_Click(object sender, EventArgs e)
        {
            //frm_eliminar_camarote ventana2 = new frm_eliminar_camarote();
            //ventana2.ShowDialog();
        }

        private void cmd_modificar_Click(object sender, EventArgs e)
        {
            //frm_editar_camarote ventana3 = new frm_editar_camarote();
            //ventana3.ShowDialog();
        }

        private void frm_abmc_TiposCamarote_Load(object sender, EventArgs e)
        {
            this.miCombito1.cargar();
            this.miCombito1.SelectedIndex = -1;
        }

        private void cmd_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
