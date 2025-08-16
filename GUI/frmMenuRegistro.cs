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
    public partial class frmMenuRegistro : Form
    {
        public frmMenuRegistro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistroCliente_Click(object sender, EventArgs e)
        {
            frmNuevoCliente registroForm = new frmNuevoCliente();
            registroForm.Show();
            this.Hide();
        }

        private void btnRegistroEmpleado_Click(object sender, EventArgs e)
        {
            frmNuevoEmpleado empleado = new frmNuevoEmpleado();
            empleado.Show();
            this.Hide(); 


        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal atras2 = new frmMenuPrincipal();
            atras2.Show();
            this.Hide();
        }

        private void btnRegistroEmpleado_Click_1(object sender, EventArgs e)
        {
         
            frmBuscaraEmpleado registroForm = new frmBuscaraEmpleado();  
            registroForm.Show();                            
            this.Hide();                                     
        }

        

        private void registroDeEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            frmRegistroDeCliente registroForm = new frmRegistroDeCliente();
            registroForm.Show();
            this.Hide();
        }

        private void btnNacionalidad_Click(object sender, EventArgs e)
        {
            frmNacionalidad registroForm = new frmNacionalidad();
            registroForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNombreCliente registroForm = new frmNombreCliente();
            registroForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPuestoTrabajo registroForm = new frmPuestoTrabajo();
            registroForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmNombreEmpleado registroForm = new frmNombreEmpleado();
            registroForm.Show();
            this.Hide();
        }
    }
}

