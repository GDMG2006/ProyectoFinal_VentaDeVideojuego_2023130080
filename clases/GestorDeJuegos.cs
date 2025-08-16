using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal03.clases
{
    public class GestorDeJuegos
    {
      private const string FILEPATH = @"C:\Users\Dell\OneDrive\Desktop\periodo II 2025\programacion 1\ProyectoFinal03\ProyectoFinal03\bin\Debug\Data\Juegos.json";

            public static void Guardar(List<IngresoJuegos> listaJuegos)
            {
                Directory.CreateDirectory(Path.GetDirectoryName(FILEPATH));
                string jsonText = JsonConvert.SerializeObject(listaJuegos, Formatting.Indented);
                File.WriteAllText(FILEPATH, jsonText);
            }

        public static List<IngresoJuegos> Cargar()
        {
            if (!File.Exists(FILEPATH)) return new List<IngresoJuegos>();

            string jsonText = File.ReadAllText(FILEPATH);
            return JsonConvert.DeserializeObject<List<IngresoJuegos>>(jsonText) ?? new List<IngresoJuegos>();
        }

    }
}

