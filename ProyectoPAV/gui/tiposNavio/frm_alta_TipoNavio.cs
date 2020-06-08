using ProyectoPAV.entidades;
using ProyectoPAV.negocio.repository;
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
    public partial class frm_alta_TipoNavio : Form
    {

        private static TipoClasificacionNavioService tipoService = new TipoClasificacionNavioService();
        public frm_alta_TipoNavio()
        {
            InitializeComponent();
        }

        private void frm_alta_TipoNavio_Load(object sender, EventArgs e)
        {

        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if(this.txt_tipo.Text == "")
            {
                MessageBox.Show("No se ingresó ningún dato", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_tipo.Focus();
            }
            else
            {
                if (tipoService.GetByName(this.txt_tipo.Text).Count == 0)
                {
                    string nombre = this.txt_tipo.Text;

                    TipoClasificacionNavio tipo = new TipoClasificacionNavio(nombre);

                    tipoService.CreateTipoNavio(tipo);

                    MessageBox.Show("Se creó el tipo " + nombre + " Exitosamente."
                                , "Mensaje"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Exclamation);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El Tipo ya existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            
        }


        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
