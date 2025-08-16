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
    public partial class frmMenuAdmin : Form
    {
        public frmMenuAdmin()
        {
            InitializeComponent();
        }

        private void btnRevisionStock_Click(object sender, EventArgs e)
        {
            frmStockVideoJuegos registroForm = new frmStockVideoJuegos();
            registroForm.Show();
            this.Hide();
        }

        

        private void btnAgregarVideojuego_Click(object sender, EventArgs e)
        {
            frmIngresoJuegos registroForm = new frmIngresoJuegos();
            registroForm.Show();
            this.Hide();
        }

        private void lblMenuAdmin_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fmrClasificacionJuego registroForm = new fmrClasificacionJuego();
            registroForm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmJuegos2 registroForm = new frmJuegos2();
            registroForm.Show();
            this.Hide();
        }
    }
}
