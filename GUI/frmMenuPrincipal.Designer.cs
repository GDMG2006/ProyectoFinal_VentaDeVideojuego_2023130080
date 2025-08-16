namespace ProyectoFinal03.GUI
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.lblMenuPrincipal = new System.Windows.Forms.Label();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.btnadmin = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alineamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alSelecionarloEntraraElMenuRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dondePordraVerElRegitroDeEmpleadoYClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alSelecionarloEntraraAlMenuAdministracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alSelecionarloEntraraAlMenuFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dondePodraCrearOVerFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMenuPrincipal
            // 
            this.lblMenuPrincipal.AutoSize = true;
            this.lblMenuPrincipal.BackColor = System.Drawing.Color.Black;
            this.lblMenuPrincipal.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuPrincipal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMenuPrincipal.Location = new System.Drawing.Point(292, 35);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(223, 34);
            this.lblMenuPrincipal.TabIndex = 0;
            this.lblMenuPrincipal.Text = "Menu Principal";
            this.lblMenuPrincipal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMenuPrincipal.Click += new System.EventHandler(this.lblMenuPrincipal_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFacturacion.Location = new System.Drawing.Point(351, 255);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(114, 35);
            this.btnFacturacion.TabIndex = 2;
            this.btnFacturacion.Text = "Facturacion";
            this.btnFacturacion.UseVisualStyleBackColor = false;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // btnadmin
            // 
            this.btnadmin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnadmin.Location = new System.Drawing.Point(338, 201);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(145, 37);
            this.btnadmin.TabIndex = 3;
            this.btnadmin.Text = "Administracion";
            this.btnadmin.UseVisualStyleBackColor = false;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistro.Location = new System.Drawing.Point(353, 144);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(114, 37);
            this.btnRegistro.TabIndex = 4;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alineamientoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 63;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alineamientoToolStripMenuItem
            // 
            this.alineamientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracionToolStripMenuItem,
            this.administracionToolStripMenuItem1,
            this.facturacionToolStripMenuItem});
            this.alineamientoToolStripMenuItem.Name = "alineamientoToolStripMenuItem";
            this.alineamientoToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.alineamientoToolStripMenuItem.Text = "Alineamiento";
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alSelecionarloEntraraElMenuRegistroToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.administracionToolStripMenuItem.Text = "Registro";
            // 
            // alSelecionarloEntraraElMenuRegistroToolStripMenuItem
            // 
            this.alSelecionarloEntraraElMenuRegistroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dondePordraVerElRegitroDeEmpleadoYClienteToolStripMenuItem});
            this.alSelecionarloEntraraElMenuRegistroToolStripMenuItem.Name = "alSelecionarloEntraraElMenuRegistroToolStripMenuItem";
            this.alSelecionarloEntraraElMenuRegistroToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.alSelecionarloEntraraElMenuRegistroToolStripMenuItem.Text = "Al selecionarlo entrar al menu registro";
            // 
            // dondePordraVerElRegitroDeEmpleadoYClienteToolStripMenuItem
            // 
            this.dondePordraVerElRegitroDeEmpleadoYClienteToolStripMenuItem.Name = "dondePordraVerElRegitroDeEmpleadoYClienteToolStripMenuItem";
            this.dondePordraVerElRegitroDeEmpleadoYClienteToolStripMenuItem.Size = new System.Drawing.Size(338, 22);
            this.dondePordraVerElRegitroDeEmpleadoYClienteToolStripMenuItem.Text = "Donde pordra ver el regitro de empleado y cliente ";
            // 
            // administracionToolStripMenuItem1
            // 
            this.administracionToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alSelecionarloEntraraAlMenuAdministracionToolStripMenuItem});
            this.administracionToolStripMenuItem1.Name = "administracionToolStripMenuItem1";
            this.administracionToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.administracionToolStripMenuItem1.Text = "Administracion";
            // 
            // alSelecionarloEntraraAlMenuAdministracionToolStripMenuItem
            // 
            this.alSelecionarloEntraraAlMenuAdministracionToolStripMenuItem.Name = "alSelecionarloEntraraAlMenuAdministracionToolStripMenuItem";
            this.alSelecionarloEntraraAlMenuAdministracionToolStripMenuItem.Size = new System.Drawing.Size(324, 22);
            this.alSelecionarloEntraraAlMenuAdministracionToolStripMenuItem.Text = "Al selecionarlo entrara al menu Administracion ";
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alSelecionarloEntraraAlMenuFacturaToolStripMenuItem});
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.facturacionToolStripMenuItem.Text = "Facturacion";
            // 
            // alSelecionarloEntraraAlMenuFacturaToolStripMenuItem
            // 
            this.alSelecionarloEntraraAlMenuFacturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dondePodraCrearOVerFacturasToolStripMenuItem});
            this.alSelecionarloEntraraAlMenuFacturaToolStripMenuItem.Name = "alSelecionarloEntraraAlMenuFacturaToolStripMenuItem";
            this.alSelecionarloEntraraAlMenuFacturaToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.alSelecionarloEntraraAlMenuFacturaToolStripMenuItem.Text = "Al selecionarlo entrara al menu factura";
            // 
            // dondePodraCrearOVerFacturasToolStripMenuItem
            // 
            this.dondePodraCrearOVerFacturasToolStripMenuItem.Name = "dondePodraCrearOVerFacturasToolStripMenuItem";
            this.dondePodraCrearOVerFacturasToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.dondePodraCrearOVerFacturasToolStripMenuItem.Text = "Donde podra crear o ver facturas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(736, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "Salir";
            // 
            // iconButton4
            // 
            this.iconButton4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 19;
            this.iconButton4.Location = new System.Drawing.Point(715, 402);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(73, 25);
            this.iconButton4.TabIndex = 96;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(351, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 41);
            this.button1.TabIndex = 98;
            this.button1.Text = "Proveedor";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.btnFacturacion);
            this.Controls.Add(this.lblMenuPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuPrincipal;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alineamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alSelecionarloEntraraElMenuRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alSelecionarloEntraraAlMenuAdministracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alSelecionarloEntraraAlMenuFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dondePodraCrearOVerFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dondePordraVerElRegitroDeEmpleadoYClienteToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Button button1;
    }
}