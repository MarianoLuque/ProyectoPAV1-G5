namespace Proyecto_PAV1_G5.ReportesyEstadisticas.Estadisticas.EstadisticasTita
{
    partial class Frm_Estadistica_Empleado_Ventas
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
            this.rp_empleados_ventas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_facturas = new System.Windows.Forms.RadioButton();
            this.rb_fecha = new System.Windows.Forms.RadioButton();
            this.txt_fecha = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_generar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rp_empleados_ventas
            // 
            this.rp_empleados_ventas.Location = new System.Drawing.Point(22, 89);
            this.rp_empleados_ventas.Name = "rp_empleados_ventas";
            this.rp_empleados_ventas.ServerReport.BearerToken = null;
            this.rp_empleados_ventas.Size = new System.Drawing.Size(995, 416);
            this.rp_empleados_ventas.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_facturas);
            this.groupBox1.Controls.Add(this.rb_fecha);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // rb_facturas
            // 
            this.rb_facturas.AutoSize = true;
            this.rb_facturas.Location = new System.Drawing.Point(182, 27);
            this.rb_facturas.Name = "rb_facturas";
            this.rb_facturas.Size = new System.Drawing.Size(162, 24);
            this.rb_facturas.TabIndex = 0;
            this.rb_facturas.TabStop = true;
            this.rb_facturas.Text = "Todas las Facturas";
            this.rb_facturas.UseVisualStyleBackColor = true;
            this.rb_facturas.CheckedChanged += new System.EventHandler(this.rb_facturas_CheckedChanged);
            // 
            // rb_fecha
            // 
            this.rb_fecha.AutoSize = true;
            this.rb_fecha.Location = new System.Drawing.Point(7, 26);
            this.rb_fecha.Name = "rb_fecha";
            this.rb_fecha.Size = new System.Drawing.Size(124, 24);
            this.rb_fecha.TabIndex = 0;
            this.rb_fecha.TabStop = true;
            this.rb_fecha.Text = "Aplicar Fecha";
            this.rb_fecha.UseVisualStyleBackColor = true;
            this.rb_fecha.CheckedChanged += new System.EventHandler(this.rb_fecha_CheckedChanged);
            // 
            // txt_fecha
            // 
            this.txt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha.Location = new System.Drawing.Point(487, 38);
            this.txt_fecha.Mask = "00/00/0000";
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(100, 26);
            this.txt_fecha.TabIndex = 1;
            this.txt_fecha.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(660, 41);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(78, 28);
            this.btn_limpiar.TabIndex = 3;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_generar
            // 
            this.btn_generar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar.Location = new System.Drawing.Point(755, 41);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(78, 28);
            this.btn_generar.TabIndex = 3;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // Frm_Estadistica_Empleado_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 517);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rp_empleados_ventas);
            this.Name = "Frm_Estadistica_Empleado_Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Estadistica_Empleado_Ventas";
            this.Load += new System.EventHandler(this.Frm_Estadistica_Empleado_Ventas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rp_empleados_ventas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_facturas;
        private System.Windows.Forms.RadioButton rb_fecha;
        private System.Windows.Forms.MaskedTextBox txt_fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_generar;
    }
}