namespace Proyecto_PAV1_G5.Transacciones.Compras
{
    partial class Frm_Alta_Compra
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
            this.grid011 = new Proyecto_PAV1_G5.Clases.Grid01();
            this.comboBox011 = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.comboBox012 = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.textBox011 = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid011)).BeginInit();
            this.SuspendLayout();
            // 
            // grid011
            // 
            this.grid011.AllowUserToAddRows = false;
            this.grid011.AllowUserToDeleteRows = false;
            this.grid011.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid011.Location = new System.Drawing.Point(316, 219);
            this.grid011.Name = "grid011";
            this.grid011.ReadOnly = true;
            this.grid011.Size = new System.Drawing.Size(425, 150);
            this.grid011.TabIndex = 0;
            // 
            // comboBox011
            // 
            this.comboBox011.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox011.FormattingEnabled = true;
            this.comboBox011.Location = new System.Drawing.Point(53, 49);
            this.comboBox011.Name = "comboBox011";
            this.comboBox011.Pp_Conseleccion = false;
            this.comboBox011.Pp_MensajeError = null;
            this.comboBox011.Pp_NombreCampo = null;
            this.comboBox011.Pp_Validable = false;
            this.comboBox011.Size = new System.Drawing.Size(121, 28);
            this.comboBox011.TabIndex = 1;
            // 
            // comboBox012
            // 
            this.comboBox012.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox012.FormattingEnabled = true;
            this.comboBox012.Location = new System.Drawing.Point(53, 83);
            this.comboBox012.Name = "comboBox012";
            this.comboBox012.Pp_Conseleccion = false;
            this.comboBox012.Pp_MensajeError = null;
            this.comboBox012.Pp_NombreCampo = null;
            this.comboBox012.Pp_Validable = false;
            this.comboBox012.Size = new System.Drawing.Size(121, 28);
            this.comboBox012.TabIndex = 2;
            // 
            // textBox011
            // 
            this.textBox011.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox011.Location = new System.Drawing.Point(554, 163);
            this.textBox011.Name = "textBox011";
            this.textBox011.Pp_campo = null;
            this.textBox011.Pp_MensajeError = null;
            this.textBox011.Pp_Validable = false;
            this.textBox011.Size = new System.Drawing.Size(100, 26);
            this.textBox011.TabIndex = 3;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(666, 156);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 30);
            this.btn_agregar.TabIndex = 4;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(53, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(170, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Frm_Alta_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.textBox011);
            this.Controls.Add(this.comboBox012);
            this.Controls.Add(this.comboBox011);
            this.Controls.Add(this.grid011);
            this.Name = "Frm_Alta_Compra";
            this.Text = "Alta Compra";
            ((System.ComponentModel.ISupportInitialize)(this.grid011)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.Grid01 grid011;
        private Clases.ComboBox01 comboBox011;
        private Clases.ComboBox01 comboBox012;
        private Clases.TextBox01 textBox011;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}