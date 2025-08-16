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
    public partial class frmStockVideoJuegos : Form
    {
        public frmStockVideoJuegos()
        {
            InitializeComponent();
        }

       
        private void IbtnAtras_Click(object sender, EventArgs e)
        {
            frmMenuAdmin registroForm = new frmMenuAdmin();
            registroForm.Show();
            this.Hide();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //DGV
        private void frmStockVideoJuegos_Load(object sender, EventArgs e)
        {
            this.Load += new System.EventHandler(this.frmStockVideoJuegos_Load);
            this.Load += frmStockVideoJuegos_Load;
            dgvMenuAdmini.AutoGenerateColumns = true;
            iconButton2.PerformClick(); // Carga los datos automáticamente
        }
       
              

        private Inventario ObtenerVideojuegoSeleccionado()
        {
            if (dgvMenuAdmini.CurrentRow != null)
            {
                return dgvMenuAdmini.CurrentRow.DataBoundItem as Inventario;
            }
            return null;
        }
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            var lista = GestorJuegos.Cargar();
            MessageBox.Show($"Se cargaron {lista.Count} videojuegos.");
            dgvMenuAdmini.DataSource = null;
            dgvMenuAdmini.DataSource = lista;

        }



        private void iconButton2_Click(object sender, EventArgs e)
        {

            string nombreBuscado = txbBuscarNombre.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(nombreBuscado))
            {
                MessageBox.Show("Por favor, ingresa un nombre de videojuego para buscar.");
                return;
            }
            var lista = GestorJuegos.Cargar();
            var resultado = lista
                .Where(i => i.Nombre.ToLower().Contains(nombreBuscado))
                .ToList();
            if (resultado.Count == 0)
            {
                MessageBox.Show("No se encontraron videojuegos con ese nombre.");
            }
            else
            {
                dgvMenuAdmini.DataSource = null;
                dgvMenuAdmini.DataSource = resultado;
            }
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            var juegoSeleccionado = ObtenerVideojuegoSeleccionado();

            if (juegoSeleccionado == null)
            {
                MessageBox.Show("Selecciona un videojuego para eliminar.");
                return;
            }

            var confirmacion = MessageBox.Show(
                $"¿Estás seguro de que quieres eliminar '{juegoSeleccionado.Nombre}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                var inventario = GestorDeInventario.Cargar();
                
                
                GestorDeInventario.Guardar(inventario);

                MessageBox.Show("Videojuego eliminado correctamente.");

                dgvMenuAdmini.DataSource = null;
                dgvMenuAdmini.DataSource = inventario;
            }
        }

        private void dgvMenuAdmini_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbxNombreJuego3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
