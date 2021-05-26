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

namespace Proyecto_PAV1_G5.Transacciones.Ventas
{
    public partial class Frm_Ventas : Form
    {
        NE_Ventas venta = new NE_Ventas();
        public Frm_Ventas()
        {
            InitializeComponent();
        }

        private void Frm_Ventas_Load(object sender, EventArgs e)
        {
            cmb_cliente.CargarCombo(venta.DatosComboCliente());
            cmb_tipo_factura.CargarCombo(venta.DatosComboTipoFactura());
            grid_ventas.Formatear("Numero Factura,125; Tipo Factura,100; Cuit Cliente,150; Monto Total,150; Fecha de Venta,150; Vendedor Asignado,200; Forma de Pago,110");
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {

        }
    }
}
