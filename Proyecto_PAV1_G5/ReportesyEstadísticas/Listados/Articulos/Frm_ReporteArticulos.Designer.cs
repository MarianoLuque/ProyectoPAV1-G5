namespace Proyecto_PAV1_G5.Reportes_y_Estadísticas.Listados
{
    partial class Frm_ReporteArticulos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.reporte_articulos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_todos = new System.Windows.Forms.RadioButton();
            this.btn_filtros = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_proveedores = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.txt_NombreArticulo = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_cantDesde = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_cantHasta = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasta";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_buscar.Location = new System.Drawing.Point(698, 68);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(90, 32);
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_cantHasta);
            this.groupBox1.Controls.Add(this.txt_cantDesde);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(175, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cantidad en Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(352, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre del Artículo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(418, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Proveedor";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_limpiar.Location = new System.Drawing.Point(698, 22);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(90, 32);
            this.btn_limpiar.TabIndex = 16;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // reporte_articulos
            // 
            this.reporte_articulos.Location = new System.Drawing.Point(12, 118);
            this.reporte_articulos.Name = "reporte_articulos";
            this.reporte_articulos.ServerReport.BearerToken = null;
            this.reporte_articulos.Size = new System.Drawing.Size(776, 320);
            this.reporte_articulos.TabIndex = 17;
            // 
            // btn_todos
            // 
            this.btn_todos.AutoSize = true;
            this.btn_todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_todos.Location = new System.Drawing.Point(24, 62);
            this.btn_todos.Name = "btn_todos";
            this.btn_todos.Size = new System.Drawing.Size(71, 24);
            this.btn_todos.TabIndex = 18;
            this.btn_todos.TabStop = true;
            this.btn_todos.Text = "Todos";
            this.btn_todos.UseVisualStyleBackColor = true;
            this.btn_todos.CheckedChanged += new System.EventHandler(this.btn_todos_CheckedChanged);
            // 
            // btn_filtros
            // 
            this.btn_filtros.AutoSize = true;
            this.btn_filtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_filtros.Location = new System.Drawing.Point(24, 32);
            this.btn_filtros.Name = "btn_filtros";
            this.btn_filtros.Size = new System.Drawing.Size(103, 24);
            this.btn_filtros.TabIndex = 19;
            this.btn_filtros.TabStop = true;
            this.btn_filtros.Text = "Con Filtros";
            this.btn_filtros.UseVisualStyleBackColor = true;
            this.btn_filtros.CheckedChanged += new System.EventHandler(this.btn_filtros_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_filtros);
            this.groupBox2.Controls.Add(this.btn_todos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 100);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // cmb_proveedores
            // 
            this.cmb_proveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_proveedores.FormattingEnabled = true;
            this.cmb_proveedores.Location = new System.Drawing.Point(505, 69);
            this.cmb_proveedores.Name = "cmb_proveedores";
            this.cmb_proveedores.Pp_Conseleccion = false;
            this.cmb_proveedores.Pp_MensajeError = null;
            this.cmb_proveedores.Pp_NombreCampo = null;
            this.cmb_proveedores.Pp_Validable = false;
            this.cmb_proveedores.Size = new System.Drawing.Size(180, 28);
            this.cmb_proveedores.TabIndex = 15;
            // 
            // txt_NombreArticulo
            // 
            this.txt_NombreArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_NombreArticulo.Location = new System.Drawing.Point(505, 22);
            this.txt_NombreArticulo.Name = "txt_NombreArticulo";
            this.txt_NombreArticulo.Pp_campo = null;
            this.txt_NombreArticulo.Pp_MensajeError = null;
            this.txt_NombreArticulo.Pp_Validable = false;
            this.txt_NombreArticulo.Size = new System.Drawing.Size(180, 26);
            this.txt_NombreArticulo.TabIndex = 13;
            // 
            // txt_cantDesde
            // 
            this.txt_cantDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_cantDesde.Location = new System.Drawing.Point(74, 31);
            this.txt_cantDesde.Name = "txt_cantDesde";
            this.txt_cantDesde.Pp_campo = null;
            this.txt_cantDesde.Pp_MensajeError = null;
            this.txt_cantDesde.Pp_Validable = false;
            this.txt_cantDesde.Size = new System.Drawing.Size(70, 26);
            this.txt_cantDesde.TabIndex = 13;
            // 
            // txt_cantHasta
            // 
            this.txt_cantHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_cantHasta.Location = new System.Drawing.Point(74, 63);
            this.txt_cantHasta.Name = "txt_cantHasta";
            this.txt_cantHasta.Pp_campo = null;
            this.txt_cantHasta.Pp_MensajeError = null;
            this.txt_cantHasta.Pp_Validable = false;
            this.txt_cantHasta.Size = new System.Drawing.Size(70, 26);
            this.txt_cantHasta.TabIndex = 13;
            // 
            // Frm_ReporteArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.reporte_articulos);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.cmb_proveedores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_NombreArticulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_buscar);
            this.Name = "Frm_ReporteArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Articulos";
            this.Load += new System.EventHandler(this.Frm_ReporteArticulos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 txt_NombreArticulo;
        private System.Windows.Forms.Label label4;
        private Clases.ComboBox01 cmb_proveedores;
        private System.Windows.Forms.Button btn_limpiar;
        private Microsoft.Reporting.WinForms.ReportViewer reporte_articulos;
        private System.Windows.Forms.RadioButton btn_todos;
        private System.Windows.Forms.RadioButton btn_filtros;
        private System.Windows.Forms.GroupBox groupBox2;
        private Clases.TextBox01 txt_cantHasta;
        private Clases.TextBox01 txt_cantDesde;
    }
}