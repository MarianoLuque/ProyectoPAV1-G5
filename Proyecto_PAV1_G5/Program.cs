using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_PAV1_G5.ABM.Articulos;
using Proyecto_PAV1_G5.ABM.Categoria;
using Proyecto_PAV1_G5.ABM.Clientes;
using Proyecto_PAV1_G5.ABM.Empleados;
using Proyecto_PAV1_G5.ABM.Equipos;
using Proyecto_PAV1_G5.ABM.Equipos.Equipos_Especiales;
using Proyecto_PAV1_G5.ABM.FormasPago;
using Proyecto_PAV1_G5.ABM.Proveedores;
using Proyecto_PAV1_G5.ABM.Rubros;

namespace Proyecto_PAV1_G5
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Principal());
            Application.Run(new Frm_Login()); 
            //Application.Run(new Frm_ABMArticulos());
            //Application.Run(new Frm_ABMEquipoEspecial());
        }
    }
}
