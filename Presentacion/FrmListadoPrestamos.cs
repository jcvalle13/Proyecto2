using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmListadoPrestamos : Form
    {
        public FrmListadoPrestamos()
        {
            InitializeComponent();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            try
            {
                List<ListaRegistroPrestamos> lstresultado = GestorConexiones.GestorConexion_Servicios.Consultar_Lista_Prestamos();

                this.dgvprestamos.DataSource = lstresultado;
                this.dgvprestamos.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
