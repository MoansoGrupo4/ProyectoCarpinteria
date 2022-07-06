namespace FormularioCarpinteria
{
    partial class FormMantenedorProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bntSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.gbDatosInsumos = new System.Windows.Forms.GroupBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.ckbEstInsumo = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dtpFVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtCTotal = new System.Windows.Forms.TextBox();
            this.txtCUnitario = new System.Windows.Forms.TextBox();
            this.lblFechaEmision = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.dgvDatosInsumos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstInsumo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panelBuscar.SuspendLayout();
            this.gbDatosInsumos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosInsumos)).BeginInit();
            this.SuspendLayout();
            // 
            // bntSalir
            // 
            this.bntSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.bntSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.bntSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSalir.ForeColor = System.Drawing.Color.Snow;
            this.bntSalir.Location = new System.Drawing.Point(632, 377);
            this.bntSalir.Name = "bntSalir";
            this.bntSalir.Size = new System.Drawing.Size(180, 50);
            this.bntSalir.TabIndex = 4;
            this.bntSalir.Text = "Salir";
            this.bntSalir.UseVisualStyleBackColor = false;
            this.bntSalir.Click += new System.EventHandler(this.bntSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.Snow;
            this.btnNuevo.Location = new System.Drawing.Point(15, 377);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(180, 50);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Snow;
            this.btnEditar.Location = new System.Drawing.Point(221, 377);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(180, 50);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnDeshabilitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeshabilitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.btnDeshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitar.ForeColor = System.Drawing.Color.Snow;
            this.btnDeshabilitar.Location = new System.Drawing.Point(427, 377);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(180, 50);
            this.btnDeshabilitar.TabIndex = 3;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = false;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // panelBuscar
            // 
            this.panelBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.panelBuscar.Controls.Add(this.txtBuscar);
            this.panelBuscar.Controls.Add(this.lbNombre);
            this.panelBuscar.Controls.Add(this.lbBuscar);
            this.panelBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBuscar.Location = new System.Drawing.Point(0, 0);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(830, 65);
            this.panelBuscar.TabIndex = 13;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(88, 25);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(709, 23);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNombre.Location = new System.Drawing.Point(23, 28);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(66, 18);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "Nombre:";
            this.lbNombre.Click += new System.EventHandler(this.lbNombre_Click);
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbBuscar.Location = new System.Drawing.Point(25, 9);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(40, 13);
            this.lbBuscar.TabIndex = 0;
            this.lbBuscar.Text = "Buscar";
            // 
            // gbDatosInsumos
            // 
            this.gbDatosInsumos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.gbDatosInsumos.Controls.Add(this.txtCategoria);
            this.gbDatosInsumos.Controls.Add(this.txtProducto);
            this.gbDatosInsumos.Controls.Add(this.ckbEstInsumo);
            this.gbDatosInsumos.Controls.Add(this.pictureBox1);
            this.gbDatosInsumos.Controls.Add(this.txtCodigo);
            this.gbDatosInsumos.Controls.Add(this.lblCodigo);
            this.gbDatosInsumos.Controls.Add(this.dtpFVencimiento);
            this.gbDatosInsumos.Controls.Add(this.lblFechaVencimiento);
            this.gbDatosInsumos.Controls.Add(this.dtpFechaIngreso);
            this.gbDatosInsumos.Controls.Add(this.btnCancelar);
            this.gbDatosInsumos.Controls.Add(this.btnModificar);
            this.gbDatosInsumos.Controls.Add(this.btnAgregar);
            this.gbDatosInsumos.Controls.Add(this.txtStock);
            this.gbDatosInsumos.Controls.Add(this.txtCTotal);
            this.gbDatosInsumos.Controls.Add(this.txtCUnitario);
            this.gbDatosInsumos.Controls.Add(this.lblFechaEmision);
            this.gbDatosInsumos.Controls.Add(this.lblStock);
            this.gbDatosInsumos.Controls.Add(this.lblCostoTotal);
            this.gbDatosInsumos.Controls.Add(this.lblDNI);
            this.gbDatosInsumos.Controls.Add(this.lblCategoria);
            this.gbDatosInsumos.Controls.Add(this.lblProducto);
            this.gbDatosInsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosInsumos.ForeColor = System.Drawing.Color.White;
            this.gbDatosInsumos.Location = new System.Drawing.Point(15, 428);
            this.gbDatosInsumos.Name = "gbDatosInsumos";
            this.gbDatosInsumos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbDatosInsumos.Size = new System.Drawing.Size(800, 331);
            this.gbDatosInsumos.TabIndex = 5;
            this.gbDatosInsumos.TabStop = false;
            this.gbDatosInsumos.Text = "Mantenimiento Insumos";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(452, 39);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(180, 21);
            this.txtCategoria.TabIndex = 1;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(113, 84);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(189, 21);
            this.txtProducto.TabIndex = 2;
            // 
            // ckbEstInsumo
            // 
            this.ckbEstInsumo.AutoSize = true;
            this.ckbEstInsumo.Location = new System.Drawing.Point(238, 37);
            this.ckbEstInsumo.Name = "ckbEstInsumo";
            this.ckbEstInsumo.Size = new System.Drawing.Size(64, 19);
            this.ckbEstInsumo.TabIndex = 11;
            this.ckbEstInsumo.Text = "Estado";
            this.ckbEstInsumo.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormularioCarpinteria.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(648, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(113, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(102, 23);
            this.txtCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(9, 37);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 17);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Código:";
            // 
            // dtpFVencimiento
            // 
            this.dtpFVencimiento.Location = new System.Drawing.Point(113, 201);
            this.dtpFVencimiento.Name = "dtpFVencimiento";
            this.dtpFVencimiento.Size = new System.Drawing.Size(232, 21);
            this.dtpFVencimiento.TabIndex = 6;
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVencimiento.Location = new System.Drawing.Point(9, 189);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(101, 34);
            this.lblFechaVencimiento.TabIndex = 4;
            this.lblFechaVencimiento.Text = "Fecha de\r\nvencimimiento:";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(113, 142);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(232, 21);
            this.dtpFechaIngreso.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Snow;
            this.btnCancelar.Location = new System.Drawing.Point(464, 258);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(220, 50);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Snow;
            this.btnModificar.Location = new System.Drawing.Point(238, 258);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(220, 50);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Snow;
            this.btnAgregar.Location = new System.Drawing.Point(13, 258);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(220, 50);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(452, 85);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(46, 23);
            this.txtStock.TabIndex = 3;
            // 
            // txtCTotal
            // 
            this.txtCTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCTotal.Location = new System.Drawing.Point(465, 202);
            this.txtCTotal.Name = "txtCTotal";
            this.txtCTotal.Size = new System.Drawing.Size(134, 23);
            this.txtCTotal.TabIndex = 7;
            // 
            // txtCUnitario
            // 
            this.txtCUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCUnitario.Location = new System.Drawing.Point(465, 143);
            this.txtCUnitario.Name = "txtCUnitario";
            this.txtCUnitario.Size = new System.Drawing.Size(134, 23);
            this.txtCUnitario.TabIndex = 5;
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.AutoSize = true;
            this.lblFechaEmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEmision.Location = new System.Drawing.Point(9, 129);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(71, 34);
            this.lblFechaEmision.TabIndex = 0;
            this.lblFechaEmision.Text = "Fecha de \r\nEmisión:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(358, 88);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(47, 17);
            this.lblStock.TabIndex = 0;
            this.lblStock.Text = "Stock:";
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.AutoSize = true;
            this.lblCostoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoTotal.Location = new System.Drawing.Point(358, 205);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(84, 17);
            this.lblCostoTotal.TabIndex = 0;
            this.lblCostoTotal.Text = "Costo Total:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(358, 146);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(101, 17);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "Costo Unitario:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(358, 39);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(73, 17);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(9, 86);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(69, 17);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Producto:";
            // 
            // dgvDatosInsumos
            // 
            this.dgvDatosInsumos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatosInsumos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDatosInsumos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            this.dgvDatosInsumos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosInsumos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatosInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosInsumos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Categoria,
            this.Producto,
            this.cantidad,
            this.FechaEmision,
            this.CUnitario,
            this.FechaVencimiento,
            this.CTotal,
            this.EstInsumo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosInsumos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatosInsumos.EnableHeadersVisualStyles = false;
            this.dgvDatosInsumos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.dgvDatosInsumos.Location = new System.Drawing.Point(15, 71);
            this.dgvDatosInsumos.Name = "dgvDatosInsumos";
            this.dgvDatosInsumos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosInsumos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatosInsumos.RowHeadersVisible = false;
            this.dgvDatosInsumos.RowHeadersWidth = 50;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDatosInsumos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatosInsumos.RowTemplate.Height = 24;
            this.dgvDatosInsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosInsumos.Size = new System.Drawing.Size(800, 300);
            this.dgvDatosInsumos.TabIndex = 0;
            this.dgvDatosInsumos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosInsumos_CellContentClick);
            this.dgvDatosInsumos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDatosInsumos_CellMouseDoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 75;
            // 
            // Categoria
            // 
            this.Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.Width = 92;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Producto.DataPropertyName = "Producto";
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.Width = 86;
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "Stock";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 65;
            // 
            // FechaEmision
            // 
            this.FechaEmision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FechaEmision.DataPropertyName = "FechaEmision";
            this.FechaEmision.HeaderText = "Fecha de Emisión ";
            this.FechaEmision.MinimumWidth = 6;
            this.FechaEmision.Name = "FechaEmision";
            this.FechaEmision.Width = 124;
            // 
            // CUnitario
            // 
            this.CUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CUnitario.DataPropertyName = "CUnitario";
            this.CUnitario.HeaderText = "Costo Unitario";
            this.CUnitario.MinimumWidth = 6;
            this.CUnitario.Name = "CUnitario";
            this.CUnitario.Width = 105;
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FechaVencimiento.DataPropertyName = "FechaVencimiento";
            this.FechaVencimiento.HeaderText = "Caducidad";
            this.FechaVencimiento.MinimumWidth = 6;
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.Width = 98;
            // 
            // CTotal
            // 
            this.CTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CTotal.DataPropertyName = "CTotal";
            this.CTotal.HeaderText = "Costo Total";
            this.CTotal.MinimumWidth = 6;
            this.CTotal.Name = "CTotal";
            this.CTotal.Width = 90;
            // 
            // EstInsumo
            // 
            this.EstInsumo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EstInsumo.DataPropertyName = "EstInsumo";
            this.EstInsumo.HeaderText = "Estado";
            this.EstInsumo.MinimumWidth = 6;
            this.EstInsumo.Name = "EstInsumo";
            this.EstInsumo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EstInsumo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EstInsumo.Width = 71;
            // 
            // FormMantenedorProducto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(1, 5);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(830, 775);
            this.Controls.Add(this.gbDatosInsumos);
            this.Controls.Add(this.bntSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.panelBuscar);
            this.Controls.Add(this.dgvDatosInsumos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMantenedorProducto";
            this.Text = "Mantenedor Insumos";
            this.Load += new System.EventHandler(this.FormMantenedorProducto_Load);
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            this.gbDatosInsumos.ResumeLayout(false);
            this.gbDatosInsumos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosInsumos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.GroupBox gbDatosInsumos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DateTimePicker dtpFVencimiento;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtCTotal;
        private System.Windows.Forms.TextBox txtCUnitario;
        private System.Windows.Forms.Label lblFechaEmision;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.DataGridView dgvDatosInsumos;
        private System.Windows.Forms.CheckBox ckbEstInsumo;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTotal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EstInsumo;
    }
}