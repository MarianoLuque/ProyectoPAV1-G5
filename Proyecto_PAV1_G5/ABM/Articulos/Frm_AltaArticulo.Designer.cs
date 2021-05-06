namespace Proyecto_PAV1_G5.ABM.Articulos
{
    partial class Frm_AltaArticulo
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
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_plazopago = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_envio = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_cuit = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.cmb_pais = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.txt_stock = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_costomin = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_costomay = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_nombre = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_descripcion = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.btn_agregar.Location = new System.Drawing.Point(160, 448);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(99, 30);
            this.btn_agregar.TabIndex = 18;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.btn_cancelar.Location = new System.Drawing.Point(286, 448);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(101, 30);
            this.btn_cancelar.TabIndex = 19;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(86, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(60, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad en Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(25, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Costo Mayorista";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(29, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Costo Minorista";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(109, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "País";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(30, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "CUIT Proveedor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(30, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tiempo de Envío";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(41, 395);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Plazo de Pago";
            // 
            // txt_plazopago
            // 
            this.txt_plazopago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_plazopago.Location = new System.Drawing.Point(158, 392);
            this.txt_plazopago.Margin = new System.Windows.Forms.Padding(5);
            this.txt_plazopago.Name = "txt_plazopago";
            this.txt_plazopago.Pp_campo = "plazo_pago";
            this.txt_plazopago.Pp_MensajeError = null;
            this.txt_plazopago.Pp_Validable = true;
            this.txt_plazopago.Size = new System.Drawing.Size(100, 26);
            this.txt_plazopago.TabIndex = 17;
            // 
            // txt_envio
            // 
            this.txt_envio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_envio.Location = new System.Drawing.Point(158, 356);
            this.txt_envio.Margin = new System.Windows.Forms.Padding(5);
            this.txt_envio.Name = "txt_envio";
            this.txt_envio.Pp_campo = "tiempo_envio";
            this.txt_envio.Pp_MensajeError = null;
            this.txt_envio.Pp_Validable = true;
            this.txt_envio.Size = new System.Drawing.Size(229, 26);
            this.txt_envio.TabIndex = 15;
            // 
            // txt_cuit
            // 
            this.txt_cuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_cuit.Location = new System.Drawing.Point(159, 320);
            this.txt_cuit.Margin = new System.Windows.Forms.Padding(5);
            this.txt_cuit.Name = "txt_cuit";
            this.txt_cuit.Pp_campo = "cuit_proveedor";
            this.txt_cuit.Pp_MensajeError = null;
            this.txt_cuit.Pp_Validable = true;
            this.txt_cuit.Size = new System.Drawing.Size(100, 26);
            this.txt_cuit.TabIndex = 13;
            // 
            // cmb_pais
            // 
            this.cmb_pais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_pais.FormattingEnabled = true;
            this.cmb_pais.Location = new System.Drawing.Point(159, 253);
            this.cmb_pais.Margin = new System.Windows.Forms.Padding(5);
            this.cmb_pais.Name = "cmb_pais";
            this.cmb_pais.Pp_Conseleccion = false;
            this.cmb_pais.Pp_MensajeError = null;
            this.cmb_pais.Pp_NombreCampo = "id_pais";
            this.cmb_pais.Pp_Validable = true;
            this.cmb_pais.Size = new System.Drawing.Size(233, 28);
            this.cmb_pais.TabIndex = 11;
            // 
            // txt_stock
            // 
            this.txt_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_stock.Location = new System.Drawing.Point(159, 145);
            this.txt_stock.Margin = new System.Windows.Forms.Padding(5);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Pp_campo = "cantidad_stock";
            this.txt_stock.Pp_MensajeError = null;
            this.txt_stock.Pp_Validable = true;
            this.txt_stock.Size = new System.Drawing.Size(233, 26);
            this.txt_stock.TabIndex = 5;
            // 
            // txt_costomin
            // 
            this.txt_costomin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_costomin.Location = new System.Drawing.Point(159, 217);
            this.txt_costomin.Margin = new System.Windows.Forms.Padding(5);
            this.txt_costomin.Name = "txt_costomin";
            this.txt_costomin.Pp_campo = "costo_minorista";
            this.txt_costomin.Pp_MensajeError = null;
            this.txt_costomin.Pp_Validable = true;
            this.txt_costomin.Size = new System.Drawing.Size(233, 26);
            this.txt_costomin.TabIndex = 9;
            // 
            // txt_costomay
            // 
            this.txt_costomay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_costomay.Location = new System.Drawing.Point(159, 181);
            this.txt_costomay.Margin = new System.Windows.Forms.Padding(5);
            this.txt_costomay.Name = "txt_costomay";
            this.txt_costomay.Pp_campo = "costo_mayorista";
            this.txt_costomay.Pp_MensajeError = null;
            this.txt_costomay.Pp_Validable = true;
            this.txt_costomay.Size = new System.Drawing.Size(233, 26);
            this.txt_costomay.TabIndex = 7;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_nombre.Location = new System.Drawing.Point(159, 24);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(5);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_campo = "nombre_articulo";
            this.txt_nombre.Pp_MensajeError = null;
            this.txt_nombre.Pp_Validable = true;
            this.txt_nombre.Size = new System.Drawing.Size(233, 26);
            this.txt_nombre.TabIndex = 1;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_descripcion.Location = new System.Drawing.Point(159, 60);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(5);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Pp_campo = "descripcion";
            this.txt_descripcion.Pp_MensajeError = null;
            this.txt_descripcion.Pp_Validable = true;
            this.txt_descripcion.Size = new System.Drawing.Size(233, 75);
            this.txt_descripcion.TabIndex = 3;
            // 
            // Frm_AltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 493);
            this.Controls.Add(this.txt_plazopago);
            this.Controls.Add(this.txt_envio);
            this.Controls.Add(this.txt_cuit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_pais);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.txt_costomin);
            this.Controls.Add(this.txt_costomay);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_descripcion);
            this.MaximizeBox = false;
            this.Name = "Frm_AltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Artículo";
            this.Load += new System.EventHandler(this.Frm_AltaArticulo_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_cancelar;
        private Clases.TextBox01 txt_descripcion;
        private Clases.TextBox01 txt_nombre;
        private Clases.TextBox01 txt_costomay;
        private Clases.TextBox01 txt_costomin;
        private Clases.TextBox01 txt_stock;
        private Clases.ComboBox01 cmb_pais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Clases.TextBox01 txt_cuit;
        private Clases.TextBox01 txt_envio;
        private Clases.TextBox01 txt_plazopago;
    }
}