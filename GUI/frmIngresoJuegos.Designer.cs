namespace ProyectoFinal03.GUI
{
    partial class frmIngresoJuegos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresoJuegos));
            this.cbxPlatadorma = new System.Windows.Forms.ComboBox();
            this.dtpFechaLazamiento3 = new System.Windows.Forms.DateTimePicker();
            this.tbxPrecio3 = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblFechaDeLanza = new System.Windows.Forms.Label();
            this.lblPlataforma = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombreDeJuego = new System.Windows.Forms.Label();
            this.lblMenuAdm = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aliniamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreDeJuegosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colocarElNombreCompletoDelJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.precioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colocarElPrecioPorUnidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disponibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selecioneSiElVideoJuegoEstaDisponibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clasificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muestraLaClasificacionDeEdadDelVideoJueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plataforamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muestraLaPlataformaDeUsoDelJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muestraElGeneroDelJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaDeLazamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muestraLaFechaDeLazamientoDelJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IbtnAtras = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.cbxClasificacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudCanti = new System.Windows.Forms.NumericUpDown();
            this.txbIdjuego = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxNombreJuego = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCanti)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxPlatadorma
            // 
            this.cbxPlatadorma.FormattingEnabled = true;
            this.cbxPlatadorma.Items.AddRange(new object[] {
            "PC (Windows, macOS, Linux)",
            "PlayStation 5",
            "PlayStation 4",
            "Xbox Series X|S",
            "Xbox One",
            "Nintendo Switch",
            "Steam Deck",
            "Android",
            "iOS",
            "Nintendo 3DS"});
            this.cbxPlatadorma.Location = new System.Drawing.Point(540, 109);
            this.cbxPlatadorma.Name = "cbxPlatadorma";
            this.cbxPlatadorma.Size = new System.Drawing.Size(121, 21);
            this.cbxPlatadorma.TabIndex = 73;
            // 
            // dtpFechaLazamiento3
            // 
            this.dtpFechaLazamiento3.Location = new System.Drawing.Point(540, 164);
            this.dtpFechaLazamiento3.Name = "dtpFechaLazamiento3";
            this.dtpFechaLazamiento3.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaLazamiento3.TabIndex = 50;
            // 
            // tbxPrecio3
            // 
            this.tbxPrecio3.Location = new System.Drawing.Point(206, 135);
            this.tbxPrecio3.Name = "tbxPrecio3";
            this.tbxPrecio3.Size = new System.Drawing.Size(144, 20);
            this.tbxPrecio3.TabIndex = 45;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(339, 48);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(61, 24);
            this.lblStock.TabIndex = 42;
            this.lblStock.Text = "Stock";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(126, 164);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 41;
            this.lblCantidad.Text = "Cantidad\r\n";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(145, 197);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 40;
            this.lblID.Text = "ID";
            this.lblID.Click += new System.EventHandler(this.lblClasificacion_Click);
            // 
            // lblFechaDeLanza
            // 
            this.lblFechaDeLanza.AutoSize = true;
            this.lblFechaDeLanza.Location = new System.Drawing.Point(416, 171);
            this.lblFechaDeLanza.Name = "lblFechaDeLanza";
            this.lblFechaDeLanza.Size = new System.Drawing.Size(109, 13);
            this.lblFechaDeLanza.TabIndex = 39;
            this.lblFechaDeLanza.Text = "Fecha de Lazamiento";
            // 
            // lblPlataforma
            // 
            this.lblPlataforma.AutoSize = true;
            this.lblPlataforma.Location = new System.Drawing.Point(468, 110);
            this.lblPlataforma.Name = "lblPlataforma";
            this.lblPlataforma.Size = new System.Drawing.Size(57, 13);
            this.lblPlataforma.TabIndex = 38;
            this.lblPlataforma.Text = "Plataforma";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(483, 136);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 37;
            this.lblGenero.Text = "Genero";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(145, 138);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 36;
            this.lblPrecio.Text = "Precio";
            // 
            // lblNombreDeJuego
            // 
            this.lblNombreDeJuego.AutoSize = true;
            this.lblNombreDeJuego.Location = new System.Drawing.Point(89, 110);
            this.lblNombreDeJuego.Name = "lblNombreDeJuego";
            this.lblNombreDeJuego.Size = new System.Drawing.Size(93, 13);
            this.lblNombreDeJuego.TabIndex = 35;
            this.lblNombreDeJuego.Text = "Nombre De Juego";
            // 
            // lblMenuAdm
            // 
            this.lblMenuAdm.AutoSize = true;
            this.lblMenuAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuAdm.Location = new System.Drawing.Point(255, 24);
            this.lblMenuAdm.Name = "lblMenuAdm";
            this.lblMenuAdm.Size = new System.Drawing.Size(245, 24);
            this.lblMenuAdm.TabIndex = 34;
            this.lblMenuAdm.Text = "Ingreso de Video Juegos";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aliniamentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 63;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aliniamentoToolStripMenuItem
            // 
            this.aliniamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreDeJuegosToolStripMenuItem,
            this.precioToolStripMenuItem,
            this.disponibleToolStripMenuItem,
            this.clasificacionToolStripMenuItem,
            this.plataforamToolStripMenuItem,
            this.generoToolStripMenuItem,
            this.fechaDeLazamientoToolStripMenuItem});
            this.aliniamentoToolStripMenuItem.Name = "aliniamentoToolStripMenuItem";
            this.aliniamentoToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.aliniamentoToolStripMenuItem.Text = "Aliniamento";
            // 
            // nombreDeJuegosToolStripMenuItem
            // 
            this.nombreDeJuegosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colocarElNombreCompletoDelJuegoToolStripMenuItem});
            this.nombreDeJuegosToolStripMenuItem.Name = "nombreDeJuegosToolStripMenuItem";
            this.nombreDeJuegosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.nombreDeJuegosToolStripMenuItem.Text = "Nombre de Juegos";
            // 
            // colocarElNombreCompletoDelJuegoToolStripMenuItem
            // 
            this.colocarElNombreCompletoDelJuegoToolStripMenuItem.Name = "colocarElNombreCompletoDelJuegoToolStripMenuItem";
            this.colocarElNombreCompletoDelJuegoToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.colocarElNombreCompletoDelJuegoToolStripMenuItem.Text = "Muestra el nombre completo del juego";
            // 
            // precioToolStripMenuItem
            // 
            this.precioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colocarElPrecioPorUnidadToolStripMenuItem});
            this.precioToolStripMenuItem.Name = "precioToolStripMenuItem";
            this.precioToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.precioToolStripMenuItem.Text = "Precio ";
            // 
            // colocarElPrecioPorUnidadToolStripMenuItem
            // 
            this.colocarElPrecioPorUnidadToolStripMenuItem.Name = "colocarElPrecioPorUnidadToolStripMenuItem";
            this.colocarElPrecioPorUnidadToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.colocarElPrecioPorUnidadToolStripMenuItem.Text = "Muestra el precio por Unidad del Juego";
            // 
            // disponibleToolStripMenuItem
            // 
            this.disponibleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selecioneSiElVideoJuegoEstaDisponibleToolStripMenuItem});
            this.disponibleToolStripMenuItem.Name = "disponibleToolStripMenuItem";
            this.disponibleToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.disponibleToolStripMenuItem.Text = "Disponible";
            // 
            // selecioneSiElVideoJuegoEstaDisponibleToolStripMenuItem
            // 
            this.selecioneSiElVideoJuegoEstaDisponibleToolStripMenuItem.Name = "selecioneSiElVideoJuegoEstaDisponibleToolStripMenuItem";
            this.selecioneSiElVideoJuegoEstaDisponibleToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.selecioneSiElVideoJuegoEstaDisponibleToolStripMenuItem.Text = "Muestra la Disponibilidad del juego";
            // 
            // clasificacionToolStripMenuItem
            // 
            this.clasificacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muestraLaClasificacionDeEdadDelVideoJueToolStripMenuItem});
            this.clasificacionToolStripMenuItem.Name = "clasificacionToolStripMenuItem";
            this.clasificacionToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.clasificacionToolStripMenuItem.Text = "Clasificacion";
            // 
            // muestraLaClasificacionDeEdadDelVideoJueToolStripMenuItem
            // 
            this.muestraLaClasificacionDeEdadDelVideoJueToolStripMenuItem.Name = "muestraLaClasificacionDeEdadDelVideoJueToolStripMenuItem";
            this.muestraLaClasificacionDeEdadDelVideoJueToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.muestraLaClasificacionDeEdadDelVideoJueToolStripMenuItem.Text = "Muestra la clasificacion de edad del juego";
            // 
            // plataforamToolStripMenuItem
            // 
            this.plataforamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muestraLaPlataformaDeUsoDelJuegoToolStripMenuItem});
            this.plataforamToolStripMenuItem.Name = "plataforamToolStripMenuItem";
            this.plataforamToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.plataforamToolStripMenuItem.Text = "Plataforama";
            // 
            // muestraLaPlataformaDeUsoDelJuegoToolStripMenuItem
            // 
            this.muestraLaPlataformaDeUsoDelJuegoToolStripMenuItem.Name = "muestraLaPlataformaDeUsoDelJuegoToolStripMenuItem";
            this.muestraLaPlataformaDeUsoDelJuegoToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.muestraLaPlataformaDeUsoDelJuegoToolStripMenuItem.Text = "Muestra la plataforma de uso del juego";
            // 
            // generoToolStripMenuItem
            // 
            this.generoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muestraElGeneroDelJuegoToolStripMenuItem});
            this.generoToolStripMenuItem.Name = "generoToolStripMenuItem";
            this.generoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.generoToolStripMenuItem.Text = "Genero";
            this.generoToolStripMenuItem.Click += new System.EventHandler(this.generoToolStripMenuItem_Click);
            // 
            // muestraElGeneroDelJuegoToolStripMenuItem
            // 
            this.muestraElGeneroDelJuegoToolStripMenuItem.Name = "muestraElGeneroDelJuegoToolStripMenuItem";
            this.muestraElGeneroDelJuegoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.muestraElGeneroDelJuegoToolStripMenuItem.Text = "Muestra el Genero del Juego";
            // 
            // fechaDeLazamientoToolStripMenuItem
            // 
            this.fechaDeLazamientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muestraLaFechaDeLazamientoDelJuegoToolStripMenuItem});
            this.fechaDeLazamientoToolStripMenuItem.Name = "fechaDeLazamientoToolStripMenuItem";
            this.fechaDeLazamientoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.fechaDeLazamientoToolStripMenuItem.Text = "Fecha de Lazamiento";
            // 
            // muestraLaFechaDeLazamientoDelJuegoToolStripMenuItem
            // 
            this.muestraLaFechaDeLazamientoDelJuegoToolStripMenuItem.Name = "muestraLaFechaDeLazamientoDelJuegoToolStripMenuItem";
            this.muestraLaFechaDeLazamientoDelJuegoToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.muestraLaFechaDeLazamientoDelJuegoToolStripMenuItem.Text = "Muestra la fecha de lazamiento del juego";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(423, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // IbtnAtras
            // 
            this.IbtnAtras.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.IbtnAtras.IconColor = System.Drawing.Color.Black;
            this.IbtnAtras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnAtras.IconSize = 20;
            this.IbtnAtras.Location = new System.Drawing.Point(728, 349);
            this.IbtnAtras.Name = "IbtnAtras";
            this.IbtnAtras.Size = new System.Drawing.Size(60, 24);
            this.IbtnAtras.TabIndex = 67;
            this.IbtnAtras.UseVisualStyleBackColor = true;
            this.IbtnAtras.Click += new System.EventHandler(this.IbtnAtras_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(600, 240);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 24);
            this.iconButton1.TabIndex = 68;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 19;
            this.iconButton4.Location = new System.Drawing.Point(12, 348);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(73, 25);
            this.iconButton4.TabIndex = 71;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // cbxGenero
            // 
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Items.AddRange(new object[] {
            "Acción",
            "Aventura",
            "Rol (RPG)",
            "hooter (Disparos)",
            "Plataformas",
            "Estrategia",
            "Deportes",
            "Carreras",
            "Simulación",
            "Survival Horror"});
            this.cbxGenero.Location = new System.Drawing.Point(540, 134);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(121, 21);
            this.cbxGenero.TabIndex = 74;
            // 
            // cbxClasificacion
            // 
            this.cbxClasificacion.FormattingEnabled = true;
            this.cbxClasificacion.Location = new System.Drawing.Point(554, 197);
            this.cbxClasificacion.Name = "cbxClasificacion";
            this.cbxClasificacion.Size = new System.Drawing.Size(121, 21);
            this.cbxClasificacion.TabIndex = 75;
            this.cbxClasificacion.SelectedIndexChanged += new System.EventHandler(this.cbxClasificacion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Clasificacion";
            // 
            // nudCanti
            // 
            this.nudCanti.Location = new System.Drawing.Point(206, 164);
            this.nudCanti.Name = "nudCanti";
            this.nudCanti.Size = new System.Drawing.Size(120, 20);
            this.nudCanti.TabIndex = 77;
            // 
            // txbIdjuego
            // 
            this.txbIdjuego.Location = new System.Drawing.Point(206, 197);
            this.txbIdjuego.Name = "txbIdjuego";
            this.txbIdjuego.Size = new System.Drawing.Size(144, 20);
            this.txbIdjuego.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Salir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(615, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "Agregar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(734, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 84;
            this.label7.Text = "Atras";
            // 
            // cbxNombreJuego
            // 
            this.cbxNombreJuego.FormattingEnabled = true;
            this.cbxNombreJuego.Location = new System.Drawing.Point(205, 110);
            this.cbxNombreJuego.Name = "cbxNombreJuego";
            this.cbxNombreJuego.Size = new System.Drawing.Size(145, 21);
            this.cbxNombreJuego.TabIndex = 86;
            this.cbxNombreJuego.SelectedIndexChanged += new System.EventHandler(this.cbxNombreJuego_SelectedIndexChanged_1);
            // 
            // frmIngresoJuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 396);
            this.Controls.Add(this.cbxNombreJuego);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbIdjuego);
            this.Controls.Add(this.nudCanti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxClasificacion);
            this.Controls.Add(this.cbxGenero);
            this.Controls.Add(this.cbxPlatadorma);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.IbtnAtras);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtpFechaLazamiento3);
            this.Controls.Add(this.tbxPrecio3);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblFechaDeLanza);
            this.Controls.Add(this.lblPlataforma);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombreDeJuego);
            this.Controls.Add(this.lblMenuAdm);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmIngresoJuegos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIngresoJuegos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCanti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpFechaLazamiento3;
        private System.Windows.Forms.TextBox tbxPrecio3;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblFechaDeLanza;
        private System.Windows.Forms.Label lblPlataforma;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombreDeJuego;
        private System.Windows.Forms.Label lblMenuAdm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aliniamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreDeJuegosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colocarElNombreCompletoDelJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem precioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colocarElPrecioPorUnidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disponibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selecioneSiElVideoJuegoEstaDisponibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clasificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muestraLaClasificacionDeEdadDelVideoJueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plataforamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muestraLaPlataformaDeUsoDelJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muestraElGeneroDelJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechaDeLazamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muestraLaFechaDeLazamientoDelJuegoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton IbtnAtras;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.ComboBox cbxPlatadorma;
        private System.Windows.Forms.ComboBox cbxClasificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudCanti;
        private System.Windows.Forms.TextBox txbIdjuego;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxNombreJuego;
    }
}