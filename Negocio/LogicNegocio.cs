using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using AccesoDatos;
using Entidades;

namespace Negocio
{
    public class LogicNegocio
    {

        #region Usuarios

        public static int AgregarUsuario(Usuarios P_Usuario)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();

                objpeticion.Peticion = @"INSERT INTO Usuarios VALUES ('" + P_Usuario.Usuario + "','" + P_Usuario.Contraseña + "','" + P_Usuario.Estado + "')";

                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int AgregarUsuarioTransaccion(Usuarios P_Usuarios)
        {
            try
            {
                //Lista que conservara las peticiones a ejecutar de forma másiva
                List<SqlCommand> lstSentencias = new List<SqlCommand>();

                //Aqui se genera cada peticion y se manda agregar a la lista de peticiones

                //AGREGAR USUARIO
                //*****************************************************************************

                //Ajustar peticion para utilización con parametros
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"EXEC PA_InsertarUsuario @usuario, @clave, @estado";

                //Crear los parametros
                SqlParameter parametroUsuario = new SqlParameter();
                parametroUsuario.ParameterName = "@usuario";
                parametroUsuario.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroUsuario.Size = 15;
                parametroUsuario.Value = P_Usuarios.Usuario;

                SqlParameter parametroClave = new SqlParameter();
                parametroClave.ParameterName = "@clave";
                parametroClave.Size = 10;
                parametroClave.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroClave.Value = P_Usuarios.Contraseña;

                SqlParameter parametroEstado = new SqlParameter();
                parametroEstado.ParameterName = "@estado";
                parametroEstado.SqlDbType = System.Data.SqlDbType.Bit;
                parametroEstado.Value = P_Usuarios.Estado;

                //Agrega a la lista de parametros los parametros creados
                objpeticion.LstParametros.Add(parametroUsuario);
                objpeticion.LstParametros.Add(parametroClave);
                objpeticion.LstParametros.Add(parametroEstado);

                //Aqui es donde se llama al método para agregar en la lista creada la peticion
                //que se armo anteriormente.
                Acceso objacceso = new Acceso();
                objacceso.AgregarPeticionEnListado(objpeticion, ref lstSentencias);

                //*****************************************************************************

                //AGREGAR USUARIO POR PERFIL
                //*****************************************************************************

                //Ajustar peticion para utilización con parametros
                objpeticion = new SQLParametros();
                objpeticion.Peticion = @"EXEC PA_InsertarUsuarioxPerfil @usuario, @perfil";

                //Crear los parametros
                parametroUsuario = new SqlParameter();
                parametroUsuario.ParameterName = "@usuario";
                parametroUsuario.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroUsuario.Size = 15;
                parametroUsuario.Value = P_Usuarios.Usuario;

                SqlParameter parametroPerfil = new SqlParameter();
                parametroPerfil.ParameterName = "@perfil";
                parametroPerfil.SqlDbType = System.Data.SqlDbType.Int;
                parametroPerfil.Value = P_Usuarios.Perfiles.cod_perfil;

                //Agrega a la lista de parametros los parametros creados
                objpeticion.LstParametros.Add(parametroUsuario);
                objpeticion.LstParametros.Add(parametroPerfil);

                //Aqui es donde se llama al método para agregar en la lista creada la peticion
                //que se armo anteriormente.
                objacceso = new Acceso();
                objacceso.AgregarPeticionEnListado(objpeticion, ref lstSentencias);

                //*****************************************************************************

                //Ejecucion de la trasaccion
                return objacceso.EjecutarTransaccion(lstSentencias);

            }
            catch (Exception)
            {

                throw;
            }
        }



        public static int ModificarUsuario(Usuarios P_Usuario)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"UPDATE Usuarios SET Contraseña = '" + P_Usuario.Contraseña + "', Estado = '" + P_Usuario.Estado + "' WHERE Usuario = '" + P_Usuario.Usuario + "'";

                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Usuarios> Consultar_Usuarios()
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"SELECT Usuario, Contraseña, Estado FROM Usuarios";

                Acceso objacceso = new Acceso();
                return objacceso.Consultar_Usuarios(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool VerificarUsuario(Usuarios P_usuario)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"SELECT Usuario, Contraseña, Estado FROM Usuarios ";
                objpeticion.Peticion += @"WHERE Usuario = '" + P_usuario.Usuario + "' AND ";
                objpeticion.Peticion += @"Contraseña = '" + P_usuario.Contraseña + "' AND ";
                objpeticion.Peticion += @"Estado = '" + P_usuario.Estado + "'";

                Acceso objacceso = new Acceso();
                List<Usuarios> lstresultados = objacceso.Consultar_Usuarios(objpeticion);

                if (lstresultados.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Usuarios> Consultar_Permisos_Usuarios(Usuarios P_usuario)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"EXEC PA_ObtenerPerfilesPorUsuario '" + P_usuario.Usuario + "'";

                Acceso objacceso = new Acceso();
                return objacceso.Consultar_Permisos_Usuarios(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int EliminarUsuario(Usuarios P_usuario)
        {

            try
            {
                SQLParametros objpeticion = new SQLParametros();

                objpeticion.Peticion = @"DELETE FROM Usuarios WHERE Usuario = '" + P_usuario.Usuario + "'";

                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Perfiles
        public static int AgregarPerfil(Perfiles P_Perfil)
        {


            try
            {
                SQLParametros objpeticion = new SQLParametros();

                objpeticion.Peticion = @"INSERT INTO Perfiles VALUES ('" + P_Perfil.cod_perfil + "','" + P_Perfil.descripcion + "','" + P_Perfil.estado + "')";

                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public static int ModificarPerfil(Perfiles P_Perfil)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"UPDATE Perfiles SET descripcion = '" + P_Perfil.cod_perfil + "', estado = '" + P_Perfil.estado + "' WHERE codigoperfil = '" + P_Perfil.cod_perfil + "'";

                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static int EliminarPerfil(Perfiles P_Perfil)
        {

            try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"DELETE FROM Perfiles WHERE codigoperfil = '" + P_Perfil.cod_perfil + "'";

                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static List<Perfiles> ConsultarPerfiles(Perfiles P_Perfil)
        {
            try
            {
                try
                {
                    SQLParametros objpeticion = new SQLParametros();
                    objpeticion.Peticion = @"EXEC PA_ConsultarPerfiles @codigoperfil";

                    //Crear los parametros
                    SqlParameter parametroCodigo = new SqlParameter();
                    parametroCodigo.ParameterName = "@codigoperfil";
                    parametroCodigo.SqlDbType = System.Data.SqlDbType.Int;
                    parametroCodigo.Value = P_Perfil.cod_perfil;

                    //Agrega a la lista de parametros los parametros creados
                    objpeticion.LstParametros.Add(parametroCodigo);

                    Acceso objacceso = new Acceso();
                    return objacceso.Consultar_Perfiles(objpeticion);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Clientes

        public static List<ClientesPrestamos> Consultar_Clientes_Prestamos()
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"SELECT Nombrecliente, ID, Email, Telefono, Producto FROM DataClientes";

                Acceso objacceso = new Acceso();

                return objacceso.Consultar_Clientes_Prestamos(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        #endregion

    }
}
