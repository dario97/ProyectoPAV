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
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_abmc_Puestos abrir = new Frm_abmc_Puestos();
            abrir.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
