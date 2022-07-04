namespace FormularioCarpinteria
{
    partial class FormTransaccionOP
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
            this.gbPedido = new System.Windows.Forms.GroupBox();
            this.txtNomPedido = new System.Windows.Forms.TextBox();
            this.TxtRSocial = new System.Windows.Forms.TextBox();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.lblRs = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.gbOP = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TxtCodPedido = new System.Windows.Forms.TextBox();
            this.txtCodModelo = new System.Windows.Forms.TextBox();
            this.lblIdModelo = new System.Windows.Forms.Label();
            this.CodCliente = new System.Windows.Forms.TextBox();
            this.txtCodProduccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIDPedido = new System.Windows.Forms.Label();
            this.lblOP = new System.Windows.Forms.Label();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.Quitar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbPedido.SuspendLayout();
            this.gbOP.SuspendLayout();
            this.gbBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPedido
            // 
            this.gbPedido.Controls.Add(this.txtNomPedido);
            this.gbPedido.Controls.Add(this.TxtRSocial);
            this.gbPedido.Controls.Add(this.btnBuscar);
            this.gbPedido.Controls.Add(this.txtBuscarCliente);
            this.gbPedido.Controls.Add(this.lblRs);
            this.gbPedido.Controls.Add(this.lblPedido);
            this.gbPedido.Controls.Add(this.lblCliente);
            this.gbPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPedido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbPedido.Location = new System.Drawing.Point(12, 12);
            this.gbPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPedido.Name = "gbPedido";
            this.gbPedido.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPedido.Size = new System.Drawing.Size(1009, 180);
            this.gbPedido.TabIndex = 0;
            this.gbPedido.TabStop = false;
            this.gbPedido.Text = "Pedido";
            // 
            // txtNomPedido
            // 
            this.txtNomPedido.Location = new System.Drawing.Point(125, 111);
            this.txtNomPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomPedido.Name = "txtNomPedido";
            this.txtNomPedido.Size = new System.Drawing.Size(289, 28);
            this.txtNomPedido.TabIndex = 2;
            // 
            // TxtRSocial
            // 
            this.TxtRSocial.Location = new System.Drawing.Point(579, 39);
            this.TxtRSocial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtRSocial.Name = "TxtRSocial";
            this.TxtRSocial.Size = new System.Drawing.Size(400, 28);
            this.TxtRSocial.TabIndex = 1;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(148, 42);
            this.txtBuscarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(183, 28);
            this.txtBuscarCliente.TabIndex = 1;
            // 
            // lblRs
            // 
            this.lblRs.AutoSize = true;
            this.lblRs.Location = new System.Drawing.Point(452, 42);
            this.lblRs.Name = "lblRs";
            this.lblRs.Size = new System.Drawing.Size(120, 22);
            this.lblRs.TabIndex = 0;
            this.lblRs.Text = "Razón Social:";
            this.lblRs.Click += new System.EventHandler(this.lblCliente_Click);
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(5, 111);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(71, 22);
            this.lblPedido.TabIndex = 0;
            this.lblPedido.Text = "Pedido:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(5, 46);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(71, 22);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            this.lblCliente.Click += new System.EventHandler(this.lblCliente_Click);
            // 
            // gbOP
            // 
            this.gbOP.Controls.Add(this.dateTimePicker1);
            this.gbOP.Controls.Add(this.TxtCodPedido);
            this.gbOP.Controls.Add(this.txtCodModelo);
            this.gbOP.Controls.Add(this.lblIdModelo);
            this.gbOP.Controls.Add(this.CodCliente);
            this.gbOP.Controls.Add(this.txtCodProduccion);
            this.gbOP.Controls.Add(this.label4);
            this.gbOP.Controls.Add(this.label3);
            this.gbOP.Controls.Add(this.lblIDPedido);
            this.gbOP.Controls.Add(this.lblOP);
            this.gbOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbOP.Location = new System.Drawing.Point(12, 209);
            this.gbOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOP.Name = "gbOP";
            this.gbOP.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOP.Size = new System.Drawing.Size(1009, 226);
            this.gbOP.TabIndex = 0;
            this.gbOP.TabStop = false;
            this.gbOP.Text = "Órden de Producción";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(195, 167);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(396, 28);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // TxtCodPedido
            // 
            this.TxtCodPedido.Location = new System.Drawing.Point(195, 111);
            this.TxtCodPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCodPedido.Name = "TxtCodPedido";
            this.TxtCodPedido.ReadOnly = true;
            this.TxtCodPedido.Size = new System.Drawing.Size(135, 28);
            this.TxtCodPedido.TabIndex = 2;
            // 
            // txtCodModelo
            // 
            this.txtCodModelo.Location = new System.Drawing.Point(727, 111);
            this.txtCodModelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodModelo.Name = "txtCodModelo";
            this.txtCodModelo.ReadOnly = true;
            this.txtCodModelo.Size = new System.Drawing.Size(137, 28);
            this.txtCodModelo.TabIndex = 1;
            // 
            // lblIdModelo
            // 
            this.lblIdModelo.AutoSize = true;
            this.lblIdModelo.Location = new System.Drawing.Point(619, 111);
            this.lblIdModelo.Name = "lblIdModelo";
            this.lblIdModelo.Size = new System.Drawing.Size(90, 22);
            this.lblIdModelo.TabIndex = 0;
            this.lblIdModelo.Text = "ID Modelo";
            this.lblIdModelo.Click += new System.EventHandler(this.lblCliente_Click);
            // 
            // CodCliente
            // 
            this.CodCliente.Location = new System.Drawing.Point(727, 39);
            this.CodCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CodCliente.Name = "CodCliente";
            this.CodCliente.ReadOnly = true;
            this.CodCliente.Size = new System.Drawing.Size(135, 28);
            this.CodCliente.TabIndex = 1;
            // 
            // txtCodProduccion
            // 
            this.txtCodProduccion.Location = new System.Drawing.Point(195, 46);
            this.txtCodProduccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodProduccion.Name = "txtCodProduccion";
            this.txtCodProduccion.Size = new System.Drawing.Size(135, 28);
            this.txtCodProduccion.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(616, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID Cliente:";
            this.label4.Click += new System.EventHandler(this.lblCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha de Inicio:";
            // 
            // lblIDPedido
            // 
            this.lblIDPedido.AutoSize = true;
            this.lblIDPedido.Location = new System.Drawing.Point(5, 111);
            this.lblIDPedido.Name = "lblIDPedido";
            this.lblIDPedido.Size = new System.Drawing.Size(93, 22);
            this.lblIDPedido.TabIndex = 0;
            this.lblIDPedido.Text = "ID Pedido:";
            // 
            // lblOP
            // 
            this.lblOP.AutoSize = true;
            this.lblOP.Location = new System.Drawing.Point(5, 46);
            this.lblOP.Name = "lblOP";
            this.lblOP.Size = new System.Drawing.Size(182, 22);
            this.lblOP.TabIndex = 0;
            this.lblOP.Text = "ID Órden Producción:";
            this.lblOP.Click += new System.EventHandler(this.lblCliente_Click);
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.txtBuscar);
            this.gbBuscar.Controls.Add(this.label9);
            this.gbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbBuscar.Location = new System.Drawing.Point(12, 453);
            this.gbBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbBuscar.Size = new System.Drawing.Size(369, 66);
            this.gbBuscar.TabIndex = 0;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(195, 25);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(135, 28);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "ID Órden Producción:";
            this.label9.Click += new System.EventHandler(this.lblCliente_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 526);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1171, 276);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(1043, 27);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(139, 49);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Quitar
            // 
            this.Quitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.Quitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Quitar.FlatAppearance.BorderSize = 0;
            this.Quitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.Quitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitar.ForeColor = System.Drawing.Color.White;
            this.Quitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Quitar.Location = new System.Drawing.Point(1043, 96);
            this.Quitar.Margin = new System.Windows.Forms.Padding(4);
            this.Quitar.Name = "Quitar";
            this.Quitar.Size = new System.Drawing.Size(139, 49);
            this.Quitar.TabIndex = 3;
            this.Quitar.Text = "Quitar";
            this.Quitar.UseVisualStyleBackColor = false;
            this.Quitar.Click += new System.EventHandler(this.Quitar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.btnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrabar.FlatAppearance.BorderSize = 0;
            this.btnGrabar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.ForeColor = System.Drawing.Color.White;
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrabar.Location = new System.Drawing.Point(1043, 165);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(139, 49);
            this.btnGrabar.TabIndex = 3;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.Quitar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(1043, 230);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(139, 49);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.Quitar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(338, 33);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 35);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.Quitar_Click);
            // 
            // FormTransaccionOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1195, 816);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.Quitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.gbOP);
            this.Controls.Add(this.gbPedido);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTransaccionOP";
            this.Text = "Form1";
            this.gbPedido.ResumeLayout(false);
            this.gbPedido.PerformLayout();
            this.gbOP.ResumeLayout(false);
            this.gbOP.PerformLayout();
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPedido;
        private System.Windows.Forms.TextBox txtNomPedido;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox TxtRSocial;
        private System.Windows.Forms.Label lblRs;
        private System.Windows.Forms.GroupBox gbOP;
        private System.Windows.Forms.TextBox TxtCodPedido;
        private System.Windows.Forms.TextBox txtCodModelo;
        private System.Windows.Forms.Label lblIdModelo;
        private System.Windows.Forms.TextBox txtCodProduccion;
        private System.Windows.Forms.Label lblIDPedido;
        private System.Windows.Forms.Label lblOP;
        private System.Windows.Forms.TextBox CodCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button Quitar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscar;
    }
}