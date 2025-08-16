using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal03.clases;
using System;
using System.Windows.Controls;
using ProyectoFinal03.clases;

namespace ProyectoFinal03.clases
{
    //  1. Abstracción
    public interface IInventariable
    {
        string ObtenerResumen();
    }




    public class Productos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
    }

    //  2. Herencia
    public class Inventario : Productos, IInventariable
    {
        //  3. Encapsulamiento
        private int _cantidadDisponible;
        private string _clasificacion;
        private string _plataforma;
        private string _genero;
        private DateTime _fechaLanzamiento;

        public int CantidadDisponible
        {
            get => _cantidadDisponible;
            set
            {
                if (value < 0)
                    throw new ArgumentException("La cantidad no puede ser negativa.");
                _cantidadDisponible = value;
            }
        }

        public string Clasificacion
        {
            get => _clasificacion;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La clasificación no puede estar vacía.");
                _clasificacion = value;
            }
        }

        public string Plataforma
        {
            get => _plataforma;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La plataforma no puede estar vacía.");
                _plataforma = value;
            }
        }

        public string Genero
        {
            get => _genero;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El género no puede estar vacío.");
                _genero = value;
            }
        }

        public DateTime FechaLanzamiento
        {
            get => _fechaLanzamiento;
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("La fecha de lanzamiento no puede ser futura.");
                _fechaLanzamiento = value;
            }
        }

        // Constructor 
        public Inventario(int Id, string nombre, decimal precio, int cantidad, string clasificacion, string plataforma, string genero, DateTime fechaLanzamiento)
        {
            Id = Id;
            Nombre = !string.IsNullOrWhiteSpace(nombre) ? nombre : throw new ArgumentException("El nombre no puede estar vacío.");
            Precio = precio >= 0 ? precio : throw new ArgumentException("El precio no puede ser negativo.");
            CantidadDisponible = cantidad;
            Clasificacion = clasificacion;
            Plataforma = plataforma;
            Genero = genero;
            FechaLanzamiento = fechaLanzamiento;
        }

        public Inventario() { }

        // 4. Polimorfismo
        public string ObtenerResumen()
        {
            return $" {Nombre} ({Genero}) - {Plataforma} - {Clasificacion} - ${Precio} - Stock: {CantidadDisponible} - Lanzado: {FechaLanzamiento:dd/MM/yyyy}";
        }
    }
}

    

