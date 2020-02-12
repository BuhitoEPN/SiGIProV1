using SiGIProV1.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiGIProV1.Vistas
{
    public partial class Login : Form
    {
        ControlLogin controlLogin;

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
            if (tUsuario.Text != "USUARIO")
            {
                if (tPassword.Text != "CONTRASEÑA")
                {
                    //Se declaran los atributos para extraer de los TextBox de los usuarios
                    string user = this.tUsuario.Text;
                    string pass = this.tPassword.Text;

                    //Se instancia el controlador para poder conectar con la base
                    controlLogin = new ControlLogin();
                    String cargo = controlLogin.controlLoginDAO(user, pass);

                    //Se utiliza un string para encontrar el cargo y abrir la interfaz correcta
                    if ((string.Compare(cargo, "Bodeguero")) == 0)
                    {

                    }
                    else if ((string.Compare(cargo, "Operario")) == 0)
                    {


                    }
                    else if ((string.Compare(cargo, "Vendedor")) == 0)
                    {

                    }
                    else if ((string.Compare(cargo, "Administrador")) == 0)
                    {
                        this.Hide();
                        Administrador admi = new Administrador(user);
                        //Administrador admi = new Administrador();
                        admi.ShowDialog();

                    }
                    else
                    { /*MessageBox.Show("No ha seleccionado ningún rol");*/
                        msgError("Usuario inválido, inténtelo de nuevo.");
                    }
                }
                else msgError("Por favor, ingrese su contraseña.");
            }
            else msgError("Por favor, ingrese su usuario.");
        }

        private void msgError(string msg)
        {
            lMensajeError.Text = "    " + msg;
            lMensajeError.Visible = true;
        }


    }
}
