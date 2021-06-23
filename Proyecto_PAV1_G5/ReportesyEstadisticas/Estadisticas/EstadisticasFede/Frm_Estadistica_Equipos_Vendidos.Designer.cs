namespace Proyecto_PAV1_G5.ReportesyEstadisticas.Estadisticas.EstadisticasFede
{
    partial class Frm_Estadistica_Equipos_Vendidos
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
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_ambos = new System.Windows.Forms.RadioButton();
            this.rb_tipo_factura = new System.Windows.Forms.RadioButton();
            this.rb_todo = new System.Windows.Forms.RadioButton();
            this.rb_fecha = new System.Windows.Forms.RadioButton();
            this.reporte_equipos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_simple = new System.Windows.Forms.RadioButton();
            this.rb_especial = new System.Windows.Forms.RadioButton();
            this.cmb_tipo_factura = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_limpiar.Location = new System.Drawing.Point(557, 130);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 32);
            this.btn_limpiar.TabIndex = 54;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_calcular.Location = new System.Drawing.Point(661, 130);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 32);
            this.btn_calcular.TabIndex = 53;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Tipo Factura";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_fecha.Location = new System.Drawing.Point(636, 42);
            this.txt_fecha.Mask = "00/00/0000";
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(100, 26);
            this.txt_fecha.TabIndex = 48;
            this.txt_fecha.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(547, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Mes y Año";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_ambos);
            this.groupBox1.Controls.Add(this.rb_tipo_factura);
            this.groupBox1.Controls.Add(this.rb_todo);
            this.groupBox1.Controls.Add(this.rb_fecha);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 97);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // rb_ambos
            // 
            this.rb_ambos.AutoSize = true;
            this.rb_ambos.Location = new System.Drawing.Point(251, 55);
            this.rb_ambos.Name = "rb_ambos";
            this.rb_ambos.Size = new System.Drawing.Size(220, 24);
            this.rb_ambos.TabIndex = 3;
            this.rb_ambos.TabStop = true;
            this.rb_ambos.Text = "Mes, Año y Tipo de Factura";
            this.rb_ambos.UseVisualStyleBackColor = true;
            this.rb_ambos.CheckedChanged += new System.EventHandler(this.rb_ambos_CheckedChanged);
            // 
            // rb_tipo_factura
            // 
            this.rb_tipo_factura.AutoSize = true;
            this.rb_tipo_factura.Location = new System.Drawing.Point(7, 58);
            this.rb_tipo_factura.Name = "rb_tipo_factura";
            this.rb_tipo_factura.Size = new System.Drawing.Size(166, 24);
            this.rb_tipo_factura.TabIndex = 2;
            this.rb_tipo_factura.TabStop = true;
            this.rb_tipo_factura.Text = "Por Tipo de Factura";
            this.rb_tipo_factura.UseVisualStyleBackColor = true;
            this.rb_tipo_factura.CheckedChanged += new System.EventHandler(this.rb_tipo_factura_CheckedChanged);
            // 
            // rb_todo
            // 
            this.rb_todo.AutoSize = true;
            this.rb_todo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rb_todo.Location = new System.Drawing.Point(251, 28);
            this.rb_todo.Name = "rb_todo";
            this.rb_todo.Size = new System.Drawing.Size(63, 24);
            this.rb_todo.TabIndex = 1;
            this.rb_todo.TabStop = true;
            this.rb_todo.Text = "Todo";
            this.rb_todo.UseVisualStyleBackColor = true;
            this.rb_todo.CheckedChanged += new System.EventHandler(this.rb_todo_CheckedChanged);
            // 
            // rb_fecha
            // 
            this.rb_fecha.AutoSize = true;
            this.rb_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rb_fecha.Location = new System.Drawing.Point(7, 28);
            this.rb_fecha.Name = "rb_fecha";
            this.rb_fecha.Size = new System.Drawing.Size(127, 24);
            this.rb_fecha.TabIndex = 0;
            this.rb_fecha.TabStop = true;
            this.rb_fecha.Text = "Por mes y año";
            this.rb_fecha.UseVisualStyleBackColor = true;
            this.rb_fecha.CheckedChanged += new System.EventHandler(this.rb_fecha_CheckedChanged);
            // 
            // reporte_equipos
            // 
            this.reporte_equipos.Location = new System.Drawing.Point(33, 187);
            this.reporte_equipos.Name = "reporte_equipos";
            this.reporte_equipos.ServerReport.BearerToken = null;
            this.reporte_equipos.Size = new System.Drawing.Size(762, 341);
            this.reporte_equipos.TabIndex = 47;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_simple);
            this.groupBox2.Controls.Add(this.rb_especial);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(26, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 58);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Equipo";
            // 
            // rb_simple
            // 
            this.rb_simple.AutoSize = true;
            this.rb_simple.Location = new System.Drawing.Point(7, 28);
            this.rb_simple.Name = "rb_simple";
            this.rb_simple.Size = new System.Drawing.Size(145, 24);
            this.rb_simple.TabIndex = 57;
            this.rb_simple.TabStop = true;
            this.rb_simple.Text = "Equipos Simples";
            this.rb_simple.UseVisualStyleBackColor = true;
            this.rb_simple.CheckedChanged += new System.EventHandler(this.rb_simple_CheckedChanged);
            // 
            // rb_especial
            // 
            this.rb_especial.AutoSize = true;
            this.rb_especial.Location = new System.Drawing.Point(251, 28);
            this.rb_especial.Name = "rb_especial";
            this.rb_especial.Size = new System.Drawing.Size(166, 24);
            this.rb_especial.TabIndex = 56;
            this.rb_especial.TabStop = true;
            this.rb_especial.Text = "Equipos Especiales";
            this.rb_especial.UseVisualStyleBackColor = true;
            this.rb_especial.CheckedChanged += new System.EventHandler(this.rb_especial_CheckedChanged);
            // 
            // cmb_tipo_factura
            // 
            this.cmb_tipo_factura.Enabled = false;
            this.cmb_tipo_factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo_factura.FormattingEnabled = true;
            this.cmb_tipo_factura.Location = new System.Drawing.Point(636, 81);
            this.cmb_tipo_factura.Name = "cmb_tipo_factura";
            this.cmb_tipo_factura.Pp_Conseleccion = false;
            this.cmb_tipo_factura.Pp_MensajeError = null;
            this.cmb_tipo_factura.Pp_NombreCampo = null;
            this.cmb_tipo_factura.Pp_Validable = false;
            this.cmb_tipo_factura.Size = new System.Drawing.Size(100, 28);
            this.cmb_tipo_factura.TabIndex = 52;
            // 
            // Frm_Estadistica_Equipos_Vendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 540);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.cmb_tipo_factura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reporte_equipos);
            this.Name = "Frm_Estadistica_Equipos_Vendidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Estadistica_Equipos_Vendidos";
            this.Load += new System.EventHandler(this.Frm_Estadistica_Equipos_Vendidos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_calcular;
        private Clases.ComboBox01 cmb_tipo_factura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_ambos;
        private System.Windows.Forms.RadioButton rb_tipo_factura;
        private System.Windows.Forms.RadioButton rb_todo;
        private System.Windows.Forms.RadioButton rb_fecha;
        private Microsoft.Reporting.WinForms.ReportViewer reporte_equipos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_simple;
        private System.Windows.Forms.RadioButton rb_especial;
    }
}