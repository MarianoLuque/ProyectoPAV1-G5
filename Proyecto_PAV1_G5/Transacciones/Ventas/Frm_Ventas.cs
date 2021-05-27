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
            // 1 - NINGUNO
            if (cmb_cliente.SelectedIndex == -1 && cmb_tipo_factura.SelectedIndex == -1 && txt_fecha_desde.Text.Substring(0, 2) == "  " && txt_fecha_hasta.Text.Substring(0, 2) == "  ")
            {
                grid_ventas.Cargar(venta.RecuperarTodos());
            }
            // 2 - SOLO CUIT  
            if (cmb_cliente.SelectedIndex != -1 && cmb_tipo_factura.SelectedIndex == -1 && txt_fecha_desde.Text.Substring(0, 2) == "  " && txt_fecha_hasta.Text.Substring(0, 2) == "  ")
            {
                grid_ventas.Cargar(venta.Recuperar_Solo_Por_Cuit(cmb_cliente.SelectedValue.ToString()));
            }
            // 3 - CUIT CLIENTE Y TIPO DE FACTURA
            if (cmb_cliente.SelectedIndex != -1 && cmb_tipo_factura.SelectedIndex != -1 && txt_fecha_desde.Text.Substring(0, 2) == "  " && txt_fecha_hasta.Text.Substring(0, 2) == "  ")
            {
                grid_ventas.Cargar(venta.Recuperar_Por_Cuit_Y_Tipo_Factura(cmb_cliente.SelectedValue.ToString(), cmb_tipo_factura.SelectedValue.ToString()));
            }
            // 4 - CUIT CLIENTE - TIPO FACTURA - FECHA DESDE
            if (cmb_cliente.SelectedIndex != -1 && cmb_tipo_factura.SelectedIndex != -1 && txt_fecha_desde.Text.Substring(0, 2) != "  " && txt_fecha_hasta.Text.Substring(0, 2) == "  ")
            {
                grid_ventas.Cargar(venta.Recuperar_Por_Cuit_Tipo_Factura_Fecha_Desde(cmb_cliente.SelectedValue.ToString(), cmb_tipo_factura.SelectedValue.ToString(), txt_fecha_desde.Text));
            }
            // 5 - CUIT CLIENTE - TIPO FACTURA - FECHA DESDE - FECHA HASTA
            if (cmb_cliente.SelectedIndex != -1 && cmb_tipo_factura.SelectedIndex != -1 && txt_fecha_desde.Text.Substring(0, 2) != "  " && txt_fecha_hasta.Text.Substring(0, 2) != "  ")
            {
                grid_ventas.Cargar(venta.Recuperar_Por_Cuit_Tipo_Factura_Fecha_Desde_Fecha_Hasta(cmb_cliente.SelectedValue.ToString(), cmb_tipo_factura.SelectedValue.ToString(), txt_fecha_desde.Text, txt_fecha_hasta.Text));
            }
            // 6 - SOLO TIPO DE FACTURA
            if (cmb_cliente.SelectedIndex == -1 && cmb_tipo_factura.SelectedIndex != -1 && txt_fecha_desde.Text.Substring(0, 2) == "  " && txt_fecha_hasta.Text.Substring(0, 2) == "  ")
            {
                grid_ventas.Cargar(venta.Recuperar_Por_Tipo_Factura(cmb_tipo_factura.SelectedValue.ToString()));
            }
            // 7 - TIPO DE FACTURA Y FECHA DESDE 
            if (cmb_cliente.SelectedIndex == -1 && cmb_tipo_factura.SelectedIndex != -1 && txt_fecha_desde.Text.Substring(0, 2) != "  " && txt_fecha_hasta.Text.Substring(0, 2) == "  ")
            {
                grid_ventas.Cargar(venta.Recuperar_Por_Tipo_Factura_Fecha_Desde(cmb_tipo_factura.SelectedValue.ToString(), txt_fecha_desde.Text));
            }
            // 8 - TIPO DE FACTURA Y FECHA HASTA
            if (cmb_cliente.SelectedIndex == -1 && cmb_tipo_factura.SelectedIndex != -1 && txt_fecha_desde.Text.Substring(0, 2) == "  " && txt_fecha_hasta.Text.Substring(0, 2) != "  ")
            {
                grid_ventas.Cargar(venta.Recuperar_Por_Tipo_Factura_Fecha_Hasta(cmb_tipo_factura.SelectedValue.ToString(), txt_fecha_hasta.Text));
            }
            // 9 - TIPO DE FACTURA - FECHA DESDE Y FECHA HASTA
            if (cmb_cliente.SelectedIndex == -1 && cmb_tipo_factura.SelectedIndex != -1 && txt_fecha_desde.Text.Substring(0, 2) != "  " && txt_fecha_hasta.Text.Substring(0, 2) != "  ")
            {
                grid_ventas.Cargar(venta.Recuperar_Por_Tipo_Factura_Fecha_Desde_Fecha_Hasta(cmb_tipo_factura.SelectedValue.ToString(), txt_fecha_desde.Text, txt_fecha_hasta.Text));
            }
            // 10 - CUIT CLIENTE Y FECHA DESDE
            if (cmb_cliente.SelectedIndex != -1 && cmb_tipo_factura.SelectedIndex == -1 && txt_fecha_desde.Text.Substring(0, 2) != "  " && txt_fecha_hasta.Text.Substring(0, 2) == "  ")
            {
                grid_ventas.Cargar(venta.Recuperar_Por_Cuit_Fecha_Desde(cmb_cliente.SelectedValue.ToString(), txt_fecha_desde.Text));
            }
            // 11 - CUIT CLIENTE Y FECHA HASTA 
            if (cmb_cliente.SelectedIndex != -1 && cmb_tipo_factura.SelectedIndex == -1 && txt_fecha_desde.Text.Substring(0, 2) == "  " && txt_fecha_hasta.Text.Substring(0, 2) != "  ")
            {
                grid_ventas.Cargar(venta.Recuperar_Por_Cuit_Fecha_Hasta(cmb_cliente.SelectedValue.ToString(), txt_fecha_hasta.Text));
            }
            // 12 - SOLO FECHA DESDE 
            if (cmb_cliente.SelectedIndex == -1 && cmb_tipo_factura.SelectedIndex == -1 && txt_fecha_desde.Text.Substring(0, 2) != "  " && txt_fecha_hasta.Text.Substring(0, 2) == "  ")
            {
                grid_ventas.Cargar(venta.Recuperar_Por_Fecha_Desde(txt_fecha_desde.Text));
            }
            // 13 - SOLO FECHA HASTA
            if (cmb_cliente.SelectedIndex == -1 && cmb_tipo_factura.SelectedIndex == -1 && txt_fecha_desde.Text.Substring(0, 2) == "  " && txt_fecha_hasta.Text.Substring(0, 2) != "  ")
            {
                grid_ventas.Cargar(venta.Recuperar_Por_Fecha_Hasta(txt_fecha_hasta.Text));
            }
            // 14 - FECHA DESDE Y FECHA HASTA 
            if (cmb_cliente.SelectedIndex == -1 && cmb_tipo_factura.SelectedIndex == -1 && txt_fecha_desde.Text.Substring(0, 2) != "  " && txt_fecha_hasta.Text.Substring(0, 2) != "  ")
            {
                grid_ventas.Cargar(venta.Recuperar_Por_Fecha_Desde_Fecha_Hasta(txt_fecha_desde.Text, txt_fecha_hasta.Text));
            }
            // 15 - CUIT CLIENTE - FECHA DESDE - FECHA HASTA
            if (cmb_cliente.SelectedIndex != -1 && cmb_tipo_factura.SelectedIndex == -1 && txt_fecha_desde.Text.Substring(0, 2) != "  " && txt_fecha_hasta.Text.Substring(0, 2) != "  ")
            {
                grid_ventas.Cargar(venta.Recuperar_Por_Cuit_Fecha_Desde_Fecha_Hasta(cmb_cliente.SelectedValue.ToString(), txt_fecha_desde.Text, txt_fecha_hasta.Text));
            }
            // 16 ????????????????????????????????????????????????????
            if (cmb_cliente.SelectedIndex == -1 && cmb_tipo_factura.SelectedIndex == -1 && txt_fecha_desde.Text.Substring(0, 2) == "  " && txt_fecha_hasta.Text.Substring(0, 2) == "  ")
            {

            }

        }
            private void btn_Agregar_Equipo_Especial_Click(object sender, EventArgs e)
            {
                Frm_Alta_Venta altaVenta = new Frm_Alta_Venta();
                altaVenta.ShowDialog();
            
        }
    }
}
