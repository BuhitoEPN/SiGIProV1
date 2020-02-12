using SiGIProV1.DAO;
using SiGIProV1.Modelo;
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
        private Proveedor proveedor;
        public void agregarProveedor(string ruc, string nombreProveedor, string direccionProveedor, string correoElectronico, string telefonoMovil)
        {
            daoProveedor = new DAOProveedor();
            proveedor = new Proveedor(ruc, nombreProveedor, direccionProveedor, telefonoMovil, "ACTIVO", correoElectronico);
            daoProveedor.agregarProveedor(proveedor);
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

        public void buscarProveedor(TextBox rucBuscar, Label rucLabel, TextBox nombre, TextBox direccion, TextBox correo, ComboBox estado,TextBox telefono)
        {
            daoProveedor = new DAOProveedor();
            proveedor = new Proveedor();

            if (rucBuscar.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el RUC del proveedor que desea actualizar.");
            }
            else
            {
                if (daoProveedor.comprobarRUC(rucBuscar.Text))
                {
                    proveedor = daoProveedor.llenarDatosProveedor(rucBuscar.Text);
                    rucLabel.Text = proveedor.Ruc;
                    nombre.Text = proveedor.Nombre;
                    direccion.Text = proveedor.Direccion;
                    correo.Text = proveedor.Correo;
                    telefono.Text = proveedor.Telefono;
                    estado.Text = proveedor.Estado;

                }
                else
                {
                    MessageBox.Show("No se encontró ningún proveedor con el RUC: " + rucBuscar.Text + ".");
                    rucBuscar.Text = "";
                    rucLabel.Text = "";
                    nombre.Text = "";
                    direccion.Text = "";
                    correo.Text = "";
                    telefono.Text = "";
                    estado.Text = "";
                }
            }
        }

    }
}
