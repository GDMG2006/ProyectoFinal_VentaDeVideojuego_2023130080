using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal03.clases
{
    public class NombreCliente
    {

        // Campos privados
        public string _primerNombre;
        public string _segundoNombre;
        public string _apellidoPaterno;
        public string _apellidoMaterno;

        // Constructor
        public NombreCliente(string primerNombre, string segundoNombre, string apellidoPaterno, string apellidoMaterno)
        {
            PrimerNombre = primerNombre;
            SegundoNombre = segundoNombre;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
        }

        // Propiedades con validaciones
        public string PrimerNombre
        {
            get => _primerNombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El primer nombre no puede estar vacío.");
                _primerNombre = value.Trim();
            }
        }

        public string SegundoNombre
        {
            get => _segundoNombre;
            set => _segundoNombre = value?.Trim() ?? ""; // Opcional
        }

        public string ApellidoPaterno
        {
            get => _apellidoPaterno;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El apellido paterno no puede estar vacío.");
                _apellidoPaterno = value.Trim();
            }
        }

        public string ApellidoMaterno
        {
            get => _apellidoMaterno;
            set => _apellidoMaterno = value?.Trim() ?? ""; // Opcional
        }

        // Método sobrescrito para mostrar el nombre completo
        public override string ToString()
        {
            return $"{PrimerNombre} {(!string.IsNullOrWhiteSpace(SegundoNombre) ? SegundoNombre + " " : "")}{ApellidoPaterno} {ApellidoMaterno}".Trim();
        }
    }
    
}

