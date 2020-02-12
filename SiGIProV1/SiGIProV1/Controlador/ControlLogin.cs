using SiGIProV1.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiGIProV1.Controlador
{
    class ControlLogin
    {
        public string controlLoginDAO(string user, string pass)
        {
            DAOUsuario daolog = new DAOUsuario();
            String confirmar = daolog.Login(user, pass);
            return confirmar;
        }
    }
}
