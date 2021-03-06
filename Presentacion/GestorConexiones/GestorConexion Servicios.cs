﻿using System;
using System.Collections.Generic;
using Entidades;

namespace Presentacion.GestorConexiones
{
    public static class GestorConexion_Servicios
    {
        #region Usuarios

        public static int AgregarUsuarioTransaccion(Usuarios P_Usuarios)
        {
            WCFServicio.ServiciosClient objservicio = null;

            try
            {
                objservicio = new WCFServicio.ServiciosClient();
                return objservicio.AgregarUsuarioTransaccion(P_Usuarios);
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

        public static List<Usuarios> Consultar_Usuarios()
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

        public static void EnviarCorreoElectronico(Email P_Correo)
        {
            WCFServicio.ServiciosClient objservicio = null;

            try
            {
                objservicio = new WCFServicio.ServiciosClient();
                objservicio.EnviarCorreoElectronico(P_Correo);
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

        #region ConsultaPrestamocliente
        public static List<ClientesPrestamos> Consultar_Clientes_Prestamos()
        {
            WCFServicio.ServiciosClient objservicio = null;
            try
            {
                objservicio = new WCFServicio.ServiciosClient();
                return objservicio.Consultar_Clientes_Prestamos();
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
            #endregion
        }

       #region Prestamos

            public static List<ListaRegistroPrestamos> Consultar_Lista_Prestamos()
            {
                WCFServicio.ServiciosClient objservicio = null;
                try
                {
                    objservicio = new WCFServicio.ServiciosClient();
                    return objservicio.Consultar_Lista_Prestamos();
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

            public static int AgregarPrestamo(ListaRegistroPrestamos P_Prestamo)
            {
                WCFServicio.ServiciosClient objservicio = null;
                try
                {
                    objservicio = new WCFServicio.ServiciosClient();
                    return objservicio.AgregarPrestamo(P_Prestamo);
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

