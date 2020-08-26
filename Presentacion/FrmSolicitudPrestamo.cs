using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmSolicitudPrestamo : Form
    {
        #region Propiedades

        public List<ListaRegistroPrestamos> lstresultado { get; set; }

        public bool EsError { get; set; }
        #endregion 

        public FrmSolicitudPrestamo()
        {
            InitializeComponent();
        }

        private bool VerificarExistenciaCodigo()
        {
            bool L_resultado = false;

            try
            {
                foreach (ListaRegistroPrestamos item in lstresultado)
                {
                    if (item.Identificacion == Convert.ToInt32(txtID.Text.Trim()))
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


     

        #region Eventos
        private void btnAgregarPresta_Click(object sender, EventArgs e)
        {
            try
            {

                if (!EsError)

                {
                    if (VerificarExistenciaCodigo())
                    {
                        MessageBox.Show("Identificación digitado ya existe en base de datos, por favor cambiarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    ListaRegistroPrestamos Id_cliente = new ListaRegistroPrestamos();

                    Id_cliente.Identificacion = Convert.ToInt32(txtID.Text.Trim());
                    Id_cliente.descripcion = txtDescripcion.Text.Trim();
                    Id_cliente.estado = (cboPerfiles.SelectedValue.ToString().Equals("true")) ? true : false;

                    GestorConexiones.GestorConexion_Servicios.AgregarPerfil(ListaRegistroPrestamos);
                    MessageBox.Show("Perfil Nuevo agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpiar();
                    //CargarLista();
                    txtcodigoperfil.Focus(); //coloca el cursor en el control   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Eventos

    }
}
