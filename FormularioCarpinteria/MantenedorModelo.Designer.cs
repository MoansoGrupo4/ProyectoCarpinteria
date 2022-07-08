namespace FormularioCarpinteria
{
    partial class MantenedorModelo
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
            this.bntSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.panelbuscar = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.gbMadera = new System.Windows.Forms.GroupBox();
            this.cmbTipoMueble = new System.Windows.Forms.ComboBox();
            this.cmbTipoMadera = new System.Windows.Forms.ComboBox();
            this.ckbEstado = new System.Windows.Forms.CheckBox();
            this.pbTronco = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtPrecioVentaPM = new System.Windows.Forms.TextBox();
            this.txtPrecioVentaPU = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCostoUni = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltipo = new System.Windows.Forms.Label();
            this.dgvDatosModelo = new System.Windows.Forms.DataGridView();
            this.CodModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodTipoMadera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVentaPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVentaPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodTipoMueble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelbuscar.SuspendLayout();
            this.gbMadera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTronco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosModelo)).BeginInit();
            this.SuspendLayout();
            // 
            // bntSalir
            // 
            this.bntSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.bntSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSalir.ForeColor = System.Drawing.Color.Snow;
            this.bntSalir.Location = new System.Drawing.Point(607, 334);
            this.bntSalir.Margin = new System.Windows.Forms.Padding(2);
            this.bntSalir.Name = "bntSalir";
            this.bntSalir.Size = new System.Drawing.Size(203, 44);
            this.bntSalir.TabIndex = 7;
            this.bntSalir.Text = "Salir";
            this.bntSalir.UseVisualStyleBackColor = false;
            this.bntSalir.Click += new System.EventHandler(this.bntSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.Snow;
            this.btnNuevo.Location = new System.Drawing.Point(21, 334);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(203, 44);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Snow;
            this.btnEditar.Location = new System.Drawing.Point(218, 334);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(203, 44);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.btnDeshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitar.ForeColor = System.Drawing.Color.Snow;
            this.btnDeshabilitar.Location = new System.Drawing.Point(412, 334);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(203, 44);
            this.btnDeshabilitar.TabIndex = 10;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = false;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // panelbuscar
            // 
            this.panelbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.panelbuscar.Controls.Add(this.txtBuscar);
            this.panelbuscar.Controls.Add(this.lbNombre);
            this.panelbuscar.Controls.Add(this.lbBuscar);
            this.panelbuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelbuscar.Location = new System.Drawing.Point(0, 0);
            this.panelbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.panelbuscar.Name = "panelbuscar";
            this.panelbuscar.Size = new System.Drawing.Size(830, 50);
            this.panelbuscar.TabIndex = 6;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(80, 23);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(731, 23);
            this.txtBuscar.TabIndex = 2;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNombre.Location = new System.Drawing.Point(17, 23);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(66, 18);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbBuscar.Location = new System.Drawing.Point(19, 7);
            this.lbBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(40, 13);
            this.lbBuscar.TabIndex = 0;
            this.lbBuscar.Text = "Buscar";
            // 
            // gbMadera
            // 
            this.gbMadera.Controls.Add(this.cmbTipoMueble);
            this.gbMadera.Controls.Add(this.cmbTipoMadera);
            this.gbMadera.Controls.Add(this.ckbEstado);
            this.gbMadera.Controls.Add(this.pbTronco);
            this.gbMadera.Controls.Add(this.btnCancelar);
            this.gbMadera.Controls.Add(this.btnModificar);
            this.gbMadera.Controls.Add(this.btnAgregar);
            this.gbMadera.Controls.Add(this.txtPrecioVentaPM);
            this.gbMadera.Controls.Add(this.txtPrecioVentaPU);
            this.gbMadera.Controls.Add(this.txtColor);
            this.gbMadera.Controls.Add(this.lblUnidad);
            this.gbMadera.Controls.Add(this.label1);
            this.gbMadera.Controls.Add(this.txtCodigo);
            this.gbMadera.Controls.Add(this.lblCostoUni);
            this.gbMadera.Controls.Add(this.txtDescripcion);
            this.gbMadera.Controls.Add(this.lblColor);
            this.gbMadera.Controls.Add(this.lblCodigo);
            this.gbMadera.Controls.Add(this.label2);
            this.gbMadera.Controls.Add(this.lbltipo);
            this.gbMadera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMadera.ForeColor = System.Drawing.Color.White;
            this.gbMadera.Location = new System.Drawing.Point(21, 378);
            this.gbMadera.Margin = new System.Windows.Forms.Padding(2);
            this.gbMadera.Name = "gbMadera";
            this.gbMadera.Padding = new System.Windows.Forms.Padding(2);
            this.gbMadera.Size = new System.Drawing.Size(790, 275);
            this.gbMadera.TabIndex = 5;
            this.gbMadera.TabStop = false;
            this.gbMadera.Text = "Datos Modelo";
            // 
            // cmbTipoMueble
            // 
            this.cmbTipoMueble.FormattingEnabled = true;
            this.cmbTipoMueble.Location = new System.Drawing.Point(436, 160);
            this.cmbTipoMueble.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoMueble.Name = "cmbTipoMueble";
            this.cmbTipoMueble.Size = new System.Drawing.Size(154, 23);
            this.cmbTipoMueble.TabIndex = 7;
            // 
            // cmbTipoMadera
            // 
            this.cmbTipoMadera.FormattingEnabled = true;
            this.cmbTipoMadera.Location = new System.Drawing.Point(110, 120);
            this.cmbTipoMadera.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoMadera.Name = "cmbTipoMadera";
            this.cmbTipoMadera.Size = new System.Drawing.Size(216, 23);
            this.cmbTipoMadera.TabIndex = 6;
            // 
            // ckbEstado
            // 
            this.ckbEstado.AutoSize = true;
            this.ckbEstado.Location = new System.Drawing.Point(597, 24);
            this.ckbEstado.Margin = new System.Windows.Forms.Padding(2);
            this.ckbEstado.Name = "ckbEstado";
            this.ckbEstado.Size = new System.Drawing.Size(129, 19);
            this.ckbEstado.TabIndex = 5;
            this.ckbEstado.Text = "Estado del modelo";
            this.ckbEstado.UseVisualStyleBackColor = true;
            // 
            // pbTronco
            // 
            this.pbTronco.Image = global::FormularioCarpinteria.Properties.Resources.mesa;
            this.pbTronco.Location = new System.Drawing.Point(597, 62);
            this.pbTronco.Margin = new System.Windows.Forms.Padding(2);
            this.pbTronco.Name = "pbTronco";
            this.pbTronco.Size = new System.Drawing.Size(188, 197);
            this.pbTronco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTronco.TabIndex = 4;
            this.pbTronco.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Snow;
            this.btnCancelar.Location = new System.Drawing.Point(406, 218);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(184, 41);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Snow;
            this.btnModificar.Location = new System.Drawing.Point(208, 218);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(184, 41);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Snow;
            this.btnAgregar.Location = new System.Drawing.Point(10, 218);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(184, 41);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtPrecioVentaPM
            // 
            this.txtPrecioVentaPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVentaPM.Location = new System.Drawing.Point(490, 119);
            this.txtPrecioVentaPM.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioVentaPM.Name = "txtPrecioVentaPM";
            this.txtPrecioVentaPM.Size = new System.Drawing.Size(71, 23);
            this.txtPrecioVentaPM.TabIndex = 1;
            // 
            // txtPrecioVentaPU
            // 
            this.txtPrecioVentaPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVentaPU.Location = new System.Drawing.Point(490, 41);
            this.txtPrecioVentaPU.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioVentaPU.Name = "txtPrecioVentaPU";
            this.txtPrecioVentaPU.Size = new System.Drawing.Size(71, 23);
            this.txtPrecioVentaPU.TabIndex = 1;
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(110, 159);
            this.txtColor.Margin = new System.Windows.Forms.Padding(2);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(216, 23);
            this.txtColor.TabIndex = 1;
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.Location = new System.Drawing.Point(346, 162);
            this.lblUnidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(90, 17);
            this.lblUnidad.TabIndex = 0;
            this.lblUnidad.Text = "Tipo Mueble:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Precio Venta P/M:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(110, 42);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(142, 23);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCostoUni
            // 
            this.lblCostoUni.AutoSize = true;
            this.lblCostoUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoUni.Location = new System.Drawing.Point(346, 44);
            this.lblCostoUni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCostoUni.Name = "lblCostoUni";
            this.lblCostoUni.Size = new System.Drawing.Size(140, 17);
            this.lblCostoUni.TabIndex = 0;
            this.lblCostoUni.Text = "Precio de Venta P/U:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(110, 81);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(480, 23);
            this.txtDescripcion.TabIndex = 1;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(17, 162);
            this.lblColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(45, 17);
            this.lblColor.TabIndex = 0;
            this.lblColor.Text = "Color:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(13, 45);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 17);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descricción:";
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.Location = new System.Drawing.Point(14, 122);
            this.lbltipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(92, 17);
            this.lbltipo.TabIndex = 0;
            this.lbltipo.Text = "Tipo Madera:";
            // 
            // dgvDatosModelo
            // 
            this.dgvDatosModelo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            this.dgvDatosModelo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosModelo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatosModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosModelo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodModelo,
            this.DesModelo,
            this.CodTipoMadera,
            this.ColorModelo,
            this.PrecioVentaPU,
            this.PrecioVentaPM,
            this.CodTipoMueble,
            this.EstadoModelo});
            this.dgvDatosModelo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.dgvDatosModelo.Location = new System.Drawing.Point(21, 56);
            this.dgvDatosModelo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatosModelo.Name = "dgvDatosModelo";
            this.dgvDatosModelo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosModelo.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatosModelo.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.dgvDatosModelo.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatosModelo.RowTemplate.Height = 24;
            this.dgvDatosModelo.Size = new System.Drawing.Size(790, 269);
            this.dgvDatosModelo.TabIndex = 4;
            // 
            // CodModelo
            // 
            this.CodModelo.DataPropertyName = "CodModelo";
            this.CodModelo.HeaderText = "Código";
            this.CodModelo.MinimumWidth = 6;
            this.CodModelo.Name = "CodModelo";
            this.CodModelo.Width = 125;
            // 
            // DesModelo
            // 
            this.DesModelo.DataPropertyName = "DesModelo";
            this.DesModelo.HeaderText = "Descripción";
            this.DesModelo.MinimumWidth = 6;
            this.DesModelo.Name = "DesModelo";
            this.DesModelo.Width = 125;
            // 
            // CodTipoMadera
            // 
            this.CodTipoMadera.DataPropertyName = "CodTipoMadera";
            this.CodTipoMadera.HeaderText = "Tipo";
            this.CodTipoMadera.MinimumWidth = 6;
            this.CodTipoMadera.Name = "CodTipoMadera";
            this.CodTipoMadera.Width = 125;
            // 
            // ColorModelo
            // 
            this.ColorModelo.DataPropertyName = "ColorModelo";
            this.ColorModelo.HeaderText = "Color";
            this.ColorModelo.MinimumWidth = 6;
            this.ColorModelo.Name = "ColorModelo";
            this.ColorModelo.Width = 125;
            // 
            // PrecioVentaPU
            // 
            this.PrecioVentaPU.DataPropertyName = "PrecioVentaPU";
            this.PrecioVentaPU.HeaderText = "Precio";
            this.PrecioVentaPU.MinimumWidth = 6;
            this.PrecioVentaPU.Name = "PrecioVentaPU";
            this.PrecioVentaPU.Width = 125;
            // 
            // PrecioVentaPM
            // 
            this.PrecioVentaPM.DataPropertyName = "PrecioVentaPM";
            this.PrecioVentaPM.HeaderText = "Precio por Mayor";
            this.PrecioVentaPM.MinimumWidth = 6;
            this.PrecioVentaPM.Name = "PrecioVentaPM";
            this.PrecioVentaPM.Width = 125;
            // 
            // CodTipoMueble
            // 
            this.CodTipoMueble.DataPropertyName = "CodTipoMueble";
            this.CodTipoMueble.HeaderText = "Mueble";
            this.CodTipoMueble.MinimumWidth = 6;
            this.CodTipoMueble.Name = "CodTipoMueble";
            this.CodTipoMueble.Width = 125;
            // 
            // EstadoModelo
            // 
            this.EstadoModelo.DataPropertyName = "EstadoModelo";
            this.EstadoModelo.HeaderText = "Estado";
            this.EstadoModelo.MinimumWidth = 6;
            this.EstadoModelo.Name = "EstadoModelo";
            this.EstadoModelo.Width = 125;
            // 
            // MantenedorModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(830, 670);
            this.Controls.Add(this.bntSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.panelbuscar);
            this.Controls.Add(this.gbMadera);
            this.Controls.Add(this.dgvDatosModelo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MantenedorModelo";
            this.Text = "MantenedorModelo";
            this.Load += new System.EventHandler(this.MantenedorModelo_Load);
            this.panelbuscar.ResumeLayout(false);
            this.panelbuscar.PerformLayout();
            this.gbMadera.ResumeLayout(false);
            this.gbMadera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTronco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosModelo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Panel panelbuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.GroupBox gbMadera;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.DataGridView dgvDatosModelo;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtPrecioVentaPU;
        private System.Windows.Forms.Label lblCostoUni;
        private System.Windows.Forms.PictureBox pbTronco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecioVentaPM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbEstado;
        private System.Windows.Forms.ComboBox cmbTipoMueble;
        private System.Windows.Forms.ComboBox cmbTipoMadera;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodTipoMadera;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVentaPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVentaPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodTipoMueble;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoModelo;
    }
}