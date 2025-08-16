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
    public partial class frmIngresoJuegos : Form
    {
        public frmIngresoJuegos()
        {
            InitializeComponent();
            this.Load += frmIngresoJuegos_Load;
            this.Load += frmIngresoJuegos_Load2;
        }
        private void frmIngresoJuegos_Load(object sender, EventArgs e)
        {
            cbxNombreJuego.DataSource = null;
            cbxNombreJuego.Items.Clear();
            List<Juegos> lista = GestorJuegos.Cargar(); 

            if (lista.Count == 0)
            {
                MessageBox.Show("No se encontraron juegos en el JSON.");
                return;
            }

            cbxNombreJuego.DataSource = lista;
            cbxNombreJuego.DisplayMember = "Nombre";
            cbxNombreJuego.SelectedIndex = -1;
        }
        private void frmIngresoJuegos_Load2(object sender, EventArgs e)
        {
            cbxClasificacion.DataSource = null;
            cbxClasificacion.Items.Clear();

            List<ClasificacionJuego> lista = GestorClasificacionJuego.Cargar();

            if (lista.Count == 0)
            {
                MessageBox.Show("No se encontraron juegos en el JSON.");
                return;
            }

            cbxClasificacion.DataSource = lista;
            cbxClasificacion.DisplayMember = "SistemaClasificacion";
            cbxClasificacion.SelectedIndex = -1;
        }



        private void generoToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
        private void LimpiarCampos()
        {
            txbIdjuego.Clear();
            tbxPrecio3.Clear();
            dtpFechaLazamiento3.Value = DateTime.Today;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
           
            try
            {
                Inventario nuevoItem = new Inventario(
                    int.Parse(txbIdjuego.Text),
                    txbIdjuego.Text,
                    decimal.Parse(tbxPrecio3.Text),
                    (int)nudCanti.Value,
                    cbxClasificacion.SelectedItem?.ToString() ?? "Sin clasificar",
                    cbxPlatadorma.SelectedItem?.ToString() ?? "Sin plataforma",
                    cbxGenero.SelectedItem?.ToString() ?? "Sin género",
                    dtpFechaLazamiento3.Value
                );

                Program.inventarioLista.Add(nuevoItem);
                GestorDeInventario.Guardar(Program.inventarioLista);

                MessageBox.Show("Producto guardado correctamente.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblClasificacion_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nudcantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void cbxClasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxNombreJuego_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
    
}
