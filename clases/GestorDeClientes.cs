using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal03.clases
{
    internal class GestorDeClientes
    {
       
            private const string FILEPATH = @"C:\Users\Dell\OneDrive\Desktop\periodo II 2025\programacion 1\ProyectoFinal03\ProyectoFinal03\bin\Debug\Data\ClientesLista.json";

            public static void Guardar(List<Cliente> listaClientes)
            {
                Directory.CreateDirectory(Path.GetDirectoryName(FILEPATH)); // Crea la carpeta si no existe
                string jsonText = JsonConvert.SerializeObject(listaClientes, Formatting.Indented);
                File.WriteAllText(FILEPATH, jsonText);
            }

            public static List<Cliente> Cargar()
            {
                if (!File.Exists(FILEPATH)) return new List<Cliente>();

                string jsonText = File.ReadAllText(FILEPATH);
                return JsonConvert.DeserializeObject<List<Cliente>>(jsonText) ?? new List<Cliente>();
            }

        

        
    }
}
