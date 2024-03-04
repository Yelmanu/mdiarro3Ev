using mdiarro3Ev.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdiarro3Ev.Servicios
{
    /// <summary>
    /// Interfaz que se encarga de la operativa de la aplicación
    /// 040324 - MDN
    /// </summary>
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Método para añadir una venta
        /// 040324 - MDN
        /// </summary>
        /// <param name="listaVentas"></param>
        public void añadirVenta(List<EmpleadoDto> listaVentas);

        /// <summary>
        /// Método para hacer el calculo de ventas realizadas en un dia
        /// 040324 - MDN
        /// </summary>
        /// <param name="listaVentas"></param>
        public void calculoTotalVentasDiario(List<EmpleadoDto> listaVentas);

        /// <summary>
        /// Método para crear un pedido para los proveedores
        /// 040324 - MDN
        /// </summary>
        /// <param name="listaVentas"></param>
        public void crearPedidoParaProveedores(List<GerenciaDto> listaVentas);
    }
}
