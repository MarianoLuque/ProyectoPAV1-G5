namespace Proyecto_PAV1_G5.Reportes_y_Estadísticas.Listados
{
    partial class Frm_ReporteProveedores
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
            this.reporte_proveedores = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rv_fechas = new System.Windows.Forms.RadioButton();
            this.rv_cuit = new System.Windows.Forms.RadioButton();
            this.rv_todos = new System.Windows.Forms.RadioButton();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_fechaHasta = new System.Windows.Forms.MaskedTextBox();
            this.txt_fechaDesde = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_proveedores = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reporte_proveedores
            // 
            this.reporte_proveedores.Location = new System.Drawing.Point(12, 135);
            this.reporte_proveedores.Name = "reporte_proveedores";
            this.reporte_proveedores.ServerReport.BearerToken = null;
            this.reporte_proveedores.Size = new System.Drawing.Size(799, 303);
            this.reporte_proveedores.TabIndex = 0;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_limpiar.Location = new System.Drawing.Point(714, 57);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(97, 32);
            this.btn_limpiar.TabIndex = 24;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rv_fechas);
            this.groupBox1.Controls.Add(this.rv_cuit);
            this.groupBox1.Controls.Add(this.rv_todos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(362, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 117);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // rv_fechas
            // 
            this.rv_fechas.AutoSize = true;
            this.rv_fechas.Location = new System.Drawing.Point(7, 84);
            this.rv_fechas.Name = "rv_fechas";
            this.rv_fechas.Size = new System.Drawing.Size(327, 24);
            this.rv_fechas.TabIndex = 2;
            this.rv_fechas.TabStop = true;
            this.rv_fechas.Text = "Rango de fechas de su inicio de operacion";
            this.rv_fechas.UseVisualStyleBackColor = true;
            // 
            // rv_cuit
            // 
            this.rv_cuit.AutoSize = true;
            this.rv_cuit.Location = new System.Drawing.Point(7, 55);
            this.rv_cuit.Name = "rv_cuit";
            this.rv_cuit.Size = new System.Drawing.Size(181, 24);
            this.rv_cuit.TabIndex = 1;
            this.rv_cuit.TabStop = true;
            this.rv_cuit.Text = "Por cuit del Proveedor";
            this.rv_cuit.UseVisualStyleBackColor = true;
            // 
            // rv_todos
            // 
            this.rv_todos.AutoSize = true;
            this.rv_todos.Location = new System.Drawing.Point(7, 26);
            this.rv_todos.Name = "rv_todos";
            this.rv_todos.Size = new System.Drawing.Size(188, 24);
            this.rv_todos.TabIndex = 0;
            this.rv_todos.TabStop = true;
            this.rv_todos.Text = "Todos los Proveedores";
            this.rv_todos.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_buscar.Location = new System.Drawing.Point(714, 98);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(96, 32);
            this.btn_buscar.TabIndex = 22;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_fechaHasta
            // 
            this.txt_fechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_fechaHasta.Location = new System.Drawing.Point(254, 53);
            this.txt_fechaHasta.Mask = "00/00/0000";
            this.txt_fechaHasta.Name = "txt_fechaHasta";
            this.txt_fechaHasta.Size = new System.Drawing.Size(87, 26);
            this.txt_fechaHasta.TabIndex = 21;
            this.txt_fechaHasta.ValidatingType = typeof(System.DateTime);
            // 
            // txt_fechaDesde
            // 
            this.txt_fechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_fechaDesde.Location = new System.Drawing.Point(94, 53);
            this.txt_fechaDesde.Mask = "00/00/0000";
            this.txt_fechaDesde.Name = "txt_fechaDesde";
            this.txt_fechaDesde.Size = new System.Drawing.Size(88, 26);
            this.txt_fechaDesde.TabIndex = 20;
            this.txt_fechaDesde.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Desde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Proveedor";
            // 
            // cmb_proveedores
            // 
            this.cmb_proveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_proveedores.FormattingEnabled = true;
            this.cmb_proveedores.Location = new System.Drawing.Point(94, 19);
            this.cmb_proveedores.Name = "cmb_proveedores";
            this.cmb_proveedores.Pp_Conseleccion = false;
            this.cmb_proveedores.Pp_MensajeError = null;
            this.cmb_proveedores.Pp_NombreCampo = null;
            this.cmb_proveedores.Pp_Validable = false;
            this.cmb_proveedores.Size = new System.Drawing.Size(173, 28);
            this.cmb_proveedores.TabIndex = 17;
            this.cmb_proveedores.TabStop = false;
            // 
            // Frm_ReporteProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_fechaHasta);
            this.Controls.Add(this.txt_fechaDesde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_proveedores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reporte_proveedores);
            this.Name = "Frm_ReporteProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Proveedores";
            this.Load += new System.EventHandler(this.Frm_ReporteProveedores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporte_proveedores;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rv_fechas;
        private System.Windows.Forms.RadioButton rv_cuit;
        private System.Windows.Forms.RadioButton rv_todos;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.MaskedTextBox txt_fechaHasta;
        private System.Windows.Forms.MaskedTextBox txt_fechaDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Clases.ComboBox01 cmb_proveedores;
        private System.Windows.Forms.Label label1;
    }
}