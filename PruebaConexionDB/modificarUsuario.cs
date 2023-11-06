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
    public partial class modificarUsuario : Form
    {
        public modificarUsuario()
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

        private void modificarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void modifcarUsuario(int idUsuario,string nombre, string usuario, string password, string tipoUsuario)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-LQ002K8\\MSSQL; Initial Catalog=EjemploClinica; Integrated Security=True"))
                {
                    conexion.Open();

                    string query = "UPDATE Usuario SET nombre = @nombre, usuario = @usuario, password = @password, tipoUsuario = @tipoUsuario WHERE idUsuario = @idUsuario ;";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@tipoUsuario", tipoUsuario);
                        cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

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
            string nuevoUsuario = txtUsuario.Text;
            string nuevaPassword = txtPassword.Text;
            string nuevoTipoUsuario = txtTipoUsuario.Text;

            if (!int.TryParse(txtId.Text, out int idUsuario))
            {
                MessageBox.Show("Ingresa un valor válido para el idUsuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Llama al método de modificación
            modifcarUsuario(idUsuario,nuevoNombre, nuevoUsuario, nuevaPassword, nuevoTipoUsuario);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtUsuario.Text = "";
            txtPassword.Text = "";
            txtTipoUsuario.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
