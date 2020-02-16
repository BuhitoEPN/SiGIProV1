using System;
using System.Windows.Forms;

namespace SiGIProV1.Vistas.Proveedores
{
    //Controlador.ControlProveedor controlProveedor;
    public partial class ActualizarProveedor : Form
    {
        public ActualizarProveedor()
        {
            InitializeComponent();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            new Controlador.ControlProveedor().buscarProveedor(textBoxRUCBuscar, labelRUC, textBoxNombre, textBoxDireccion, textBoxCorreo, comboBoxEstado, textBoxTelefono);

        }

        private void bActualizar_Click(object sender, EventArgs e)
        {
            new Controlador.ControlProveedor().actualizarProveedor(labelRUC, textBoxNombre, textBoxDireccion, textBoxCorreo, textBoxTelefono, comboBoxEstado, labelErrorTelefono, labelErrorCorreo);
        }

        private void textBoxRUCBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            new Controlador.ControlProveedor().verificarCampoNumeros(e);
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


        private void comboBoxEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxEstado.SelectedIndex == 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea dar de alta al proveedor?", "Cambiar Estado", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                }
                else if (dialogResult == DialogResult.No)
                {
                    comboBoxEstado.SelectedIndex = 1;
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea dar de baja el estado?", "Cambiar Estado", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                }
                else if (dialogResult == DialogResult.No)
                {
                    comboBoxEstado.SelectedIndex = 0;
                }
            }
        }
    }
}
