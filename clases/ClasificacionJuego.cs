using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal03.clases
{
 
        public class ClasificacionJuego : EntidadBase
        {
            private string _nombre;
            private string _descripcion;
            private int _edadMinima;
            private string _sistemaClasificacion;

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

            public int EdadMinima
            {
                get => _edadMinima;
                set
                {
                    if (value < 0 || value > 21)
                        throw new ArgumentException("La edad mínima debe estar entre 0 y 21.");
                    _edadMinima = value;
                }
            }

            public string SistemaClasificacion
            {
                get => _sistemaClasificacion;
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("El sistema de clasificación no puede estar vacío.");
                    _sistemaClasificacion = value.Trim();
                }
            }

            public ClasificacionJuego(string nombre, string descripcion, int edadMinima, string sistemaClasificacion)
            {
                Nombre = nombre;
                Descripcion = descripcion;
                EdadMinima = edadMinima;
                SistemaClasificacion = sistemaClasificacion;
            }

          
        }
}
