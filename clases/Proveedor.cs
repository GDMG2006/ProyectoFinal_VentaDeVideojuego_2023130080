using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProyectoFinal03.clases
{
    public interface IRegistrable
    {
        string ObtenerResumen();
    }
    public class EntidadBase
    {
        public bool Activo { get; set; } = true;
    }
    public class Proveedor : EntidadBase, IRegistrable
    {
        private string _nombre;
        private string _telefono;
        private string _email;
        private string _direccion;
        private string _tipoProducto;

        //encapsulamiento
        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío.");
                _nombre = value;
            }
        }

        public string Telefono
        {
            get => _telefono;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 8)
                    throw new ArgumentException("El teléfono debe tener al menos 8 dígitos.");
                _telefono = value;
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El correo electrónico no puede estar vacío.");

                if (!value.EndsWith("@gmail.com"))
                    throw new ArgumentException("El correo debe terminar en @gmail.com.");

                var parteLocal = value.Split('@')[0];

                if (string.IsNullOrWhiteSpace(parteLocal) || !parteLocal.Any(char.IsLetter))
                    throw new ArgumentException("El correo debe tener al menos una letra antes de la arroba.");

                _email = value.Trim();
            }
        }


        public string Direccion
        {
            get => _direccion;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La dirección no puede estar vacía.");
                _direccion = value;
            }
        }

        public string TipoProducto
        {
            get => _tipoProducto;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El tipo de producto no puede estar vacío.");
                _tipoProducto = value;
            }
        }
        // Constructor 
        public Proveedor() { }
        public Proveedor(string nombre, string telefono, string email, string direccion, string tipoProducto, bool activo = true)
        {
            Nombre = nombre;
            Telefono = telefono;
            Email = email;
            Direccion = direccion;
            TipoProducto = tipoProducto;
            Activo = activo;
        }
        public string ObtenerResumen()
        {
            return $"{Nombre} - {TipoProducto} - Tel: {Telefono} - Email: {Email} - Activo: {(Activo ? "Sí" : "No")}";
        }
    }
}




