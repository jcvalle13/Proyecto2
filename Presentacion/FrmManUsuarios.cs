using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Entidades;

namespace Presentacion
{
    public partial class FrmManUsuarios : Form
    {

        #region Propiedades
        public List<Usuarios> lstresultado { get; set; }
        public bool EsError { get; set; }
        #endregion

        private void CargarPerfiles()
        {
            try
            {
                List<Perfiles> lstperfiles = GestorConexiones.GestorConexion_Servicios.ConsultarPerfiles(new Perfiles { cod_perfil = 0 });

                cboPerfiles.DataSource = lstperfiles;
                cboPerfiles.DisplayMember = "descripcion";
                cboPerfiles.ValueMember = "cod_perfil";
                cboPerfiles.Refresh();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public FrmManUsuarios()
        {
            InitializeComponent();
            lstresultado = new List<Usuarios>();
            CargarCombos();
            CargarPerfiles();
        }

        private void limpiar()
        {

            txtUsuario.Text = string.Empty;
            txtcontraseña.Text = string.Empty;
            cboestado.SelectedIndex = 0;
        }



        private void CargarCombos()
        {
            try
            {
                //Creando una tabla
                DataTable dt = new DataTable();

                //Creando las columnas a esa tabla
                dt.Columns.Add("Usuario");
                dt.Columns.Add("Contraseña");

                //Insertando información a esa tabla
                dt.Rows.Add("true", "Activo");
                dt.Rows.Add("false", "Inactivo");

                cboestado.DataSource = dt;
                cboestado.DisplayMember = "Contraseña";
                cboestado.ValueMember = "Usuario";
                cboestado.Refresh();
                cboestado.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool VerificarExistenciaCodigo()
        {
            bool L_resultado = false;

            try
            {
                foreach (Usuarios item in lstresultado)
                {
                    if (item.Usuario == txtUsuario.Text.Trim())
                    {
                        L_resultado = true; // Es igual a encontro el codigo
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return L_resultado;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsError)
                {
                    if (VerificarExistenciaCodigo())
                    {
                        MessageBox.Show("El código digitado ya existe en base de datos, por favor cambiarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Usuarios u = new Usuarios();

                    u.Usuario = txtUsuario.Text.Trim();
                    u.Contraseña = txtcontraseña.Text.Trim();
                    u.Estado = (cboestado.SelectedValue.ToString().Equals("true")) ? true : false;

                    GestorConexiones.GestorConexion_Servicios.AgregarUsuario(u);
                    MessageBox.Show("Usuario agregado");
                    limpiar();

                    txtUsuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsError)
                {
                    Usuarios u = new Usuarios();

                    u.Usuario = txtUsuario.Text.Trim();
                    u.Contraseña = txtcontraseña.Text.Trim();
                    u.Estado = (cboestado.SelectedValue.ToString().Equals("true")) ? true : false;

                    GestorConexiones.GestorConexion_Servicios.ModificarUsuario(u);
                    MessageBox.Show("Usuario modificado");
                    limpiar();

                    txtUsuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            this.Close();

            /*FrmMenu frm = new FrmMenu();
            frm.Show();
            this.Hide();*/
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuarios u = new Usuarios();

                u.Usuario = txtUsuario.Text.Trim();

                GestorConexiones.GestorConexion_Servicios.EliminarUsuario(u);
                MessageBox.Show("Usuario Eliminado");
                limpiar();

                txtUsuario.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnListaUsuario_Click(object sender, EventArgs e)
        {
            try
            {
               
                DataTable dt = new DataTable();

                dt.Columns.Add("NombreUsuario");
                dt.Columns.Add("Contraseña");
                dt.Columns.Add("Estado");

                List<Usuarios> lstusuarios = GestorConexiones.GestorConexion_Servicios.Consultar_Usuarios();

                foreach (Usuarios item in lstusuarios)
                {
                    dt.Rows.Add(item.Usuario, item.Contraseña, item.Estado == true ? "Activo" : "Inactivo");
                }

                gdvUsuarios.DataSource = dt;
                gdvUsuarios.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

