using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_PAV1_G5.Login;


namespace Proyecto_PAV1_G5
{
    public partial class Frm_Login : Form
    {
        // ZONA DE DECLARACIONES
        public String Pp_usuario
        {
            get { return txt_usuario.Text; }
            set { txt_usuario.Text = value; }
        }

        
        public String Pp_password
        {
            get { return txt_password.Text; }
            set { txt_password.Text = value; }
        }

        NE_Login login = new NE_Login();

        // CONSTRUCTOR
        public Frm_Login()
        {
            InitializeComponent();
        }

        // BOTON CANCELAR
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // BOTON ACEPTAR
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {
                MessageBox.Show("La casilla de USUARIO se encuentra vacia");
                txt_usuario.Focus();
                return;
            }
            if (txt_password.Text == "")
            {
                MessageBox.Show("La casilla de PASSWORD se encuentra vacia");
                txt_password.Focus();
                return;
            }

            NE_Login.ResultadoValidacion resultado = login.Validar_Usuario(txt_usuario.Text,txt_password.Text);

            if (resultado == NE_Login.ResultadoValidacion.existe)
            {
                Principal principal = new Principal();
                principal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("El usuario y la password no coinciden con ninguno de nuestra Base Datos.");
                txt_usuario.Focus();
            }

        }

        private void btn_ocultar_contrasena_Click(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '\0';
            btn_ocultar_contrasena.Hide();
            btn_ver_contrasena.Show();
        }

        private void btn_ver_contrasena_Click(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '*';
            btn_ver_contrasena.Hide();
            btn_ocultar_contrasena.Show();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            btn_ver_contrasena.Hide();
        }

    }
}
