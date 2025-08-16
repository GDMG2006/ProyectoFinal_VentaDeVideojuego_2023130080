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
using static ProyectoFinal03.clases.Facturacion;


namespace ProyectoFinal03.GUI
{
    public partial class Facturas : Form
    {
        private string numeroFactura;

        public Facturas()
        {
            InitializeComponent();
        }

        private Factura textBox1_TextChanged(object sender, EventArgs e)
        {

            List<Factura> facturas = ObtenerFacturas();
            return facturas.FirstOrDefault(f => f.NumeroFactura == numeroFactura);


        }

        private List<Factura> ObtenerFacturas()
        {
            throw new NotImplementedException();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {

        }

        private void tbxnombrejuego_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxNumeroFactura_TextChanged(object sender, EventArgs e)
        {

        }

        private void IbtnAtras_Click(object sender, EventArgs e)
        {
            frmfacturas registroForm = new frmfacturas();
            registroForm.Show();
            this.Hide();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void frmBuscarFactura_Load_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //json-dgv
        private void frmFacturas_Load(object sender, EventArgs e)
        {
            var listaFacturas = GestorFacturas.CargarFacturas();

            dgvFacturas.DataSource = null;
            dgvFacturas.DataSource = listaFacturas;
        }

        private void dgvFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow fila = dgvFacturas.Rows[e.RowIndex];

                    tbxNumeroFactura.Text = fila.Cells["NumeroFactura"].Value.ToString();
                    tbxNombreCliente.Text = fila.Cells["Cliente"].Value.ToString();
                    tbxDNI.Text = fila.Cells["Indentificacion"].Value.ToString();
                    tbxnombrejuego.Text = fila.Cells["Videojuego"].Value.ToString();
                    tbxprecio.Text = fila.Cells["PrecioUnitario"].Value.ToString();
                    nudCantidad.Value = Convert.ToDecimal(fila.Cells["Cantidad"].Value);
                    tbxTotal.Text = fila.Cells["Total"].Value.ToString();
                    dtpFecha.Text = Convert.ToDateTime(fila.Cells["Fecha"].Value).ToShortDateString();
                }
            }

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            {
                string criterio = textBox1.Text.Trim().ToLower();
                var todas = GestorFacturas.CargarFacturas();

                var filtradas = todas
                    .Where(f => f.Cliente.ToLower().Contains(criterio) ||
                                f.NumeroFactura.ToString().Contains(criterio))
                    .ToList();

                dgvFacturas.DataSource = null;
                dgvFacturas.DataSource = filtradas;


            }




        }
        private void LimpiarCampos()
        {
            tbxNumeroFactura.Clear();
            tbxNombreCliente.Clear();
            tbxDNI.Clear();
            tbxnombrejuego.Clear();
            tbxprecio.Clear();
            nudCantidad.Value = 1;
            tbxTotal.Clear();
            dtpFecha.Value = DateTime.Today;
        }
        private Factura ObtenerFacturaSeleccionada()
        {
            if (dgvFacturas.CurrentRow != null)
            {
                return dgvFacturas.CurrentRow.DataBoundItem as Factura;
            }
            return null;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            var facturaSeleccionada = ObtenerFacturaSeleccionada();

            if (facturaSeleccionada == null)
            {
                MessageBox.Show("Selecciona una factura para eliminar.");
                return;
            }

            var confirmacion = MessageBox.Show(
                $"¿Estás seguro de que quieres eliminar la factura #{facturaSeleccionada.NumeroFactura}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                var facturas = GestorFacturas.CargarFacturas(); 
                facturas = facturas
                    .Where(f => f.NumeroFactura != facturaSeleccionada.NumeroFactura)
                    .ToList();

                GestorFacturas.GuardarFacturas(facturas); 
                MessageBox.Show("Factura eliminada correctamente.");

                dgvFacturas.DataSource = null;
                dgvFacturas.DataSource = facturas;
            }
        }

        private void lblNumeroFacura2_Click(object sender, EventArgs e)
        {

        }
    }
}
    

