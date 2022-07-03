namespace FormularioCarpinteria
{
    partial class FormMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            this.btnPersonal = new System.Windows.Forms.Button();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelOpcion = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRe = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelPersonalSubMenu = new System.Windows.Forms.Panel();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnInsumo = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.panelProductoSubMenu = new System.Windows.Forms.Panel();
            this.btnPSalida = new System.Windows.Forms.Button();
            this.btnPEntrada = new System.Windows.Forms.Button();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.btnModelos = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.btnActividades = new System.Windows.Forms.Button();
            this.btnOrdenP = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.panelBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panelOpcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).BeginInit();
            this.panelPersonalSubMenu.SuspendLayout();
            this.panelProductoSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPersonal
            // 
            this.btnPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.btnPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonal.FlatAppearance.BorderSize = 0;
            this.btnPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonal.ForeColor = System.Drawing.Color.White;
            this.btnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonal.Location = new System.Drawing.Point(0, 190);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPersonal.Size = new System.Drawing.Size(250, 40);
            this.btnPersonal.TabIndex = 1;
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonal.UseVisualStyleBackColor = false;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.panelBarra.Controls.Add(this.btnMin);
            this.panelBarra.Controls.Add(this.btnMax);
            this.panelBarra.Controls.Add(this.btnRestaurar);
            this.panelBarra.Controls.Add(this.btnCerrar);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(1100, 30);
            this.panelBarra.TabIndex = 6;
            this.panelBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarra_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(1007, 4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(20, 20);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 3;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.Location = new System.Drawing.Point(1038, 4);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(20, 20);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 2;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1038, 4);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(20, 20);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 1;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1069, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelOpcion
            // 
            this.panelOpcion.AutoScroll = true;
            this.panelOpcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.panelOpcion.Controls.Add(this.btnReportes);
            this.panelOpcion.Controls.Add(this.btnOrdenP);
            this.panelOpcion.Controls.Add(this.btnPedido);
            this.panelOpcion.Controls.Add(this.btnActividades);
            this.panelOpcion.Controls.Add(this.btnModelos);
            this.panelOpcion.Controls.Add(this.btnMaterial);
            this.panelOpcion.Controls.Add(this.panelProductoSubMenu);
            this.panelOpcion.Controls.Add(this.btnProducto);
            this.panelOpcion.Controls.Add(this.btnInsumo);
            this.panelOpcion.Controls.Add(this.btnCliente);
            this.panelOpcion.Controls.Add(this.panelPersonalSubMenu);
            this.panelOpcion.Controls.Add(this.btnPersonal);
            this.panelOpcion.Controls.Add(this.pictureBox1);
            this.panelOpcion.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOpcion.Location = new System.Drawing.Point(0, 30);
            this.panelOpcion.Name = "panelOpcion";
            this.panelOpcion.Size = new System.Drawing.Size(250, 720);
            this.panelOpcion.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelRe
            // 
            this.panelRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.panelRe.Controls.Add(this.btnRegresar);
            this.panelRe.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRe.Location = new System.Drawing.Point(250, 30);
            this.panelRe.Name = "panelRe";
            this.panelRe.Size = new System.Drawing.Size(850, 30);
            this.panelRe.TabIndex = 8;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(16, 5);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(20, 20);
            this.btnRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.TabStop = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 60);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(850, 690);
            this.panelContenedor.TabIndex = 9;
            // 
            // panelPersonalSubMenu
            // 
            this.panelPersonalSubMenu.Controls.Add(this.btnAsignar);
            this.panelPersonalSubMenu.Controls.Add(this.btnEmpleado);
            this.panelPersonalSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPersonalSubMenu.Location = new System.Drawing.Point(0, 230);
            this.panelPersonalSubMenu.Name = "panelPersonalSubMenu";
            this.panelPersonalSubMenu.Size = new System.Drawing.Size(250, 62);
            this.panelPersonalSubMenu.TabIndex = 2;
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.btnEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnEmpleado.Location = new System.Drawing.Point(0, 0);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnEmpleado.Size = new System.Drawing.Size(250, 30);
            this.btnEmpleado.TabIndex = 0;
            this.btnEmpleado.Text = "Empleado";
            this.btnEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleado.UseVisualStyleBackColor = false;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.btnAsignar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsignar.FlatAppearance.BorderSize = 0;
            this.btnAsignar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.ForeColor = System.Drawing.Color.White;
            this.btnAsignar.Location = new System.Drawing.Point(0, 30);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAsignar.Size = new System.Drawing.Size(250, 30);
            this.btnAsignar.TabIndex = 1;
            this.btnAsignar.Text = "Asignar Personal";
            this.btnAsignar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(0, 292);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCliente.Size = new System.Drawing.Size(250, 40);
            this.btnCliente.TabIndex = 3;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnInsumo
            // 
            this.btnInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.btnInsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsumo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsumo.FlatAppearance.BorderSize = 0;
            this.btnInsumo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsumo.ForeColor = System.Drawing.Color.White;
            this.btnInsumo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsumo.Location = new System.Drawing.Point(0, 332);
            this.btnInsumo.Name = "btnInsumo";
            this.btnInsumo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInsumo.Size = new System.Drawing.Size(250, 40);
            this.btnInsumo.TabIndex = 4;
            this.btnInsumo.Text = "Insumos";
            this.btnInsumo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsumo.UseVisualStyleBackColor = false;
            this.btnInsumo.Click += new System.EventHandler(this.btnInsumo_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.btnProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.ForeColor = System.Drawing.Color.White;
            this.btnProducto.Location = new System.Drawing.Point(0, 372);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProducto.Size = new System.Drawing.Size(250, 40);
            this.btnProducto.TabIndex = 5;
            this.btnProducto.Text = "Producto";
            this.btnProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.UseVisualStyleBackColor = false;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // panelProductoSubMenu
            // 
            this.panelProductoSubMenu.Controls.Add(this.btnPSalida);
            this.panelProductoSubMenu.Controls.Add(this.btnPEntrada);
            this.panelProductoSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProductoSubMenu.Location = new System.Drawing.Point(0, 412);
            this.panelProductoSubMenu.Name = "panelProductoSubMenu";
            this.panelProductoSubMenu.Size = new System.Drawing.Size(250, 62);
            this.panelProductoSubMenu.TabIndex = 6;
            // 
            // btnPSalida
            // 
            this.btnPSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.btnPSalida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPSalida.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPSalida.FlatAppearance.BorderSize = 0;
            this.btnPSalida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnPSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSalida.ForeColor = System.Drawing.Color.White;
            this.btnPSalida.Location = new System.Drawing.Point(0, 30);
            this.btnPSalida.Name = "btnPSalida";
            this.btnPSalida.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPSalida.Size = new System.Drawing.Size(250, 30);
            this.btnPSalida.TabIndex = 3;
            this.btnPSalida.Text = "Salida";
            this.btnPSalida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPSalida.UseVisualStyleBackColor = false;
            this.btnPSalida.Click += new System.EventHandler(this.btnPSalida_Click);
            // 
            // btnPEntrada
            // 
            this.btnPEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.btnPEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPEntrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPEntrada.FlatAppearance.BorderSize = 0;
            this.btnPEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnPEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPEntrada.ForeColor = System.Drawing.Color.White;
            this.btnPEntrada.Location = new System.Drawing.Point(0, 0);
            this.btnPEntrada.Name = "btnPEntrada";
            this.btnPEntrada.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPEntrada.Size = new System.Drawing.Size(250, 30);
            this.btnPEntrada.TabIndex = 2;
            this.btnPEntrada.Text = "Entrada";
            this.btnPEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPEntrada.UseVisualStyleBackColor = false;
            this.btnPEntrada.Click += new System.EventHandler(this.btnPEntrada_Click);
            // 
            // btnMaterial
            // 
            this.btnMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.btnMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaterial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaterial.FlatAppearance.BorderSize = 0;
            this.btnMaterial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterial.ForeColor = System.Drawing.Color.White;
            this.btnMaterial.Location = new System.Drawing.Point(0, 474);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMaterial.Size = new System.Drawing.Size(250, 40);
            this.btnMaterial.TabIndex = 7;
            this.btnMaterial.Text = "Material";
            this.btnMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterial.UseVisualStyleBackColor = false;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // btnModelos
            // 
            this.btnModelos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.btnModelos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModelos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModelos.FlatAppearance.BorderSize = 0;
            this.btnModelos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnModelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModelos.ForeColor = System.Drawing.Color.White;
            this.btnModelos.Location = new System.Drawing.Point(0, 514);
            this.btnModelos.Name = "btnModelos";
            this.btnModelos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnModelos.Size = new System.Drawing.Size(250, 40);
            this.btnModelos.TabIndex = 8;
            this.btnModelos.Text = "Modelos";
            this.btnModelos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModelos.UseVisualStyleBackColor = false;
            this.btnModelos.Click += new System.EventHandler(this.btnModelos_Click);
            // 
            // btnPedido
            // 
            this.btnPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.btnPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedido.FlatAppearance.BorderSize = 0;
            this.btnPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.ForeColor = System.Drawing.Color.White;
            this.btnPedido.Location = new System.Drawing.Point(0, 594);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPedido.Size = new System.Drawing.Size(250, 40);
            this.btnPedido.TabIndex = 10;
            this.btnPedido.Text = "Pedido";
            this.btnPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedido.UseVisualStyleBackColor = false;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click_1);
            // 
            // btnActividades
            // 
            this.btnActividades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.btnActividades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActividades.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActividades.FlatAppearance.BorderSize = 0;
            this.btnActividades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnActividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActividades.ForeColor = System.Drawing.Color.White;
            this.btnActividades.Location = new System.Drawing.Point(0, 554);
            this.btnActividades.Name = "btnActividades";
            this.btnActividades.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnActividades.Size = new System.Drawing.Size(250, 40);
            this.btnActividades.TabIndex = 9;
            this.btnActividades.Text = "Actividades";
            this.btnActividades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActividades.UseVisualStyleBackColor = false;
            this.btnActividades.Click += new System.EventHandler(this.btnActividades_Click);
            // 
            // btnOrdenP
            // 
            this.btnOrdenP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.btnOrdenP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdenP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrdenP.FlatAppearance.BorderSize = 0;
            this.btnOrdenP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnOrdenP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenP.ForeColor = System.Drawing.Color.White;
            this.btnOrdenP.Location = new System.Drawing.Point(0, 634);
            this.btnOrdenP.Name = "btnOrdenP";
            this.btnOrdenP.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOrdenP.Size = new System.Drawing.Size(250, 40);
            this.btnOrdenP.TabIndex = 11;
            this.btnOrdenP.Text = "Orden de Produccion";
            this.btnOrdenP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenP.UseVisualStyleBackColor = false;
            this.btnOrdenP.Click += new System.EventHandler(this.btnOrdenP_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Location = new System.Drawing.Point(0, 674);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(250, 40);
            this.btnReportes.TabIndex = 12;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 750);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelRe);
            this.Controls.Add(this.panelOpcion);
            this.Controls.Add(this.panelBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuPrincipal";
            this.panelBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panelOpcion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).EndInit();
            this.panelPersonalSubMenu.ResumeLayout(false);
            this.panelProductoSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Panel panelOpcion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelRe;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox btnRegresar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Panel panelPersonalSubMenu;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnInsumo;
        private System.Windows.Forms.Panel panelProductoSubMenu;
        private System.Windows.Forms.Button btnPSalida;
        private System.Windows.Forms.Button btnPEntrada;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnActividades;
        private System.Windows.Forms.Button btnModelos;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Button btnOrdenP;
        private System.Windows.Forms.Button btnReportes;
    }
}