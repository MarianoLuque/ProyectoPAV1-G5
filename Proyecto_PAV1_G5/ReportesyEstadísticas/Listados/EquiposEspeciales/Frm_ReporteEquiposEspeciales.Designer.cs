namespace Proyecto_PAV1_G5.Reportes_y_Estadísticas.Listados
{
    partial class Frm_ReporteEquiposEspeciales
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
            this.reporte_equipos_especiales = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.txt_precio_max = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_precio_min = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.cmb_clientes = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.SuspendLayout();
            // 
            // reporte_equipos_especiales
            // 
            this.reporte_equipos_especiales.Location = new System.Drawing.Point(12, 98);
            this.reporte_equipos_especiales.Name = "reporte_equipos_especiales";
            this.reporte_equipos_especiales.ServerReport.BearerToken = null;
            this.reporte_equipos_especiales.Size = new System.Drawing.Size(776, 340);
            this.reporte_equipos_especiales.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Precio Min.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(588, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio Máx.";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_buscar.Location = new System.Drawing.Point(700, 60);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 32);
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_limpiar.Location = new System.Drawing.Point(610, 60);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(77, 32);
            this.btn_limpiar.TabIndex = 9;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_todos.Location = new System.Drawing.Point(515, 64);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(71, 24);
            this.rb_todos.TabIndex = 10;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "Todos";
            this.rb_todos.UseVisualStyleBackColor = true;
            this.rb_todos.CheckedChanged += new System.EventHandler(this.rb_todos_CheckedChanged);
            // 
            // txt_precio_max
            // 
            this.txt_precio_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio_max.Location = new System.Drawing.Point(684, 16);
            this.txt_precio_max.Name = "txt_precio_max";
            this.txt_precio_max.Pp_campo = "precio_mayorista";
            this.txt_precio_max.Pp_MensajeError = "Falta cargar el precio mayorista";
            this.txt_precio_max.Pp_Validable = false;
            this.txt_precio_max.Size = new System.Drawing.Size(87, 26);
            this.txt_precio_max.TabIndex = 12;
            this.txt_precio_max.TextChanged += new System.EventHandler(this.txt_precio_max_TextChanged);
            // 
            // txt_precio_min
            // 
            this.txt_precio_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio_min.Location = new System.Drawing.Point(412, 16);
            this.txt_precio_min.Name = "txt_precio_min";
            this.txt_precio_min.Pp_campo = "precio_mayorista";
            this.txt_precio_min.Pp_MensajeError = "Falta cargar el precio mayorista";
            this.txt_precio_min.Pp_Validable = false;
            this.txt_precio_min.Size = new System.Drawing.Size(87, 26);
            this.txt_precio_min.TabIndex = 11;
            this.txt_precio_min.TextChanged += new System.EventHandler(this.txt_precio_min_TextChanged);
            // 
            // cmb_clientes
            // 
            this.cmb_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_clientes.FormattingEnabled = true;
            this.cmb_clientes.Location = new System.Drawing.Point(76, 16);
            this.cmb_clientes.Name = "cmb_clientes";
            this.cmb_clientes.Pp_Conseleccion = false;
            this.cmb_clientes.Pp_MensajeError = null;
            this.cmb_clientes.Pp_NombreCampo = null;
            this.cmb_clientes.Pp_Validable = false;
            this.cmb_clientes.Size = new System.Drawing.Size(173, 28);
            this.cmb_clientes.TabIndex = 3;
            this.cmb_clientes.TabStop = false;
            this.cmb_clientes.SelectedIndexChanged += new System.EventHandler(this.cmb_clientes_SelectedIndexChanged);
            // 
            // Frm_ReporteEquiposEspeciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_precio_max);
            this.Controls.Add(this.txt_precio_min);
            this.Controls.Add(this.rb_todos);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_clientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reporte_equipos_especiales);
            this.Name = "Frm_ReporteEquiposEspeciales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Equipos Especiales";
            this.Load += new System.EventHandler(this.Frm_ReporteEquiposEspeciales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporte_equipos_especiales;
        private System.Windows.Forms.Label label1;
        private Clases.ComboBox01 cmb_clientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.RadioButton rb_todos;
        private Clases.TextBox01 txt_precio_min;
        private Clases.TextBox01 txt_precio_max;
    }
}