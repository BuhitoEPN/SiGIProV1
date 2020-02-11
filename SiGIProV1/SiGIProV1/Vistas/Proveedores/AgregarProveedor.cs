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
            controlProveedor = new Controlador.ControlProveedor();
        }

        private void bRegistrar_Click(object sender, EventArgs e)
        {
            controlProveedor = new Controlador.ControlProveedor();
            controlProveedor.agregarProveedor(textBoxRuc.Text, textBoxNombre.Text, textBoxDireccion.Text, textBoxCorreo.Text, textBoxTelefono.Text);
            vaciarTextBox();
        }

        private void vaciarTextBox()
        {
            textBoxRuc.Text = "";
            textBoxNombre.Text = "";
            textBoxDireccion.Text = "";
            textBoxCorreo.Text = "";
            textBoxTelefono.Text = "";
        }

    }
}
