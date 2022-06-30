namespace FormularioCarpinteria
{
    partial class FormTransaccionPedido
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.Button();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbkEstadoEmpleado = new System.Windows.Forms.CheckBox();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDatosUsuario = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblFuncion = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblListaEmpleados = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvDatosEmpleado = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbDatosUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtBuscar.Location = new System.Drawing.Point(106, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(972, 27);
            this.txtBuscar.TabIndex = 24;
            this.txtBuscar.Text = " ";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DirEmpleado";
            this.Column4.HeaderText = "Dirección";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnNuevo.ForeColor = System.Drawing.Color.Snow;
            this.btnNuevo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNuevo.Location = new System.Drawing.Point(25, 378);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(254, 55);
            this.btnNuevo.TabIndex = 19;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(489, 141);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(299, 24);
            this.txtEdad.TabIndex = 13;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "EdadEmpleado";
            this.Column6.HeaderText = "Edad";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(119, 187);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(268, 24);
            this.txtDNI.TabIndex = 11;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "FechaEmpleado";
            this.Column7.HeaderText = "Inscricción";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(119, 235);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(669, 24);
            this.txtDireccion.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdEmpleado";
            this.Column1.HeaderText = "Codigo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Width = 125;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtUsuario.Location = new System.Drawing.Point(119, 33);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(212, 27);
            this.txtUsuario.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnAgregar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAgregar.Location = new System.Drawing.Point(22, 269);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(246, 50);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NomEmpleado";
            this.Column2.HeaderText = "Nombres";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnEditar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditar.Location = new System.Drawing.Point(277, 378);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(256, 55);
            this.btnEditar.TabIndex = 20;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DNIEmpleado";
            this.Column5.HeaderText = "DNI";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnModificar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModificar.Location = new System.Drawing.Point(281, 269);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(246, 50);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelar.Location = new System.Drawing.Point(542, 269);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(246, 50);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // cbkEstadoEmpleado
            // 
            this.cbkEstadoEmpleado.AutoSize = true;
            this.cbkEstadoEmpleado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbkEstadoEmpleado.Location = new System.Drawing.Point(632, 34);
            this.cbkEstadoEmpleado.Name = "cbkEstadoEmpleado";
            this.cbkEstadoEmpleado.Size = new System.Drawing.Size(156, 22);
            this.cbkEstadoEmpleado.TabIndex = 3;
            this.cbkEstadoEmpleado.Text = "Estado del Usuario";
            this.cbkEstadoEmpleado.UseVisualStyleBackColor = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "FuncionEmpleado";
            this.Column3.HeaderText = "Cargo";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // gbDatosUsuario
            // 
            this.gbDatosUsuario.Controls.Add(this.txtEdad);
            this.gbDatosUsuario.Controls.Add(this.txtDireccion);
            this.gbDatosUsuario.Controls.Add(this.txtDNI);
            this.gbDatosUsuario.Controls.Add(this.txtUsuario);
            this.gbDatosUsuario.Controls.Add(this.btnModificar);
            this.gbDatosUsuario.Controls.Add(this.btnCancelar);
            this.gbDatosUsuario.Controls.Add(this.btnAgregar);
            this.gbDatosUsuario.Controls.Add(this.cbkEstadoEmpleado);
            this.gbDatosUsuario.Controls.Add(this.pictureBox1);
            this.gbDatosUsuario.Controls.Add(this.dtpFechaIngreso);
            this.gbDatosUsuario.Controls.Add(this.txtFuncion);
            this.gbDatosUsuario.Controls.Add(this.lblFecha);
            this.gbDatosUsuario.Controls.Add(this.lblEdad);
            this.gbDatosUsuario.Controls.Add(this.txtNombre);
            this.gbDatosUsuario.Controls.Add(this.lblDNI);
            this.gbDatosUsuario.Controls.Add(this.txtNumero);
            this.gbDatosUsuario.Controls.Add(this.lblDir);
            this.gbDatosUsuario.Controls.Add(this.lblFuncion);
            this.gbDatosUsuario.Controls.Add(this.lblNumero);
            this.gbDatosUsuario.Controls.Add(this.lblNombre);
            this.gbDatosUsuario.Controls.Add(this.lblUsuario);
            this.gbDatosUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gbDatosUsuario.ForeColor = System.Drawing.Color.White;
            this.gbDatosUsuario.Location = new System.Drawing.Point(25, 433);
            this.gbDatosUsuario.Name = "gbDatosUsuario";
            this.gbDatosUsuario.Size = new System.Drawing.Size(1053, 339);
            this.gbDatosUsuario.TabIndex = 23;
            this.gbDatosUsuario.TabStop = false;
            this.gbDatosUsuario.Text = "Datos del Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormularioCarpinteria.Properties.Resources._1;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(1241, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 463);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(489, 187);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(299, 24);
            this.dtpFechaIngreso.TabIndex = 8;
            // 
            // txtFuncion
            // 
            this.txtFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtFuncion.Location = new System.Drawing.Point(119, 136);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(268, 27);
            this.txtFuncion.TabIndex = 5;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecha.Location = new System.Drawing.Point(404, 187);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(69, 20);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Ingreso:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblEdad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEdad.Location = new System.Drawing.Point(404, 139);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(52, 20);
            this.lblEdad.TabIndex = 0;
            this.lblEdad.Text = "Edad:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtNombre.Location = new System.Drawing.Point(119, 84);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(669, 27);
            this.txtNombre.TabIndex = 4;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblDNI.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDNI.Location = new System.Drawing.Point(22, 191);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(43, 20);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI:";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtNumero.Location = new System.Drawing.Point(426, 33);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(175, 27);
            this.txtNumero.TabIndex = 2;
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblDir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDir.Location = new System.Drawing.Point(22, 239);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(86, 20);
            this.lblDir.TabIndex = 0;
            this.lblDir.Text = "Dirección:";
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblFuncion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFuncion.Location = new System.Drawing.Point(22, 139);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(73, 20);
            this.lblFuncion.TabIndex = 0;
            this.lblFuncion.Text = "Función:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblNumero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNumero.Location = new System.Drawing.Point(342, 37);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(78, 20);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Telefono:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNombre.Location = new System.Drawing.Point(22, 87);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUsuario.Location = new System.Drawing.Point(22, 37);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(72, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblListaEmpleados
            // 
            this.lblListaEmpleados.AutoSize = true;
            this.lblListaEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblListaEmpleados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblListaEmpleados.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblListaEmpleados.Location = new System.Drawing.Point(16, 39);
            this.lblListaEmpleados.Name = "lblListaEmpleados";
            this.lblListaEmpleados.Size = new System.Drawing.Size(167, 22);
            this.lblListaEmpleados.TabIndex = 17;
            this.lblListaEmpleados.Text = "Lista de Empleados";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbNombre.Location = new System.Drawing.Point(17, 5);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(78, 22);
            this.lbNombre.TabIndex = 18;
            this.lbNombre.Text = "Nombre:";
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.btnDeshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnDeshabilitar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeshabilitar.Location = new System.Drawing.Point(532, 378);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(269, 55);
            this.btnDeshabilitar.TabIndex = 21;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalir.Location = new System.Drawing.Point(801, 378);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(276, 55);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // dgvDatosEmpleado
            // 
            this.dgvDatosEmpleado.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dgvDatosEmpleado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.dgvDatosEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosEmpleado.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatosEmpleado.Location = new System.Drawing.Point(23, 80);
            this.dgvDatosEmpleado.Name = "dgvDatosEmpleado";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosEmpleado.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatosEmpleado.RowHeadersWidth = 51;
            this.dgvDatosEmpleado.RowTemplate.Height = 24;
            this.dgvDatosEmpleado.Size = new System.Drawing.Size(1053, 291);
            this.dgvDatosEmpleado.TabIndex = 16;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Numero";
            this.Column8.HeaderText = "Teléfono";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "estEmpleado";
            this.Column9.HeaderText = "Estado";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // FormTransaccionPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1099, 810);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gbDatosUsuario);
            this.Controls.Add(this.lblListaEmpleados);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvDatosEmpleado);
            this.Name = "FormTransaccionPedido";
            this.Text = "FormTransaccionPedido";
            this.gbDatosUsuario.ResumeLayout(false);
            this.gbDatosUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox cbkEstadoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox gbDatosUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblListaEmpleados;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvDatosEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column9;
    }
}