using mdiarro3Ev.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdiarro3Ev.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void añadirVenta(List<EmpleadoDto> listaVentas)
        {
            EmpleadoDto venta = new EmpleadoDto();

            Console.WriteLine("Introduzca el importe de la venta: ");
            venta.Precio = Convert.ToInt32(Console.ReadLine());
            venta.FechaVenta = DateTime.Now;
            venta.Id = calcularNuevoIdVentas(listaVentas);
            Console.WriteLine("Id: "+venta.Id +" Fecha venta: "+ venta.FechaVenta+" Precio: "+ venta.Precio+" euros");
            listaVentas.Add(venta);

        }

        public void calculoTotalVentasDiario(List<EmpleadoDto> listaVentas)
        {
            Console.WriteLine("Introduzca la fecha de la que quiere calcular las ventas");
            string fechaPedida = Console.ReadLine();
            DateTime fecha = Convert.ToDateTime(fechaPedida);
            foreach(EmpleadoDto ventas in listaVentas)
            {
                if (ventas.FechaVenta == fecha)
                {
                    
                }

            }
        }

        public void crearPedidoParaProveedores(List<GerenciaDto> listaPedidos)
        {
            GerenciaDto pedido = new GerenciaDto();

                Console.WriteLine("Introduzca el nombre del producto: ");
                pedido.NombreProducto = Console.ReadLine();
                Console.WriteLine("Introduzca la cantidad deseada del producto: ");
                pedido.CantidadProducto = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduzca la fecha de entrega deseada (dd-MM-yyyy)");
                string fechaString = Console.ReadLine();
                pedido.FechaDeseadaEntrega = Convert.ToDateTime(fechaString);
                pedido.Id = calcularNuevoIdPedidos(listaPedidos);
                listaPedidos.Add(pedido);
              
        }

        
        private long calcularNuevoIdVentas(List<EmpleadoDto> listaVentas)
        {
            long idCalculado;
            int tamanioLista = listaVentas.Count;
            if (tamanioLista == 0)
            {
                idCalculado = 1;
            }
            else
            {
                idCalculado = listaVentas[tamanioLista - 1].Id + 1;
            }

            return idCalculado;
        }
        private long calcularNuevoIdPedidos(List<GerenciaDto> listaPedidos)
        {
            long idCalculado;
            int tamanioLista = listaPedidos.Count;
            if (tamanioLista == 0)
            {
                idCalculado = 1;
            }
            else
            {
                idCalculado = listaPedidos[tamanioLista - 1].Id + 1;
            }

            return idCalculado;
        }

    }
}
