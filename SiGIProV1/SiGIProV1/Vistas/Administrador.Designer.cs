namespace SiGIProV1
{
    partial class Administrador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.buttonRestaurar = new System.Windows.Forms.Button();
            this.buttonMinimizar = new System.Windows.Forms.Button();
            this.buttonMaximizar = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.menuSuperior = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarios = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioDeMateriaPrimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarMateriaPrimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarMateriaPrimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarMateriaPrimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarStockDeMateriaPrimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProductosTerminadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elaborarLoteProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEmpleadoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEmpleadoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarEmpleadoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelEscritorio = new System.Windows.Forms.Panel();
            this.panelTitulo.SuspendLayout();
            this.menuSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.panelTitulo.Controls.Add(this.buttonRestaurar);
            this.panelTitulo.Controls.Add(this.buttonMinimizar);
            this.panelTitulo.Controls.Add(this.buttonMaximizar);
            this.panelTitulo.Controls.Add(this.buttonCerrar);
            this.panelTitulo.Controls.Add(this.menuSuperior);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1080, 35);
            this.panelTitulo.TabIndex = 5;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // buttonRestaurar
            // 
            this.buttonRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRestaurar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRestaurar.BackgroundImage")));
            this.buttonRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRestaurar.FlatAppearance.BorderSize = 0;
            this.buttonRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.buttonRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestaurar.Location = new System.Drawing.Point(1003, 2);
            this.buttonRestaurar.Name = "buttonRestaurar";
            this.buttonRestaurar.Size = new System.Drawing.Size(30, 30);
            this.buttonRestaurar.TabIndex = 9;
            this.buttonRestaurar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonRestaurar.UseVisualStyleBackColor = true;
            this.buttonRestaurar.Visible = false;
            this.buttonRestaurar.Click += new System.EventHandler(this.buttonRestaurar_Click);
            // 
            // buttonMinimizar
            // 
            this.buttonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMinimizar.BackgroundImage")));
            this.buttonMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMinimizar.FlatAppearance.BorderSize = 0;
            this.buttonMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.buttonMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimizar.Location = new System.Drawing.Point(966, 2);
            this.buttonMinimizar.Name = "buttonMinimizar";
            this.buttonMinimizar.Size = new System.Drawing.Size(30, 30);
            this.buttonMinimizar.TabIndex = 8;
            this.buttonMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonMinimizar.UseVisualStyleBackColor = true;
            this.buttonMinimizar.Click += new System.EventHandler(this.buttonMinimizar_Click);
            // 
            // buttonMaximizar
            // 
            this.buttonMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMaximizar.BackgroundImage")));
            this.buttonMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMaximizar.FlatAppearance.BorderSize = 0;
            this.buttonMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.buttonMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximizar.Location = new System.Drawing.Point(1003, 2);
            this.buttonMaximizar.Name = "buttonMaximizar";
            this.buttonMaximizar.Size = new System.Drawing.Size(30, 30);
            this.buttonMaximizar.TabIndex = 7;
            this.buttonMaximizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonMaximizar.UseVisualStyleBackColor = true;
            this.buttonMaximizar.Click += new System.EventHandler(this.buttonMaximizar_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCerrar.BackgroundImage")));
            this.buttonCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCerrar.FlatAppearance.BorderSize = 0;
            this.buttonCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrar.Location = new System.Drawing.Point(1038, 2);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(30, 30);
            this.buttonCerrar.TabIndex = 6;
            this.buttonCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // menuSuperior
            // 
            this.menuSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.menuSuperior.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.proveedores,
            this.inventarios,
            this.ventasToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.empleadosToolStripMenuItem});
            this.menuSuperior.Location = new System.Drawing.Point(0, 0);
            this.menuSuperior.Name = "menuSuperior";
            this.menuSuperior.Size = new System.Drawing.Size(1080, 29);
            this.menuSuperior.TabIndex = 10;
            this.menuSuperior.Text = "menuStrip1";
            this.menuSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuSuperior_MouseDown);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // proveedores
            // 
            this.proveedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProveedoresToolStripMenuItem,
            this.listarProveedorToolStripMenuItem,
            this.actualizarProveedorToolStripMenuItem});
            this.proveedores.ForeColor = System.Drawing.Color.Gainsboro;
            this.proveedores.Name = "proveedores";
            this.proveedores.Size = new System.Drawing.Size(118, 25);
            this.proveedores.Text = "Proveedores";
            // 
            // agregarProveedoresToolStripMenuItem
            // 
            this.agregarProveedoresToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.agregarProveedoresToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.agregarProveedoresToolStripMenuItem.Name = "agregarProveedoresToolStripMenuItem";
            this.agregarProveedoresToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.agregarProveedoresToolStripMenuItem.Text = "Agregar Proveedor";
            this.agregarProveedoresToolStripMenuItem.Click += new System.EventHandler(this.listarProveedoresToolStripMenuItem_Click);
            // 
            // listarProveedorToolStripMenuItem
            // 
            this.listarProveedorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.listarProveedorToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.listarProveedorToolStripMenuItem.Name = "listarProveedorToolStripMenuItem";
            this.listarProveedorToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.listarProveedorToolStripMenuItem.Text = "Consultar Proveedor";
            this.listarProveedorToolStripMenuItem.Click += new System.EventHandler(this.registrarProveedorToolStripMenuItem_Click);
            // 
            // actualizarProveedorToolStripMenuItem
            // 
            this.actualizarProveedorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.actualizarProveedorToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.actualizarProveedorToolStripMenuItem.Name = "actualizarProveedorToolStripMenuItem";
            this.actualizarProveedorToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.actualizarProveedorToolStripMenuItem.Text = "Actualizar Proveedor";
            this.actualizarProveedorToolStripMenuItem.Click += new System.EventHandler(this.actualizarProveedorToolStripMenuItem_Click);
            // 
            // inventarios
            // 
            this.inventarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.inventarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioDeMateriaPrimaToolStripMenuItem,
            this.inventarioDeProductosToolStripMenuItem});
            this.inventarios.ForeColor = System.Drawing.Color.Gainsboro;
            this.inventarios.Name = "inventarios";
            this.inventarios.Size = new System.Drawing.Size(109, 25);
            this.inventarios.Text = "Inventarios";
            // 
            // inventarioDeMateriaPrimaToolStripMenuItem
            // 
            this.inventarioDeMateriaPrimaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.inventarioDeMateriaPrimaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarMateriaPrimaToolStripMenuItem,
            this.consultarMateriaPrimaToolStripMenuItem,
            this.actualizarMateriaPrimaToolStripMenuItem,
            this.agregarStockDeMateriaPrimaToolStripMenuItem});
            this.inventarioDeMateriaPrimaToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.inventarioDeMateriaPrimaToolStripMenuItem.Name = "inventarioDeMateriaPrimaToolStripMenuItem";
            this.inventarioDeMateriaPrimaToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.inventarioDeMateriaPrimaToolStripMenuItem.Text = "Inventario de Materia Prima";
            // 
            // agregarMateriaPrimaToolStripMenuItem
            // 
            this.agregarMateriaPrimaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.agregarMateriaPrimaToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.agregarMateriaPrimaToolStripMenuItem.Name = "agregarMateriaPrimaToolStripMenuItem";
            this.agregarMateriaPrimaToolStripMenuItem.Size = new System.Drawing.Size(331, 26);
            this.agregarMateriaPrimaToolStripMenuItem.Text = "Agregar Nueva Materia Prima";
            this.agregarMateriaPrimaToolStripMenuItem.Click += new System.EventHandler(this.agregarMateriaPrimaToolStripMenuItem_Click);
            // 
            // consultarMateriaPrimaToolStripMenuItem
            // 
            this.consultarMateriaPrimaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.consultarMateriaPrimaToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.consultarMateriaPrimaToolStripMenuItem.Name = "consultarMateriaPrimaToolStripMenuItem";
            this.consultarMateriaPrimaToolStripMenuItem.Size = new System.Drawing.Size(331, 26);
            this.consultarMateriaPrimaToolStripMenuItem.Text = "Consultar Materia Prima";
            this.consultarMateriaPrimaToolStripMenuItem.Click += new System.EventHandler(this.consultarMateriaPrimaToolStripMenuItem_Click);
            // 
            // actualizarMateriaPrimaToolStripMenuItem
            // 
            this.actualizarMateriaPrimaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.actualizarMateriaPrimaToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.actualizarMateriaPrimaToolStripMenuItem.Name = "actualizarMateriaPrimaToolStripMenuItem";
            this.actualizarMateriaPrimaToolStripMenuItem.Size = new System.Drawing.Size(331, 26);
            this.actualizarMateriaPrimaToolStripMenuItem.Text = "Actualizar Materia Prima";
            this.actualizarMateriaPrimaToolStripMenuItem.Click += new System.EventHandler(this.actualizarMateriaPrimaToolStripMenuItem_Click);
            // 
            // agregarStockDeMateriaPrimaToolStripMenuItem
            // 
            this.agregarStockDeMateriaPrimaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.agregarStockDeMateriaPrimaToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.agregarStockDeMateriaPrimaToolStripMenuItem.Name = "agregarStockDeMateriaPrimaToolStripMenuItem";
            this.agregarStockDeMateriaPrimaToolStripMenuItem.Size = new System.Drawing.Size(331, 26);
            this.agregarStockDeMateriaPrimaToolStripMenuItem.Text = "Agregar Stock de Materia Prima";
            this.agregarStockDeMateriaPrimaToolStripMenuItem.Click += new System.EventHandler(this.agregarStockDeMateriaPrimaToolStripMenuItem_Click);
            // 
            // inventarioDeProductosToolStripMenuItem
            // 
            this.inventarioDeProductosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.inventarioDeProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarProductosTerminadosToolStripMenuItem});
            this.inventarioDeProductosToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.inventarioDeProductosToolStripMenuItem.Name = "inventarioDeProductosToolStripMenuItem";
            this.inventarioDeProductosToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.inventarioDeProductosToolStripMenuItem.Text = "Inventario de Productos";
            // 
            // consultarProductosTerminadosToolStripMenuItem
            // 
            this.consultarProductosTerminadosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.consultarProductosTerminadosToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.consultarProductosTerminadosToolStripMenuItem.Name = "consultarProductosTerminadosToolStripMenuItem";
            this.consultarProductosTerminadosToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.consultarProductosTerminadosToolStripMenuItem.Text = "Consultar Producto";
            this.consultarProductosTerminadosToolStripMenuItem.Click += new System.EventHandler(this.consultarProductosTerminadosToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoProductoToolStripMenuItem,
            this.consultarProductoToolStripMenuItem,
            this.actualizarProductoToolStripMenuItem,
            this.elaborarLoteProductosToolStripMenuItem});
            this.ventasToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(110, 25);
            this.ventasToolStripMenuItem.Text = "Producción";
            // 
            // agregarNuevoProductoToolStripMenuItem
            // 
            this.agregarNuevoProductoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.agregarNuevoProductoToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.agregarNuevoProductoToolStripMenuItem.Name = "agregarNuevoProductoToolStripMenuItem";
            this.agregarNuevoProductoToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.agregarNuevoProductoToolStripMenuItem.Text = "Agregar Nuevo Producto";
            this.agregarNuevoProductoToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevoProductoToolStripMenuItem_Click);
            // 
            // consultarProductoToolStripMenuItem
            // 
            this.consultarProductoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.consultarProductoToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.consultarProductoToolStripMenuItem.Name = "consultarProductoToolStripMenuItem";
            this.consultarProductoToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.consultarProductoToolStripMenuItem.Text = "Consultar Producto";
            this.consultarProductoToolStripMenuItem.Click += new System.EventHandler(this.consultarProductoToolStripMenuItem_Click);
            // 
            // actualizarProductoToolStripMenuItem
            // 
            this.actualizarProductoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.actualizarProductoToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.actualizarProductoToolStripMenuItem.Name = "actualizarProductoToolStripMenuItem";
            this.actualizarProductoToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.actualizarProductoToolStripMenuItem.Text = "Actualizar Producto";
            this.actualizarProductoToolStripMenuItem.Click += new System.EventHandler(this.actualizarProductoToolStripMenuItem_Click);
            // 
            // elaborarLoteProductosToolStripMenuItem
            // 
            this.elaborarLoteProductosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.elaborarLoteProductosToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.elaborarLoteProductosToolStripMenuItem.Name = "elaborarLoteProductosToolStripMenuItem";
            this.elaborarLoteProductosToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.elaborarLoteProductosToolStripMenuItem.Text = "Elaborar Nuevo Lote de Productos";
            this.elaborarLoteProductosToolStripMenuItem.Click += new System.EventHandler(this.elaborarLoteProductosToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarClienteToolStripMenuItem1,
            this.consultarClienteToolStripMenuItem1,
            this.actualizarClienteToolStripMenuItem1});
            this.clienteToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.clienteToolStripMenuItem.Text = "Clientes";
            // 
            // agregarClienteToolStripMenuItem1
            // 
            this.agregarClienteToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.agregarClienteToolStripMenuItem1.ForeColor = System.Drawing.Color.Gainsboro;
            this.agregarClienteToolStripMenuItem1.Name = "agregarClienteToolStripMenuItem1";
            this.agregarClienteToolStripMenuItem1.Size = new System.Drawing.Size(262, 26);
            this.agregarClienteToolStripMenuItem1.Text = "Agregar Nuevo Cliente";
            this.agregarClienteToolStripMenuItem1.Click += new System.EventHandler(this.agregarClienteToolStripMenuItem1_Click);
            // 
            // consultarClienteToolStripMenuItem1
            // 
            this.consultarClienteToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.consultarClienteToolStripMenuItem1.ForeColor = System.Drawing.Color.Gainsboro;
            this.consultarClienteToolStripMenuItem1.Name = "consultarClienteToolStripMenuItem1";
            this.consultarClienteToolStripMenuItem1.Size = new System.Drawing.Size(262, 26);
            this.consultarClienteToolStripMenuItem1.Text = "Consultar Cliente";
            this.consultarClienteToolStripMenuItem1.Click += new System.EventHandler(this.consultarClienteToolStripMenuItem1_Click);
            // 
            // actualizarClienteToolStripMenuItem1
            // 
            this.actualizarClienteToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.actualizarClienteToolStripMenuItem1.ForeColor = System.Drawing.Color.Gainsboro;
            this.actualizarClienteToolStripMenuItem1.Name = "actualizarClienteToolStripMenuItem1";
            this.actualizarClienteToolStripMenuItem1.Size = new System.Drawing.Size(262, 26);
            this.actualizarClienteToolStripMenuItem1.Text = "Actualizar Cliente";
            this.actualizarClienteToolStripMenuItem1.Click += new System.EventHandler(this.actualizarClienteToolStripMenuItem1_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarPedidoToolStripMenuItem});
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.clientesToolStripMenuItem.Text = "Ventas";
            // 
            // registrarPedidoToolStripMenuItem
            // 
            this.registrarPedidoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.registrarPedidoToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.registrarPedidoToolStripMenuItem.Name = "registrarPedidoToolStripMenuItem";
            this.registrarPedidoToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.registrarPedidoToolStripMenuItem.Text = "Registrar Pedido";
            this.registrarPedidoToolStripMenuItem.Click += new System.EventHandler(this.registrarPedidoToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEmpleadoToolStripMenuItem2,
            this.consultarEmpleadoToolStripMenuItem2,
            this.actualizarEmpleadoToolStripMenuItem2});
            this.empleadosToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(108, 25);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // agregarEmpleadoToolStripMenuItem2
            // 
            this.agregarEmpleadoToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.agregarEmpleadoToolStripMenuItem2.ForeColor = System.Drawing.Color.Gainsboro;
            this.agregarEmpleadoToolStripMenuItem2.Name = "agregarEmpleadoToolStripMenuItem2";
            this.agregarEmpleadoToolStripMenuItem2.Size = new System.Drawing.Size(286, 26);
            this.agregarEmpleadoToolStripMenuItem2.Text = "Agregar Nuevo Empleado";
            this.agregarEmpleadoToolStripMenuItem2.Click += new System.EventHandler(this.agregarEmpleadoToolStripMenuItem2_Click);
            // 
            // consultarEmpleadoToolStripMenuItem2
            // 
            this.consultarEmpleadoToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.consultarEmpleadoToolStripMenuItem2.ForeColor = System.Drawing.Color.Gainsboro;
            this.consultarEmpleadoToolStripMenuItem2.Name = "consultarEmpleadoToolStripMenuItem2";
            this.consultarEmpleadoToolStripMenuItem2.Size = new System.Drawing.Size(286, 26);
            this.consultarEmpleadoToolStripMenuItem2.Text = "Consultar Empleado";
            this.consultarEmpleadoToolStripMenuItem2.Click += new System.EventHandler(this.consultarEmpleadoToolStripMenuItem2_Click);
            // 
            // actualizarEmpleadoToolStripMenuItem2
            // 
            this.actualizarEmpleadoToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.actualizarEmpleadoToolStripMenuItem2.ForeColor = System.Drawing.Color.Gainsboro;
            this.actualizarEmpleadoToolStripMenuItem2.Name = "actualizarEmpleadoToolStripMenuItem2";
            this.actualizarEmpleadoToolStripMenuItem2.Size = new System.Drawing.Size(286, 26);
            this.actualizarEmpleadoToolStripMenuItem2.Text = "Actualizar Empleado";
            this.actualizarEmpleadoToolStripMenuItem2.Click += new System.EventHandler(this.actualizarEmpleadoToolStripMenuItem2_Click);
            // 
            // panelEscritorio
            // 
            this.panelEscritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.panelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEscritorio.Location = new System.Drawing.Point(0, 35);
            this.panelEscritorio.Name = "panelEscritorio";
            this.panelEscritorio.Size = new System.Drawing.Size(1080, 609);
            this.panelEscritorio.TabIndex = 6;
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 644);
            this.Controls.Add(this.panelEscritorio);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.menuSuperior.ResumeLayout(false);
            this.menuSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Button buttonRestaurar;
        private System.Windows.Forms.Button buttonMinimizar;
        private System.Windows.Forms.Button buttonMaximizar;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.MenuStrip menuSuperior;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedores;
        private System.Windows.Forms.ToolStripMenuItem agregarProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarios;
        private System.Windows.Forms.ToolStripMenuItem inventarioDeMateriaPrimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarMateriaPrimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarMateriaPrimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarMateriaPrimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarStockDeMateriaPrimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarProductosTerminadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elaborarLoteProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem actualizarClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.Panel panelEscritorio;
        private System.Windows.Forms.ToolStripMenuItem agregarEmpleadoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem consultarEmpleadoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem actualizarEmpleadoToolStripMenuItem2;
    }
}

