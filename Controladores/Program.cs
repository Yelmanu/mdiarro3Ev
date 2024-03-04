using mdiarro3Ev.Dtos;
using mdiarro3Ev.Servicios;

namespace mdiarro3Ev.Controladores
{
    class Program
    {
        /// <summary>
        /// Clase principal de la aplicación
        /// 040324 - MDN
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Instanciamos las clases donde se encuentran los métodos
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();

            //Hacemos una lista donde guardar los datos
            List<EmpleadoDto> listaVentas = new List<EmpleadoDto>();
            List<GerenciaDto> listaPedidos = new List<GerenciaDto>();   

            //Declaramos las variables de control del bucle
            int opcionIntroducida;
             bool cerrarMenu = false;
            do
            {
                opcionIntroducida = mi.menuInicial();
                switch (opcionIntroducida)
                {
                    case 0:
                        cerrarMenu = true;
                        break;
                    case 1:
                        int opcionNueva = mi.menuEmpleado();
                        switch (opcionNueva)
                        {
                            case 0:
                                Console.WriteLine("VOLVERAS AL MENU INICIAL");
                                break;
                            case 1:
                                oi.calculoTotalVentasDiario(listaVentas);
                                break; 
                            case 2:
                                oi.añadirVenta(listaVentas);
                                break;
                            default:
                                Console.WriteLine("*ERROR* La opción introducida no es válida");
                                break;
                        }
                        break;
                    case 2:
                        int opcionNueva2 = mi.menuGerencia();
                        switch (opcionNueva2)
                        {
                            case 0:
                                Console.WriteLine("VOLVERAS AL MENU INICIAL");
                                break;
                            case 1:
                                break;
                            case 2:
                                oi.crearPedidoParaProveedores(listaPedidos);
                                foreach (GerenciaDto pedidos in listaPedidos)
                                {
                                    Console.WriteLine(pedidos.ToString());
                                }
                                break;
                            default:
                                Console.WriteLine("*ERROR* La opción introducida no es válida");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("*ERROR* La opción introducida no es válida");
                        break;
                }
            }while(!cerrarMenu);
        }
    }
}