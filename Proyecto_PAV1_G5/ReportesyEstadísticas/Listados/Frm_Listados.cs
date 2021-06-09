using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PAV1_G5.Reportes_y_Estadísticas.Listados
{
    public partial class Frm_Listados : Form
    {
        public Frm_Listados()
        {
            InitializeComponent();
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            Frm_ReporteVentas ventas = new Frm_ReporteVentas();
            ventas.ShowDialog();
        }

        private void btn_compras_Click(object sender, EventArgs e)
        {
            Frm_ReporteCompras compras = new Frm_ReporteCompras();
            compras.ShowDialog();
        }

        private void btn_articulos_Click(object sender, EventArgs e)
        {
            Frm_ReporteArticulos articulos = new Frm_ReporteArticulos();
            articulos.ShowDialog();
        }

        private void btn_equipos_simples_Click(object sender, EventArgs e)
        {
            Frm_ReporteEquiposSimples equipo_simple = new Frm_ReporteEquiposSimples();
            equipo_simple.ShowDialog();
        }

        private void btn_equipos_especiales_Click(object sender, EventArgs e)
        {
            Frm_ReporteEquiposEspeciales equipo_especial = new Frm_ReporteEquiposEspeciales();
            equipo_especial.ShowDialog();
        }

        private void btn_rubros_Click(object sender, EventArgs e)
        {
            Frm_ReporteRubros rubros = new Frm_ReporteRubros();
            rubros.ShowDialog();
        }

        private void btn_empleados_Click(object sender, EventArgs e)
        {
            Frm_ReporteEmpleados empleado = new Frm_ReporteEmpleados();
            empleado.ShowDialog();
        }

        private void btn_proveedores_Click(object sender, EventArgs e)
        {
            Frm_ReporteProveedores proveedor = new Frm_ReporteProveedores();
            proveedor.ShowDialog();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            Frm_ReporteClientes cliente = new Frm_ReporteClientes();
            cliente.ShowDialog();
        }

        private void btn_categoria_Click(object sender, EventArgs e)
        {
            Frm_ReporteClasificacionesClientes categoria = new Frm_ReporteClasificacionesClientes();
            categoria.ShowDialog();
        }
    }
}
