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
                

            }
        
        }
    }
}
