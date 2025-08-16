using System;

namespace ProyectoFinal03.clases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        // Constructor explícito
        public Persona(string nombre, string genero, string telefono, string correo)
        {
            Nombre = nombre;
            Genero = genero;
            Telefono = telefono;
            Correo = correo;
        }
    }

    public class Empleado : Persona
    {
     

        public string Puesto { get; set; }
        public decimal Sueldo { get; set; }
        public DateTime FechaContratacion { get; set; }

        public string ObtenerFechaContratacion()
        {
            return FechaContratacion.ToString("dd/MM/yyyy");
        }


        public override string ToString()
        {
            return $"{Nombre} - {Puesto} - Sueldo: ${Sueldo}";
        }

        // Constructor un pco mas explícito ya que llama al constructor base
        public Empleado(string nombre, string genero, string telefono, string correo,
                        string puesto, decimal sueldo, DateTime fechaContratacion)
            : base(nombre, genero, telefono, correo)
        {
            Puesto = puesto;
            Sueldo = sueldo;
            FechaContratacion = fechaContratacion;
        }


    }
}