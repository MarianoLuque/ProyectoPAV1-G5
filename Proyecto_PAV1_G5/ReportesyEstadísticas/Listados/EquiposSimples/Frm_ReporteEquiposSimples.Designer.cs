namespace Proyecto_PAV1_G5.Reportes_y_Estadísticas.Listados
{
    partial class Frm_ReporteEquiposSimples
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
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rb02 = new System.Windows.Forms.RadioButton();
            this.Rb01 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Rb04 = new System.Windows.Forms.RadioButton();
            this.Rb03 = new System.Windows.Forms.RadioButton();
            this.Rb00 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigo_equipoHasta = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_nombre_equipo = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_codigo_equipoDesde = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reporte_ventas
            // 
            this.reporte_ventas.Location = new System.Drawing.Point(25, 136);
            this.reporte_ventas.Name = "reporte_ventas";
            this.reporte_ventas.ServerReport.BearerToken = null;
            this.reporte_ventas.Size = new System.Drawing.Size(776, 294);
            this.reporte_ventas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código Equipo Desde";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_buscar.Location = new System.Drawing.Point(726, 60);
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
            this.label4.Location = new System.Drawing.Point(39, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nombre Equipo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rb02);
            this.groupBox1.Controls.Add(this.Rb01);
            this.groupBox1.Location = new System.Drawing.Point(288, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 63);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Cálculo";
            // 
            // Rb02
            // 
            this.Rb02.AutoSize = true;
            this.Rb02.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Rb02.Location = new System.Drawing.Point(18, 40);
            this.Rb02.Name = "Rb02";
            this.Rb02.Size = new System.Drawing.Size(182, 21);
            this.Rb02.TabIndex = 3;
            this.Rb02.TabStop = true;
            this.Rb02.Text = "Buscar código por rango";
            this.Rb02.UseVisualStyleBackColor = true;
            // 
            // Rb01
            // 
            this.Rb01.AutoSize = true;
            this.Rb01.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Rb01.Location = new System.Drawing.Point(18, 19);
            this.Rb01.Name = "Rb01";
            this.Rb01.Size = new System.Drawing.Size(142, 21);
            this.Rb01.TabIndex = 2;
            this.Rb01.TabStop = true;
            this.Rb01.Text = "Todos los equipos";
            this.Rb01.UseVisualStyleBackColor = true;
            this.Rb01.CheckedChanged += new System.EventHandler(this.Rb01_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Rb04);
            this.groupBox2.Controls.Add(this.Rb03);
            this.groupBox2.Location = new System.Drawing.Point(513, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 73);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Reporte";
            // 
            // Rb04
            // 
            this.Rb04.AutoSize = true;
            this.Rb04.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Rb04.Location = new System.Drawing.Point(18, 40);
            this.Rb04.Name = "Rb04";
            this.Rb04.Size = new System.Drawing.Size(152, 21);
            this.Rb04.TabIndex = 3;
            this.Rb04.TabStop = true;
            this.Rb04.Text = "Artículos por equipo";
            this.Rb04.UseVisualStyleBackColor = true;
            // 
            // Rb03
            // 
            this.Rb03.AutoSize = true;
            this.Rb03.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Rb03.Location = new System.Drawing.Point(18, 19);
            this.Rb03.Name = "Rb03";
            this.Rb03.Size = new System.Drawing.Size(77, 21);
            this.Rb03.TabIndex = 2;
            this.Rb03.TabStop = true;
            this.Rb03.Text = "Equipos";
            this.Rb03.UseVisualStyleBackColor = true;
            // 
            // Rb00
            // 
            this.Rb00.AutoSize = true;
            this.Rb00.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Rb00.Location = new System.Drawing.Point(306, 95);
            this.Rb00.Name = "Rb00";
            this.Rb00.Size = new System.Drawing.Size(192, 21);
            this.Rb00.TabIndex = 4;
            this.Rb00.TabStop = true;
            this.Rb00.Text = "Buscar nombre por patrón";
            this.Rb00.UseVisualStyleBackColor = true;
            this.Rb00.CheckedChanged += new System.EventHandler(this.Rb00_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Código Equipo Hasta";
            // 
            // txt_codigo_equipoHasta
            // 
            this.txt_codigo_equipoHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_equipoHasta.Location = new System.Drawing.Point(191, 56);
            this.txt_codigo_equipoHasta.Name = "txt_codigo_equipoHasta";
            this.txt_codigo_equipoHasta.Pp_campo = null;
            this.txt_codigo_equipoHasta.Pp_MensajeError = null;
            this.txt_codigo_equipoHasta.Pp_Validable = false;
            this.txt_codigo_equipoHasta.Size = new System.Drawing.Size(88, 26);
            this.txt_codigo_equipoHasta.TabIndex = 18;
            // 
            // txt_nombre_equipo
            // 
            this.txt_nombre_equipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_equipo.Location = new System.Drawing.Point(158, 90);
            this.txt_nombre_equipo.Name = "txt_nombre_equipo";
            this.txt_nombre_equipo.Pp_campo = null;
            this.txt_nombre_equipo.Pp_MensajeError = null;
            this.txt_nombre_equipo.Pp_Validable = false;
            this.txt_nombre_equipo.Size = new System.Drawing.Size(121, 26);
            this.txt_nombre_equipo.TabIndex = 11;
            // 
            // txt_codigo_equipoDesde
            // 
            this.txt_codigo_equipoDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_equipoDesde.Location = new System.Drawing.Point(191, 23);
            this.txt_codigo_equipoDesde.Name = "txt_codigo_equipoDesde";
            this.txt_codigo_equipoDesde.Pp_campo = null;
            this.txt_codigo_equipoDesde.Pp_MensajeError = null;
            this.txt_codigo_equipoDesde.Pp_Validable = false;
            this.txt_codigo_equipoDesde.Size = new System.Drawing.Size(88, 26);
            this.txt_codigo_equipoDesde.TabIndex = 11;
            // 
            // Frm_ReporteEquiposSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.Rb00);
            this.Controls.Add(this.txt_codigo_equipoHasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nombre_equipo);
            this.Controls.Add(this.txt_codigo_equipoDesde);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reporte_ventas);
            this.Name = "Frm_ReporteEquiposSimples";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Equipos Simples";
            this.Load += new System.EventHandler(this.Frm_ReporteEquiposSimples_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporte_ventas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscar;
        private Clases.TextBox01 txt_codigo_equipoDesde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rb02;
        private System.Windows.Forms.RadioButton Rb01;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Rb04;
        private System.Windows.Forms.RadioButton Rb03;
        private System.Windows.Forms.RadioButton Rb00;
        private Clases.TextBox01 txt_nombre_equipo;
        private Clases.TextBox01 txt_codigo_equipoHasta;
        private System.Windows.Forms.Label label2;
    }
}