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
    internal class GestorClasificacionJuego
    {
        private const string FILEPATH = @"C:\Users\Dell\OneDrive\Desktop\periodo II 2025\programacion 1\ProyectoFinal03\ProyectoFinal03\bin\Debug\Data\ClasificacionJuego.json";

        public static void Guardar(List<ClasificacionJuego> listaClasificacionJuego)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(FILEPATH));
            string jsonText = JsonConvert.SerializeObject(listaClasificacionJuego, Formatting.Indented);
            File.WriteAllText(FILEPATH, jsonText);
        }
        public static List<ClasificacionJuego> Cargar()
        {
            if (!File.Exists(FILEPATH)) return new List<ClasificacionJuego>();

            string jsonText = File.ReadAllText(FILEPATH);
            return JsonConvert.DeserializeObject<List<ClasificacionJuego>>(jsonText) ?? new List<ClasificacionJuego>();
        }
    }
}
