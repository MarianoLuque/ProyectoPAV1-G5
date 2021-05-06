﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_PAV1_G5.BackEnd;
using System.Windows.Forms;

namespace Proyecto_PAV1_G5.Clases
{
    class ComboBox01 : ComboBox
    {
        //Creo que se pueden sacar las 3 primeras Pp
        //public string Pp_Pk { get; set; }
        //public string Pp_descripcion { get; set; }
        //public string Pp_tabla { get; set; }
        public bool Pp_Conseleccion { get; set; }
        public bool Pp_Validable { get; set; }
        public string Pp_MensajeError { get; set; }
        public string Pp_NombreCampo { get; set; }

        Acceso_Datos _BD = new Acceso_Datos();

        public void CargarCombo(Estructura_ComboBox edc)
        {

            this.DisplayMember = edc.Display;
            this.ValueMember = edc.Value;
            this.DataSource = edc.Tabla;

            if (this.Pp_Conseleccion == true)
            {
                this.SelectedIndex = 0;
            }
            else
            {
                this.SelectedIndex = -1;
            }
        }
    }
}
