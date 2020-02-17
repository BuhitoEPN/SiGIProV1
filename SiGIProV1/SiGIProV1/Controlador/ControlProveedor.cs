using SiGIProV1.DAO;
using SiGIProV1.Modelo;
using System.Data;
using System.Windows.Forms;

namespace SiGIProV1.Controlador
{
    class ControlProveedor
    {
        public void agregarProveedor(TextBox ruc, TextBox nombreProveedor, TextBox direccionProveedor, TextBox correoElectronico, TextBox telefonoMovil, Label errorRuc, Label errorTelefono, Label errorCorreo)
        {
            if (ruc.Text.Equals("") || nombreProveedor.Text.Equals("") || direccionProveedor.Text.Equals("") || correoElectronico.Text.Equals("") || telefonoMovil.Text.Equals(""))
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
                    new DAOProveedor().agregarProveedor(new Proveedor(ruc.Text, nombreProveedor.Text, direccionProveedor.Text, telefonoMovil.Text, "ACTIVO", correoElectronico.Text));
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
            return new DAOProveedor().listarProveedor();
        }

        public DataTable filtroProveedor(string comboBox, string buscar)
        {
            DAOProveedor daoProveedor = new DAOProveedor();
            
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
            DAOProveedor daoProveedor = new DAOProveedor();
            Proveedor proveedor = new Proveedor();

            if (rucBuscar.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el RUC del proveedor que desea actualizar.");
                vaciarCamposProveedor(rucBuscar, rucLabel, nombre, direccion, correo, telefono, estado);
            }
            else if (rucBuscar.TextLength < 13)
            {

                MessageBox.Show("El RUC sebe tener 13 caracteres.");
                vaciarCamposProveedor(rucBuscar, rucLabel, nombre, direccion, correo, telefono, estado);
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
                    vaciarCamposProveedor(rucBuscar, rucLabel, nombre, direccion, correo, telefono, estado);
                }
            }
        }

        private void vaciarCamposProveedor(TextBox rucBuscar, Label rucLabel, TextBox nombre, TextBox direccion, TextBox correo, TextBox telefono, ComboBox estado)
        {
            rucBuscar.Text = "";
            rucLabel.Text = "";
            nombre.Text = "";
            direccion.Text = "";
            correo.Text = "";
            telefono.Text = "";
            estado.SelectedIndex = -1;
        }


        public void verificarCampoRUC(KeyPressEventArgs evt, Label error, TextBox ruc)
        {
            new ControlValidaciones().validarCamposNumericos(evt);
            if (new DAOProveedor().comprobarRUC(ruc.Text))
            {
                error.Visible = true;
                MessageBox.Show("Ya existe un proveedor con el RUC: " + ruc.Text + ".");
            }
            else
            {
                error.Visible = false;
            }
        }
        /*
        public void verificarCampoRUC(KeyPressEventArgs evt, Label error, TextBox ruc)
        {
            ControlValidaciones controlValidaciones = new ControlValidaciones();
            controlValidaciones.validarCamposNumericos(evt);
            daoProveedor = new DAOProveedor();
            daoProveedor.comprobarRUCError(ruc.Text, error);
            if (ruc.TextLength < 13)
            {
                error.Visible = true;
            }
            else
            {
                error.Visible = false;
            }
        } */

        public void verificarCampoLetras(KeyPressEventArgs evt)
        {
            new ControlValidaciones().validarCamposTexto(evt);
        }

        public void verificarCampoNumeros(KeyPressEventArgs evt)
        {
            new ControlValidaciones().validarCamposNumericos(evt);
        }

        public void verificarCampoTelefono(KeyPressEventArgs evt, Label error)
        {
            
            new ControlValidaciones().validarCamposNumericos(evt);
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

        public void actualizarProveedor(Label ruc, TextBox nombreProveedor, TextBox direccionProveedor, TextBox correoElectronico, TextBox telefonoMovil, ComboBox estado, Label errorTelefono, Label errorCorreo)
        {
            if (nombreProveedor.Text.Equals("") || direccionProveedor.Text.Equals("") || correoElectronico.Text.Equals("") || telefonoMovil.Text.Equals(""))
            {
                MessageBox.Show("Existen campos vacíos.");
            }
            else
            {
                if (errorCorreo.Visible || errorTelefono.Visible)
                {
                    MessageBox.Show("Existen campos con errores.");
                }
                else
                {
                    new DAOProveedor().actualizarProveedor(new Proveedor(ruc.Text, nombreProveedor.Text, direccionProveedor.Text, telefonoMovil.Text, estado.Text, correoElectronico.Text));
                    MessageBox.Show("Proveedor actualizado con éxito.");
                    nombreProveedor.Text = "";
                    direccionProveedor.Text = "";
                    telefonoMovil.Text = "";
                    correoElectronico.Text = "";
                    estado.SelectedIndex = -1;
                }
            }
        }
    }
}
