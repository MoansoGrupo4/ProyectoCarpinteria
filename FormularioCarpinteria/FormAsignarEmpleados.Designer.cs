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
            this.groupBoxOrdendeproduccion = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.groupBoxEmpleado.SuspendLayout();
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
            // groupBoxOrdendeproduccion
            // 
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleado:";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(391, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(563, 22);
            this.textBox2.TabIndex = 3;
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
            // FormAsignarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1227, 558);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBoxOrdendeproduccion);
            this.Controls.Add(this.groupBoxEmpleado);
            this.Name = "FormAsignarEmpleados";
            this.Text = "FormAsignarEmpleados";
            this.groupBoxEmpleado.ResumeLayout(false);
            this.groupBoxEmpleado.PerformLayout();
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
    }
}