using System;
using System.Windows.Forms;

namespace SiGIProV1.Vistas.Proveedores
{
    public partial class ConsultarProveedor : Form
    {
        public ConsultarProveedor()
        {
            InitializeComponent();
            dGVProveedores.DataSource = new Controlador.ControlProveedor().listarProveedores();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            dGVProveedores.DataSource = new Controlador.ControlProveedor().filtroProveedor(comboBoxProveedor.Text, tNombreDelProducto.Text);
        }
    }
}
