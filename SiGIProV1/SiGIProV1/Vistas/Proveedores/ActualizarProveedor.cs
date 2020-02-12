﻿using System;
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
    //Controlador.ControlProveedor controlProveedor;
    public partial class ActualizarProveedor : Form
    {
        Controlador.ControlProveedor controlProveedor;
        public ActualizarProveedor()
        {
            InitializeComponent();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            controlProveedor = new Controlador.ControlProveedor();
            controlProveedor.buscarProveedor(textBoxRUCBuscar, labelRUC, textBoxNombre, textBoxDireccion, textBoxCorreo, comboBoxEstado, textBoxTelefono);

        }

        private void bActualizar_Click(object sender, EventArgs e)
        {

        }

        private void textBoxRUCBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlProveedor = new Controlador.ControlProveedor();
            controlProveedor.verificarCampoNumeros(e);
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
