using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal03.clases
{
   

    public class NombreEmpleado
    {
        
        public string _primerNombre;
        public string _segundoNombre;
        public string _apellidoPaterno;
        public string apellidoMaterno;

        // Constructor
        public NombreEmpleado(string primerNombre, string segundoNombre, string apellidoPaterno, string apellidoMaterno)
        {
            PrimerNombre = primerNombre;
            SegundoNombre = segundoNombre;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
        }

        // validaciones
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
            set => _segundoNombre = value?.Trim() ?? "";
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
            get => apellidoMaterno;
            set => apellidoMaterno = value?.Trim() ?? "";
        }

        
        public virtual string ObtenerNombreCompleto()
        {
            return $"{PrimerNombre} {(string.IsNullOrWhiteSpace(SegundoNombre) ? "" : SegundoNombre + " ")}{ApellidoPaterno} {ApellidoMaterno}".Trim();
        }
    }
}
