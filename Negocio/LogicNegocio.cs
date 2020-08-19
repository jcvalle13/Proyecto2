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

                objpeticion.Peticion = @"INSERT INTO Usuarioss VALUES ('" + P_Usuario.Usuario + "','" + P_Usuario.Contraseña + "','" + P_Usuario.Estado + "')";

                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
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
                objpeticion.Peticion = @"SELECT Usuario, Contraseña, Estado FROM Usuarioss";

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


            /*try
            {
                SQLParametros objpeticion = new SQLParametros();
               objpeticion.Peticion = @"SELECT Usuario, Contraseña, Estado FROM Usuarioss";

                Acceso objacceso = new Acceso();
                return objacceso.Consultar_Permisos_Usuarios(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }*/
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


            //SE UTILIZA CON PARAMETROS
            /* SQLParametros objpeticion = new SQLParametros();


             //Ajustar peticion para utilización con parametros
             objpeticion.Peticion = @"EXEC PA_AgregarPerfil @codigoperfil, @descripcion, @estado";

             //Crear los parametros
             SqlParameter parametroCodigo = new SqlParameter();
             parametroCodigo.ParameterName = "@codigoperfil";
             parametroCodigo.SqlDbType = System.Data.SqlDbType.Int;
             parametroCodigo.Value = P_Perfil.cod_perfil;

             SqlParameter parametroDescripcion = new SqlParameter();
             parametroDescripcion.ParameterName = "@descripcion";
             parametroDescripcion.Size = 50;
             parametroDescripcion.SqlDbType = System.Data.SqlDbType.VarChar;
             parametroDescripcion.Value = P_Perfil.descripcion;

             SqlParameter parametroEstado = new SqlParameter();
             parametroEstado.ParameterName = "@estado";
             parametroEstado.SqlDbType = System.Data.SqlDbType.Bit;
             parametroEstado.Value = P_Perfil.estado;

             //Agrega a la lista de parametros los parametros creados
             objpeticion.LstParametros.Add(parametroCodigo);
             objpeticion.LstParametros.Add(parametroDescripcion);
             objpeticion.LstParametros.Add(parametroEstado);

             Acceso objacceso = new Acceso();
             return objacceso.Ejecutar_Peticiones(objpeticion);*/




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




            /* try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"EXEC PA_ModificarPerfil @codigoperfil, @descripcion, @estado";

                //Crear los parametros
                SqlParameter parametroCodigo = new SqlParameter();
                parametroCodigo.ParameterName = "@codigoperfil";
                parametroCodigo.SqlDbType = System.Data.SqlDbType.Int;
                parametroCodigo.Value = P_Perfil.cod_perfil;

                SqlParameter parametroDescripcion = new SqlParameter();
                parametroDescripcion.ParameterName = "@descripcion";
                parametroDescripcion.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroDescripcion.Value = P_Perfil.descripcion;

                SqlParameter parametroEstado = new SqlParameter();
                parametroEstado.ParameterName = "@estado";
                parametroEstado.SqlDbType = System.Data.SqlDbType.Bit;
                parametroEstado.Value = P_Perfil.estado;

                //Agrega a la lista de parametros los parametros creados
                objpeticion.LstParametros.Add(parametroCodigo);
                objpeticion.LstParametros.Add(parametroDescripcion);
                objpeticion.LstParametros.Add(parametroEstado);

                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }*/
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


            /* try
            {
                SQLParametros objpeticion = new SQLParametros();
                objpeticion.Peticion = @"EXEC PA_EliminarPerfil @codigoperfil";

                //Crear los parametros
                SqlParameter parametroCodigo = new SqlParameter();
                parametroCodigo.ParameterName = "@codigoperfil";
                parametroCodigo.SqlDbType = System.Data.SqlDbType.Int;
                parametroCodigo.Value = P_Perfil.cod_perfil;

                //Agrega a la lista de parametros los parametros creados
                objpeticion.LstParametros.Add(parametroCodigo);

                Acceso objacceso = new Acceso();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }*/
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
                objpeticion.Peticion = @"SELECT Nombrecliente,ID , Email, Telefono, Producto, FROM DataClientes";

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
