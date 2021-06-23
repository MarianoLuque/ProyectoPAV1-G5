using Proyecto_PAV1_G5.Reportes_y_Estadísticas.Listados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PAV1_G5.ReportesyEstadisticas.Listados
{
    public partial class Frm_Botonera_Listados : Form
    {
        public Frm_Botonera_Listados()
        {
            InitializeComponent();
        }

        private void btn_articulos_Click(object sender, EventArgs e)
        {
            Frm_ReporteArticulos articulos = new Frm_ReporteArticulos();
            articulos.Show();
        }

        private void btn_clasificaciones_Click(object sender, EventArgs e)
        {
            Frm_ReporteClasificacionesClientes clasif = new Frm_ReporteClasificacionesClientes();
            clasif.Show();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            Frm_ReporteClientes clientes = new Frm_ReporteClientes();
            clientes.Show();
        }

        private void btn_compras_Click(object sender, EventArgs e)
        {
            Frm_ReporteCompras compras = new Frm_ReporteCompras();
            compras.Show();
        }

        private void btn_empleados_Click(object sender, EventArgs e)
        {
            Frm_ReporteEmpleados empleados = new Frm_ReporteEmpleados();
            empleados.Show();
        }

        private void btn_eq_esp_Click(object sender, EventArgs e)
        {
            Frm_ReporteEquiposEspeciales eqEsp = new Frm_ReporteEquiposEspeciales();
            eqEsp.Show();
        }

        private void btn_eq_simple_Click(object sender, EventArgs e)
        {
            Frm_ReporteEquiposSimples eqSimple = new Frm_ReporteEquiposSimples();
            eqSimple.Show();
        }

        private void btn_proveedor_Click(object sender, EventArgs e)
        {
            Frm_ReporteProveedores proveedores = new Frm_ReporteProveedores();
            proveedores.Show();
        }

        private void btn_rubros_Click(object sender, EventArgs e)
        {
            Frm_ReporteRubros rubros = new Frm_ReporteRubros();
            rubros.Show();
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            Frm_ReporteVentas ventas = new Frm_ReporteVentas();
            ventas.Show();
        }
    }
}
