using SiGIProV1.DAO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SiGIProV1.Controlador
{
    class ControlLogin
    {
        private Label error = new Label();
        private TextBox user = new TextBox();
        private TextBox pass = new TextBox();
        private Button aceptar = new Button();
        private Button salir = new Button();
        private Timer timerEspera;
        private int segundos;
        private int intentos = 0;

        //ABRIR LOS DIFERENTES FORM DEPENDIENDO DEL CARGO:
        public void controlPorCargos(TextBox textUser, TextBox textPass, Label labelError, Form login, Button butAceptar, Button butSalir)
        {
            error = labelError;
            user = textUser;
            pass = textPass;
            aceptar = butAceptar;
            salir = butSalir;

            if (user.Text != "USUARIO")
            {
                if (pass.Text != "CONTRASEÑA")
                {
                    //Se instancia el controlador para poder conectar con la base
                    String cargo = new DAOUsuario().LoginCargoDAO(user.Text, pass.Text);

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
                        login.Hide();
                        new Administrador(user.Text).ShowDialog();
                    }
                    else
                    {
                        intentos++;
                        msgError("Usuario inválido, inténtelo de nuevo.  Intentos restantes " + (3 - intentos) + ".", error);
                        if (intentos == 3)
                        {
                            intentos = 0;
                            segundos = 5;
                            timerEspera = new Timer();
                            timerEspera.Interval = 1000;
                            timerEspera.Tick += new System.EventHandler(bloquearSistema);
                            aceptar.Enabled = false;
                            salir.Enabled = false;
                            user.Enabled = false;
                            pass.Enabled = false;
                            timerEspera.Start();
                            
                        }
                    }
                }
                else msgError("Por favor, ingrese su contraseña.", error);
            }
            else msgError("Por favor, ingrese su usuario.", error);            
        }
        //FUNCIÓN QUE BLOQUEA EL SISTEMA:
        private void bloquearSistema(object sender, EventArgs e)
        {
            msgError("Sistema bloqueado, por favor espere " + segundos + " segundos.", error);
            if (segundos == 0)
            {
                error.Visible = false;
                aceptar.Enabled = true;
                salir.Enabled = true;
                user.Enabled = true;
                pass.Enabled = true;
                timerEspera.Stop();
            }
            segundos--;
        }
        //FUNCIÓN QUE MUESTRA LOS MENSAJES DE ERROR:
        private void msgError(string msg, Label lMensajeError)
        {
            lMensajeError.Text = "    " + msg;
            lMensajeError.Visible = true;
        }

        public void focoEnradaLogin(TextBox labelUsuario)
        {
            if (labelUsuario.Text=="USUARIO")
            {
                labelUsuario.Text = "";
                labelUsuario.ForeColor = Color.LightGray;
            }
            else if(labelUsuario.Text == "CONTRASEÑA")
            {
                labelUsuario.Text = "";
                labelUsuario.ForeColor = Color.LightGray;
                labelUsuario.UseSystemPasswordChar = true;
            }
        }

        public void focoSalidaUsuarioLogin(TextBox labelUsuario)
        {
            if (labelUsuario.Text =="")
            {
                labelUsuario.Text = "USUARIO";
                labelUsuario.ForeColor = Color.DimGray;
            }
        }

        public void focoSalidaPasswordLogin(TextBox labelPassword)
        {
            if (labelPassword.Text =="")
            {
                labelPassword.Text = "CONTRASEÑA";
                labelPassword.ForeColor = Color.DimGray;
                labelPassword.UseSystemPasswordChar = false;
            }
        }
    }

}
