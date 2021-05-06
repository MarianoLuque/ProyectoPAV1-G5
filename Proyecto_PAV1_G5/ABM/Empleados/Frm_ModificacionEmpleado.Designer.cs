namespace Proyecto_PAV1_G5.ABM.Empleados
{
    partial class Frm_ModificacionEmpleado
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
            this.txt_numdoc = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.cmb_tipodoc = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_legajo = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_telefono = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_nombre = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_apellido = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_fechaingreso = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.cmb_barrio = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_numdoc
            // 
            this.txt_numdoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_numdoc.Location = new System.Drawing.Point(236, 86);
            this.txt_numdoc.Margin = new System.Windows.Forms.Padding(5);
            this.txt_numdoc.Name = "txt_numdoc";
            this.txt_numdoc.Pp_campo = null;
            this.txt_numdoc.Pp_MensajeError = null;
            this.txt_numdoc.Pp_Validable = false;
            this.txt_numdoc.Size = new System.Drawing.Size(163, 26);
            this.txt_numdoc.TabIndex = 3;
            // 
            // cmb_tipodoc
            // 
            this.cmb_tipodoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_tipodoc.FormattingEnabled = true;
            this.cmb_tipodoc.Location = new System.Drawing.Point(236, 48);
            this.cmb_tipodoc.Margin = new System.Windows.Forms.Padding(5);
            this.cmb_tipodoc.Name = "cmb_tipodoc";
            this.cmb_tipodoc.Pp_Conseleccion = false;
            this.cmb_tipodoc.Pp_MensajeError = null;
            this.cmb_tipodoc.Pp_NombreCampo = null;
            this.cmb_tipodoc.Pp_Validable = false;
            this.cmb_tipodoc.Size = new System.Drawing.Size(163, 28);
            this.cmb_tipodoc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(92, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(44, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número de Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(171, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Legajo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(159, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(163, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(177, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Barrio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(159, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Teléfono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(94, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fecha de Ingreso";
            // 
            // txt_legajo
            // 
            this.txt_legajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_legajo.Location = new System.Drawing.Point(236, 303);
            this.txt_legajo.Margin = new System.Windows.Forms.Padding(5);
            this.txt_legajo.Name = "txt_legajo";
            this.txt_legajo.Pp_campo = "legajo";
            this.txt_legajo.Pp_MensajeError = null;
            this.txt_legajo.Pp_Validable = true;
            this.txt_legajo.Size = new System.Drawing.Size(163, 26);
            this.txt_legajo.TabIndex = 13;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_telefono.Location = new System.Drawing.Point(236, 232);
            this.txt_telefono.Margin = new System.Windows.Forms.Padding(5);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Pp_campo = null;
            this.txt_telefono.Pp_MensajeError = null;
            this.txt_telefono.Pp_Validable = false;
            this.txt_telefono.Size = new System.Drawing.Size(163, 26);
            this.txt_telefono.TabIndex = 11;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_nombre.Location = new System.Drawing.Point(236, 158);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(5);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_campo = null;
            this.txt_nombre.Pp_MensajeError = null;
            this.txt_nombre.Pp_Validable = false;
            this.txt_nombre.Size = new System.Drawing.Size(163, 26);
            this.txt_nombre.TabIndex = 7;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_apellido.Location = new System.Drawing.Point(236, 122);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(5);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Pp_campo = null;
            this.txt_apellido.Pp_MensajeError = null;
            this.txt_apellido.Pp_Validable = false;
            this.txt_apellido.Size = new System.Drawing.Size(163, 26);
            this.txt_apellido.TabIndex = 5;
            // 
            // txt_fechaingreso
            // 
            this.txt_fechaingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_fechaingreso.Location = new System.Drawing.Point(236, 339);
            this.txt_fechaingreso.Margin = new System.Windows.Forms.Padding(5);
            this.txt_fechaingreso.Name = "txt_fechaingreso";
            this.txt_fechaingreso.Pp_campo = null;
            this.txt_fechaingreso.Pp_MensajeError = null;
            this.txt_fechaingreso.Pp_Validable = false;
            this.txt_fechaingreso.Size = new System.Drawing.Size(163, 26);
            this.txt_fechaingreso.TabIndex = 15;
            // 
            // cmb_barrio
            // 
            this.cmb_barrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_barrio.FormattingEnabled = true;
            this.cmb_barrio.Location = new System.Drawing.Point(236, 194);
            this.cmb_barrio.Margin = new System.Windows.Forms.Padding(5);
            this.cmb_barrio.Name = "cmb_barrio";
            this.cmb_barrio.Pp_Conseleccion = false;
            this.cmb_barrio.Pp_MensajeError = null;
            this.cmb_barrio.Pp_NombreCampo = null;
            this.cmb_barrio.Pp_Validable = false;
            this.cmb_barrio.Size = new System.Drawing.Size(163, 28);
            this.cmb_barrio.TabIndex = 9;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_aceptar.Location = new System.Drawing.Point(131, 374);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(89, 32);
            this.btn_aceptar.TabIndex = 16;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click_1);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_cancelar.Location = new System.Drawing.Point(236, 373);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(89, 32);
            this.btn_cancelar.TabIndex = 17;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click_1);
            // 
            // Frm_ModificacionEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 409);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.cmb_barrio);
            this.Controls.Add(this.txt_fechaingreso);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_legajo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_tipodoc);
            this.Controls.Add(this.txt_numdoc);
            this.MaximizeBox = false;
            this.Name = "Frm_ModificacionEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Empleado";
            this.Load += new System.EventHandler(this.Frm_ModificacionEmpleado_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.TextBox01 txt_numdoc;
        private Clases.ComboBox01 cmb_tipodoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Clases.TextBox01 txt_legajo;
        private Clases.TextBox01 txt_telefono;
        private Clases.TextBox01 txt_nombre;
        private Clases.TextBox01 txt_apellido;
        private Clases.TextBox01 txt_fechaingreso;
        private Clases.ComboBox01 cmb_barrio;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}