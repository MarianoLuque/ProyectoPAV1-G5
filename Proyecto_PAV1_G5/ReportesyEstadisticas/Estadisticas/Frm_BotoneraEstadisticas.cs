using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_PAV1_G5.ReportesyEstadísticas.Estadísticas;
using Proyecto_PAV1_G5.ReportesyEstadisticas.Estadisticas.EstadisticasFede;
using Proyecto_PAV1_G5.ReportesyEstadísticas.Estadisticas.EstadisticasMariano;
using Proyecto_PAV1_G5.ReportesyEstadisticas.Estadisticas.EstadisticasVale;
using Proyecto_PAV1_G5.ReportesyEstadisticas.Estadisticas.EstadisticasTita;

namespace Proyecto_PAV1_G5.ReportesyEstadisticas.Estadisticas
{
    public partial class Frm_BotoneraEstadisticas : Form
    {
        public Frm_BotoneraEstadisticas()
        {
            InitializeComponent();
        }

        private void btn_articulos_Click(object sender, EventArgs e)
        {
            Frm_Estadistica_Articulos articulos = new Frm_Estadistica_Articulos();
            articulos.Show();
        }

        private void btn_clasificaciones_Click(object sender, EventArgs e)
        {
            Frm_Estadistica_Clasificacion_Clientes clasif = new Frm_Estadistica_Clasificacion_Clientes();
            clasif.Show();
        }

        private void btn_compras_Click(object sender, EventArgs e)
        {
            Frm_Estadistica_Compras_Por_Proveedor compra = new Frm_Estadistica_Compras_Por_Proveedor();
            compra.Show();
        }

        private void btn_empleados_Click(object sender, EventArgs e)
        {
            Frm_Estadistica_Empleado_Ventas emp = new Frm_Estadistica_Empleado_Ventas();
            emp.Show();
        }

        private void btn_equipos_Click(object sender, EventArgs e)
        {
            Frm_Estadistica_Equipos_Vendidos eq = new Frm_Estadistica_Equipos_Vendidos();
            eq.Show();
        }

        private void btn_formaspago_Click(object sender, EventArgs e)
        {
            Frm_Estadistica_Forma_De_Pago formapago = new Frm_Estadistica_Forma_De_Pago();
            formapago.Show();
        }

        private void btn_rubros_Click(object sender, EventArgs e)
        {
            Frm_Estadistica_Rubros rubros = new Frm_Estadistica_Rubros();
            rubros.Show();
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            Frm_Estadistica_Tipo_Producto produc = new Frm_Estadistica_Tipo_Producto();
            produc.Show();
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            Frm_Estadisticas_Clientes_Compras cli = new Frm_Estadisticas_Clientes_Compras();
            cli.Show();
        }

        private void btn_tipofactura_Click(object sender, EventArgs e)
        {
            Frm_Estadistica_Ventas_Cantidad vent = new Frm_Estadistica_Ventas_Cantidad();
            vent.Show();
        }
    }
}
