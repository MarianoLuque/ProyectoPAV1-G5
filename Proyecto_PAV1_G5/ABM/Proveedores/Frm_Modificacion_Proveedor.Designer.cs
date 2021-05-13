namespace Proyecto_PAV1_G5.ABM.Proveedores
{
    partial class Frm_Modificacion_Proveedor
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
            this.txt_cuit_proveedor = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_razonSocial = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_legajoComprador = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_fechaInicioOperacion = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_telefono = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.cmb_barrio = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.txt_calle = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_nroCalle = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_cuit_proveedor
            // 
            this.txt_cuit_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cuit_proveedor.Location = new System.Drawing.Point(255, 45);
            this.txt_cuit_proveedor.Name = "txt_cuit_proveedor";
            this.txt_cuit_proveedor.Pp_campo = "cuit_proveedor";
            this.txt_cuit_proveedor.Pp_MensajeError = "Falta cargar el cuit del proveedor";
            this.txt_cuit_proveedor.Pp_Validable = true;
            this.txt_cuit_proveedor.Size = new System.Drawing.Size(242, 26);
            this.txt_cuit_proveedor.TabIndex = 0;
            // 
            // txt_razonSocial
            // 
            this.txt_razonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_razonSocial.Location = new System.Drawing.Point(255, 88);
            this.txt_razonSocial.Name = "txt_razonSocial";
            this.txt_razonSocial.Pp_campo = "razon_social";
            this.txt_razonSocial.Pp_MensajeError = "Falta cargar la razón social";
            this.txt_razonSocial.Pp_Validable = true;
            this.txt_razonSocial.Size = new System.Drawing.Size(242, 26);
            this.txt_razonSocial.TabIndex = 1;
            // 
            // txt_legajoComprador
            // 
            this.txt_legajoComprador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_legajoComprador.Location = new System.Drawing.Point(255, 131);
            this.txt_legajoComprador.Name = "txt_legajoComprador";
            this.txt_legajoComprador.Pp_campo = "legajo_comprador";
            this.txt_legajoComprador.Pp_MensajeError = "Falta cargar el legajo del comprador";
            this.txt_legajoComprador.Pp_Validable = true;
            this.txt_legajoComprador.Size = new System.Drawing.Size(242, 26);
            this.txt_legajoComprador.TabIndex = 2;
            // 
            // txt_fechaInicioOperacion
            // 
            this.txt_fechaInicioOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fechaInicioOperacion.Location = new System.Drawing.Point(255, 174);
            this.txt_fechaInicioOperacion.Name = "txt_fechaInicioOperacion";
            this.txt_fechaInicioOperacion.Pp_campo = "fecha_inicio_operacion";
            this.txt_fechaInicioOperacion.Pp_MensajeError = "Falta cargar la fecha de inicio de la operación";
            this.txt_fechaInicioOperacion.Pp_Validable = true;
            this.txt_fechaInicioOperacion.Size = new System.Drawing.Size(242, 26);
            this.txt_fechaInicioOperacion.TabIndex = 3;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(255, 217);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Pp_campo = "telefono";
            this.txt_telefono.Pp_MensajeError = "Falta cargar el teléfono";
            this.txt_telefono.Pp_Validable = true;
            this.txt_telefono.Size = new System.Drawing.Size(242, 26);
            this.txt_telefono.TabIndex = 4;
            // 
            // cmb_barrio
            // 
            this.cmb_barrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_barrio.FormattingEnabled = true;
            this.cmb_barrio.Location = new System.Drawing.Point(255, 260);
            this.cmb_barrio.Name = "cmb_barrio";
            this.cmb_barrio.Pp_Conseleccion = true;
            this.cmb_barrio.Pp_MensajeError = "Falta seleccionar el barrio";
            this.cmb_barrio.Pp_NombreCampo = "id_barrio";
            this.cmb_barrio.Pp_Validable = true;
            this.cmb_barrio.Size = new System.Drawing.Size(242, 28);
            this.cmb_barrio.TabIndex = 5;
            // 
            // txt_calle
            // 
            this.txt_calle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_calle.Location = new System.Drawing.Point(255, 303);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Pp_campo = "calle";
            this.txt_calle.Pp_MensajeError = "Falta cargar la calle";
            this.txt_calle.Pp_Validable = true;
            this.txt_calle.Size = new System.Drawing.Size(242, 26);
            this.txt_calle.TabIndex = 6;
            // 
            // txt_nroCalle
            // 
            this.txt_nroCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nroCalle.Location = new System.Drawing.Point(255, 346);
            this.txt_nroCalle.Name = "txt_nroCalle";
            this.txt_nroCalle.Pp_campo = "nro_calle";
            this.txt_nroCalle.Pp_MensajeError = "Falta cargar el número de calle";
            this.txt_nroCalle.Pp_Validable = true;
            this.txt_nroCalle.Size = new System.Drawing.Size(242, 26);
            this.txt_nroCalle.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "CUIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Razón Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Legajo Comprador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha de inicio de operación ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Teléfono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(186, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Calle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(107, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Número de calle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(179, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Barrio";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_aceptar.Location = new System.Drawing.Point(190, 410);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(92, 28);
            this.btn_aceptar.TabIndex = 16;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_cancelar.Location = new System.Drawing.Point(307, 410);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(92, 28);
            this.btn_cancelar.TabIndex = 17;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Frm_Modificacion_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 472);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nroCalle);
            this.Controls.Add(this.txt_calle);
            this.Controls.Add(this.cmb_barrio);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_fechaInicioOperacion);
            this.Controls.Add(this.txt_legajoComprador);
            this.Controls.Add(this.txt_razonSocial);
            this.Controls.Add(this.txt_cuit_proveedor);
            this.Name = "Frm_Modificacion_Proveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moficiación Proveedores";
            this.Load += new System.EventHandler(this.Frm_Modificacion_Proveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.TextBox01 txt_cuit_proveedor;
        private Clases.TextBox01 txt_razonSocial;
        private Clases.TextBox01 txt_legajoComprador;
        private Clases.TextBox01 txt_fechaInicioOperacion;
        private Clases.TextBox01 txt_telefono;
        private Clases.ComboBox01 cmb_barrio;
        private Clases.TextBox01 txt_calle;
        private Clases.TextBox01 txt_nroCalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}