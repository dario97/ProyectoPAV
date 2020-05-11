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
    public partial class Frm_abmc_cubierta : Form
    {
        public Frm_abmc_cubierta()
        {
            InitializeComponent();
            this.tooltip.SetToolTip(cmd_agregar, "Agregar nueva cubierta");
            this.tooltip.SetToolTip(cmd_editar, "Modificar cubierta");
            this.tooltip.SetToolTip(cmd_eliminar, "Eliminar cubierta seleccionada");
            this.tooltip.SetToolTip(cmd_salir, "Salir al menu principal");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_abmc_cubierta_Load(object sender, EventArgs e)
        {

        }
    }
}
