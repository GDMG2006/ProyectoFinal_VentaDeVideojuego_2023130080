namespace ProyectoFinal03.GUI
{
    partial class frmMenuDeFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuDeFactura));
            this.lblDNI = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxprecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNumeroFactura = new System.Windows.Forms.TextBox();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnPagarFactura = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alineamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coloqueLaFechaActualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numeroDeFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coloqueElNumeroDeFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coloqueElPrimerNombreYElPrimerApellidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.identificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coloqueElDNIDelClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreDeJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coloqueElNombreDelJuegoCompradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selecioneLaCantidadDeJuegoCompradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.precioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coloqueElPrecioPorUnidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTotal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxMetodoPago = new System.Windows.Forms.ComboBox();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.IbtnAtras = new FontAwesome.Sharp.IconButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cbxNombreCliente = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(288, 162);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(70, 13);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "Identificacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero De Factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre De Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre del Video Juego";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Precio ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(323, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total";
            // 
            // tbxprecio
            // 
            this.tbxprecio.Location = new System.Drawing.Point(360, 261);
            this.tbxprecio.Name = "tbxprecio";
            this.tbxprecio.Size = new System.Drawing.Size(100, 20);
            this.tbxprecio.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Factura";
            // 
            // tbxNumeroFactura
            // 
            this.tbxNumeroFactura.Location = new System.Drawing.Point(370, 109);
            this.tbxNumeroFactura.Name = "tbxNumeroFactura";
            this.tbxNumeroFactura.Size = new System.Drawing.Size(100, 20);
            this.tbxNumeroFactura.TabIndex = 13;
            this.tbxNumeroFactura.TextChanged += new System.EventHandler(this.tbxNumeroFactura_TextChanged);
            // 
            // tbxTotal
            // 
            this.tbxTotal.Location = new System.Drawing.Point(360, 287);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.Size = new System.Drawing.Size(100, 20);
            this.tbxTotal.TabIndex = 15;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(360, 235);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 20);
            this.nudCantidad.TabIndex = 16;
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(274, 86);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 17;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // btnPagarFactura
            // 
            this.btnPagarFactura.Location = new System.Drawing.Point(252, 374);
            this.btnPagarFactura.Name = "btnPagarFactura";
            this.btnPagarFactura.Size = new System.Drawing.Size(85, 39);
            this.btnPagarFactura.TabIndex = 21;
            this.btnPagarFactura.Text = "Pagar Factura";
            this.btnPagarFactura.UseVisualStyleBackColor = true;
            this.btnPagarFactura.Click += new System.EventHandler(this.btnPagarFactura_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(490, 374);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(82, 39);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar Factura";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alineamentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alineamentoToolStripMenuItem
            // 
            this.alineamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fechaToolStripMenuItem,
            this.numeroDeFacturaToolStripMenuItem,
            this.nombreDeClienteToolStripMenuItem,
            this.identificacionToolStripMenuItem,
            this.nombreDeJuegoToolStripMenuItem,
            this.cantidadToolStripMenuItem,
            this.precioToolStripMenuItem});
            this.alineamentoToolStripMenuItem.Name = "alineamentoToolStripMenuItem";
            this.alineamentoToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.alineamentoToolStripMenuItem.Text = "Alineamento";
            // 
            // fechaToolStripMenuItem
            // 
            this.fechaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coloqueLaFechaActualToolStripMenuItem});
            this.fechaToolStripMenuItem.Name = "fechaToolStripMenuItem";
            this.fechaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.fechaToolStripMenuItem.Text = "Fecha";
            // 
            // coloqueLaFechaActualToolStripMenuItem
            // 
            this.coloqueLaFechaActualToolStripMenuItem.Name = "coloqueLaFechaActualToolStripMenuItem";
            this.coloqueLaFechaActualToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.coloqueLaFechaActualToolStripMenuItem.Text = "Coloque la fecha actual";
            // 
            // numeroDeFacturaToolStripMenuItem
            // 
            this.numeroDeFacturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coloqueElNumeroDeFacturaToolStripMenuItem});
            this.numeroDeFacturaToolStripMenuItem.Name = "numeroDeFacturaToolStripMenuItem";
            this.numeroDeFacturaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.numeroDeFacturaToolStripMenuItem.Text = "Numero de Factura";
            // 
            // coloqueElNumeroDeFacturaToolStripMenuItem
            // 
            this.coloqueElNumeroDeFacturaToolStripMenuItem.Name = "coloqueElNumeroDeFacturaToolStripMenuItem";
            this.coloqueElNumeroDeFacturaToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.coloqueElNumeroDeFacturaToolStripMenuItem.Text = "Coloque el numero de factura ";
            // 
            // nombreDeClienteToolStripMenuItem
            // 
            this.nombreDeClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coloqueElPrimerNombreYElPrimerApellidoToolStripMenuItem});
            this.nombreDeClienteToolStripMenuItem.Name = "nombreDeClienteToolStripMenuItem";
            this.nombreDeClienteToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.nombreDeClienteToolStripMenuItem.Text = "Nombre de Cliente";
            // 
            // coloqueElPrimerNombreYElPrimerApellidoToolStripMenuItem
            // 
            this.coloqueElPrimerNombreYElPrimerApellidoToolStripMenuItem.Name = "coloqueElPrimerNombreYElPrimerApellidoToolStripMenuItem";
            this.coloqueElPrimerNombreYElPrimerApellidoToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
            this.coloqueElPrimerNombreYElPrimerApellidoToolStripMenuItem.Text = "Coloque el primer Nombre y el primer Apellido";
            // 
            // identificacionToolStripMenuItem
            // 
            this.identificacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coloqueElDNIDelClienteToolStripMenuItem});
            this.identificacionToolStripMenuItem.Name = "identificacionToolStripMenuItem";
            this.identificacionToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.identificacionToolStripMenuItem.Text = "Identificacion ";
            // 
            // coloqueElDNIDelClienteToolStripMenuItem
            // 
            this.coloqueElDNIDelClienteToolStripMenuItem.Name = "coloqueElDNIDelClienteToolStripMenuItem";
            this.coloqueElDNIDelClienteToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.coloqueElDNIDelClienteToolStripMenuItem.Text = "Coloque el DNI del cliente";
            // 
            // nombreDeJuegoToolStripMenuItem
            // 
            this.nombreDeJuegoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coloqueElNombreDelJuegoCompradoToolStripMenuItem});
            this.nombreDeJuegoToolStripMenuItem.Name = "nombreDeJuegoToolStripMenuItem";
            this.nombreDeJuegoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.nombreDeJuegoToolStripMenuItem.Text = "Nombre de Juego ";
            // 
            // coloqueElNombreDelJuegoCompradoToolStripMenuItem
            // 
            this.coloqueElNombreDelJuegoCompradoToolStripMenuItem.Name = "coloqueElNombreDelJuegoCompradoToolStripMenuItem";
            this.coloqueElNombreDelJuegoCompradoToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.coloqueElNombreDelJuegoCompradoToolStripMenuItem.Text = "Coloque el nombre del juego comprado";
            // 
            // cantidadToolStripMenuItem
            // 
            this.cantidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selecioneLaCantidadDeJuegoCompradoToolStripMenuItem});
            this.cantidadToolStripMenuItem.Name = "cantidadToolStripMenuItem";
            this.cantidadToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.cantidadToolStripMenuItem.Text = "Cantidad";
            // 
            // selecioneLaCantidadDeJuegoCompradoToolStripMenuItem
            // 
            this.selecioneLaCantidadDeJuegoCompradoToolStripMenuItem.Name = "selecioneLaCantidadDeJuegoCompradoToolStripMenuItem";
            this.selecioneLaCantidadDeJuegoCompradoToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.selecioneLaCantidadDeJuegoCompradoToolStripMenuItem.Text = "Selecione la cantidad de juego comprado";
            // 
            // precioToolStripMenuItem
            // 
            this.precioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coloqueElPrecioPorUnidadToolStripMenuItem});
            this.precioToolStripMenuItem.Name = "precioToolStripMenuItem";
            this.precioToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.precioToolStripMenuItem.Text = "Precio";
            // 
            // coloqueElPrecioPorUnidadToolStripMenuItem
            // 
            this.coloqueElPrecioPorUnidadToolStripMenuItem.Name = "coloqueElPrecioPorUnidadToolStripMenuItem";
            this.coloqueElPrecioPorUnidadToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.coloqueElPrecioPorUnidadToolStripMenuItem.Text = "Coloque el precio por Unidad ";
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(466, 287);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(60, 24);
            this.btnTotal.TabIndex = 24;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(480, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // cbxMetodoPago
            // 
            this.cbxMetodoPago.FormattingEnabled = true;
            this.cbxMetodoPago.Items.AddRange(new object[] {
            "Seleccione",
            "Pago con Tarjeta ",
            "Pago con Transferencia ",
            "Pago con Efectivo "});
            this.cbxMetodoPago.Location = new System.Drawing.Point(360, 313);
            this.cbxMetodoPago.Name = "cbxMetodoPago";
            this.cbxMetodoPago.Size = new System.Drawing.Size(121, 21);
            this.cbxMetodoPago.TabIndex = 65;
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Location = new System.Drawing.Point(268, 316);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(86, 13);
            this.lblMetodoPago.TabIndex = 66;
            this.lblMetodoPago.Text = "Metodo de Pago";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(740, 432);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 98;
            this.label9.Text = "Atras";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 97;
            this.label10.Text = "Salir";
            // 
            // iconButton4
            // 
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 19;
            this.iconButton4.Location = new System.Drawing.Point(12, 404);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(73, 25);
            this.iconButton4.TabIndex = 96;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
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
            this.IbtnAtras.TabIndex = 95;
            this.IbtnAtras.UseVisualStyleBackColor = true;
            this.IbtnAtras.Click += new System.EventHandler(this.IbtnAtras_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "DNI",
            "Passaporte",
            "RTN"});
            this.comboBox1.Location = new System.Drawing.Point(364, 159);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 99;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(364, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 100;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(359, 210);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 101;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cbxNombreCliente
            // 
            this.cbxNombreCliente.FormattingEnabled = true;
            this.cbxNombreCliente.Location = new System.Drawing.Point(364, 132);
            this.cbxNombreCliente.Name = "cbxNombreCliente";
            this.cbxNombreCliente.Size = new System.Drawing.Size(121, 21);
            this.cbxNombreCliente.TabIndex = 102;
            // 
            // frmMenuDeFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxNombreCliente);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.IbtnAtras);
            this.Controls.Add(this.lblMetodoPago);
            this.Controls.Add(this.cbxMetodoPago);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnPagarFactura);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.tbxTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNumeroFactura);
            this.Controls.Add(this.tbxprecio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuDeFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxprecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNumeroFactura;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnPagarFactura;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alineamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coloqueLaFechaActualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numeroDeFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coloqueElNumeroDeFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coloqueElPrimerNombreYElPrimerApellidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem identificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coloqueElDNIDelClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreDeJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coloqueElNombreDelJuegoCompradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selecioneLaCantidadDeJuegoCompradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem precioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coloqueElPrecioPorUnidadToolStripMenuItem;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbxMetodoPago;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton IbtnAtras;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cbxNombreCliente;
    }
}