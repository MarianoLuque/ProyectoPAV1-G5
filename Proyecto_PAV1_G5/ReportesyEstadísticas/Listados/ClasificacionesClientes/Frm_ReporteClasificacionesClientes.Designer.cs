namespace Proyecto_PAV1_G5.Reportes_y_Estadísticas.Listados
{
    partial class Frm_ReporteClasificacionesClientes
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
            this.check_Mayorista = new System.Windows.Forms.CheckBox();
            this.check_minorista = new System.Windows.Forms.CheckBox();
            this.cmb_clientes = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.SuspendLayout();
            // 
            // reporte_ventas
            // 
            this.reporte_ventas.Location = new System.Drawing.Point(12, 98);
            this.reporte_ventas.Name = "reporte_ventas";
            this.reporte_ventas.ServerReport.BearerToken = null;
            this.reporte_ventas.Size = new System.Drawing.Size(776, 340);
            this.reporte_ventas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(521, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasta";
            // 
            // txt_fechaDesde
            // 
            this.txt_fechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_fechaDesde.Location = new System.Drawing.Point(408, 19);
            this.txt_fechaDesde.Mask = "00/00/0000";
            this.txt_fechaDesde.Name = "txt_fechaDesde";
            this.txt_fechaDesde.Size = new System.Drawing.Size(88, 26);
            this.txt_fechaDesde.TabIndex = 6;
            this.txt_fechaDesde.ValidatingType = typeof(System.DateTime);
            // 
            // txt_fechaHasta
            // 
            this.txt_fechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_fechaHasta.Location = new System.Drawing.Point(584, 19);
            this.txt_fechaHasta.Mask = "00/00/0000";
            this.txt_fechaHasta.Name = "txt_fechaHasta";
            this.txt_fechaHasta.Size = new System.Drawing.Size(87, 26);
            this.txt_fechaHasta.TabIndex = 7;
            this.txt_fechaHasta.ValidatingType = typeof(System.DateTime);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_buscar.Location = new System.Drawing.Point(713, 60);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 32);
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // check_Mayorista
            // 
            this.check_Mayorista.AutoSize = true;
            this.check_Mayorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.check_Mayorista.Location = new System.Drawing.Point(49, 65);
            this.check_Mayorista.Name = "check_Mayorista";
            this.check_Mayorista.Size = new System.Drawing.Size(104, 24);
            this.check_Mayorista.TabIndex = 9;
            this.check_Mayorista.Text = "Mayoristas";
            this.check_Mayorista.UseVisualStyleBackColor = true;
            // 
            // check_minorista
            // 
            this.check_minorista.AutoSize = true;
            this.check_minorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.check_minorista.Location = new System.Drawing.Point(182, 65);
            this.check_minorista.Name = "check_minorista";
            this.check_minorista.Size = new System.Drawing.Size(100, 24);
            this.check_minorista.TabIndex = 10;
            this.check_minorista.Text = "Minoristas";
            this.check_minorista.UseVisualStyleBackColor = true;
            // 
            // cmb_clientes
            // 
            this.cmb_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_clientes.FormattingEnabled = true;
            this.cmb_clientes.Location = new System.Drawing.Point(109, 19);
            this.cmb_clientes.Name = "cmb_clientes";
            this.cmb_clientes.Pp_Conseleccion = false;
            this.cmb_clientes.Pp_MensajeError = null;
            this.cmb_clientes.Pp_NombreCampo = null;
            this.cmb_clientes.Pp_Validable = false;
            this.cmb_clientes.Size = new System.Drawing.Size(173, 28);
            this.cmb_clientes.TabIndex = 3;
            this.cmb_clientes.TabStop = false;
            // 
            // Frm_ReporteClasificacionesClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.check_minorista);
            this.Controls.Add(this.check_Mayorista);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_fechaHasta);
            this.Controls.Add(this.txt_fechaDesde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_clientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reporte_ventas);
            this.Name = "Frm_ReporteClasificacionesClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Clasificaciones Clientes";
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
        private System.Windows.Forms.CheckBox check_Mayorista;
        private System.Windows.Forms.CheckBox check_minorista;
    }
}