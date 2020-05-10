using ProyectoPAV.entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPAV.gui.Camarotes
{
    public partial class Frm_moficar_camarote : Form
    {

        private Camarote camarote;
        public Frm_moficar_camarote(Camarote camarote)
        {
            this.camarote = camarote;
            InitializeComponent();
        }

        private void cmd_aceptar_Click(object sender, EventArgs e)
        {

        }

        private void Frm_moficar_camarote_Load(object sender, EventArgs e)
        {
            this.txt_numcam.Text = camarote.NumCamarote.ToString();
            this.txt_camas.Text = camarote.CantCamas.ToString();
            this.txt_cubierta.Text = camarote.NumCubierta.ToString();
            this.txt_codigo.Text = camarote.IdNavio.ToString();
            this.txt_tipo.Text = camarote.IdTipoCamarote.ToString();
            this.txt_ubicacion.Text = camarote.Ubicacion;
        }
    }
}
