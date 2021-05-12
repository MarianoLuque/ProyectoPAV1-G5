namespace Proyecto_PAV1_G5.ABM.Equipos.Equipos_Especiales
{
    partial class Frm_ABMEquipoEspecial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ABMEquipoEspecial));
            this.grid_Equipo_Especial = new System.Windows.Forms.DataGridView();
            this.codigo_equipo_especial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_equipo_especial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Agregar_Equipo_Especial = new System.Windows.Forms.Button();
            this.btn_Modificar_Equipo_Especial = new System.Windows.Forms.Button();
            this.btn_Eliminar_Equipo_Especial = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Codigo_Equipo_Especial = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_Cuit_Cliente = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nombre_Equipo_Especial = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Consultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Equipo_Especial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_Equipo_Especial
            // 
            this.grid_Equipo_Especial.AllowUserToAddRows = false;
            this.grid_Equipo_Especial.AllowUserToDeleteRows = false;
            this.grid_Equipo_Especial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Equipo_Especial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_equipo_especial,
            this.cuit_cliente,
            this.nombre_equipo_especial,
            this.precio,
            this.descripcion});
            this.grid_Equipo_Especial.Location = new System.Drawing.Point(12, 243);
            this.grid_Equipo_Especial.Name = "grid_Equipo_Especial";
            this.grid_Equipo_Especial.ReadOnly = true;
            this.grid_Equipo_Especial.Size = new System.Drawing.Size(760, 254);
            this.grid_Equipo_Especial.TabIndex = 0;
            // 
            // codigo_equipo_especial
            // 
            this.codigo_equipo_especial.HeaderText = "Codigo";
            this.codigo_equipo_especial.Name = "codigo_equipo_especial";
            this.codigo_equipo_especial.ReadOnly = true;
            this.codigo_equipo_especial.Width = 65;
            // 
            // cuit_cliente
            // 
            this.cuit_cliente.HeaderText = "Cliente";
            this.cuit_cliente.Name = "cuit_cliente";
            this.cuit_cliente.ReadOnly = true;
            // 
            // nombre_equipo_especial
            // 
            this.nombre_equipo_especial.HeaderText = "Nombre Equipo";
            this.nombre_equipo_especial.Name = "nombre_equipo_especial";
            this.nombre_equipo_especial.ReadOnly = true;
            this.nombre_equipo_especial.Width = 250;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 65;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 230;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Lucida Fax", 20.25F);
            this.textBox1.Location = new System.Drawing.Point(201, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 32);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Equipos Especiales";
            // 
            // btn_Agregar_Equipo_Especial
            // 
            this.btn_Agregar_Equipo_Especial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Agregar_Equipo_Especial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar_Equipo_Especial.Location = new System.Drawing.Point(119, 519);
            this.btn_Agregar_Equipo_Especial.Name = "btn_Agregar_Equipo_Especial";
            this.btn_Agregar_Equipo_Especial.Size = new System.Drawing.Size(100, 30);
            this.btn_Agregar_Equipo_Especial.TabIndex = 4;
            this.btn_Agregar_Equipo_Especial.Text = "Agregar";
            this.btn_Agregar_Equipo_Especial.UseVisualStyleBackColor = true;
            this.btn_Agregar_Equipo_Especial.Click += new System.EventHandler(this.btn_Agregar_Equipo_Especial_Click);
            // 
            // btn_Modificar_Equipo_Especial
            // 
            this.btn_Modificar_Equipo_Especial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Modificar_Equipo_Especial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar_Equipo_Especial.Location = new System.Drawing.Point(355, 519);
            this.btn_Modificar_Equipo_Especial.Name = "btn_Modificar_Equipo_Especial";
            this.btn_Modificar_Equipo_Especial.Size = new System.Drawing.Size(100, 30);
            this.btn_Modificar_Equipo_Especial.TabIndex = 5;
            this.btn_Modificar_Equipo_Especial.Text = "Editar";
            this.btn_Modificar_Equipo_Especial.UseVisualStyleBackColor = true;
            this.btn_Modificar_Equipo_Especial.Click += new System.EventHandler(this.btn_Modificar_Equipo_Especial_Click);
            // 
            // btn_Eliminar_Equipo_Especial
            // 
            this.btn_Eliminar_Equipo_Especial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Eliminar_Equipo_Especial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar_Equipo_Especial.Location = new System.Drawing.Point(591, 519);
            this.btn_Eliminar_Equipo_Especial.Name = "btn_Eliminar_Equipo_Especial";
            this.btn_Eliminar_Equipo_Especial.Size = new System.Drawing.Size(100, 30);
            this.btn_Eliminar_Equipo_Especial.TabIndex = 6;
            this.btn_Eliminar_Equipo_Especial.Text = "Eliminar";
            this.btn_Eliminar_Equipo_Especial.UseVisualStyleBackColor = true;
            this.btn_Eliminar_Equipo_Especial.Click += new System.EventHandler(this.btn_Eliminar_Equipo_Especial_Click);
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
            this.pictureBox1.BackgroundImage = global::Proyecto_PAV1_G5.Properties.Resources._022_illustration;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(464, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 82);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Codigo_Equipo_Especial
            // 
            this.txt_Codigo_Equipo_Especial.Location = new System.Drawing.Point(317, 145);
            this.txt_Codigo_Equipo_Especial.Name = "txt_Codigo_Equipo_Especial";
            this.txt_Codigo_Equipo_Especial.Pp_campo = "codigo_equipo_especial";
            this.txt_Codigo_Equipo_Especial.Pp_MensajeError = null;
            this.txt_Codigo_Equipo_Especial.Pp_Validable = false;
            this.txt_Codigo_Equipo_Especial.Size = new System.Drawing.Size(192, 20);
            this.txt_Codigo_Equipo_Especial.TabIndex = 0;
            // 
            // txt_Cuit_Cliente
            // 
            this.txt_Cuit_Cliente.Location = new System.Drawing.Point(317, 171);
            this.txt_Cuit_Cliente.Name = "txt_Cuit_Cliente";
            this.txt_Cuit_Cliente.Pp_campo = "cuit_cliente";
            this.txt_Cuit_Cliente.Pp_MensajeError = null;
            this.txt_Cuit_Cliente.Pp_Validable = false;
            this.txt_Cuit_Cliente.Size = new System.Drawing.Size(192, 20);
            this.txt_Cuit_Cliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Código Equipo Especial";
            // 
            // txt_Nombre_Equipo_Especial
            // 
            this.txt_Nombre_Equipo_Especial.Location = new System.Drawing.Point(317, 201);
            this.txt_Nombre_Equipo_Especial.Name = "txt_Nombre_Equipo_Especial";
            this.txt_Nombre_Equipo_Especial.Pp_campo = "nombre_equipo_especial";
            this.txt_Nombre_Equipo_Especial.Pp_MensajeError = null;
            this.txt_Nombre_Equipo_Especial.Pp_Validable = false;
            this.txt_Nombre_Equipo_Especial.Size = new System.Drawing.Size(192, 20);
            this.txt_Nombre_Equipo_Especial.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cuit Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombre Equipo Especial";
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Location = new System.Drawing.Point(555, 169);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_Consultar.TabIndex = 3;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // Frm_ABMEquipoEspecial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_Consultar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Nombre_Equipo_Especial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Cuit_Cliente);
            this.Controls.Add(this.txt_Codigo_Equipo_Especial);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btn_Eliminar_Equipo_Especial);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_Modificar_Equipo_Especial);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_Agregar_Equipo_Especial);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grid_Equipo_Especial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_ABMEquipoEspecial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipos Especiales";
            ((System.ComponentModel.ISupportInitialize)(this.grid_Equipo_Especial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_Equipo_Especial;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Agregar_Equipo_Especial;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_Modificar_Equipo_Especial;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_Eliminar_Equipo_Especial;
        private Clases.TextBox01 txt_Codigo_Equipo_Especial;
        private Clases.TextBox01 txt_Cuit_Cliente;
        private System.Windows.Forms.Label label1;
        private Clases.TextBox01 txt_Nombre_Equipo_Especial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_equipo_especial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_equipo_especial;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
    }
}