using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidades;

namespace Presentacion
{
    public partial class FrmConsultaClientes : Form
    {
        public FrmConsultaClientes()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            try
            {
                List<ClientesPrestamos> lstresultado = GestorConexiones.GestorConexion_Servicios.Consultar_Clientes_Prestamos();

                this.dgvclientes.DataSource = lstresultado;
                this.dgvclientes.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            frm.Show();
            this.Hide();
        }
    }
}
