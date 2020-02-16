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

        private void textBoxRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            new Controlador.ControlProveedor().verificarCampoRUC(e, labelErrorRUC, textBoxRuc);
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            new Controlador.ControlProveedor().verificarCampoLetras(e);
        }

        private void textBoxCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            new Controlador.ControlProveedor().verificarCampoCorreo(labelErrorCorreo, textBoxCorreo);
        }
        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            new Controlador.ControlProveedor().verificarCampoTelefono(e, labelErrorTelefono);
        }

        private void bRegistrar_Click(object sender, EventArgs e)
        {
            new Controlador.ControlProveedor().agregarProveedor(textBoxRuc, textBoxNombre, textBoxDireccion, textBoxCorreo, textBoxTelefono, labelErrorRUC, labelErrorTelefono, labelErrorCorreo);
        }
    }
}
