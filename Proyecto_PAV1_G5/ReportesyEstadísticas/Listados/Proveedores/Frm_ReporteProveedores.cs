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
using Proyecto_PAV1_G5.Clases;
using Proyecto_PAV1_G5.Negocios;

namespace Proyecto_PAV1_G5.Reportes_y_Estadísticas.Listados
{
    public partial class Frm_ReporteProveedores : Form
    {
        Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();
        DataTable tabla = new DataTable();
        NE_Proveedores proveedor = new NE_Proveedores();

        public Frm_ReporteProveedores()
        {
            InitializeComponent();
        }

        private void Frm_ReporteProveedores_Load(object sender, EventArgs e)
        {
            this.reporte_proveedores.RefreshReport();
            cmb_proveedores.CargarCombo(proveedor.DatosComboProveedor());
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            cmb_proveedores.SelectedIndex = -1;
            txt_fechaDesde.Text = "";
            txt_fechaHasta.Text = "";
            rv_todos.Checked = false;
            rv_cuit.Checked = false;
            rv_fechas.Checked = false;
            this.reporte_proveedores.Clear();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            RecuperarProveedores();
        }

        private void RecuperarProveedores()
        {
            if (rv_todos.Checked == true)
            {
                tabla = proveedor.BuscarTodosProveedores();
                ArmarReporte(tabla);
                return;
            }

            if (rv_cuit.Checked == true)
            {
                if(cmb_proveedores.Text == "")
                {
                    MessageBox.Show("Para utilizar este filtro se debe seleccionar un proveedor");
                    cmb_proveedores.Focus();
                    return;
                }
                tabla = proveedor.BuscarProveedorPorCuit(cmb_proveedores.SelectedValue.ToString());
                ArmarReporte(tabla);
                return;
            }

            if (rv_fechas.Checked == true)
            {
                if (txt_fechaDesde.MaskFull == true && txt_fechaHasta.MaskFull == true)
                {
                    tabla = proveedor.BuscarProveedorConFechas(txt_fechaDesde.Text, txt_fechaHasta.Text);
                    ArmarReporte(tabla);
                }
                if (txt_fechaDesde.MaskFull == true && txt_fechaHasta.MaskFull == false)
                {
                    tabla = proveedor.BuscarProveedorConFechaDesde(txt_fechaDesde.Text);
                    ArmarReporte(tabla);
                }
                if (txt_fechaDesde.MaskFull == false && txt_fechaHasta.MaskFull == true)
                {
                    tabla = proveedor.BuscarProveedorConFechaHasta(txt_fechaHasta.Text);
                    ArmarReporte(tabla);
                }
                if (txt_fechaDesde.MaskFull == false && txt_fechaHasta.MaskFull == false)
                {
                    MessageBox.Show("Debe ingresar por lo menos una de las 2 fechas para poder usar este filtro");
                }
                return;
            }
        }

        private void ArmarReporte(DataTable tabla)
        {
            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            reporte_proveedores.LocalReport.ReportEmbeddedResource = "Proyecto_PAV1_G5.ReportesyEstadísticas.Listados.Proveedores.ListadoProveedor.rdlc";
            reporte_proveedores.LocalReport.DataSources.Clear();
            reporte_proveedores.LocalReport.DataSources.Add(datos);
            reporte_proveedores.RefreshReport();
        }
    }
}
