namespace Proyecto_PAV1_G5.Reportes_y_Estadísticas.Listados
{
    partial class Frm_ReporteRubros
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
            this.reporte_rubros = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_IdDesde = new System.Windows.Forms.MaskedTextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_patron_nombre = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_IdHasta = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb02 = new System.Windows.Forms.RadioButton();
            this.rb01 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reporte_rubros
            // 
            this.reporte_rubros.Location = new System.Drawing.Point(12, 98);
            this.reporte_rubros.Name = "reporte_rubros";
            this.reporte_rubros.ServerReport.BearerToken = null;
            this.reporte_rubros.Size = new System.Drawing.Size(776, 340);
            this.reporte_rubros.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(477, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(481, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID hasta";
            // 
            // txt_IdDesde
            // 
            this.txt_IdDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_IdDesde.Location = new System.Drawing.Point(557, 16);
            this.txt_IdDesde.Mask = "9999";
            this.txt_IdDesde.Name = "txt_IdDesde";
            this.txt_IdDesde.Size = new System.Drawing.Size(52, 26);
            this.txt_IdDesde.TabIndex = 6;
            this.txt_IdDesde.ValidatingType = typeof(int);
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
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_patron_nombre
            // 
            this.txt_patron_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patron_nombre.Location = new System.Drawing.Point(110, 22);
            this.txt_patron_nombre.Name = "txt_patron_nombre";
            this.txt_patron_nombre.Pp_campo = null;
            this.txt_patron_nombre.Pp_MensajeError = null;
            this.txt_patron_nombre.Pp_Validable = false;
            this.txt_patron_nombre.Size = new System.Drawing.Size(151, 26);
            this.txt_patron_nombre.TabIndex = 11;
            // 
            // txt_IdHasta
            // 
            this.txt_IdHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_IdHasta.Location = new System.Drawing.Point(557, 48);
            this.txt_IdHasta.Mask = "9999";
            this.txt_IdHasta.Name = "txt_IdHasta";
            this.txt_IdHasta.Size = new System.Drawing.Size(52, 26);
            this.txt_IdHasta.TabIndex = 6;
            this.txt_IdHasta.ValidatingType = typeof(int);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb02);
            this.groupBox1.Controls.Add(this.rb01);
            this.groupBox1.Location = new System.Drawing.Point(267, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 79);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patron nombre";
            // 
            // rb02
            // 
            this.rb02.AutoSize = true;
            this.rb02.Location = new System.Drawing.Point(6, 42);
            this.rb02.Name = "rb02";
            this.rb02.Size = new System.Drawing.Size(93, 17);
            this.rb02.TabIndex = 1;
            this.rb02.TabStop = true;
            this.rb02.Text = "Que contenga";
            this.rb02.UseVisualStyleBackColor = true;
            // 
            // rb01
            // 
            this.rb01.AutoSize = true;
            this.rb01.Location = new System.Drawing.Point(7, 20);
            this.rb01.Name = "rb01";
            this.rb01.Size = new System.Drawing.Size(109, 17);
            this.rb01.TabIndex = 0;
            this.rb01.TabStop = true;
            this.rb01.Text = "Que empiece con";
            this.rb01.UseVisualStyleBackColor = true;
            // 
            // Frm_ReporteRubros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_patron_nombre);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_IdHasta);
            this.Controls.Add(this.txt_IdDesde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reporte_rubros);
            this.Name = "Frm_ReporteRubros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Rubros";
            this.Load += new System.EventHandler(this.Frm_ReporteRubros_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporte_rubros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txt_IdDesde;
        private System.Windows.Forms.Button btn_buscar;
        private Clases.TextBox01 txt_patron_nombre;
        private System.Windows.Forms.MaskedTextBox txt_IdHasta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb02;
        private System.Windows.Forms.RadioButton rb01;
    }
}