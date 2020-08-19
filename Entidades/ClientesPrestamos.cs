using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClientesPrestamos
    {
        public string Nombre { get; set; }

        public int Identificacion { get; set; }

        public string email { get; set; }

        public int Telefono { get; set; }

        public string Producto { get; set; }

        public ClientesPrestamos()

        {

            Nombre = string.Empty;
            Identificacion = 0;
            email = string.Empty;
            Telefono = 0;
            Producto = string.Empty;

        }
    }
}
