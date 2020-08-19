using Entidades;
using System;
using System.Collections.Generic;
using Negocio;



namespace Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Servicios" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Servicios.svc o Servicios.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Servicios : IServicios
    {
        public int AgregarPerfil(Perfiles P_Perfil)
        {
            return LogicNegocio.AgregarPerfil(P_Perfil);
        }

        public int AgregarUsuario(Usuarios P_Usuario)
        {
            return LogicNegocio.AgregarUsuario(P_Usuario);
        }

        public List<Perfiles> ConsultarPerfiles(Perfiles P_Perfil)
        {
            return LogicNegocio.ConsultarPerfiles(P_Perfil);
        }

        public List<Usuarios> Consultar_Permisos_Usuarios(Usuarios P_usuario)
        {
            return LogicNegocio.Consultar_Permisos_Usuarios(P_usuario);
        }

        public List<Usuarios> Consultar_Usuarios()
        {
            return LogicNegocio.Consultar_Usuarios();
        }

        public void DoWork()
        {
        }

        public int EliminarPerfil(Perfiles P_Perfil)
        {
            return LogicNegocio.EliminarPerfil(P_Perfil);
        }

        public int EliminarUsuario(Usuarios P_usuario)
        {
            return LogicNegocio.EliminarUsuario(P_usuario); 
        }

        public int ModificarPerfil(Perfiles P_Perfil)
        {
            return LogicNegocio.ModificarPerfil(P_Perfil);
           
        }

        public int ModificarUsuario(Usuarios P_Usuario)
        {
            return LogicNegocio.ModificarUsuario(P_Usuario);
        }

        public bool VerificarUsuario(Usuarios P_usuario)
        {
            return LogicNegocio.VerificarUsuario(P_usuario);
        }

        public List<ClientesPrestamos> Consultar_Clientes_Prestamos()
        {
            return LogicNegocio.Consultar_Clientes_Prestamos();
        }



    }
}
