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

namespace ProyectoPAV.gui.itinerarios
{
    public partial class Frm_gestionarItinerarios : Form
    {

        private ItinerarioService itinerarioService = new ItinerarioService();
        private EscalaService escalaService = new EscalaService();
        public Frm_gestionarItinerarios()
        {
            InitializeComponent();
        }

        private void Frm_gestionarItinerarios_Load(object sender, EventArgs e)
        {
            this.cmb_itinerarios.cargar();
            this.cmb_itinerarios.SelectedIndex = -1;
        }

        private void cargar_grillaItinerarios(List<Itinerario> itinerariosList)
        {
            this.dgv_itinerarios.Rows.Clear();
            if (itinerariosList.Count != 0)
            {
                for (int i = 0; i < itinerariosList.Count; i++)
                {
                        
                    dgv_itinerarios.Rows.Add();
                    dgv_itinerarios.Rows[i].Cells[0].Value = itinerariosList[i].IdItinerario;
                    dgv_itinerarios.Rows[i].Cells[1].Value = itinerariosList[i].Descripcion;
                    dgv_itinerarios.Rows[i].Cells[2].Value = itinerariosList[i].Categoria;

                }

            }

        }

        private void cargar_grillaEscalas(List<Escala> escalasList)
        {
            this.dgv_escalas .Rows.Clear();
            if (escalasList.Count != 0)
            {
                for (int i = 0; i < escalasList.Count; i++)
                {

                    dgv_escalas.Rows.Add();
                    dgv_escalas.Rows[i].Cells[0].Value = escalasList[i].Id;
                    dgv_escalas.Rows[i].Cells[1].Value = escalasList[i].NumEscala;
                    dgv_escalas.Rows[i].Cells[2].Value = escalasList[i].getPuerto().Nombre;

                }

            }

        }

        private void cmd_Buscar_Click(object sender, EventArgs e)
        {
            
            List<Escala> escalas = new List<Escala>();

            if(this.cmb_itinerarios.SelectedIndex != -1 && !this.chk_todos.Checked)
            {
                List<Itinerario> itinerarios = new List<Itinerario>();
                int id = Convert.ToInt32(this.cmb_itinerarios.SelectedValue);
                Itinerario itinerario = itinerarioService.GetById(id);
                escalas = escalaService.getAllEscalasDeUnItinerario(id);
                itinerarios.Add(itinerario);
                cargar_grillaItinerarios(itinerarios);
                cargar_grillaEscalas(escalas);

            }
            else
            {
                if (this.chk_todos.Checked)
                {
                    int id = Convert.ToInt32(this.cmb_itinerarios.SelectedValue);
                    List<Itinerario> itinerariosList = itinerarioService.GetAll();
                    cargar_grillaItinerarios(itinerariosList);
                }
                else
                {
                    MessageBox.Show("No ha ingresado ningún dato para realizar la búsqueda", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
                
        }

        private void cmd_agregar_Click(object sender, EventArgs e)
        {
            Frm_Agregar_Itinerario frm_Agregar_Itinerario = new Frm_Agregar_Itinerario();
            frm_Agregar_Itinerario.ShowDialog();
        }
    }
}
                    
                

                
                
