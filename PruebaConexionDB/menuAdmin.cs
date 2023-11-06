using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PruebaConexionDB
{
    public partial class menuAdmin : Form
    {
        public menuAdmin(string nombre)
        {
            InitializeComponent();
            lblMensajeAdmin.Text = nombre;
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new principalPacientes());
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new citasMedicas());
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Medicos());
        }

        private void btnRecetas_Click(object sender, EventArgs e)
        {

        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new principalUsuario());
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();

            Login loginForm = new Login();
            loginForm.Show();
        }
    }
}
