namespace Proyecto_PAV1_G5.ABM.FormasPago
{
    partial class Frm_BajaFormaPago
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
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_interes = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_descuento = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_nombre_forma_pago = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_id_forma_pago = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Interes";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(234, 211);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(93, 29);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(66, 211);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(93, 29);
            this.btn_aceptar.TabIndex = 4;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Descuento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Id Forma de Pago";
            // 
            // txt_interes
            // 
            this.txt_interes.Location = new System.Drawing.Point(166, 100);
            this.txt_interes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_interes.Name = "txt_interes";
            this.txt_interes.Pp_campo = "interes";
            this.txt_interes.Pp_MensajeError = "Falta cargar el interes de la Forma de Pago";
            this.txt_interes.Pp_Validable = true;
            this.txt_interes.ReadOnly = true;
            this.txt_interes.Size = new System.Drawing.Size(148, 26);
            this.txt_interes.TabIndex = 2;
            // 
            // txt_descuento
            // 
            this.txt_descuento.Location = new System.Drawing.Point(166, 147);
            this.txt_descuento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Pp_campo = "descuento";
            this.txt_descuento.Pp_MensajeError = "Falta cargar el descuento de la Forma de Pago";
            this.txt_descuento.Pp_Validable = true;
            this.txt_descuento.ReadOnly = true;
            this.txt_descuento.Size = new System.Drawing.Size(148, 26);
            this.txt_descuento.TabIndex = 3;
            // 
            // txt_nombre_forma_pago
            // 
            this.txt_nombre_forma_pago.Location = new System.Drawing.Point(166, 53);
            this.txt_nombre_forma_pago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_nombre_forma_pago.Name = "txt_nombre_forma_pago";
            this.txt_nombre_forma_pago.Pp_campo = "nombre_forma_pago";
            this.txt_nombre_forma_pago.Pp_MensajeError = "Falta cargar el Nombre de la Forma de Pago";
            this.txt_nombre_forma_pago.Pp_Validable = true;
            this.txt_nombre_forma_pago.ReadOnly = true;
            this.txt_nombre_forma_pago.Size = new System.Drawing.Size(148, 26);
            this.txt_nombre_forma_pago.TabIndex = 1;
            // 
            // txt_id_forma_pago
            // 
            this.txt_id_forma_pago.Location = new System.Drawing.Point(166, 6);
            this.txt_id_forma_pago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_id_forma_pago.Name = "txt_id_forma_pago";
            this.txt_id_forma_pago.Pp_campo = "id_forma_pago";
            this.txt_id_forma_pago.Pp_MensajeError = "Falta cargar el Id de la forma de pago";
            this.txt_id_forma_pago.Pp_Validable = true;
            this.txt_id_forma_pago.ReadOnly = true;
            this.txt_id_forma_pago.Size = new System.Drawing.Size(148, 26);
            this.txt_id_forma_pago.TabIndex = 0;
            // 
            // Frm_BajaFormaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 251);
            this.Controls.Add(this.txt_interes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_descuento);
            this.Controls.Add(this.txt_nombre_forma_pago);
            this.Controls.Add(this.txt_id_forma_pago);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_BajaFormaPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja Forma de Pago";
            this.Load += new System.EventHandler(this.Frm_BajaFormaPago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.TextBox01 txt_interes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 txt_descuento;
        private Clases.TextBox01 txt_nombre_forma_pago;
        private Clases.TextBox01 txt_id_forma_pago;
    }
}