﻿using ProyectoPAV.entidades;
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
        private static NavioService navioService = new NavioService();

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
            if (navioService.GetByName(this.txt_nombre.Text).Count==0)
            {
                string nombre = this.txt_nombre.Text;
                float altura = Convert.ToSingle(this.txt_altura.Text);
                float autonomia = Convert.ToSingle(this.txt_autonomia.Text);
                float desplazamiento = Convert.ToSingle(this.txt_desplazamiento.Text);
                float eslora = Convert.ToSingle(this.txt_eslora.Text);
                float manga = Convert.ToSingle(this.txt_manga.Text);
                int cantMaxPasajeros = Convert.ToInt32(this.txt_pasajeros.Text);
                int cantTripulantes = Convert.ToInt32(this.txt_tripulantes.Text);
                int tipoClasificacion = Convert.ToInt32(this.txt_clasificacion.Text);
                int cantMotores = Convert.ToInt32(this.txt_motores.Text);
                Navio navio = new Navio(nombre, altura, autonomia, desplazamiento, eslora, manga, cantMaxPasajeros, cantTripulantes, tipoClasificacion, cantMotores);

                navioService.CreateNavio(navio);

                MessageBox.Show("Se grabó exitosamente los datos"
                            , ""
                            , MessageBoxButtons.OK
                            , MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
            {
                MessageBox.Show("El Navío ya existe", "" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

                

        }

        private void cmd_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox011_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
