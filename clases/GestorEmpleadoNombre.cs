using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ProyectoFinal03.clases
{
    public class GestorEmpleadoNombre
    {
        private const string FILEPATH = @"C:\Users\Dell\OneDrive\Desktop\periodo II 2025\programacion 1\ProyectoFinal03\ProyectoFinal03\bin\Debug\Data\NombreEmpleado.json";

        public static void Guardar(List<NombreEmpleado> listaNombreEmpleados)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(FILEPATH));
            string jsonText = JsonConvert.SerializeObject(listaNombreEmpleados, Formatting.Indented);
            File.WriteAllText(FILEPATH, jsonText);
        }
        public static List<NombreEmpleado> Cargar()
        {
            if (!File.Exists(FILEPATH)) return new List<NombreEmpleado>();

            string jsonText = File.ReadAllText(FILEPATH);
            return JsonConvert.DeserializeObject<List<NombreEmpleado>>(jsonText) ?? new List<NombreEmpleado>();
        }


    }
}

    