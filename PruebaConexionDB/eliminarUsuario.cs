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
    public partial class eliminarUsuario : Form
    {
        public eliminarUsuario()
        {
            InitializeComponent();
            
        }

        public TextBox TxtNombre
        {
            get { return txtNombre; }
        }

        public TextBox TxtUsuario
        {
            get { return txtUsuario; }
        }

        public TextBox TxtPassword
        {
            get { return txtPassword; }
        }

        public TextBox TxtTipoUsuario
        {
            get { return txtTipoUsuario; }
        }

        public TextBox TxtId
        {
            get { return txtId; }
        }

        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-LQ002K8\\MSSQL; Initial Catalog=EjemploClinica; Integrated Security=True");

        private void EliminarUsuario(int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-LQ002K8\\MSSQL; Initial Catalog=EjemploClinica; Integrated Security=True"))
                {
                    conexion.Open();

                    string query = "DELETE FROM Usuario WHERE idUsuario = @idUsuario;";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idUsuario", id);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Eliminación exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Puedes cerrar el formulario después de una eliminación exitosa si es apropiado
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Asegúrate de que txtId es un control TextBox en tu formulario
            if (int.TryParse(txtId.Text, out int idUsuario))
            {
                EliminarUsuario(idUsuario);
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido para el ID del usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
