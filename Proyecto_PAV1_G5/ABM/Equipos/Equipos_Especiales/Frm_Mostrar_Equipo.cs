﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_PAV1_G5.Clases;
using Proyecto_PAV1_G5.Negocios;

namespace Proyecto_PAV1_G5.ABM.Equipos.Equipos_Especiales
{
    public partial class Frm_Mostrar_Equipo : Form
    {
        public string TipoEquipo { get; set; }
        NE_EquiposEspeciales equipoEs = new NE_EquiposEspeciales();
        public string[] Pp_codigo_y_cuit_equipo_especial;
        public string[] Pp_codigo_equipo_simple { get; set; }
        public Frm_Mostrar_Equipo()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Mostrar_Equipo_Load(object sender, EventArgs e)
        {
            grid_articulos.Formatear("Codigo,75; Nombre,200; Precio Mayorista,100; Precio Minorista,100; Cantidad,50");
            cmb_clientes.CargarCombo(equipoEs.DatosComboCliente());
            if (TipoEquipo == "simple")
            {
                label_titulo.Text = "Mostrar Equipo Simple";
                MostrarDatos(equipoEs.Recuperar_x_Codigo_Array(Pp_codigo_equipo_simple));
                label_cuit.Hide();
                cmb_clientes.Hide();
                label_descripcion.Hide();
                txt_Descripcion.Hide();
                label_precio_minorista.Show();
                txt_Precio_Minorista.Show();
                txt_Codigo_Equipo.ReadOnly = true;
                grid_articulos.Cargar(equipoEs.RecuperarArticulo_X_Equipo(Pp_codigo_equipo_simple[0]));

            }
            if (TipoEquipo == "especial")
            {
                label_titulo.Text = "Mostrar Equipo Especial";
                MostrarDatos(equipoEs.Recuperar_x_Codigo_y_Cuit_Array(Pp_codigo_y_cuit_equipo_especial));
                label_cuit.Show();
                cmb_clientes.Show();
                label_descripcion.Show();
                txt_Descripcion.Show();
                label_precio_minorista.Hide();
                txt_Precio_Minorista.Hide();
                txt_Codigo_Equipo.ReadOnly = false;
                grid_articulos.Cargar(equipoEs.RecuperarArticulo_X_Equipo_Especial(Pp_codigo_y_cuit_equipo_especial[0], Pp_codigo_y_cuit_equipo_especial[1]));
            }
        }

        private void MostrarDatos(DataTable tabla)
        {
            if (TipoEquipo == "especial")
            {
                txt_Codigo_Equipo.Text = tabla.Rows[0]["codigo_equipo_especial"].ToString();
                cmb_clientes.SelectedValue = tabla.Rows[0]["cuit_cliente"].ToString();
                txt_Descripcion.Text = tabla.Rows[0]["descripcion"].ToString();
                txt_Precio_Mayorista.Text = tabla.Rows[0]["precio"].ToString();
                txt_Nombre.Text = tabla.Rows[0]["nombre_equipo_especial"].ToString();
            }
            if (TipoEquipo == "simple")
            {
                txt_Codigo_Equipo.Text = tabla.Rows[0]["codigo_equipo"].ToString();
                txt_Precio_Mayorista.Text = tabla.Rows[0]["precio_mayorista"].ToString();
                txt_Precio_Minorista.Text = tabla.Rows[0]["precio_minorista"].ToString();
                txt_Nombre.Text = tabla.Rows[0]["nombre_equipo"].ToString();
            }
        }
    }
}
