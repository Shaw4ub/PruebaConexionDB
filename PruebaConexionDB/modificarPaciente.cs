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
using static System.Net.Mime.MediaTypeNames;

namespace PruebaConexionDB
{
    public partial class modificarPaciente : Form
    {
        public modificarPaciente()
        {
            InitializeComponent();
        }
        public TextBox TxtNombre
        {
            get { return txtNombre; }
        }

        public TextBox TxtApellido
        {
            get { return txtApellido; }
        }

        public DateTimePicker TxtFechaNacimiento
        {
            get { return dtpPaciente; }
        }
        public TextBox TxtGenero
        {
            get { return txtGenero; }
        }
        public TextBox TxtDireccion
        {
            get { return txtDireccion; }
        }
        public TextBox TxtTelefono
        {
            get { return txtTelefono; }
        }
        public TextBox TxtHistorialMedico
        {
            get { return txtHistorialMedico; }
        }
        public TextBox TxtRecetas
        {
            get { return txtRecetas; }
        }
        public TextBox TxtFacturas
        {
            get { return txtFacturas; }
        }
        public TextBox TxtId
        {
            get { return txtId; }
        }
        private void modifcarPaciente(int idPaciente, string nombre, string apellido, string fechaNaciemiento , string genero, string direccion, string telefono)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-LQ002K8\\MSSQL; Initial Catalog=EjemploClinica; Integrated Security=True"))
                {
                    conexion.Open();

                    string query = "UPDATE Paciente SET nombre = @Nombre, apellido = @Apellido, fechaNaciemiento = @FechaNaciemiento, genero = Genero, direccion = @Direccion, telefono = @Telefono WHERE idPaciente = @idPaciente ;";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Apellido", apellido);
                        cmd.Parameters.AddWithValue("@FechaNaciemiento", fechaNaciemiento);
                        cmd.Parameters.AddWithValue("@Genero", genero);
                        cmd.Parameters.AddWithValue("@Direccion", direccion);
                        cmd.Parameters.AddWithValue("@Telefono", telefono);
                        cmd.Parameters.AddWithValue("@idPaciente", idPaciente);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Modificación exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Puedes cerrar el formulario después de una eliminación exitosa si es apropiado
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el paciente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            dtpPaciente.CustomFormat = " "; // Espacio en blanco
            dtpPaciente.Format = DateTimePickerFormat.Custom;
            txtGenero.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtHistorialMedico.Text = "";
            txtRecetas.Text = "";
            txtFacturas.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Asegúrate de tener los valores actualizados de tus TextBox u otros controles
            string nuevoNombre = txtNombre.Text;
            string nuevoApellido = txtApellido.Text;
            DateTime nuevaFechaNacimiento = dtpPaciente.Value;
            string nuevaFechaNacimientoStr = nuevaFechaNacimiento.ToString("yyyy-MM-dd"); // Cambia el formato según tus necesidades
            string nuevoGenero = txtGenero.Text;
            string nuevaDireccion = txtDireccion.Text;
            string nuevoTelefono = txtTelefono.Text;

            if (!int.TryParse(txtId.Text, out int idPaciente))
            {
                MessageBox.Show("Ingresa un valor válido para el idPaciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Llama al método de modificación
            modifcarPaciente(idPaciente, nuevoNombre, nuevoApellido, nuevaFechaNacimientoStr, nuevoGenero, nuevaDireccion, nuevoTelefono);
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

        private void txtGenero_TextChanged(object sender, EventArgs e)
        {
            //Haz que este texto solo acepte letras
            txtGenero.Text = System.Text.RegularExpressions.Regex.Replace(txtGenero.Text, @"[^A-Za-zñÑ\s]", "");

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            //Haz que este texto solo acepte numeros
            txtTelefono.Text = System.Text.RegularExpressions.Regex.Replace(txtTelefono.Text, @"[^0-9]", "");
        }
    }
}
