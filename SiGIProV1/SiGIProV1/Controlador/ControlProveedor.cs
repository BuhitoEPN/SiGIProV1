using SiGIProV1.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiGIProV1.Controlador
{
    class ControlProveedor
    {
        private DAOProveedor daoProveedor;
        public void agregarProveedor(string ruc, string nombreProveedor, string direccionProveedor, string correoElectronico, string telefonoMovil)
        {
            daoProveedor = new DAOProveedor();
            daoProveedor.agregarProveedor(ruc, nombreProveedor, direccionProveedor, correoElectronico, telefonoMovil);
        }

        public DataTable listarProveedores()
        {
            daoProveedor = new DAOProveedor();
            return daoProveedor.listarProveedor();
        }

        public DataTable filtroProveedor(string comboBox, string buscar)
        {
            daoProveedor = new DAOProveedor();
            if (comboBox.Equals("RUC"))
            {
                if (buscar.Equals(""))
                {
                    MessageBox.Show("Ingrese el RUC del proveedor a buscar.");
                }
                return daoProveedor.filtrarRUC(buscar);
            }else if (comboBox.Equals("Nombre"))
            {
                if (buscar.Equals(""))
                {
                    MessageBox.Show("Ingrese el nombre del proveedor a buscar.");
                }
                return daoProveedor.filtrarNombre(buscar);
            }
            else
            {
                MessageBox.Show("Seleccione un filtro para la busqueda.");
                return listarProveedores();
            }
        }
    }
}
