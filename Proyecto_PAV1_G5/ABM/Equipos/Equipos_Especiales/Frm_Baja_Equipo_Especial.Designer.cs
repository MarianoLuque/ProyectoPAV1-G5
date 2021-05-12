namespace Proyecto_PAV1_G5.ABM.Equipos.Equipos_Especiales
{
    partial class Frm_Baja_Equipo_Especial
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
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nombre_Equipo_Especial = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_Precio_Equipo_Especial = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_Descripcion_Equipo_Especial = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_Cuit_Cliente_Equipo_Especial = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_Codigo_Equipo_Especial = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(300, 195);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 25);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(142, 195);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 25);
            this.btn_Aceptar.TabIndex = 5;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nombre Equipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cuit Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Codigo";
            // 
            // txt_Nombre_Equipo_Especial
            // 
            this.txt_Nombre_Equipo_Especial.Location = new System.Drawing.Point(142, 142);
            this.txt_Nombre_Equipo_Especial.Name = "txt_Nombre_Equipo_Especial";
            this.txt_Nombre_Equipo_Especial.Pp_campo = "nombre_equipo_especial";
            this.txt_Nombre_Equipo_Especial.Pp_MensajeError = null;
            this.txt_Nombre_Equipo_Especial.Pp_Validable = true;
            this.txt_Nombre_Equipo_Especial.ReadOnly = true;
            this.txt_Nombre_Equipo_Especial.Size = new System.Drawing.Size(233, 20);
            this.txt_Nombre_Equipo_Especial.TabIndex = 4;
            // 
            // txt_Precio_Equipo_Especial
            // 
            this.txt_Precio_Equipo_Especial.Location = new System.Drawing.Point(142, 116);
            this.txt_Precio_Equipo_Especial.Name = "txt_Precio_Equipo_Especial";
            this.txt_Precio_Equipo_Especial.Pp_campo = "precio";
            this.txt_Precio_Equipo_Especial.Pp_MensajeError = null;
            this.txt_Precio_Equipo_Especial.Pp_Validable = true;
            this.txt_Precio_Equipo_Especial.ReadOnly = true;
            this.txt_Precio_Equipo_Especial.Size = new System.Drawing.Size(233, 20);
            this.txt_Precio_Equipo_Especial.TabIndex = 3;
            // 
            // txt_Descripcion_Equipo_Especial
            // 
            this.txt_Descripcion_Equipo_Especial.Location = new System.Drawing.Point(142, 90);
            this.txt_Descripcion_Equipo_Especial.Name = "txt_Descripcion_Equipo_Especial";
            this.txt_Descripcion_Equipo_Especial.Pp_campo = "descripcion";
            this.txt_Descripcion_Equipo_Especial.Pp_MensajeError = null;
            this.txt_Descripcion_Equipo_Especial.Pp_Validable = true;
            this.txt_Descripcion_Equipo_Especial.ReadOnly = true;
            this.txt_Descripcion_Equipo_Especial.Size = new System.Drawing.Size(233, 20);
            this.txt_Descripcion_Equipo_Especial.TabIndex = 2;
            // 
            // txt_Cuit_Cliente_Equipo_Especial
            // 
            this.txt_Cuit_Cliente_Equipo_Especial.Location = new System.Drawing.Point(142, 64);
            this.txt_Cuit_Cliente_Equipo_Especial.Name = "txt_Cuit_Cliente_Equipo_Especial";
            this.txt_Cuit_Cliente_Equipo_Especial.Pp_campo = "cuit_cliente";
            this.txt_Cuit_Cliente_Equipo_Especial.Pp_MensajeError = null;
            this.txt_Cuit_Cliente_Equipo_Especial.Pp_Validable = true;
            this.txt_Cuit_Cliente_Equipo_Especial.ReadOnly = true;
            this.txt_Cuit_Cliente_Equipo_Especial.Size = new System.Drawing.Size(233, 20);
            this.txt_Cuit_Cliente_Equipo_Especial.TabIndex = 1;
            // 
            // txt_Codigo_Equipo_Especial
            // 
            this.txt_Codigo_Equipo_Especial.Location = new System.Drawing.Point(142, 38);
            this.txt_Codigo_Equipo_Especial.Name = "txt_Codigo_Equipo_Especial";
            this.txt_Codigo_Equipo_Especial.Pp_campo = "codigo_equipo_especial";
            this.txt_Codigo_Equipo_Especial.Pp_MensajeError = null;
            this.txt_Codigo_Equipo_Especial.Pp_Validable = true;
            this.txt_Codigo_Equipo_Especial.ReadOnly = true;
            this.txt_Codigo_Equipo_Especial.Size = new System.Drawing.Size(233, 20);
            this.txt_Codigo_Equipo_Especial.TabIndex = 0;
            // 
            // Frm_Baja_Equipo_Especial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 260);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Nombre_Equipo_Especial);
            this.Controls.Add(this.txt_Precio_Equipo_Especial);
            this.Controls.Add(this.txt_Descripcion_Equipo_Especial);
            this.Controls.Add(this.txt_Cuit_Cliente_Equipo_Especial);
            this.Controls.Add(this.txt_Codigo_Equipo_Especial);
            this.Name = "Frm_Baja_Equipo_Especial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Equipo Especial";
            this.Load += new System.EventHandler(this.Frm_Baja_Equipo_Especial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 txt_Nombre_Equipo_Especial;
        private Clases.TextBox01 txt_Precio_Equipo_Especial;
        private Clases.TextBox01 txt_Descripcion_Equipo_Especial;
        private Clases.TextBox01 txt_Cuit_Cliente_Equipo_Especial;
        private Clases.TextBox01 txt_Codigo_Equipo_Especial;
    }
}