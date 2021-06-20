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
    public partial class Frm_ReporteClientes : Form
    {
        Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();
        DataTable tabla = new DataTable();
        NE_Clientes cliente = new NE_Clientes();

        public Frm_ReporteClientes()
        {
            InitializeComponent();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            cmb_clientes.SelectedIndex = -1;
            txt_fechaDesde.Text = "";
            txt_fechaHasta.Text = "";
            rv_todos.Checked = false;
            rv_cuit.Checked = false;
            rv_fechas.Checked = false;
            this.reporte_clientes.Clear();
        }

        private void ArmarReporte(DataTable tabla)
        {
            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            reporte_clientes.LocalReport.ReportEmbeddedResource = "Proyecto_PAV1_G5.ReportesyEstadisticas.Listados.Clientes.ListadoCliente.rdlc";
            reporte_clientes.LocalReport.DataSources.Clear();
            reporte_clientes.LocalReport.DataSources.Add(datos);
            reporte_clientes.RefreshReport();
        }

        private void Frm_ReporteClientes_Load(object sender, EventArgs e)
        {
            this.reporte_clientes.RefreshReport();
            cmb_clientes.CargarCombo(cliente.DatosComboCliente());
        }

        private void RecuperarClientes()
        {
            if(rv_todos.Checked == true)
            {
                tabla = cliente.RecuperarTodos();
                ArmarReporte(tabla);
                return;
            }

            if(rv_cuit.Checked == true)
            {
                tabla = cliente.BuscarClientesPorCuit(cmb_clientes.SelectedValue.ToString());
                ArmarReporte(tabla);
                return;
            }

            if(rv_fechas.Checked == true)
            {
                if (txt_fechaDesde.MaskFull == true && txt_fechaHasta.MaskFull == true)
                {
                    tabla = cliente.BuscarClienteConFechas(txt_fechaDesde.Text, txt_fechaHasta.Text);
                    ArmarReporte(tabla);
                }
                if (txt_fechaDesde.MaskFull == true && txt_fechaHasta.MaskFull == false)
                {
                    tabla = cliente.BuscarClientesConFechaDesde(txt_fechaDesde.Text);
                    ArmarReporte(tabla);
                }
                if (txt_fechaDesde.MaskFull == false && txt_fechaHasta.MaskFull == true)
                {
                    tabla = cliente.BuscarClientesConFechaHasta(txt_fechaHasta.Text);
                    ArmarReporte(tabla);
                }
                if(txt_fechaDesde.MaskFull == false && txt_fechaHasta.MaskFull == false)
                {
                    MessageBox.Show("Debe ingresar por lo menos una de las 2 fechas para poder usar este filtro");
                }
                return;                
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            RecuperarClientes();
            ArmarReporte(tabla);
        }
    }
}
