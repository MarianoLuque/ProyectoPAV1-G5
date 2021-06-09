namespace Proyecto_PAV1_G5.Reportes_y_Estadísticas.Listados
{
    partial class Frm_ReporteVentas
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
            this.reporte_ventas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fechaDesde = new System.Windows.Forms.MaskedTextBox();
            this.txt_fechaHasta = new System.Windows.Forms.MaskedTextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_mayorista = new System.Windows.Forms.RadioButton();
            this.btn_minorista = new System.Windows.Forms.RadioButton();
            this.btn_todas = new System.Windows.Forms.RadioButton();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.cmb_clientes = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reporte_ventas
            // 
            this.reporte_ventas.Location = new System.Drawing.Point(12, 154);
            this.reporte_ventas.Name = "reporte_ventas";
            this.reporte_ventas.ServerReport.BearerToken = null;
            this.reporte_ventas.Size = new System.Drawing.Size(776, 313);
            this.reporte_ventas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(465, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasta";
            // 
            // txt_fechaDesde
            // 
            this.txt_fechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_fechaDesde.Location = new System.Drawing.Point(352, 81);
            this.txt_fechaDesde.Mask = "00/00/0000";
            this.txt_fechaDesde.Name = "txt_fechaDesde";
            this.txt_fechaDesde.Size = new System.Drawing.Size(88, 26);
            this.txt_fechaDesde.TabIndex = 6;
            this.txt_fechaDesde.ValidatingType = typeof(System.DateTime);
            // 
            // txt_fechaHasta
            // 
            this.txt_fechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_fechaHasta.Location = new System.Drawing.Point(528, 81);
            this.txt_fechaHasta.Mask = "00/00/0000";
            this.txt_fechaHasta.Name = "txt_fechaHasta";
            this.txt_fechaHasta.Size = new System.Drawing.Size(87, 26);
            this.txt_fechaHasta.TabIndex = 7;
            this.txt_fechaHasta.ValidatingType = typeof(System.DateTime);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_buscar.Location = new System.Drawing.Point(650, 104);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(97, 32);
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_todas);
            this.groupBox1.Controls.Add(this.btn_minorista);
            this.groupBox1.Controls.Add(this.btn_mayorista);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(77, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 136);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Factura";
            // 
            // btn_mayorista
            // 
            this.btn_mayorista.AutoSize = true;
            this.btn_mayorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_mayorista.Location = new System.Drawing.Point(6, 41);
            this.btn_mayorista.Name = "btn_mayorista";
            this.btn_mayorista.Size = new System.Drawing.Size(103, 24);
            this.btn_mayorista.TabIndex = 12;
            this.btn_mayorista.TabStop = true;
            this.btn_mayorista.Text = "Mayoristas";
            this.btn_mayorista.UseVisualStyleBackColor = true;
            this.btn_mayorista.CheckedChanged += new System.EventHandler(this.btn_mayorista_CheckedChanged_1);
            // 
            // btn_minorista
            // 
            this.btn_minorista.AutoSize = true;
            this.btn_minorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_minorista.Location = new System.Drawing.Point(6, 71);
            this.btn_minorista.Name = "btn_minorista";
            this.btn_minorista.Size = new System.Drawing.Size(99, 24);
            this.btn_minorista.TabIndex = 13;
            this.btn_minorista.TabStop = true;
            this.btn_minorista.Text = "Minoristas";
            this.btn_minorista.UseVisualStyleBackColor = true;
            this.btn_minorista.CheckedChanged += new System.EventHandler(this.btn_minorista_CheckedChanged);
            // 
            // btn_todas
            // 
            this.btn_todas.AutoSize = true;
            this.btn_todas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_todas.Location = new System.Drawing.Point(6, 100);
            this.btn_todas.Name = "btn_todas";
            this.btn_todas.Size = new System.Drawing.Size(71, 24);
            this.btn_todas.TabIndex = 14;
            this.btn_todas.TabStop = true;
            this.btn_todas.Text = "Todas";
            this.btn_todas.UseVisualStyleBackColor = true;
            this.btn_todas.CheckedChanged += new System.EventHandler(this.btn_todas_CheckedChanged_1);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_limpiar.Location = new System.Drawing.Point(650, 66);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(97, 32);
            this.btn_limpiar.TabIndex = 14;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // cmb_clientes
            // 
            this.cmb_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_clientes.FormattingEnabled = true;
            this.cmb_clientes.Location = new System.Drawing.Point(352, 34);
            this.cmb_clientes.Name = "cmb_clientes";
            this.cmb_clientes.Pp_Conseleccion = false;
            this.cmb_clientes.Pp_MensajeError = null;
            this.cmb_clientes.Pp_NombreCampo = null;
            this.cmb_clientes.Pp_Validable = false;
            this.cmb_clientes.Size = new System.Drawing.Size(263, 28);
            this.cmb_clientes.TabIndex = 3;
            this.cmb_clientes.TabStop = false;
            // 
            // Frm_ReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_fechaHasta);
            this.Controls.Add(this.txt_fechaDesde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_clientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reporte_ventas);
            this.Name = "Frm_ReporteVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ReporteVentas";
            this.Load += new System.EventHandler(this.Frm_ReporteVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporte_ventas;
        private System.Windows.Forms.Label label1;
        private Clases.ComboBox01 cmb_clientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txt_fechaDesde;
        private System.Windows.Forms.MaskedTextBox txt_fechaHasta;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btn_minorista;
        private System.Windows.Forms.RadioButton btn_mayorista;
        private System.Windows.Forms.RadioButton btn_todas;
        private System.Windows.Forms.Button btn_limpiar;
    }
}