namespace Proyecto_PAV1_G5.Reportes_y_Estadísticas.Listados
{
    partial class Frm_ReporteEmpleados
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
            this.reporte_empleados = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fechaDesde = new System.Windows.Forms.MaskedTextBox();
            this.txt_fechaHasta = new System.Windows.Forms.MaskedTextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb01 = new System.Windows.Forms.RadioButton();
            this.rb02 = new System.Windows.Forms.RadioButton();
            this.rb03 = new System.Windows.Forms.RadioButton();
            this.rb04 = new System.Windows.Forms.RadioButton();
            this.cmb_tipo_documento = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.txt_patron_apellido = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_patron_nombre = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reporte_empleados
            // 
            this.reporte_empleados.Location = new System.Drawing.Point(12, 170);
            this.reporte_empleados.Name = "reporte_empleados";
            this.reporte_empleados.ServerReport.BearerToken = null;
            this.reporte_empleados.Size = new System.Drawing.Size(961, 409);
            this.reporte_empleados.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(660, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha de ingreso desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(664, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de ingreso hasta";
            // 
            // txt_fechaDesde
            // 
            this.txt_fechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_fechaDesde.Location = new System.Drawing.Point(846, 50);
            this.txt_fechaDesde.Mask = "00/00/0000";
            this.txt_fechaDesde.Name = "txt_fechaDesde";
            this.txt_fechaDesde.Size = new System.Drawing.Size(118, 26);
            this.txt_fechaDesde.TabIndex = 6;
            this.txt_fechaDesde.ValidatingType = typeof(System.DateTime);
            // 
            // txt_fechaHasta
            // 
            this.txt_fechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_fechaHasta.Location = new System.Drawing.Point(846, 89);
            this.txt_fechaHasta.Mask = "00/00/0000";
            this.txt_fechaHasta.Name = "txt_fechaHasta";
            this.txt_fechaHasta.Size = new System.Drawing.Size(118, 26);
            this.txt_fechaHasta.TabIndex = 7;
            this.txt_fechaHasta.ValidatingType = typeof(System.DateTime);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_buscar.Location = new System.Drawing.Point(848, 132);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(116, 32);
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_limpiar.Location = new System.Drawing.Point(713, 132);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(116, 32);
            this.btn_limpiar.TabIndex = 8;
            this.btn_limpiar.Text = "Limpiar Filtros";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(660, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tipo Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(354, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Apellido";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb02);
            this.groupBox1.Controls.Add(this.rb01);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 76);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patron nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb04);
            this.groupBox2.Controls.Add(this.rb03);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(358, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 79);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patron Apellido";
            // 
            // rb01
            // 
            this.rb01.AutoSize = true;
            this.rb01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb01.Location = new System.Drawing.Point(7, 25);
            this.rb01.Name = "rb01";
            this.rb01.Size = new System.Drawing.Size(132, 20);
            this.rb01.TabIndex = 0;
            this.rb01.TabStop = true;
            this.rb01.Text = "Que empiece con";
            this.rb01.UseVisualStyleBackColor = true;
            // 
            // rb02
            // 
            this.rb02.AutoSize = true;
            this.rb02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb02.Location = new System.Drawing.Point(7, 47);
            this.rb02.Name = "rb02";
            this.rb02.Size = new System.Drawing.Size(110, 20);
            this.rb02.TabIndex = 1;
            this.rb02.TabStop = true;
            this.rb02.Text = "Que contenga";
            this.rb02.UseVisualStyleBackColor = true;
            // 
            // rb03
            // 
            this.rb03.AutoSize = true;
            this.rb03.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb03.Location = new System.Drawing.Point(7, 26);
            this.rb03.Name = "rb03";
            this.rb03.Size = new System.Drawing.Size(132, 20);
            this.rb03.TabIndex = 0;
            this.rb03.TabStop = true;
            this.rb03.Text = "Que empiece con";
            this.rb03.UseVisualStyleBackColor = true;
            // 
            // rb04
            // 
            this.rb04.AutoSize = true;
            this.rb04.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb04.Location = new System.Drawing.Point(7, 47);
            this.rb04.Name = "rb04";
            this.rb04.Size = new System.Drawing.Size(110, 20);
            this.rb04.TabIndex = 1;
            this.rb04.TabStop = true;
            this.rb04.Text = "Que contenga";
            this.rb04.UseVisualStyleBackColor = true;
            // 
            // cmb_tipo_documento
            // 
            this.cmb_tipo_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo_documento.FormattingEnabled = true;
            this.cmb_tipo_documento.Location = new System.Drawing.Point(792, 10);
            this.cmb_tipo_documento.Name = "cmb_tipo_documento";
            this.cmb_tipo_documento.Pp_Conseleccion = false;
            this.cmb_tipo_documento.Pp_MensajeError = null;
            this.cmb_tipo_documento.Pp_NombreCampo = null;
            this.cmb_tipo_documento.Pp_Validable = false;
            this.cmb_tipo_documento.Size = new System.Drawing.Size(172, 28);
            this.cmb_tipo_documento.TabIndex = 3;
            this.cmb_tipo_documento.TabStop = false;
            // 
            // txt_patron_apellido
            // 
            this.txt_patron_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patron_apellido.Location = new System.Drawing.Point(425, 10);
            this.txt_patron_apellido.Name = "txt_patron_apellido";
            this.txt_patron_apellido.Pp_campo = null;
            this.txt_patron_apellido.Pp_MensajeError = null;
            this.txt_patron_apellido.Pp_Validable = false;
            this.txt_patron_apellido.Size = new System.Drawing.Size(196, 26);
            this.txt_patron_apellido.TabIndex = 9;
            // 
            // txt_patron_nombre
            // 
            this.txt_patron_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patron_nombre.Location = new System.Drawing.Point(95, 10);
            this.txt_patron_nombre.Name = "txt_patron_nombre";
            this.txt_patron_nombre.Pp_campo = null;
            this.txt_patron_nombre.Pp_MensajeError = null;
            this.txt_patron_nombre.Pp_Validable = false;
            this.txt_patron_nombre.Size = new System.Drawing.Size(196, 26);
            this.txt_patron_nombre.TabIndex = 9;
            // 
            // Frm_ReporteEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 591);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_tipo_documento);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_patron_apellido);
            this.Controls.Add(this.txt_patron_nombre);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_fechaHasta);
            this.Controls.Add(this.txt_fechaDesde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reporte_empleados);
            this.Name = "Frm_ReporteEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Empleados";
            this.Load += new System.EventHandler(this.Frm_ReporteEmpleados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporte_empleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txt_fechaDesde;
        private System.Windows.Forms.MaskedTextBox txt_fechaHasta;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_limpiar;
        private Clases.ComboBox01 cmb_tipo_documento;
        private System.Windows.Forms.Label label4;
        private Clases.TextBox01 txt_patron_nombre;
        private System.Windows.Forms.Label label5;
        private Clases.TextBox01 txt_patron_apellido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb02;
        private System.Windows.Forms.RadioButton rb01;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb04;
        private System.Windows.Forms.RadioButton rb03;
    }
}