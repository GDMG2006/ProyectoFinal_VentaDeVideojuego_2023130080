using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal03.GUI
{

        // Herencia: esta clase podría heredar de una clase base si se desea extender
        public class Nacionalidad : EntidadBase
        {
            
            private string _nombre;
            private string _codigoISO;
            private string _idiomaPrincipal;
            private string _region;
        public Nacionalidad(string nombre, string region, string idiomaPrincipal, string codigoISO)
        {
            Nombre = nombre;
            Region = region;
            IdiomaPrincipal = idiomaPrincipal;
            CodigoISO = codigoISO;
        }


        // Encapsulamiento + Validación


        public string Nombre
            {
                get => _nombre;
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("El nombre no puede estar vacío.");
                    _nombre = value.Trim();
                }
            }

            public string CodigoISO
            {
                get => _codigoISO;
                set
                {
                    if (string.IsNullOrWhiteSpace(value) || value.Length != 2)
                        throw new ArgumentException("El código ISO debe tener 2 letras.");
                    _codigoISO = value.ToUpper();
                }
            }

            public string IdiomaPrincipal
            {
                get => _idiomaPrincipal;
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("El idioma principal no puede estar vacío.");
                    _idiomaPrincipal = value.Trim();
                }
            }

            public string Region
            {
                get => _region;
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("La región no puede estar vacía.");
                    _region = value.Trim();
                }
            }

            // Polimorfismo: método sobrescribible
            public virtual string ObtenerResumen()
            {
                return $"{Nombre} ({CodigoISO}) - Idioma: {IdiomaPrincipal}, Región: {Region}";
            }
        }

        // Clase base para demostrar herencia (opcional)
        public abstract class EntidadBase
        {
            public DateTime FechaCreacion { get; set; } = DateTime.Now;

            public virtual string ObtenerResumen()
            {
                return $"Entidad creada el {FechaCreacion}";
            }
        }
   
}