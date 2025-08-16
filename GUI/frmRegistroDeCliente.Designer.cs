namespace ProyectoFinal03.GUI
{
    partial class frmRegistroDeCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroDeCliente));
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.lblTelefonoEmpleado = new System.Windows.Forms.Label();
            this.lblFechaContratacion = new System.Windows.Forms.Label();
            this.lblCorreoEmpleado = new System.Windows.Forms.Label();
            this.lblGeneroEmpleado = new System.Windows.Forms.Label();
            this.lblPuestoEmpleado = new System.Windows.Forms.Label();
            this.lblSueldoEmleado = new System.Windows.Forms.Label();
            this.lblRegsitroEmpleado2 = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxGenero = new System.Windows.Forms.TextBox();
            this.tbxTelefono = new System.Windows.Forms.TextBox();
            this.tbxCorreo = new System.Windows.Forms.TextBox();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.cbxfiel = new System.Windows.Forms.CheckBox();
            this.cbxfiel2 = new System.Windows.Forms.CheckBox();
            this.tbxNacionalidad = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.IbtnAtras = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txbBuscarNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(242, 92);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(44, 13);
            this.lblNombreEmpleado.TabIndex = 0;
            this.lblNombreEmpleado.Text = "Nombre";
            this.lblNombreEmpleado.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTelefonoEmpleado
            // 
            this.lblTelefonoEmpleado.AutoSize = true;
            this.lblTelefonoEmpleado.Location = new System.Drawing.Point(242, 137);
            this.lblTelefonoEmpleado.Name = "lblTelefonoEmpleado";
            this.lblTelefonoEmpleado.Size = new System.Drawing.Size(49, 13);
            this.lblTelefonoEmpleado.TabIndex = 1;
            this.lblTelefonoEmpleado.Text = "Telefono";
            // 
            // lblFechaContratacion
            // 
            this.lblFechaContratacion.AutoSize = true;
            this.lblFechaContratacion.Location = new System.Drawing.Point(237, 210);
            this.lblFechaContratacion.Name = "lblFechaContratacion";
            this.lblFechaContratacion.Size = new System.Drawing.Size(96, 13);
            this.lblFechaContratacion.TabIndex = 2;
            this.lblFechaContratacion.Text = "Fecha De Registro";
            // 
            // lblCorreoEmpleado
            // 
            this.lblCorreoEmpleado.AutoSize = true;
            this.lblCorreoEmpleado.Location = new System.Drawing.Point(242, 159);
            this.lblCorreoEmpleado.Name = "lblCorreoEmpleado";
            this.lblCorreoEmpleado.Size = new System.Drawing.Size(38, 13);
            this.lblCorreoEmpleado.TabIndex = 3;
            this.lblCorreoEmpleado.Text = "Correo";
            // 
            // lblGeneroEmpleado
            // 
            this.lblGeneroEmpleado.AutoSize = true;
            this.lblGeneroEmpleado.Location = new System.Drawing.Point(242, 114);
            this.lblGeneroEmpleado.Name = "lblGeneroEmpleado";
            this.lblGeneroEmpleado.Size = new System.Drawing.Size(42, 13);
            this.lblGeneroEmpleado.TabIndex = 4;
            this.lblGeneroEmpleado.Text = "Genero";
            // 
            // lblPuestoEmpleado
            // 
            this.lblPuestoEmpleado.AutoSize = true;
            this.lblPuestoEmpleado.Location = new System.Drawing.Point(231, 184);
            this.lblPuestoEmpleado.Name = "lblPuestoEmpleado";
            this.lblPuestoEmpleado.Size = new System.Drawing.Size(69, 13);
            this.lblPuestoEmpleado.TabIndex = 5;
            this.lblPuestoEmpleado.Text = "Nacionalidad";
            // 
            // lblSueldoEmleado
            // 
            this.lblSueldoEmleado.AutoSize = true;
            this.lblSueldoEmleado.Location = new System.Drawing.Point(250, 248);
            this.lblSueldoEmleado.Name = "lblSueldoEmleado";
            this.lblSueldoEmleado.Size = new System.Drawing.Size(41, 13);
            this.lblSueldoEmleado.TabIndex = 6;
            this.lblSueldoEmleado.Text = "abitual ";
            // 
            // lblRegsitroEmpleado2
            // 
            this.lblRegsitroEmpleado2.AutoSize = true;
            this.lblRegsitroEmpleado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegsitroEmpleado2.Location = new System.Drawing.Point(279, 22);
            this.lblRegsitroEmpleado2.Name = "lblRegsitroEmpleado2";
            this.lblRegsitroEmpleado2.Size = new System.Drawing.Size(229, 25);
            this.lblRegsitroEmpleado2.TabIndex = 7;
            this.lblRegsitroEmpleado2.Text = "Resgistro De Cliente";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(294, 92);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(100, 20);
            this.tbxNombre.TabIndex = 11;
            // 
            // tbxGenero
            // 
            this.tbxGenero.Location = new System.Drawing.Point(294, 115);
            this.tbxGenero.Name = "tbxGenero";
            this.tbxGenero.Size = new System.Drawing.Size(100, 20);
            this.tbxGenero.TabIndex = 12;
            // 
            // tbxTelefono
            // 
            this.tbxTelefono.Location = new System.Drawing.Point(294, 137);
            this.tbxTelefono.Name = "tbxTelefono";
            this.tbxTelefono.Size = new System.Drawing.Size(100, 20);
            this.tbxTelefono.TabIndex = 13;
            // 
            // tbxCorreo
            // 
            this.tbxCorreo.Location = new System.Drawing.Point(294, 161);
            this.tbxCorreo.Name = "tbxCorreo";
            this.tbxCorreo.Size = new System.Drawing.Size(100, 20);
            this.tbxCorreo.TabIndex = 14;
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Location = new System.Drawing.Point(339, 210);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaRegistro.TabIndex = 17;
            // 
            // cbxfiel
            // 
            this.cbxfiel.AutoSize = true;
            this.cbxfiel.Location = new System.Drawing.Point(297, 244);
            this.cbxfiel.Name = "cbxfiel";
            this.cbxfiel.Size = new System.Drawing.Size(36, 17);
            this.cbxfiel.TabIndex = 18;
            this.cbxfiel.Text = "SI";
            this.cbxfiel.UseVisualStyleBackColor = true;
            // 
            // cbxfiel2
            // 
            this.cbxfiel2.AutoSize = true;
            this.cbxfiel2.Location = new System.Drawing.Point(328, 244);
            this.cbxfiel2.Name = "cbxfiel2";
            this.cbxfiel2.Size = new System.Drawing.Size(42, 17);
            this.cbxfiel2.TabIndex = 19;
            this.cbxfiel2.Text = "NO";
            this.cbxfiel2.UseVisualStyleBackColor = true;
            // 
            // tbxNacionalidad
            // 
            this.tbxNacionalidad.Location = new System.Drawing.Point(297, 184);
            this.tbxNacionalidad.Name = "tbxNacionalidad";
            this.tbxNacionalidad.Size = new System.Drawing.Size(100, 20);
            this.tbxNacionalidad.TabIndex = 24;
            this.tbxNacionalidad.TextChanged += new System.EventHandler(this.tbxNacionalidad_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(514, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(740, 503);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 94;
            this.label7.Text = "Atras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "Salir";
            // 
            // iconButton4
            // 
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 19;
            this.iconButton4.Location = new System.Drawing.Point(12, 475);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(73, 25);
            this.iconButton4.TabIndex = 89;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // IbtnAtras
            // 
            this.IbtnAtras.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.IbtnAtras.IconColor = System.Drawing.Color.Black;
            this.IbtnAtras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnAtras.IconSize = 20;
            this.IbtnAtras.Location = new System.Drawing.Point(725, 475);
            this.IbtnAtras.Name = "IbtnAtras";
            this.IbtnAtras.Size = new System.Drawing.Size(60, 24);
            this.IbtnAtras.TabIndex = 85;
            this.IbtnAtras.UseVisualStyleBackColor = true;
            this.IbtnAtras.Click += new System.EventHandler(this.IbtnAtras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 100;
            this.label1.Text = "Ingrese el Nombre";
            // 
            // txbBuscarNombre
            // 
            this.txbBuscarNombre.Location = new System.Drawing.Point(318, 480);
            this.txbBuscarNombre.Name = "txbBuscarNombre";
            this.txbBuscarNombre.Size = new System.Drawing.Size(153, 20);
            this.txbBuscarNombre.TabIndex = 99;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 507);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 98;
            this.label5.Text = "Buscar";
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.Location = new System.Drawing.Point(504, 480);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(75, 23);
            this.iconButton2.TabIndex = 97;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(29, 300);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(742, 150);
            this.dgvClientes.TabIndex = 101;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(601, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 103;
            this.label2.Text = "Eliminar";
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 19;
            this.iconButton1.Location = new System.Drawing.Point(585, 481);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(73, 23);
            this.iconButton1.TabIndex = 102;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // frmRegistroDeCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbBuscarNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.IbtnAtras);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxNacionalidad);
            this.Controls.Add(this.cbxfiel2);
            this.Controls.Add(this.cbxfiel);
            this.Controls.Add(this.dtpFechaRegistro);
            this.Controls.Add(this.tbxCorreo);
            this.Controls.Add(this.tbxTelefono);
            this.Controls.Add(this.tbxGenero);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.lblRegsitroEmpleado2);
            this.Controls.Add(this.lblSueldoEmleado);
            this.Controls.Add(this.lblPuestoEmpleado);
            this.Controls.Add(this.lblGeneroEmpleado);
            this.Controls.Add(this.lblCorreoEmpleado);
            this.Controls.Add(this.lblFechaContratacion);
            this.Controls.Add(this.lblTelefonoEmpleado);
            this.Controls.Add(this.lblNombreEmpleado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistroDeCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro De Cliente";
            this.Load += new System.EventHandler(this.frmRegistroDeCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.Label lblTelefonoEmpleado;
        private System.Windows.Forms.Label lblFechaContratacion;
        private System.Windows.Forms.Label lblCorreoEmpleado;
        private System.Windows.Forms.Label lblGeneroEmpleado;
        private System.Windows.Forms.Label lblPuestoEmpleado;
        private System.Windows.Forms.Label lblSueldoEmleado;
        private System.Windows.Forms.Label lblRegsitroEmpleado2;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxGenero;
        private System.Windows.Forms.TextBox tbxTelefono;
        private System.Windows.Forms.TextBox tbxCorreo;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.CheckBox cbxfiel;
        private System.Windows.Forms.CheckBox cbxfiel2;
        private System.Windows.Forms.TextBox tbxNacionalidad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton IbtnAtras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbBuscarNombre;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}