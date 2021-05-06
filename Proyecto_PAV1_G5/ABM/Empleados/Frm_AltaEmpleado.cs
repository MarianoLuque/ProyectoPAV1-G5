using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_PAV1_G5.Negocios;
using Proyecto_PAV1_G5.Clases;

namespace Proyecto_PAV1_G5.ABM.Empleados
{
    public partial class Frm_AltaEmpleado : Form
    {
        NE_Empleados emp = new NE_Empleados();
        public Frm_AltaEmpleado()
        {
            InitializeComponent();
        }
                        
        private void Frm_AltaEmpleado_Load_1(object sender, EventArgs e)
        {
            cmb_barrio.CargarCombo(emp.DatosComboBarrio());
            cmb_tipodoc.CargarCombo(emp.DatosComboTipoDoc());
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click_1(object sender, EventArgs e)
        {
            Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();

            if (tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {
                NE_Empleados empleado = new NE_Empleados();


                empleado.Insertar(this.Controls);
                if (MessageBox.Show("El empleado se registró con éxito", "Aviso", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                return;
            }
        }
    }
}