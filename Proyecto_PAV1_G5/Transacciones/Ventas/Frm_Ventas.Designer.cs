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
            this.grid_ventas = new Proyecto_PAV1_G5.Clases.Grid01();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_Eliminar_Equipo_Especial = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_Modificar_Equipo_Especial = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Agregar_Equipo_Especial = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.txt_fecha_hasta = new System.Windows.Forms.MaskedTextBox();
            this.txt_fecha_desde = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_cliente = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_tipo_factura = new Proyecto_PAV1_G5.Clases.ComboBox01();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_ventas
            // 
            this.grid_ventas.AllowUserToAddRows = false;
            this.grid_ventas.AllowUserToDeleteRows = false;
            this.grid_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_ventas.Location = new System.Drawing.Point(44, 180);
            this.grid_ventas.Name = "grid_ventas";
            this.grid_ventas.ReadOnly = true;
            this.grid_ventas.Size = new System.Drawing.Size(1031, 241);
            this.grid_ventas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ventas";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Proyecto_PAV1_G5.Properties.Resources._003_delete;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(785, 447);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // btn_Eliminar_Equipo_Especial
            // 
            this.btn_Eliminar_Equipo_Especial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Eliminar_Equipo_Especial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar_Equipo_Especial.Location = new System.Drawing.Point(821, 447);
            this.btn_Eliminar_Equipo_Especial.Name = "btn_Eliminar_Equipo_Especial";
            this.btn_Eliminar_Equipo_Especial.Size = new System.Drawing.Size(100, 30);
            this.btn_Eliminar_Equipo_Especial.TabIndex = 15;
            this.btn_Eliminar_Equipo_Especial.Text = "Eliminar";
            this.btn_Eliminar_Equipo_Especial.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Proyecto_PAV1_G5.Properties.Resources._002_edit;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(482, 447);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // btn_Modificar_Equipo_Especial
            // 
            this.btn_Modificar_Equipo_Especial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Modificar_Equipo_Especial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar_Equipo_Especial.Location = new System.Drawing.Point(518, 447);
            this.btn_Modificar_Equipo_Especial.Name = "btn_Modificar_Equipo_Especial";
            this.btn_Modificar_Equipo_Especial.Size = new System.Drawing.Size(100, 30);
            this.btn_Modificar_Equipo_Especial.TabIndex = 14;
            this.btn_Modificar_Equipo_Especial.Text = "Editar";
            this.btn_Modificar_Equipo_Especial.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Proyecto_PAV1_G5.Properties.Resources._001__add;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(154, 447);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Agregar_Equipo_Especial
            // 
            this.btn_Agregar_Equipo_Especial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Agregar_Equipo_Especial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar_Equipo_Especial.Location = new System.Drawing.Point(190, 447);
            this.btn_Agregar_Equipo_Especial.Name = "btn_Agregar_Equipo_Especial";
            this.btn_Agregar_Equipo_Especial.Size = new System.Drawing.Size(100, 30);
            this.btn_Agregar_Equipo_Especial.TabIndex = 13;
            this.btn_Agregar_Equipo_Especial.Text = "Agregar";
            this.btn_Agregar_Equipo_Especial.UseVisualStyleBackColor = true;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.Location = new System.Drawing.Point(723, 134);
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
            this.txt_fecha_hasta.Location = new System.Drawing.Point(584, 136);
            this.txt_fecha_hasta.Mask = "00/00/0000";
            this.txt_fecha_hasta.Name = "txt_fecha_hasta";
            this.txt_fecha_hasta.Size = new System.Drawing.Size(100, 26);
            this.txt_fecha_hasta.TabIndex = 25;
            this.txt_fecha_hasta.ValidatingType = typeof(System.DateTime);
            // 
            // txt_fecha_desde
            // 
            this.txt_fecha_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha_desde.Location = new System.Drawing.Point(417, 136);
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
            this.label4.Location = new System.Drawing.Point(543, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Fecha entre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Cliente";
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_cliente.FormattingEnabled = true;
            this.cmb_cliente.Location = new System.Drawing.Point(417, 102);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.Pp_Conseleccion = false;
            this.cmb_cliente.Pp_MensajeError = null;
            this.cmb_cliente.Pp_NombreCampo = null;
            this.cmb_cliente.Pp_Validable = false;
            this.cmb_cliente.Size = new System.Drawing.Size(267, 28);
            this.cmb_cliente.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(291, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tipo de Factura";
            // 
            // cmb_tipo_factura
            // 
            this.cmb_tipo_factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo_factura.FormattingEnabled = true;
            this.cmb_tipo_factura.Location = new System.Drawing.Point(417, 68);
            this.cmb_tipo_factura.Name = "cmb_tipo_factura";
            this.cmb_tipo_factura.Pp_Conseleccion = false;
            this.cmb_tipo_factura.Pp_MensajeError = null;
            this.cmb_tipo_factura.Pp_NombreCampo = null;
            this.cmb_tipo_factura.Pp_Validable = false;
            this.cmb_tipo_factura.Size = new System.Drawing.Size(267, 28);
            this.cmb_tipo_factura.TabIndex = 27;
            // 
            // Frm_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 498);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_tipo_factura);
            this.Controls.Add(this.cmb_cliente);
            this.Controls.Add(this.txt_fecha_hasta);
            this.Controls.Add(this.txt_fecha_desde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btn_Eliminar_Equipo_Especial);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_Modificar_Equipo_Especial);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_Agregar_Equipo_Especial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_ventas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Frm_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.Grid01 grid_ventas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_Eliminar_Equipo_Especial;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_Modificar_Equipo_Especial;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_Agregar_Equipo_Especial;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.MaskedTextBox txt_fecha_hasta;
        private System.Windows.Forms.MaskedTextBox txt_fecha_desde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Clases.ComboBox01 cmb_cliente;
        private System.Windows.Forms.Label label5;
        private Clases.ComboBox01 cmb_tipo_factura;
    }
}