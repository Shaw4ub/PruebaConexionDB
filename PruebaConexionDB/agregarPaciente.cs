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
    public partial class agregarPaciente : Form
    {
        public agregarPaciente()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-LQ002K8\\MSSQL; Initial Catalog=EjemploClinica; Integrated Security=True");

        public void AgregarPaciente(string nombre, string apellido, DateTime fechaNaciemiento, string genero, string direccion, string telefono)
        {
            try
            {
                // Abrir la conexión
                conexion.Open();

                // Crear una cadena SQL para la inserción de datos
                string query = "INSERT INTO Paciente (nombre, apellido, fechaNaciemiento, genero, direccion, telefono) VALUES (@Nombre, @Apellido, @FechaNaciemiento, @Genero, @Direccion, @Telefono)";

                // Crear un objeto SqlCommand con la cadena SQL y la conexión
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    // Agregar parámetros para evitar la inyección de SQL y asignar valores
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellido", apellido);
                    cmd.Parameters.AddWithValue("@FechaNaciemiento", fechaNaciemiento);
                    cmd.Parameters.AddWithValue("@Genero", genero);
                    cmd.Parameters.AddWithValue("@Direccion", direccion);
                    cmd.Parameters.AddWithValue("@Telefono", telefono);

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
            string apellido = txtApellido.Text;
            DateTime fechaNaciemiento = dtpPaciente.Value;
            string genero = txtGenero.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;

            AgregarPaciente(nombre, apellido, fechaNaciemiento, genero, direccion, telefono);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            //Haz que este texto solo acepte letras
            txtNombre.Text = System.Text.RegularExpressions.Regex.Replace(txtNombre.Text, @"[^A-Za-zñÑ\s]", "");
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            //Haz que este texto solo acepte letras
            txtApellido.Text = System.Text.RegularExpressions.Regex.Replace(txtApellido.Text, @"[^A-Za-zñÑ\s]", "");
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            //Haz que este texto solo acepte numeros
            txtTelefono.Text = System.Text.RegularExpressions.Regex.Replace(txtTelefono.Text, @"[^0-9]", "");
        }

        private void txtGenero_TextChanged(object sender, EventArgs e)
        {
            //Haz que este texto solo acepte letras
            txtGenero.Text = System.Text.RegularExpressions.Regex.Replace(txtGenero.Text, @"[^A-Za-zñÑ\s]", "");

        }
    }
}
