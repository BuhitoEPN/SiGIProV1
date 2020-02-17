using SiGIProV1.Controlador;
using System;
using System.Windows.Forms;

namespace SiGIProV1.Vistas
{
    public partial class Login : Form
    {
        ControlLogin controlLogin = new ControlLogin();
        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "SiGIProV-RUESCO S.A.";
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            controlLogin.controlPorCargos(tUsuario, tPassword, lMensajeError, this, bAceptar, bSalir);
        }

    }
}
