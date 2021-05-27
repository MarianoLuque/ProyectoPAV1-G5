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

namespace Proyecto_PAV1_G5.Transacciones.Ventas
{
    public partial class Frm_Ventas : Form
    {
        NE_Ventas venta = new NE_Ventas();
        Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();
        public Frm_Ventas()
        {
            InitializeComponent();
        }

        private void Frm_Ventas_Load(object sender, EventArgs e)
        {
            cmb_cliente.CargarCombo(venta.DatosComboCliente());
            cmb_tipo_factura.CargarCombo(venta.DatosComboTipoFactura());
            grid_ventas.Formatear("Numero Factura,125; Tipo Factura,100; Cliente,150; Monto Total,150; Fecha de Venta,150; Vendedor Asignado,200; Forma de Pago,110");
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            string[] subcadenas_fecha_desde = txt_fecha_desde.Text.Split('/');
            string[] subcadenas_fecha_hasta = txt_fecha_hasta.Text.Split('/');
            bool bandera = false;
            if (subcadenas_fecha_desde[0] != "  " || subcadenas_fecha_desde[1] != "  " || subcadenas_fecha_desde[2] != "")
            {
                bandera = true;
            }
            if ((subcadenas_fecha_desde[0] == "  " || subcadenas_fecha_desde[1] == "  " || subcadenas_fecha_desde[2] == "") && bandera)
            {
                if (tratamiento.ValidarFecha(txt_fecha_desde.Text) == Tratamientos_Especiales.Resultado.error)
                {
                    MessageBox.Show("No es una fecha valida \n " + txt_fecha_desde.Text);
                    txt_fecha_desde.Focus();
                    return;
                }
            }
            if (cmb_cliente.SelectedIndex == -1 && cmb_tipo_factura.SelectedIndex == -1 && txt_fecha_desde.Text.Substring(0, 2) == "  " && txt_fecha_hasta.Text.Substring(0, 2) == "  ")
            {
                grid_ventas.Cargar(venta.RecuperarTodos());
            }
        }

        private void btn_Agregar_Equipo_Especial_Click(object sender, EventArgs e)
        {
            Frm_Alta_Venta altaVenta = new Frm_Alta_Venta();
            altaVenta.ShowDialog();
        }
    }
}
