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
    public partial class FrmEnvioMail : Form
    {
        public FrmEnvioMail()
        {
            InitializeComponent();
        }
      

        private void EnviarCorreo()
        {
            try
            {
                Email correo = new Email();
                correo.Asunto = "Olvido de contraseña";
                correo.MensajeCorreo = "Contraseña -Usuario";
                correo.Remitente = "ycalv13@gmail.com";
                correo.Destinatario = new List<string>();
                foreach (DataGridViewRow item in dgvCorreos.Rows)

                {
                    correo.Destinatario.Add(item.Cells[1].Value.ToString());
                }

                GestorConexiones.GestorConexion_Servicios.EnviarCorreoElectronico(correo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void dgvCorreos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvCorreos.Columns[e.ColumnIndex].Name =="btnEliminar")
             {
                dgvCorreos.Rows.RemoveAt(e.RowIndex);
            
            }
         
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            EnviarCorreo();

            this.timer2.Start();
            MessageBox.Show("ENVIADO");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvCorreos.Rows.Add("", txtcorreo.Text.Trim());

            this.timer1.Start();
        }
       
        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Close();

            /*FrmLogin frm = new FrmLogin();
            frm.Show();*/
                      
        }
     
        private void timer1_Tick_1(object sender, EventArgs e)
        {
         pbcarga.Increment(10);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pbcarga2.Increment(10);
        }
    }
}
