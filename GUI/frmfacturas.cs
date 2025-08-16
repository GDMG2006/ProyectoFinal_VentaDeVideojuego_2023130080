using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal03.GUI
{
    public partial class frmfacturas : Form
    {
        public frmfacturas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearFactura_Click(object sender, EventArgs e)
        {
            frmMenuDeFactura registroForm = new frmMenuDeFactura();  
            registroForm.Show();                            
            this.Hide();                                     
        }

        private void btnVerFactura_Click(object sender, EventArgs e)
        {
            Facturas registroForm = new Facturas();
            registroForm.Show();
            this.Hide();
        }

       

        private void IbtnAtras_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal registroForm = new frmMenuPrincipal();
            registroForm.Show();
            this.Hide();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

