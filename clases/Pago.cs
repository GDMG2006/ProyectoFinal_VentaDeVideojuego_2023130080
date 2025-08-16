using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal03.clases
{
    public class Pago
    {
        public int IdPago { get; set; }
        public int IdFactura { get; set; }
        public decimal Monto { get; set; }
        public string MetodoPago { get; set; }
        public DateTime FechaPago { get; set; }
        //constructor

        public Pago(int idFactura, decimal monto, string metodoPago)
        {
            if (idFactura <= 0) throw new ArgumentException("Factura inválida.");
            if (monto <= 0) throw new ArgumentException("Monto debe ser mayor a cero.");
            if (string.IsNullOrWhiteSpace(metodoPago)) throw new ArgumentException("Método de pago requerido.");

            IdFactura = idFactura;
            Monto = monto;
            MetodoPago = metodoPago;
            FechaPago = DateTime.Now;
            IdPago = new Random().Next(1000, 9999); 
        }
    }
}
