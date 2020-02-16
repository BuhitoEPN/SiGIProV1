using SiGIProV1.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiGIProV1.Controlador
{
    class ControladorHome
    {
        DAOUsuario dAOUsuario = new DAOUsuario();

        public void nombreUsuario(Label labelSaludo, string user)
        {
            labelSaludo.Text = "Bienvenido " + dAOUsuario.devolverNombre(user);
        }
        

    }
}
