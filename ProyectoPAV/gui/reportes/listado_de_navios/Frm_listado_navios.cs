using ProyectoPAV.entidades;
using ProyectoPAV.negocio.controllers;
using ProyectoPAV.negocio.servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoPAV.gui.reportes
{
    public partial class Frm_listado_navios : Form
    {
        private static NavioService navioService = new NavioService();
        
        public Frm_listado_navios()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.rv_listado_navio.RefreshReport();

            this.cmb_tipoNavio.cargar();
            this.cmb_tipoNavio.SelectedIndex = -1;

            this.cmb_campos.SelectedIndex = 1;
            this.rdb_top5.Checked = true;

           

            this.rv_listado_navio.RefreshReport();
        }

        private void cmd_generar_Click(object sender, EventArgs e)
        {
            
            GenerarListadoNavioController generarListadoNavioController = new GenerarListadoNavioController();

            
            this.rv_listado_navio.RefreshReport();
            generarListadoNavioController.tomarSeleccionTipoNavio(Convert.ToInt32(this.cmb_tipoNavio.SelectedValue));
        
            naviosBindingSource.DataSource = generarListadoNavioController.tomarConfirmacionGenerarListado();
            rv_listado_navio.RefreshReport();
        }

        private void chk_todos_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_todos.Checked)
            {
                this.cmb_tipoNavio.SelectedIndex = -1;
                this.cmb_tipoNavio.Enabled = false;

            }
            else
            {
                this.cmb_tipoNavio.Enabled = true;
            }
        }

        private void cmd_generar_estadTipoNavio_Click(object sender, EventArgs e)
        {

            this.generarEstadisticasTipoNavio();
        }

        private void generarEstadisticasTipoNavio()
        {

            GenerarEstadisticaTiposNavioController generarEstadisticaTiposNavioController = new GenerarEstadisticaTiposNavioController();

            generarEstadisticaTiposNavioController.calcularEstadisticas();

            List<string> legends = generarEstadisticaTiposNavioController.getLegends();
            List<int> values = generarEstadisticaTiposNavioController.getValues();
            int total = values.Sum();

            this.chart_tiposNavio.Series[0].Points.Clear();
            this.chart_tipoNavioBarras.Series[0].Points.Clear();
            this.chart_tipoNavioBarras.Series[0].Name = "Tipos de Navios";

            for (int i = 0; i < values.Count; i++)
            {
                int value = values[i];
                string legend = legends[i];
                float porcentaje = (value * 100) / total;

                this.chart_tiposNavio.Series[0].Points.Add(value);
                this.chart_tiposNavio.Series[0].Points.Last().LegendText = legend;
                this.chart_tiposNavio.Series[0].Points.Last().Label = porcentaje.ToString() + "%";

                this.chart_tipoNavioBarras.Series[0].Points.Add(value);
                this.chart_tipoNavioBarras.Series[0].Points.Last().Name = legend;
                this.chart_tipoNavioBarras.Series[0].Points.Last().Label = value.ToString();
                this.chart_tipoNavioBarras.Series[0].Points.Last().AxisLabel = legend;
            }

        }


        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if(tabControl1.SelectedTab == tabControl1.TabPages[1])
            {
                this.generarEstadisticasTipoNavio();
            }
        }

        private void generarEstadisticasNavios()
        {
            ControladorEstNavios controladorEstNavios = new ControladorEstNavios();

            controladorEstNavios.tomarSeleccionCampo(this.cmb_campos.SelectedIndex);

            if (rdb_top5.Checked)
            {
                controladorEstNavios.tomarSeleccionTop(5);
            }
            else
            {
                controladorEstNavios.tomarSeleccionTop(10);
            }

            controladorEstNavios.generarEstadisticas();

            List<string> navioNames = controladorEstNavios.getNavioNames();
            List<int> values = controladorEstNavios.getValues();

            this.chart_navios.Series[0].Points.Clear();
            this.chart_navios.Series[0].Points.Clear();
            this.chart_navios.ChartAreas[0].AxisY.Title = cmb_campos.SelectedItem.ToString();
            this.chart_navios.ChartAreas[0].AxisX.IsReversed = true;


            for (int i = 0; i < values.Count; i++)
            {
                int value = values[i];
                string navioName = navioNames[i];
                

                this.chart_navios.Series[0].Points.Add(value);
                this.chart_navios.Series[0].Points.Last().Label = navioName;
                
            }

        }
        private void cmd_generarEstNavios_Click(object sender, EventArgs e)
        {
            generarEstadisticasNavios();
        }
    }
}

           







  




       

            


