using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiGIProV1.Vistas.Proveedores
{
    public partial class AgregarProveedor : Form
    {
        Controlador.ControlProveedor controlProveedor;
        public AgregarProveedor()
        {
            InitializeComponent();
        }

        private void textBoxRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //controlProveedor = new Controlador.ControlProveedor();
           // controlProveedor.verificarCampoRUC(e, labelErrorRUC, textBoxRuc);
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlProveedor = new Controlador.ControlProveedor();
            controlProveedor.verificarCampoLetras(e);
        }

        private void textBoxCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlProveedor = new Controlador.ControlProveedor();
            controlProveedor.verificarCampoCorreo(labelErrorCorreo, textBoxCorreo);
        }
        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlProveedor = new Controlador.ControlProveedor();
            controlProveedor.verificarCampoNumeros(e);
        }

        private void bRegistrar_Click(object sender, EventArgs e)
        {
            controlProveedor = new Controlador.ControlProveedor();
            controlProveedor.agregarProveedor(textBoxRuc, textBoxNombre, textBoxDireccion, textBoxCorreo, textBoxTelefono, labelErrorRUC, labelErrorTelefono, labelErrorCorreo);
        }
    }
}
