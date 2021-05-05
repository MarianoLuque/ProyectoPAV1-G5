namespace Proyecto_PAV1_G5.ABM.Articulos
{
    partial class Frm_ABMArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ABMArticulos));
            this.grid_articulos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_bajaarticulo = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_modificararticulo = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_altaarticulo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_articulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_articulos
            // 
            this.grid_articulos.AllowUserToAddRows = false;
            this.grid_articulos.AllowUserToDeleteRows = false;
            this.grid_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_articulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7});
            this.grid_articulos.Location = new System.Drawing.Point(12, 243);
            this.grid_articulos.Name = "grid_articulos";
            this.grid_articulos.ReadOnly = true;
            this.grid_articulos.Size = new System.Drawing.Size(760, 254);
            this.grid_articulos.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Nombre";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripción";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Stock";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Costo Mayorista";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Costo Minorista";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Proveedor";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Lucida Fax", 20.25F);
            this.textBox1.Location = new System.Drawing.Point(276, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 32);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Artículos";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(555, 519);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // btn_bajaarticulo
            // 
            this.btn_bajaarticulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_bajaarticulo.BackgroundImage")));
            this.btn_bajaarticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_bajaarticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bajaarticulo.Location = new System.Drawing.Point(591, 519);
            this.btn_bajaarticulo.Name = "btn_bajaarticulo";
            this.btn_bajaarticulo.Size = new System.Drawing.Size(100, 30);
            this.btn_bajaarticulo.TabIndex = 11;
            this.btn_bajaarticulo.Text = "Eliminar";
            this.btn_bajaarticulo.UseVisualStyleBackColor = true;
            this.btn_bajaarticulo.Click += new System.EventHandler(this.btn_bajaarticulo_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(319, 519);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // btn_modificararticulo
            // 
            this.btn_modificararticulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_modificararticulo.BackgroundImage")));
            this.btn_modificararticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_modificararticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificararticulo.Location = new System.Drawing.Point(355, 519);
            this.btn_modificararticulo.Name = "btn_modificararticulo";
            this.btn_modificararticulo.Size = new System.Drawing.Size(100, 30);
            this.btn_modificararticulo.TabIndex = 9;
            this.btn_modificararticulo.Text = "Editar";
            this.btn_modificararticulo.UseVisualStyleBackColor = true;
            this.btn_modificararticulo.Click += new System.EventHandler(this.btn_modificararticulo_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(83, 519);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btn_altaarticulo
            // 
            this.btn_altaarticulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_altaarticulo.BackgroundImage")));
            this.btn_altaarticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_altaarticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_altaarticulo.Location = new System.Drawing.Point(119, 519);
            this.btn_altaarticulo.Name = "btn_altaarticulo";
            this.btn_altaarticulo.Size = new System.Drawing.Size(100, 30);
            this.btn_altaarticulo.TabIndex = 5;
            this.btn_altaarticulo.Text = "Agregar";
            this.btn_altaarticulo.UseVisualStyleBackColor = true;
            this.btn_altaarticulo.Click += new System.EventHandler(this.btn_altaarticulo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(403, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 81);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_consultar.BackgroundImage")));
            this.btn_consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.Location = new System.Drawing.Point(591, 207);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(100, 30);
            this.btn_consultar.TabIndex = 13;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Código de Artículo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre de Artículo";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_codigo.Location = new System.Drawing.Point(204, 115);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(203, 26);
            this.txt_codigo.TabIndex = 19;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_nombre.Location = new System.Drawing.Point(204, 151);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(203, 26);
            this.txt_nombre.TabIndex = 20;
            // 
            // Frm_ABMArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btn_bajaarticulo);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_modificararticulo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_altaarticulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grid_articulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_ABMArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            ((System.ComponentModel.ISupportInitialize)(this.grid_articulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_articulos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_altaarticulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_modificararticulo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_bajaarticulo;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_nombre;
    }
}