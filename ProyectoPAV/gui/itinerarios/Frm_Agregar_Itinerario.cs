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
    public partial class Frm_Agregar_Itinerario : Form
    {
        private List<Escala> escalasList;
        private static ItinerarioService itinerarioService = new ItinerarioService();
        public Frm_Agregar_Itinerario()
        {
            InitializeComponent();
        }
        private void Frm_Agregar_Itinerario_Load(object sender, EventArgs e)
        {
            escalasList = new List<Escala>();
            this.cmb_puerto.cargar();
            this.cmb_puerto.SelectedIndex = -1;
            this.cmd_agregar.Enabled = false;
            this.txt_numEscala.Enabled = false;
            this.cmb_puerto.Enabled = false;
        }

        private void cmd_agregar_Click(object sender, EventArgs e)
        {
            Escala escala = null;

            if (this.txt_descripcion.Text == "" || this.txt_categoria.Text == "" || this.txt_numEscala.Text == "" || this.cmb_puerto.SelectedIndex == -1)
            {
                MessageBox.Show("No se cargó ningún dato", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int numEscala = Convert.ToInt32(this.txt_numEscala.Text);
                int idPuerto = Convert.ToInt32(this.cmb_puerto.SelectedValue);

                escala = new Escala(numEscala, idPuerto);

                escalasList.Add(escala);
                this.txt_numEscala.Text = "";
                this.cmb_puerto.SelectedIndex = -1;

                cargar_grilla(escalasList);
            }

            


        }

        private void cargar_grilla(List<Escala> escalasList)
        {
            this.dgv_escalas.Rows.Clear();
            if (escalasList.Count != 0)
            {
                for (int i = 0; i < escalasList.Count; i++)
                {
                    dgv_escalas.Rows.Add();
                    
                    dgv_escalas.Rows[i].Cells[0].Value = escalasList[i].NumEscala;
                    dgv_escalas.Rows[i].Cells[1].Value = escalasList[i].getPuerto().Nombre;
                }

            }

        }
                    

        private void cmd_aceptar_Click(object sender, EventArgs e)
        {
            if (this.txt_descripcion.Text == "" || this.txt_categoria.Text == "")
            {
                MessageBox.Show("Debe cargar Descripción y Categoría del Itinerario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string descripcion = this.txt_descripcion.Text;
                string categoria = this.txt_categoria.Text;

                Itinerario itinerario = new Itinerario(descripcion, categoria, escalasList);

                itinerarioService.cargarItinerario(itinerario);

                MessageBox.Show("Carga de itinerario finalizada con éxtio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
            



        private void cmd_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {
            setAgregarPuertoFieldsVisibility();
        }

        private void setAgregarPuertoFieldsVisibility()
        {
            if(this.txt_descripcion.Text != "" && this.txt_categoria.Text != "")
            {
                
                this.txt_numEscala.Enabled = true;
                this.cmb_puerto.Enabled = true;
            }
            else
            {
                
                this.txt_numEscala.Enabled = false;
                this.cmb_puerto.Enabled = false;
            }
        }

        private void setAgregarButtonVisibility()
        {
            if(this.txt_numEscala.Text != "" && this.cmb_puerto.SelectedIndex != -1)
            {
                this.cmd_agregar.Enabled = true;
            }
            else
            {
                this.cmd_agregar.Enabled = false;
            }
        }

        private void txt_categoria_TextChanged(object sender, EventArgs e)
        {

            setAgregarPuertoFieldsVisibility();

        }

        

        private void txt_numEscala_TextChanged(object sender, EventArgs e)
        {
            setAgregarButtonVisibility();
        }

        private void cmb_puerto_SelectedValueChanged(object sender, EventArgs e)
        {
            setAgregarButtonVisibility();
        }

        private void cmd_eliminar_Click(object sender, EventArgs e)
        {
            int numEscala = Convert.ToInt32(this.dgv_escalas.CurrentRow.Cells["Num_escala"].Value.ToString());
            for(int i = 0; i<escalasList.Count; i++)
            {
                if(escalasList[i].NumEscala == numEscala)
                {
                    escalasList.RemoveAt(i);
                }
            }
            cargar_grilla(escalasList);
        }
    }
}
