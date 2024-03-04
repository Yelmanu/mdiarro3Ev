using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdiarro3Ev.Servicios
{
    /// <summary>
    /// Interfaz que se encarga de la funcionalidad de los menús
    /// 040324 - MDN 
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Menú inicial de la aplicación
        /// 040324 - MDN
        /// </summary>
        /// <returns></returns>
        public int menuInicial();

        /// <summary>
        /// Menú para los empleados
        /// 040324 - MDN
        /// </summary>
        /// <returns></returns>
        public int menuEmpleado();

        /// <summary>
        /// Menú para la gerencia
        /// 040324 - MDN
        /// </summary>
        /// <returns></returns>
        public int menuGerencia();
    }
}
