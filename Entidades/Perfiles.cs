using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perfiles
    {

        public int cod_perfil { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }



        public Perfiles()
        {
            this.cod_perfil = 0;
            this.descripcion = string.Empty;
            this.estado = false;


        }
    }
}
