namespace FormularioCarpinteria
{
    partial class FormAsignarEmpleados
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
            this.groupBoxEmpleado = new System.Windows.Forms.GroupBox();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxOrdendeproduccion = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscarIdPedido = new System.Windows.Forms.Button();
            this.dtpFechaInicioOP = new System.Windows.Forms.DateTimePicker();
            this.TxtCodPedido = new System.Windows.Forms.TextBox();
            this.txtCodModelo = new System.Windows.Forms.TextBox();
            this.lblIdModelo = new System.Windows.Forms.Label();
            this.txtCodEmpleado = new System.Windows.Forms.TextBox();
            this.txtCodProduccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIDPedido = new System.Windows.Forms.Label();
            this.lblOP = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBoxEmpleado.SuspendLayout();
            this.groupBoxOrdendeproduccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEmpleado
            // 
            this.groupBoxEmpleado.Controls.Add(this.btnBuscarEmpleado);
            this.groupBoxEmpleado.Controls.Add(this.textBox2);
            this.groupBoxEmpleado.Controls.Add(this.textBox1);
            this.groupBoxEmpleado.Controls.Add(this.label2);
            this.groupBoxEmpleado.Controls.Add(this.label1);
            this.groupBoxEmpleado.ForeColor = System.Drawing.Color.White;
            this.groupBoxEmpleado.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEmpleado.Name = "groupBoxEmpleado";
            this.groupBoxEmpleado.Size = new System.Drawing.Size(943, 180);
            this.groupBoxEmpleado.TabIndex = 0;
            this.groupBoxEmpleado.TabStop = false;
            this.groupBoxEmpleado.Text = "Empleado:";
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(571, 51);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(110, 28);
            this.btnBuscarEmpleado.TabIndex = 4;
            this.btnBuscarEmpleado.Text = "BUSCAR";
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(563, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(391, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleado:";
            // 
            // groupBoxOrdendeproduccion
            // 
            this.groupBoxOrdendeproduccion.Controls.Add(this.btnBuscarIdPedido);
            this.groupBoxOrdendeproduccion.Controls.Add(this.dtpFechaInicioOP);
            this.groupBoxOrdendeproduccion.Controls.Add(this.TxtCodPedido);
            this.groupBoxOrdendeproduccion.Controls.Add(this.txtCodModelo);
            this.groupBoxOrdendeproduccion.Controls.Add(this.lblIdModelo);
            this.groupBoxOrdendeproduccion.Controls.Add(this.txtCodEmpleado);
            this.groupBoxOrdendeproduccion.Controls.Add(this.txtCodProduccion);
            this.groupBoxOrdendeproduccion.Controls.Add(this.label4);
            this.groupBoxOrdendeproduccion.Controls.Add(this.label3);
            this.groupBoxOrdendeproduccion.Controls.Add(this.lblIDPedido);
            this.groupBoxOrdendeproduccion.Controls.Add(this.lblOP);
            this.groupBoxOrdendeproduccion.ForeColor = System.Drawing.Color.White;
            this.groupBoxOrdendeproduccion.Location = new System.Drawing.Point(12, 209);
            this.groupBoxOrdendeproduccion.Name = "groupBoxOrdendeproduccion";
            this.groupBoxOrdendeproduccion.Size = new System.Drawing.Size(943, 203);
            this.groupBoxOrdendeproduccion.TabIndex = 1;
            this.groupBoxOrdendeproduccion.TabStop = false;
            this.groupBoxOrdendeproduccion.Text = "Orden de Produccion:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(1034, 38);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(142, 38);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(1034, 94);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(142, 38);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "QUITAR";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1034, 148);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(142, 38);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnBuscarIdPedido
            // 
            this.btnBuscarIdPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.btnBuscarIdPedido.Location = new System.Drawing.Point(476, 101);
            this.btnBuscarIdPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarIdPedido.Name = "btnBuscarIdPedido";
            this.btnBuscarIdPedido.Size = new System.Drawing.Size(89, 31);
            this.btnBuscarIdPedido.TabIndex = 15;
            this.btnBuscarIdPedido.Text = "Buscar";
            this.btnBuscarIdPedido.UseVisualStyleBackColor = false;
            // 
            // dtpFechaInicioOP
            // 
            this.dtpFechaInicioOP.Location = new System.Drawing.Point(220, 158);
            this.dtpFechaInicioOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaInicioOP.Name = "dtpFechaInicioOP";
            this.dtpFechaInicioOP.Size = new System.Drawing.Size(396, 22);
            this.dtpFechaInicioOP.TabIndex = 14;
            // 
            // TxtCodPedido
            // 
            this.TxtCodPedido.Location = new System.Drawing.Point(220, 102);
            this.TxtCodPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCodPedido.Name = "TxtCodPedido";
            this.TxtCodPedido.ReadOnly = true;
            this.TxtCodPedido.Size = new System.Drawing.Size(135, 22);
            this.TxtCodPedido.TabIndex = 13;
            // 
            // txtCodModelo
            // 
            this.txtCodModelo.Location = new System.Drawing.Point(752, 102);
            this.txtCodModelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodModelo.Name = "txtCodModelo";
            this.txtCodModelo.ReadOnly = true;
            this.txtCodModelo.Size = new System.Drawing.Size(137, 22);
            this.txtCodModelo.TabIndex = 10;
            // 
            // lblIdModelo
            // 
            this.lblIdModelo.AutoSize = true;
            this.lblIdModelo.Location = new System.Drawing.Point(644, 102);
            this.lblIdModelo.Name = "lblIdModelo";
            this.lblIdModelo.Size = new System.Drawing.Size(69, 16);
            this.lblIdModelo.TabIndex = 5;
            this.lblIdModelo.Text = "ID Modelo";
            // 
            // txtCodEmpleado
            // 
            this.txtCodEmpleado.Location = new System.Drawing.Point(752, 30);
            this.txtCodEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodEmpleado.Name = "txtCodEmpleado";
            this.txtCodEmpleado.ReadOnly = true;
            this.txtCodEmpleado.Size = new System.Drawing.Size(135, 22);
            this.txtCodEmpleado.TabIndex = 11;
            // 
            // txtCodProduccion
            // 
            this.txtCodProduccion.Location = new System.Drawing.Point(220, 37);
            this.txtCodProduccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodProduccion.Name = "txtCodProduccion";
            this.txtCodProduccion.Size = new System.Drawing.Size(135, 22);
            this.txtCodProduccion.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(641, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID Empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha de Inicio:";
            // 
            // lblIDPedido
            // 
            this.lblIDPedido.AutoSize = true;
            this.lblIDPedido.Location = new System.Drawing.Point(30, 102);
            this.lblIDPedido.Name = "lblIDPedido";
            this.lblIDPedido.Size = new System.Drawing.Size(70, 16);
            this.lblIDPedido.TabIndex = 8;
            this.lblIDPedido.Text = "ID Pedido:";
            // 
            // lblOP
            // 
            this.lblOP.AutoSize = true;
            this.lblOP.Location = new System.Drawing.Point(30, 37);
            this.lblOP.Name = "lblOP";
            this.lblOP.Size = new System.Drawing.Size(134, 16);
            this.lblOP.TabIndex = 9;
            this.lblOP.Text = "ID Órden Producción:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 519);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1203, 238);
            this.dataGridView1.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "ID Órden Producción:";
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.txtBuscar);
            this.gbBuscar.Controls.Add(this.label9);
            this.gbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbBuscar.Location = new System.Drawing.Point(12, 425);
            this.gbBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbBuscar.Size = new System.Drawing.Size(369, 66);
            this.gbBuscar.TabIndex = 6;
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
            // 
            // FormAsignarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1227, 782);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBoxOrdendeproduccion);
            this.Controls.Add(this.groupBoxEmpleado);
            this.Name = "FormAsignarEmpleados";
            this.Text = "FormAsignarEmpleados";
            this.groupBoxEmpleado.ResumeLayout(false);
            this.groupBoxEmpleado.PerformLayout();
            this.groupBoxOrdendeproduccion.ResumeLayout(false);
            this.groupBoxOrdendeproduccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEmpleado;
        private System.Windows.Forms.GroupBox groupBoxOrdendeproduccion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarEmpleado;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscarIdPedido;
        private System.Windows.Forms.DateTimePicker dtpFechaInicioOP;
        private System.Windows.Forms.TextBox TxtCodPedido;
        private System.Windows.Forms.TextBox txtCodModelo;
        private System.Windows.Forms.Label lblIdModelo;
        private System.Windows.Forms.TextBox txtCodEmpleado;
        private System.Windows.Forms.TextBox txtCodProduccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIDPedido;
        private System.Windows.Forms.Label lblOP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}