namespace ProyectoFinal03.GUI
{
    partial class frmfacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmfacturas));
            this.btnCrearFactura = new System.Windows.Forms.Button();
            this.btnVerFactura = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aliniamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.observarLasFacturasCreadasAnteriormenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUnaNuevasFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.IbtnAtras = new FontAwesome.Sharp.IconButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrearFactura
            // 
            this.btnCrearFactura.BackColor = System.Drawing.Color.Black;
            this.btnCrearFactura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCrearFactura.Location = new System.Drawing.Point(332, 249);
            this.btnCrearFactura.Name = "btnCrearFactura";
            this.btnCrearFactura.Size = new System.Drawing.Size(111, 62);
            this.btnCrearFactura.TabIndex = 0;
            this.btnCrearFactura.Text = "Crear Factura";
            this.btnCrearFactura.UseVisualStyleBackColor = false;
            this.btnCrearFactura.Click += new System.EventHandler(this.btnCrearFactura_Click);
            // 
            // btnVerFactura
            // 
            this.btnVerFactura.BackColor = System.Drawing.Color.Black;
            this.btnVerFactura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVerFactura.Location = new System.Drawing.Point(332, 139);
            this.btnVerFactura.Name = "btnVerFactura";
            this.btnVerFactura.Size = new System.Drawing.Size(111, 57);
            this.btnVerFactura.TabIndex = 1;
            this.btnVerFactura.Text = "Ver Factura";
            this.btnVerFactura.UseVisualStyleBackColor = false;
            this.btnVerFactura.Click += new System.EventHandler(this.btnVerFactura_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(327, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "MenuFactura";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aliniamentosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aliniamentosToolStripMenuItem
            // 
            this.aliniamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verFacturaToolStripMenuItem,
            this.crearFacturasToolStripMenuItem});
            this.aliniamentosToolStripMenuItem.Name = "aliniamentosToolStripMenuItem";
            this.aliniamentosToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.aliniamentosToolStripMenuItem.Text = "Aliniamentos";
            // 
            // verFacturaToolStripMenuItem
            // 
            this.verFacturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.observarLasFacturasCreadasAnteriormenteToolStripMenuItem});
            this.verFacturaToolStripMenuItem.Name = "verFacturaToolStripMenuItem";
            this.verFacturaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.verFacturaToolStripMenuItem.Text = "Ver Factura";
            // 
            // observarLasFacturasCreadasAnteriormenteToolStripMenuItem
            // 
            this.observarLasFacturasCreadasAnteriormenteToolStripMenuItem.Name = "observarLasFacturasCreadasAnteriormenteToolStripMenuItem";
            this.observarLasFacturasCreadasAnteriormenteToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.observarLasFacturasCreadasAnteriormenteToolStripMenuItem.Text = "observar las facturas creadas anteriormente";
            // 
            // crearFacturasToolStripMenuItem
            // 
            this.crearFacturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUnaNuevasFacturaToolStripMenuItem});
            this.crearFacturasToolStripMenuItem.Name = "crearFacturasToolStripMenuItem";
            this.crearFacturasToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.crearFacturasToolStripMenuItem.Text = "Crear Facturas";
            // 
            // crearUnaNuevasFacturaToolStripMenuItem
            // 
            this.crearUnaNuevasFacturaToolStripMenuItem.Name = "crearUnaNuevasFacturaToolStripMenuItem";
            this.crearUnaNuevasFacturaToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.crearUnaNuevasFacturaToolStripMenuItem.Text = "Crear una  nuevas factura";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(740, 430);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 102;
            this.label9.Text = "Atras";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 431);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 101;
            this.label10.Text = "Salir";
            // 
            // iconButton4
            // 
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 19;
            this.iconButton4.Location = new System.Drawing.Point(12, 403);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(73, 25);
            this.iconButton4.TabIndex = 100;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // IbtnAtras
            // 
            this.IbtnAtras.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.IbtnAtras.IconColor = System.Drawing.Color.Black;
            this.IbtnAtras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnAtras.IconSize = 20;
            this.IbtnAtras.Location = new System.Drawing.Point(728, 403);
            this.IbtnAtras.Name = "IbtnAtras";
            this.IbtnAtras.Size = new System.Drawing.Size(60, 24);
            this.IbtnAtras.TabIndex = 99;
            this.IbtnAtras.UseVisualStyleBackColor = true;
            this.IbtnAtras.Click += new System.EventHandler(this.IbtnAtras_Click);
            // 
            // frmfacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal03.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.IbtnAtras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerFactura);
            this.Controls.Add(this.btnCrearFactura);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmfacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "facturas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearFactura;
        private System.Windows.Forms.Button btnVerFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aliniamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem observarLasFacturasCreadasAnteriormenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearUnaNuevasFacturaToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton IbtnAtras;
    }
}