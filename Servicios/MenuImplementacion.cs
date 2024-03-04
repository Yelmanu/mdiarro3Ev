using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdiarro3Ev.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuInicial()
        {
            int opcionIntroducida;

            Console.WriteLine("Introduzca una opción: ");
            Console.WriteLine("0.- Salir: ");
            Console.WriteLine("1.- Menú Empleado: ");
            Console.WriteLine("2.- Menú Gerencia: ");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            return opcionIntroducida;
        }
        public int menuEmpleado()
        {
            int opcionIntroducida;

            Console.WriteLine("Introduzca una opción: ");
            Console.WriteLine("0.- Salir: ");
            Console.WriteLine("1.- Cálculo total de ventas diario: ");
            Console.WriteLine("2.- Añadir venta: ");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            return opcionIntroducida;
        }

        public int menuGerencia()
        {
            int opcionIntroducida;

            Console.WriteLine("Introduzca una opción: ");
            Console.WriteLine("0.- Salir: ");
            Console.WriteLine("1.- Mostrar ventas del dia: ");
            Console.WriteLine("2.- Crear pedido para proveedores: ");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            return opcionIntroducida;
        }

    }
}
