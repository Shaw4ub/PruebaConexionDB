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
    public partial class principalUsuario : Form
    {
        public principalUsuario()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-LQ002K8\\MSSQL; Initial Catalog=EjemploClinica; Integrated Security=True");

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Abrir la conexión
                conexion.Open();

                // Crear una cadena SQL para obtener todos los usuarios
                string query = "SELECT idUsuario, nombre, usuario, password, tipoUsuario FROM Usuario";

                // Crear un objeto SqlCommand con la cadena SQL y la conexión
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    // Crear un SqlDataAdapter para ejecutar la consulta y llenar un DataTable
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        // Asignar el DataTable al DataSource del DataGridView
                        dgvUsuarios.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar Usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar la conexión después de usarla
                conexion.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor seleccione una fila para eliminar.");
                return;
            }

            // Obtener la fila seleccionada
            DataGridViewRow row = dgvUsuarios.SelectedRows[0];

            // Verificar si la fila es válida
            if (row.Index < 0 || row.Index >= dgvUsuarios.Rows.Count)
            {
                MessageBox.Show("La fila seleccionada no es válida.");
                return;
            }

            // Crear un nuevo formulario EliminarUsuario
            eliminarUsuario eliminarUsuarioForm = new eliminarUsuario();

            // Pasar los valores de la fila seleccionada al nuevo formulario
            eliminarUsuarioForm.TxtId.Text = row.Cells[0].Value.ToString();
            eliminarUsuarioForm.TxtNombre.Text = row.Cells[1].Value.ToString(); 
            eliminarUsuarioForm.TxtUsuario.Text = row.Cells[2].Value.ToString(); 
            eliminarUsuarioForm.TxtPassword.Text = row.Cells[3].Value.ToString(); 
            eliminarUsuarioForm.TxtTipoUsuario.Text = row.Cells[4].Value.ToString(); 
            

            // Mostrar el nuevo formulario
            eliminarUsuarioForm.Show();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor seleccione una fila para modificar.");
                return;
            }

            // Obtener la fila seleccionada
            DataGridViewRow row = dgvUsuarios.SelectedRows[0];

            // Verificar si la fila es válida
            if (row.Index < 0 || row.Index >= dgvUsuarios.Rows.Count)
            {
                MessageBox.Show("La fila seleccionada no es válida.");
                return;
            }

            // Crear un nuevo formulario EliminarUsuario
            modificarUsuario modificarUsuarioForm = new modificarUsuario();

            // Pasar los valores de la fila seleccionada al nuevo formulario

            modificarUsuarioForm.TxtId.Text = row.Cells[0].Value.ToString();
            modificarUsuarioForm.TxtNombre.Text = row.Cells[1].Value.ToString(); 
            modificarUsuarioForm.TxtUsuario.Text = row.Cells[2].Value.ToString(); 
            modificarUsuarioForm.TxtPassword.Text = row.Cells[3].Value.ToString(); 
            modificarUsuarioForm.TxtTipoUsuario.Text = row.Cells[4].Value.ToString(); 


            // Mostrar el nuevo formulario
            modificarUsuarioForm.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarUsuario agregarUsuario = new AgregarUsuario();
            this.Hide();
            agregarUsuario.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
