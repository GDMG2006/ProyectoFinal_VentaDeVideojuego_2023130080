using ProyectoFinal03.clases;
using ProyectoFinal03.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cliente = ProyectoFinal03.clases.Cliente;

namespace ProyectoFinal03
{
    internal static class Program
    {

        public static List<Cliente> clientesLista = new List<Cliente>();
        public static List<Inventario> inventarioLista = new List<Inventario>();
        public static List<Empleado> empleadosLista = new List<Empleado>();
        public static List<Facturacion.Factura> facturaLista = new List<Facturacion.Factura>();
        public static List<IngresoJuegos> listaJuegos = new List<IngresoJuegos>();
        public static List<Nacionalidad>NacionalidadLista=new List<Nacionalidad>();

        [STAThread]
        

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            inventarioLista = GestorDeInventario.Cargar();
            empleadosLista = GestorDeEmpleados.Cargar();
            facturaLista = GestorFacturas.CargarFacturas();
            listaJuegos = GestorDeJuegos.Cargar();
            NacionalidadLista = GestorNacionalidad.Cargar();



            // Cargar datos antes de iniciar
            clientesLista = GestorDeClientes.Cargar();

                Application.Run(new frmMenuPrincipal());
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMenuPrincipal ());
        }
       
    }
}
