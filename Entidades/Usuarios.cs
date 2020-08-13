using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public bool Estado { get; set; }
        public Perfiles Perfiles { get; set; }//Aqui se agrega la propiedad para conservar la lista de perfiles asociados a un usuario


        public Usuarios()
        {
            Usuario = string.Empty;
            Contraseña = string.Empty;
            Estado = false;

            Perfiles = new Perfiles();



        }



    }
}
