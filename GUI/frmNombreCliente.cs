using ProyectoFinal03.clases;
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
    public partial class frmNombreCliente : Form
    {
        public frmNombreCliente()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        
        {
            try
            {
                // Validaciones previas
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("El primer nombre y el primer apellido son obligatorios.");
                    return;
                }

                // Crear instancia
                NombreCliente nuevo = new NombreCliente(
                    textBox1.Text.Trim(),
                    textBox2.Text.Trim(),
                    textBox3.Text.Trim(),
                    textBox4.Text.Trim()
                );

                // Cargar lista actual
                var lista = GestorNombreCliente.Cargar();

                // Agregar y guardar
                lista.Add(nuevo);
                GestorNombreCliente.Guardar(lista);

                MessageBox.Show("Cliente guardado correctamente.");
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            
        }

        private void LimpiarFormulario()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
          
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
        private void frmNombreCliente_Load(object sender, EventArgs e)
        {
            CargarClientesEnGrid();
        }
        private void CargarClientesEnGrid()
        {
            var lista = GestorNombreCliente.Cargar();
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = lista;
        }


        private void iconButton3_Click(object sender, EventArgs e)
        {
            string nombreBuscado = txbBuscarNacionalidad.Text.Trim().ToLower();
            var lista = GestorNombreCliente.Cargar();

            var resultado = lista.Where(c => c.PrimerNombre.ToLower().Contains(nombreBuscado)).ToList();

            if (resultado.Any())
            {
                dgvEmpleados.DataSource = null;
                dgvEmpleados.DataSource = resultado;
            }
            else
            {
                MessageBox.Show("No se encontró ningún cliente con ese nombre.");
            }

        }
    }
}


