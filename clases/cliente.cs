using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoFinal03.clases
{
    public class Cliente
    {
        
        
        private string _nombre;
        private string _genero;
        private string _telefono;
        private string _correo;
        private string _nacionalidad;
        

        // n validación
        public string Nombre
        {
            get => _nombre;
             set => _nombre = ValidarNombre(value);
        }

        public string Genero
        {
            get => _genero;
            set => _genero = ValidarGenero(value);
        }

        public string Telefono
        {
            get => _telefono;
             set => _telefono = ValidarTelefono(value);
        }

        public string Correo
        {
            get => _correo;
            set => _correo = ValidarCorreo(value);
        }

        public string Nacionalidad
        {
            get => _nacionalidad;
            set => _nacionalidad = string.IsNullOrWhiteSpace(value) ? "Desconocida" : value;
        }

        public DateTime FechaRegistro { get; set; }
        public bool Habitual { get; set; }
        public int Id { get;  set; }
        private static int _contadorId = 1;
        public Cliente(string nombre, string genero, string telefono, string correo, string nacionalidad, bool esHabitual = false)
    : this(_contadorId++, nombre, genero, telefono, correo, nacionalidad, esHabitual)
        { }
        // El Constructor 
        public Cliente(int id, string nombre, string genero, string telefono, string correo, string nacionalidad, bool esHabitual = false)
        {
            Id = id;
            Nombre = nombre;
            Genero = genero;
            Telefono = telefono;
            Correo = correo;
            Nacionalidad = nacionalidad;
            Habitual = esHabitual;
            FechaRegistro = DateTime.Now;
        }
        public Cliente() { }
        // validación
        private string ValidarNombre(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El nombre no puede estar vacío.");
            return value;
        }

        private string ValidarGenero(string value)
        {
            var opcionesValidas = new[] { "Masculino", "Femenino", "Otro" };
            if (!opcionesValidas.Contains(value))
                throw new ArgumentException("Género inválido. Usa Masculino, Femenino u Otro.");
            return value;
        }

        private string ValidarTelefono(string value)
       {
    value = value.Trim(); 
    if (value.Length != 8 || !value.All(char.IsDigit))
        throw new ArgumentException("Teléfono inválido. Debe tener exactamente 8 dígitos numéricos.");
    return value;
}

        private string ValidarCorreo(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || !value.Contains("@") || !value.Contains("."))
                throw new ArgumentException("Correo electrónico inválido.");
            return value;
        }

        
        public override string ToString()
        {
            return $"{Nombre} ({Genero}) - {Correo} - Tel: {Telefono} - Nacionalidad: {Nacionalidad} - Registrado el: {FechaRegistro:dd/MM/yyyy} - Habitual: {(Habitual ? "Sí" : "No")}";
        }

        
    }
}