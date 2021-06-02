namespace Proyecto_PAV1_G5.Transacciones.Ventas
{
    partial class Frm_Mostrar_Venta
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
            this.btn_volver = new System.Windows.Forms.Button();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.MaskedTextBox();
            this.txt_numero_factura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.grid_equipos_especiales = new Proyecto_PAV1_G5.Clases.Grid01();
            this.grid_equipos = new Proyecto_PAV1_G5.Clases.Grid01();
            this.grid_articulos = new Proyecto_PAV1_G5.Clases.Grid01();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_id_tipo_factura = new System.Windows.Forms.TextBox();
            this.txt_cuit_cliente = new System.Windows.Forms.TextBox();
            this.txt_legajo_vendedor = new System.Windows.Forms.TextBox();
            this.txt_id_forma_pago = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_equipos_especiales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_equipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.btn_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.Location = new System.Drawing.Point(877, 584);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(87, 30);
            this.btn_volver.TabIndex = 4;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // txt_monto
            // 
            this.txt_monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monto.Location = new System.Drawing.Point(466, 70);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.ReadOnly = true;
            this.txt_monto.Size = new System.Drawing.Size(169, 26);
            this.txt_monto.TabIndex = 5;
            this.txt_monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo de Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(371, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Monto total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(666, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha de Venta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(671, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Forma de Pago";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(381, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Vendedor";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha.Location = new System.Drawing.Point(795, 70);
            this.txt_fecha.Mask = "00/00/0000";
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.ReadOnly = true;
            this.txt_fecha.Size = new System.Drawing.Size(169, 26);
            this.txt_fecha.TabIndex = 7;
            this.txt_fecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_fecha.ValidatingType = typeof(System.DateTime);
            // 
            // txt_numero_factura
            // 
            this.txt_numero_factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero_factura.Location = new System.Drawing.Point(176, 107);
            this.txt_numero_factura.Name = "txt_numero_factura";
            this.txt_numero_factura.ReadOnly = true;
            this.txt_numero_factura.Size = new System.Drawing.Size(169, 26);
            this.txt_numero_factura.TabIndex = 5;
            this.txt_numero_factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numero de Factura";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(21, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(243, 37);
            this.label17.TabIndex = 26;
            this.label17.Text = "Mostrar Venta";
            // 
            // grid_equipos_especiales
            // 
            this.grid_equipos_especiales.AllowUserToAddRows = false;
            this.grid_equipos_especiales.AllowUserToDeleteRows = false;
            this.grid_equipos_especiales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_equipos_especiales.Location = new System.Drawing.Point(104, 336);
            this.grid_equipos_especiales.Name = "grid_equipos_especiales";
            this.grid_equipos_especiales.ReadOnly = true;
            this.grid_equipos_especiales.Size = new System.Drawing.Size(860, 133);
            this.grid_equipos_especiales.TabIndex = 0;
            // 
            // grid_equipos
            // 
            this.grid_equipos.AllowUserToAddRows = false;
            this.grid_equipos.AllowUserToDeleteRows = false;
            this.grid_equipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_equipos.Location = new System.Drawing.Point(104, 481);
            this.grid_equipos.Name = "grid_equipos";
            this.grid_equipos.ReadOnly = true;
            this.grid_equipos.Size = new System.Drawing.Size(638, 133);
            this.grid_equipos.TabIndex = 0;
            // 
            // grid_articulos
            // 
            this.grid_articulos.AllowUserToAddRows = false;
            this.grid_articulos.AllowUserToDeleteRows = false;
            this.grid_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_articulos.Location = new System.Drawing.Point(104, 191);
            this.grid_articulos.Name = "grid_articulos";
            this.grid_articulos.ReadOnly = true;
            this.grid_articulos.Size = new System.Drawing.Size(860, 133);
            this.grid_articulos.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Artículos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 534);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Equipos";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 377);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 40);
            this.label16.TabIndex = 16;
            this.label16.Text = "Equipos \r\nEspeciales";
            // 
            // txt_id_tipo_factura
            // 
            this.txt_id_tipo_factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_tipo_factura.Location = new System.Drawing.Point(176, 70);
            this.txt_id_tipo_factura.Name = "txt_id_tipo_factura";
            this.txt_id_tipo_factura.ReadOnly = true;
            this.txt_id_tipo_factura.Size = new System.Drawing.Size(169, 26);
            this.txt_id_tipo_factura.TabIndex = 5;
            this.txt_id_tipo_factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_cuit_cliente
            // 
            this.txt_cuit_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cuit_cliente.Location = new System.Drawing.Point(176, 144);
            this.txt_cuit_cliente.Name = "txt_cuit_cliente";
            this.txt_cuit_cliente.ReadOnly = true;
            this.txt_cuit_cliente.Size = new System.Drawing.Size(169, 26);
            this.txt_cuit_cliente.TabIndex = 5;
            this.txt_cuit_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_legajo_vendedor
            // 
            this.txt_legajo_vendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_legajo_vendedor.Location = new System.Drawing.Point(466, 107);
            this.txt_legajo_vendedor.Name = "txt_legajo_vendedor";
            this.txt_legajo_vendedor.ReadOnly = true;
            this.txt_legajo_vendedor.Size = new System.Drawing.Size(169, 26);
            this.txt_legajo_vendedor.TabIndex = 5;
            this.txt_legajo_vendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_id_forma_pago
            // 
            this.txt_id_forma_pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_forma_pago.Location = new System.Drawing.Point(795, 107);
            this.txt_id_forma_pago.Name = "txt_id_forma_pago";
            this.txt_id_forma_pago.ReadOnly = true;
            this.txt_id_forma_pago.Size = new System.Drawing.Size(169, 26);
            this.txt_id_forma_pago.TabIndex = 5;
            this.txt_id_forma_pago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Frm_Mostrar_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 639);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_legajo_vendedor);
            this.Controls.Add(this.txt_id_forma_pago);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.txt_id_tipo_factura);
            this.Controls.Add(this.txt_cuit_cliente);
            this.Controls.Add(this.txt_numero_factura);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.grid_equipos_especiales);
            this.Controls.Add(this.grid_equipos);
            this.Controls.Add(this.grid_articulos);
            this.MaximizeBox = false;
            this.Name = "Frm_Mostrar_Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar Venta";
            this.Load += new System.EventHandler(this.Frm_Mostrar_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_equipos_especiales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_equipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_articulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.Grid01 grid_articulos;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txt_fecha;
        private System.Windows.Forms.TextBox txt_numero_factura;
        private System.Windows.Forms.Label label3;
        private Clases.Grid01 grid_equipos;
        private Clases.Grid01 grid_equipos_especiales;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_id_tipo_factura;
        private System.Windows.Forms.TextBox txt_cuit_cliente;
        private System.Windows.Forms.TextBox txt_legajo_vendedor;
        private System.Windows.Forms.TextBox txt_id_forma_pago;
    }
}