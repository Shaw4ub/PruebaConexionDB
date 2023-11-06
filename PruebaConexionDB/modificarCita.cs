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
using static PruebaConexionDB.agregarCita;

namespace PruebaConexionDB
{
    public partial class modificarCita : Form
    {
        public modificarCita()
        {
            InitializeComponent();
        }

       /* public TextBox TextBoxIdCita
        {
            get { return textBoxId; }
        }

        public ComboBox ComboBoxPacientes
        {
            get { return comboBoxPacientes; }
        }

        public ComboBox ComboBoxMedicos
        {
            get { return comboBoxMedicos; }
        }

        public MonthCalendar MonthCalendarFechaCita
        {
            get { return monthCalendarFechaCita; }
        }

        public NumericUpDown NumericUpDownHoraCita
        {
            get { return numericUpDownHoraCita; }
        }

        public TextBox TextBoxMotivoCita
        {
            get { return textBoxMotivoCita; }
        }

        public ComboBox ComboBoxEstadoCita
        {
            get { return comboBoxEstadoCita; }*/

        private void ModificarCita(int idCita, int idPaciente, int idMedico, DateTime fechaCita, int horaCita, string motivoCita, string estadoCita)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection("Cadena de conexión a tu base de datos"))
                {
                    conexion.Open();

                    string query = "UPDATE citasMedicas SET idPaciente = @idPaciente, idMedico = @idMedico, fechaCita = @fechaCita, horaCita = @horaCita, motivoCita = @motivoCita, estadoCita = @estadoCita WHERE idCita = @idCita;";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idCita", idCita);
                        cmd.Parameters.AddWithValue("@idPaciente", idPaciente);
                        cmd.Parameters.AddWithValue("@idMedico", idMedico);
                        cmd.Parameters.AddWithValue("@fechaCita", fechaCita);
                        cmd.Parameters.AddWithValue("@horaCita", horaCita);
                        cmd.Parameters.AddWithValue("@motivoCita", motivoCita);
                        cmd.Parameters.AddWithValue("@estadoCita", estadoCita);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cita médica modificada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la cita médica", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnModificarCita_Click(object sender, EventArgs e)
        {
            /* Asegúrate de tener los valores actualizados de tus controles
            int idCita = textBoxId.Text; 
            int idPaciente = ((Paciente)comboBoxPacientes.SelectedItem).idPaciente;
            int idMedico = ((Medico)comboBoxMedicos.SelectedItem).idMedico;
            DateTime fechaCita = monthCalendarFechaCita.SelectionStart;
            int horaCita = (int)numericUpDownHoraCita.Value;
            string motivoCita = textBoxMotivoCita.Text;
            string estadoCita = comboBoxEstadoCita.SelectedItem.ToString();

            // Llama al método de modificación
            ModificarCita(idCita, idPaciente, idMedico, fechaCita, horaCita, motivoCita, estadoCita);*/
        }
    }
}
