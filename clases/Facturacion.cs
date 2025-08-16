using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace ProyectoFinal03.clases { 

    public class Facturacion { 
   
        public class Factura
        {
            //constructor
            public Factura(int id, string numeroFactura, string cliente, string videojuego, int cantidad, decimal precioUnitario, decimal Total)
            {
                Id = id;
                NumeroFactura = numeroFactura;
                Cliente = cliente;
                Videojuego = videojuego;
                Cantidad = cantidad;
                PrecioUnitario = precioUnitario;
                this.Total = Total;
            }

            // Propiedades básicas 
            public int Id { get; set; }
            public string NumeroFactura { get; set; }
            public DateTime Fecha { get; set; } = DateTime.Now;
            public string Cliente { get; set; }
            public string Videojuego { get; set; }
            public int Cantidad { get; set; }
            public decimal PrecioUnitario { get; set; }
            public decimal Total { get; private set; }

            // Método para calcular el total
            public void CalcularTotal()
            {
                Total = Cantidad * PrecioUnitario;
            }

            // Método para mostrar en MessageBox
            public void MostrarFactura()
            {
                string mensaje = $"FACTURA #{NumeroFactura}\n\n" +
                               $"Fecha: {Fecha:dd/MM/yyyy}\n" +
                               $"Cliente: {Cliente}\n" +
                               $"Videojuego: {Videojuego}\n" +
                               $"Cantidad: {Cantidad}\n" +
                               $"Precio Unitario: {PrecioUnitario:C}\n\n" +
                               $"TOTAL A PAGAR: {Total:C}";

                MessageBox.Show(mensaje, "Factura Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Método para vincular los controles del frm
            public void BindToForm(TextBox txtCliente, TextBox txtVideojuego,
                                 NumericUpDown nudCantidad, TextBox txtPrecio,
                                 Label lblTotal, Label lblNumeroFactura, Label lblFecha)
            {
                txtCliente.Text = Cliente;
                txtVideojuego.Text = Videojuego;
                nudCantidad.Value = Cantidad;
                txtPrecio.Text = PrecioUnitario.ToString("0.00");
                lblTotal.Text = Total.ToString("C");
                lblNumeroFactura.Text = NumeroFactura;
                lblFecha.Text = Fecha.ToShortDateString();
                
            }
        }
    }
}

