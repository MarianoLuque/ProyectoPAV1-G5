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
    public partial class Frm_ModificacionEmpleado : Form
    {
        public string[] Pp_legajo { get; set; }
        NE_Empleados emp = new NE_Empleados();
        public Frm_ModificacionEmpleado()
        {
            InitializeComponent();
        }


        private void MostrarDatos(DataTable tabla)
        {
            cmb_barrio.SelectedValue = int.Parse(tabla.Rows[0]["id_barrio"].ToString());
            txt_numdoc.Text = tabla.Rows[0]["nro_documento"].ToString();
            txt_apellido.Text = tabla.Rows[0]["apellido"].ToString();
            txt_nombre.Text = tabla.Rows[0]["nombre"].ToString();
            txt_telefono.Text = tabla.Rows[0]["telefono"].ToString();
            txt_legajo.Text = tabla.Rows[0]["legajo"].ToString();
            txt_fechaingreso.Text = tabla.Rows[0]["fecha_ingreso"].ToString();
            cmb_tipodoc.SelectedValue = int.Parse(tabla.Rows[0]["id_tipo_documento"].ToString());
            txt_usuario.Text = tabla.Rows[0]["usuario"].ToString();
            txt_contrasena.Text = tabla.Rows[0]["contrasena"].ToString();
            txt_calle.Text = tabla.Rows[0]["calle"].ToString();
            txt_nro_calle.Text = tabla.Rows[0]["nro_calle"].ToString();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();

            if (tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {
                NE_Empleados empleado = new NE_Empleados();


                empleado.Modificar(Pp_legajo, this.Controls);
                if (MessageBox.Show("El empleado se modificó con éxito", "Aviso", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                return;
            }
        }

        private void Frm_ModificacionEmpleado_Load_1(object sender, EventArgs e)
        {
            cmb_barrio.CargarCombo(emp.DatosComboBarrio());
            cmb_tipodoc.CargarCombo(emp.DatosComboTipoDoc());
            MostrarDatos(emp.Recuperar_x_Legajo_Array(Pp_legajo));
        }
    }
}