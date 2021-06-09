using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            RecuperarVentas();
            //ArmarReporte();
        }

        private void RecuperarVentas()
        {
            if (cmb_clientes.SelectedIndex == -1 && txt_fechaDesde.MaskFull == false && txt_fechaHasta.MaskFull == false)
            {
                MessageBox.Show("Aca se mostrarían todas las ventas mayoristas o minoristas de cualquier fecha");
                return;

            }

            if (cmb_clientes.SelectedIndex != -1 && txt_fechaDesde.MaskFull == false && txt_fechaHasta.MaskFull == false)
            {
                MessageBox.Show("Aca se devolverían todas las ventas del cliente en cualquier fecha");
            }

            if (cmb_clientes.SelectedIndex == -1 && txt_fechaDesde.MaskFull == true && txt_fechaHasta.MaskFull == true)
            {
                if (check_Mayorista.Checked==false && check_minorista.Checked==false)
                {
                    MessageBox.Show("Mostrar todas las ventas mayoristas y minoristas en ese periodo");
                }
                if (check_Mayorista.Checked == true)
                {
                    MessageBox.Show("Aca se devolverian todas las ventas mayoristas en ese rango de fechas");
                }
                if (check_minorista.Checked == true)
                {
                    MessageBox.Show("Aca se devolverían todas las ventas minoristas en ese rango de fechas");
                }
               
            }

            if (cmb_clientes.SelectedIndex != -1 && txt_fechaDesde.MaskFull == true && txt_fechaHasta.MaskFull == true)
            {
                MessageBox.Show("Aca se mostrarian todas las ventas de ese cliente mayorista en ese rango de fechas");
            }

            if (cmb_clientes.SelectedIndex == -1 && txt_fechaDesde.MaskFull == false && txt_fechaHasta.MaskFull == true)
            {
                MessageBox.Show("Por favor ingrese una fecha desde");
            }

            if (cmb_clientes.SelectedIndex == -1 && txt_fechaDesde.MaskFull == true && txt_fechaHasta.MaskFull == false)
            {
                MessageBox.Show("Aca deberian mostrarse todas las ventas desde la fecha ingresada hasta la actual");
            }
        }
    }
}
