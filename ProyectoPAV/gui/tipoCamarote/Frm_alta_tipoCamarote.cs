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

namespace ProyectoPAV.gui.tipoCamarote
{
    public partial class Frm_alta_tipoCamarote : Form
    {
        private static TipoCamaroteService tipoCamaroteService;
        public Frm_alta_tipoCamarote()
        {
            tipoCamaroteService = new TipoCamaroteService();
            InitializeComponent();
        }

        private void bttn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttn_aceptar_Click(object sender, EventArgs e)
        {
            if (this.txt_tipo.Text == "")
            {
                MessageBox.Show("No se ingresó ningún dato", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_tipo.Focus();
            }
            else
            {
                if (tipoCamaroteService.consultarPorNombre(this.txt_tipo.Text).Rows.Count == 0)
                {
                    string nombre = this.txt_tipo.Text;

                    TipoCamarote tipoCamarote = new TipoCamarote(nombre);
                    tipoCamaroteService.crearTipoCamarote(tipoCamarote);
                    MessageBox.Show("Se creó el tipo de camarote " + nombre + " Exitosamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El  puerto ya existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
