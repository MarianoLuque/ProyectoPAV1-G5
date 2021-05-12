namespace Proyecto_PAV1_G5.ABM.Proveedores
{
    partial class Frm_ABMProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ABMProveedores));
            this.grid_proveedores = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.cuit_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razon_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajo_comprador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_inicio_operacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_proveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_proveedores
            // 
            this.grid_proveedores.AllowUserToAddRows = false;
            this.grid_proveedores.AllowUserToDeleteRows = false;
            this.grid_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_proveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuit_proveedor,
            this.razon_social,
            this.legajo_comprador,
            this.fecha_inicio_operacion,
            this.telefono,
            this.barrio,
            this.calle,
            this.nro_calle});
            this.grid_proveedores.Location = new System.Drawing.Point(12, 243);
            this.grid_proveedores.Name = "grid_proveedores";
            this.grid_proveedores.ReadOnly = true;
            this.grid_proveedores.Size = new System.Drawing.Size(796, 254);
            this.grid_proveedores.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Lucida Fax", 20.25F);
            this.textBox1.Location = new System.Drawing.Point(261, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 32);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Proveedores";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(119, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(355, 519);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(591, 519);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 30);
            this.button3.TabIndex = 11;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Proyecto_PAV1_G5.Properties.Resources._003_delete;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(555, 519);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Proyecto_PAV1_G5.Properties.Resources._002_edit;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(319, 519);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Proyecto_PAV1_G5.Properties.Resources._001__add;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(83, 519);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Proyecto_PAV1_G5.Properties.Resources._003_contract;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(440, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 82);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.Location = new System.Drawing.Point(591, 161);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(100, 30);
            this.btn_consultar.TabIndex = 13;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // cuit_proveedor
            // 
            this.cuit_proveedor.HeaderText = "Cuit";
            this.cuit_proveedor.Name = "cuit_proveedor";
            this.cuit_proveedor.ReadOnly = true;
            this.cuit_proveedor.Width = 50;
            // 
            // razon_social
            // 
            this.razon_social.HeaderText = "Razón Social";
            this.razon_social.Name = "razon_social";
            this.razon_social.ReadOnly = true;
            // 
            // legajo_comprador
            // 
            this.legajo_comprador.HeaderText = "Legajo Comprador";
            this.legajo_comprador.Name = "legajo_comprador";
            this.legajo_comprador.ReadOnly = true;
            // 
            // fecha_inicio_operacion
            // 
            this.fecha_inicio_operacion.HeaderText = "Fecha de inicio de operación";
            this.fecha_inicio_operacion.Name = "fecha_inicio_operacion";
            this.fecha_inicio_operacion.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // barrio
            // 
            this.barrio.HeaderText = "Barrio";
            this.barrio.Name = "barrio";
            this.barrio.ReadOnly = true;
            // 
            // calle
            // 
            this.calle.HeaderText = "Calle";
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            // 
            // nro_calle
            // 
            this.nro_calle.HeaderText = "Número de calle";
            this.nro_calle.Name = "nro_calle";
            this.nro_calle.ReadOnly = true;
            // 
            // Frm_ABMProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 561);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grid_proveedores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_ABMProveedores";
            this.Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.grid_proveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_proveedores;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn razon_social;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo_comprador;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_inicio_operacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_calle;
    }
}