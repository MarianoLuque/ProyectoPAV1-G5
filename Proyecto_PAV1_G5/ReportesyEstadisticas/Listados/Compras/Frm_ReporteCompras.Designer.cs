namespace Proyecto_PAV1_G5.Reportes_y_Estadísticas.Listados
{
    partial class Frm_ReporteCompras
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
            this.Rb02 = new System.Windows.Forms.RadioButton();
            this.Rb01 = new System.Windows.Forms.RadioButton();
            this.Check1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_proveedor = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reporte_ventas
            // 
            this.reporte_ventas.Location = new System.Drawing.Point(12, 120);
            this.reporte_ventas.Name = "reporte_ventas";
            this.reporte_ventas.ServerReport.BearerToken = null;
            this.reporte_ventas.Size = new System.Drawing.Size(776, 318);
            this.reporte_ventas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasta";
            // 
            // txt_fechaDesde
            // 
            this.txt_fechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_fechaDesde.Location = new System.Drawing.Point(84, 57);
            this.txt_fechaDesde.Mask = "00/00/0000";
            this.txt_fechaDesde.Name = "txt_fechaDesde";
            this.txt_fechaDesde.Size = new System.Drawing.Size(88, 26);
            this.txt_fechaDesde.TabIndex = 6;
            this.txt_fechaDesde.ValidatingType = typeof(System.DateTime);
            // 
            // txt_fechaHasta
            // 
            this.txt_fechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_fechaHasta.Location = new System.Drawing.Point(241, 57);
            this.txt_fechaHasta.Mask = "00/00/0000";
            this.txt_fechaHasta.Name = "txt_fechaHasta";
            this.txt_fechaHasta.Size = new System.Drawing.Size(87, 26);
            this.txt_fechaHasta.TabIndex = 7;
            this.txt_fechaHasta.ValidatingType = typeof(System.DateTime);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_buscar.Location = new System.Drawing.Point(696, 58);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 32);
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // Rb02
            // 
            this.Rb02.AutoSize = true;
            this.Rb02.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Rb02.Location = new System.Drawing.Point(17, 49);
            this.Rb02.Name = "Rb02";
            this.Rb02.Size = new System.Drawing.Size(128, 21);
            this.Rb02.TabIndex = 3;
            this.Rb02.TabStop = true;
            this.Rb02.Text = "Incluye Artículos";
            this.Rb02.UseVisualStyleBackColor = true;
            // 
            // Rb01
            // 
            this.Rb01.AutoSize = true;
            this.Rb01.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Rb01.Location = new System.Drawing.Point(17, 22);
            this.Rb01.Name = "Rb01";
            this.Rb01.Size = new System.Drawing.Size(109, 21);
            this.Rb01.TabIndex = 0;
            this.Rb01.TabStop = true;
            this.Rb01.Text = "Solo Remitos";
            this.Rb01.UseVisualStyleBackColor = true;
            // 
            // Check1
            // 
            this.Check1.AutoSize = true;
            this.Check1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Check1.Location = new System.Drawing.Point(261, 18);
            this.Check1.Name = "Check1";
            this.Check1.Size = new System.Drawing.Size(67, 21);
            this.Check1.TabIndex = 12;
            this.Check1.Text = "Todos";
            this.Check1.UseVisualStyleBackColor = true;
            this.Check1.CheckedChanged += new System.EventHandler(this.Check1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rb01);
            this.groupBox1.Controls.Add(this.Rb02);
            this.groupBox1.Location = new System.Drawing.Point(452, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 80);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Reporte";
            // 
            // cmb_proveedor
            // 
            this.cmb_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_proveedor.FormattingEnabled = true;
            this.cmb_proveedor.Location = new System.Drawing.Point(109, 13);
            this.cmb_proveedor.Name = "cmb_proveedor";
            this.cmb_proveedor.Pp_Conseleccion = false;
            this.cmb_proveedor.Pp_MensajeError = null;
            this.cmb_proveedor.Pp_NombreCampo = null;
            this.cmb_proveedor.Pp_Validable = false;
            this.cmb_proveedor.Size = new System.Drawing.Size(121, 28);
            this.cmb_proveedor.TabIndex = 14;
            // 
            // Frm_ReporteCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_proveedor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Check1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_fechaHasta);
            this.Controls.Add(this.txt_fechaDesde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reporte_ventas);
            this.Name = "Frm_ReporteCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Compras";
            this.Load += new System.EventHandler(this.Frm_ReporteCompras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporte_ventas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txt_fechaDesde;
        private System.Windows.Forms.MaskedTextBox txt_fechaHasta;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.RadioButton Rb02;
        private System.Windows.Forms.RadioButton Rb01;
        private System.Windows.Forms.CheckBox Check1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Clases.ComboBox01 cmb_proveedor;
    }
}