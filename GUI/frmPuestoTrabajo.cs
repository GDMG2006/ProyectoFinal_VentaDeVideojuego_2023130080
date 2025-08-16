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
    public partial class frmPuestoTrabajo : Form
    {
        public frmPuestoTrabajo()
        {
            InitializeComponent();
            listaPuestos = GestorPuestoTrabajo.Cargar(); 
        }

        private List<PuestoTrabajo> listaPuestos;


        private void iconButton1_Click(object sender, EventArgs e)
        { 
            try
            {
                // Captura de datos desde los controles
                string nombre = textBox1.Text;
                string descripcion = textBox2.Text;
                decimal salario = decimal.Parse(textBox3.Text); 
                bool activo = checkBox1.Checked;

                // Crear objeto
                ProyectoFinal03.clases.PuestoTrabajo nuevoPuesto = new ProyectoFinal03.clases.PuestoTrabajo(nombre, descripcion, salario, activo);
                // Agregar a la lista
                listaPuestos.Add(nuevoPuesto);

                // Guardar en JSON
                GestorPuestoTrabajo.Guardar(listaPuestos);

                
                MessageBox.Show("Puesto guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el puesto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
