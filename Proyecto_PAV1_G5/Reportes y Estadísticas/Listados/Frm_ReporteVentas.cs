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

namespace Proyecto_PAV1_G5.Reportes_y_Estadísticas.Listados
{
    public partial class Frm_ReporteVentas : Form
    {
        Tratamientos_Especiales TratEsp = new Tratamientos_Especiales();
        DataTable tabla = new DataTable();
        public Frm_ReporteVentas()
        {
            InitializeComponent();
        }

  
        private void Frm_ReporteArticulos_Load(object sender, EventArgs e)
        {

            this.reporte_ventas.RefreshReport();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            //RecuperarVentas();
            //ArmarReporte();
        }

        private void RecuperarVentas()
        {
            if (cmb_clientes.SelectedValue.ToString() == "" && txt_fechaDesde.Text == "" && txt_fechaHasta.Text == "")
            {
                MessageBox.Show("No se realizó selección para la búsqueda");
                return;
            }

            if (cmb_clientes.SelectedValue.ToString() != "" && txt_fechaDesde.Text == "" && txt_fechaHasta.Text == "")
            {
                if ((TratEsp.ValidarFecha(txt_fechaDesde.Text) == Tratamientos_Especiales.Resultado.correcto) && (TratEsp.ValidarFecha(txt_fechaHasta.Text) == Tratamientos_Especiales.Resultado.correcto))
                {
                    //tabla = venta.BuscarVentas(txt.fechaDesde.Text, txt_fechaHasta.Text, cmb_clientes.SelectedValue.ToString())
                }
            }

            if (cmb_clientes.SelectedValue.ToString() == "" && txt_fechaDesde.Text != "" && txt_fechaHasta.Text != "")
            {
                //buscar por el rango de fecha
            }

            if (cmb_clientes.SelectedValue.ToString() != "" && txt_fechaDesde.Text != "" && txt_fechaHasta.Text != "")
            {
                //buscar por cliente y rango de fecha
            }

            if (cmb_clientes.SelectedValue.ToString() == "" && txt_fechaDesde.Text == "" && txt_fechaHasta.Text != "")
            {
                MessageBox.Show("Por favor ingrese una fecha desde");
            }

            if (cmb_clientes.SelectedValue.ToString() == "" && txt_fechaDesde.Text != "" && txt_fechaHasta.Text == "")
            {
                //Aca deberia mostrar los que sean de la fecha desde ingresada hasta la fecha actual.
            }
        }
    }
}
