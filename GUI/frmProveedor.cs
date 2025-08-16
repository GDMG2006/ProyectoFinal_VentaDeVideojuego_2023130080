using ProyectoFinal03.clases;
using ProyectoFinal03.gestores;
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
    public partial class frmProveedor : Form
    {
        public frmProveedor()
        {
            InitializeComponent();
        }
        private void LimpiarCampos()
        {
            tbxNombre.Clear();
            tbxTelefono.Clear();
            tbxCorreo.Clear();
            tbxDireccion.Clear();
        }
        private void iconButton1_Click(object sender, EventArgs e)
        { 
            try
            {
                var proveedor = new Proveedor(
                    tbxNombre.Text,
                    tbxTelefono.Text,
                    tbxCorreo.Text,
                    tbxDireccion.Text,
                    cbxProducto.Text,
                    cbxActivo.Text == "Sí"
                );

                var gestor = new GestorProveedor();
                gestor.AgregarProveedor(proveedor);

                MessageBox.Show("Proveedor guardado correctamente.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
        //dgv
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            var gestor = new GestorProveedor();
            dgvProveedor.AutoGenerateColumns = true;
            dgvProveedor.DataSource = null;
            dgvProveedor.DataSource = gestor.CargarProveedores();
        }
        

        private Proveedor ObtenerProveedorSeleccionado()
        {
            if (dgvProveedor.CurrentRow != null)
            {
                return dgvProveedor.CurrentRow.DataBoundItem as Proveedor;
            }
            return null;
        }

        private void iconButton2_Click(object sender, EventArgs e)
            {

                string criterio = textBox2.Text.Trim().ToLower();

                if (string.IsNullOrWhiteSpace(criterio))
                {
                    MessageBox.Show("Ingrese un criterio de búsqueda.");
                    return;
                }
            var gestor = new GestorProveedor();
            var lista = gestor.CargarProveedores();


            var resultados = lista.Where(p =>
                    p.Nombre.ToLower().Contains(criterio) ||
                    p.Email.ToLower().Contains(criterio) ||
                    p.Telefono.Contains(criterio) ||
                    p.TipoProducto.ToLower().Contains(criterio)
                ).ToList();

            dgvProveedor.DataSource = null;
            dgvProveedor.DataSource = resultados;
            }

        

        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void iconButton3_Click(object sender, EventArgs e)
        {

            var proveedorSeleccionado = ObtenerProveedorSeleccionado();

            if (proveedorSeleccionado == null)
            {
                MessageBox.Show("Selecciona un proveedor para eliminar.");
                return;
            }

            var confirmacion = MessageBox.Show(
                $"¿Estás seguro de que quieres eliminar a {proveedorSeleccionado.Nombre}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                var gestor = new GestorProveedor();
                var proveedores = gestor.CargarProveedores();

                proveedores = proveedores
                    .Where(p => p.Email != proveedorSeleccionado.Email)
                    .ToList();

                gestor.GuardarProveedores(proveedores);

                // Eliminar por correo (asumiendo que es único)
                proveedores = proveedores
                    .Where(p => p.Email != proveedorSeleccionado.Email)
                    .ToList();


                MessageBox.Show("Proveedor eliminado correctamente.");

                dgvProveedor.DataSource = null;
                dgvProveedor.DataSource = proveedores;
            }
        }
               

            

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void cbxActivo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbxNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
