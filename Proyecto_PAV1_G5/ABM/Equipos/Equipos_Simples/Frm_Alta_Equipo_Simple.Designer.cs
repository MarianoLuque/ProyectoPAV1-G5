namespace Proyecto_PAV1_G5.ABM.Equipos.Equipos_Simples
{
    partial class Frm_Alta_Equipo_Simple
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Precio_Minorista = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_Nombre_Equipo = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_Precio_Mayorista = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(339, 187);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(83, 28);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Location = new System.Drawing.Point(189, 187);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 28);
            this.btn_Aceptar.TabIndex = 3;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Precio Minorista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Precio Mayorista";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nombre Equipo";
            // 
            // txt_Precio_Minorista
            // 
            this.txt_Precio_Minorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Precio_Minorista.Location = new System.Drawing.Point(189, 74);
            this.txt_Precio_Minorista.Name = "txt_Precio_Minorista";
            this.txt_Precio_Minorista.Pp_campo = "precio_minorista";
            this.txt_Precio_Minorista.Pp_MensajeError = "Falta cargar el precio minorista";
            this.txt_Precio_Minorista.Pp_Validable = true;
            this.txt_Precio_Minorista.Size = new System.Drawing.Size(233, 26);
            this.txt_Precio_Minorista.TabIndex = 1;
            // 
            // txt_Nombre_Equipo
            // 
            this.txt_Nombre_Equipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre_Equipo.Location = new System.Drawing.Point(189, 122);
            this.txt_Nombre_Equipo.Name = "txt_Nombre_Equipo";
            this.txt_Nombre_Equipo.Pp_campo = "nombre_equipo";
            this.txt_Nombre_Equipo.Pp_MensajeError = "Falta cargar el nombre del equipo";
            this.txt_Nombre_Equipo.Pp_Validable = true;
            this.txt_Nombre_Equipo.Size = new System.Drawing.Size(233, 26);
            this.txt_Nombre_Equipo.TabIndex = 2;
            // 
            // txt_Precio_Mayorista
            // 
            this.txt_Precio_Mayorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Precio_Mayorista.Location = new System.Drawing.Point(189, 26);
            this.txt_Precio_Mayorista.Name = "txt_Precio_Mayorista";
            this.txt_Precio_Mayorista.Pp_campo = "precio_mayorista";
            this.txt_Precio_Mayorista.Pp_MensajeError = "Falta cargar el precio mayorista";
            this.txt_Precio_Mayorista.Pp_Validable = true;
            this.txt_Precio_Mayorista.Size = new System.Drawing.Size(233, 26);
            this.txt_Precio_Mayorista.TabIndex = 0;
            // 
            // Frm_Alta_Equipo_Simple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 260);
            this.ControlBox = false;
            this.Controls.Add(this.txt_Precio_Minorista);
            this.Controls.Add(this.txt_Nombre_Equipo);
            this.Controls.Add(this.txt_Precio_Mayorista);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Name = "Frm_Alta_Equipo_Simple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGREGAR EQUIPO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Clases.TextBox01 txt_Nombre_Equipo;
        private Clases.TextBox01 txt_Precio_Mayorista;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Clases.TextBox01 txt_Precio_Minorista;
    }
}