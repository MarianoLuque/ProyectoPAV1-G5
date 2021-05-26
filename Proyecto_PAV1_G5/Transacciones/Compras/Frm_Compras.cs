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

namespace Proyecto_PAV1_G5.Transacciones.Compras
{
    public partial class Frm_Compras : Form
    {
        NE_Compras compra = new NE_Compras();
        Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();
        public Frm_Compras()
        {
            InitializeComponent();
        }

        private void Frm_Compras_Load(object sender, EventArgs e)
        {
            cmb_proveedor.CargarCombo(compra.DatosCombo());
            grid_compras.Formatear("Numero de Remito,150; Cuit Proveedor,180; Razon Social Proveedor,200; Fecha Recepción,200");
            MessageBox.Show(txt_fecha_desde.Text.Substring(0,2));
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (cmb_proveedor.SelectedIndex == -1 && txt_fecha_desde.Text.Substring(0, 2) == "  " && txt_fecha_hasta.Text.Substring(0,2) == "  ")
            {
                grid_compras.Cargar(compra.RecuperarTodos());
            }
            if (cmb_proveedor.SelectedIndex != -1 && txt_fecha_desde.Text.Substring(0, 2) == "  " && txt_fecha_hasta.Text.Substring(0, 2) == "  ")
            {
                grid_compras.Cargar(compra.Recuperar_X_Proveedor(cmb_proveedor.SelectedValue.ToString()));
            }
            if (cmb_proveedor.SelectedIndex == -1 && txt_fecha_desde.Text.Substring(0, 2) != "  " && txt_fecha_hasta.Text.Substring(0, 2) == "  ")
            {
                tratamiento.ValidarFecha(txt_fecha_desde.Text);
                grid_compras.Cargar(compra.Recuperar_X_Fecha_Desde(txt_fecha_desde.Text));
            }
            if (cmb_proveedor.SelectedIndex == -1 && txt_fecha_desde.Text.Substring(0, 2) == "  " && txt_fecha_hasta.Text.Substring(0, 2) != "  ")
            {
                tratamiento.ValidarFecha(txt_fecha_hasta.Text);
                grid_compras.Cargar(compra.Recuperar_X_Fecha_Hasta(txt_fecha_hasta.Text));
            }
            if (cmb_proveedor.SelectedIndex != -1 && txt_fecha_desde.Text.Substring(0, 2) != "  " && txt_fecha_hasta.Text.Substring(0, 2) == "  ")
            {
                tratamiento.ValidarFecha(txt_fecha_desde.Text);
                grid_compras.Cargar(compra.Recuperar_X_Proveedor_Y_Fecha_Desde(cmb_proveedor.SelectedValue.ToString(), txt_fecha_desde.Text));
            }
            if (cmb_proveedor.SelectedIndex != -1 && txt_fecha_desde.Text.Substring(0, 2) == "  " && txt_fecha_hasta.Text.Substring(0, 2) != "  ")
            {
                tratamiento.ValidarFecha(txt_fecha_hasta.Text);
                grid_compras.Cargar(compra.Recuperar_X_Proveedor_Y_Fecha_Hasta(cmb_proveedor.SelectedValue.ToString(), txt_fecha_hasta.Text));
            }
            if (cmb_proveedor.SelectedIndex == -1 && txt_fecha_desde.Text.Substring(0, 2) != "  " && txt_fecha_hasta.Text.Substring(0, 2) != "  ")
            {
                tratamiento.ValidarFecha(txt_fecha_hasta.Text);
                tratamiento.ValidarFecha(txt_fecha_desde.Text);
                grid_compras.Cargar(compra.Recuperar_X_Fecha_Desde_Y_Hasta(txt_fecha_desde.Text, txt_fecha_hasta.Text));
            }
            if (cmb_proveedor.SelectedIndex != -1 && txt_fecha_desde.Text.Substring(0, 2) != "  " && txt_fecha_hasta.Text.Substring(0, 2) != "  ")
            {
                tratamiento.ValidarFecha(txt_fecha_hasta.Text);
                tratamiento.ValidarFecha(txt_fecha_desde.Text);
                grid_compras.Cargar(compra.Recuperar_X_Proveedor_Y_Fecha_Desde_Y_Hasta(cmb_proveedor.SelectedValue.ToString(), txt_fecha_desde.Text, txt_fecha_hasta.Text));
            }
        }
    }
}
