using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_PAV1_G5.ABM.Articulos;
using Proyecto_PAV1_G5.ABM.Categoria;
using Proyecto_PAV1_G5.ABM.Clientes;
using Proyecto_PAV1_G5.ABM.Empleados;
using Proyecto_PAV1_G5.ABM.Equipos;
using Proyecto_PAV1_G5.ABM.FormasPago;
using Proyecto_PAV1_G5.ABM.Proveedores;
using Proyecto_PAV1_G5.ABM.Rubros;

namespace Proyecto_PAV1_G5
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_articulos_Click(object sender, EventArgs e)
        {
            Frm_ABMArticulos articulos = new Frm_ABMArticulos();
            articulos.ShowDialog();
        }

        private void btn_categorias(object sender, EventArgs e)
        {
            Frm_ABMCategoria categorias = new Frm_ABMCategoria();
            categorias.ShowDialog();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.ShowDialog();
        }

        private void btn_empleados_Click(object sender, EventArgs e)
        {
            Frm_ABMEmpleados empleados = new Frm_ABMEmpleados();
            empleados.ShowDialog();
        }

        private void btn_equipos_Click(object sender, EventArgs e)
        {
            Frm_Equipos equipos = new Frm_Equipos();
            equipos.ShowDialog();
        }

        private void btn_formas_de_pago_Click(object sender, EventArgs e)
        {
            Frm_ABMFormasPago formapago = new Frm_ABMFormasPago();
            formapago.ShowDialog();
        }

        private void btn_proveedores_Click(object sender, EventArgs e)
        {
            Frm_ABMProveedores proveedor = new Frm_ABMProveedores();
            proveedor.ShowDialog();
        }

        private void btn_rubros_Click(object sender, EventArgs e)
        {
            Frm_ABMRubros rubros = new Frm_ABMRubros();
            rubros.ShowDialog();
        }
    }
}
