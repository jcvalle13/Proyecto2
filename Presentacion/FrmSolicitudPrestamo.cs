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


        private void limpiar()
        {
            txtNombre.Text = string.Empty;
            txt1Apellido.Text = string.Empty;
            txt2apellido.Text = string.Empty;
            txtID.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtOperacion.Text = string.Empty;
            txtFecha.Text = string.Empty;
            txtObservacion.Text = string.Empty;

        }


        public FrmSolicitudPrestamo()
        {

            lstresultado = new List<ListaRegistroPrestamos>();
            InitializeComponent();
        }

        private bool VerificarExistenciaPrestamo()
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
                    if (VerificarExistenciaPrestamo())
                    {
                        MessageBox.Show("Identificación digitado ya existe en base de datos, por favor cambiarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    ListaRegistroPrestamos Id_cliente = new ListaRegistroPrestamos();


                    Id_cliente.Nombre = txtNombre.Text.Trim();
                    Id_cliente.Apellido1 = txt1Apellido.Text.Trim();
                    Id_cliente.Apellido2 = txt1Apellido.Text.Trim();
                    Id_cliente.Identificacion = Convert.ToInt32(txtID.Text.Trim());
                    Id_cliente.Cantidad = Convert.ToInt32(txtCantidad.Text.Trim());
                    Id_cliente.Operacion = Convert.ToInt32(txtOperacion.Text.Trim());
                    Id_cliente.Fechasolicitud = txtFecha.Text.Trim();
                    Id_cliente.Observacion = txtObservacion.Text.Trim();

                    GestorConexiones.GestorConexion_Servicios.AgregarPrestamo(Id_cliente);
                    MessageBox.Show("Nuevo Prestamo agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpiar();
                    txtNombre.Focus(); //coloca el cursor en el control   
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

        #endregion

    }
}
