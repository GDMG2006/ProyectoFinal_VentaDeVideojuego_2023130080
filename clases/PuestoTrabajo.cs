using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal03.clases
{
    public class PuestoTrabajo
    {
        
        private string _nombre;
        private string _descripcion;
        private decimal _salarioBase;
        private bool _activo;

        // Constructor
        public PuestoTrabajo(string nombre, string descripcion, decimal salarioBase, bool activo = true)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            SalarioBase = salarioBase;
            Activo = activo;
        }

        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre del puesto no puede estar vacío.");
                _nombre = value.Trim();
            }
        }

        
        public string Descripcion
        {
            get => _descripcion;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La descripción no puede estar vacía.");
                _descripcion = value.Trim();
            }
        }

       
        public decimal SalarioBase
        {
            get => _salarioBase;
            set
            {
                if (value < 0)
                    throw new ArgumentException("El salario base no puede ser negativo.");
                _salarioBase = value;
            }
        }

        
        public bool Activo
        {
            get => _activo;
            set => _activo = value;
        }

       
        public virtual string ObtenerResumen()
        {
            return $"Puesto: {Nombre} | Salario: L.{SalarioBase} | Estado: {(Activo ? "Activo" : "Inactivo")}";
        }
    }
        

    
}
