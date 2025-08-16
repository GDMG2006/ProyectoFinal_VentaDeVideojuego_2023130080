using Newtonsoft.Json;
using ProyectoFinal03.clases;
using System;
using System.Collections.Generic;
using System.IO;

namespace ProyectoFinal03.clases
{
    public static class GestorDeInventario
    {
        private const string FILEPATH = @"C:\Users\Dell\OneDrive\Desktop\periodo II 2025\programacion 1\ProyectoFinal03\ProyectoFinal03\bin\Debug\Data\InventarioLista.json";

        public static void Guardar(List<Inventario> listaInventario)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(FILEPATH));
            string jsonText = JsonConvert.SerializeObject(listaInventario, Formatting.Indented);
            File.WriteAllText(FILEPATH, jsonText);
        }

        public static List<Inventario> Cargar()
        {
            if (!File.Exists(FILEPATH)) return new List<Inventario>();

            string jsonText = File.ReadAllText(FILEPATH);
            return JsonConvert.DeserializeObject<List<Inventario>>(jsonText) ?? new List<Inventario>();
        }

        
    }
}