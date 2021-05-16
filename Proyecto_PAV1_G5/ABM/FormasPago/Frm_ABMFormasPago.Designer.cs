namespace Proyecto_PAV1_G5.ABM.FormasPago
{
    partial class Frm_ABMFormasPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ABMFormasPago));
            this.grid_forma_pago = new System.Windows.Forms.DataGridView();
            this.id_forma_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_forma_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_patron_nombre_forma_pago = new System.Windows.Forms.TextBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_forma_pago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_forma_pago
            // 
            this.grid_forma_pago.AllowUserToAddRows = false;
            this.grid_forma_pago.AllowUserToDeleteRows = false;
            this.grid_forma_pago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_forma_pago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_forma_pago,
            this.nombre_forma_pago,
            this.interes,
            this.descuento});
            this.grid_forma_pago.Location = new System.Drawing.Point(16, 170);
            this.grid_forma_pago.Name = "grid_forma_pago";
            this.grid_forma_pago.ReadOnly = true;
            this.grid_forma_pago.Size = new System.Drawing.Size(675, 254);
            this.grid_forma_pago.TabIndex = 5;
            this.grid_forma_pago.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_forma_pago_CellClick);
            // 
            // id_forma_pago
            // 
            this.id_forma_pago.HeaderText = "ID Forma Pago";
            this.id_forma_pago.Name = "id_forma_pago";
            this.id_forma_pago.ReadOnly = true;
            this.id_forma_pago.Width = 150;
            // 
            // nombre_forma_pago
            // 
            this.nombre_forma_pago.HeaderText = "Nombre Forma de Pago";
            this.nombre_forma_pago.Name = "nombre_forma_pago";
            this.nombre_forma_pago.ReadOnly = true;
            this.nombre_forma_pago.Width = 250;
            // 
            // interes
            // 
            this.interes.HeaderText = "Interes";
            this.interes.Name = "interes";
            this.interes.ReadOnly = true;
            // 
            // descuento
            // 
            this.descuento.HeaderText = "Descuento";
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Lucida Fax", 20.25F);
            this.textBox1.Location = new System.Drawing.Point(166, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 32);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Formas de Pago";
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(81, 445);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(100, 30);
            this.btn_agregar.TabIndex = 2;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(317, 445);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(100, 30);
            this.btn_modificar.TabIndex = 3;
            this.btn_modificar.Text = "Editar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(553, 445);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(100, 30);
            this.btn_eliminar.TabIndex = 4;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre Forma de Pago";
            // 
            // txt_patron_nombre_forma_pago
            // 
            this.txt_patron_nombre_forma_pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patron_nombre_forma_pago.Location = new System.Drawing.Point(207, 109);
            this.txt_patron_nombre_forma_pago.Name = "txt_patron_nombre_forma_pago";
            this.txt_patron_nombre_forma_pago.Size = new System.Drawing.Size(181, 26);
            this.txt_patron_nombre_forma_pago.TabIndex = 0;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.Location = new System.Drawing.Point(527, 124);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(94, 30);
            this.btn_consultar.TabIndex = 1;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Proyecto_PAV1_G5.Properties.Resources._003_delete;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(517, 445);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Proyecto_PAV1_G5.Properties.Resources._002_edit;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(281, 445);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Proyecto_PAV1_G5.Properties.Resources._001__add;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(45, 445);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Proyecto_PAV1_G5.Properties.Resources.credit_card;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(386, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 82);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_ABMFormasPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_patron_nombre_forma_pago);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grid_forma_pago);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_ABMFormasPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formas de Pago";
            ((System.ComponentModel.ISupportInitialize)(this.grid_forma_pago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_forma_pago;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_patron_nombre_forma_pago;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_forma_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_forma_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn interes;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
    }
}