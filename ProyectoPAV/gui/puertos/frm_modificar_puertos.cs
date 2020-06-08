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
    public partial class frm_modificar_puertos : Form
    {
        private string pp_nombre;
        private int pp_id;

        PuertoService puerto = new PuertoService();
        public frm_modificar_puertos(int pp_id,string pp_nombre)
        {
            this.pp_id = pp_id;
            this.pp_nombre = pp_nombre;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frm_modificar_puertos_Load(object sender, EventArgs e)
        {
            this.txt_nombre.Text = pp_nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Puerto puerto1 = new Puerto(pp_id, this.txt_nombre.Text);
            puerto.UpdatePuerto(puerto1);
            MessageBox.Show("El nombre se modifico con exito", "Mensaje", MessageBoxButtons.OK);
        }
    }
}
