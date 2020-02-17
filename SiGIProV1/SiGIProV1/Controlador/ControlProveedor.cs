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

        public DataTable filtroProveedor(string comboBox, TextBox buscar)
        {
            DAOProveedor daoProveedor = new DAOProveedor();
            
            if (comboBox.Equals("RUC"))
            {
                if (buscar.Equals(""))
                {
                    MessageBox.Show("Ingrese el RUC del proveedor a buscar.");
                }
                return daoProveedor.filtrarRUC(buscar.Text);
            }else if (comboBox.Equals("Nombre"))
            {
                if (buscar.Equals(""))
                {
                    MessageBox.Show("Ingrese el nombre del proveedor a buscar.");
                }
                return daoProveedor.filtrarNombre(buscar.Text);
            }
            else
            {
                MessageBox.Show("Seleccione un filtro para la busqueda.");
                buscar.Text = "";
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

                MessageBox.Show("No existe el proveedor.");
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
                    MessageBox.Show("No existe el proveedor.");
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


        public void verificarCampoRUC(Label error, TextBox ruc)
        {
            if (ruc.Text.Length == 13)
            {
                error.Visible = false;
                if (!new Controlador.ControlValidaciones().verificarCedula(ruc.Text))
                {
                    MessageBox.Show("El RUC: " + ruc.Text + " es incorrecto.");
                    error.Visible = true;
                }
                else
                {
                    error.Visible = false;
                    new DAOProveedor().comprobarRUCError(ruc.Text, error);
                }
                    
            }
            else
            {
                error.Visible = true;
            }
        }

        public void verificarCampoNumerosKeyUp(KeyEventArgs e, TextBox ruc)
        {
            new Controlador.ControlValidaciones().validarCamposNumericosKeyUp(e, ruc);
        }

        public void verificarCampoLetras(KeyPressEventArgs evt)
        {
            new ControlValidaciones().validarCamposTexto(evt);
        }

        public void verificarCampoNumeros(KeyPressEventArgs evt)
        {
            new ControlValidaciones().validarCamposNumericos(evt);
        }

        public void verificarTelefono(TextBox numero, Label error)
        {
            if (numero.Text.Length == 10)
            {
                
                char[] cadena = numero.Text.ToCharArray(0, numero.Text.Length);
                if (int.Parse(cadena[0].ToString()) == 0 && int.Parse(cadena[1].ToString()) == 9)
                {
                    error.Visible = false;
                }
                else
                    error.Visible = true;
            }
            else
                error.Visible = true;
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
                    ruc.Text = "";
                    estado.SelectedIndex = -1;
                }
            }
        }
    }
}
