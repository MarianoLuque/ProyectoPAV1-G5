namespace Proyecto_PAV1_G5.ABM.Equipos
{
    partial class Frm_Equipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Equipos));
            this.btn_equiposimple = new System.Windows.Forms.Button();
            this.btn_equipoespecial = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_equiposimple
            // 
            this.btn_equiposimple.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_equiposimple.Location = new System.Drawing.Point(12, 22);
            this.btn_equiposimple.Name = "btn_equiposimple";
            this.btn_equiposimple.Size = new System.Drawing.Size(200, 100);
            this.btn_equiposimple.TabIndex = 0;
            this.btn_equiposimple.Text = "Equipos Simples";
            this.btn_equiposimple.UseVisualStyleBackColor = true;
            this.btn_equiposimple.Click += new System.EventHandler(this.btn_equiposimple_Click);
            // 
            // btn_equipoespecial
            // 
            this.btn_equipoespecial.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_equipoespecial.Location = new System.Drawing.Point(12, 149);
            this.btn_equipoespecial.Name = "btn_equipoespecial";
            this.btn_equipoespecial.Size = new System.Drawing.Size(200, 100);
            this.btn_equipoespecial.TabIndex = 1;
            this.btn_equipoespecial.Text = "Equipos Especiales";
            this.btn_equipoespecial.UseVisualStyleBackColor = true;
            this.btn_equipoespecial.Click += new System.EventHandler(this.btn_equipoespecial_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Proyecto_PAV1_G5.Properties.Resources._022_illustration;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(222, 149);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 100);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Proyecto_PAV1_G5.Properties.Resources._002_desktop_computer;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(222, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 100);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Equipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 268);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_equipoespecial);
            this.Controls.Add(this.btn_equiposimple);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Equipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_equiposimple;
        private System.Windows.Forms.Button btn_equipoespecial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}