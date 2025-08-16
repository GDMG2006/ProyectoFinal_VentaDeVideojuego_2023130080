using Newtonsoft.Json;
using ProyectoFinal03.GUI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal03.clases
{
    public class GestorNacionalidad
    {
        
            private const string FILEPATH = @"C:\Users\Dell\OneDrive\Desktop\periodo II 2025\programacion 1\ProyectoFinal03\ProyectoFinal03\bin\Debug\Data\Nacionalidad.json";

            public static void Guardar(List<Nacionalidad> listaNacionalidad)
            {
                Directory.CreateDirectory(Path.GetDirectoryName(FILEPATH));
                string jsonText = JsonConvert.SerializeObject(listaNacionalidad, Formatting.Indented);
                File.WriteAllText(FILEPATH, jsonText);
            }

            public static List<Nacionalidad> Cargar()
            {
                if (!File.Exists(FILEPATH)) return new List<Nacionalidad>();

                string jsonText = File.ReadAllText(FILEPATH);
                return JsonConvert.DeserializeObject<List<Nacionalidad>>(jsonText) ?? new List<Nacionalidad>();
            }
    }
}
