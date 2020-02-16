using SiGIProV1.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiGIProV1.Controlador
{
    class ControlLogin
    {
        public void controlLogin(string user, string pass, Label error, Form login)
        {
            if (user != "USUARIO")
            {
                if (pass != "CONTRASEÑA")
                {
                    //Se instancia el controlador para poder conectar con la base
                    String cargo = new DAOUsuario().LoginCargoDAO(user, pass);

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
                        new Administrador(user).ShowDialog();
                    }
                    else
                    { /*MessageBox.Show("No ha seleccionado ningún rol");*/
                        msgError("Usuario inválido, inténtelo de nuevo.", error);
                    }
                }
                else msgError("Por favor, ingrese su contraseña.", error);
            }
            else msgError("Por favor, ingrese su usuario.", error);
        }

        private void msgError(string msg, Label lMensajeError)
        {
            lMensajeError.Text = "    " + msg;
            lMensajeError.Visible = true;
        }

    }

}
