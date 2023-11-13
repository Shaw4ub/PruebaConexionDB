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
    public partial class Medicos : Form
    {
        public Medicos()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-LQ002K8\\MSSQL; Initial Catalog=EjemploClinica; Integrated Security=True");
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Abrir la conexión
                conexion.Open();

                // Crear una cadena SQL para obtener todos los usuarios
                string query = "SELECT idMedico, nombre, especialidad FROM Medico";

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

            // Crear un nuevo formulario modificarPaciente
            modificarMedico modificarMedicoForm = new modificarMedico();

            // Pasar los valores de la fila seleccionada al nuevo formulario

            modificarMedicoForm.TxtId.Text = row.Cells[0].Value.ToString();
            modificarMedicoForm.TxtNombre.Text = row.Cells[1].Value.ToString();
            modificarMedicoForm.TxtEspecialidad.Text = row.Cells[2].Value.ToString();
           
            // Mostrar el nuevo formulario
            modificarMedicoForm.Show();
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
            eliminarMedico eliminarMedicoForm = new eliminarMedico();

            //Pasar los valores de la fila seleccionada al nuevo formulario
            eliminarMedicoForm.TxtId.Text = row.Cells[0].Value.ToString();
            eliminarMedicoForm.TxtNombre.Text = row.Cells[1].Value.ToString();
            eliminarMedicoForm.TxtEspecialidad.Text = row.Cells[2].Value.ToString();

            // Mostrar el nuevo formulario
            eliminarMedicoForm.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarMedico agregarMedico = new agregarMedico();
            agregarMedico.Show();
        }

        private void Medicos_Load(object sender, EventArgs e)
        {

        }
    }
}
