namespace Proyecto_PAV1_G5.ABM.Categoria
{
    partial class Frm_AltaCategoria
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
            this.txt_antiguedad = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_cantidad_compras = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_descuento = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_antiguedad
            // 
            this.txt_antiguedad.Location = new System.Drawing.Point(293, 42);
            this.txt_antiguedad.Name = "txt_antiguedad";
            this.txt_antiguedad.Pp_campo = "anios_antiguedad";
            this.txt_antiguedad.Pp_MensajeError = "Falta cargar los años de antigüedad";
            this.txt_antiguedad.Pp_Validable = true;
            this.txt_antiguedad.Size = new System.Drawing.Size(100, 26);
            this.txt_antiguedad.TabIndex = 0;
            // 
            // txt_cantidad_compras
            // 
            this.txt_cantidad_compras.Location = new System.Drawing.Point(293, 88);
            this.txt_cantidad_compras.Name = "txt_cantidad_compras";
            this.txt_cantidad_compras.Pp_campo = "cantidad_compras_historicas";
            this.txt_cantidad_compras.Pp_MensajeError = "Falta cargar la cantidad de compras historicas";
            this.txt_cantidad_compras.Pp_Validable = true;
            this.txt_cantidad_compras.Size = new System.Drawing.Size(100, 26);
            this.txt_cantidad_compras.TabIndex = 1;
            // 
            // txt_descuento
            // 
            this.txt_descuento.Location = new System.Drawing.Point(293, 135);
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Pp_campo = "descuento";
            this.txt_descuento.Pp_MensajeError = "Falta cargar el descuento de la categoria";
            this.txt_descuento.Pp_Validable = true;
            this.txt_descuento.Size = new System.Drawing.Size(100, 26);
            this.txt_descuento.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Años de antigüedad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad de compras históricas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descuento";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(159, 210);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(84, 30);
            this.btn_aceptar.TabIndex = 4;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(308, 210);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(85, 30);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Frm_AltaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 297);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_descuento);
            this.Controls.Add(this.txt_cantidad_compras);
            this.Controls.Add(this.txt_antiguedad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_AltaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Categoría";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.TextBox01 txt_antiguedad;
        private Clases.TextBox01 txt_cantidad_compras;
        private Clases.TextBox01 txt_descuento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}