namespace Proyecto_PAV1_G5.ReportesyEstadisticas.Estadisticas
{
    partial class Frm_BotoneraEstadisticas
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
            this.btn_articulos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_equipos = new System.Windows.Forms.Button();
            this.btn_empleados = new System.Windows.Forms.Button();
            this.btn_compras = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.btn_tipofactura = new System.Windows.Forms.Button();
            this.btn_clasificaciones = new System.Windows.Forms.Button();
            this.btn_formaspago = new System.Windows.Forms.Button();
            this.btn_productos = new System.Windows.Forms.Button();
            this.btn_rubros = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_articulos
            // 
            this.btn_articulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_articulos.Location = new System.Drawing.Point(24, 109);
            this.btn_articulos.Margin = new System.Windows.Forms.Padding(15);
            this.btn_articulos.Name = "btn_articulos";
            this.btn_articulos.Size = new System.Drawing.Size(250, 50);
            this.btn_articulos.TabIndex = 0;
            this.btn_articulos.Text = "Artículos Mas Vendidos";
            this.btn_articulos.UseVisualStyleBackColor = true;
            this.btn_articulos.Click += new System.EventHandler(this.btn_articulos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Generar Estadísticas";
            // 
            // btn_equipos
            // 
            this.btn_equipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_equipos.Location = new System.Drawing.Point(24, 269);
            this.btn_equipos.Margin = new System.Windows.Forms.Padding(15);
            this.btn_equipos.Name = "btn_equipos";
            this.btn_equipos.Size = new System.Drawing.Size(250, 50);
            this.btn_equipos.TabIndex = 3;
            this.btn_equipos.Text = "Equipos Mas Vendidos";
            this.btn_equipos.UseVisualStyleBackColor = true;
            this.btn_equipos.Click += new System.EventHandler(this.btn_equipos_Click);
            // 
            // btn_empleados
            // 
            this.btn_empleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empleados.Location = new System.Drawing.Point(304, 189);
            this.btn_empleados.Margin = new System.Windows.Forms.Padding(15);
            this.btn_empleados.Name = "btn_empleados";
            this.btn_empleados.Size = new System.Drawing.Size(250, 50);
            this.btn_empleados.TabIndex = 4;
            this.btn_empleados.Text = "Empleados con Mas Ventas";
            this.btn_empleados.UseVisualStyleBackColor = true;
            this.btn_empleados.Click += new System.EventHandler(this.btn_empleados_Click);
            // 
            // btn_compras
            // 
            this.btn_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compras.Location = new System.Drawing.Point(24, 189);
            this.btn_compras.Margin = new System.Windows.Forms.Padding(15);
            this.btn_compras.Name = "btn_compras";
            this.btn_compras.Size = new System.Drawing.Size(250, 50);
            this.btn_compras.TabIndex = 5;
            this.btn_compras.Text = "Compras por Proveedor";
            this.btn_compras.UseVisualStyleBackColor = true;
            this.btn_compras.Click += new System.EventHandler(this.btn_compras_Click);
            // 
            // btn_cliente
            // 
            this.btn_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cliente.Location = new System.Drawing.Point(24, 429);
            this.btn_cliente.Margin = new System.Windows.Forms.Padding(15);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(250, 50);
            this.btn_cliente.TabIndex = 6;
            this.btn_cliente.Text = "Ventas por Cliente";
            this.btn_cliente.UseVisualStyleBackColor = true;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // btn_tipofactura
            // 
            this.btn_tipofactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tipofactura.Location = new System.Drawing.Point(304, 429);
            this.btn_tipofactura.Margin = new System.Windows.Forms.Padding(15);
            this.btn_tipofactura.Name = "btn_tipofactura";
            this.btn_tipofactura.Size = new System.Drawing.Size(250, 50);
            this.btn_tipofactura.TabIndex = 7;
            this.btn_tipofactura.Text = "Ventas por Tipo de Factura";
            this.btn_tipofactura.UseVisualStyleBackColor = true;
            this.btn_tipofactura.Click += new System.EventHandler(this.btn_tipofactura_Click);
            // 
            // btn_clasificaciones
            // 
            this.btn_clasificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clasificaciones.Location = new System.Drawing.Point(304, 109);
            this.btn_clasificaciones.Margin = new System.Windows.Forms.Padding(15);
            this.btn_clasificaciones.Name = "btn_clasificaciones";
            this.btn_clasificaciones.Size = new System.Drawing.Size(250, 50);
            this.btn_clasificaciones.TabIndex = 8;
            this.btn_clasificaciones.Text = "Clasificaciones de Clientes";
            this.btn_clasificaciones.UseVisualStyleBackColor = true;
            this.btn_clasificaciones.Click += new System.EventHandler(this.btn_clasificaciones_Click);
            // 
            // btn_formaspago
            // 
            this.btn_formaspago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_formaspago.Location = new System.Drawing.Point(304, 269);
            this.btn_formaspago.Margin = new System.Windows.Forms.Padding(15);
            this.btn_formaspago.Name = "btn_formaspago";
            this.btn_formaspago.Size = new System.Drawing.Size(250, 50);
            this.btn_formaspago.TabIndex = 9;
            this.btn_formaspago.Text = "Formas de Pago mas Utilizadas";
            this.btn_formaspago.UseVisualStyleBackColor = true;
            this.btn_formaspago.Click += new System.EventHandler(this.btn_formaspago_Click);
            // 
            // btn_productos
            // 
            this.btn_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productos.Location = new System.Drawing.Point(304, 349);
            this.btn_productos.Margin = new System.Windows.Forms.Padding(15);
            this.btn_productos.Name = "btn_productos";
            this.btn_productos.Size = new System.Drawing.Size(250, 50);
            this.btn_productos.TabIndex = 10;
            this.btn_productos.Text = "Tipos de Productos mas Vendidos";
            this.btn_productos.UseVisualStyleBackColor = true;
            this.btn_productos.Click += new System.EventHandler(this.btn_productos_Click);
            // 
            // btn_rubros
            // 
            this.btn_rubros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rubros.Location = new System.Drawing.Point(24, 349);
            this.btn_rubros.Margin = new System.Windows.Forms.Padding(15);
            this.btn_rubros.Name = "btn_rubros";
            this.btn_rubros.Size = new System.Drawing.Size(250, 50);
            this.btn_rubros.TabIndex = 11;
            this.btn_rubros.Text = "Rubros mas Vendidos";
            this.btn_rubros.UseVisualStyleBackColor = true;
            this.btn_rubros.Click += new System.EventHandler(this.btn_rubros_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Proyecto_PAV1_G5.Properties.Resources._004_stats;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(377, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 75);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_BotoneraEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 498);
            this.Controls.Add(this.btn_rubros);
            this.Controls.Add(this.btn_productos);
            this.Controls.Add(this.btn_formaspago);
            this.Controls.Add(this.btn_clasificaciones);
            this.Controls.Add(this.btn_tipofactura);
            this.Controls.Add(this.btn_cliente);
            this.Controls.Add(this.btn_compras);
            this.Controls.Add(this.btn_empleados);
            this.Controls.Add(this.btn_equipos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_articulos);
            this.Name = "Frm_BotoneraEstadisticas";
            this.Text = "Frm_BotoneraEstadisticas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_articulos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_equipos;
        private System.Windows.Forms.Button btn_empleados;
        private System.Windows.Forms.Button btn_compras;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Button btn_tipofactura;
        private System.Windows.Forms.Button btn_clasificaciones;
        private System.Windows.Forms.Button btn_formaspago;
        private System.Windows.Forms.Button btn_productos;
        private System.Windows.Forms.Button btn_rubros;
    }
}