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
    internal class GestorNombreCliente
    {


        private const string FILEPATH = @"C:\Users\Dell\OneDrive\Desktop\periodo II 2025\programacion 1\ProyectoFinal03\ProyectoFinal03\bin\Debug\Data\NombreCliente.json";

        public static void Guardar(List<NombreCliente> listaNombreCliente)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(FILEPATH));
            string jsonText = JsonConvert.SerializeObject(listaNombreCliente, Formatting.Indented);
            File.WriteAllText(FILEPATH, jsonText);
        }
        public static List<NombreCliente> Cargar()
        {
            if (!File.Exists(FILEPATH)) return new List<NombreCliente>();

            string jsonText = File.ReadAllText(FILEPATH);
            return JsonConvert.DeserializeObject<List<NombreCliente>>(jsonText) ?? new List<NombreCliente>();
        }
    }
    
}

