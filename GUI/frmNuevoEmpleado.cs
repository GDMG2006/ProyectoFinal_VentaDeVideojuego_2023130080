using ProyectoFinal03.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProyectoFinal03.GUI
{
    public partial class frmNuevoEmpleado : Form
    {
        protected int contadorTextBox { get; set; } = 7;
        private StreamWriter archivoWriter;
        private List<Empleado> listaEmpleados;

        enum IndicesTextBox
        {
            Nombre = 0,
            Genero = 1,
            Telefono = 2,
            Correo = 3,
            Puesto = 4,
            FechaContratacio = 5,
            Sueldo = 6
        }
        public void LimpiarTextBox()
        {
            foreach (Control controlGUI in Controls)
            {
                (controlGUI as TextBox)?.Clear();
            }
        }
        public string[] ObtenerDatosTextBox()
        {
            return new string[]
            {
                txbSueldo.Text,
                comboBox1.Text,
                tbxCorreo2.Text,
                tbxTelefono2.Text,
                lbxGenero.Text,
                comboBox2.Text,
                dtpFechaContratacion.Value.ToString("dd/MM/yyyy"),

            };
        }
        public frmNuevoEmpleado()
        {
            InitializeComponent();
            this.Load += frmNuevoEmpleado_Load;
            this.Load += frmNuevoEmpleado_Load2;
        }

        private void frmNuevoEmpleado_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = null;
            comboBox1.Items.Clear();

            List<PuestoTrabajo> lista = GestorPuestoTrabajo.Cargar();

            if (lista.Count == 0)
            {
                MessageBox.Show("No se encontraron juegos en el JSON.");
                return;
            }

            comboBox1.DataSource = lista;
            comboBox1.DisplayMember = "Nombre";
            comboBox1.SelectedIndex = -1;
        }
        private void frmNuevoEmpleado_Load2(object sender, EventArgs e)
        {
            
            comboBox2.Items.Clear();

            List<NombreEmpleado> lista = GestorEmpleadoNombre.Cargar();

            if (lista.Count == 0)
            {
                MessageBox.Show("No se encontraron Ningun Nombre de Empleado en el JSON.");
                return;
            }

            comboBox2.DataSource = lista;
            comboBox2.DisplayMember = "PrimerNombre";
            comboBox2.SelectedIndex = -1;

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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmMenuRegistro atras = new frmMenuRegistro();
            atras.Show();
            this.Hide();
        }

        private void lblGeneroEmpleado_Click(object sender, EventArgs e)
        {

        }

        
            

        private void btnactualizar3(object sender, EventArgs e)
        {
            string[] valores = ObtenerDatosTextBox();

            // Validar que el nombre no esté vacío
            if (!string.IsNullOrEmpty(valores[(int)IndicesTextBox.Nombre]))
            {
                try
                {
                    // Extraer y convertir los datos
                    string nombre = valores[(int)IndicesTextBox.Nombre];
                    string genero = valores[(int)IndicesTextBox.Genero];
                    string telefono = valores[(int)IndicesTextBox.Telefono];
                    string correo = valores[(int)IndicesTextBox.Correo];
                    string puesto = valores[(int)IndicesTextBox.Puesto];
                    decimal sueldo = decimal.Parse(valores[(int)IndicesTextBox.Sueldo]);
                    DateTime FechaContratacio = DateTime.Parse(valores[(int)IndicesTextBox.FechaContratacio]);

                    // Crear el objeto Empleado
                    Empleado cuenta = new Empleado(nombre, genero, telefono, correo, puesto, sueldo, FechaContratacio);

                    // Aquí podrías actualizar una lista, mostrar en pantalla, etc.
                    MessageBox.Show($"Empleado actualizado:\n{cuenta}");
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Error en el formato de sueldo o fecha. Verifica los datos ingresados.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("El campo 'Nombre' no puede estar vacío.");
            }
            LimpiarTextBox();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            List<Empleado> listaEmpleados = new List<Empleado>();
            string[] valores = ObtenerDatosTextBox();
            string nombreBuscado = valores[(int)IndicesTextBox.Nombre];

            if (!string.IsNullOrEmpty(nombreBuscado))
            {
                // Buscar el empleado por nombre
                var empleadoAEliminar = listaEmpleados
                    .FirstOrDefault(emp => emp.Nombre.Equals(nombreBuscado, StringComparison.OrdinalIgnoreCase));

                if (empleadoAEliminar != null)
                {
                    listaEmpleados.Remove(empleadoAEliminar);
                    MessageBox.Show($"Empleado '{nombreBuscado}' eliminado correctamente.");

                    // Actualizar vista si usas DataGridView

                }
                else
                {
                    MessageBox.Show("Empleado no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa el nombre del empleado a eliminar.");
            }
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {

        }

       

        private void dgvNuevoEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.RowIndex < listaEmpleados.Count)
            {
                var empleadoSeleccionado = listaEmpleados[e.RowIndex];
                comboBox2.Text = empleadoSeleccionado.Nombre;
                lbxGenero.Text = empleadoSeleccionado.Genero;
                tbxTelefono2.Text = empleadoSeleccionado.Telefono;
                tbxCorreo2.Text = empleadoSeleccionado.Correo;
                comboBox1.Text = empleadoSeleccionado.Puesto;
                dtpFechaContratacion.Value = empleadoSeleccionado.FechaContratacion;
                txbSueldo.Text = empleadoSeleccionado.Sueldo.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LimpiarCampos()
        {
            lbxGenero.SelectedIndex = -1;
            tbxTelefono2.Clear();
            tbxCorreo2.Clear();
            txbSueldo.Clear();
            dtpFechaContratacion.Value = DateTime.Today;
        }

       

        private void iconButton1_Click(object sender, EventArgs e)
        {

            try
            {
                Empleado nuevoEmpleado = new Empleado(
                    comboBox2.Text,
                    lbxGenero.SelectedItem?.ToString() ?? "Otro",
                    tbxTelefono2.Text,
                    tbxCorreo2.Text,
                    comboBox1.Text,
                    decimal.Parse(txbSueldo.Text),
                    dtpFechaContratacion.Value
                );

                Program.empleadosLista.Add(nuevoEmpleado);
                GestorDeEmpleados.Guardar(Program.empleadosLista);

                MessageBox.Show("Empleado guardado correctamente.");
                LimpiarCampos(); // si tenés un método para limpiar los TextBox
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
    

}



   