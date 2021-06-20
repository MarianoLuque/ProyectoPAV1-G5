using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Proyecto_PAV1_G5.ReportesyEstadísticas.Estadisticas.EstadisticasMariano
{
    public partial class Frm_Estadistica_Compras_Por_Proveedor : Form
    {
        public Frm_Estadistica_Compras_Por_Proveedor()
        {
            InitializeComponent();
        }

        private void Frm_Estadistica_Compras_Por_Proveedor_Load(object sender, EventArgs e)
        {

            this.reporte_compras_proveedor.RefreshReport();
        }

        private void CargarReporte(DataTable tabla)
        {
            string restriccion = "Restricciones: \n";

            //if (txt_patron_nombre.Text != "")
            //{
            //    if (rb01.Checked == true)
            //    {
            //        restriccion += "  - Nombre empezado con " + txt_patron_nombre.Text + "\n";
            //    }
            //    if (rb02.Checked == true)
            //    {
            //        restriccion += "  - Nombre que contiene " + txt_patron_nombre.Text + "\n";
            //    }
            //}

            //if (txt_patron_apellido.Text != "")
            //{
            //    if (rb03.Checked == true)
            //    {
            //        restriccion += "  - Apellido empezado con " + txt_patron_nombre.Text + "\n";
            //    }
            //    if (rb04.Checked == true)
            //    {
            //        restriccion += "  - Apellido que contiene " + txt_patron_nombre.Text + "\n";
            //    }
            //}

            //if (txt_fechaDesde.MaskFull && txt_fechaHasta.MaskFull)
            //{
            //    restriccion += "  - Fecha de ingreso desde " + txt_fechaDesde.Text + " hasta " + txt_fechaHasta.Text + "\n";
            //    fechas = true;
            //}
            //if (txt_fechaHasta.MaskFull && fechas == false)
            //{
            //    restriccion += "  - Fecha de ingreso hasta " + txt_fechaHasta.Text + "\n";
            //}
            //if (txt_fechaDesde.MaskFull && fechas == false)
            //{
            //    restriccion += "  - Fecha de ingreso desde " + txt_fechaDesde.Text + "\n";
            //}

            //if (cmb_tipo_documento.SelectedIndex != -1)
            //{
            //    restriccion += "  - Tipo de documento: " + cmb_tipo_documento.Text + "\n";
            //}

            //if (txt_patron_nombre.Text.Trim() == "" && txt_patron_apellido.Text.Trim() == "" && txt_fechaDesde.MaskFull == false && txt_fechaHasta.MaskFull == false && cmb_tipo_documento.SelectedIndex == -1)
            //{
            //    restriccion = "Restricciones: Todos los empleados";
            //}

            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);

            reporte_compras_proveedor.LocalReport.ReportEmbeddedResource = "Proyecto_PAV1_G5.ReportesyEstadisticas.Listados.Empleados.Report1.rdlc";
            reporte_compras_proveedor.LocalReport.DataSources.Clear();
            reporte_compras_proveedor.LocalReport.DataSources.Add(datos);
            ReportParameter[] parametro = new ReportParameter[1];
            parametro[0] = new ReportParameter("RPRestriccion", restriccion);
            reporte_compras_proveedor.LocalReport.SetParameters(parametro);
            reporte_compras_proveedor.RefreshReport();
        }
    }
}
