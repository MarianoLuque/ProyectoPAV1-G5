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

namespace Proyecto_PAV1_G5.ABM.Empleados
{
    public partial class Frm_ABMEmpleados : Form
    {
        public Frm_ABMEmpleados()
        {
            InitializeComponent();
        }
            
        private void CargarGrilla(DataTable tabla)
        {
            //Voy a recorrer la tabla con su contenido para cargar la grilla
            gridempleados.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                gridempleados.Rows.Add();
                gridempleados.Rows[i].Cells[0].Value = tabla.Rows[i]["tipo_documento"].ToString();
                gridempleados.Rows[i].Cells[1].Value = tabla.Rows[i]["nro_documento"].ToString();
                gridempleados.Rows[i].Cells[2].Value = tabla.Rows[i]["legajo"].ToString();
                gridempleados.Rows[i].Cells[3].Value = tabla.Rows[i]["apellido"].ToString();
                gridempleados.Rows[i].Cells[4].Value = tabla.Rows[i]["nombre"].ToString();
                gridempleados.Rows[i].Cells[5].Value = tabla.Rows[i]["barrio"].ToString();
                gridempleados.Rows[i].Cells[6].Value = tabla.Rows[i]["telefono"].ToString();
                gridempleados.Rows[i].Cells[7].Value = tabla.Rows[i]["fecha_ingreso"].ToString();
            }

        }

        private void btn_consultar_Click_1(object sender, EventArgs e)
        {
            NE_Empleados emp = new NE_Empleados();

            //if (txt_patron_razon_social.Text == "" && txt_patron_cuit.Text == "")
            //{
            //    CargarGrilla(emp.RecuperarTodos());
            //}
            //if (txt_patron_razon_social.Text != "" && txt_patron_cuit.Text != "")
            //{
            //    CargarGrilla(emp.Recuperar_Mixto(txt_patron_cuit.Text, txt_patron_razon_social.Text));
            //    return;
            //}
            //if (txt_patron_razon_social.Text != "")
            //{
            //    CargarGrilla(emp.Recuperar_x_Razon_Social(txt_patron_razon_social.Text));
            //}
            //if (txt_patron_cuit.Text != "")
            //{
            //    CargarGrilla(emp.Recuperar_x_Cuit(txt_patron_cuit.Text));
            //}
        }

        private void btn_agregar_Click_1(object sender, EventArgs e)
        {
            Frm_AltaEmpleado altaEmpleado = new Frm_AltaEmpleado();
            altaEmpleado.ShowDialog();
        }

        private void btn_editar_Click_1(object sender, EventArgs e)
        {
            Frm_ModificacionEmpleado modifEmpleado = new Frm_ModificacionEmpleado();
            string[] Pp_legajo = new string[1];
            Pp_legajo[0] = gridempleados.CurrentRow.Cells["legajo"].Value.ToString();
            modifEmpleado.Pp_legajo = Pp_legajo;
            modifEmpleado.ShowDialog();
        }

        private void btn_eliminar_Click_1(object sender, EventArgs e)
        {
            Frm_BajaEmpleado bajaCliente = new Frm_BajaEmpleado();
            string[] Pp_legajo = new string[1];
            Pp_legajo[0] = gridempleados.CurrentRow.Cells["legajo"].Value.ToString();
            bajaCliente.Pp_legajo = Pp_legajo;
            bajaCliente.ShowDialog();
        }
    }
}
