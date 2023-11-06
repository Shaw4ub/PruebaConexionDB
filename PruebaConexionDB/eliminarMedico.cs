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
    public partial class eliminarMedico : Form
    {
        public eliminarMedico()
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



        private void EliminarMedico(int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-LQ002K8\\MSSQL; Initial Catalog=EjemploClinica; Integrated Security=True"))
                {
                    conexion.Open();

                    string query = "DELETE FROM Medico WHERE idMedico = @idMedico;";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idMedico", id);

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

        private void btnEliminarMedico_Click(object sender, EventArgs e)
        {
            // Asegúrate de que txtId es un control TextBox en tu formulario
            if (int.TryParse(txtId.Text, out int idMedico))
            {
                EliminarMedico(idMedico);
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido para el ID del médico", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
