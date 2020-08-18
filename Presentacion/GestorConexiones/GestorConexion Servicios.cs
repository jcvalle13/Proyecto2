using System;
using System.Collections.Generic;
using Entidades;

namespace Presentacion.GestorConexiones
{
    public static class GestorConexion_Servicios
    {
        #region Usuarios
        public static int AgregarUsuario(Usuarios P_Usuario)
        {
            WCFServicio.ServiciosClient objservicio = null;
            try
            {
                objservicio = new WCFServicio.ServiciosClient();
                return objservicio.AgregarUsuario(P_Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (objservicio != null)
                    objservicio.Close();
            
            }
        }

        public static int ModificarUsuario(Usuarios P_Usuario)
        {
            WCFServicio.ServiciosClient objservicio = null;
            try
            {
                objservicio = new WCFServicio.ServiciosClient();
                return objservicio.ModificarUsuario(P_Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (objservicio != null)
                    objservicio.Close();

            }
        }

        public static  List<Usuarios> Consultar_Usuarios()
        {
            WCFServicio.ServiciosClient objservicio = null;
            try
            {
                objservicio = new WCFServicio.ServiciosClient();
                return objservicio.Consultar_Usuarios();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (objservicio != null)
                    objservicio.Close();

            }
        }

        public static bool VerificarUsuario(Usuarios P_usuario)
        {
            WCFServicio.ServiciosClient objservicio = null;
            try
            {
                objservicio = new WCFServicio.ServiciosClient();
                return objservicio.VerificarUsuario(P_usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (objservicio != null)
                    objservicio.Close();

            }
        }

        public static List<Usuarios> Consultar_Permisos_Usuarios(Usuarios P_usuario)
        {
            WCFServicio.ServiciosClient objservicio = null;
            try
            {
                objservicio = new WCFServicio.ServiciosClient();
                return objservicio.Consultar_Permisos_Usuarios(P_usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (objservicio != null)
                    objservicio.Close();

            }
        }

        public static int EliminarUsuario(Usuarios P_usuario)
        {
            WCFServicio.ServiciosClient objservicio = null;
            try
            {
                objservicio = new WCFServicio.ServiciosClient();
                return objservicio.EliminarUsuario(P_usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (objservicio != null)
                    objservicio.Close();

            }
        }
        #endregion


        #region Perfiles
        public static int AgregarPerfil(Perfiles P_Perfil)
        {
            WCFServicio.ServiciosClient objservicio = null;
            try
            {
                objservicio = new WCFServicio.ServiciosClient();
                return objservicio.AgregarPerfil(P_Perfil);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (objservicio != null)
                    objservicio.Close();

            }
        }

        public static int ModificarPerfil(Perfiles P_Perfil)
        {
            WCFServicio.ServiciosClient objservicio = null;
            try
            {
                objservicio = new WCFServicio.ServiciosClient();
                return objservicio.ModificarPerfil(P_Perfil);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (objservicio != null)
                    objservicio.Close();

            }
        }

        public static int EliminarPerfil(Perfiles P_Perfil)
        {
            WCFServicio.ServiciosClient objservicio = null;
            try
            {
                objservicio = new WCFServicio.ServiciosClient();
                return objservicio.EliminarPerfil(P_Perfil);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (objservicio != null)
                    objservicio.Close();

            }
        }

        public static List<Perfiles> ConsultarPerfiles(Perfiles P_Perfil)
        {
            WCFServicio.ServiciosClient objservicio = null;
            try
            {
                objservicio = new WCFServicio.ServiciosClient();
                return objservicio.ConsultarPerfiles(P_Perfil);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (objservicio != null)
                    objservicio.Close();

            }
        }

        #endregion

    }
}


