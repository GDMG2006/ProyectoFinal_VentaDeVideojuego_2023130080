using Newtonsoft.Json;
using ProyectoFinal03.clases;
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
using static ProyectoFinal03.clases.Facturacion;

namespace ProyectoFinal03.GUI
{
    public partial class frmNacionalidad : Form
    {
        public frmNacionalidad()
        {
            InitializeComponent();
        }

        public void LimpiarTextBox()
        {
            foreach (Control controlGUI in Controls)
            {
                if (controlGUI is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
        }




        private void dgvNacionalidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private Nacionalidad ObtenerNacionalidadSeleccionado()
        {
            if (dgvNacionalidad.CurrentRow != null)
            {
                return dgvNacionalidad.CurrentRow.DataBoundItem as Nacionalidad;
            }
            return null;
        }


        private void iconButton1_Click(object sender, EventArgs e)
        { 
            var seleccionado = ObtenerNacionalidadSeleccionado();

            if (seleccionado == null)
            {
                MessageBox.Show("Selecciona una nacionalidad para eliminar.");
                return;
            }

            var confirmacion = MessageBox.Show(
                $"¿Estás seguro de que quieres eliminar a {seleccionado.Nombre}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                var lista = GestorNacionalidad.Cargar();

                
                lista = lista
                    .Where(n => n.CodigoISO != seleccionado.CodigoISO)
                    .ToList();

                GestorNacionalidad.Guardar(lista);

                MessageBox.Show("Nacionalidad eliminada correctamente.");

                dgvNacionalidad.DataSource = null;
                dgvNacionalidad.DataSource = lista;
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = GestorNacionalidad.Cargar();
                string filtro = textBox1.Text.Trim().ToLower();

                List<Nacionalidad> resultado;

                if (string.IsNullOrWhiteSpace(filtro))
                {
                    // Si no hay filtro, mostrar todo
                    resultado = lista;
                }
                else
                {
                    // Filtrar por nombre
                    resultado = lista
                        .Where(n => n.Nombre.ToLower() == filtro)
                        .ToList();

                    if (resultado.Count == 0)
                    {
                        MessageBox.Show("No se encontró ninguna nacionalidad con ese nombre.");
                        dgvNacionalidad.DataSource = null;
                        return;
                    }
                }

                dgvNacionalidad.DataSource = null;
                dgvNacionalidad.DataSource = resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar nacionalidad: {ex.Message}");
            }
        }


        private void tbxRegion_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
           
            // Validaciones
            if (string.IsNullOrWhiteSpace(tbxNacionalidad.Text) ||
                string.IsNullOrWhiteSpace(tbxRegion.Text) ||
                string.IsNullOrWhiteSpace(tbxIdioma.Text) ||
                string.IsNullOrWhiteSpace(tbxPaisCodigo.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            // Crear instancia
            Nacionalidad nueva = new Nacionalidad(
                tbxNacionalidad.Text.Trim(),
                tbxRegion.Text.Trim(),
                tbxIdioma.Text.Trim(),
                tbxPaisCodigo.Text.Trim()
            );

            try
            {
                // Cargar lista existente
                var lista = GestorNacionalidad.Cargar();

                // Validar duplicado por Código ISO
                if (lista.Any(n => n.CodigoISO == nueva.CodigoISO))
                {
                    MessageBox.Show("Ya existe una nacionalidad con ese código ISO.");
                    return;
                }

                // Agregar y guardar
                lista.Add(nueva);
                GestorNacionalidad.Guardar(lista);

                MessageBox.Show("Nacionalidad guardada correctamente.");
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}");
            }

        }
        private void LimpiarFormulario()
        {
            tbxNacionalidad.Clear();
            tbxRegion.Clear();
            tbxIdioma.Clear();
            tbxPaisCodigo.Clear();
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

        private void tbxNacionalidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

