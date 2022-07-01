using System;

namespace FormularioCarpinteria
{
    partial class FormMantenedorEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMantenedorEmpleado));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbDatosUsuario = new System.Windows.Forms.GroupBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbkEstadoEmpleado = new System.Windows.Forms.CheckBox();
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblListaEmpleados = new System.Windows.Forms.Label();
            this.dgvDatosEmpleado = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbDatosUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEmpleado)).BeginInit();
            this.SuspendLayout();
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
            resources.ApplyResources(this.gbDatosUsuario, "gbDatosUsuario");
            this.gbDatosUsuario.ForeColor = System.Drawing.Color.White;
            this.gbDatosUsuario.Name = "gbDatosUsuario";
            this.gbDatosUsuario.TabStop = false;
            this.gbDatosUsuario.Enter += new System.EventHandler(this.gbDatosUsuario_Enter);
            // 
            // txtEdad
            // 
            resources.ApplyResources(this.txtEdad, "txtEdad");
            this.txtEdad.Name = "txtEdad";
            // 
            // txtDireccion
            // 
            resources.ApplyResources(this.txtDireccion, "txtDireccion");
            this.txtDireccion.Name = "txtDireccion";
            // 
            // txtDNI
            // 
            resources.ApplyResources(this.txtDNI, "txtDNI");
            this.txtDNI.Name = "txtDNI";
            // 
            // txtUsuario
            // 
            resources.ApplyResources(this.txtUsuario, "txtUsuario");
            this.txtUsuario.Name = "txtUsuario";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            resources.ApplyResources(this.btnModificar, "btnModificar");
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            resources.ApplyResources(this.btnAgregar, "btnAgregar");
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbkEstadoEmpleado
            // 
            resources.ApplyResources(this.cbkEstadoEmpleado, "cbkEstadoEmpleado");
            this.cbkEstadoEmpleado.Name = "cbkEstadoEmpleado";
            this.cbkEstadoEmpleado.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormularioCarpinteria.Properties.Resources._1;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // dtpFechaIngreso
            // 
            resources.ApplyResources(this.dtpFechaIngreso, "dtpFechaIngreso");
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.ValueChanged += new System.EventHandler(this.dtpFechaIngreso_ValueChanged);
            // 
            // txtFuncion
            // 
            resources.ApplyResources(this.txtFuncion, "txtFuncion");
            this.txtFuncion.Name = "txtFuncion";
            // 
            // lblFecha
            // 
            resources.ApplyResources(this.lblFecha, "lblFecha");
            this.lblFecha.Name = "lblFecha";
            // 
            // lblEdad
            // 
            resources.ApplyResources(this.lblEdad, "lblEdad");
            this.lblEdad.Name = "lblEdad";
            // 
            // txtNombre
            // 
            resources.ApplyResources(this.txtNombre, "txtNombre");
            this.txtNombre.Name = "txtNombre";
            // 
            // lblDNI
            // 
            resources.ApplyResources(this.lblDNI, "lblDNI");
            this.lblDNI.Name = "lblDNI";
            // 
            // txtNumero
            // 
            resources.ApplyResources(this.txtNumero, "txtNumero");
            this.txtNumero.Name = "txtNumero";
            // 
            // lblDir
            // 
            resources.ApplyResources(this.lblDir, "lblDir");
            this.lblDir.Name = "lblDir";
            // 
            // lblFuncion
            // 
            resources.ApplyResources(this.lblFuncion, "lblFuncion");
            this.lblFuncion.Name = "lblFuncion";
            // 
            // lblNumero
            // 
            resources.ApplyResources(this.lblNumero, "lblNumero");
            this.lblNumero.Name = "lblNumero";
            // 
            // lblNombre
            // 
            resources.ApplyResources(this.lblNombre, "lblNombre");
            this.lblNombre.Name = "lblNombre";
            // 
            // lblUsuario
            // 
            resources.ApplyResources(this.lblUsuario, "lblUsuario");
            this.lblUsuario.Name = "lblUsuario";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            resources.ApplyResources(this.btnNuevo, "btnNuevo");
            this.btnNuevo.ForeColor = System.Drawing.Color.Snow;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            resources.ApplyResources(this.btnSalir, "btnSalir");
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            resources.ApplyResources(this.btnDeshabilitar, "btnDeshabilitar");
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = false;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            resources.ApplyResources(this.btnEditar, "btnEditar");
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lbNombre
            // 
            resources.ApplyResources(this.lbNombre, "lbNombre");
            this.lbNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNombre.Name = "lbNombre";
            // 
            // txtBuscar
            // 
            resources.ApplyResources(this.txtBuscar, "txtBuscar");
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblListaEmpleados
            // 
            resources.ApplyResources(this.lblListaEmpleados, "lblListaEmpleados");
            this.lblListaEmpleados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblListaEmpleados.Name = "lblListaEmpleados";
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
            resources.ApplyResources(this.dgvDatosEmpleado, "dgvDatosEmpleado");
            this.dgvDatosEmpleado.Name = "dgvDatosEmpleado";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosEmpleado.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatosEmpleado.RowTemplate.Height = 24;
            this.dgvDatosEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosEmpleado_CellContentClick);
            this.dgvDatosEmpleado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosEmpleado_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdEmpleado";
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NomEmpleado";
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "FuncionEmpleado";
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DirEmpleado";
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DNIEmpleado";
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "EdadEmpleado";
            resources.ApplyResources(this.Column6, "Column6");
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "FechaEmpleado";
            resources.ApplyResources(this.Column7, "Column7");
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Numero";
            resources.ApplyResources(this.Column8, "Column8");
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "estEmpleado";
            resources.ApplyResources(this.Column9, "Column9");
            this.Column9.Name = "Column9";
            // 
            // FormMantenedorEmpleado
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblListaEmpleados);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbDatosUsuario);
            this.Controls.Add(this.dgvDatosEmpleado);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMantenedorEmpleado";
            this.Load += new System.EventHandler(this.FormMantenedorUsuario_Load);
            this.gbDatosUsuario.ResumeLayout(false);
            this.gbDatosUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbDatosUsuario;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbkEstadoEmpleado;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblListaEmpleados;
        private System.Windows.Forms.DataGridView dgvDatosEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column9;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtDNI;
    }
}