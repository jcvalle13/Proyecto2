using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public FrmManUsuarios()
        {
            InitializeComponent();
            lstresultado = new List<Usuarios>();
            CargarCombos();
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

                    Negocio.LNegocio.AgregarUsuario(u);
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

                    Negocio.LNegocio.ModificarUsuario(u);
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
            frmMenu frm = new frmMenu();
            frm.Show();
            this.Hide();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuarios u = new Usuarios();

                u.Usuario = txtUsuario.Text.Trim();

                LNegocio.EliminarUsuario(u);
                MessageBox.Show("Usuario Eliminado");
                limpiar();

                txtUsuario.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
}
