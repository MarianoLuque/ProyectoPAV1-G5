namespace Proyecto_PAV1_G5.ReportesyEstadisticas.Estadisticas.EstadisticasFede
{
    partial class Frm_Estadistica_Ventas_Cantidad
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
            this.txt_fecha = new System.Windows.Forms.MaskedTextBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.rb_fecha = new System.Windows.Forms.RadioButton();
            this.reporte_venta_cantidad = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_fecha
            // 
            this.txt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha.Location = new System.Drawing.Point(458, 40);
            this.txt_fecha.Mask = "00/00/0000";
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.ReadOnly = true;
            this.txt_fecha.Size = new System.Drawing.Size(100, 26);
            this.txt_fecha.TabIndex = 43;
            this.txt_fecha.ValidatingType = typeof(System.DateTime);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_limpiar.Location = new System.Drawing.Point(847, 40);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 27);
            this.btn_limpiar.TabIndex = 41;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_calcular.Location = new System.Drawing.Point(847, 72);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 28);
            this.btn_calcular.TabIndex = 40;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Mes y año";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_todos);
            this.groupBox1.Controls.Add(this.rb_fecha);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 68);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Location = new System.Drawing.Point(237, 30);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(89, 24);
            this.rb_todos.TabIndex = 1;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "Histórico";
            this.rb_todos.UseVisualStyleBackColor = true;
            this.rb_todos.CheckedChanged += new System.EventHandler(this.rb_todos_CheckedChanged);
            // 
            // rb_fecha
            // 
            this.rb_fecha.AutoSize = true;
            this.rb_fecha.Location = new System.Drawing.Point(18, 30);
            this.rb_fecha.Name = "rb_fecha";
            this.rb_fecha.Size = new System.Drawing.Size(196, 24);
            this.rb_fecha.TabIndex = 0;
            this.rb_fecha.TabStop = true;
            this.rb_fecha.Text = "Mes y año en especifico";
            this.rb_fecha.UseVisualStyleBackColor = true;
            this.rb_fecha.CheckedChanged += new System.EventHandler(this.rb_fecha_CheckedChanged);
            // 
            // reporte_venta_cantidad
            // 
            this.reporte_venta_cantidad.LocalReport.ReportEmbeddedResource = "Proyecto_PAV1_G5.ReportesyEstadísticas.Estadisticas.EstadisticasMariano.Estadisti" +
    "ca_Formas_De_Pago_Mas_Utilizadas.rdlc";
            this.reporte_venta_cantidad.Location = new System.Drawing.Point(12, 106);
            this.reporte_venta_cantidad.Name = "reporte_venta_cantidad";
            this.reporte_venta_cantidad.ServerReport.BearerToken = null;
            this.reporte_venta_cantidad.Size = new System.Drawing.Size(910, 513);
            this.reporte_venta_cantidad.TabIndex = 36;
            // 
            // Frm_Estadistica_Ventas_Cantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 641);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reporte_venta_cantidad);
            this.Name = "Frm_Estadistica_Ventas_Cantidad";
            this.Text = "Estadistica Ventas";
            this.Load += new System.EventHandler(this.Frm_Estadistica_Forma_De_Pago_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txt_fecha;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_todos;
        private System.Windows.Forms.RadioButton rb_fecha;
        private Microsoft.Reporting.WinForms.ReportViewer reporte_venta_cantidad;
    }
}