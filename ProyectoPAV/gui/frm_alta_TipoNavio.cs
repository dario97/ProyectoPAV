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
            if (tipoService.consultarPorNombre(this.txt_tipo.Text).Rows.Count == 0)
            {
                string nombre = this.txt_tipo.Text;
                
                TipoClasificacionNavio tipo = new TipoClasificacionNavio(nombre);

                tipoService.crearTipoClasificacionNavio(tipo);

                MessageBox.Show("Se grabó exitosamente los datos"
                            , "Mensaje"
                            , MessageBoxButtons.OK
                            , MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
            {
                MessageBox.Show("El Tipo ya existe", "Hola", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        
    }
}
