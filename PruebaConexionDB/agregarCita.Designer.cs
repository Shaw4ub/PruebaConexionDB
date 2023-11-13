namespace PruebaConexionDB
{
    partial class agregarCita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMedicos = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarCita = new System.Windows.Forms.Button();
            this.lblMotivoCita = new System.Windows.Forms.Label();
            this.lblHoraCita = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblFechaCita = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.comboBoxPacientes = new System.Windows.Forms.ComboBox();
            this.comboBoxMedicos = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFechaCita = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownHoraCita = new System.Windows.Forms.NumericUpDown();
            this.comboBoxAmPm = new System.Windows.Forms.ComboBox();
            this.textBoxMotivoCita = new System.Windows.Forms.TextBox();
            this.lblEstadoCita = new System.Windows.Forms.Label();
            this.comboBoxEstadoCita = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHoraCita)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::PruebaConexionDB.Properties.Resources.closeWindow;
            this.btnCerrar.Location = new System.Drawing.Point(1003, 10);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(59, 39);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 43;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMedicos
            // 
            this.btnMedicos.BackColor = System.Drawing.Color.Transparent;
            this.btnMedicos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMedicos.FlatAppearance.BorderSize = 0;
            this.btnMedicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicos.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicos.ForeColor = System.Drawing.Color.Black;
            this.btnMedicos.Image = global::PruebaConexionDB.Properties.Resources.citas64;
            this.btnMedicos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMedicos.Location = new System.Drawing.Point(21, 10);
            this.btnMedicos.Margin = new System.Windows.Forms.Padding(4);
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(405, 89);
            this.btnMedicos.TabIndex = 44;
            this.btnMedicos.Text = "Agregar citas";
            this.btnMedicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicos.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(288, 571);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(245, 59);
            this.btnCancelar.TabIndex = 91;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardarCita
            // 
            this.btnGuardarCita.BackColor = System.Drawing.Color.Black;
            this.btnGuardarCita.FlatAppearance.BorderSize = 0;
            this.btnGuardarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCita.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCita.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCita.Location = new System.Drawing.Point(629, 571);
            this.btnGuardarCita.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarCita.Name = "btnGuardarCita";
            this.btnGuardarCita.Size = new System.Drawing.Size(245, 59);
            this.btnGuardarCita.TabIndex = 90;
            this.btnGuardarCita.Text = "Agregar cita";
            this.btnGuardarCita.UseVisualStyleBackColor = false;
            this.btnGuardarCita.Click += new System.EventHandler(this.btnGuardarCita_Click);
            // 
            // lblMotivoCita
            // 
            this.lblMotivoCita.AutoSize = true;
            this.lblMotivoCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(99)))));
            this.lblMotivoCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMotivoCita.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivoCita.ForeColor = System.Drawing.Color.White;
            this.lblMotivoCita.Location = new System.Drawing.Point(352, 354);
            this.lblMotivoCita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotivoCita.Name = "lblMotivoCita";
            this.lblMotivoCita.Size = new System.Drawing.Size(122, 23);
            this.lblMotivoCita.TabIndex = 85;
            this.lblMotivoCita.Text = "Motivo Cita";
            // 
            // lblHoraCita
            // 
            this.lblHoraCita.AutoSize = true;
            this.lblHoraCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(99)))));
            this.lblHoraCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHoraCita.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraCita.ForeColor = System.Drawing.Color.White;
            this.lblHoraCita.Location = new System.Drawing.Point(320, 305);
            this.lblHoraCita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraCita.Name = "lblHoraCita";
            this.lblHoraCita.Size = new System.Drawing.Size(155, 23);
            this.lblHoraCita.TabIndex = 84;
            this.lblHoraCita.Text = "Hora de la cita";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PruebaConexionDB.Properties.Resources.botonFondo;
            this.pictureBox1.Location = new System.Drawing.Point(277, 561);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PruebaConexionDB.Properties.Resources.botonFondo;
            this.pictureBox2.Location = new System.Drawing.Point(619, 561);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(267, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 93;
            this.pictureBox2.TabStop = false;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(99)))));
            this.lblPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPaciente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.ForeColor = System.Drawing.Color.White;
            this.lblPaciente.Location = new System.Drawing.Point(373, 148);
            this.lblPaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(96, 23);
            this.lblPaciente.TabIndex = 88;
            this.lblPaciente.Text = "Paciente";
            // 
            // lblFechaCita
            // 
            this.lblFechaCita.AutoSize = true;
            this.lblFechaCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(99)))));
            this.lblFechaCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFechaCita.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCita.ForeColor = System.Drawing.Color.White;
            this.lblFechaCita.Location = new System.Drawing.Point(299, 246);
            this.lblFechaCita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaCita.Name = "lblFechaCita";
            this.lblFechaCita.Size = new System.Drawing.Size(170, 23);
            this.lblFechaCita.TabIndex = 94;
            this.lblFechaCita.Text = "Fecha de la cita";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(99)))));
            this.lblMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMedico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedico.ForeColor = System.Drawing.Color.White;
            this.lblMedico.Location = new System.Drawing.Point(384, 197);
            this.lblMedico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(85, 23);
            this.lblMedico.TabIndex = 96;
            this.lblMedico.Text = "Medico";
            // 
            // comboBoxPacientes
            // 
            this.comboBoxPacientes.FormattingEnabled = true;
            this.comboBoxPacientes.Location = new System.Drawing.Point(491, 148);
            this.comboBoxPacientes.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPacientes.Name = "comboBoxPacientes";
            this.comboBoxPacientes.Size = new System.Drawing.Size(276, 24);
            this.comboBoxPacientes.TabIndex = 98;
            this.comboBoxPacientes.SelectedIndexChanged += new System.EventHandler(this.comboBoxPacientes_SelectedIndexChanged);
            // 
            // comboBoxMedicos
            // 
            this.comboBoxMedicos.FormattingEnabled = true;
            this.comboBoxMedicos.Location = new System.Drawing.Point(491, 197);
            this.comboBoxMedicos.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMedicos.Name = "comboBoxMedicos";
            this.comboBoxMedicos.Size = new System.Drawing.Size(276, 24);
            this.comboBoxMedicos.TabIndex = 99;
            this.comboBoxMedicos.SelectedIndexChanged += new System.EventHandler(this.comboBoxMedicos_SelectedIndexChanged);
            // 
            // dateTimePickerFechaCita
            // 
            this.dateTimePickerFechaCita.Location = new System.Drawing.Point(491, 246);
            this.dateTimePickerFechaCita.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFechaCita.Name = "dateTimePickerFechaCita";
            this.dateTimePickerFechaCita.Size = new System.Drawing.Size(276, 22);
            this.dateTimePickerFechaCita.TabIndex = 100;
            // 
            // numericUpDownHoraCita
            // 
            this.numericUpDownHoraCita.Location = new System.Drawing.Point(501, 305);
            this.numericUpDownHoraCita.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownHoraCita.Name = "numericUpDownHoraCita";
            this.numericUpDownHoraCita.Size = new System.Drawing.Size(267, 22);
            this.numericUpDownHoraCita.TabIndex = 101;
            // 
            // comboBoxAmPm
            // 
            this.comboBoxAmPm.FormattingEnabled = true;
            this.comboBoxAmPm.Location = new System.Drawing.Point(779, 305);
            this.comboBoxAmPm.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAmPm.Name = "comboBoxAmPm";
            this.comboBoxAmPm.Size = new System.Drawing.Size(73, 24);
            this.comboBoxAmPm.TabIndex = 102;
            // 
            // textBoxMotivoCita
            // 
            this.textBoxMotivoCita.Location = new System.Drawing.Point(501, 354);
            this.textBoxMotivoCita.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMotivoCita.Multiline = true;
            this.textBoxMotivoCita.Name = "textBoxMotivoCita";
            this.textBoxMotivoCita.Size = new System.Drawing.Size(265, 24);
            this.textBoxMotivoCita.TabIndex = 103;
            // 
            // lblEstadoCita
            // 
            this.lblEstadoCita.AutoSize = true;
            this.lblEstadoCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(99)))));
            this.lblEstadoCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEstadoCita.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCita.ForeColor = System.Drawing.Color.White;
            this.lblEstadoCita.Location = new System.Drawing.Point(352, 404);
            this.lblEstadoCita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoCita.Name = "lblEstadoCita";
            this.lblEstadoCita.Size = new System.Drawing.Size(120, 23);
            this.lblEstadoCita.TabIndex = 104;
            this.lblEstadoCita.Text = "Estado Cita";
            // 
            // comboBoxEstadoCita
            // 
            this.comboBoxEstadoCita.FormattingEnabled = true;
            this.comboBoxEstadoCita.Location = new System.Drawing.Point(501, 404);
            this.comboBoxEstadoCita.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEstadoCita.Name = "comboBoxEstadoCita";
            this.comboBoxEstadoCita.Size = new System.Drawing.Size(265, 24);
            this.comboBoxEstadoCita.TabIndex = 105;
            // 
            // agregarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 690);
            this.Controls.Add(this.comboBoxEstadoCita);
            this.Controls.Add(this.lblEstadoCita);
            this.Controls.Add(this.textBoxMotivoCita);
            this.Controls.Add(this.comboBoxAmPm);
            this.Controls.Add(this.numericUpDownHoraCita);
            this.Controls.Add(this.dateTimePickerFechaCita);
            this.Controls.Add(this.comboBoxMedicos);
            this.Controls.Add(this.comboBoxPacientes);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.lblFechaCita);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarCita);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.lblMotivoCita);
            this.Controls.Add(this.lblHoraCita);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnMedicos);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "agregarCita";
            this.Text = "agregarCita";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.agregarCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHoraCita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnMedicos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarCita;
        private System.Windows.Forms.Label lblMotivoCita;
        private System.Windows.Forms.Label lblHoraCita;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblFechaCita;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.ComboBox comboBoxPacientes;
        private System.Windows.Forms.ComboBox comboBoxMedicos;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaCita;
        private System.Windows.Forms.NumericUpDown numericUpDownHoraCita;
        private System.Windows.Forms.ComboBox comboBoxAmPm;
        private System.Windows.Forms.TextBox textBoxMotivoCita;
        private System.Windows.Forms.Label lblEstadoCita;
        private System.Windows.Forms.ComboBox comboBoxEstadoCita;
    }
}