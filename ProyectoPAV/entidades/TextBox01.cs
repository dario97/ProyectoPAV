using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPAV.entidades
{
    class TextBox01 : TextBox
    {
        public bool pp_validar { get; set; }
        public string pp_nombre_tabla { get; set; }
        public string pp_nombre_campo { get; set; }
        public string pp_mensaje_error { get; set; }
        public TextBox01()
        {
            this.Font = new System.Drawing.Font(this.Font.Name, 10);
        }

    }
    
}
