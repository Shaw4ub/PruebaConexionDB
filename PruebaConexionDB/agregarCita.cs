using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaConexionDB
{
    public partial class agregarCita : Form
    {
        public agregarCita()
        {
            InitializeComponent();
            LlenarComboBoxPaciete();
            LlenarComboBoxMedico();

            // Agregar las opciones "am" y "pm" al ComboBox
            comboBoxAmPm.Items.Add("am");
            comboBoxAmPm.Items.Add("pm");

            // Agregar las opciones "asignada" y "noAsignada" al ComboBox
            comboBoxEstadoCita.Items.Add("Asignada");
            comboBoxEstadoCita.Items.Add("Pendiente");
        }

        public class Paciente
        {
            public int idPaciente { get; set; }
            public string nombre { get; set; }
            public string apellido { get; set; }

            public override string ToString()
            {
                return $"{nombre} {apellido}";
            }
        }

        public class Medico
        {
            public int idMedico { get; set; }
            public string nombre { get; set; }
            public string especialidad { get; set; }

            public override string ToString()
            {
                return $"{nombre} {especialidad}";
            }
        }

        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-LQ002K8\\MSSQL; Initial Catalog=EjemploClinica; Integrated Security=True");

        private void LlenarComboBoxPaciete()
        {
            try
            {
                conexion.Open();

                string query = "SELECT idPaciente, nombre, apellido FROM Paciente";
                SqlCommand command = new SqlCommand(query, conexion);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int idPaciente = reader.GetInt32(0);
                        string nombre = reader.GetString(1);
                        string apellido = reader.GetString(2);
                        comboBoxPacientes.Items.Add(new Paciente { idPaciente = idPaciente, nombre = nombre, apellido = apellido });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de inserción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void LlenarComboBoxMedico()
        {
            try
            {
                conexion.Open();

                string query = "SELECT idMedico, nombre, especialidad FROM Medico";
                SqlCommand command = new SqlCommand(query, conexion);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int idMedico = reader.GetInt32(0);
                        string nombre = reader.GetString(1);
                        string especialidad = reader.GetString(2);
                        comboBoxMedicos.Items.Add(new Medico { idMedico = idMedico, nombre = nombre, especialidad = especialidad });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de inserción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnGuardarCita_Click(object sender, EventArgs e)
        {
            try
            {
                int idPaciente = ((Paciente)comboBoxPacientes.SelectedItem).idPaciente;
                int idMedico = ((Medico)comboBoxMedicos.SelectedItem).idMedico;
                DateTime fechaCita = dateTimePickerFechaCita.Value;
                int horaCita = (int)numericUpDownHoraCita.Value;
                string amPm = comboBoxAmPm.SelectedItem.ToString(); // Obtener "am" o "pm"
                string estadoCita = comboBoxEstadoCita.SelectedItem.ToString();
                string motivoCita = textBoxMotivoCita.Text;

                // Convertir la hora y el minuto en formato de cadena "hh:mm"
                string horaCitaStr = string.Format("{0:D2}:{1:D2}", horaCita, 0); // Suponemos que los minutos son siempre 0

                if (amPm == "pm")
                {
                    horaCita += 12;
                    horaCitaStr = string.Format("{0:D2}:{1:D2}", horaCita, 0);
                }

                // Inserta la cita médica en la base de datos 
                string query = "INSERT INTO citasMedicas (idPaciente, idMedico, fechaCita, horaCita, estadoCita,motivoCita) " +
                              "VALUES (@IdPaciente, @IdMedico, @FechaCita, @HoraCita, @EstadoCita,@MotivoCita)";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@IdPaciente", idPaciente);
                    command.Parameters.AddWithValue("@IdMedico", idMedico);
                    command.Parameters.AddWithValue("@FechaCita", fechaCita);
                    command.Parameters.AddWithValue("@HoraCita", horaCitaStr);
                    command.Parameters.AddWithValue("@EstadoCita", estadoCita);
                    command.Parameters.AddWithValue("@MotivoCita", motivoCita);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }

                MessageBox.Show("Cita médica guardada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la cita médica: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarCita_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
