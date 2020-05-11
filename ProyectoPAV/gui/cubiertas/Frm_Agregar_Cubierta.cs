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
    public partial class Frm_Agregar_Cubierta : Form
    {
        public Frm_Agregar_Cubierta()
        {
            InitializeComponent();
        }

        private void Frm_Agregar_Cubierta_Load(object sender, EventArgs e)
        {
            this.miCombito1.cargar();
            miCombito1.SelectedIndex = -1;
        }

        private void cmd_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cmd_aceptar_Click(object sender, EventArgs e)
        {
            CubiertaService cubiertaService = new CubiertaService();

            if (this.miCombito1.SelectedIndex == -1  || this.txt_numCubierta.Text == "" || this.txt_descripcion.Text == "")
            {
                MessageBox.Show("Faltan datos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                

                int idNavio = Convert.ToInt32(this.miCombito1.SelectedValue);
                int numCubierta = Convert.ToInt32(this.txt_numCubierta.Text.ToString());
                string descripcion = this.txt_descripcion.Text.ToString();
                int legajoEncargado = this.txt_legEncargado.Text.ToString() == "" ? 0 : Convert.ToInt32(this.txt_legEncargado.Text.ToString());
                
                
                

                Cubierta cubiertaConsulta = cubiertaService.consultarCubierta(idNavio, numCubierta);

                if (cubiertaConsulta == null)
                {
                    Cubierta cubierta = new Cubierta(idNavio, numCubierta, descripcion, legajoEncargado);
                    cubiertaService.crearCubierta(cubierta);
                    MessageBox.Show("Se creó con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Ya existe una Cubierta con esos datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }



            }
        
        }
    }
}
