﻿using System;
using System.Windows.Forms;
using Entidades;

namespace Presentacion
{
    public partial class FrmLogin : Form
    {
        int contador;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Usuario no ha sido ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (txtClave.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Contraseña no ha sido ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //Crea la instancia y se le asignan los valores                
                Usuarios objusuario = new Usuarios();

                objusuario.Usuario = txtUsuario.Text.Trim();
                objusuario.Contraseña = txtClave.Text.Trim();
                objusuario.Estado = true;

                if (GestorConexiones.GestorConexion_Servicios.VerificarUsuario(objusuario))

                {
                    MessageBox.Show("USUARIO CORRECTO", "Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FrmMenu frm = new FrmMenu();
                    frm.Usuario = txtUsuario.Text.Trim();//Nuevo
                    frm.CargarOpcionesUsuario();//NUEVO
                    frm.Show();
                    this.Hide();
                }

                else if (contador > 2)
                {
                    MessageBox.Show("Los intentos máximos (3) han sido alcanzados", "Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                else
                    MessageBox.Show("Usuario Incorrecto");
                txtUsuario.Text = "";
                txtClave.Text = "";
                contador += 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkRecuperarContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmEnvioMail frm = new FrmEnvioMail();
            frm.Show();

         
        }
    }
}
