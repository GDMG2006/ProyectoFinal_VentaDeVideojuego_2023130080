using Newtonsoft.Json;
using ProyectoFinal03.clases;
using ProyectoFinal03.gestores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal03.GUI
{
    public partial class frmNuevoCliente : Form
    {
        public frmNuevoCliente()
        {
            InitializeComponent();
           this.Load += frmNuelcliente_Load;
        }
        private void frmNuelcliente_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = null;
            comboBox1.Items.Clear();

            List<NombreCliente> lista = GestorNombreCliente.Cargar();

            if (lista.Count == 0)
            {
                MessageBox.Show("No se encontraron juegos en el JSON.");
                return;
            }

            comboBox1.DataSource = lista;
            comboBox1.DisplayMember = "Nombre";
            comboBox1.SelectedIndex = -1;
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nacionalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxfiel_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvRegistroDeCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
         

        private void IbtnAtras_Click(object sender, EventArgs e)
        {
            frmMenuRegistro registroForm = new frmMenuRegistro();
            registroForm.Show();
            this.Hide();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Cliente nuevoCliente = new Cliente(
   // método que vos definas para generar el ID
   comboBox1.Text,
   listBox1.SelectedItem?.ToString() ?? "Otro",
   tbxTelefono.Text,
   tbxCorreo.Text,
   cbxNacionalidad.Text,
   cbxfiel.Checked
   
);

            Program.clientesLista.Add(nuevoCliente);
            GestorDeClientes.Guardar(Program.clientesLista);

            MessageBox.Show("Cliente guardado correctamente.");
            // si tenés un método para limpiar los TextBox

        }

        private void frmNuevoCliente_Load(object sender, EventArgs e)

        {
            GestorNacionalidad gestor = new GestorNacionalidad();
            var lista = GestorNacionalidad.Cargar();
            cbxNacionalidad.DataSource = null;
            cbxNacionalidad.Items.Clear();
            if (lista.Count == 0)
            {
                MessageBox.Show("No se encontraron proveedores en el JSON.");
                return;
            }

            cbxNacionalidad.DataSource = lista;
            cbxNacionalidad.DisplayMember = "Nombre";
            cbxNacionalidad.SelectedIndex = -1;
        }

        private void cbxNacionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
