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
    public partial class Frm_ReporteVentas : Form
    {
        Tratamientos_Especiales TratEsp = new Tratamientos_Especiales();
        DataTable tabla = new DataTable();
        NE_Ventas venta = new NE_Ventas();
        public Frm_ReporteVentas()
        {
            InitializeComponent();
        }

        private void Frm_ReporteVentas_Load(object sender, EventArgs e)
        {
            this.reporte_ventas.RefreshReport();
            cmb_clientes.CargarCombo(venta.DatosComboCliente());
            btn_buscar.Enabled = false;
            
        }

        private void btn_minorista_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_minorista.Checked == true)
            {
                cmb_clientes.SelectedIndex = -1;
                cmb_clientes.Enabled = false;
                btn_buscar.Enabled = true;
            }
            else
            {
                cmb_clientes.SelectedIndex = -1;
                cmb_clientes.Enabled = true;
                btn_buscar.Enabled = false;
            }
        }

        private void btn_mayorista_CheckedChanged_1(object sender, EventArgs e)
        {
            if (btn_mayorista.Checked == true)
            {
                cmb_clientes.SelectedIndex = -1;
                btn_buscar.Enabled = true;
            }
            else
            {
                cmb_clientes.SelectedIndex = -1;
                btn_buscar.Enabled = false;
            }
        }

        private void btn_todas_CheckedChanged_1(object sender, EventArgs e)
        {
            if (btn_todas.Checked == true)
            {
                cmb_clientes.SelectedIndex = -1;
                cmb_clientes.Enabled = false;
                btn_buscar.Enabled = true;
            }
            else
            {
                cmb_clientes.SelectedIndex = -1;
                cmb_clientes.Enabled = false;
                btn_buscar.Enabled = false;
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            cmb_clientes.SelectedIndex = -1;
            txt_fechaDesde.Text = "";
            txt_fechaHasta.Text = "";
            btn_mayorista.Checked = false;
            btn_minorista.Checked = false;
            btn_todas.Checked = false;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            RecuperarVentas();
            ArmarReporte(tabla);
        }

        private void RecuperarVentas()
        {
            if (btn_mayorista.Checked == true && cmb_clientes.SelectedIndex != -1)
            {
                if(txt_fechaDesde.MaskFull == true && txt_fechaHasta.MaskFull == true)
                {
                    tabla = venta.BuscarVentasClienteFechas(txt_fechaDesde.Text, txt_fechaHasta.Text, cmb_clientes.SelectedValue.ToString());
                }
                if (txt_fechaDesde.MaskFull == true && txt_fechaHasta.MaskFull == false)
                {
                    tabla = venta.BuscarVentasClienteFechaDesde(txt_fechaDesde.Text, cmb_clientes.SelectedValue.ToString());
                }
                if (txt_fechaDesde.MaskFull == false && txt_fechaHasta.MaskFull == true)
                {
                    MessageBox.Show("Por favor ingrese una Fecha Desde o elimine la Fecha Hasta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txt_fechaDesde.MaskFull == false && txt_fechaHasta.MaskFull == false)
                {
                    tabla = venta.BuscarVentasClienteSinFechas(cmb_clientes.SelectedValue.ToString());
                }
                return;
            }

            if (btn_mayorista.Checked == true )
            {
                if (txt_fechaDesde.MaskFull == true && txt_fechaHasta.MaskFull == true)
                {
                    tabla = venta.BuscarVentasMayoristasConFechas(txt_fechaDesde.Text, txt_fechaHasta.Text);
                }
                if (txt_fechaDesde.MaskFull == true && txt_fechaHasta.MaskFull == false)
                {
                    tabla = venta.BuscarVentasMayoristasConFechaDesde(txt_fechaDesde.Text);
                }
                if (txt_fechaDesde.MaskFull == false && txt_fechaHasta.MaskFull == true)
                {
                    MessageBox.Show("Por favor ingrese una Fecha Desde o elimine la Fecha Hasta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txt_fechaDesde.MaskFull == false && txt_fechaHasta.MaskFull == false)
                {
                    tabla = venta.BuscarVentasMayoristasSinFecha();
                }
                return;
            }

            if (btn_minorista.Checked == true)
            {
                if (txt_fechaDesde.MaskFull == true && txt_fechaHasta.MaskFull == true)
                {
                    tabla = venta.BuscarVentasMinoristasConFechas(txt_fechaDesde.Text, txt_fechaHasta.Text);
                }
                if (txt_fechaDesde.MaskFull == false && txt_fechaHasta.MaskFull == false)
                {
                    tabla = venta.BuscarVentasMinoristasSinFechas();
                }
                if (txt_fechaDesde.MaskFull == false && txt_fechaHasta.MaskFull == true)
                {
                    MessageBox.Show("Por favor ingrese una Fecha Desde o elimine la Fecha Hasta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txt_fechaDesde.MaskFull == true && txt_fechaHasta.MaskFull == false)
                {
                    tabla = venta.BuscarVentasMinoristasConFechaDesde(txt_fechaDesde.Text);
                }
                return;
            }
           
            if (btn_todas.Checked == true)
            {
                if (txt_fechaDesde.MaskFull == true && txt_fechaHasta.MaskFull == true)
                {
                    tabla = venta.BuscarVentasConFechas(txt_fechaDesde.Text, txt_fechaHasta.Text);
                }
                if (txt_fechaDesde.MaskFull == false && txt_fechaHasta.MaskFull == false)
                {
                    tabla = venta.BuscarVentasSinFechas();
                }
                if (txt_fechaDesde.MaskFull == false && txt_fechaHasta.MaskFull == true)
                {
                    MessageBox.Show("Por favor ingrese una Fecha Desde o elimine la Fecha Hasta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txt_fechaDesde.MaskFull == true && txt_fechaHasta.MaskFull == false)
                {
                    tabla = venta.BuscarVentasConFechaDesde(txt_fechaDesde.Text);
                }
                return;
            }
        }

        private void ArmarReporte(DataTable tabla)
        {
            ReportDataSource datosVenta = new ReportDataSource("DataSet1", tabla);
            reporte_ventas.LocalReport.ReportEmbeddedResource = "Proyecto_PAV1_G5.ReportesyEstadísticas.Listados.Ventas.ListadoVenta.rdlc";
            reporte_ventas.LocalReport.DataSources.Clear();
            reporte_ventas.LocalReport.DataSources.Add(datosVenta);
            reporte_ventas.RefreshReport();
        }

        
    }
}
