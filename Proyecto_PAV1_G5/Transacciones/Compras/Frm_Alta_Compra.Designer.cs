namespace Proyecto_PAV1_G5.Transacciones.Compras
{
    partial class Frm_Alta_Compra
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
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_descripcion_articulo = new System.Windows.Forms.TextBox();
            this.btn_agregar_articulos = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_nombre_articulo = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.grid_articulos = new Proyecto_PAV1_G5.Clases.Grid01();
            this.cmb_rubro = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.cmb_proveedor = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Location = new System.Drawing.Point(178, 490);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(81, 30);
            this.btn_aceptar.TabIndex = 4;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(427, 490);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(81, 30);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rubro";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(80, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "Descripción";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(174, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Cantidad";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(253, 280);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(87, 26);
            this.txt_cantidad.TabIndex = 30;
            // 
            // txt_descripcion_articulo
            // 
            this.txt_descripcion_articulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion_articulo.Location = new System.Drawing.Point(178, 221);
            this.txt_descripcion_articulo.Multiline = true;
            this.txt_descripcion_articulo.Name = "txt_descripcion_articulo";
            this.txt_descripcion_articulo.ReadOnly = true;
            this.txt_descripcion_articulo.Size = new System.Drawing.Size(330, 53);
            this.txt_descripcion_articulo.TabIndex = 32;
            // 
            // btn_agregar_articulos
            // 
            this.btn_agregar_articulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_articulos.Location = new System.Drawing.Point(421, 280);
            this.btn_agregar_articulos.Name = "btn_agregar_articulos";
            this.btn_agregar_articulos.Size = new System.Drawing.Size(87, 30);
            this.btn_agregar_articulos.TabIndex = 29;
            this.btn_agregar_articulos.Text = "Agregar";
            this.btn_agregar_articulos.UseVisualStyleBackColor = true;
            this.btn_agregar_articulos.Click += new System.EventHandler(this.btn_agregar_articulos_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(110, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Artículo";
            // 
            // cmb_nombre_articulo
            // 
            this.cmb_nombre_articulo.Enabled = false;
            this.cmb_nombre_articulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_nombre_articulo.FormattingEnabled = true;
            this.cmb_nombre_articulo.Location = new System.Drawing.Point(178, 187);
            this.cmb_nombre_articulo.Name = "cmb_nombre_articulo";
            this.cmb_nombre_articulo.Pp_Conseleccion = false;
            this.cmb_nombre_articulo.Pp_MensajeError = "";
            this.cmb_nombre_articulo.Pp_NombreCampo = null;
            this.cmb_nombre_articulo.Pp_Validable = false;
            this.cmb_nombre_articulo.Size = new System.Drawing.Size(330, 28);
            this.cmb_nombre_articulo.TabIndex = 27;
            this.cmb_nombre_articulo.SelectionChangeCommitted += new System.EventHandler(this.cmb_nombre_articulo_SelectionChangeCommitted);
            // 
            // grid_articulos
            // 
            this.grid_articulos.AllowUserToAddRows = false;
            this.grid_articulos.AllowUserToDeleteRows = false;
            this.grid_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_articulos.Location = new System.Drawing.Point(12, 316);
            this.grid_articulos.Name = "grid_articulos";
            this.grid_articulos.ReadOnly = true;
            this.grid_articulos.Size = new System.Drawing.Size(631, 150);
            this.grid_articulos.TabIndex = 26;
            // 
            // cmb_rubro
            // 
            this.cmb_rubro.Enabled = false;
            this.cmb_rubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_rubro.FormattingEnabled = true;
            this.cmb_rubro.Location = new System.Drawing.Point(178, 153);
            this.cmb_rubro.Name = "cmb_rubro";
            this.cmb_rubro.Pp_Conseleccion = false;
            this.cmb_rubro.Pp_MensajeError = null;
            this.cmb_rubro.Pp_NombreCampo = null;
            this.cmb_rubro.Pp_Validable = false;
            this.cmb_rubro.Size = new System.Drawing.Size(330, 28);
            this.cmb_rubro.TabIndex = 2;
            this.cmb_rubro.SelectionChangeCommitted += new System.EventHandler(this.cmb_rubro_SelectionChangeCommitted);
            // 
            // cmb_proveedor
            // 
            this.cmb_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_proveedor.FormattingEnabled = true;
            this.cmb_proveedor.Location = new System.Drawing.Point(178, 119);
            this.cmb_proveedor.Name = "cmb_proveedor";
            this.cmb_proveedor.Pp_Conseleccion = false;
            this.cmb_proveedor.Pp_MensajeError = null;
            this.cmb_proveedor.Pp_NombreCampo = null;
            this.cmb_proveedor.Pp_Validable = false;
            this.cmb_proveedor.Size = new System.Drawing.Size(330, 28);
            this.cmb_proveedor.TabIndex = 1;
            this.cmb_proveedor.SelectionChangeCommitted += new System.EventHandler(this.cmb_proveedor_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 37);
            this.label3.TabIndex = 38;
            this.label3.Text = "Nueva Compra";
            // 
            // Frm_Alta_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 535);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.txt_descripcion_articulo);
            this.Controls.Add(this.btn_agregar_articulos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmb_nombre_articulo);
            this.Controls.Add(this.grid_articulos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.cmb_rubro);
            this.Controls.Add(this.cmb_proveedor);
            this.MaximizeBox = false;
            this.Name = "Frm_Alta_Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Compra";
            this.Load += new System.EventHandler(this.Frm_Alta_Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_articulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Clases.ComboBox01 cmb_proveedor;
        private Clases.ComboBox01 cmb_rubro;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_descripcion_articulo;
        private System.Windows.Forms.Button btn_agregar_articulos;
        private System.Windows.Forms.Label label11;
        private Clases.ComboBox01 cmb_nombre_articulo;
        private Clases.Grid01 grid_articulos;
        private System.Windows.Forms.Label label3;
    }
}