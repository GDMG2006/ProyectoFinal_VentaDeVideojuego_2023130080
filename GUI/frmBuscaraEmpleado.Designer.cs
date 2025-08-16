namespace ProyectoFinal03.GUI
{
    partial class frmBuscaraEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscaraEmpleado));
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.lblBuscarEmpleado = new System.Windows.Forms.Label();
            this.dtpFechaContratacion = new System.Windows.Forms.DateTimePicker();
            this.tbxCorreo2 = new System.Windows.Forms.TextBox();
            this.tbxTelefono2 = new System.Windows.Forms.TextBox();
            this.tbxNombre2 = new System.Windows.Forms.TextBox();
            this.txbSueldo = new System.Windows.Forms.TextBox();
            this.lblSueldoEmleado = new System.Windows.Forms.Label();
            this.lblPuestoEmpleado = new System.Windows.Forms.Label();
            this.lblGeneroEmpleado = new System.Windows.Forms.Label();
            this.lblCorreoEmpleado = new System.Windows.Forms.Label();
            this.lblFechaContratacion = new System.Windows.Forms.Label();
            this.lblTelefonoEmpleado = new System.Windows.Forms.Label();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aliniamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colocarPrimeNombreYPrimerApellidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telefonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colocarSolo8DigitosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siempreColocargmailcomAlfinalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usarLaComaSiempreEnCada3DigitosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplo20000ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.IbtnAtras = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbBuscarNacionalidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.lbxGenero = new System.Windows.Forms.ListBox();
            this.cbxpuesto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(43, 247);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(714, 150);
            this.dgvEmpleados.TabIndex = 60;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            // 
            // lblBuscarEmpleado
            // 
            this.lblBuscarEmpleado.AutoSize = true;
            this.lblBuscarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarEmpleado.Location = new System.Drawing.Point(347, 13);
            this.lblBuscarEmpleado.Name = "lblBuscarEmpleado";
            this.lblBuscarEmpleado.Size = new System.Drawing.Size(196, 25);
            this.lblBuscarEmpleado.TabIndex = 54;
            this.lblBuscarEmpleado.Text = "Buscar Empleado";
            // 
            // dtpFechaContratacion
            // 
            this.dtpFechaContratacion.Location = new System.Drawing.Point(404, 199);
            this.dtpFechaContratacion.Name = "dtpFechaContratacion";
            this.dtpFechaContratacion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaContratacion.TabIndex = 53;
            // 
            // tbxCorreo2
            // 
            this.tbxCorreo2.Location = new System.Drawing.Point(333, 129);
            this.tbxCorreo2.Name = "tbxCorreo2";
            this.tbxCorreo2.Size = new System.Drawing.Size(100, 20);
            this.tbxCorreo2.TabIndex = 51;
            // 
            // tbxTelefono2
            // 
            this.tbxTelefono2.Location = new System.Drawing.Point(333, 105);
            this.tbxTelefono2.Name = "tbxTelefono2";
            this.tbxTelefono2.Size = new System.Drawing.Size(100, 20);
            this.tbxTelefono2.TabIndex = 50;
            // 
            // tbxNombre2
            // 
            this.tbxNombre2.Location = new System.Drawing.Point(333, 60);
            this.tbxNombre2.Name = "tbxNombre2";
            this.tbxNombre2.Size = new System.Drawing.Size(100, 20);
            this.tbxNombre2.TabIndex = 48;
            // 
            // txbSueldo
            // 
            this.txbSueldo.Location = new System.Drawing.Point(333, 177);
            this.txbSueldo.Name = "txbSueldo";
            this.txbSueldo.Size = new System.Drawing.Size(100, 20);
            this.txbSueldo.TabIndex = 47;
            // 
            // lblSueldoEmleado
            // 
            this.lblSueldoEmleado.AutoSize = true;
            this.lblSueldoEmleado.Location = new System.Drawing.Point(281, 177);
            this.lblSueldoEmleado.Name = "lblSueldoEmleado";
            this.lblSueldoEmleado.Size = new System.Drawing.Size(40, 13);
            this.lblSueldoEmleado.TabIndex = 46;
            this.lblSueldoEmleado.Text = "Sueldo";
            // 
            // lblPuestoEmpleado
            // 
            this.lblPuestoEmpleado.AutoSize = true;
            this.lblPuestoEmpleado.Location = new System.Drawing.Point(281, 152);
            this.lblPuestoEmpleado.Name = "lblPuestoEmpleado";
            this.lblPuestoEmpleado.Size = new System.Drawing.Size(40, 13);
            this.lblPuestoEmpleado.TabIndex = 45;
            this.lblPuestoEmpleado.Text = "Puesto";
            // 
            // lblGeneroEmpleado
            // 
            this.lblGeneroEmpleado.AutoSize = true;
            this.lblGeneroEmpleado.Location = new System.Drawing.Point(281, 82);
            this.lblGeneroEmpleado.Name = "lblGeneroEmpleado";
            this.lblGeneroEmpleado.Size = new System.Drawing.Size(42, 13);
            this.lblGeneroEmpleado.TabIndex = 44;
            this.lblGeneroEmpleado.Text = "Genero";
            // 
            // lblCorreoEmpleado
            // 
            this.lblCorreoEmpleado.AutoSize = true;
            this.lblCorreoEmpleado.Location = new System.Drawing.Point(281, 127);
            this.lblCorreoEmpleado.Name = "lblCorreoEmpleado";
            this.lblCorreoEmpleado.Size = new System.Drawing.Size(38, 13);
            this.lblCorreoEmpleado.TabIndex = 43;
            this.lblCorreoEmpleado.Text = "Correo";
            // 
            // lblFechaContratacion
            // 
            this.lblFechaContratacion.AutoSize = true;
            this.lblFechaContratacion.Location = new System.Drawing.Point(281, 205);
            this.lblFechaContratacion.Name = "lblFechaContratacion";
            this.lblFechaContratacion.Size = new System.Drawing.Size(117, 13);
            this.lblFechaContratacion.TabIndex = 42;
            this.lblFechaContratacion.Text = "Fecha De Contratacion";
            // 
            // lblTelefonoEmpleado
            // 
            this.lblTelefonoEmpleado.AutoSize = true;
            this.lblTelefonoEmpleado.Location = new System.Drawing.Point(281, 105);
            this.lblTelefonoEmpleado.Name = "lblTelefonoEmpleado";
            this.lblTelefonoEmpleado.Size = new System.Drawing.Size(49, 13);
            this.lblTelefonoEmpleado.TabIndex = 41;
            this.lblTelefonoEmpleado.Text = "Telefono";
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(281, 60);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(44, 13);
            this.lblNombreEmpleado.TabIndex = 40;
            this.lblNombreEmpleado.Text = "Nombre";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aliniamentosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 62;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aliniamentosToolStripMenuItem
            // 
            this.aliniamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreToolStripMenuItem,
            this.telefonoToolStripMenuItem,
            this.correoToolStripMenuItem,
            this.sueldoToolStripMenuItem});
            this.aliniamentosToolStripMenuItem.Name = "aliniamentosToolStripMenuItem";
            this.aliniamentosToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.aliniamentosToolStripMenuItem.Text = "Aliniamentos";
            // 
            // nombreToolStripMenuItem
            // 
            this.nombreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colocarPrimeNombreYPrimerApellidoToolStripMenuItem});
            this.nombreToolStripMenuItem.Name = "nombreToolStripMenuItem";
            this.nombreToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.nombreToolStripMenuItem.Text = "Nombre";
            // 
            // colocarPrimeNombreYPrimerApellidoToolStripMenuItem
            // 
            this.colocarPrimeNombreYPrimerApellidoToolStripMenuItem.Name = "colocarPrimeNombreYPrimerApellidoToolStripMenuItem";
            this.colocarPrimeNombreYPrimerApellidoToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.colocarPrimeNombreYPrimerApellidoToolStripMenuItem.Text = "colocar Prime Nombre y Primer Apellido";
            // 
            // telefonoToolStripMenuItem
            // 
            this.telefonoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colocarSolo8DigitosToolStripMenuItem});
            this.telefonoToolStripMenuItem.Name = "telefonoToolStripMenuItem";
            this.telefonoToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.telefonoToolStripMenuItem.Text = "Telefono";
            // 
            // colocarSolo8DigitosToolStripMenuItem
            // 
            this.colocarSolo8DigitosToolStripMenuItem.Name = "colocarSolo8DigitosToolStripMenuItem";
            this.colocarSolo8DigitosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.colocarSolo8DigitosToolStripMenuItem.Text = "colocar solo 8 digitos";
            // 
            // correoToolStripMenuItem
            // 
            this.correoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siempreColocargmailcomAlfinalToolStripMenuItem});
            this.correoToolStripMenuItem.Name = "correoToolStripMenuItem";
            this.correoToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.correoToolStripMenuItem.Text = "correo ";
            // 
            // siempreColocargmailcomAlfinalToolStripMenuItem
            // 
            this.siempreColocargmailcomAlfinalToolStripMenuItem.Name = "siempreColocargmailcomAlfinalToolStripMenuItem";
            this.siempreColocargmailcomAlfinalToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.siempreColocargmailcomAlfinalToolStripMenuItem.Text = "siempre colocar @gmail.com alfinal ";
            // 
            // sueldoToolStripMenuItem
            // 
            this.sueldoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usarLaComaSiempreEnCada3DigitosToolStripMenuItem});
            this.sueldoToolStripMenuItem.Name = "sueldoToolStripMenuItem";
            this.sueldoToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.sueldoToolStripMenuItem.Text = "Sueldo ";
            // 
            // usarLaComaSiempreEnCada3DigitosToolStripMenuItem
            // 
            this.usarLaComaSiempreEnCada3DigitosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejemplo20000ToolStripMenuItem});
            this.usarLaComaSiempreEnCada3DigitosToolStripMenuItem.Name = "usarLaComaSiempreEnCada3DigitosToolStripMenuItem";
            this.usarLaComaSiempreEnCada3DigitosToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.usarLaComaSiempreEnCada3DigitosToolStripMenuItem.Text = "Usar la coma siempre en cada 3 digitos";
            // 
            // ejemplo20000ToolStripMenuItem
            // 
            this.ejemplo20000ToolStripMenuItem.Name = "ejemplo20000ToolStripMenuItem";
            this.ejemplo20000ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.ejemplo20000ToolStripMenuItem.Text = "ejemplo: 20,000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(742, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 94;
            this.label7.Text = "Atras";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(497, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 92;
            this.label5.Text = "Buscar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 432);
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
            this.iconButton4.Location = new System.Drawing.Point(12, 405);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(73, 25);
            this.iconButton4.TabIndex = 89;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.Location = new System.Drawing.Point(481, 407);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(75, 23);
            this.iconButton2.TabIndex = 87;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // IbtnAtras
            // 
            this.IbtnAtras.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.IbtnAtras.IconColor = System.Drawing.Color.Black;
            this.IbtnAtras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnAtras.IconSize = 20;
            this.IbtnAtras.Location = new System.Drawing.Point(728, 405);
            this.IbtnAtras.Name = "IbtnAtras";
            this.IbtnAtras.Size = new System.Drawing.Size(60, 24);
            this.IbtnAtras.TabIndex = 85;
            this.IbtnAtras.UseVisualStyleBackColor = true;
            this.IbtnAtras.Click += new System.EventHandler(this.IbtnAtras_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(549, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // txbBuscarNacionalidad
            // 
            this.txbBuscarNacionalidad.Location = new System.Drawing.Point(322, 410);
            this.txbBuscarNacionalidad.Name = "txbBuscarNacionalidad";
            this.txbBuscarNacionalidad.Size = new System.Drawing.Size(153, 20);
            this.txbBuscarNacionalidad.TabIndex = 95;
            this.txbBuscarNacionalidad.TextChanged += new System.EventHandler(this.txbBuscarNacionalidad_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 96;
            this.label1.Text = "Ingrese el Nombre del Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 99;
            this.label2.Text = "Eliminar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 19;
            this.iconButton1.Location = new System.Drawing.Point(562, 406);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(73, 23);
            this.iconButton1.TabIndex = 98;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // lbxGenero
            // 
            this.lbxGenero.FormattingEnabled = true;
            this.lbxGenero.Items.AddRange(new object[] {
            "Selecione",
            "Masculino ",
            "Femenino"});
            this.lbxGenero.Location = new System.Drawing.Point(333, 82);
            this.lbxGenero.Name = "lbxGenero";
            this.lbxGenero.Size = new System.Drawing.Size(104, 17);
            this.lbxGenero.TabIndex = 101;
            // 
            // cbxpuesto
            // 
            this.cbxpuesto.FormattingEnabled = true;
            this.cbxpuesto.Items.AddRange(new object[] {
            "Seleccionar",
            "Gerente de Ventas ",
            "Asesor de Ventas / Vendedor ",
            "Community Manager ",
            "Especialista en E-commerce ",
            "Responsable de Logística ",
            "Ejecutivo de Marketing Digital",
            "Atención al Cliente",
            "Comprador de Videojuegos ",
            "Desarrollador Web ",
            "Organizador de Eventos ",
            ""});
            this.cbxpuesto.Location = new System.Drawing.Point(333, 152);
            this.cbxpuesto.Name = "cbxpuesto";
            this.cbxpuesto.Size = new System.Drawing.Size(121, 21);
            this.cbxpuesto.TabIndex = 102;
            // 
            // frmBuscaraEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxpuesto);
            this.Controls.Add(this.lbxGenero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbBuscarNacionalidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.IbtnAtras);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.lblBuscarEmpleado);
            this.Controls.Add(this.dtpFechaContratacion);
            this.Controls.Add(this.tbxCorreo2);
            this.Controls.Add(this.tbxTelefono2);
            this.Controls.Add(this.tbxNombre2);
            this.Controls.Add(this.txbSueldo);
            this.Controls.Add(this.lblSueldoEmleado);
            this.Controls.Add(this.lblPuestoEmpleado);
            this.Controls.Add(this.lblGeneroEmpleado);
            this.Controls.Add(this.lblCorreoEmpleado);
            this.Controls.Add(this.lblFechaContratacion);
            this.Controls.Add(this.lblTelefonoEmpleado);
            this.Controls.Add(this.lblNombreEmpleado);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBuscaraEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBuscaraEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Label lblBuscarEmpleado;
        private System.Windows.Forms.DateTimePicker dtpFechaContratacion;
        private System.Windows.Forms.TextBox tbxCorreo2;
        private System.Windows.Forms.TextBox tbxTelefono2;
        private System.Windows.Forms.TextBox tbxNombre2;
        private System.Windows.Forms.TextBox txbSueldo;
        private System.Windows.Forms.Label lblSueldoEmleado;
        private System.Windows.Forms.Label lblPuestoEmpleado;
        private System.Windows.Forms.Label lblGeneroEmpleado;
        private System.Windows.Forms.Label lblCorreoEmpleado;
        private System.Windows.Forms.Label lblFechaContratacion;
        private System.Windows.Forms.Label lblTelefonoEmpleado;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aliniamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colocarPrimeNombreYPrimerApellidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telefonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colocarSolo8DigitosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siempreColocargmailcomAlfinalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usarLaComaSiempreEnCada3DigitosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejemplo20000ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton IbtnAtras;
        private System.Windows.Forms.TextBox txbBuscarNacionalidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.ListBox lbxGenero;
        private System.Windows.Forms.ComboBox cbxpuesto;
    }
}