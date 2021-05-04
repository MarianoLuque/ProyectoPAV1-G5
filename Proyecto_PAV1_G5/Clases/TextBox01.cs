using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PAV1_G5.Clases
{
    class TextBox01 : TextBox
    {
        public string Pp_tabla { get; set; }
        public string Pp_campo { get; set; }
        public bool Pp_Validable { get; set; }
        public string Pp_MensajeError { get; set; }
    }
}
