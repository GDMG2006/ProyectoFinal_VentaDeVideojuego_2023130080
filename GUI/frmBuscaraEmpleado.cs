using ProyectoFinal03.clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinal03.GUI
{
    public partial class frmBuscaraEmpleado : Form
    {
        protected int contadorTextBox { get; set; } = 7;
        private List<Empleado> registrosGrid = new List<Empleado>();
        private StreamReader archivoReader;
        private List<Empleado> listaEmpleados;

        public string valorRetorno1 { get; set; }
        public string valorRetorno2 { get; set; }

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

        public frmBuscaraEmpleado()
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

        public void ObtenerDatosTextBox(string[] valores)
        {
            if (valores.Length != contadorTextBox)
            {
                throw new ArgumentException($"Se esperaban {contadorTextBox} valores, pero se recibieron {valores.Length}.");
            }

            // Asignar valores a los controles
            tbxNombre2.Text = valores[(int)IndicesTextBox.Nombre];
            lbxGenero.Text = valores[(int)IndicesTextBox.Genero];
            tbxTelefono2.Text = valores[(int)IndicesTextBox.Telefono];
            tbxCorreo2.Text = valores[(int)IndicesTextBox.Correo];
            cbxpuesto.Text = valores[(int)IndicesTextBox.Puesto];
            dtpFechaContratacion.Value = DateTime.Parse(valores[(int)IndicesTextBox.FechaContratacio]);
            txbSueldo.Text = valores[(int)IndicesTextBox.Sueldo];

            // Crear y agregar el empleado
            Empleado nuevoEmpleado = new Empleado(
                tbxNombre2.Text,
                lbxGenero.Text,
                tbxTelefono2.Text,
                tbxCorreo2.Text,
                cbxpuesto.Text,
                decimal.Parse(txbSueldo.Text),
                dtpFechaContratacion.Value
            );
        }

        //DGV//
        private List<Empleado> empleados = new List<Empleado>();

        private void frmBuscarEmpleado_Load(object sender, EventArgs e)
        {
            empleados = GestorDeEmpleados.Cargar();
            dgvEmpleados.DataSource = empleados;
        }


        private void btnActualizar2_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar2_Click(object sender, EventArgs e)
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

        private void iconButton2_Click(object sender, EventArgs e)

        {
            string nombreBuscado = txbBuscarNacionalidad.Text.Trim();
            var empleados = GestorDeEmpleados.Cargar();

            var resultado = empleados
            .Where(emp => emp.Nombre.IndexOf(nombreBuscado, StringComparison.OrdinalIgnoreCase) >= 0)
            .ToList();

            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = resultado;
        }



        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Eliminar empleado seleccionado
        private Empleado ObtenerEmpleadoSeleccionado()
        {
            if (dgvEmpleados.CurrentRow != null)
            {
                return dgvEmpleados.CurrentRow.DataBoundItem as Empleado;
            }
            return null;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            var empleadoSeleccionado = ObtenerEmpleadoSeleccionado();

            if (empleadoSeleccionado == null)
            {
                MessageBox.Show("Selecciona un empleado para eliminar.");
                return;
            }

            var confirmacion = MessageBox.Show(
                $"¿Estás seguro de que quieres eliminar a {empleadoSeleccionado.Nombre}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                var empleados = GestorDeEmpleados.Cargar();

                // Buscar por una propiedad única, como el correo
                empleados = empleados
                    .Where(emp => emp.Correo != empleadoSeleccionado.Correo)
                    .ToList();

                GestorDeEmpleados.Guardar(empleados);

                MessageBox.Show("Empleado eliminado correctamente.");

                // Recargar la vista
                dgvEmpleados.DataSource = null;
                dgvEmpleados.DataSource = empleados;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txbBuscarNacionalidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

