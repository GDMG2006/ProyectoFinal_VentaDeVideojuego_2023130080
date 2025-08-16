using Newtonsoft.Json;
using ProyectoFinal03.clases;
using System;
using System.Collections.Generic;
using System.IO;

namespace ProyectoFinal03.clases
{
    public static class GestorFacturas
    {
        private const string FILEPATH = @"C:\Users\Dell\OneDrive\Desktop\periodo II 2025\programacion 1\ProyectoFinal03\ProyectoFinal03\bin\Debug\Data\FacturasLista.json";

        public static void GuardarFacturas(List<Facturacion.Factura> listaFacturas)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(FILEPATH));
            string jsonText = JsonConvert.SerializeObject(listaFacturas, Formatting.Indented);
            File.WriteAllText(FILEPATH, jsonText);
        }

        public static List<Facturacion.Factura> CargarFacturas()
        {
            if (!File.Exists(FILEPATH)) return new List<Facturacion.Factura>();

            string jsonText = File.ReadAllText(FILEPATH);
            return JsonConvert.DeserializeObject<List<Facturacion.Factura>>(jsonText) ?? new List<Facturacion.Factura>();
        }
    }
}