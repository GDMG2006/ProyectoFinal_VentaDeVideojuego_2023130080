namespace ProyectoFinal03.GUI
{
    partial class frmMenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuAdmin));
            this.lblMenuAdmin = new System.Windows.Forms.Label();
            this.btnAgregarVideojuego = new System.Windows.Forms.Button();
            this.btnRevisionStock = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarVideoJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seEncargarEnAgregarNuevosJuegosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revisarStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seEncargaDeRevisarElStockActualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.IbtnAtras = new FontAwesome.Sharp.IconButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMenuAdmin
            // 
            this.lblMenuAdmin.AutoSize = true;
            this.lblMenuAdmin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMenuAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMenuAdmin.Location = new System.Drawing.Point(332, 30);
            this.lblMenuAdmin.Name = "lblMenuAdmin";
            this.lblMenuAdmin.Size = new System.Drawing.Size(233, 25);
            this.lblMenuAdmin.TabIndex = 0;
            this.lblMenuAdmin.Text = "Menu Administrativo ";
            this.lblMenuAdmin.Click += new System.EventHandler(this.lblMenuAdmin_Click);
            // 
            // btnAgregarVideojuego
            // 
            this.btnAgregarVideojuego.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarVideojuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVideojuego.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarVideojuego.Location = new System.Drawing.Point(485, 147);
            this.btnAgregarVideojuego.Name = "btnAgregarVideojuego";
            this.btnAgregarVideojuego.Size = new System.Drawing.Size(120, 57);
            this.btnAgregarVideojuego.TabIndex = 1;
            this.btnAgregarVideojuego.Text = "Agregar Videojuego";
            this.btnAgregarVideojuego.UseVisualStyleBackColor = false;
            this.btnAgregarVideojuego.Click += new System.EventHandler(this.btnAgregarVideojuego_Click);
            // 
            // btnRevisionStock
            // 
            this.btnRevisionStock.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRevisionStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevisionStock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRevisionStock.Location = new System.Drawing.Point(273, 139);
            this.btnRevisionStock.Name = "btnRevisionStock";
            this.btnRevisionStock.Size = new System.Drawing.Size(120, 65);
            this.btnRevisionStock.TabIndex = 2;
            this.btnRevisionStock.Text = "Revisar Stock";
            this.btnRevisionStock.UseVisualStyleBackColor = false;
            this.btnRevisionStock.Click += new System.EventHandler(this.btnRevisionStock_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aliToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aliToolStripMenuItem
            // 
            this.aliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarVideoJuegoToolStripMenuItem,
            this.revisarStockToolStripMenuItem});
            this.aliToolStripMenuItem.Name = "aliToolStripMenuItem";
            this.aliToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.aliToolStripMenuItem.Text = "Alineamentos";
            // 
            // agregarVideoJuegoToolStripMenuItem
            // 
            this.agregarVideoJuegoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seEncargarEnAgregarNuevosJuegosToolStripMenuItem});
            this.agregarVideoJuegoToolStripMenuItem.Name = "agregarVideoJuegoToolStripMenuItem";
            this.agregarVideoJuegoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarVideoJuegoToolStripMenuItem.Text = "Agregar VideoJuego";
            // 
            // seEncargarEnAgregarNuevosJuegosToolStripMenuItem
            // 
            this.seEncargarEnAgregarNuevosJuegosToolStripMenuItem.Name = "seEncargarEnAgregarNuevosJuegosToolStripMenuItem";
            this.seEncargarEnAgregarNuevosJuegosToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.seEncargarEnAgregarNuevosJuegosToolStripMenuItem.Text = "Se encargar en Agregar nuevos juegos";
            // 
            // revisarStockToolStripMenuItem
            // 
            this.revisarStockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seEncargaDeRevisarElStockActualToolStripMenuItem});
            this.revisarStockToolStripMenuItem.Name = "revisarStockToolStripMenuItem";
            this.revisarStockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.revisarStockToolStripMenuItem.Text = "Revisar Stock";
            // 
            // seEncargaDeRevisarElStockActualToolStripMenuItem
            // 
            this.seEncargaDeRevisarElStockActualToolStripMenuItem.Name = "seEncargaDeRevisarElStockActualToolStripMenuItem";
            this.seEncargaDeRevisarElStockActualToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.seEncargaDeRevisarElStockActualToolStripMenuItem.Text = "Se encarga de revisar el stock actual ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(740, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 94;
            this.label7.Text = "Atras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 426);
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
            this.iconButton4.Location = new System.Drawing.Point(12, 398);
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
            this.IbtnAtras.Location = new System.Drawing.Point(728, 399);
            this.IbtnAtras.Name = "IbtnAtras";
            this.IbtnAtras.Size = new System.Drawing.Size(60, 24);
            this.IbtnAtras.TabIndex = 85;
            this.IbtnAtras.UseVisualStyleBackColor = true;
            this.IbtnAtras.Click += new System.EventHandler(this.IbtnAtras_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(273, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 56);
            this.button2.TabIndex = 96;
            this.button2.Text = "Clasificacion Juegos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(485, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 57);
            this.button1.TabIndex = 97;
            this.button1.Text = "Juegos ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal03.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.IbtnAtras);
            this.Controls.Add(this.btnRevisionStock);
            this.Controls.Add(this.btnAgregarVideojuego);
            this.Controls.Add(this.lblMenuAdmin);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuAdmin;
        private System.Windows.Forms.Button btnAgregarVideojuego;
        private System.Windows.Forms.Button btnRevisionStock;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarVideoJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seEncargarEnAgregarNuevosJuegosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revisarStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seEncargaDeRevisarElStockActualToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton IbtnAtras;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}