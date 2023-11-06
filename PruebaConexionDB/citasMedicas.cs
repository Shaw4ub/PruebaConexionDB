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
    public partial class citasMedicas : Form
    {
        public citasMedicas()
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
                string query = "SELECT idCitaMedica,idPaciente, idMedico, fechaCita, horaCita, motivoCita, estadoCita FROM citasMedicas";

                // Crear un objeto SqlCommand con la cadena SQL y la conexión
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    // Crear un SqlDataAdapter para ejecutar la consulta y llenar un DataTable
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        // Asignar el DataTable al DataSource del DataGridView
                        dgvCitas.DataSource = dt;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarCita agregarCita = new agregarCita();
            agregarCita.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            // Verificar si hay una fila seleccionada
            if (dgvCitas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor seleccione una fila para modificar.");
                return;
            }

            // Obtener la fila seleccionada
            DataGridViewRow row = dgvCitas.SelectedRows[0];

            // Verificar si la fila es válida
            if (row.Index < 0 || row.Index >= dgvCitas.Rows.Count)
            {
                MessageBox.Show("La fila seleccionada no es válida.");
                return;
            }

            modificarCita modificarCitaForm = new modificarCita();

            string idCita = row.Cells[0].Value.ToString();
            string pacienteSeleccionado = row.Cells[1].Value.ToString();
            string medicoSeleccionado = row.Cells[2].Value.ToString();
            DateTime fechaCitaSeleccionada = Convert.ToDateTime(row.Cells[3].Value);
            int horaCitaSeleccionada = Convert.ToInt32(row.Cells[4].Value);
            string motivoCitaSeleccionado = row.Cells[5].Value.ToString();
            string estadoCitaSeleccionado = row.Cells[6].Value.ToString();

            modificarCitaForm.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el control donde se muestran las citas médicas
            if (dgvCitas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una cita médica para eliminar.");
                return;
            }

            // Obtener el ID de la cita médica seleccionada desde el control (supongamos que hay una columna "IdCitaMedica")
            int idCitaMedica = Convert.ToInt32(dgvCitas.SelectedRows[0].Cells["IdCitaMedica"].Value);

            if (MessageBox.Show("¿Estás seguro de que deseas eliminar esta cita médica?", "Confirmación de eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    // Realizar la eliminación de la cita médica en la base de datos
                    string query = "DELETE FROM citasMedicas WHERE idCitaMedica = @IdCitaMedica";

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@IdCitaMedica", idCitaMedica);

                        conexion.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        conexion.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cita médica eliminada correctamente.");
                            // Recargar la lista de citas médicas en el control DataGridView
                            // Esto puede requerir una función para cargar las citas médicas nuevamente
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la cita médica para eliminar.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar la cita médica: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
