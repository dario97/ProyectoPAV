﻿using ProyectoPAV.gui.itinerarios;
using ProyectoPAV.gui.reportes;
using ProyectoPAV.gui.tipoCamarote;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            frm_abmc_puertos abrir1 = new frm_abmc_puertos();
            abrir1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_Navio abrir3 = new Frm_Navio();
            abrir3.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_abmc_usuarios abrir4 = new frm_abmc_usuarios();
            abrir4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_abmc_tipoNavio abrir5 = new frm_abmc_tipoNavio();
            abrir5.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm_abmc_TiposCamarote abrir6 = new frm_abmc_TiposCamarote();
           
            abrir6.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttn_tiposDeCamarote_Click(object sender, EventArgs e)
        {
            Frm_abmc_tipoCamarote frm_Abmc_TipoCamarote = new Frm_abmc_tipoCamarote();
            frm_Abmc_TipoCamarote.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Frm_abmc_cubierta frmCubierta = new Frm_abmc_cubierta();
            frmCubierta.ShowDialog();
        }

        private void bttn_itinerarios_Click(object sender, EventArgs e)
        {
            Frm_gestionarItinerarios frm_gestionar_itinerarios = new Frm_gestionarItinerarios();
            frm_gestionar_itinerarios.ShowDialog();
        }

        private void cmd_reportes_Click(object sender, EventArgs e)
        {
            Frm_listado_navios frm = new Frm_listado_navios();
            frm.ShowDialog();
        }
    }
}
