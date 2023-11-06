using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaConexionDB
{
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-LQ002K8\\MSSQL; Initial Catalog=EjemploClinica; Integrated Security=True");

        public void agregarUsuario(string nombre, string usuario, string password, string tipoUsuario)
        {
            try
            {
                // Abrir la conexión
                conexion.Open();

                // Crear una cadena SQL para la inserción de datos
                string query = "INSERT INTO Usuario (nombre, tipoUsuario, Usuario, Password) VALUES (@Nombre, @TipoUsuario, @Usuario, @Contrasena)";

                // Crear un objeto SqlCommand con la cadena SQL y la conexión
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    // Agregar parámetros para evitar la inyección de SQL y asignar valores
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@TipoUsuario", tipoUsuario);
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Contrasena", password);

                    // Ejecutar la consulta de inserción
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Inserción exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se insertaron filas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de inserción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar la conexión después de usarla
                conexion.Close();
            }



        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            string nombre = txtNombre.Text;
            string usuario = txtUsuario.Text;
            string password = txtContra.Text;
            string tipoUsuario = txtTipoUsuario.Text;

            agregarUsuario(this.txtNombre.Text, this.txtUsuario.Text, this.txtContra.Text, this.txtTipoUsuario.Text);
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
