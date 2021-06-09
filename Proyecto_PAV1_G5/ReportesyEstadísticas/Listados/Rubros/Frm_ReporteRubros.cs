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
using Microsoft.Reporting.WinForms;

namespace Proyecto_PAV1_G5.Reportes_y_Estadísticas.Listados
{
    public partial class Frm_ReporteRubros : Form
    {
        DataTable Tabla = new DataTable();
        NE_Rubros rubro = new NE_Rubros();
        public Frm_ReporteRubros()
        {
            InitializeComponent();
        }

        private void Frm_ReporteRubros_Load(object sender, EventArgs e)
        {
            this.reporte_rubros.Refresh();
        }

        private bool BuscarDatos()
        {
            bool banderaRB1 = false;
            bool banderaRB2 = false;
            bool IDdesde = false;
            bool IDhasta = false;
            bool patron = false;
            bool ambosID = false;
            if(txt_patron_nombre.Text != "")
            {
                patron = true;
                if(rb01.Checked == true)
                {
                    banderaRB1 = true;
                }
                if(rb02.Checked == true)
                {
                    banderaRB2 = true;
                }
                if(rb01.Checked == false && rb02.Checked == false)
                {
                    MessageBox.Show("Falta elegir el tipo de patron a aplicar para el nombre de rubro");
                    return false;
                }
            }
            if(txt_IdDesde.Text != "")
            {
                IDdesde = true;
            }
            if(txt_IdHasta.Text != "")
            {
                IDhasta = true;
            }
            if(txt_IdDesde.Text != "" && txt_IdHasta.Text != "")
            {
                IDdesde = false;
                IDhasta = false;
                ambosID = true;
            }

            Tabla = rubro.ReporteRubros(banderaRB1, banderaRB2, IDdesde, IDhasta, patron, ambosID, txt_patron_nombre.Text, txt_IdDesde.Text, txt_IdHasta.Text);
            return true;
        }

        private void CargarReporte(DataTable tabla)
        {
            bool patron = false;
            bool id1 = false;
            bool id2 = false;
            string restriccion = "";

            if(txt_patron_nombre.Text != "")
            {
                patron = true;
                if(rb01.Checked == true)
                {
                    restriccion = "Nombre empezado con " + txt_patron_nombre.Text;
                }
                if(rb02.Checked == true)
                {
                    restriccion = "Nombre que contiene " + txt_patron_nombre.Text;
                }
                if(txt_IdDesde.Text != "")
                {
                    restriccion += " y el ID mayor que " + txt_IdDesde.Text;
                }
                if (txt_IdHasta.Text != "")
                {
                    restriccion += " y el ID menor que " + txt_IdHasta.Text;
                }
            }
            if(txt_IdDesde.Text != "" && patron == false)
            {
                restriccion = "ID desde " + txt_IdDesde.Text;
                id1 = true;
            }
            if (txt_IdHasta.Text != "" && patron == false)
            {
                restriccion = "ID hasta " + txt_IdHasta.Text;
                id2 = true;
            }
            if(id1 && id2)
            {
                restriccion = "ID entre " + txt_IdDesde.Text + " y " + txt_IdHasta.Text;
            }
            if (txt_patron_nombre.Text == "" && txt_IdDesde.Text == "" && txt_IdHasta.Text == "")
            {
                restriccion = "Todos los usuarios";
            }

            ReportDataSource datos = new ReportDataSource("DataSet1", Tabla);

            reporte_rubros.LocalReport.ReportEmbeddedResource = "Proyecto_PAV1_G5.ReportesyEstadísticas.Listados.Rubros.Report1.rdlc";
            reporte_rubros.LocalReport.DataSources.Clear();
            reporte_rubros.LocalReport.DataSources.Add(datos);
            ReportParameter[] parametro = new ReportParameter[1];
            parametro[0] = new ReportParameter("RPRestriccion", restriccion);
            reporte_rubros.LocalReport.SetParameters(parametro);
            reporte_rubros.RefreshReport();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if(BuscarDatos())
            {
                CargarReporte(Tabla);
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_patron_nombre.Text = "";
            rb01.Checked = false;
            rb02.Checked = false;
            txt_IdDesde.Text = "";
            txt_IdHasta.Text = "";
        }
    }
}
