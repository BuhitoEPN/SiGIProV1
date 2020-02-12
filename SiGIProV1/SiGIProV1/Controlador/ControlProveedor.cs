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
        public void agregarProveedor(TextBox ruc, TextBox nombreProveedor, TextBox direccionProveedor, TextBox correoElectronico, TextBox telefonoMovil, Label errorRuc, Label errorTelefono, Label errorCorreo)
        {
            if (ruc.Text.Equals("") && nombreProveedor.Text.Equals("") && direccionProveedor.Text.Equals("") && correoElectronico.Text.Equals("") && telefonoMovil.Text.Equals(""))
            {
                MessageBox.Show("Existen campos vacíos.");
            }
            else
            {
                if (errorRuc.Visible || errorCorreo.Visible || errorTelefono.Visible)
                {
                    MessageBox.Show("Existen campos con errores.");
                }
                else
                {
                    daoProveedor = new DAOProveedor();
                    proveedor = new Proveedor(ruc.Text, nombreProveedor.Text, direccionProveedor.Text, telefonoMovil.Text, "ACTIVO", correoElectronico.Text);
                    daoProveedor.agregarProveedor(proveedor);
                    MessageBox.Show("Proveedor registrado con éxito.");
                    ruc.Text = "";
                    nombreProveedor.Text = "";
                    direccionProveedor.Text = "";
                    telefonoMovil.Text = "";
                    correoElectronico.Text = "";
                }
            }
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
                    if (proveedor.Estado.Equals("ACTIVO"))
                    {
                        estado.SelectedIndex = 0;
                    } else
                    {
                        estado.SelectedIndex = 1;
                    }
                    rucBuscar.Text = "";

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

        public void verificarCampoRUC(KeyPressEventArgs evt, Label error, TextBox ruc)
        {
            ControlValidaciones controlValidaciones = new ControlValidaciones();
            controlValidaciones.validarCamposNumericos(evt);
            daoProveedor = new DAOProveedor();
            if (daoProveedor.comprobarRUC(ruc.Text))
            {
                error.Visible = true;
                MessageBox.Show("Ya existe un proveedor con el RUC: " + ruc.Text + ".");
            }
            else
            {
                error.Visible = false;
            }
        }

        public void verificarCampoLetras(KeyPressEventArgs evt)
        {
            ControlValidaciones controlValidaciones = new ControlValidaciones();
            controlValidaciones.validarCamposTexto(evt);
        }

        public void verificarCampoNumeros(KeyPressEventArgs evt)
        {
            ControlValidaciones controlValidaciones = new ControlValidaciones();
            controlValidaciones.validarCamposNumericos(evt);
        }


        public void verificarCampoCorreo(Label error, TextBox correo)
        {
            ControlValidaciones controlValidaciones = new ControlValidaciones();
            if (!controlValidaciones.validarCorreo(correo.Text))
            {
                error.Visible = true;
            }
            else
            {
                error.Visible = false;
            }
        }

    }
}
