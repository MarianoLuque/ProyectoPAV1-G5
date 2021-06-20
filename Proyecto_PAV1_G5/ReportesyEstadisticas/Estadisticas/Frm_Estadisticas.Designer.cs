namespace Proyecto_PAV1_G5.ReportesyEstadisticas.Estadisticas
{
    partial class Frm_Estadisticas
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
            this.dataSetF1 = new Proyecto_PAV1_G5.ReportesyEstadisticas.Estadisticas.EstadisticasFlor.DataSetF();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetF1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetF1
            // 
            this.dataSetF1.DataSetName = "DataSetF";
            this.dataSetF1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Frm_Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Frm_Estadisticas";
            this.Text = "Frm_Estadisticas";
            ((System.ComponentModel.ISupportInitialize)(this.dataSetF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EstadisticasFlor.DataSetF dataSetF1;
    }
}