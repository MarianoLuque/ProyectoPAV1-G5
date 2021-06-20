namespace Proyecto_PAV1_G5.ReportesyEstadísticas.Estadisticas.EstadisticasMariano
{
    partial class Frm_Estadistica_Compras_Por_Proveedor
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
            this.reporte_compras_proveedor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reporte_compras_proveedor
            // 
            this.reporte_compras_proveedor.LocalReport.ReportEmbeddedResource = "Proyecto_PAV1_G5.ReportesyEstadísticas.Estadisticas.EstadisticasMariano.Estadisti" +
    "ca_Cantidad_De_Compras_Por_Proveedor.rdlc";
            this.reporte_compras_proveedor.Location = new System.Drawing.Point(12, 73);
            this.reporte_compras_proveedor.Name = "reporte_compras_proveedor";
            this.reporte_compras_proveedor.ServerReport.BearerToken = null;
            this.reporte_compras_proveedor.Size = new System.Drawing.Size(776, 296);
            this.reporte_compras_proveedor.TabIndex = 0;
            // 
            // Frm_Estadistica_Compras_Por_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reporte_compras_proveedor);
            this.Name = "Frm_Estadistica_Compras_Por_Proveedor";
            this.Text = "Frm_Estadistica_Compras_Por_Proveedor";
            this.Load += new System.EventHandler(this.Frm_Estadistica_Compras_Por_Proveedor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporte_compras_proveedor;
    }
}