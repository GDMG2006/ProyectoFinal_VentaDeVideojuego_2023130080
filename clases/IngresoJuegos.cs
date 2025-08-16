using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal03.clases
{
    public class IngresoJuegos
    {
        
        // Propiedades privadas
            private string _nombre;
            private string _categoria;
            private string _plataforma;
            private decimal _precio;
            private int _stock;
            private DateTime _fechaIngreso;
            private string _codigo;
            private string _descripcion;

            // Constructor sobrecargado
            public IngresoJuegos(string nombre, string categoria, string plataforma, decimal precio, int stock, DateTime fechaIngreso, string codigo, string descripcion)
            {
                Nombre = nombre;
                Categoria = categoria;
                Plataforma = plataforma;
                Precio = precio;
                Stock = stock;
                FechaIngreso = fechaIngreso;
                Codigo = codigo;
                Descripcion = descripcion;
            }

            // Propiedades públicas con validaciones
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

            public string Categoria
            {
                get => _categoria;
                set
                {
               
                }
            }

            public string Plataforma
            {
                get => _plataforma;
                set
                {
                  
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

            public DateTime FechaIngreso
            {
                get => _fechaIngreso;
                set
                {
                    if (value > DateTime.Now)
                        throw new ArgumentException("La fecha de ingreso no puede ser futura.");
                    _fechaIngreso = value;
                }
            }

            public string Codigo
            {
                get => _codigo;
                set
                {
                    
                }
            }

            public string Descripcion
            {
                get => _descripcion;
                set => _descripcion = value ?? "Sin descripción";
            }

            // Polimorfismo: método ToString sobreescrito
           
    }
}

