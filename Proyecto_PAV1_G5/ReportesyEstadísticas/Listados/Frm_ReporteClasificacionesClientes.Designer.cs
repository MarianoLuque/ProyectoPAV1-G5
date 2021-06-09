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
            this.reporte_clasificacion = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cantidad_compras = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_antiguedad = new System.Windows.Forms.TextBox();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reporte_clasificacion
            // 
            this.reporte_clasificacion.Location = new System.Drawing.Point(12, 98);
            this.reporte_clasificacion.Name = "reporte_clasificacion";
            this.reporte_clasificacion.ServerReport.BearerToken = null;
            this.reporte_clasificacion.Size = new System.Drawing.Size(776, 340);
            this.reporte_clasificacion.TabIndex = 0;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_buscar.Location = new System.Drawing.Point(681, 52);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 32);
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Cantidad de compras historicas";
            // 
            // txt_cantidad_compras
            // 
            this.txt_cantidad_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_compras.Location = new System.Drawing.Point(574, 9);
            this.txt_cantidad_compras.Name = "txt_cantidad_compras";
            this.txt_cantidad_compras.Size = new System.Drawing.Size(181, 26);
            this.txt_cantidad_compras.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Antigüedad";
            // 
            // txt_antiguedad
            // 
            this.txt_antiguedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_antiguedad.Location = new System.Drawing.Point(105, 6);
            this.txt_antiguedad.Name = "txt_antiguedad";
            this.txt_antiguedad.Size = new System.Drawing.Size(181, 26);
            this.txt_antiguedad.TabIndex = 18;
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_todos.Location = new System.Drawing.Point(485, 56);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(71, 24);
            this.rb_todos.TabIndex = 22;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "Todos";
            this.rb_todos.UseVisualStyleBackColor = true;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_limpiar.Location = new System.Drawing.Point(577, 52);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 32);
            this.btn_limpiar.TabIndex = 23;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // Frm_ReporteClasificacionesClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.rb_todos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_cantidad_compras);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_antiguedad);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.reporte_clasificacion);
            this.Name = "Frm_ReporteClasificacionesClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Clasificaciones Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporte_clasificacion;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cantidad_compras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_antiguedad;
        private System.Windows.Forms.RadioButton rb_todos;
        private System.Windows.Forms.Button btn_limpiar;
    }
}