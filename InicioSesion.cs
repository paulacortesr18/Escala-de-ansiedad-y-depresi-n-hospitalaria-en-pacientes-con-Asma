using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Paula" && txtContraseña.Text == "12345p")
            {
                MessageBox.Show("Sesion iniciada");

                var frm = new FormularioDeRequisitos();
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta");
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (txtContraseña.PasswordChar == (char)0)
            {
                txtContraseña.PasswordChar = '*';
            }
            else
            {
                txtContraseña.PasswordChar = (char)0;
            }
        }
    }
}
