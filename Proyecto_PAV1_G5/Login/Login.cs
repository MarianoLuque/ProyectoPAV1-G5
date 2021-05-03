using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        // CONSTRUCTOR
        public Frm_Login()
        {
            InitializeComponent();
        }

        // BOTON CANCELAR
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

            Principal principal = new Principal();
            principal.ShowDialog();
            this.Close();
        }

        private void btn_Ver_Contraeña_Click(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar == '*')
            {
                txt_password.PasswordChar = '\0';
            }
            else
            {
                txt_password.PasswordChar = '*';
            }
        }
    }
}
