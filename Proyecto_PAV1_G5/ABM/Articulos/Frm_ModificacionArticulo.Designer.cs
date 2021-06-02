namespace Proyecto_PAV1_G5.ABM.Articulos
{
    partial class Frm_ModificacionArticulo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_plazopago = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_envio = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.cmb_pais = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.txt_stock = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_costomin = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_costomay = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_nombre = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_descripcion = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_codigo_articulo = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_rubros = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.cmb_proveedor = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.btn_aceptar.Location = new System.Drawing.Point(160, 461);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(99, 30);
            this.btn_aceptar.TabIndex = 20;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.btn_cancelar.Location = new System.Drawing.Point(286, 461);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(101, 30);
            this.btn_cancelar.TabIndex = 21;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(82, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(55, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(7, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad en Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(24, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Costo Mayorista";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(28, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Costo Minorista";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(108, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "País";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(21, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tiempo de Envío";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(36, 425);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Plazo de Pago";
            // 
            // txt_plazopago
            // 
            this.txt_plazopago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_plazopago.Location = new System.Drawing.Point(160, 422);
            this.txt_plazopago.Margin = new System.Windows.Forms.Padding(5);
            this.txt_plazopago.Name = "txt_plazopago";
            this.txt_plazopago.Pp_campo = "plazo_pago";
            this.txt_plazopago.Pp_MensajeError = null;
            this.txt_plazopago.Pp_Validable = true;
            this.txt_plazopago.Size = new System.Drawing.Size(232, 26);
            this.txt_plazopago.TabIndex = 19;
            // 
            // txt_envio
            // 
            this.txt_envio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_envio.Location = new System.Drawing.Point(160, 387);
            this.txt_envio.Margin = new System.Windows.Forms.Padding(5);
            this.txt_envio.Name = "txt_envio";
            this.txt_envio.Pp_campo = "tiempo_envio";
            this.txt_envio.Pp_MensajeError = null;
            this.txt_envio.Pp_Validable = true;
            this.txt_envio.Size = new System.Drawing.Size(232, 26);
            this.txt_envio.TabIndex = 17;
            // 
            // cmb_pais
            // 
            this.cmb_pais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_pais.FormattingEnabled = true;
            this.cmb_pais.Location = new System.Drawing.Point(158, 276);
            this.cmb_pais.Margin = new System.Windows.Forms.Padding(5);
            this.cmb_pais.Name = "cmb_pais";
            this.cmb_pais.Pp_Conseleccion = false;
            this.cmb_pais.Pp_MensajeError = null;
            this.cmb_pais.Pp_NombreCampo = "id_pais";
            this.cmb_pais.Pp_Validable = true;
            this.cmb_pais.Size = new System.Drawing.Size(233, 28);
            this.cmb_pais.TabIndex = 13;
            // 
            // txt_stock
            // 
            this.txt_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_stock.Location = new System.Drawing.Point(158, 171);
            this.txt_stock.Margin = new System.Windows.Forms.Padding(5);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Pp_campo = "cantidad_stock";
            this.txt_stock.Pp_MensajeError = null;
            this.txt_stock.Pp_Validable = true;
            this.txt_stock.Size = new System.Drawing.Size(233, 26);
            this.txt_stock.TabIndex = 7;
            // 
            // txt_costomin
            // 
            this.txt_costomin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_costomin.Location = new System.Drawing.Point(158, 241);
            this.txt_costomin.Margin = new System.Windows.Forms.Padding(5);
            this.txt_costomin.Name = "txt_costomin";
            this.txt_costomin.Pp_campo = "costo_minorista";
            this.txt_costomin.Pp_MensajeError = null;
            this.txt_costomin.Pp_Validable = true;
            this.txt_costomin.Size = new System.Drawing.Size(233, 26);
            this.txt_costomin.TabIndex = 11;
            // 
            // txt_costomay
            // 
            this.txt_costomay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_costomay.Location = new System.Drawing.Point(158, 206);
            this.txt_costomay.Margin = new System.Windows.Forms.Padding(5);
            this.txt_costomay.Name = "txt_costomay";
            this.txt_costomay.Pp_campo = "costo_mayorista";
            this.txt_costomay.Pp_MensajeError = null;
            this.txt_costomay.Pp_Validable = true;
            this.txt_costomay.Size = new System.Drawing.Size(233, 26);
            this.txt_costomay.TabIndex = 9;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_nombre.Location = new System.Drawing.Point(158, 52);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(5);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_campo = "nombre_articulo";
            this.txt_nombre.Pp_MensajeError = null;
            this.txt_nombre.Pp_Validable = true;
            this.txt_nombre.Size = new System.Drawing.Size(233, 26);
            this.txt_nombre.TabIndex = 3;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_descripcion.Location = new System.Drawing.Point(158, 87);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(5);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Pp_campo = "descripcion";
            this.txt_descripcion.Pp_MensajeError = null;
            this.txt_descripcion.Pp_Validable = true;
            this.txt_descripcion.Size = new System.Drawing.Size(233, 75);
            this.txt_descripcion.TabIndex = 5;
            // 
            // txt_codigo_articulo
            // 
            this.txt_codigo_articulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_articulo.Location = new System.Drawing.Point(159, 17);
            this.txt_codigo_articulo.Name = "txt_codigo_articulo";
            this.txt_codigo_articulo.Pp_campo = "codigo_articulo";
            this.txt_codigo_articulo.Pp_MensajeError = null;
            this.txt_codigo_articulo.Pp_Validable = false;
            this.txt_codigo_articulo.ReadOnly = true;
            this.txt_codigo_articulo.Size = new System.Drawing.Size(233, 26);
            this.txt_codigo_articulo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(33, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo articulo";
            // 
            // cmb_rubros
            // 
            this.cmb_rubros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_rubros.FormattingEnabled = true;
            this.cmb_rubros.Location = new System.Drawing.Point(158, 350);
            this.cmb_rubros.Name = "cmb_rubros";
            this.cmb_rubros.Pp_Conseleccion = false;
            this.cmb_rubros.Pp_MensajeError = null;
            this.cmb_rubros.Pp_NombreCampo = "id_rubro";
            this.cmb_rubros.Pp_Validable = true;
            this.cmb_rubros.Size = new System.Drawing.Size(234, 28);
            this.cmb_rubros.TabIndex = 24;
            // 
            // cmb_proveedor
            // 
            this.cmb_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_proveedor.FormattingEnabled = true;
            this.cmb_proveedor.Location = new System.Drawing.Point(158, 313);
            this.cmb_proveedor.Name = "cmb_proveedor";
            this.cmb_proveedor.Pp_Conseleccion = false;
            this.cmb_proveedor.Pp_MensajeError = null;
            this.cmb_proveedor.Pp_NombreCampo = "cuit_proveedor";
            this.cmb_proveedor.Pp_Validable = true;
            this.cmb_proveedor.Size = new System.Drawing.Size(233, 28);
            this.cmb_proveedor.TabIndex = 25;
            this.cmb_proveedor.SelectionChangeCommitted += new System.EventHandler(this.cmb_proveedor_SelectionChangeCommitted);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(94, 353);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Rubro";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(66, 316);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Proveedor";
            // 
            // Frm_ModificacionArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 503);
            this.Controls.Add(this.cmb_rubros);
            this.Controls.Add(this.cmb_proveedor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_codigo_articulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_plazopago);
            this.Controls.Add(this.txt_envio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
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
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_descripcion);
            this.MaximizeBox = false;
            this.Name = "Frm_ModificacionArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Artículo";
            this.Load += new System.EventHandler(this.Frm_ModificacionArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_aceptar;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Clases.TextBox01 txt_envio;
        private Clases.TextBox01 txt_plazopago;
        private Clases.TextBox01 txt_codigo_articulo;
        private System.Windows.Forms.Label label2;
        private Clases.ComboBox01 cmb_rubros;
        private Clases.ComboBox01 cmb_proveedor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}