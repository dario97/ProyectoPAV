﻿using System;
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
        public frm_alta_puertos()
        {
            InitializeComponent();
        }

        private void cmd_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}