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
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.cmb_barrio = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.txt_contrasena = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_usuario = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_fechaingreso = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_apellido = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_nro_calle = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_calle = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_nombre = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_telefono = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.usuario = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_tipodoc = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.txt_numdoc = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_legajo = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_aceptar.Location = new System.Drawing.Point(98, 462);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(97, 30);
            this.btn_aceptar.TabIndex = 16;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_cancelar.Location = new System.Drawing.Point(257, 462);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(97, 30);
            this.btn_cancelar.TabIndex = 17;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // cmb_barrio
            // 
            this.cmb_barrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_barrio.FormattingEnabled = true;
            this.cmb_barrio.Location = new System.Drawing.Point(229, 197);
            this.cmb_barrio.Margin = new System.Windows.Forms.Padding(5);
            this.cmb_barrio.Name = "cmb_barrio";
            this.cmb_barrio.Pp_Conseleccion = false;
            this.cmb_barrio.Pp_MensajeError = "Falta cargar el barrio del empleado";
            this.cmb_barrio.Pp_NombreCampo = "id_barrio";
            this.cmb_barrio.Pp_Validable = true;
            this.cmb_barrio.Size = new System.Drawing.Size(163, 28);
            this.cmb_barrio.TabIndex = 31;
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_contrasena.Location = new System.Drawing.Point(229, 415);
            this.txt_contrasena.Margin = new System.Windows.Forms.Padding(5);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.Pp_campo = "contrasena";
            this.txt_contrasena.Pp_MensajeError = "Falta cargar la contraseña del empleado";
            this.txt_contrasena.Pp_Validable = true;
            this.txt_contrasena.Size = new System.Drawing.Size(163, 26);
            this.txt_contrasena.TabIndex = 39;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_usuario.Location = new System.Drawing.Point(229, 379);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(5);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Pp_campo = "usuario";
            this.txt_usuario.Pp_MensajeError = "Falta cargar el usuario del empleado";
            this.txt_usuario.Pp_Validable = true;
            this.txt_usuario.Size = new System.Drawing.Size(163, 26);
            this.txt_usuario.TabIndex = 38;
            // 
            // txt_fechaingreso
            // 
            this.txt_fechaingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_fechaingreso.Location = new System.Drawing.Point(229, 343);
            this.txt_fechaingreso.Margin = new System.Windows.Forms.Padding(5);
            this.txt_fechaingreso.Name = "txt_fechaingreso";
            this.txt_fechaingreso.Pp_campo = "fecha_ingreso";
            this.txt_fechaingreso.Pp_MensajeError = "Falta cargar la fecha de ingreso del empleado";
            this.txt_fechaingreso.Pp_Validable = true;
            this.txt_fechaingreso.Size = new System.Drawing.Size(163, 26);
            this.txt_fechaingreso.TabIndex = 37;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_apellido.Location = new System.Drawing.Point(229, 125);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(5);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Pp_campo = "apellido";
            this.txt_apellido.Pp_MensajeError = "Falta cargar el apellido del empleado";
            this.txt_apellido.Pp_Validable = true;
            this.txt_apellido.Size = new System.Drawing.Size(163, 26);
            this.txt_apellido.TabIndex = 23;
            // 
            // txt_nro_calle
            // 
            this.txt_nro_calle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_nro_calle.Location = new System.Drawing.Point(229, 271);
            this.txt_nro_calle.Margin = new System.Windows.Forms.Padding(5);
            this.txt_nro_calle.Name = "txt_nro_calle";
            this.txt_nro_calle.Pp_campo = "nro_calle";
            this.txt_nro_calle.Pp_MensajeError = "Falta cargar el numero de calle del empleado";
            this.txt_nro_calle.Pp_Validable = true;
            this.txt_nro_calle.Size = new System.Drawing.Size(163, 26);
            this.txt_nro_calle.TabIndex = 27;
            // 
            // txt_calle
            // 
            this.txt_calle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_calle.Location = new System.Drawing.Point(229, 235);
            this.txt_calle.Margin = new System.Windows.Forms.Padding(5);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Pp_campo = "calle";
            this.txt_calle.Pp_MensajeError = "Falta cargar la calle del empleado";
            this.txt_calle.Pp_Validable = true;
            this.txt_calle.Size = new System.Drawing.Size(163, 26);
            this.txt_calle.TabIndex = 28;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_nombre.Location = new System.Drawing.Point(229, 161);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(5);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_campo = "nombre";
            this.txt_nombre.Pp_MensajeError = "Falta cargar el nombre del empleado";
            this.txt_nombre.Pp_Validable = true;
            this.txt_nombre.Size = new System.Drawing.Size(163, 26);
            this.txt_nombre.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(123, 418);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "Contraseña";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_telefono.Location = new System.Drawing.Point(229, 307);
            this.txt_telefono.Margin = new System.Windows.Forms.Padding(5);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Pp_campo = "telefono";
            this.txt_telefono.Pp_MensajeError = "Falta cargar el telefono del empleado";
            this.txt_telefono.Pp_Validable = true;
            this.txt_telefono.Size = new System.Drawing.Size(163, 26);
            this.txt_telefono.TabIndex = 33;
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usuario.Location = new System.Drawing.Point(151, 382);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(64, 20);
            this.usuario.TabIndex = 36;
            this.usuario.Text = "Usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(82, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Fecha de Ingreso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(94, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Numero de calle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(146, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Teléfono";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(171, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Calle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(165, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Barrio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(152, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(152, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(42, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Número de Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(91, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tipo Documento";
            // 
            // cmb_tipodoc
            // 
            this.cmb_tipodoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_tipodoc.FormattingEnabled = true;
            this.cmb_tipodoc.Location = new System.Drawing.Point(229, 51);
            this.cmb_tipodoc.Margin = new System.Windows.Forms.Padding(5);
            this.cmb_tipodoc.Name = "cmb_tipodoc";
            this.cmb_tipodoc.Pp_Conseleccion = false;
            this.cmb_tipodoc.Pp_MensajeError = "Falta cargar el tipo de documento del empleado";
            this.cmb_tipodoc.Pp_NombreCampo = "id_tipo_documento";
            this.cmb_tipodoc.Pp_Validable = true;
            this.cmb_tipodoc.Size = new System.Drawing.Size(163, 28);
            this.cmb_tipodoc.TabIndex = 19;
            // 
            // txt_numdoc
            // 
            this.txt_numdoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_numdoc.Location = new System.Drawing.Point(229, 89);
            this.txt_numdoc.Margin = new System.Windows.Forms.Padding(5);
            this.txt_numdoc.Name = "txt_numdoc";
            this.txt_numdoc.Pp_campo = "nro_documento";
            this.txt_numdoc.Pp_MensajeError = "Falta cargar el numero de documento del empleado";
            this.txt_numdoc.Pp_Validable = true;
            this.txt_numdoc.Size = new System.Drawing.Size(163, 26);
            this.txt_numdoc.TabIndex = 21;
            // 
            // txt_legajo
            // 
            this.txt_legajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_legajo.Location = new System.Drawing.Point(229, 15);
            this.txt_legajo.Margin = new System.Windows.Forms.Padding(5);
            this.txt_legajo.Name = "txt_legajo";
            this.txt_legajo.Pp_campo = "legajo";
            this.txt_legajo.Pp_MensajeError = "Falta cargar el legajo del empleado";
            this.txt_legajo.Pp_Validable = true;
            this.txt_legajo.Size = new System.Drawing.Size(163, 26);
            this.txt_legajo.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(158, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Legajo";
            // 
            // Frm_ModificacionEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 507);
            this.ControlBox = false;
            this.Controls.Add(this.cmb_barrio);
            this.Controls.Add(this.txt_contrasena);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.txt_fechaingreso);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nro_calle);
            this.Controls.Add(this.txt_calle);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_tipodoc);
            this.Controls.Add(this.txt_legajo);
            this.Controls.Add(this.txt_numdoc);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.MaximizeBox = false;
            this.Name = "Frm_ModificacionEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Empleado";
            this.Load += new System.EventHandler(this.Frm_ModificacionEmpleado_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private Clases.ComboBox01 cmb_barrio;
        private Clases.TextBox01 txt_contrasena;
        private Clases.TextBox01 txt_usuario;
        private Clases.TextBox01 txt_fechaingreso;
        private Clases.TextBox01 txt_apellido;
        private Clases.TextBox01 txt_nro_calle;
        private Clases.TextBox01 txt_calle;
        private Clases.TextBox01 txt_nombre;
        private System.Windows.Forms.Label label12;
        private Clases.TextBox01 txt_telefono;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Clases.ComboBox01 cmb_tipodoc;
        private Clases.TextBox01 txt_numdoc;
        private Clases.TextBox01 txt_legajo;
        private System.Windows.Forms.Label label3;
    }
}