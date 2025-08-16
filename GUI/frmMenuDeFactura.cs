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
using static ProyectoFinal03.clases.Inventario;


namespace ProyectoFinal03.GUI
{
    public partial class frmMenuDeFactura : Form
    {
        public frmMenuDeFactura()
        {
            InitializeComponent();
            this.Load += frmMenuDeFactura_Load;
            this.Load += frmMenuDeFactura2_Load;
        }
        private void frmMenuDeFactura2_Load(object sender, EventArgs e)
        {
            cbxNombreCliente.DataSource = null;
            cbxNombreCliente.Items.Clear();

            List<NombreCliente> lista = GestorNombreCliente.Cargar();

            if (lista.Count == 0)
            {
                MessageBox.Show("No se encontraron juegos en el JSON.");
                return;
            }

            cbxNombreCliente.DataSource = lista;
            cbxNombreCliente.DisplayMember = "Nombre";
            cbxNombreCliente.SelectedIndex = -1;
        }
        private void frmMenuDeFactura_Load(object sender, EventArgs e)
        {
            comboBox2.DataSource = null;
            comboBox2.Items.Clear();

            List<Juegos> lista = GestorJuegos.Cargar();

            if (lista.Count == 0)
            {
                MessageBox.Show("No se encontraron juegos en el JSON.");
                return;
            }

            comboBox2.DataSource = lista;
            comboBox2.DisplayMember = "Nombre";
            comboBox2.SelectedIndex = -1;

        }


        private void LimpiarCampos()
        {
            tbxTotal.Text = "";
            cbxMetodoPago.SelectedIndex = -1;
        }

        private void btnPagarFactura_Click(object sender, EventArgs e)
      
        {
            try
            {
                decimal total = decimal.Parse(tbxTotal.Text);

                if (total <= 0)
                {
                    MessageBox.Show("❌ Pago sin éxito. El monto debe ser mayor a cero.", "Error de pago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("✅ Pago realizado con éxito.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("⚠️ El valor ingresado no es un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnTotal_Click(object sender, EventArgs e)
        {
         
            try
            {
                int cantidad = int.Parse(nudCantidad.Text);       
                decimal precio = decimal.Parse(tbxprecio.Text);  

                decimal total = cantidad * precio;
                tbxTotal.Text = total.ToString("F2");            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el total: " + ex.Message);
            }
        }
       

        private void btnGuardar_Click(object sender, EventArgs e)
       
        {
            try
            {
                var nuevaFactura = new Facturacion.Factura(
                    id: int.Parse(textBox1.Text),
                    numeroFactura: tbxNumeroFactura.Text,
                    cliente: cbxNombreCliente.Text,
                    videojuego: comboBox2.SelectedItem?.ToString() ?? "Sin clasificar",
                    cantidad: (int)nudCantidad.Value,
                    precioUnitario: decimal.Parse(tbxprecio.Text),
                    Total: decimal.Parse(tbxTotal.Text)
                );

                nuevaFactura.CalcularTotal();

                Program.facturaLista.Add(nuevaFactura);
                GestorFacturas.GuardarFacturas(Program.facturaLista);

                nuevaFactura.MostrarFactura();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void tbxNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbxNumeroFactura_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


