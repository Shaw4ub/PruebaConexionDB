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
    public partial class modificarMedico : Form
    {
        public modificarMedico()
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

        private void modifcarMedico(int idMedico, string nombre, string especialidad)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-LQ002K8\\MSSQL; Initial Catalog=EjemploClinica; Integrated Security=True"))
                {
                    conexion.Open();

                    string query = "UPDATE Medico SET nombre = @nombre, especialidad = @especialidad WHERE idMedico = @idMedico ;";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idMedico", idMedico); // Declarar y asignar valor a @idMedico
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@especialidad", especialidad);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Modificación exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Asegúrate de tener los valores actualizados de tus TextBox u otros controles
            string nuevoNombre = txtNombre.Text;
            string nuevaEspecialidad = txtEspecialidad.Text;

            if (!int.TryParse(txtId.Text, out int idMedico))
            {
                MessageBox.Show("Ingresa un valor válido para el idMedico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Llama al método de modificación
            modifcarMedico(idMedico, nuevoNombre, nuevaEspecialidad);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtEspecialidad.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
