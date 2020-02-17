using System;
using System.Windows.Forms;

namespace SiGIProV1.Vistas.Proveedores
{
    public partial class AgregarProveedor : Form
    {
        public AgregarProveedor()
        {
            InitializeComponent();
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            new Controlador.ControlProveedor().verificarCampoLetras(e);
        }

        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            new Controlador.ControlProveedor().verificarCampoNumeros(e);
        }

        private void bRegistrar_Click(object sender, EventArgs e)
        {
            new Controlador.ControlProveedor().agregarProveedor(textBoxRuc, textBoxNombre, textBoxDireccion, textBoxCorreo, textBoxTelefono, labelErrorRUC, labelErrorTelefono, labelErrorCorreo);
        }

        private void textBoxRuc_KeyUp(object sender, KeyEventArgs e)
        {
            new Controlador.ControlProveedor().verificarCampoRUC(labelErrorRUC, textBoxRuc);
            //new Controlador.ControlProveedor().verificarCampoNumerosKeyUp(e, textBoxRuc);
        }

        private void textBoxRuc_Leave(object sender, EventArgs e)
        {
            //new Controlador.ControlProveedor().verificarCampoRUC(labelErrorRUC, textBoxRuc);
        }

        private void textBoxCorreo_KeyUp(object sender, KeyEventArgs e)
        {
            new Controlador.ControlProveedor().verificarCampoCorreo(labelErrorCorreo, textBoxCorreo);
        }

        private void textBoxTelefono_KeyUp(object sender, KeyEventArgs e)
        {
            new Controlador.ControlProveedor().verificarTelefono(textBoxTelefono, labelErrorTelefono);
        }

        private void textBoxRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            new Controlador.ControlProveedor().verificarCampoNumeros(e);
        }
    }
}
