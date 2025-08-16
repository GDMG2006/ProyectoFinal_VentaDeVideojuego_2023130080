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
    public partial class frmNombreEmpleado : Form
    {
        public frmNombreEmpleado()
        {
            InitializeComponent();
        }
        private List<GestorEmpleadoNombre> listaEmpleados = new List<GestorEmpleadoNombre>();
        private void iconButton1_Click(object sender, EventArgs e)
        {

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
                    NombreEmpleado nuevo = new NombreEmpleado(
                        textBox1.Text.Trim(),
                        textBox2.Text.Trim(),
                        textBox3.Text.Trim(),
                        textBox4.Text.Trim()
                    );
                    
                    var lista = GestorEmpleadoNombre.Cargar();
                    lista.Add(nuevo);
                    GestorEmpleadoNombre.Guardar(lista);

                    MessageBox.Show("Cliente guardado correctamente.");
                    LimpiarFormulario(); ;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }


        private void frmNombreCliente_Load2(object sender, EventArgs e)
        {
            CargarClientesEnGrid();
        }
        private void CargarClientesEnGrid()
        {
            var lista = GestorNombreCliente.Cargar();
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = lista;
        }


        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            string nombreBuscado = txbBuscarNacionalidad.Text.Trim().ToLower();
            var lista = GestorEmpleadoNombre.Cargar();

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

        private void LimpiarFormulario()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void IbtnAtras_Click(object sender, EventArgs e)
        {
            frmMenuRegistro registroForm = new frmMenuRegistro();
            registroForm.Show();
            this.Hide();
        }
    }
}


   