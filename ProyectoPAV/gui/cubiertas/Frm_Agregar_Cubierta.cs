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
    }
}
