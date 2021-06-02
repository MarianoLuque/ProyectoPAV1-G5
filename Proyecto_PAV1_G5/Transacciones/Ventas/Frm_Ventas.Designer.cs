namespace Proyecto_PAV1_G5.Transacciones.Ventas
{
    partial class Frm_Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ventas));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.txt_fecha_hasta = new System.Windows.Forms.MaskedTextBox();
            this.txt_fecha_desde = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmb_tipo_factura = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.cmb_cliente = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.grid_ventas = new Proyecto_PAV1_G5.Clases.Grid01();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ventas";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Location = new System.Drawing.Point(980, 477);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(100, 30);
            this.btn_Agregar.TabIndex = 13;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Equipo_Especial_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.Location = new System.Drawing.Point(728, 184);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(93, 30);
            this.btn_consultar.TabIndex = 19;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // txt_fecha_hasta
            // 
            this.txt_fecha_hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha_hasta.Location = new System.Drawing.Point(589, 186);
            this.txt_fecha_hasta.Mask = "00/00/0000";
            this.txt_fecha_hasta.Name = "txt_fecha_hasta";
            this.txt_fecha_hasta.Size = new System.Drawing.Size(100, 26);
            this.txt_fecha_hasta.TabIndex = 25;
            this.txt_fecha_hasta.ValidatingType = typeof(System.DateTime);
            // 
            // txt_fecha_desde
            // 
            this.txt_fecha_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha_desde.Location = new System.Drawing.Point(422, 186);
            this.txt_fecha_desde.Mask = "00/00/0000";
            this.txt_fecha_desde.Name = "txt_fecha_desde";
            this.txt_fecha_desde.Size = new System.Drawing.Size(100, 26);
            this.txt_fecha_desde.TabIndex = 26;
            this.txt_fecha_desde.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(548, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Fecha entre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(296, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tipo de Factura";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Proyecto_PAV1_G5.Properties.Resources._001__add;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(944, 477);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // cmb_tipo_factura
            // 
            this.cmb_tipo_factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo_factura.FormattingEnabled = true;
            this.cmb_tipo_factura.Location = new System.Drawing.Point(422, 118);
            this.cmb_tipo_factura.Name = "cmb_tipo_factura";
            this.cmb_tipo_factura.Pp_Conseleccion = false;
            this.cmb_tipo_factura.Pp_MensajeError = null;
            this.cmb_tipo_factura.Pp_NombreCampo = null;
            this.cmb_tipo_factura.Pp_Validable = false;
            this.cmb_tipo_factura.Size = new System.Drawing.Size(267, 28);
            this.cmb_tipo_factura.TabIndex = 27;
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_cliente.FormattingEnabled = true;
            this.cmb_cliente.Location = new System.Drawing.Point(422, 152);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.Pp_Conseleccion = false;
            this.cmb_cliente.Pp_MensajeError = null;
            this.cmb_cliente.Pp_NombreCampo = null;
            this.cmb_cliente.Pp_Validable = false;
            this.cmb_cliente.Size = new System.Drawing.Size(267, 28);
            this.cmb_cliente.TabIndex = 27;
            // 
            // grid_ventas
            // 
            this.grid_ventas.AllowUserToAddRows = false;
            this.grid_ventas.AllowUserToDeleteRows = false;
            this.grid_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_ventas.Location = new System.Drawing.Point(49, 230);
            this.grid_ventas.Name = "grid_ventas";
            this.grid_ventas.ReadOnly = true;
            this.grid_ventas.Size = new System.Drawing.Size(1031, 241);
            this.grid_ventas.TabIndex = 0;
            this.grid_ventas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_ventas_CellDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Proyecto_PAV1_G5.Properties.Resources._020_indicator;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(558, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 82);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 520);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_tipo_factura);
            this.Controls.Add(this.cmb_cliente);
            this.Controls.Add(this.txt_fecha_hasta);
            this.Controls.Add(this.txt_fecha_desde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_ventas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Frm_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.Grid01 grid_ventas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.MaskedTextBox txt_fecha_hasta;
        private System.Windows.Forms.MaskedTextBox txt_fecha_desde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Clases.ComboBox01 cmb_cliente;
        private System.Windows.Forms.Label label5;
        private Clases.ComboBox01 cmb_tipo_factura;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}