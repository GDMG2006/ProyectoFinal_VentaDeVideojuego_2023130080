using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal03.clases
{
    
        public class Juegos : EntidadBase
        {
            private string _nombre;
            private string _genero;
            private decimal _precio;
            private int _stock;
            private ClasificacionJuego _clasificacion;

            public string Nombre
            {
                get => _nombre;
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("El nombre del juego no puede estar vacío.");
                    _nombre = value.Trim();
                }
            }

            public string Genero
            {
                get => _genero;
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("El género no puede estar vacío.");
                    _genero = value.Trim();
                }
            }

            public decimal Precio
            {
                get => _precio;
                set
                {
                    if (value < 0)
                        throw new ArgumentException("El precio no puede ser negativo.");
                    _precio = value;
                }
            }

            public int Stock
            {
                get => _stock;
                set
                {
                    if (value < 0)
                        throw new ArgumentException("El stock no puede ser negativo.");
                    _stock = value;
                }
            }

            public ClasificacionJuego Clasificacion
            {
                get => _clasificacion;
                set
                {
                    if (value == null)
                        throw new ArgumentException("Debe asignarse una clasificación válida.");
                    _clasificacion = value;
                }
            }

            public Juegos(string nombre, string genero, decimal precio, int stock, ClasificacionJuego clasificacion)
            {
                Nombre = nombre;
                Genero = genero;
                Precio = precio;
                Stock = stock;
                Clasificacion = clasificacion;
            }

           
        }
    
}

