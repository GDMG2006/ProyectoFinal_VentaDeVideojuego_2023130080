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
    public partial class frmJuegos2 : Form
    {
        public frmJuegos2()
        {
            InitializeComponent();
            this.Load += frmJuegos_load;
        }

        private void frmJuegos_load(object sender, EventArgs e)
        {
            comboBox1.DataSource = null;
            comboBox1.Items.Clear();

            List<ClasificacionJuego> lista = GestorClasificacionJuego.Cargar();

            if (lista.Count == 0)
            {
                MessageBox.Show("No se encontraron juegos en el JSON.");
                return;
            }

            comboBox1.DataSource = lista;
            comboBox1.DisplayMember = "SistemaClasificacion";
            comboBox1.SelectedIndex = -1;
        }


        private void LimpiarCampos()
        {
            textBox4.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            comboBox1.SelectedIndex = -1;
        }
         private List<Juegos> listaJuegos = GestorJuegos.Cargar();

        private void iconButton1_Click(object sender, EventArgs e)
        {
          
            try
            {
                string nombre = textBox5.Text;
                string genero = textBox4.Text;
                decimal precio = decimal.Parse(textBox3.Text);
                int stock = int.Parse(textBox2.Text);
                ClasificacionJuego clasificacion = (ClasificacionJuego)comboBox1.SelectedItem;

                Juegos nuevoJuego = new Juegos(nombre, genero, precio, stock, clasificacion);
                listaJuegos.Add(nuevoJuego);

                GestorJuegos.Guardar(listaJuegos);

                MessageBox.Show("Juego agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el juego: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
