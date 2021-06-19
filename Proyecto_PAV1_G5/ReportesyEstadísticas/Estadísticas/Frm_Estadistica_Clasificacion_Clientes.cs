using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Proyecto_PAV1_G5.Negocios;

namespace Proyecto_PAV1_G5.ReportesyEstadísticas.Estadísticas
{
    public partial class Frm_Estadistica_Clasificacion_Clientes : Form
    {
        public Frm_Estadistica_Clasificacion_Clientes()
        {
            InitializeComponent();
        }

        private void Frm_Estadistica_Clasificacion_Clientes_Load(object sender, EventArgs e)
        {
            this.rv_clasificacion.RefreshReport();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.rv_clasificacion.Clear();
            chk_todos.Checked = false;
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            NE_Categoria categoria = new NE_Categoria();

            if (chk_todos.Checked == true)
            {
                tabla = categoria.Calcular_Cantidades();
                ArmarEstadisticaClasificacion(tabla);
            }
            if (chk_todos.Checked == false)
            {
                tabla = categoria.Calcular_Cantidades2();
                ArmarEstadisticaClasificacion(tabla);
            }
            
        }

        private void ArmarEstadisticaClasificacion(DataTable tabla)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
            rv_clasificacion.LocalReport.ReportEmbeddedResource = "Proyecto_PAV1_G5.ReportesyEstadísticas.Estadísticas.Estadistica_Clasificaciones.rdlc";
            rv_clasificacion.LocalReport.DataSources.Clear();
            rv_clasificacion.LocalReport.DataSources.Add(PaqueteDatos);
            rv_clasificacion.RefreshReport();
        }

    }
}
