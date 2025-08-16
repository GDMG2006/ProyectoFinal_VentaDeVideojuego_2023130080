using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ProyectoFinal03.clases;

namespace ProyectoFinal03.gestores
{
    public class GestorProveedor
    {
        private readonly string rutaArchivo = @"C:\\Users\\Dell\\OneDrive\\Desktop\\periodo II 2025\\programacion 1\\ProyectoFinal03\\ProyectoFinal03\\bin\\Debug\\Data\Dataproveedores.json";

        public List<Proveedor> CargarProveedores()
        {
            if (!File.Exists(rutaArchivo))
                return new List<Proveedor>();

            string json = File.ReadAllText(rutaArchivo);
            return JsonConvert.DeserializeObject<List<Proveedor>>(json);
        }

        public void GuardarProveedores(List<Proveedor> proveedores)
        {
            string json = JsonConvert.SerializeObject(proveedores, Formatting.Indented);
            File.WriteAllText(rutaArchivo, json);
        }

        public void AgregarProveedor(Proveedor nuevo)
        {
            var lista = CargarProveedores();
            lista.Add(nuevo);
            GuardarProveedores(lista);
        }
    }
}