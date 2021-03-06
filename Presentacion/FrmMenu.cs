﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidades;

namespace Presentacion
{
    public partial class FrmMenu : Form
    {

        public string Usuario { get; set; }

        public void CargarOpcionesUsuario()
        {

            Usuarios u = new Usuarios();
            u.Usuario = Usuario;

            List<Usuarios> lstusuarios = GestorConexiones.GestorConexion_Servicios.Consultar_Permisos_Usuarios(u);// se trae la consulta de los permisos

            //botones

            mantenimientosToolStripMenuItem.Visible = false;
            consultasToolStripMenuItem.Visible = false;
            registroToolStripMenuItem.Visible = false;
            foreach (Usuarios item in lstusuarios)
            {
                switch (item.Perfiles.cod_perfil)
                {
                    case 1: { mantenimientosToolStripMenuItem.Visible = true; } break;
                    case 2: { consultasToolStripMenuItem.Visible = true; } break;
                    case 3: { registroToolStripMenuItem.Visible = true; } break;
                    case 4: { } break;
                    case 5: { } break;

                }
            }
        }
        public FrmMenu()
        {
            InitializeComponent();
        }

    
        private void perfilesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmManPerfiles frm = new FrmManPerfiles();
            frm.MdiParent = this;
            frm.Show();
            //this.Hide();
        }

        private void usuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmManUsuarios frm = new FrmManUsuarios();
            frm.MdiParent = this;
            frm.Show();
            //this.Hide();
        }


        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaClientes frm = new FrmConsultaClientes();
            frm.MdiParent = this;
            frm.Show();
            //this.Hide();
        }

        private void LogoffToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Conexion Finalizada");
            Application.Exit();


        }

        private void regresarAlInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoCliente frm = new FrmNuevoCliente();
            frm.MdiParent = this;
            frm.Show();

        }

        private void solicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSolicitudPrestamo frm = new FrmSolicitudPrestamo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void listadoDePrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoPrestamos frm = new FrmListadoPrestamos();
            frm.MdiParent = this;
            frm.Show();
        }
    }

}

