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
using Microsoft.Reporting.WinForms;

namespace Proyecto_PAV1_G5.Reportes_y_Estadísticas.Listados
{
    public partial class Frm_ReporteEmpleados : Form
    {
        DataTable Tabla = new DataTable();
        NE_Empleados empleado = new NE_Empleados();

        public Frm_ReporteEmpleados()
        {
            InitializeComponent();
        }

        private void Frm_ReporteEmpleados_Load(object sender, EventArgs e)
        {
            cmb_tipo_documento.CargarCombo(empleado.DatosComboTipoDoc());
            cmb_tipo_documento.SelectedIndex = -1;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (BuscarDatos())
            {
                CargarReporte(Tabla);
            }
        }

        private bool BuscarDatos()
        {
            bool apellido = false;
            bool nombre = false;
            bool tipo_doc = false;

            bool banderaRB1 = false;
            bool banderaRB2 = false;
            bool banderaRB3 = false;
            bool banderaRB4 = false;

            bool fechaDesde = false;
            bool fechaHasta = false;
            bool ambasFechas = false;

            if (txt_patron_nombre.Text.Trim() != "")
            {
                nombre = true;
                if (rb01.Checked == true)
                {
                    banderaRB1 = true;
                }
                if (rb02.Checked == true)
                {
                    banderaRB2 = true;
                }
                if (rb01.Checked == false && rb02.Checked == false)
                {
                    MessageBox.Show("Falta elegir el tipo de patron a aplicar para el nombre del empleado");
                    return false;
                }
            }

            if (txt_patron_apellido.Text.Trim() != "")
            {
                apellido = true;
                if (rb03.Checked == true)
                {
                    banderaRB3 = true;
                }
                if (rb04.Checked == true)
                {
                    banderaRB4 = true;
                }
                if (rb03.Checked == false && rb04.Checked == false)
                {
                    MessageBox.Show("Falta elegir el tipo de patron a aplicar para el apellido del empleado");
                    return false;
                }
            }

            if (txt_fechaDesde.MaskFull)
            {
                fechaDesde = true;
            }
            if (txt_fechaHasta.MaskFull)
            {
                fechaHasta = true;
            }
            if (txt_fechaDesde.MaskFull && txt_fechaHasta.MaskFull)
            {
                fechaDesde = false;
                fechaHasta = false;
                ambasFechas = true;
            }

            if (cmb_tipo_documento.SelectedIndex != -1)
            {
                tipo_doc = true;
                Tabla = empleado.ReporteEmpleados(banderaRB1, banderaRB2, banderaRB3, banderaRB4, tipo_doc, fechaDesde, fechaHasta, nombre, apellido, ambasFechas, txt_patron_nombre.Text, txt_patron_apellido.Text, txt_fechaDesde.Text, txt_fechaHasta.Text, cmb_tipo_documento.SelectedValue.ToString());
                return true;
            }

            Tabla = empleado.ReporteEmpleados(banderaRB1, banderaRB2, banderaRB3, banderaRB4, tipo_doc, fechaDesde, fechaHasta, nombre, apellido, ambasFechas, txt_patron_nombre.Text, txt_patron_apellido.Text, txt_fechaDesde.Text, txt_fechaHasta.Text, "");
            return true;
        }

        private void CargarReporte(DataTable tabla)
        {
            bool fechas = false;
            string restriccion = "Restricciones: \n";

            if (txt_patron_nombre.Text != "")
            {
                if (rb01.Checked == true)
                {
                    restriccion += "  - Nombre empezado con " + txt_patron_nombre.Text + "\n";
                }
                if (rb02.Checked == true)
                {
                    restriccion += "  - Nombre que contiene " + txt_patron_nombre.Text + "\n";
                }
            }

            if (txt_patron_apellido.Text != "")
            {
                if (rb03.Checked == true)
                {
                    restriccion += "  - Apellido empezado con " + txt_patron_nombre.Text + "\n";
                }
                if (rb04.Checked == true)
                {
                    restriccion += "  - Apellido que contiene " + txt_patron_nombre.Text + "\n";
                }
            }

            if (txt_fechaDesde.MaskFull && txt_fechaHasta.MaskFull)
            {
                restriccion += "  - Fecha de ingreso desde " + txt_fechaDesde.Text + " hasta " + txt_fechaHasta.Text + "\n";
                fechas = true;
            }
            if (txt_fechaHasta.MaskFull && fechas == false)
            {
                restriccion += "  - Fecha de ingreso hasta " + txt_fechaHasta.Text + "\n";
            }
            if (txt_fechaDesde.MaskFull && fechas == false)
            {
                restriccion += "  - Fecha de ingreso desde " + txt_fechaDesde.Text + "\n";
            }

            if (cmb_tipo_documento.SelectedIndex != -1)
            {
                restriccion += "  - Tipo de documento: " + cmb_tipo_documento.Text + "\n";
            }

            if (txt_patron_nombre.Text.Trim() == "" && txt_patron_apellido.Text.Trim() == "" && txt_fechaDesde.MaskFull == false && txt_fechaHasta.MaskFull == false && cmb_tipo_documento.SelectedIndex == -1)
            {
                restriccion = "Restricciones: Todos los empleados";
            }

            ReportDataSource datos = new ReportDataSource("DataSet1", Tabla);

            reporte_empleados.LocalReport.ReportEmbeddedResource = "Proyecto_PAV1_G5.ReportesyEstadísticas.Listados.Empleados.Report1.rdlc";
            reporte_empleados.LocalReport.DataSources.Clear();
            reporte_empleados.LocalReport.DataSources.Add(datos);
            ReportParameter[] parametro = new ReportParameter[1];
            parametro[0] = new ReportParameter("RPRestriccion", restriccion);
            reporte_empleados.LocalReport.SetParameters(parametro);
            reporte_empleados.RefreshReport();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_patron_apellido.Text = "";
            txt_patron_nombre.Text = "";
            txt_fechaDesde.Text = "";
            txt_fechaHasta.Text = "";
            rb01.Checked = false;
            rb02.Checked = false;
            rb03.Checked = false;
            rb04.Checked = false;
            cmb_tipo_documento.SelectedIndex = -1;
        }

    }
}
