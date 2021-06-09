namespace Proyecto_PAV1_G5.Reportes_y_Estadísticas.Listados
{
    partial class Frm_ReporteClientes
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
            this.reporte_clientes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fechaDesde = new System.Windows.Forms.MaskedTextBox();
            this.txt_fechaHasta = new System.Windows.Forms.MaskedTextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.cmb_clientes = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rv_fechas = new System.Windows.Forms.RadioButton();
            this.rv_cuit = new System.Windows.Forms.RadioButton();
            this.rv_todos = new System.Windows.Forms.RadioButton();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reporte_clientes
            // 
            this.reporte_clientes.Location = new System.Drawing.Point(12, 135);
            this.reporte_clientes.Name = "reporte_clientes";
            this.reporte_clientes.ServerReport.BearerToken = null;
            this.reporte_clientes.Size = new System.Drawing.Size(776, 303);
            this.reporte_clientes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasta";
            // 
            // txt_fechaDesde
            // 
            this.txt_fechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_fechaDesde.Location = new System.Drawing.Point(93, 56);
            this.txt_fechaDesde.Mask = "00/00/0000";
            this.txt_fechaDesde.Name = "txt_fechaDesde";
            this.txt_fechaDesde.Size = new System.Drawing.Size(88, 26);
            this.txt_fechaDesde.TabIndex = 6;
            this.txt_fechaDesde.ValidatingType = typeof(System.DateTime);
            // 
            // txt_fechaHasta
            // 
            this.txt_fechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_fechaHasta.Location = new System.Drawing.Point(270, 56);
            this.txt_fechaHasta.Mask = "00/00/0000";
            this.txt_fechaHasta.Name = "txt_fechaHasta";
            this.txt_fechaHasta.Size = new System.Drawing.Size(87, 26);
            this.txt_fechaHasta.TabIndex = 7;
            this.txt_fechaHasta.ValidatingType = typeof(System.DateTime);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_buscar.Location = new System.Drawing.Point(692, 97);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(96, 32);
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // cmb_clientes
            // 
            this.cmb_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_clientes.FormattingEnabled = true;
            this.cmb_clientes.Location = new System.Drawing.Point(93, 19);
            this.cmb_clientes.Name = "cmb_clientes";
            this.cmb_clientes.Pp_Conseleccion = false;
            this.cmb_clientes.Pp_MensajeError = null;
            this.cmb_clientes.Pp_NombreCampo = null;
            this.cmb_clientes.Pp_Validable = false;
            this.cmb_clientes.Size = new System.Drawing.Size(173, 28);
            this.cmb_clientes.TabIndex = 3;
            this.cmb_clientes.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rv_fechas);
            this.groupBox1.Controls.Add(this.rv_cuit);
            this.groupBox1.Controls.Add(this.rv_todos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(373, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 117);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // rv_fechas
            // 
            this.rv_fechas.AutoSize = true;
            this.rv_fechas.Location = new System.Drawing.Point(7, 84);
            this.rv_fechas.Name = "rv_fechas";
            this.rv_fechas.Size = new System.Drawing.Size(306, 24);
            this.rv_fechas.TabIndex = 2;
            this.rv_fechas.TabStop = true;
            this.rv_fechas.Text = "Rango de fechas de su primera compra";
            this.rv_fechas.UseVisualStyleBackColor = true;
            // 
            // rv_cuit
            // 
            this.rv_cuit.AutoSize = true;
            this.rv_cuit.Location = new System.Drawing.Point(7, 53);
            this.rv_cuit.Name = "rv_cuit";
            this.rv_cuit.Size = new System.Drawing.Size(158, 24);
            this.rv_cuit.TabIndex = 1;
            this.rv_cuit.TabStop = true;
            this.rv_cuit.Text = "Por cuit del Cliente";
            this.rv_cuit.UseVisualStyleBackColor = true;
            // 
            // rv_todos
            // 
            this.rv_todos.AutoSize = true;
            this.rv_todos.Location = new System.Drawing.Point(7, 26);
            this.rv_todos.Name = "rv_todos";
            this.rv_todos.Size = new System.Drawing.Size(156, 24);
            this.rv_todos.TabIndex = 0;
            this.rv_todos.TabStop = true;
            this.rv_todos.Text = "Todos los Clientes";
            this.rv_todos.UseVisualStyleBackColor = true;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_limpiar.Location = new System.Drawing.Point(692, 56);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(97, 32);
            this.btn_limpiar.TabIndex = 15;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // Frm_ReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_fechaHasta);
            this.Controls.Add(this.txt_fechaDesde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_clientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reporte_clientes);
            this.Name = "Frm_ReporteClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Clientes";
            this.Load += new System.EventHandler(this.Frm_ReporteClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporte_clientes;
        private System.Windows.Forms.Label label1;
        private Clases.ComboBox01 cmb_clientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txt_fechaDesde;
        private System.Windows.Forms.MaskedTextBox txt_fechaHasta;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rv_fechas;
        private System.Windows.Forms.RadioButton rv_cuit;
        private System.Windows.Forms.RadioButton rv_todos;
        private System.Windows.Forms.Button btn_limpiar;
    }
}