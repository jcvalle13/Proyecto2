using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ListaRegistroPrestamos
    {
        public string Nombre { get; set; }

        public string Apellido1 { get; set; }

        public string Apellido2 { get; set; }

        public int Identificacion { get; set; }

        public int Cantidad { get; set; }

        public int Operacion { get; set; }

        public string Fechasolicitud { get; set; }

        public string Observacion { get; set; }

        public ListaRegistroPrestamos()

        {

            Nombre = string.Empty;
            Apellido1 = string.Empty;
            Apellido2 = string.Empty;
            Identificacion = 0;
            Cantidad = 0;
            Operacion = 0;
            Fechasolicitud = string.Empty;
            Observacion = string.Empty;
        }
    }
}
