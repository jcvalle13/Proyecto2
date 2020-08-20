using Entidades;
using System.Collections.Generic;
using System.ServiceModel;



namespace Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicios" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicios
    {
        #region Usuarios
        [OperationContract]
        int AgregarUsuario(Usuarios P_Usuario);

        [OperationContract]
        int AgregarUsuarioTransaccion(Usuarios P_Usuarios);

        [OperationContract]
        int ModificarUsuario(Usuarios P_Usuario);

        [OperationContract]
        List<Usuarios> Consultar_Usuarios();

        [OperationContract]
        bool VerificarUsuario(Usuarios P_usuario);

        [OperationContract]
        List<Usuarios> Consultar_Permisos_Usuarios(Usuarios P_usuario);

        [OperationContract]
        int EliminarUsuario(Usuarios P_usuario);

        #endregion

        #region Perfiles

        [OperationContract]
        int AgregarPerfil(Perfiles P_Perfil);

        [OperationContract]
        int ModificarPerfil(Perfiles P_Perfil);

        [OperationContract]
        int EliminarPerfil(Perfiles P_Perfil);


        [OperationContract]
        List<Perfiles> ConsultarPerfiles(Perfiles P_Perfil);
        #endregion

        #region Consultaclientes
        [OperationContract]
        List<ClientesPrestamos> Consultar_Clientes_Prestamos();
        #endregion

    }
}
