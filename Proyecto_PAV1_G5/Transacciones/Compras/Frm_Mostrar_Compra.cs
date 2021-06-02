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

namespace Proyecto_PAV1_G5.Transacciones.Compras
{
    public partial class Frm_Mostrar_Compra : Form
    {
        NE_Compras compra = new NE_Compras();
        public string Pp_Cuit_Proveedor { get; set; }
        public string Pp_Nro_Remito { get; set; }
        public Frm_Mostrar_Compra()
        {
            InitializeComponent();
        }

        private void Frm_Mostrar_Compra_Load(object sender, EventArgs e)
        {
            txt_proveedor.Text = Pp_Cuit_Proveedor;
            grid_articulos.Formatear("Codigo,75; Nombre,200; Id Rubro,75; Rubro Articulo,150; Cantidad,100");
            grid_articulos.Cargar(compra.RecuperarArticulos_X_Remito(Pp_Nro_Remito));
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
