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
    public partial class principalRecetas : Form
    {
        public principalRecetas()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-LQ002K8\\MSSQL; Initial Catalog=EjemploClinica; Integrated Security=True");

        private void Recetas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ejemploClinicaDataSet.Receta' Puede moverla o quitarla según sea necesario.
            this.recetaTableAdapter.Fill(this.ejemploClinicaDataSet.Receta);

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                                // Abrir la conexión
                conexion.Open();

                // Crear una cadena SQL para obtener todos los usuarios
                string query = "SELECT idReceta, idPaciente, dosisMedicamento, fechaPrescripcion FROM Receta";

                // Crear un objeto SqlCommand con la cadena SQL y la conexión
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    // Crear un SqlDataAdapter para ejecutar la consulta y llenar un DataTable
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        // Asignar el DataTable al DataSource del DataGridView
                        dgvRecetas.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar Receta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar la conexión después de usarla
                conexion.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            


        }
    }
}
