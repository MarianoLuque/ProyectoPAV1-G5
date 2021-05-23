namespace Proyecto_PAV1_G5.ABM.Equipos.Equipos_Simples
{
    partial class Frm_ABMEquipoSimple
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
            this.grid_Equipos_Simples = new System.Windows.Forms.DataGridView();
            this.codigo_equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_mayorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_minorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Agregar_Equipo = new System.Windows.Forms.Button();
            this.btn_Modificar_Equipo = new System.Windows.Forms.Button();
            this.btn_Eliminar_Equipo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Codigo_Equipo = new System.Windows.Forms.TextBox();
            this.txt_Nombre_Equipo = new System.Windows.Forms.TextBox();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Equipos_Simples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_Equipos_Simples
            // 
            this.grid_Equipos_Simples.AllowUserToAddRows = false;
            this.grid_Equipos_Simples.AllowUserToDeleteRows = false;
            this.grid_Equipos_Simples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Equipos_Simples.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_equipo,
            this.precio_mayorista,
            this.precio_minorista,
            this.nombre_equipo});
            this.grid_Equipos_Simples.Location = new System.Drawing.Point(12, 221);
            this.grid_Equipos_Simples.Name = "grid_Equipos_Simples";
            this.grid_Equipos_Simples.ReadOnly = true;
            this.grid_Equipos_Simples.Size = new System.Drawing.Size(760, 276);
            this.grid_Equipos_Simples.TabIndex = 4;
            this.grid_Equipos_Simples.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Equipos_Simples_CellClick);
            // 
            // codigo_equipo
            // 
            this.codigo_equipo.HeaderText = "Codigo Equipo";
            this.codigo_equipo.Name = "codigo_equipo";
            this.codigo_equipo.ReadOnly = true;
            // 
            // precio_mayorista
            // 
            this.precio_mayorista.HeaderText = "Precio Mayorista";
            this.precio_mayorista.Name = "precio_mayorista";
            this.precio_mayorista.ReadOnly = true;
            this.precio_mayorista.Width = 150;
            // 
            // precio_minorista
            // 
            this.precio_minorista.HeaderText = "Precio Minorista";
            this.precio_minorista.Name = "precio_minorista";
            this.precio_minorista.ReadOnly = true;
            this.precio_minorista.Width = 150;
            // 
            // nombre_equipo
            // 
            this.nombre_equipo.HeaderText = "Nombre Equipo";
            this.nombre_equipo.Name = "nombre_equipo";
            this.nombre_equipo.ReadOnly = true;
            this.nombre_equipo.Width = 300;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Lucida Fax", 20.25F);
            this.textBox1.Location = new System.Drawing.Point(199, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 32);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Equipos Simples";
            // 
            // btn_Agregar_Equipo
            // 
            this.btn_Agregar_Equipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Agregar_Equipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar_Equipo.Location = new System.Drawing.Point(119, 519);
            this.btn_Agregar_Equipo.Name = "btn_Agregar_Equipo";
            this.btn_Agregar_Equipo.Size = new System.Drawing.Size(100, 30);
            this.btn_Agregar_Equipo.TabIndex = 3;
            this.btn_Agregar_Equipo.Text = "Agregar";
            this.btn_Agregar_Equipo.UseVisualStyleBackColor = true;
            this.btn_Agregar_Equipo.Click += new System.EventHandler(this.btn_Agregar_Equipo_Click);
            // 
            // btn_Modificar_Equipo
            // 
            this.btn_Modificar_Equipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Modificar_Equipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar_Equipo.Location = new System.Drawing.Point(355, 519);
            this.btn_Modificar_Equipo.Name = "btn_Modificar_Equipo";
            this.btn_Modificar_Equipo.Size = new System.Drawing.Size(100, 30);
            this.btn_Modificar_Equipo.TabIndex = 5;
            this.btn_Modificar_Equipo.Text = "Editar";
            this.btn_Modificar_Equipo.UseVisualStyleBackColor = true;
            this.btn_Modificar_Equipo.Click += new System.EventHandler(this.btn_Modificar_Equipo_Click);
            // 
            // btn_Eliminar_Equipo
            // 
            this.btn_Eliminar_Equipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Eliminar_Equipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar_Equipo.Location = new System.Drawing.Point(591, 519);
            this.btn_Eliminar_Equipo.Name = "btn_Eliminar_Equipo";
            this.btn_Eliminar_Equipo.Size = new System.Drawing.Size(100, 30);
            this.btn_Eliminar_Equipo.TabIndex = 6;
            this.btn_Eliminar_Equipo.Text = "Eliminar";
            this.btn_Eliminar_Equipo.UseVisualStyleBackColor = true;
            this.btn_Eliminar_Equipo.Click += new System.EventHandler(this.btn_Eliminar_Equipo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Codigo Equipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre Equipo";
            // 
            // txt_Codigo_Equipo
            // 
            this.txt_Codigo_Equipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo_Equipo.Location = new System.Drawing.Point(263, 173);
            this.txt_Codigo_Equipo.Name = "txt_Codigo_Equipo";
            this.txt_Codigo_Equipo.Size = new System.Drawing.Size(192, 26);
            this.txt_Codigo_Equipo.TabIndex = 1;
            // 
            // txt_Nombre_Equipo
            // 
            this.txt_Nombre_Equipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre_Equipo.Location = new System.Drawing.Point(263, 134);
            this.txt_Nombre_Equipo.Name = "txt_Nombre_Equipo";
            this.txt_Nombre_Equipo.Size = new System.Drawing.Size(192, 26);
            this.txt_Nombre_Equipo.TabIndex = 0;
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Consultar.Location = new System.Drawing.Point(490, 173);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(95, 27);
            this.btn_Consultar.TabIndex = 2;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
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
            this.pictureBox1.BackgroundImage = global::Proyecto_PAV1_G5.Properties.Resources._002_desktop_computer;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(438, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 82);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_ABMEquipoSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Codigo_Equipo);
            this.Controls.Add(this.txt_Nombre_Equipo);
            this.Controls.Add(this.btn_Consultar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btn_Eliminar_Equipo);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_Modificar_Equipo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_Agregar_Equipo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grid_Equipos_Simples);
            this.MaximizeBox = false;
            this.Name = "Frm_ABMEquipoSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipos Simples";
            ((System.ComponentModel.ISupportInitialize)(this.grid_Equipos_Simples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_Equipos_Simples;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Agregar_Equipo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_Modificar_Equipo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_Eliminar_Equipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Codigo_Equipo;
        private System.Windows.Forms.TextBox txt_Nombre_Equipo;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_mayorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_minorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_equipo;
    }
}