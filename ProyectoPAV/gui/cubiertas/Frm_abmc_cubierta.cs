using ProyectoPAV.entidades;
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
            this.miCombito1.cargar();
            this.miCombito1.SelectedIndex = -1;
        }

        private void cmd_agregar_Click(object sender, EventArgs e)
        {
            Frm_Agregar_Cubierta frmAgregar = new Frm_Agregar_Cubierta();
            frmAgregar.ShowDialog();
        }

        private void cmd_editar_Click(object sender, EventArgs e)
        {
            Frm_Modificar_Cubierta frmModificar = new Frm_Modificar_Cubierta();
            frmModificar.ShowDialog();
        }

        private void cmd_eliminar_Click(object sender, EventArgs e)
        {
            CubiertaService cubiertaService = new CubiertaService();
            int id = -1;
            id = Convert.ToInt32(this.dvg1.CurrentRow.Cells["ID"].Value.ToString());

            if (id != -1)
            {
                cubiertaService.deleteById(id);
                MessageBox.Show("Se eliminó con éxito");

            }
        }

        private void cmd_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_consultar_Click(object sender, EventArgs e)
        {
            CubiertaService cubiertaService = new CubiertaService();
            List<Cubierta> cubiertasList = new List<Cubierta>();

            if (chk_todos.Checked)
            {
               cubiertasList = cubiertaService.getAll();
               cargar_grilla(cubiertasList);
            }
            else
            {
                

                if (Convert.ToInt32(this.miCombito1.SelectedIndex.ToString()) != -1 && this.txt_nroCubierta.Text.ToString() != "")
                {
                    int codNavio = Convert.ToInt32(this.miCombito1.SelectedValue.ToString());
                    int numCubierta = Convert.ToInt32(this.txt_nroCubierta.Text.ToString());

                    Cubierta cubierta = cubiertaService.consultarCubierta(codNavio, numCubierta);

                    if(cubierta != null)
                    {
                        cubiertasList.Add(cubierta);
                        cargar_grilla(cubiertasList);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ninguna cubierta con esos datos", " Mensaje", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    MessageBox.Show("Faltan datos", " Mensaje", MessageBoxButtons.OK);
                }
            }
        }

        private void cargar_grilla(List<Cubierta> cubiertasList)
        {
            this.dvg1.Rows.Clear();
            if (cubiertasList.Count != 0)
            {
                for (int i = 0; i < cubiertasList.Count; i++)
                {
                    
                    this.dvg1.Rows.Add();
                    dvg1.Rows[i].Cells[0].Value = cubiertasList[i].Id;
                    dvg1.Rows[i].Cells[1].Value = cubiertasList[i].IdNavio;
                    dvg1.Rows[i].Cells[2].Value = cubiertasList[i].NumCubierta;
                    dvg1.Rows[i].Cells[3].Value = cubiertasList[i].Descripcion;
                    dvg1.Rows[i].Cells[4].Value = cubiertasList[i].LegajoEncargado;
                   

                }

            }

        }

     
    }
}
