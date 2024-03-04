using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdiarro3Ev.Dtos
{
    /// <summary>
    /// Clase objeto de la parte de la aplicación de la gerencia
    /// 040324 - MDN
    /// </summary>
    internal class GerenciaDto
    {
        //Atributos
        long id;
        private string nombreProducto = "aaaaa";
        private int cantidadProducto = 0;
        private DateTime fechaPedida;
        private DateTime fechaDeseadaEntrega;


        //Getters y Setters
        public long Id { get => id; set => id = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
        public DateTime FechaPedida { get => fechaPedida; set => fechaPedida = value; }
        public DateTime FechaDeseadaEntrega { get => fechaDeseadaEntrega; set => fechaDeseadaEntrega = value; }

        //Constructores
        public GerenciaDto(long id, string nombreProducto, int cantidadProducto, DateTime fechaPedida, DateTime fechaDeseadaEntrega)
        {
            this.id = id;
            this.nombreProducto = nombreProducto;
            this.cantidadProducto = cantidadProducto;
            this.fechaPedida = fechaPedida;
            this.fechaDeseadaEntrega = fechaDeseadaEntrega;
        }

        public GerenciaDto()
        {

        }

        //ToString
        override
        public string ToString()
        {
            string pedido = "Producto: "+this.NombreProducto+"\nCantidad: "+this.CantidadProducto+"\nFecha entrega: "+this.FechaDeseadaEntrega;
            return pedido;
        }
    }
}
