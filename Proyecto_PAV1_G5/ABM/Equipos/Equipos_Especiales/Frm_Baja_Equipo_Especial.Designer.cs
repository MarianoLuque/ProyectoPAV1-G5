namespace Proyecto_PAV1_G5.ABM.Equipos.Equipos_Especiales
{
    partial class Frm_Baja_Equipo_Especial
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
            this.label_codigo = new System.Windows.Forms.Label();
            this.label_cuit = new System.Windows.Forms.Label();
            this.label_descripcion = new System.Windows.Forms.Label();
            this.label_precio_minorista = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label_titulo = new System.Windows.Forms.Label();
            this.cmb_clientes = new Proyecto_PAV1_G5.Clases.ComboBox01();
            this.grid_articulos = new Proyecto_PAV1_G5.Clases.Grid01();
            this.txt_Nombre = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_Precio_Mayorista = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_Precio_Minorista = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_Descripcion = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.txt_Codigo_Equipo = new Proyecto_PAV1_G5.Clases.TextBox01();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // label_codigo
            // 
            this.label_codigo.AutoSize = true;
            this.label_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_codigo.Location = new System.Drawing.Point(112, 200);
            this.label_codigo.Name = "label_codigo";
            this.label_codigo.Size = new System.Drawing.Size(59, 20);
            this.label_codigo.TabIndex = 1;
            this.label_codigo.Text = "Codigo";
            // 
            // label_cuit
            // 
            this.label_cuit.AutoSize = true;
            this.label_cuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cuit.Location = new System.Drawing.Point(68, 243);
            this.label_cuit.Name = "label_cuit";
            this.label_cuit.Size = new System.Drawing.Size(103, 20);
            this.label_cuit.TabIndex = 1;
            this.label_cuit.Text = "Razón Social";
            // 
            // label_descripcion
            // 
            this.label_descripcion.AutoSize = true;
            this.label_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_descripcion.Location = new System.Drawing.Point(79, 286);
            this.label_descripcion.Name = "label_descripcion";
            this.label_descripcion.Size = new System.Drawing.Size(92, 20);
            this.label_descripcion.TabIndex = 1;
            this.label_descripcion.Text = "Descripcion";
            // 
            // label_precio_minorista
            // 
            this.label_precio_minorista.AutoSize = true;
            this.label_precio_minorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_precio_minorista.Location = new System.Drawing.Point(50, 71);
            this.label_precio_minorista.Name = "label_precio_minorista";
            this.label_precio_minorista.Size = new System.Drawing.Size(121, 20);
            this.label_precio_minorista.TabIndex = 1;
            this.label_precio_minorista.Text = "Precio Minorista";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nombre Equipo";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Location = new System.Drawing.Point(177, 335);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(87, 30);
            this.btn_aceptar.TabIndex = 6;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Precio Mayorista";
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(12, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(108, 39);
            this.label_titulo.TabIndex = 7;
            this.label_titulo.Text = "Titulo";
            // 
            // cmb_clientes
            // 
            this.cmb_clientes.Enabled = false;
            this.cmb_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_clientes.FormattingEnabled = true;
            this.cmb_clientes.Location = new System.Drawing.Point(177, 240);
            this.cmb_clientes.Name = "cmb_clientes";
            this.cmb_clientes.Pp_Conseleccion = false;
            this.cmb_clientes.Pp_MensajeError = null;
            this.cmb_clientes.Pp_NombreCampo = null;
            this.cmb_clientes.Pp_Validable = false;
            this.cmb_clientes.Size = new System.Drawing.Size(233, 28);
            this.cmb_clientes.TabIndex = 15;
            // 
            // grid_articulos
            // 
            this.grid_articulos.AllowUserToAddRows = false;
            this.grid_articulos.AllowUserToDeleteRows = false;
            this.grid_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_articulos.Location = new System.Drawing.Point(436, 71);
            this.grid_articulos.Name = "grid_articulos";
            this.grid_articulos.ReadOnly = true;
            this.grid_articulos.Size = new System.Drawing.Size(570, 238);
            this.grid_articulos.TabIndex = 8;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(177, 154);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Pp_campo = "nombre_equipo_especial";
            this.txt_Nombre.Pp_MensajeError = "Falta cargar el nombre del equipo";
            this.txt_Nombre.Pp_Validable = false;
            this.txt_Nombre.ReadOnly = true;
            this.txt_Nombre.Size = new System.Drawing.Size(233, 26);
            this.txt_Nombre.TabIndex = 4;
            // 
            // txt_Precio_Mayorista
            // 
            this.txt_Precio_Mayorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Precio_Mayorista.Location = new System.Drawing.Point(177, 111);
            this.txt_Precio_Mayorista.Name = "txt_Precio_Mayorista";
            this.txt_Precio_Mayorista.Pp_campo = "precio_mayorista";
            this.txt_Precio_Mayorista.Pp_MensajeError = "Falta cargar el precio mayorista";
            this.txt_Precio_Mayorista.Pp_Validable = false;
            this.txt_Precio_Mayorista.ReadOnly = true;
            this.txt_Precio_Mayorista.Size = new System.Drawing.Size(233, 26);
            this.txt_Precio_Mayorista.TabIndex = 3;
            // 
            // txt_Precio_Minorista
            // 
            this.txt_Precio_Minorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Precio_Minorista.Location = new System.Drawing.Point(177, 71);
            this.txt_Precio_Minorista.Name = "txt_Precio_Minorista";
            this.txt_Precio_Minorista.Pp_campo = "precio_minorista";
            this.txt_Precio_Minorista.Pp_MensajeError = "Falta cargar el precio minorista";
            this.txt_Precio_Minorista.Pp_Validable = false;
            this.txt_Precio_Minorista.ReadOnly = true;
            this.txt_Precio_Minorista.Size = new System.Drawing.Size(233, 26);
            this.txt_Precio_Minorista.TabIndex = 3;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descripcion.Location = new System.Drawing.Point(177, 283);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Pp_campo = "descripcion";
            this.txt_Descripcion.Pp_MensajeError = "Falta cargar la descripcion";
            this.txt_Descripcion.Pp_Validable = false;
            this.txt_Descripcion.ReadOnly = true;
            this.txt_Descripcion.Size = new System.Drawing.Size(233, 26);
            this.txt_Descripcion.TabIndex = 2;
            // 
            // txt_Codigo_Equipo
            // 
            this.txt_Codigo_Equipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo_Equipo.Location = new System.Drawing.Point(177, 197);
            this.txt_Codigo_Equipo.Name = "txt_Codigo_Equipo";
            this.txt_Codigo_Equipo.Pp_campo = "codigo_equipo_especial";
            this.txt_Codigo_Equipo.Pp_MensajeError = "Falta cargar el código";
            this.txt_Codigo_Equipo.Pp_Validable = false;
            this.txt_Codigo_Equipo.ReadOnly = true;
            this.txt_Codigo_Equipo.Size = new System.Drawing.Size(233, 26);
            this.txt_Codigo_Equipo.TabIndex = 0;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(323, 335);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(87, 30);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // Frm_Baja_Equipo_Especial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 392);
            this.ControlBox = false;
            this.Controls.Add(this.cmb_clientes);
            this.Controls.Add(this.grid_articulos);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_precio_minorista);
            this.Controls.Add(this.label_descripcion);
            this.Controls.Add(this.label_cuit);
            this.Controls.Add(this.label_codigo);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Precio_Mayorista);
            this.Controls.Add(this.txt_Precio_Minorista);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.txt_Codigo_Equipo);
            this.Name = "Frm_Baja_Equipo_Especial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Equipo";
            this.Load += new System.EventHandler(this.Frm_Baja_Equipo_Especial_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.grid_articulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.TextBox01 txt_Codigo_Equipo;
        private System.Windows.Forms.Label label_codigo;
        private System.Windows.Forms.Label label_cuit;
        private System.Windows.Forms.Label label_descripcion;
        private System.Windows.Forms.Label label_precio_minorista;
        private System.Windows.Forms.Label label5;
        private Clases.TextBox01 txt_Descripcion;
        private Clases.TextBox01 txt_Precio_Minorista;
        private Clases.TextBox01 txt_Nombre;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label label7;
        private Clases.TextBox01 txt_Precio_Mayorista;
        private System.Windows.Forms.Label label_titulo;
        private Clases.Grid01 grid_articulos;
        private Clases.ComboBox01 cmb_clientes;
        private System.Windows.Forms.Button btn_cancelar;
    }
}