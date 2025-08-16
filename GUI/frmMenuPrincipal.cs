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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void lblMenuPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            frmMenuRegistro registrodeempleado = new frmMenuRegistro();
            registrodeempleado.Show();
            this.Hide();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            frmMenuAdmin registroForm = new frmMenuAdmin();
            registroForm.Show();
            this.Hide();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            frmfacturas registroForm = new frmfacturas();
            registroForm.Show();
            this.Hide();
        }

       

        

        private void button1_Click(object sender, EventArgs e)
        {
            frmProveedor registroForm = new frmProveedor();
            registroForm.Show();
            this.Hide();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
