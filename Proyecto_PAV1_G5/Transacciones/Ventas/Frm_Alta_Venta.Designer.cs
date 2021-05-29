namespace Proyecto_PAV1_G5.Transacciones.Ventas
{
    partial class Frm_Alta_Venta
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
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
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
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txt_cantidad_articulo = new System.Windows.Forms.TextBox();
            this.txt_precio_mayorista_articulo = new System.Windows.Forms.TextBox();
            this.txt_descripcion_articulo = new System.Windows.Forms.TextBox();
            this.txt_precio_minorista_articulo = new System.Windows.Forms.TextBox();
            this.btn_agregar_articulos = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_agregar_equipos = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_precio_mayorista_equipos = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_precio_minorista_equipos = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_agregar_equipos_especiales = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_precio_mayorista_equipos_especiales = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_descripcion_equipo_especial = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cmb_equipos_especiales = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.cmb_equipos = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.cmb_nombre_articulo = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.txt_cantidad_equipos_especiales = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_cantidad_equipos = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.cmb_id_forma_pago = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.cmb_legajo_vendedor = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.cmb_cuit_cliente = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.cmb_id_tipo_factura = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.grid_equipos_especiales = new Proyecto_PAV1_G5.Clases.Grid01();
            this.grid_equipos = new Proyecto_PAV1_G5.Clases.Grid01();
            this.grid_articulos = new Proyecto_PAV1_G5.Clases.Grid01();
            ((System.ComponentModel.ISupportInitialize)(this.grid_equipos_especiales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_equipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Location = new System.Drawing.Point(113, 699);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(87, 30);
            this.btn_aceptar.TabIndex = 4;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(296, 699);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(87, 30);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_monto
            // 
            this.txt_monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monto.Location = new System.Drawing.Point(214, 206);
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
            this.label1.Location = new System.Drawing.Point(80, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo de Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Monto total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha de Venta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(82, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Forma de Pago";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(121, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Vendedor";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha.Location = new System.Drawing.Point(214, 238);
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
            this.txt_numero_factura.Location = new System.Drawing.Point(214, 174);
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
            this.label3.Location = new System.Drawing.Point(54, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numero de Factura";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(526, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Descripción";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(788, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(493, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Precio Mayorista";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(493, 175);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(121, 20);
            this.label.TabIndex = 24;
            this.label.Text = "Precio Minorista";
            // 
            // txt_cantidad_articulo
            // 
            this.txt_cantidad_articulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_articulo.Location = new System.Drawing.Point(867, 140);
            this.txt_cantidad_articulo.Name = "txt_cantidad_articulo";
            this.txt_cantidad_articulo.Size = new System.Drawing.Size(87, 26);
            this.txt_cantidad_articulo.TabIndex = 18;
            // 
            // txt_precio_mayorista_articulo
            // 
            this.txt_precio_mayorista_articulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio_mayorista_articulo.Location = new System.Drawing.Point(624, 140);
            this.txt_precio_mayorista_articulo.Name = "txt_precio_mayorista_articulo";
            this.txt_precio_mayorista_articulo.ReadOnly = true;
            this.txt_precio_mayorista_articulo.Size = new System.Drawing.Size(100, 26);
            this.txt_precio_mayorista_articulo.TabIndex = 19;
            // 
            // txt_descripcion_articulo
            // 
            this.txt_descripcion_articulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion_articulo.Location = new System.Drawing.Point(624, 81);
            this.txt_descripcion_articulo.Multiline = true;
            this.txt_descripcion_articulo.Name = "txt_descripcion_articulo";
            this.txt_descripcion_articulo.ReadOnly = true;
            this.txt_descripcion_articulo.Size = new System.Drawing.Size(330, 53);
            this.txt_descripcion_articulo.TabIndex = 20;
            // 
            // txt_precio_minorista_articulo
            // 
            this.txt_precio_minorista_articulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio_minorista_articulo.Location = new System.Drawing.Point(624, 172);
            this.txt_precio_minorista_articulo.Name = "txt_precio_minorista_articulo";
            this.txt_precio_minorista_articulo.ReadOnly = true;
            this.txt_precio_minorista_articulo.Size = new System.Drawing.Size(100, 26);
            this.txt_precio_minorista_articulo.TabIndex = 21;
            // 
            // btn_agregar_articulos
            // 
            this.btn_agregar_articulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_articulos.Location = new System.Drawing.Point(867, 172);
            this.btn_agregar_articulos.Name = "btn_agregar_articulos";
            this.btn_agregar_articulos.Size = new System.Drawing.Size(87, 30);
            this.btn_agregar_articulos.TabIndex = 17;
            this.btn_agregar_articulos.Text = "Agregar";
            this.btn_agregar_articulos.UseVisualStyleBackColor = true;
            this.btn_agregar_articulos.Click += new System.EventHandler(this.btn_agregar_articulos_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(556, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Artículo";
            // 
            // btn_agregar_equipos
            // 
            this.btn_agregar_equipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_equipos.Location = new System.Drawing.Point(867, 497);
            this.btn_agregar_equipos.Name = "btn_agregar_equipos";
            this.btn_agregar_equipos.Size = new System.Drawing.Size(87, 30);
            this.btn_agregar_equipos.TabIndex = 4;
            this.btn_agregar_equipos.Text = "Agregar";
            this.btn_agregar_equipos.UseVisualStyleBackColor = true;
            this.btn_agregar_equipos.Click += new System.EventHandler(this.btn_agregar_equipos_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(559, 431);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Equipo";
            // 
            // txt_precio_mayorista_equipos
            // 
            this.txt_precio_mayorista_equipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio_mayorista_equipos.Location = new System.Drawing.Point(624, 469);
            this.txt_precio_mayorista_equipos.Name = "txt_precio_mayorista_equipos";
            this.txt_precio_mayorista_equipos.ReadOnly = true;
            this.txt_precio_mayorista_equipos.Size = new System.Drawing.Size(100, 26);
            this.txt_precio_mayorista_equipos.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(493, 472);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "Precio Mayorista";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(788, 469);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 20);
            this.label15.TabIndex = 22;
            this.label15.Text = "Cantidad";
            // 
            // txt_precio_minorista_equipos
            // 
            this.txt_precio_minorista_equipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio_minorista_equipos.Location = new System.Drawing.Point(624, 501);
            this.txt_precio_minorista_equipos.Name = "txt_precio_minorista_equipos";
            this.txt_precio_minorista_equipos.ReadOnly = true;
            this.txt_precio_minorista_equipos.Size = new System.Drawing.Size(100, 26);
            this.txt_precio_minorista_equipos.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(493, 504);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Precio Minorista";
            // 
            // btn_agregar_equipos_especiales
            // 
            this.btn_agregar_equipos_especiales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_equipos_especiales.Location = new System.Drawing.Point(382, 497);
            this.btn_agregar_equipos_especiales.Name = "btn_agregar_equipos_especiales";
            this.btn_agregar_equipos_especiales.Size = new System.Drawing.Size(87, 30);
            this.btn_agregar_equipos_especiales.TabIndex = 4;
            this.btn_agregar_equipos_especiales.Text = "Agregar";
            this.btn_agregar_equipos_especiales.UseVisualStyleBackColor = true;
            this.btn_agregar_equipos_especiales.Click += new System.EventHandler(this.btn_agregar_equipos_especiales_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 376);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 20);
            this.label16.TabIndex = 16;
            this.label16.Text = "Equipo Especial";
            // 
            // txt_precio_mayorista_equipos_especiales
            // 
            this.txt_precio_mayorista_equipos_especiales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio_mayorista_equipos_especiales.Location = new System.Drawing.Point(139, 466);
            this.txt_precio_mayorista_equipos_especiales.Name = "txt_precio_mayorista_equipos_especiales";
            this.txt_precio_mayorista_equipos_especiales.ReadOnly = true;
            this.txt_precio_mayorista_equipos_especiales.Size = new System.Drawing.Size(100, 26);
            this.txt_precio_mayorista_equipos_especiales.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 469);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(125, 20);
            this.label18.TabIndex = 23;
            this.label18.Text = "Precio Mayorista";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(303, 470);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 20);
            this.label19.TabIndex = 22;
            this.label19.Text = "Cantidad";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(51, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(258, 39);
            this.label17.TabIndex = 26;
            this.label17.Text = "Registrar Venta";
            // 
            // txt_descripcion_equipo_especial
            // 
            this.txt_descripcion_equipo_especial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion_equipo_especial.Location = new System.Drawing.Point(139, 407);
            this.txt_descripcion_equipo_especial.Multiline = true;
            this.txt_descripcion_equipo_especial.Name = "txt_descripcion_equipo_especial";
            this.txt_descripcion_equipo_especial.ReadOnly = true;
            this.txt_descripcion_equipo_especial.Size = new System.Drawing.Size(330, 53);
            this.txt_descripcion_equipo_especial.TabIndex = 20;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(40, 410);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 20);
            this.label20.TabIndex = 25;
            this.label20.Text = "Descripción";
            // 
            // cmb_equipos_especiales
            // 
            this.cmb_equipos_especiales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_equipos_especiales.FormattingEnabled = true;
            this.cmb_equipos_especiales.Location = new System.Drawing.Point(139, 373);
            this.cmb_equipos_especiales.Name = "cmb_equipos_especiales";
            this.cmb_equipos_especiales.Pp_Conseleccion = false;
            this.cmb_equipos_especiales.Pp_MensajeError = "";
            this.cmb_equipos_especiales.Pp_NombreCampo = null;
            this.cmb_equipos_especiales.Pp_Validable = false;
            this.cmb_equipos_especiales.Size = new System.Drawing.Size(330, 28);
            this.cmb_equipos_especiales.TabIndex = 15;
            this.cmb_equipos_especiales.SelectionChangeCommitted += new System.EventHandler(this.cmb_equipos_especiales_SelectionChangeCommitted);
            // 
            // cmb_equipos
            // 
            this.cmb_equipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_equipos.FormattingEnabled = true;
            this.cmb_equipos.Location = new System.Drawing.Point(624, 428);
            this.cmb_equipos.Name = "cmb_equipos";
            this.cmb_equipos.Pp_Conseleccion = false;
            this.cmb_equipos.Pp_MensajeError = "";
            this.cmb_equipos.Pp_NombreCampo = null;
            this.cmb_equipos.Pp_Validable = false;
            this.cmb_equipos.Size = new System.Drawing.Size(330, 28);
            this.cmb_equipos.TabIndex = 15;
            this.cmb_equipos.SelectionChangeCommitted += new System.EventHandler(this.cmb_equipos_SelectionChangeCommitted);
            // 
            // cmb_nombre_articulo
            // 
            this.cmb_nombre_articulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_nombre_articulo.FormattingEnabled = true;
            this.cmb_nombre_articulo.Location = new System.Drawing.Point(624, 47);
            this.cmb_nombre_articulo.Name = "cmb_nombre_articulo";
            this.cmb_nombre_articulo.Pp_Conseleccion = false;
            this.cmb_nombre_articulo.Pp_MensajeError = "";
            this.cmb_nombre_articulo.Pp_NombreCampo = null;
            this.cmb_nombre_articulo.Pp_Validable = false;
            this.cmb_nombre_articulo.Size = new System.Drawing.Size(330, 28);
            this.cmb_nombre_articulo.TabIndex = 15;
            this.cmb_nombre_articulo.SelectionChangeCommitted += new System.EventHandler(this.cmb_nombre_articulo_SelectionChangeCommitted);
            // 
            // txt_cantidad_equipos_especiales
            // 
            this.txt_cantidad_equipos_especiales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_equipos_especiales.Location = new System.Drawing.Point(382, 466);
            this.txt_cantidad_equipos_especiales.Name = "txt_cantidad_equipos_especiales";
            this.txt_cantidad_equipos_especiales.Pp_campo = null;
            this.txt_cantidad_equipos_especiales.Pp_MensajeError = null;
            this.txt_cantidad_equipos_especiales.Pp_Validable = false;
            this.txt_cantidad_equipos_especiales.Size = new System.Drawing.Size(87, 26);
            this.txt_cantidad_equipos_especiales.TabIndex = 3;
            // 
            // txt_cantidad_equipos
            // 
            this.txt_cantidad_equipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_equipos.Location = new System.Drawing.Point(867, 465);
            this.txt_cantidad_equipos.Name = "txt_cantidad_equipos";
            this.txt_cantidad_equipos.Pp_campo = null;
            this.txt_cantidad_equipos.Pp_MensajeError = null;
            this.txt_cantidad_equipos.Pp_Validable = false;
            this.txt_cantidad_equipos.Size = new System.Drawing.Size(87, 26);
            this.txt_cantidad_equipos.TabIndex = 3;
            // 
            // cmb_id_forma_pago
            // 
            this.cmb_id_forma_pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_id_forma_pago.FormattingEnabled = true;
            this.cmb_id_forma_pago.Location = new System.Drawing.Point(214, 304);
            this.cmb_id_forma_pago.Name = "cmb_id_forma_pago";
            this.cmb_id_forma_pago.Pp_Conseleccion = false;
            this.cmb_id_forma_pago.Pp_MensajeError = null;
            this.cmb_id_forma_pago.Pp_NombreCampo = null;
            this.cmb_id_forma_pago.Pp_Validable = false;
            this.cmb_id_forma_pago.Size = new System.Drawing.Size(169, 28);
            this.cmb_id_forma_pago.TabIndex = 2;
            // 
            // cmb_legajo_vendedor
            // 
            this.cmb_legajo_vendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_legajo_vendedor.FormattingEnabled = true;
            this.cmb_legajo_vendedor.Location = new System.Drawing.Point(214, 270);
            this.cmb_legajo_vendedor.Name = "cmb_legajo_vendedor";
            this.cmb_legajo_vendedor.Pp_Conseleccion = false;
            this.cmb_legajo_vendedor.Pp_MensajeError = null;
            this.cmb_legajo_vendedor.Pp_NombreCampo = null;
            this.cmb_legajo_vendedor.Pp_Validable = false;
            this.cmb_legajo_vendedor.Size = new System.Drawing.Size(169, 28);
            this.cmb_legajo_vendedor.TabIndex = 2;
            // 
            // cmb_cuit_cliente
            // 
            this.cmb_cuit_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_cuit_cliente.FormattingEnabled = true;
            this.cmb_cuit_cliente.Location = new System.Drawing.Point(214, 140);
            this.cmb_cuit_cliente.Name = "cmb_cuit_cliente";
            this.cmb_cuit_cliente.Pp_Conseleccion = false;
            this.cmb_cuit_cliente.Pp_MensajeError = null;
            this.cmb_cuit_cliente.Pp_NombreCampo = null;
            this.cmb_cuit_cliente.Pp_Validable = false;
            this.cmb_cuit_cliente.Size = new System.Drawing.Size(169, 28);
            this.cmb_cuit_cliente.TabIndex = 2;
            this.cmb_cuit_cliente.SelectionChangeCommitted += new System.EventHandler(this.cmb_cuit_cliente_SelectionChangeCommitted);
            this.cmb_cuit_cliente.SelectedValueChanged += new System.EventHandler(this.cmb_cuit_cliente_SelectedValueChanged);
            // 
            // cmb_id_tipo_factura
            // 
            this.cmb_id_tipo_factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_id_tipo_factura.FormattingEnabled = true;
            this.cmb_id_tipo_factura.Location = new System.Drawing.Point(214, 106);
            this.cmb_id_tipo_factura.Name = "cmb_id_tipo_factura";
            this.cmb_id_tipo_factura.Pp_Conseleccion = false;
            this.cmb_id_tipo_factura.Pp_MensajeError = null;
            this.cmb_id_tipo_factura.Pp_NombreCampo = null;
            this.cmb_id_tipo_factura.Pp_Validable = false;
            this.cmb_id_tipo_factura.Size = new System.Drawing.Size(169, 28);
            this.cmb_id_tipo_factura.TabIndex = 1;
            this.cmb_id_tipo_factura.SelectionChangeCommitted += new System.EventHandler(this.cmb_id_tipo_factura_SelectionChangeCommitted);
            this.cmb_id_tipo_factura.SelectedValueChanged += new System.EventHandler(this.cmb_id_tipo_factura_SelectedValueChanged);
            // 
            // grid_equipos_especiales
            // 
            this.grid_equipos_especiales.AllowUserToAddRows = false;
            this.grid_equipos_especiales.AllowUserToDeleteRows = false;
            this.grid_equipos_especiales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_equipos_especiales.Location = new System.Drawing.Point(12, 533);
            this.grid_equipos_especiales.Name = "grid_equipos_especiales";
            this.grid_equipos_especiales.ReadOnly = true;
            this.grid_equipos_especiales.Size = new System.Drawing.Size(457, 150);
            this.grid_equipos_especiales.TabIndex = 0;
            this.grid_equipos_especiales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_equipos_especiales_CellDoubleClick);
            // 
            // grid_equipos
            // 
            this.grid_equipos.AllowUserToAddRows = false;
            this.grid_equipos.AllowUserToDeleteRows = false;
            this.grid_equipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_equipos.Location = new System.Drawing.Point(497, 533);
            this.grid_equipos.Name = "grid_equipos";
            this.grid_equipos.ReadOnly = true;
            this.grid_equipos.Size = new System.Drawing.Size(457, 150);
            this.grid_equipos.TabIndex = 0;
            this.grid_equipos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_equipos_CellDoubleClick);
            // 
            // grid_articulos
            // 
            this.grid_articulos.AllowUserToAddRows = false;
            this.grid_articulos.AllowUserToDeleteRows = false;
            this.grid_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_articulos.Location = new System.Drawing.Point(497, 208);
            this.grid_articulos.Name = "grid_articulos";
            this.grid_articulos.ReadOnly = true;
            this.grid_articulos.Size = new System.Drawing.Size(457, 150);
            this.grid_articulos.TabIndex = 0;
            this.grid_articulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_articulos_CellDoubleClick);
            // 
            // Frm_Alta_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 741);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txt_cantidad_articulo);
            this.Controls.Add(this.txt_precio_mayorista_equipos_especiales);
            this.Controls.Add(this.txt_precio_mayorista_equipos);
            this.Controls.Add(this.txt_precio_mayorista_articulo);
            this.Controls.Add(this.txt_descripcion_equipo_especial);
            this.Controls.Add(this.txt_descripcion_articulo);
            this.Controls.Add(this.txt_precio_minorista_equipos);
            this.Controls.Add(this.txt_precio_minorista_articulo);
            this.Controls.Add(this.btn_agregar_articulos);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmb_equipos_especiales);
            this.Controls.Add(this.cmb_equipos);
            this.Controls.Add(this.cmb_nombre_articulo);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.txt_numero_factura);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_agregar_equipos_especiales);
            this.Controls.Add(this.btn_agregar_equipos);
            this.Controls.Add(this.txt_cantidad_equipos_especiales);
            this.Controls.Add(this.txt_cantidad_equipos);
            this.Controls.Add(this.cmb_id_forma_pago);
            this.Controls.Add(this.cmb_legajo_vendedor);
            this.Controls.Add(this.cmb_cuit_cliente);
            this.Controls.Add(this.cmb_id_tipo_factura);
            this.Controls.Add(this.grid_equipos_especiales);
            this.Controls.Add(this.grid_equipos);
            this.Controls.Add(this.grid_articulos);
            this.Name = "Frm_Alta_Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Venta";
            this.Load += new System.EventHandler(this.Frm_Alta_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_equipos_especiales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_equipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_articulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.Grid01 grid_articulos;
        private Clases.ComboBox01 cmb_id_tipo_factura;
        private Clases.ComboBox01 cmb_cuit_cliente;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Clases.ComboBox01 cmb_legajo_vendedor;
        private Clases.ComboBox01 cmb_id_forma_pago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txt_fecha;
        private System.Windows.Forms.TextBox txt_numero_factura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txt_cantidad_articulo;
        private System.Windows.Forms.TextBox txt_precio_mayorista_articulo;
        private System.Windows.Forms.TextBox txt_descripcion_articulo;
        private System.Windows.Forms.TextBox txt_precio_minorista_articulo;
        private System.Windows.Forms.Button btn_agregar_articulos;
        private System.Windows.Forms.Label label11;
        private Clases.ComboBox01 cmb_nombre_articulo;
        private Clases.TextBox01 txt_cantidad_equipos;
        private System.Windows.Forms.Button btn_agregar_equipos;
        private Clases.Grid01 grid_equipos;
        private Clases.ComboBox01 cmb_equipos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_precio_mayorista_equipos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_precio_minorista_equipos;
        private System.Windows.Forms.Label label13;
        private Clases.Grid01 grid_equipos_especiales;
        private Clases.TextBox01 txt_cantidad_equipos_especiales;
        private System.Windows.Forms.Button btn_agregar_equipos_especiales;
        private Clases.ComboBox01 cmb_equipos_especiales;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_precio_mayorista_equipos_especiales;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_descripcion_equipo_especial;
        private System.Windows.Forms.Label label20;
    }
}