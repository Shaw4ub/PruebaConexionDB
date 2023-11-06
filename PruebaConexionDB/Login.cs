using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace PruebaConexionDB
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-LQ002K8\\MSSQL; Initial Catalog=EjemploClinica; Integrated Security=True");

        public void logear(string usuario, string contrasena)
        {

            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT nombre, tipoUsuario FROM Usuario WHERE Usuario = @Usuario AND Password = @pas",conexion);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pas", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if(dt.Rows.Count == 1) 
                {
                    this.Hide();

                    if (dt.Rows[0][1].ToString() == "Admin" )
                    {

                        new menuAdmin(dt.Rows[0][0].ToString()).Show();
                         
                    }

                    else if (dt.Rows[0][1].ToString() == "Usuario")
                    {
                        new menuUsuarios(dt.Rows[0][0].ToString()).Show();
                    }

                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrecta");
                }
            }
            catch(Exception e )
            {
                MessageBox.Show(e.Message);
            }

            finally
            {
                conexion.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            logear(this.txtUsuario.Text, this.txtContrasena.Text);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pnlBarraControl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
