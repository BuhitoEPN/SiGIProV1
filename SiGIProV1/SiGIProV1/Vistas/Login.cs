using SiGIProV1.Controlador;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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

        private void tUsuario_Enter(object sender, EventArgs e)
        {
            new ControlLogin().focoEnradaLogin(tUsuario);
        }

        private void tUsuario_Leave(object sender, EventArgs e)
        {
            new ControlLogin().focoSalidaUsuarioLogin(tUsuario);
        }

        private void tPassword_Enter(object sender, EventArgs e)
        {
            new ControlLogin().focoEnradaLogin(tPassword);
        }

        private void tPassword_Leave(object sender, EventArgs e)
        {
            new ControlLogin().focoSalidaPasswordLogin(tPassword);
        }

        //DRAG FORM:

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
