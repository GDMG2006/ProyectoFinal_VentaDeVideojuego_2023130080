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
    public partial class fmrClasificacionJuego : Form
    {
        public fmrClasificacionJuego()
        {
            InitializeComponent();
            this.Load += fmrClasificacionJuego_Load;
            
        }

        private void fmrClasificacionJuego_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = null;
            comboBox1.Items.Clear();

            List<Juegos> lista = GestorJuegos.Cargar();

            if (lista.Count == 0)
            {
                MessageBox.Show("No se encontraron juegos en el JSON.");
                return;
            }

            comboBox1.DataSource = lista;
            comboBox1.DisplayMember = "Nombre";
            comboBox1.SelectedIndex = -1;
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LimpiarFormulario()
        {
            
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            textBox1.Clear();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear nueva instancia con datos del formulario
                ClasificacionJuego nueva = new ClasificacionJuego(
                    comboBox1.Text.Trim(),
                    textBox2.Text.Trim(),
                    int.Parse(numericUpDown1.Text.Trim()),
                    textBox1.Text.Trim()
                );

                // Cargar lista actual desde JSON
                var lista = GestorClasificacionJuego.Cargar();

                // Validar duplicado por nombre + sistema
                if (lista.Any(c => c.Nombre == nueva.Nombre && c.SistemaClasificacion == nueva.SistemaClasificacion))
                {
                    MessageBox.Show("Ya existe una clasificación con ese nombre y sistema.");
                    return;
                }

                // Agregar y guardar
                lista.Add(nueva);
                GestorClasificacionJuego.Guardar(lista);

                MessageBox.Show("Clasificación guardada correctamente.");
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}");
            }

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string criterio = textBox3.Text.Trim().ToLower();
                var lista = GestorClasificacionJuego.Cargar();

                List<ClasificacionJuego> resultado;

                if (string.IsNullOrWhiteSpace(criterio))
                {
                    //General Buscar
                    resultado = lista;
                }
                else
                {
                    //Filtro
                    resultado = lista.Where(c =>
                        c.Nombre.ToLower().Contains(criterio) ||
                        c.SistemaClasificacion.ToLower().Contains(criterio)
                    ).ToList();
                }

                gdvClasificacion.DataSource = null;
                gdvClasificacion.DataSource = resultado;

                if (resultado.Count == 0)
                    MessageBox.Show("No se encontraron clasificaciones que coincidan.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar: {ex.Message}");
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
           {
            try
            {
                if (gdvClasificacion.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecciona una clasificación para eliminar.");
                    return;
                }

                // Obtener la clasificación seleccionada
                var seleccion = (ClasificacionJuego)gdvClasificacion.SelectedRows[0].DataBoundItem;

                // Confirmar eliminación
                var confirm = MessageBox.Show(
                    $"¿Seguro que deseas eliminar '{seleccion.Nombre}' del sistema '{seleccion.SistemaClasificacion}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm != DialogResult.Yes)
                    return;

                // Cargar lista actual
                var lista = GestorClasificacionJuego.Cargar();

                // Eliminar por coincidencia exacta
                var actualizada = lista.Where(c =>
                    !(c.Nombre == seleccion.Nombre && c.SistemaClasificacion == seleccion.SistemaClasificacion)
                ).ToList();

                // Guardar lista actualizada
                GestorClasificacionJuego.Guardar(actualizada);

                MessageBox.Show("Clasificación eliminada correctamente.");
                iconButton2.PerformClick(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}");
            }
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
