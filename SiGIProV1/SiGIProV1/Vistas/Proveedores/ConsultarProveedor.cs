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
    public partial class ConsultarProveedor : Form
    {
        Controlador.ControlProveedor controlProveedor;
        public ConsultarProveedor()
        {
            InitializeComponent();
            controlProveedor = new Controlador.ControlProveedor();
            dGVProveedores.DataSource = controlProveedor.listarProveedores();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            controlProveedor = new Controlador.ControlProveedor();
            dGVProveedores.DataSource = controlProveedor.filtroProveedor(comboBoxProveedor.Text, tNombreDelProducto.Text);
        }
    }
}
