namespace Proyecto_PAV1_G5.ReportesyEstadísticas.Estadisticas.EstadisticasMariano
{
    partial class Frm_Estadistica_Forma_De_Pago
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
            this.reporte_forma_pago = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.rb_ambos = new System.Windows.Forms.RadioButton();
            this.rb_tipo_factura = new System.Windows.Forms.RadioButton();
            this.rb_fecha = new System.Windows.Forms.RadioButton();
            this.txt_fecha = new System.Windows.Forms.MaskedTextBox();
            this.cmb_tipo_factura = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reporte_forma_pago
            // 
            this.reporte_forma_pago.LocalReport.ReportEmbeddedResource = "Proyecto_PAV1_G5.ReportesyEstadísticas.Estadisticas.EstadisticasMariano.Estadisti" +
    "ca_Formas_De_Pago_Mas_Utilizadas.rdlc";
            this.reporte_forma_pago.Location = new System.Drawing.Point(12, 106);
            this.reporte_forma_pago.Name = "reporte_forma_pago";
            this.reporte_forma_pago.ServerReport.BearerToken = null;
            this.reporte_forma_pago.Size = new System.Drawing.Size(1099, 522);
            this.reporte_forma_pago.TabIndex = 0;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_limpiar.Location = new System.Drawing.Point(1036, 40);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 27);
            this.btn_limpiar.TabIndex = 33;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_calcular.Location = new System.Drawing.Point(1036, 72);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 28);
            this.btn_calcular.TabIndex = 32;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(663, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tipo Factura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(680, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mes y año";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_todos);
            this.groupBox1.Controls.Add(this.rb_ambos);
            this.groupBox1.Controls.Add(this.rb_tipo_factura);
            this.groupBox1.Controls.Add(this.rb_fecha);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 88);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Location = new System.Drawing.Point(247, 58);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(192, 24);
            this.rb_todos.TabIndex = 1;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "En Todas Las Facturas";
            this.rb_todos.UseVisualStyleBackColor = true;
            this.rb_todos.CheckedChanged += new System.EventHandler(this.rb_todos_CheckedChanged);
            // 
            // rb_ambos
            // 
            this.rb_ambos.AutoSize = true;
            this.rb_ambos.Location = new System.Drawing.Point(247, 29);
            this.rb_ambos.Name = "rb_ambos";
            this.rb_ambos.Size = new System.Drawing.Size(220, 24);
            this.rb_ambos.TabIndex = 1;
            this.rb_ambos.TabStop = true;
            this.rb_ambos.Text = "Mes, Año y Tipo de Factura";
            this.rb_ambos.UseVisualStyleBackColor = true;
            this.rb_ambos.CheckedChanged += new System.EventHandler(this.rb_ambos_CheckedChanged);
            // 
            // rb_tipo_factura
            // 
            this.rb_tipo_factura.AutoSize = true;
            this.rb_tipo_factura.Location = new System.Drawing.Point(6, 58);
            this.rb_tipo_factura.Name = "rb_tipo_factura";
            this.rb_tipo_factura.Size = new System.Drawing.Size(211, 24);
            this.rb_tipo_factura.TabIndex = 1;
            this.rb_tipo_factura.TabStop = true;
            this.rb_tipo_factura.Text = "Segun un Tipo de Factura";
            this.rb_tipo_factura.UseVisualStyleBackColor = true;
            this.rb_tipo_factura.CheckedChanged += new System.EventHandler(this.rb_tipo_factura_CheckedChanged);
            // 
            // rb_fecha
            // 
            this.rb_fecha.AutoSize = true;
            this.rb_fecha.Location = new System.Drawing.Point(6, 29);
            this.rb_fecha.Name = "rb_fecha";
            this.rb_fecha.Size = new System.Drawing.Size(196, 24);
            this.rb_fecha.TabIndex = 0;
            this.rb_fecha.TabStop = true;
            this.rb_fecha.Text = "Mes y año en especifico";
            this.rb_fecha.UseVisualStyleBackColor = true;
            this.rb_fecha.CheckedChanged += new System.EventHandler(this.rb_fecha_CheckedChanged);
            // 
            // txt_fecha
            // 
            this.txt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha.Location = new System.Drawing.Point(768, 40);
            this.txt_fecha.Mask = "00/00/0000";
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.ReadOnly = true;
            this.txt_fecha.Size = new System.Drawing.Size(100, 26);
            this.txt_fecha.TabIndex = 35;
            this.txt_fecha.ValidatingType = typeof(System.DateTime);
            // 
            // cmb_tipo_factura
            // 
            this.cmb_tipo_factura.Enabled = false;
            this.cmb_tipo_factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo_factura.FormattingEnabled = true;
            this.cmb_tipo_factura.Location = new System.Drawing.Point(768, 72);
            this.cmb_tipo_factura.Name = "cmb_tipo_factura";
            this.cmb_tipo_factura.Pp_Conseleccion = false;
            this.cmb_tipo_factura.Pp_MensajeError = null;
            this.cmb_tipo_factura.Pp_NombreCampo = null;
            this.cmb_tipo_factura.Pp_Validable = false;
            this.cmb_tipo_factura.Size = new System.Drawing.Size(100, 28);
            this.cmb_tipo_factura.TabIndex = 34;
            // 
            // Frm_Estadistica_Forma_De_Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 640);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.cmb_tipo_factura);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reporte_forma_pago);
            this.Name = "Frm_Estadistica_Forma_De_Pago";
            this.Text = "Frm_Estadistica_Forma_De_Pago";
            this.Load += new System.EventHandler(this.Frm_Estadistica_Forma_De_Pago_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporte_forma_pago;
        private Clases.ComboBox01 cmb_tipo_factura;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_tipo_factura;
        private System.Windows.Forms.RadioButton rb_fecha;
        private System.Windows.Forms.MaskedTextBox txt_fecha;
        private System.Windows.Forms.RadioButton rb_ambos;
        private System.Windows.Forms.RadioButton rb_todos;
    }
}