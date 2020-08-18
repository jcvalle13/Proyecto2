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




            foreach (Usuarios item in lstusuarios)
            {
                switch (item.Perfiles.cod_perfil)
                {
                    case 1: { mantenimientosToolStripMenuItem.Visible = true; } break;
                    case 2: { consultasToolStripMenuItem.Visible = true; } break;
                    case 3: { } break;
                    case 4: { } break;
                    case 5: { } break;

                }
            }
        }
        public FrmMenu()
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

      


    }

}

