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
    public partial class agregarMedico : Form
    {
        public agregarMedico()
        {
            InitializeComponent();
        }

        public TextBox TxtId
        {
            get { return txtId; }
        }

        public TextBox TxtNombre
        {
            get { return txtNombre; }
        }

        public TextBox TxtEspecialidad
        {
            get { return txtEspecialidad; }
        }

        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-LQ002K8\\MSSQL; Initial Catalog=EjemploClinica; Integrated Security=True");

        public void AgregarMedico(string nombre, string especialidad)
        {
            try
            {
                // Abrir la conexión
                conexion.Open();

                // Crear una cadena SQL para la inserción de datos
                string query = "INSERT INTO Medico (nombre, especialidad) VALUES (@Nombre, @Especialidad)";

                // Crear un objeto SqlCommand con la cadena SQL y la conexión
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    // Agregar parámetros para evitar la inyección de SQL y asignar valores
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Especialidad", especialidad);

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

        private void btnEliminarMedico_Click(object sender, EventArgs e)
        {
            
            string nombre = txtNombre.Text;
            string especialidad = txtEspecialidad.Text;
   
            AgregarMedico(this.txtNombre.Text, this.txtEspecialidad.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            //Haz que este texto solo acepte letras
            if (System.Text.RegularExpressions.Regex.IsMatch(txtNombre.Text, "[^a-zA-Z]"))
            {
                MessageBox.Show("Por favor ingrese solo letras.");
                txtNombre.Text = txtNombre.Text.Remove(txtNombre.Text.Length - 1);
            }
        }
    }

}
