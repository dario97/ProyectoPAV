using ProyectoPAV.negocio.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPAV.gui.clases
{
    class MiCombito : ComboBox
    {
        BE_acceso_BD accesoBD = new BE_acceso_BD();

        public string pp_nombre_tabla_cargar { get; set; }
        public string pp_pk_tabla_cargar { get; set; }
        public string pp_descriptor_tabla_cargar { get; set; }
        public bool pp_validar { get; set; }
        public string pp_nombre_tabla { get; set; }
        public string pp_nombre_campo { get; set; }

        public void cargar()
        {
            string sql = "SELECT * FROM " + this.pp_nombre_tabla_cargar.Trim();
            this.DisplayMember = pp_descriptor_tabla_cargar;
            this.ValueMember = pp_pk_tabla_cargar;
            this.DataSource = accesoBD.ejecutarConsulta(sql);
        }
        
    }
}
