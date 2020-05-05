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
    public partial class Frm_Alta_Navio : Form
    {
        NavioService _navio = new NavioService();

        public Frm_Alta_Navio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Alta_Navio_Load(object sender, EventArgs e)
        {

        }

        private void cmd_Aceptar_Click(object sender, EventArgs e)
        {
            if (_navio.consultarPorNombre(this.txt_nombre) .Rows.Count==0)
            {

            }
        }
    }
}
