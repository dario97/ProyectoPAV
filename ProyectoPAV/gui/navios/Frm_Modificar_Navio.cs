using ProyectoPAV.negocio.servicios;
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

namespace ProyectoPAV.gui
{
    public partial class Frm_Modificar_Navio : Form
    {

        private int pp_codigo;
        private string pp_nombre;
        private float pp_altura;
        private float pp_autonomia;
        private float pp_desplazamiento;
        private float pp_eslora;
        private float pp_manga;
        private int pp_cantMaxPasajeros;
        private int pp_cantTripulantes;
        private int pp_tipoClasificacion;
        private int pp_cantMotores;

        NavioService tipoService = new NavioService();

        public Frm_Modificar_Navio(int codigo, string nombre, float altura, float autonomia, float desplazamiento, float eslora, float manga, int cantMaxPasajeros, int cantTripulantes, int tipoClasificacion, int cantMotores)
        {
            this.pp_codigo = codigo;
            this.pp_nombre = nombre;
            this.pp_altura = altura;
            this.pp_autonomia = autonomia;
            this.pp_desplazamiento = desplazamiento;
            this.pp_eslora = eslora;
            this.pp_manga = manga;
            this.pp_cantMaxPasajeros = cantMaxPasajeros;
            this.pp_cantTripulantes = cantTripulantes;
            this.pp_tipoClasificacion = tipoClasificacion;
            this.pp_cantMotores = cantMotores;
          

            InitializeComponent();
        }

        private void cmd_aceptar_Click(object sender, EventArgs e)
        {
            Navio navio = new Navio(pp_codigo, this.txt_navio.Text, Convert.ToSingle(this.txt_altura.Text), Convert.ToSingle(this.txt_autonomia.Text), Convert.ToSingle(this.txt_desplazamiento.Text), Convert.ToSingle(this.txt_eslora.Text), Convert.ToSingle(this.txt_manga.Text), Convert.ToInt32(this.txt_cant_max_pasajeros.Text), Convert.ToInt32(this.txt_cant_tripulantes.Text), Convert.ToInt32(this.txt_clasificacion.Text), Convert.ToInt32(this.txt_cant_motores.Text));
            tipoService.UpdateNavio(navio);
            MessageBox.Show("El navío se modificó correctamente", "Mensaje", MessageBoxButtons.OK);
        }

        private void Frm_Modificar_Navio_Load(object sender, EventArgs e)
        {
            this.txt_navio.Text = pp_nombre;
            this.txt_manga.Text = pp_manga.ToString();
            this.txt_eslora.Text = pp_eslora.ToString();
            this.txt_desplazamiento.Text = pp_desplazamiento.ToString();
            this.txt_clasificacion.Text = pp_tipoClasificacion.ToString();
            this.txt_cant_tripulantes.Text = pp_cantTripulantes.ToString();
            this.txt_cant_motores.Text = pp_cantMotores.ToString();
            this.txt_cant_max_pasajeros.Text = pp_cantMaxPasajeros.ToString();
            this.txt_autonomia.Text = pp_autonomia.ToString();
            this.txt_altura.Text = pp_altura.ToString();    
        
        }
        
    }
}
