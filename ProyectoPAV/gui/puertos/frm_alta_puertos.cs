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

namespace ProyectoPAV.entidades
{
    public partial class frm_alta_puertos : Form
    {
        PuertoService puerto = new PuertoService();
        public frm_alta_puertos()
        {
            InitializeComponent();
        }

        private void cmd_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_crear_Click(object sender, EventArgs e)
        {
            if(this.txt_nombre.Text=="")
            {
                MessageBox.Show("No se ingresó ningún dato", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
            }
            else
            {
                if(puerto.GetByName(this.txt_nombre.Text).Count==0)
                {
                    string nombre = this.txt_nombre.Text;
                    
                    Puerto puerto1 = new Puerto(nombre);
                    puerto.CreatePuerto(puerto1);
                    MessageBox.Show("Se creó el puerto " + nombre + " Exitosamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

