using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdiarro3Ev.Dtos
{
    /// <summary>
    /// Clase objeto de la parte de la aplicación del empleado
    /// 040324 - MDN
    /// </summary>
    internal class EmpleadoDto
    {
        //Atributos
        long id;
        private int precio = 0;
        private DateTime fechaVenta;
        private DateTime fechaPedida = new DateTime(9999,12,31);
        private TimeSpan horasAbierta;


        //Getters y Setters
        public long Id { get => id; set => id = value; }
        public int Precio { get => precio; set => precio = value; }
        public DateTime FechaVenta { get => fechaVenta; set => fechaVenta = value; }
        public DateTime FechaPedida { get => fechaPedida; set => fechaPedida = value; }
        public TimeSpan HorasAbierta { get => horasAbierta; set => horasAbierta = value; }

        //Constructores

        public EmpleadoDto(long id, int precio, DateTime fechaVenta)
        {
            this.id = id;
            this.precio = precio;
            this.fechaVenta = fechaVenta;
        }
        public EmpleadoDto() 
        {
            
        }

    }
}
