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
using Microsoft.Reporting.WinForms;

namespace Proyecto_PAV1_G5.Reportes_y_Estadísticas.Listados
{
    public partial class Frm_ReporteCompras : Form
    {
        NE_Compras compras = new NE_Compras();
        DataTable Tabla = new DataTable();
        Tratamientos_Especiales te = new Tratamientos_Especiales();
        public Frm_ReporteCompras()
        {
            InitializeComponent();
        }

        private void BuscarRemitos()
        {
            DataTable tabla = new DataTable();
            string[] subcadenas_fecha_desde = txt_fechaDesde.Text.Split('/');
            string[] subcadenas_fecha_hasta = txt_fechaHasta.Text.Split('/');
            bool bandera = false;
            if (subcadenas_fecha_desde[0] != "  " || subcadenas_fecha_desde[1] != "  " || subcadenas_fecha_desde[2] != "")
            {
                bandera = true;
            }
            if ((subcadenas_fecha_desde[0] == "  " || subcadenas_fecha_desde[1] == "  " || subcadenas_fecha_desde[2] == "") && bandera)
            {
                if (te.ValidarFecha(txt_fechaDesde.Text) == Tratamientos_Especiales.Resultado.error)
                {
                    MessageBox.Show("No es una fecha valida \n " + txt_fechaDesde.Text);
                    txt_fechaDesde.Focus();
                    return;
                }
            }
            if ((subcadenas_fecha_hasta[0] == "  " || subcadenas_fecha_hasta[1] == "  " || subcadenas_fecha_hasta[2] == "") && bandera)
            {
                if (te.ValidarFecha(txt_fechaHasta.Text) == Tratamientos_Especiales.Resultado.error)
                {
                    MessageBox.Show("No es una fecha valida \n " + txt_fechaHasta.Text);
                    txt_fechaHasta.Focus();
                    return;
                }
            }

            //            
            if (Rb01.Checked == false && Check1.Checked == false && cmb_proveedor.SelectedIndex == -1 && txt_fechaDesde.Text.Substring(0, 2) == "  " && txt_fechaHasta.Text.Substring(0, 2) == "  ")
            {
                MessageBox.Show("Seleccione algunos datos antes de realizar el reporte");
                cmb_proveedor.Focus();
                return;
            }
            if (Rb01.Checked == false && Rb02.Checked == false)
            {
                MessageBox.Show("Seleccione el tipo de reporte antes de realizarlo");
                return;
            }
            if (Rb01.Checked == true)
            {
                if (Check1.Checked == true)
                {
                    tabla = compras.RecuperarTodosReporte1();
                    ArmarReporteRemito1(tabla);
                }
                if (Check1.Checked == false && cmb_proveedor.SelectedIndex != -1 && txt_fechaDesde.Text.Substring(0, 2) == "  " && txt_fechaHasta.Text.Substring(0, 2) == "  ")
                {
                    tabla = compras.Recuperar_X_Proveedor(cmb_proveedor.SelectedValue.ToString());
                    ArmarReporteRemito1(tabla);
                }
                if (Check1.Checked == false && cmb_proveedor.SelectedIndex != -1 && txt_fechaDesde.Text.Substring(0, 2) != "  " && txt_fechaHasta.Text.Substring(0, 2) == "  ")
                {
                    tabla = compras.Recuperar_X_Proveedor_Y_Fecha_Desde(cmb_proveedor.SelectedValue.ToString(), txt_fechaDesde.Text);
                    ArmarReporteRemito1(tabla);
                }
                if (Check1.Checked == false && cmb_proveedor.SelectedIndex != -1 && txt_fechaDesde.Text.Substring(0, 2) == "  " && txt_fechaHasta.Text.Substring(0, 2) != "  ")
                {
                    tabla = compras.Recuperar_X_Proveedor_Y_Fecha_Hasta(cmb_proveedor.SelectedValue.ToString(), txt_fechaHasta.Text);
                    ArmarReporteRemito1(tabla);
                }
                if (Check1.Checked == false && cmb_proveedor.SelectedIndex != -1 && txt_fechaDesde.Text.Substring(0, 2) != "  " && txt_fechaHasta.Text.Substring(0, 2) != "  ")
                {
                    tabla = compras.Recuperar_X_Proveedor_Y_Fecha_Desde_Y_Hasta(cmb_proveedor.SelectedValue.ToString(), txt_fechaDesde.Text, txt_fechaHasta.Text);
                    ArmarReporteRemito1(tabla);
                }
                if (Check1.Checked == false && cmb_proveedor.SelectedIndex == -1 && txt_fechaDesde.Text.Substring(0, 2) != "  " && txt_fechaHasta.Text.Substring(0, 2) == "  ")
                {
                    tabla = compras.Recuperar_X_Fecha_Desde(txt_fechaDesde.Text);
                    ArmarReporteRemito1(tabla);
                }
                if (Check1.Checked == false && cmb_proveedor.SelectedIndex == -1 && txt_fechaDesde.Text.Substring(0, 2) == "  " && txt_fechaHasta.Text.Substring(0, 2) != "  ")
                {
                    tabla = compras.Recuperar_X_Fecha_Hasta(txt_fechaHasta.Text);
                    ArmarReporteRemito1(tabla);
                }
                if (Check1.Checked == false && cmb_proveedor.SelectedIndex == -1 && txt_fechaDesde.Text.Substring(0, 2) != "  " && txt_fechaHasta.Text.Substring(0, 2) != "  ")
                {
                    tabla = compras.Recuperar_X_Fecha_Desde_Y_Hasta(txt_fechaDesde.Text, txt_fechaHasta.Text);
                    ArmarReporteRemito1(tabla);
                }
            }

            if (Rb02.Checked == true)
            {
                if (Check1.Checked == true)
                {
                    tabla = compras.RecuperarTodosReporte2();
                    ArmarReporteRemito1(tabla);
                }
                if (Check1.Checked == false && cmb_proveedor.SelectedIndex != -1 && txt_fechaDesde.Text.Substring(0, 2) == "  " && txt_fechaHasta.Text.Substring(0, 2) == "  ")
                {
                    tabla = compras.Recuperar_X_Proveedor2(cmb_proveedor.SelectedValue.ToString());
                    ArmarReporteRemito1(tabla);
                }
                if (Check1.Checked == false && cmb_proveedor.SelectedIndex != -1 && txt_fechaDesde.Text.Substring(0, 2) != "  " && txt_fechaHasta.Text.Substring(0, 2) == "  ")
                {
                    tabla = compras.Recuperar_X_Proveedor_Y_Fecha_Desde2(cmb_proveedor.SelectedValue.ToString(), txt_fechaDesde.Text);
                    ArmarReporteRemito1(tabla);
                }
                if (Check1.Checked == false && cmb_proveedor.SelectedIndex != -1 && txt_fechaDesde.Text.Substring(0, 2) == "  " && txt_fechaHasta.Text.Substring(0, 2) != "  ")
                {
                    tabla = compras.Recuperar_X_Proveedor_Y_Fecha_Hasta2(cmb_proveedor.SelectedValue.ToString(), txt_fechaHasta.Text);
                    ArmarReporteRemito1(tabla);
                }
                if (Check1.Checked == false && cmb_proveedor.SelectedIndex != -1 && txt_fechaDesde.Text.Substring(0, 2) != "  " && txt_fechaHasta.Text.Substring(0, 2) != "  ")
                {
                    tabla = compras.Recuperar_X_Proveedor_Y_Fecha_Desde_Y_Hasta2(cmb_proveedor.SelectedValue.ToString(), txt_fechaDesde.Text, txt_fechaHasta.Text);
                    ArmarReporteRemito1(tabla);
                }
                if (Check1.Checked == false && cmb_proveedor.SelectedIndex == -1 && txt_fechaDesde.Text.Substring(0, 2) != "  " && txt_fechaHasta.Text.Substring(0, 2) == "  ")
                {
                    tabla = compras.Recuperar_X_Fecha_Desde2(txt_fechaDesde.Text);
                    ArmarReporteRemito1(tabla);
                }
                if (Check1.Checked == false && cmb_proveedor.SelectedIndex == -1 && txt_fechaDesde.Text.Substring(0, 2) == "  " && txt_fechaHasta.Text.Substring(0, 2) != "  ")
                {
                    tabla = compras.Recuperar_X_Fecha_Hasta2(txt_fechaHasta.Text);
                    ArmarReporteRemito1(tabla);
                }
                if (Check1.Checked == false && cmb_proveedor.SelectedIndex == -1 && txt_fechaDesde.Text.Substring(0, 2) != "  " && txt_fechaHasta.Text.Substring(0, 2) != "  ")
                {
                    tabla = compras.Recuperar_X_Fecha_Desde_Y_Hasta2(txt_fechaDesde.Text, txt_fechaHasta.Text);
                    ArmarReporteRemito1(tabla);
                }
            }

        }
        private void ArmarReporteRemito1(DataTable tabla)
        {
            ReportDataSource paqueteDatos = new ReportDataSource("DataSet", tabla);
            ReportDataSource paqueteDatos2 = new ReportDataSource("DataSet2", tabla);


            if (Rb01.Checked == true)
                reporte_ventas.LocalReport.ReportEmbeddedResource = "Proyecto_PAV1_G5.ReportesyEstadísticas.Listados.Compras.ReporteCompras.rdlc";
            else
                reporte_ventas.LocalReport.ReportEmbeddedResource = "Proyecto_PAV1_G5.ReportesyEstadísticas.Listados.Compras.ReporteCompras2.rdlc";
            reporte_ventas.LocalReport.DataSources.Clear();
            reporte_ventas.LocalReport.DataSources.Add(paqueteDatos);
            reporte_ventas.LocalReport.DataSources.Add(paqueteDatos2);
            reporte_ventas.RefreshReport();

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

            BuscarRemitos();

        }

        private void Frm_ReporteCompras_Load(object sender, EventArgs e)
        {
            cmb_proveedor.CargarCombo(compras.DatosComboProveedor());
        }

        private void Check1_CheckedChanged(object sender, EventArgs e)
        {
            if (Check1.Checked == true)
            {
                cmb_proveedor.SelectedIndex = -1;
                cmb_proveedor.Enabled = false;
                txt_fechaDesde.Clear();
                txt_fechaDesde.ReadOnly = true;
                txt_fechaHasta.Clear();
                txt_fechaHasta.ReadOnly = true;
            }
            else
            {
                cmb_proveedor.Enabled = true;
                txt_fechaDesde.ReadOnly = false;
                txt_fechaHasta.ReadOnly = false;
            }
        }
    }
}
