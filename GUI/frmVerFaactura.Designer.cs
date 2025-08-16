namespace ProyectoFinal03.GUI
{
    partial class Facturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturas));
            this.tbxnombrejuego = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNumeroFactura = new System.Windows.Forms.TextBox();
            this.tbxDNI = new System.Windows.Forms.TextBox();
            this.tbxNombreCliente = new System.Windows.Forms.TextBox();
            this.tbxprecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNumeroFacura2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.IbtnAtras = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label13 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxnombrejuego
            // 
            this.tbxnombrejuego.Location = new System.Drawing.Point(364, 184);
            this.tbxnombrejuego.Name = "tbxnombrejuego";
            this.tbxnombrejuego.Size = new System.Drawing.Size(100, 20);
            this.tbxnombrejuego.TabIndex = 39;
            this.tbxnombrejuego.TextChanged += new System.EventHandler(this.tbxnombrejuego_TextChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(268, 95);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 38;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(344, 210);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 20);
            this.nudCantidad.TabIndex = 37;
            // 
            // tbxTotal
            // 
            this.tbxTotal.Location = new System.Drawing.Point(364, 261);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.Size = new System.Drawing.Size(100, 20);
            this.tbxTotal.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Factura";
            // 
            // tbxNumeroFactura
            // 
            this.tbxNumeroFactura.Location = new System.Drawing.Point(364, 118);
            this.tbxNumeroFactura.Name = "tbxNumeroFactura";
            this.tbxNumeroFactura.Size = new System.Drawing.Size(100, 20);
            this.tbxNumeroFactura.TabIndex = 34;
            this.tbxNumeroFactura.TextChanged += new System.EventHandler(this.tbxNumeroFactura_TextChanged);
            // 
            // tbxDNI
            // 
            this.tbxDNI.Location = new System.Drawing.Point(364, 161);
            this.tbxDNI.Name = "tbxDNI";
            this.tbxDNI.Size = new System.Drawing.Size(100, 20);
            this.tbxDNI.TabIndex = 33;
            // 
            // tbxNombreCliente
            // 
            this.tbxNombreCliente.Location = new System.Drawing.Point(364, 140);
            this.tbxNombreCliente.Name = "tbxNombreCliente";
            this.tbxNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.tbxNombreCliente.TabIndex = 32;
            // 
            // tbxprecio
            // 
            this.tbxprecio.Location = new System.Drawing.Point(364, 235);
            this.tbxprecio.Name = "tbxprecio";
            this.tbxprecio.Size = new System.Drawing.Size(100, 20);
            this.tbxprecio.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Precio ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Nombre del Video Juego";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Nombre De Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Numero De Factura";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(288, 161);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(70, 13);
            this.lblDNI.TabIndex = 23;
            this.lblDNI.Text = "Identificacion";
            // 
            // lblNumeroFacura2
            // 
            this.lblNumeroFacura2.AutoSize = true;
            this.lblNumeroFacura2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFacura2.Location = new System.Drawing.Point(147, 462);
            this.lblNumeroFacura2.Name = "lblNumeroFacura2";
            this.lblNumeroFacura2.Size = new System.Drawing.Size(133, 15);
            this.lblNumeroFacura2.TabIndex = 45;
            this.lblNumeroFacura2.Text = "Nombre De Cliente:";
            this.lblNumeroFacura2.Click += new System.EventHandler(this.lblNumeroFacura2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(309, 462);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 46;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(474, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(740, 482);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 106;
            this.label9.Text = "Atras";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 481);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 105;
            this.label10.Text = "Salir";
            // 
            // iconButton4
            // 
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 19;
            this.iconButton4.Location = new System.Drawing.Point(12, 453);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(73, 25);
            this.iconButton4.TabIndex = 104;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // IbtnAtras
            // 
            this.IbtnAtras.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.IbtnAtras.IconColor = System.Drawing.Color.Black;
            this.IbtnAtras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnAtras.IconSize = 20;
            this.IbtnAtras.Location = new System.Drawing.Point(728, 455);
            this.IbtnAtras.Name = "IbtnAtras";
            this.IbtnAtras.Size = new System.Drawing.Size(60, 24);
            this.IbtnAtras.TabIndex = 103;
            this.IbtnAtras.UseVisualStyleBackColor = true;
            this.IbtnAtras.Click += new System.EventHandler(this.IbtnAtras_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(586, 483);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 112;
            this.label11.Text = "Eliminar";
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 19;
            this.iconButton1.Location = new System.Drawing.Point(570, 455);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(73, 23);
            this.iconButton1.TabIndex = 111;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(505, 483);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 108;
            this.label13.Text = "Buscar";
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.Location = new System.Drawing.Point(489, 456);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(75, 23);
            this.iconButton2.TabIndex = 107;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Location = new System.Drawing.Point(36, 296);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.Size = new System.Drawing.Size(735, 150);
            this.dgvFacturas.TabIndex = 113;
            this.dgvFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacturas_CellContentClick);
            // 
            // Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.IbtnAtras);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNumeroFacura2);
            this.Controls.Add(this.tbxnombrejuego);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.tbxTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNumeroFactura);
            this.Controls.Add(this.tbxDNI);
            this.Controls.Add(this.tbxNombreCliente);
            this.Controls.Add(this.tbxprecio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDNI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Facturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVerFactura";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxnombrejuego;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNumeroFactura;
        private System.Windows.Forms.TextBox tbxDNI;
        private System.Windows.Forms.TextBox tbxNombreCliente;
        private System.Windows.Forms.TextBox tbxprecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNumeroFacura2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton IbtnAtras;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label13;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.DataGridView dgvFacturas;
    }
}