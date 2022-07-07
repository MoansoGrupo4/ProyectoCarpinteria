namespace FormularioCarpinteria
{
    partial class FormOrdenEntrada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbPedido = new System.Windows.Forms.GroupBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbMadera = new System.Windows.Forms.GroupBox();
            this.cboMPrima = new System.Windows.Forms.ComboBox();
            this.txtMPrima = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbInsumos = new System.Windows.Forms.GroupBox();
            this.cboCodigoInsumos = new System.Windows.Forms.ComboBox();
            this.txtNombreInsumo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvDatosEmpleado = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dgvTablaMadera = new System.Windows.Forms.DataGridView();
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
            this.gbPedido.SuspendLayout();
            this.gbMadera.SuspendLayout();
            this.gbInsumos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaMadera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosInsumos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(146, 638);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(260, 40);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbPedido
            // 
            this.gbPedido.Controls.Add(this.txtCodigo);
            this.gbPedido.Controls.Add(this.dgvDatosEmpleado);
            this.gbPedido.Controls.Add(this.txtCliente);
            this.gbPedido.Controls.Add(this.label2);
            this.gbPedido.Controls.Add(this.label1);
            this.gbPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPedido.ForeColor = System.Drawing.Color.White;
            this.gbPedido.Location = new System.Drawing.Point(12, 12);
            this.gbPedido.Name = "gbPedido";
            this.gbPedido.Size = new System.Drawing.Size(800, 200);
            this.gbPedido.TabIndex = 8;
            this.gbPedido.TabStop = false;
            this.gbPedido.Text = "Pedido";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(111, 113);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(151, 23);
            this.txtCliente.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // gbMadera
            // 
            this.gbMadera.Controls.Add(this.dgvTablaMadera);
            this.gbMadera.Controls.Add(this.cboMPrima);
            this.gbMadera.Controls.Add(this.txtMPrima);
            this.gbMadera.Controls.Add(this.label3);
            this.gbMadera.Controls.Add(this.label4);
            this.gbMadera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMadera.ForeColor = System.Drawing.Color.White;
            this.gbMadera.Location = new System.Drawing.Point(12, 218);
            this.gbMadera.Name = "gbMadera";
            this.gbMadera.Size = new System.Drawing.Size(800, 200);
            this.gbMadera.TabIndex = 9;
            this.gbMadera.TabStop = false;
            this.gbMadera.Text = "Madera";
            // 
            // cboMPrima
            // 
            this.cboMPrima.FormattingEnabled = true;
            this.cboMPrima.Location = new System.Drawing.Point(111, 68);
            this.cboMPrima.Name = "cboMPrima";
            this.cboMPrima.Size = new System.Drawing.Size(151, 24);
            this.cboMPrima.TabIndex = 8;
            // 
            // txtMPrima
            // 
            this.txtMPrima.Location = new System.Drawing.Point(111, 122);
            this.txtMPrima.Name = "txtMPrima";
            this.txtMPrima.Size = new System.Drawing.Size(151, 23);
            this.txtMPrima.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Codigo:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(425, 638);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(260, 40);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbInsumos
            // 
            this.gbInsumos.Controls.Add(this.dgvDatosInsumos);
            this.gbInsumos.Controls.Add(this.cboCodigoInsumos);
            this.gbInsumos.Controls.Add(this.txtNombreInsumo);
            this.gbInsumos.Controls.Add(this.label5);
            this.gbInsumos.Controls.Add(this.label6);
            this.gbInsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInsumos.ForeColor = System.Drawing.Color.White;
            this.gbInsumos.Location = new System.Drawing.Point(12, 424);
            this.gbInsumos.Name = "gbInsumos";
            this.gbInsumos.Size = new System.Drawing.Size(800, 200);
            this.gbInsumos.TabIndex = 10;
            this.gbInsumos.TabStop = false;
            this.gbInsumos.Text = "Insumos";
            // 
            // cboCodigoInsumos
            // 
            this.cboCodigoInsumos.FormattingEnabled = true;
            this.cboCodigoInsumos.Location = new System.Drawing.Point(111, 65);
            this.cboCodigoInsumos.Name = "cboCodigoInsumos";
            this.cboCodigoInsumos.Size = new System.Drawing.Size(151, 24);
            this.cboCodigoInsumos.TabIndex = 8;
            // 
            // txtNombreInsumo
            // 
            this.txtNombreInsumo.Location = new System.Drawing.Point(111, 119);
            this.txtNombreInsumo.Name = "txtNombreInsumo";
            this.txtNombreInsumo.Size = new System.Drawing.Size(151, 23);
            this.txtNombreInsumo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Codigo:";
            // 
            // dgvDatosEmpleado
            // 
            this.dgvDatosEmpleado.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dgvDatosEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatosEmpleado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDatosEmpleado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            this.dgvDatosEmpleado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvDatosEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosEmpleado.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvDatosEmpleado.EnableHeadersVisualStyles = false;
            this.dgvDatosEmpleado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.dgvDatosEmpleado.Location = new System.Drawing.Point(284, 24);
            this.dgvDatosEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatosEmpleado.Name = "dgvDatosEmpleado";
            this.dgvDatosEmpleado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosEmpleado.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvDatosEmpleado.RowHeadersVisible = false;
            this.dgvDatosEmpleado.RowHeadersWidth = 51;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDatosEmpleado.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvDatosEmpleado.RowTemplate.Height = 24;
            this.dgvDatosEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosEmpleado.Size = new System.Drawing.Size(500, 160);
            this.dgvDatosEmpleado.TabIndex = 10;
            this.dgvDatosEmpleado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosEmpleado_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdEmpleado";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomEmpleado";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombres";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 88;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FuncionEmpleado";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cargo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 69;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DirEmpleado";
            this.Column4.HeaderText = "Dirección";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 90;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DNIEmpleado";
            this.Column5.HeaderText = "DNI";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 54;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "EdadEmpleado";
            this.Column6.HeaderText = "Edad";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 64;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "FechaEmpleado";
            this.Column7.HeaderText = "Inscricción";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 97;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Numero";
            this.Column8.HeaderText = "Teléfono";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 87;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "estEmpleado";
            this.Column9.HeaderText = "Estado";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 56;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(111, 59);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(151, 23);
            this.txtCodigo.TabIndex = 11;
            // 
            // dgvTablaMadera
            // 
            this.dgvTablaMadera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTablaMadera.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTablaMadera.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            this.dgvTablaMadera.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaMadera.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvTablaMadera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTablaMadera.DefaultCellStyle = dataGridViewCellStyle22;
            this.dgvTablaMadera.EnableHeadersVisualStyles = false;
            this.dgvTablaMadera.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.dgvTablaMadera.Location = new System.Drawing.Point(284, 24);
            this.dgvTablaMadera.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTablaMadera.Name = "dgvTablaMadera";
            this.dgvTablaMadera.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaMadera.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvTablaMadera.RowHeadersVisible = false;
            this.dgvTablaMadera.RowHeadersWidth = 51;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTablaMadera.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvTablaMadera.RowTemplate.Height = 24;
            this.dgvTablaMadera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTablaMadera.Size = new System.Drawing.Size(500, 160);
            this.dgvTablaMadera.TabIndex = 9;
            this.dgvTablaMadera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTablaMadera_CellContentClick);
            // 
            // dgvDatosInsumos
            // 
            this.dgvDatosInsumos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatosInsumos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDatosInsumos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            this.dgvDatosInsumos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosInsumos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
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
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosInsumos.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvDatosInsumos.EnableHeadersVisualStyles = false;
            this.dgvDatosInsumos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.dgvDatosInsumos.Location = new System.Drawing.Point(284, 30);
            this.dgvDatosInsumos.Name = "dgvDatosInsumos";
            this.dgvDatosInsumos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosInsumos.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvDatosInsumos.RowHeadersVisible = false;
            this.dgvDatosInsumos.RowHeadersWidth = 50;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDatosInsumos.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvDatosInsumos.RowTemplate.Height = 24;
            this.dgvDatosInsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosInsumos.Size = new System.Drawing.Size(500, 150);
            this.dgvDatosInsumos.TabIndex = 9;
            this.dgvDatosInsumos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosInsumos_CellContentClick);
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
            this.Producto.Width = 88;
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "Stock";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 66;
            // 
            // FechaEmision
            // 
            this.FechaEmision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FechaEmision.DataPropertyName = "FechaEmision";
            this.FechaEmision.HeaderText = "Fecha de Emisión ";
            this.FechaEmision.MinimumWidth = 6;
            this.FechaEmision.Name = "FechaEmision";
            this.FechaEmision.Width = 134;
            // 
            // CUnitario
            // 
            this.CUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CUnitario.DataPropertyName = "CUnitario";
            this.CUnitario.HeaderText = "Costo Unitario";
            this.CUnitario.MinimumWidth = 6;
            this.CUnitario.Name = "CUnitario";
            this.CUnitario.Width = 110;
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
            this.CTotal.Width = 95;
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
            this.EstInsumo.Width = 75;
            // 
            // FormOrdenEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(830, 690);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbPedido);
            this.Controls.Add(this.gbMadera);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbInsumos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOrdenEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOrdenEntrada";
            this.gbPedido.ResumeLayout(false);
            this.gbPedido.PerformLayout();
            this.gbMadera.ResumeLayout(false);
            this.gbMadera.PerformLayout();
            this.gbInsumos.ResumeLayout(false);
            this.gbInsumos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaMadera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosInsumos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbMadera;
        private System.Windows.Forms.ComboBox cboMPrima;
        private System.Windows.Forms.TextBox txtMPrima;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbInsumos;
        private System.Windows.Forms.ComboBox cboCodigoInsumos;
        private System.Windows.Forms.TextBox txtNombreInsumo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DataGridView dgvDatosEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column9;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView dgvTablaMadera;
        private System.Windows.Forms.DataGridView dgvDatosInsumos;
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