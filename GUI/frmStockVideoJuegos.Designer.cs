namespace ProyectoFinal03.GUI
{
    partial class frmStockVideoJuegos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockVideoJuegos));
            this.dtpFechaLazamiento3 = new System.Windows.Forms.DateTimePicker();
            this.dgvMenuAdmini = new System.Windows.Forms.DataGridView();
            this.tbxPlataforma3 = new System.Windows.Forms.TextBox();
            this.tbxGenero3 = new System.Windows.Forms.TextBox();
            this.tbxNombreJuego3 = new System.Windows.Forms.TextBox();
            this.tbxPrecio3 = new System.Windows.Forms.TextBox();
            this.tbxDisponible3 = new System.Windows.Forms.TextBox();
            this.tbxClasificacion3 = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.lblFechaDeLanza = new System.Windows.Forms.Label();
            this.lblPlataforma = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombreDeJuego = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.IbtnAtras = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbBuscarNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuAdmini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaLazamiento3
            // 
            this.dtpFechaLazamiento3.Location = new System.Drawing.Point(568, 166);
            this.dtpFechaLazamiento3.Name = "dtpFechaLazamiento3";
            this.dtpFechaLazamiento3.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaLazamiento3.TabIndex = 50;
            // 
            // dgvMenuAdmini
            // 
            this.dgvMenuAdmini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuAdmini.Location = new System.Drawing.Point(32, 254);
            this.dgvMenuAdmini.Name = "dgvMenuAdmini";
            this.dgvMenuAdmini.Size = new System.Drawing.Size(714, 150);
            this.dgvMenuAdmini.TabIndex = 49;
            this.dgvMenuAdmini.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenuAdmini_CellContentClick);
            // 
            // tbxPlataforma3
            // 
            this.tbxPlataforma3.Location = new System.Drawing.Point(568, 109);
            this.tbxPlataforma3.Name = "tbxPlataforma3";
            this.tbxPlataforma3.Size = new System.Drawing.Size(131, 20);
            this.tbxPlataforma3.TabIndex = 48;
            // 
            // tbxGenero3
            // 
            this.tbxGenero3.Location = new System.Drawing.Point(568, 138);
            this.tbxGenero3.Name = "tbxGenero3";
            this.tbxGenero3.Size = new System.Drawing.Size(131, 20);
            this.tbxGenero3.TabIndex = 47;
            // 
            // tbxNombreJuego3
            // 
            this.tbxNombreJuego3.Location = new System.Drawing.Point(234, 109);
            this.tbxNombreJuego3.Name = "tbxNombreJuego3";
            this.tbxNombreJuego3.Size = new System.Drawing.Size(144, 20);
            this.tbxNombreJuego3.TabIndex = 46;
            this.tbxNombreJuego3.TextChanged += new System.EventHandler(this.tbxNombreJuego3_TextChanged);
            // 
            // tbxPrecio3
            // 
            this.tbxPrecio3.Location = new System.Drawing.Point(234, 137);
            this.tbxPrecio3.Name = "tbxPrecio3";
            this.tbxPrecio3.Size = new System.Drawing.Size(144, 20);
            this.tbxPrecio3.TabIndex = 45;
            // 
            // tbxDisponible3
            // 
            this.tbxDisponible3.Location = new System.Drawing.Point(234, 166);
            this.tbxDisponible3.Name = "tbxDisponible3";
            this.tbxDisponible3.Size = new System.Drawing.Size(144, 20);
            this.tbxDisponible3.TabIndex = 44;
            // 
            // tbxClasificacion3
            // 
            this.tbxClasificacion3.Location = new System.Drawing.Point(234, 192);
            this.tbxClasificacion3.Name = "tbxClasificacion3";
            this.tbxClasificacion3.Size = new System.Drawing.Size(144, 20);
            this.tbxClasificacion3.TabIndex = 43;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(286, 45);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(267, 24);
            this.lblStock.TabIndex = 42;
            this.lblStock.Text = "Stock De Los Video Juegos";
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.Location = new System.Drawing.Point(154, 166);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(0, 13);
            this.lblDisponible.TabIndex = 41;
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.Location = new System.Drawing.Point(141, 191);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(69, 13);
            this.lblClasificacion.TabIndex = 40;
            this.lblClasificacion.Text = "Clasificacion ";
            // 
            // lblFechaDeLanza
            // 
            this.lblFechaDeLanza.AutoSize = true;
            this.lblFechaDeLanza.Location = new System.Drawing.Point(444, 173);
            this.lblFechaDeLanza.Name = "lblFechaDeLanza";
            this.lblFechaDeLanza.Size = new System.Drawing.Size(109, 13);
            this.lblFechaDeLanza.TabIndex = 39;
            this.lblFechaDeLanza.Text = "Fecha de Lazamiento";
            // 
            // lblPlataforma
            // 
            this.lblPlataforma.AutoSize = true;
            this.lblPlataforma.Location = new System.Drawing.Point(496, 112);
            this.lblPlataforma.Name = "lblPlataforma";
            this.lblPlataforma.Size = new System.Drawing.Size(57, 13);
            this.lblPlataforma.TabIndex = 38;
            this.lblPlataforma.Text = "Plataforma";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(511, 138);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 37;
            this.lblGenero.Text = "Genero";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(173, 140);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 36;
            this.lblPrecio.Text = "Precio";
            // 
            // lblNombreDeJuego
            // 
            this.lblNombreDeJuego.AutoSize = true;
            this.lblNombreDeJuego.Location = new System.Drawing.Point(117, 112);
            this.lblNombreDeJuego.Name = "lblNombreDeJuego";
            this.lblNombreDeJuego.Size = new System.Drawing.Size(93, 13);
            this.lblNombreDeJuego.TabIndex = 35;
            this.lblNombreDeJuego.Text = "Nombre De Juego";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(734, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 94;
            this.label7.Text = "Atras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 436);
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
            this.iconButton4.Location = new System.Drawing.Point(12, 408);
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
            this.IbtnAtras.Location = new System.Drawing.Point(728, 408);
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
            this.pictureBox1.Location = new System.Drawing.Point(-3, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 100;
            this.label1.Text = "Ingrese el Nombre";
            // 
            // txbBuscarNombre
            // 
            this.txbBuscarNombre.Location = new System.Drawing.Point(350, 408);
            this.txbBuscarNombre.Name = "txbBuscarNombre";
            this.txbBuscarNombre.Size = new System.Drawing.Size(153, 20);
            this.txbBuscarNombre.TabIndex = 99;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(552, 435);
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
            this.iconButton2.Location = new System.Drawing.Point(536, 408);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(75, 23);
            this.iconButton2.TabIndex = 97;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 101;
            this.label2.Text = "ID del Juego";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(633, 436);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 114;
            this.label11.Text = "Eliminar";
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 19;
            this.iconButton1.Location = new System.Drawing.Point(617, 408);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(73, 23);
            this.iconButton1.TabIndex = 113;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // frmStockVideoJuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbBuscarNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.IbtnAtras);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtpFechaLazamiento3);
            this.Controls.Add(this.dgvMenuAdmini);
            this.Controls.Add(this.tbxPlataforma3);
            this.Controls.Add(this.tbxGenero3);
            this.Controls.Add(this.tbxNombreJuego3);
            this.Controls.Add(this.tbxPrecio3);
            this.Controls.Add(this.tbxDisponible3);
            this.Controls.Add(this.tbxClasificacion3);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblDisponible);
            this.Controls.Add(this.lblClasificacion);
            this.Controls.Add(this.lblFechaDeLanza);
            this.Controls.Add(this.lblPlataforma);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombreDeJuego);
            this.Name = "frmStockVideoJuegos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockVideoJuegos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuAdmini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpFechaLazamiento3;
        private System.Windows.Forms.DataGridView dgvMenuAdmini;
        private System.Windows.Forms.TextBox tbxPlataforma3;
        private System.Windows.Forms.TextBox tbxGenero3;
        private System.Windows.Forms.TextBox tbxNombreJuego3;
        private System.Windows.Forms.TextBox tbxPrecio3;
        private System.Windows.Forms.TextBox tbxDisponible3;
        private System.Windows.Forms.TextBox tbxClasificacion3;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblDisponible;
        private System.Windows.Forms.Label lblClasificacion;
        private System.Windows.Forms.Label lblFechaDeLanza;
        private System.Windows.Forms.Label lblPlataforma;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombreDeJuego;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton IbtnAtras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbBuscarNombre;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}