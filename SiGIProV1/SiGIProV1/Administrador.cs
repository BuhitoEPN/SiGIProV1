﻿using SiGIProV1.Controlador;
using SiGIProV1.Vistas.Proveedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SiGIProV1.Vistas;
using SiGIProV1.Vistas.Inventarios;
using SiGIProV1.Vistas.Categoría;
using SiGIProV1.Vistas.Categoria;
using SiGIProV1.Vistas.Producción;
using SiGIProV1.Vistas.Clientes;
using SiGIProV1.Vistas.Ventas;

namespace SiGIProV1
{
    public partial class Administrador : Form
    {
        private Form currentChildForm = new Form();
        private ControladorInterfaz controlInterfaz = new ControladorInterfaz();
        private String usuario;

        public Administrador(string user)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Text = "Administrador";
            this.menuSuperior.Renderer = new MenuStripRender();
            this.menuSuperior.Renderer = new MenuStripRender();
            usuario = user;
            controlInterfaz.OpenChildForm(new HomeAdministrador(usuario), currentChildForm, panelEscritorio);
        }

        //HOME:
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            controlInterfaz.OpenChildForm(new HomeAdministrador(usuario), currentChildForm, panelEscritorio);
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
        }
        /*------------------------------------------------------
        * -------------------PROVEEDORES------------------------
        ------------------------------------------------------*/
        private void listarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            controlInterfaz.OpenChildForm(new AgregarProveedor(), currentChildForm, panelEscritorio);

        }

        private void registrarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlInterfaz.OpenChildForm(new ConsultarProveedor(), currentChildForm, panelEscritorio);
        }

        private void actualizarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlInterfaz.OpenChildForm(new ActualizarProveedor(), currentChildForm, panelEscritorio);
        }
        /*------------------------------------------------------
         * -------------------INVENTARIOS-----------------------
         ------------------------------------------------------*/

        //INVENTARIO MATERIA PRIMA:
        private void agregarMateriaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlInterfaz.OpenChildForm(new AgregarNuevaMateriaPrima(), currentChildForm, panelEscritorio);
        }

        private void consultarMateriaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlInterfaz.OpenChildForm(new ConsultarMateriaPrima(), currentChildForm, panelEscritorio);
        }

        private void actualizarMateriaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlInterfaz.OpenChildForm(new ActualizarMateriaPrima(), currentChildForm, panelEscritorio);
        }

        private void agregarStockDeMateriaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlInterfaz.OpenChildForm(new ElaborarMateriaPrima(), currentChildForm, panelEscritorio);
        }
        //INVENTARIO PRODUCTOS:
        private void consultarProductosTerminadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlInterfaz.OpenChildForm(new ConsultarProducto(), currentChildForm, panelEscritorio);
        }

        /*------------------------------------------------------
        * -------------------PRODUCCIÓN-----------------------
        ------------------------------------------------------*/

        //CATEGORÍA:
        private void agregarCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlInterfaz.OpenChildForm(new AgregarCategoria(), currentChildForm, panelEscritorio);
        }

        private void consultarCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlInterfaz.OpenChildForm(new ConsultarCategoria(), currentChildForm, panelEscritorio);
        }

        private void actualizarCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlInterfaz.OpenChildForm(new ActualizarCategoria(), currentChildForm, panelEscritorio);
        }

        //PRODUCCIÓN:
        private void agregarNuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlInterfaz.OpenChildForm(new AgregarProducto(), currentChildForm, panelEscritorio);
        }

        private void consultarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlInterfaz.OpenChildForm(new ConsultarProducto(), currentChildForm, panelEscritorio);
        }

        private void actualizarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlInterfaz.OpenChildForm(new ActualizarProducto(), currentChildForm, panelEscritorio);
        }

        private void elaborarLoteProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        /*------------------------------------------------------
        * -------------------CLIENTE----------------------------
        ------------------------------------------------------*/
        private void agregarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            controlInterfaz.OpenChildForm(new AgregarCliente(), currentChildForm, panelEscritorio);
        }

        private void consultarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            controlInterfaz.OpenChildForm(new ConsultarCliente(), currentChildForm, panelEscritorio);
        }

        private void actualizarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            controlInterfaz.OpenChildForm(new ActualizarCliente(), currentChildForm, panelEscritorio);
        }
        /*------------------------------------------------------
        * -------------------VENTAS-----------------------------
        ------------------------------------------------------*/
        private void registrarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlInterfaz.OpenChildForm(new GenerarOrden(), currentChildForm, panelEscritorio);
        }
        /*------------------------------------------------------
        * -------------------EMPLEADO---------------------------
        ------------------------------------------------------*/
        private void agregarEmpleadoToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void consultarEmpleadoToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void actualizarEmpleadoToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        /*-----------------------------------------------------------------------------
         ------------------------- FUNCIONALIDAD --------------------------------------
          -----------------------------------------------------------------------------*/

        //BOTONES DE CONTROL:
        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            buttonRestaurar.Visible = false;
            buttonMaximizar.Visible = true;
        }

        private void buttonMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            buttonMaximizar.Visible = false;
            buttonRestaurar.Visible = true;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //DRAG FORM:

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void menuSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
