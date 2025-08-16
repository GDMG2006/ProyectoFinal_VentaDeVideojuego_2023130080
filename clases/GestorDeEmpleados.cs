using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ProyectoFinal03.clases
{
    public static class GestorDeEmpleados
    {
        private const string FILEPATH = @"C:\Users\Dell\OneDrive\Desktop\periodo II 2025\programacion 1\ProyectoFinal03\ProyectoFinal03\bin\Debug\Data\EmpleadosLista.json";

        public static void Guardar(List<Empleado> listaEmpleados)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(FILEPATH));
            string jsonText = JsonConvert.SerializeObject(listaEmpleados, Formatting.Indented);
            File.WriteAllText(FILEPATH, jsonText);
        }

        public static List<Empleado> Cargar()
        {
            if (!File.Exists(FILEPATH)) return new List<Empleado>();

            string jsonText = File.ReadAllText(FILEPATH);
            return JsonConvert.DeserializeObject<List<Empleado>>(jsonText) ?? new List<Empleado>();
        }
    }
}
