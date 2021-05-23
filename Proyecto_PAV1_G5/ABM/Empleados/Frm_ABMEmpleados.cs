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
        public string[] Pp_legajo { get; set; }
        NE_Empleados emp = new NE_Empleados();

        public Frm_ABMEmpleados()
        {
            InitializeComponent();
        }
            
        private void CargarGrilla(DataTable tabla)
        {
            //Voy a recorrer la tabla con su contenido para cargar la grilla
            grid_empleados.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_empleados.Rows.Add();
                grid_empleados.Rows[i].Cells[0].Value = tabla.Rows[i]["legajo"].ToString();
                grid_empleados.Rows[i].Cells[1].Value = tabla.Rows[i]["documento"].ToString();
                grid_empleados.Rows[i].Cells[2].Value = tabla.Rows[i]["nro_documento"].ToString();
                grid_empleados.Rows[i].Cells[3].Value = tabla.Rows[i]["nombre"].ToString();
                grid_empleados.Rows[i].Cells[4].Value = tabla.Rows[i]["apellido"].ToString();
                grid_empleados.Rows[i].Cells[5].Value = tabla.Rows[i]["fecha_ingreso"].ToString().Split()[0];
                grid_empleados.Rows[i].Cells[6].Value = tabla.Rows[i]["telefono"].ToString();
                grid_empleados.Rows[i].Cells[7].Value = tabla.Rows[i]["barrio"].ToString();
            }
        }

        private void btn_consultar_Click_1(object sender, EventArgs e)
        {
            if(cmb_tipo_doc.SelectedIndex == -1 && txt_patron_apellido.Text=="" && txt_patron_legajo.Text=="" && txt_patron_nro_doc.Text =="")
            {
                CargarGrilla(emp.RecuperarTodos());
            }
            if(cmb_tipo_doc.SelectedIndex == -1 && txt_patron_apellido.Text == "" && txt_patron_legajo.Text == "" && txt_patron_nro_doc.Text != "")
            {
                CargarGrilla(emp.Recuperar_x_Numero_Documento(txt_patron_nro_doc.Text));
            }
            if (cmb_tipo_doc.SelectedIndex == -1 && txt_patron_apellido.Text == "" && txt_patron_legajo.Text != "" && txt_patron_nro_doc.Text == "")
            {
                CargarGrilla(emp.Recuperar_x_Legajo(txt_patron_legajo.Text));
            }
            if (cmb_tipo_doc.SelectedIndex == -1 && txt_patron_apellido.Text != "" && txt_patron_legajo.Text == "" && txt_patron_nro_doc.Text == "")
            {
                CargarGrilla(emp.Recuperar_x_Apellido(txt_patron_apellido.Text));
            }
            if (cmb_tipo_doc.SelectedIndex != -1 && txt_patron_apellido.Text == "" && txt_patron_legajo.Text == "" && txt_patron_nro_doc.Text == "")
            {
                CargarGrilla(emp.Recuperar_x_Tipo_Documento(cmb_tipo_doc.SelectedValue.ToString()));
            }
            if (cmb_tipo_doc.SelectedIndex == -1 && txt_patron_apellido.Text == "" && txt_patron_legajo.Text != "" && txt_patron_nro_doc.Text != "")
            {
                CargarGrilla(emp.Recuperar_x_Numero_Documento_y_Legajo(txt_patron_legajo.Text, txt_patron_nro_doc.Text));
            }
            if (cmb_tipo_doc.SelectedIndex == -1 && txt_patron_apellido.Text != "" && txt_patron_legajo.Text == "" && txt_patron_nro_doc.Text != "")
            {
                CargarGrilla(emp.Recuperar_x_Numero_Documento_y_Apellido(txt_patron_apellido.Text, txt_patron_nro_doc.Text));
            }
            if (cmb_tipo_doc.SelectedIndex != -1 && txt_patron_apellido.Text == "" && txt_patron_legajo.Text == "" && txt_patron_nro_doc.Text != "")
            {
                CargarGrilla(emp.Recuperar_x_Tipo_y_Numero_Documento(txt_patron_nro_doc.Text, cmb_tipo_doc.SelectedValue.ToString()));
            }
            if (cmb_tipo_doc.SelectedIndex == -1 && txt_patron_apellido.Text != "" && txt_patron_legajo.Text != "" && txt_patron_nro_doc.Text == "")
            {
                CargarGrilla(emp.Recuperar_x_Apellido_y_Legajo(txt_patron_apellido.Text, txt_patron_legajo.Text));
            }
            if (cmb_tipo_doc.SelectedIndex != -1 && txt_patron_apellido.Text == "" && txt_patron_legajo.Text != "" && txt_patron_nro_doc.Text == "")
            {
                CargarGrilla(emp.Recuperar_x_Tipo_Documento_y_Legajo(txt_patron_legajo.Text, cmb_tipo_doc.SelectedValue.ToString()));
            }
            if (cmb_tipo_doc.SelectedIndex != -1 && txt_patron_apellido.Text != "" && txt_patron_legajo.Text == "" && txt_patron_nro_doc.Text == "")
            {
                CargarGrilla(emp.Recuperar_x_Tipo_Documento_y_Apellido(txt_patron_apellido.Text, cmb_tipo_doc.SelectedValue.ToString()));
            }
            if (cmb_tipo_doc.SelectedIndex == -1 && txt_patron_apellido.Text != "" && txt_patron_legajo.Text != "" && txt_patron_nro_doc.Text != "")
            {
                CargarGrilla(emp.Recuperar_x_Apellido_Legajo_y_Numero_Documento(txt_patron_apellido.Text, txt_patron_legajo.Text, txt_patron_nro_doc.Text));
            }
            if (cmb_tipo_doc.SelectedIndex != -1 && txt_patron_apellido.Text == "" && txt_patron_legajo.Text != "" && txt_patron_nro_doc.Text != "")
            {
                CargarGrilla(emp.Recuperar_x_Tipo_y_Numero_Documento_y_Legajo(txt_patron_legajo.Text, cmb_tipo_doc.SelectedValue.ToString(), txt_patron_nro_doc.Text));
            }
            if (cmb_tipo_doc.SelectedIndex != -1 && txt_patron_apellido.Text != "" && txt_patron_legajo.Text == "" && txt_patron_nro_doc.Text != "")
            {
                CargarGrilla(emp.Recuperar_x_Tipo_y_Numero_Documento_y_Apellido(txt_patron_apellido.Text, cmb_tipo_doc.SelectedValue.ToString(), txt_patron_nro_doc.Text));
            }
            if (cmb_tipo_doc.SelectedIndex != -1 && txt_patron_apellido.Text != "" && txt_patron_legajo.Text != "" && txt_patron_nro_doc.Text == "")
            {
                CargarGrilla(emp.Recuperar_x_Tipo_Documento_Legajo_y_Apellido(txt_patron_apellido.Text, cmb_tipo_doc.SelectedValue.ToString(), txt_patron_legajo.Text));
            }
            if (cmb_tipo_doc.SelectedIndex != -1 && txt_patron_apellido.Text != "" && txt_patron_legajo.Text != "" && txt_patron_nro_doc.Text != "")
            {
                CargarGrilla(emp.Recuperar_x_Tipo_y_Numero_Documento_Apellido_y_Legajo(txt_patron_apellido.Text, cmb_tipo_doc.SelectedValue.ToString(), txt_patron_nro_doc.Text, txt_patron_legajo.Text));
            }
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
            Pp_legajo[0] = grid_empleados.CurrentRow.Cells["legajo"].Value.ToString();
            modifEmpleado.Pp_legajo = Pp_legajo;
            modifEmpleado.ShowDialog();
        }

        private void btn_eliminar_Click_1(object sender, EventArgs e)
        {
            Frm_BajaEmpleado bajaCliente = new Frm_BajaEmpleado();
            string[] Pp_legajo = new string[1];
            Pp_legajo[0] = grid_empleados.CurrentRow.Cells["legajo"].Value.ToString();
            bajaCliente.Pp_legajo = Pp_legajo;
            bajaCliente.ShowDialog();
        }

        private void Frm_ABMEmpleados_Load(object sender, EventArgs e)
        {
            cmb_tipo_doc.CargarCombo(emp.DatosComboTipoDoc());
        }
    }
}
