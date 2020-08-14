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
using Negocio;

namespace Presentacion
{
    public partial class FrmMenu : Form
    {
        public partial class frmMenu : Form
        {

            public string Usuario { get; set; }

            public void CargarOpcionesUsuario()
            {

                Usuarios u = new Usuarios();
                u.Usuario = Usuario;

                List<Usuarios> lstusuarios = LogicNegocio.Consultar_Permisos_Usuarios(u);// se trae la consulta de los permisos

                //botones

                mantenimientosToolStripMenuItem.Visible = false;
                consultasToolStripMenuItem.Visible = false;
                mensajeroToolStripMenuItem.Visible = false;



                foreach (Usuarios item in lstusuarios)
                {
                    switch (item.Perfiles.cod_perfil)
                    {
                        case 1: { mantenimientosToolStripMenuItem.Visible = true; } break;
                        case 2: { consultasToolStripMenuItem.Visible = true; } break;
                        case 3: { mensajeroToolStripMenuItem.Visible = true; } break;
                        case 4: { } break;
                        case 5: { } break;

                    }
                }
            }
            public frmMenu()
            {
                InitializeComponent();
            }

            private void LogoffToolStripMenuItem_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Conexion Finalizada");
                Application.Exit();

            }

            private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
            {
                FrmManPerfiles frm = new FrmManPerfiles();
                //frm.MdiParent = this;
                frm.Show();
                this.Hide();
            }

            private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
            {
                FrmManUsuarios frm = new FrmManUsuarios();
                frm.Show();
                this.Hide();
            }


            private void mensajeroToolStripMenuItem_Click(object sender, EventArgs e)
            {
                FrmMensajero frm = new FrmMensajero();
                frm.Show();
                this.Hide();
            }





            private void listadoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
            {
                FrmConsultaUsuarios frm = new FrmConsultaUsuarios();
                frm.Show();
                this.Hide();
            }

            private void listadoDePaquetesToolStripMenuItem_Click(object sender, EventArgs e)
            {
                FrmConsultaMensajeros frm = new FrmConsultaMensajeros();
                frm.Show();
                this.Hide();
            }

            private void listadoCantidadDePaquetesToolStripMenuItem_Click(object sender, EventArgs e)
            {
                FrmConsultaClientes frm = new FrmConsultaClientes();
                frm.Show();
                this.Hide();
            }

            private void estadoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
            {
                FrmEstadoPedido frm = new FrmEstadoPedido();
                frm.Show();
                this.Hide();
            }

            private void regresarAlInicioToolStripMenuItem_Click(object sender, EventArgs e)
            {
                FrmInicio frm = new FrmInicio();
                frm.Show();
                this.Hide();
            }


        }
    }
}
