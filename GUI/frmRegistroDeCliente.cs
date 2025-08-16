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
    public partial class frmRegistroDeCliente : Form
    {
        public frmRegistroDeCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistroDeCliente_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
        //Data GDV
        private void FormClientes_Load(object sender, EventArgs e)
        {
            try
            {
                var listaClientes = GestorDeClientes.Cargar();

                dgvClientes.AutoGenerateColumns = true;
                dgvClientes.DataSource = listaClientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}");
            }
        }
        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                var listaClientes = GestorDeClientes.Cargar();

                dgvClientes.DataSource = null;
                dgvClientes.Columns.Clear(); // Opcional, si usas columnas personalizadas
                dgvClientes.AutoGenerateColumns = true;
                dgvClientes.DataSource = listaClientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar clientes: {ex.Message}");
            }
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
          
            string criterio = txbBuscarNombre.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(criterio))
            {
                MessageBox.Show("Ingrese un criterio de búsqueda.");
                return;
            }


            var listaClientes = GestorDeClientes.Cargar();

            var resultados = listaClientes.Where(c =>
                c.Nombre.ToLower().Contains(criterio) ||
                c.Correo.ToLower().Contains(criterio) ||
                c.Telefono.Contains(criterio) ||
                c.Nacionalidad.ToLower().Contains(criterio) ||
                c.Id.ToString() == criterio
            ).ToList();

            if (resultados.Count == 0)
            {
                MessageBox.Show("No se encontraron clientes con ese criterio.");
            }

            dgvClientes.DataSource = null;
            dgvClientes.DataSource = resultados;
        }

        private Cliente ObtenerClienteSeleccionado()
        {
            if (dgvClientes.CurrentRow != null)
            {
                return dgvClientes.CurrentRow.DataBoundItem as Cliente;
            }
            return null;
        }

        
        private void iconButton1_Click(object sender, EventArgs e)
        {
            var clienteSeleccionado = ObtenerClienteSeleccionado();

            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Selecciona un cliente para eliminar.");
                return;
            }

            var confirmacion = MessageBox.Show(
                $"¿Estás seguro de que quieres eliminar a {clienteSeleccionado.Nombre}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                var clientes = GestorDeClientes.Cargar();

                // ✅ Eliminar por Id único
                clientes = clientes
                    .Where(c => c.Id != clienteSeleccionado.Id)
                    .ToList();

                GestorDeClientes.Guardar(clientes);

                MessageBox.Show("Cliente eliminado correctamente.");

                dgvClientes.DataSource = null;
                dgvClientes.DataSource = clientes;
            }
        }

        private void tbxNacionalidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    


