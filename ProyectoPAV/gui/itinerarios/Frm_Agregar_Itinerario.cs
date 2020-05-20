using ProyectoPAV.entidades;
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
        public Frm_Agregar_Itinerario()
        {
            InitializeComponent();
        }
        private void Frm_Agregar_Itinerario_Load(object sender, EventArgs e)
        {
            escalasList = new List<Escala>();
            this.cmb_puerto.cargar();
            this.cmb_puerto.SelectedIndex = -1;
        }

        private void cmd_agregar_Click(object sender, EventArgs e)
        {
            Escala escala = null;

            int numEscala = Convert.ToInt32(this.txt_numEscala.Text);
            int idPuerto = Convert.ToInt32(this.cmb_puerto.SelectedValue);

            escala = new Escala(numEscala, idPuerto);

            escalasList.Add(escala);

            cargar_grilla(escalasList);


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
                    dgv_escalas.Rows[i].Cells[1].Value = escalasList[i].IdPuerto;
                }

            }

        }
                    

        private void cmd_aceptar_Click(object sender, EventArgs e)
        {
            string descripcion = this.txt_descripcion.Text;
            string categoria = this.txt_categoria.Text;

            Itinerario itinerario = new Itinerario(descripcion, categoria, escalasList);


        }

        private void cmd_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
