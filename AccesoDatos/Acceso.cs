using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entidades;
using System.Data;

namespace AccesoDatos
{
    public class Acceso
    {
        #region Atributos
        //Configuracion string de conexion BD Joiner Prestamos
        private string strconexion = Properties.Settings.Default.Prestamos;

        //AGREGAR string conexion Steph


        private SqlConnection objconexion;
        #endregion

        #region Constructor

        public Acceso()
        {
            try
            {
                //Inicializa la conexion con la cadena 
                objconexion = new SqlConnection(strconexion);
                this.ABRIRCONEXION();  //se abre conexión
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRARCONEXION(); //Cierre de conexión
            }
        }
        #endregion

        #region Metodos privados

        private void ABRIRCONEXION()
        {
            if (objconexion.State == System.Data.ConnectionState.Closed)
                objconexion.Open();
        }

        private void CERRARCONEXION()
        {
            if (objconexion.State == System.Data.ConnectionState.Open)
                objconexion.Close();
        }

        #endregion

        #region Métodos públicos

        public int Ejecutar_Peticiones(SQLParametros P_Peticion)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = P_Peticion.Peticion;

                this.ABRIRCONEXION();

                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRARCONEXION();
            }
        }

       public List<Usuarios> Consultar_Usuarios(SQLParametros P_Peticion)
        {

            List<Usuarios> lstresultados = new List<Usuarios>();

            try
            {

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = P_Peticion.Peticion;


                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);


                DataTable dt = new DataTable();
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {

                    foreach (DataRow fila in dt.Rows)
                    {
                        Usuarios u = new Usuarios();


                        u.Usuario = fila.ItemArray[0].ToString();
                        u.Contraseña = fila.ItemArray[1].ToString();
                        u.Estado = Convert.ToBoolean(fila.ItemArray[2].ToString());

                        lstresultados.Add(u);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRARCONEXION();
            }

            return lstresultados;
        }

       public List<Usuarios> Consultar_Permisos_Usuarios(SQLParametros P_Peticion)
        {
            //Variable temporal que conservara respuesta de BD
            List<Usuarios> lstresultados = new List<Usuarios>();

            try
            {
                //Este objeto se encarga de las configuraciones necesarias para conectarse a BD
                //Ademas de contener un metodo para la ejecucion de esa petición contra la BD
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = objconexion; //Identifica la conexion a la BD
                cmd.CommandType = System.Data.CommandType.Text; //Se especifica el tipo de formato de sentencia a ejecutar
                cmd.CommandText = P_Peticion.Peticion; //Aqui se asigna la peticion construida

                if (P_Peticion.LstParametros.Count > 0)  //Validar si tiene parametros, y agregarlos
                    cmd.Parameters.AddRange(P_Peticion.LstParametros.ToArray());

                //Objeto que es el que se encarga de ejecutar la consulta y recibir el resultado
                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);

                //Variable temporal para captura respuesta
                DataTable dt = new DataTable();
                objconsulta.Fill(dt); //Aqui se envia la peticion a ejecutar en BD y recibe la respuesta,
                                      //esta respuesta se carga en el DT

                if (dt.Rows.Count > 0) //Verifica si la consulta devolvio registros
                {
                    //Es un ciclo que toma uno a uno los elementos de la coleccion que se este recorriendo
                    foreach (DataRow fila in dt.Rows)
                    {
                        Usuarios u = new Usuarios();

                        //Aqui se obtiene los valores de celda o columna por fila leida
                        u.Perfiles = new Perfiles
                        {
                            cod_perfil = Convert.ToInt32(fila.ItemArray[0].ToString()),
                            descripcion = fila.ItemArray[1].ToString()
                        };

                        lstresultados.Add(u);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRARCONEXION();
            }

            return lstresultados;
        }

       public List<Perfiles> Consultar_Perfiles(SQLParametros P_Peticion)
        {
            List<Perfiles> lstresultados = new List<Perfiles>();

            try
            {

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = objconexion; //Identifica la conexion a la BD
                cmd.CommandType = System.Data.CommandType.Text; //Se especifica el tipo de formato de sentencia a ejecutar
                cmd.CommandText = P_Peticion.Peticion; //Aqui se asigna la peticion construida

                if (P_Peticion.LstParametros.Count > 0)  //Validar si tiene parametros, y agregarlos
                    cmd.Parameters.AddRange(P_Peticion.LstParametros.ToArray());


                SqlDataAdapter objconsultaperfil = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                objconsultaperfil.Fill(dt);

                if (dt.Rows.Count > 0) //Verifica si la consulta devolvio registros
                {
                    foreach (DataRow fila in dt.Rows)
                    {
                        Perfiles p = new Perfiles();

                        //Aqui se obtiene los valores de celda o columna por fila leida
                        p.cod_perfil = Convert.ToInt32(fila.ItemArray[0].ToString());
                        p.descripcion = fila.ItemArray[1].ToString();
                        p.estado = Convert.ToBoolean(fila.ItemArray[2].ToString());

                        lstresultados.Add(p);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRARCONEXION();
            }

            return lstresultados;
        }
        #endregion

        public List<ClientesPrestamos> Consultar_Clientes_Prestamos(SQLParametros P_Peticion)
        {
            List<ClientesPrestamos> lstresultados = new List<ClientesPrestamos>();

            try
            {

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = objconexion; //Identifica la conexion a la BD
                cmd.CommandType = System.Data.CommandType.Text; //Se especifica el tipo de formato de sentencia a ejecutar
                cmd.CommandText = P_Peticion.Peticion; //Aqui se asigna la peticion construida

                if (P_Peticion.LstParametros.Count > 0)  //Validar si tiene parametros, y agregarlos
                    cmd.Parameters.AddRange(P_Peticion.LstParametros.ToArray());


                SqlDataAdapter objconsultacliente = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                objconsultacliente.Fill(dt);

                if (dt.Rows.Count > 0) //Verifica si la consulta devolvio registros
                {
                    foreach (DataRow fila in dt.Rows)
                    {
                        ClientesPrestamos p = new ClientesPrestamos();

                        //Aqui se obtiene los valores de celda o columna por fila leida
                        
                        p.Nombre = fila.ItemArray[0].ToString();
                        p.Identificacion = Convert.ToInt32(fila.ItemArray[1].ToString());
                        p.email = fila.ItemArray[2].ToString();
                        p.Telefono = Convert.ToInt32(fila.ItemArray[3].ToString());
                        p.Producto = fila.ItemArray[4].ToString();
                        
                        
                        lstresultados.Add(p);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRARCONEXION();
            }

            return lstresultados;
        }


        public List<ListaRegistroPrestamos> Consultar_Lista_Prestamos(SQLParametros P_Peticion)
        {
            List<ListaRegistroPrestamos> lstresultados = new List<ListaRegistroPrestamos>();

            try
            {

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = objconexion; //Identifica la conexion a la BD
                cmd.CommandType = System.Data.CommandType.Text; //Se especifica el tipo de formato de sentencia a ejecutar
                cmd.CommandText = P_Peticion.Peticion; //Aqui se asigna la peticion construida

                if (P_Peticion.LstParametros.Count > 0)  //Validar si tiene parametros, y agregarlos
                    cmd.Parameters.AddRange(P_Peticion.LstParametros.ToArray());


                SqlDataAdapter objconsultacliente = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                objconsultacliente.Fill(dt);

                if (dt.Rows.Count > 0) //Verifica si la consulta devolvio registros
                {
                    foreach (DataRow fila in dt.Rows)
                    {
                        ListaRegistroPrestamos p = new ListaRegistroPrestamos();

                        //Aqui se obtiene los valores de celda o columna por fila leida
                  

                        p.Nombre = fila.ItemArray[0].ToString();
                        p.Apellido1= fila.ItemArray[1].ToString();
                        p.Apellido2 = fila.ItemArray[2].ToString();
                        p.Identificacion = Convert.ToInt32(fila.ItemArray[3].ToString());
                        p.Cantidad = Convert.ToInt32(fila.ItemArray[4].ToString());
                        p.Operacion = Convert.ToInt32(fila.ItemArray[5].ToString());
                        p.Fechasolicitud = fila.ItemArray[6].ToString();



                        lstresultados.Add(p);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRARCONEXION();
            }

            return lstresultados;
        }



        #region Para transaccion
        public void AgregarPeticionEnListado(SQLParametros P_Peticion, ref List<SqlCommand> P_Lista)
        {
            /// Método que se encarga de agregar a la lista de peticiones por ejecutar la nueva petición 
            /// recibida


            //utilizo parametro por valor
            //Este objeto se encarga de las configuraciones necesarias para conectarse a BD
            //Ademas de contener un metodo para la ejecucion de esa petición contra la BD
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = objconexion; //Identifica la conexion a la BD
            cmd.CommandType = System.Data.CommandType.Text; //Se especifica el tipo de formato de sentencia a ejecutar
            cmd.CommandText = P_Peticion.Peticion; //Aqui se asigna la peticion construida

            if (P_Peticion.LstParametros.Count > 0)  //Validar si tiene parametros, y agregarlos
                cmd.Parameters.AddRange(P_Peticion.LstParametros.ToArray());

            P_Lista.Add(cmd); //Aqui se agrega nuevo item a la lista de comandos por ejecutar en la transaccion
        }


        public int EjecutarTransaccion(List<SqlCommand> P_Lista)
        {
            /// Método que se encarga de la ejecución de las peticiones una a una, es decir, realiza 
            /// la ejecución de la trasaccion


            SqlTransaction objtransaccion;
            ABRIRCONEXION();
            objtransaccion = objconexion.BeginTransaction();

            try
            {
                //Recorre la lista de peticiones y ejecuta en memoria la peticion uno a uno
                //En este momento todo esta en una simulación
                foreach (SqlCommand cmd in P_Lista)
                {
                    cmd.Transaction = objtransaccion;
                    cmd.Connection = objconexion;
                    cmd.ExecuteNonQuery(); //Aqui es donde verifica si es correcta la ejecucion de la peticion
                }
                objtransaccion.Commit(); //Este realiza los cambios de forma permanente en BD
                return 1;
            }
            catch (Exception ex)
            {
                objtransaccion.Rollback(); //En caso de error elimina cualquier cambio efectuado
                throw ex;
            }
            finally
            {
                objtransaccion.Dispose();
                CERRARCONEXION();
            }

        }

        #endregion
    }
}
