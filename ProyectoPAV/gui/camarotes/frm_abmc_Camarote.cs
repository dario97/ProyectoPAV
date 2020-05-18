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
            CamaroteService camaroteService = new CamaroteService();
            DataTable tabla = new DataTable();
            List<Camarote> camarotesList = new List<Camarote>();

            if (cmb_navio.SelectedIndex == -1
                && txt_nroCamarote.Text == ""
                && txt_nroCubierta.Text == ""
                && chbx.Checked == false)
            {
                MessageBox.Show("No se cargó ningún dato", "Mensaje", MessageBoxButtons.OK);
            }

            if (cmb_navio.SelectedIndex != -1
                && txt_nroCamarote.Text != ""
                && txt_nroCubierta.Text != ""
                && chbx.Checked == false)
            {
                Camarote camarote = camaroteService.consultarCamarote(Convert.ToInt32(cmb_navio.SelectedValue), Convert.ToInt32(txt_nroCubierta.Text), Convert.ToInt32(txt_nroCamarote.Text));
              
                if (camarote == null)
                {
                    MessageBox.Show("No se encontró ningún camarote con esos datos", " Mensaje", MessageBoxButtons.OK);
                    
                }
                else
                {
                    camarotesList.Add(camarote);
                }
            }
            if (chbx.Checked == true)
            {
                camarotesList = camaroteService.getAll();
                if(camarotesList.Count == 0)
                {
                    MessageBox.Show("No se encontró ningún camarote", " Mensaje", MessageBoxButtons.OK);
                }
            }

            cargar_grilla(camarotesList);

        }
        private void cargar_grilla(List<Camarote> camarotesList)
        {
            this.dgv3.Rows.Clear();
            if(camarotesList.Count != 0)
            {
                for (int i = 0; i < camarotesList.Count; i++)
                {
                    dgv3.Rows.Add();
                   
                    dgv3.Rows[i].Cells[0].Value = camarotesList[i].Id;
                    dgv3.Rows[i].Cells[1].Value = camarotesList[i].IdNavio;
                    dgv3.Rows[i].Cells[2].Value = camarotesList[i].NumCubierta;
                    dgv3.Rows[i].Cells[3].Value = camarotesList[i].NumCamarote;
                    dgv3.Rows[i].Cells[4].Value = camarotesList[i].IdTipoCamarote;
                    dgv3.Rows[i].Cells[5].Value = camarotesList[i].Ubicacion;
                    dgv3.Rows[i].Cells[6].Value = camarotesList[i].CantCamas;

                }

            }
            
        }

        private void cmd_agregar_Click(object sender, EventArgs e)
        {
            Frm_AgregarCamarote ventana = new Frm_AgregarCamarote();
            ventana.ShowDialog();

        }

        
        private void cmd_eliminar_Click(object sender, EventArgs e)
        {
            CamaroteService camaroteService = new CamaroteService();
            int id = -1;
            id = Convert.ToInt32(this.dgv3.CurrentRow.Cells["ID"].Value.ToString());

            if (id != -1)
            {
                camaroteService.deleteById(id);
                MessageBox.Show("Se eliminó con éxito");

            }
        }

        private void cmd_modificar_Click(object sender, EventArgs e)
        {
            //frm_editar_camarote ventana3 = new frm_editar_camarote();
            //ventana3.ShowDialog();
        }

        private void frm_abmc_TiposCamarote_Load(object sender, EventArgs e)
        {
            this.cmb_navio.cargar();
            this.cmb_navio.SelectedIndex = -1;
        }

        private void cmd_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
                







