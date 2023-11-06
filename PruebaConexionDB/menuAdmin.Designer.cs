namespace PruebaConexionDB
{
    partial class menuAdmin
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
            this.lblMensajeAdmin = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlBarraControl = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBienvenida = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.btnRecetas = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnMedicos = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.pnlBarraControl.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensajeAdmin
            // 
            this.lblMensajeAdmin.AutoSize = true;
            this.lblMensajeAdmin.Location = new System.Drawing.Point(384, 72);
            this.lblMensajeAdmin.Name = "lblMensajeAdmin";
            this.lblMensajeAdmin.Size = new System.Drawing.Size(0, 13);
            this.lblMensajeAdmin.TabIndex = 1;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(99)))));
            this.Menu.Controls.Add(this.btnReportes);
            this.Menu.Controls.Add(this.btnCerrarSesion);
            this.Menu.Controls.Add(this.button1);
            this.Menu.Controls.Add(this.btnFacturas);
            this.Menu.Controls.Add(this.btnRecetas);
            this.Menu.Controls.Add(this.btnUsuarios);
            this.Menu.Controls.Add(this.btnMedicos);
            this.Menu.Controls.Add(this.btnCitas);
            this.Menu.Controls.Add(this.btnPacientes);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(440, 728);
            this.Menu.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(99)))));
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(440, 80);
            this.button1.TabIndex = 10;
            this.button1.Text = "Acciones";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pnlBarraControl
            // 
            this.pnlBarraControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.pnlBarraControl.Controls.Add(this.btnBienvenida);
            this.pnlBarraControl.Controls.Add(this.btnCerrar);
            this.pnlBarraControl.Controls.Add(this.btnMinimizar);
            this.pnlBarraControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraControl.Location = new System.Drawing.Point(440, 0);
            this.pnlBarraControl.Name = "pnlBarraControl";
            this.pnlBarraControl.Size = new System.Drawing.Size(926, 80);
            this.pnlBarraControl.TabIndex = 4;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.Controls.Add(this.pictureBox1);
            this.pnlContenedor.Location = new System.Drawing.Point(440, 80);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(928, 768);
            this.pnlContenedor.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PruebaConexionDB.Properties.Resources.logoClinica1;
            this.pictureBox1.Location = new System.Drawing.Point(264, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 417);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnBienvenida
            // 
            this.btnBienvenida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnBienvenida.FlatAppearance.BorderSize = 0;
            this.btnBienvenida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnBienvenida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnBienvenida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBienvenida.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBienvenida.ForeColor = System.Drawing.Color.White;
            this.btnBienvenida.Image = global::PruebaConexionDB.Properties.Resources.Doctor_Female_icon_icons_com_75050;
            this.btnBienvenida.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBienvenida.Location = new System.Drawing.Point(0, 0);
            this.btnBienvenida.Name = "btnBienvenida";
            this.btnBienvenida.Size = new System.Drawing.Size(328, 80);
            this.btnBienvenida.TabIndex = 0;
            this.btnBienvenida.Text = "¡BIENVENID@!";
            this.btnBienvenida.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::PruebaConexionDB.Properties.Resources.cerrarIcon;
            this.btnCerrar.Location = new System.Drawing.Point(880, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(44, 32);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::PruebaConexionDB.Properties.Resources.menos;
            this.btnMinimizar.Location = new System.Drawing.Point(836, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(44, 32);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 14;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(192)))), ((int)(((byte)(204)))));
            this.btnReportes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.Black;
            this.btnReportes.Image = global::PruebaConexionDB.Properties.Resources.reporte64;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 560);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(440, 80);
            this.btnReportes.TabIndex = 12;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(192)))), ((int)(((byte)(204)))));
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Black;
            this.btnCerrarSesion.Image = global::PruebaConexionDB.Properties.Resources.cerrarSesion64;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 640);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(440, 88);
            this.btnCerrarSesion.TabIndex = 11;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnFacturas
            // 
            this.btnFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(192)))), ((int)(((byte)(204)))));
            this.btnFacturas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturas.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturas.ForeColor = System.Drawing.Color.Black;
            this.btnFacturas.Image = global::PruebaConexionDB.Properties.Resources.facturas64;
            this.btnFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturas.Location = new System.Drawing.Point(0, 400);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(440, 80);
            this.btnFacturas.TabIndex = 9;
            this.btnFacturas.Text = "Facturas";
            this.btnFacturas.UseVisualStyleBackColor = false;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // btnRecetas
            // 
            this.btnRecetas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(192)))), ((int)(((byte)(204)))));
            this.btnRecetas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRecetas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnRecetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecetas.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecetas.ForeColor = System.Drawing.Color.Black;
            this.btnRecetas.Image = global::PruebaConexionDB.Properties.Resources.recetas64;
            this.btnRecetas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecetas.Location = new System.Drawing.Point(0, 320);
            this.btnRecetas.Name = "btnRecetas";
            this.btnRecetas.Size = new System.Drawing.Size(440, 80);
            this.btnRecetas.TabIndex = 8;
            this.btnRecetas.Text = "Recetas";
            this.btnRecetas.UseVisualStyleBackColor = false;
            this.btnRecetas.Click += new System.EventHandler(this.btnRecetas_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(192)))), ((int)(((byte)(204)))));
            this.btnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.Black;
            this.btnUsuarios.Image = global::PruebaConexionDB.Properties.Resources.users64;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 480);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(440, 80);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnMedicos
            // 
            this.btnMedicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(192)))), ((int)(((byte)(204)))));
            this.btnMedicos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMedicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicos.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicos.ForeColor = System.Drawing.Color.Black;
            this.btnMedicos.Image = global::PruebaConexionDB.Properties.Resources.doctor64;
            this.btnMedicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicos.Location = new System.Drawing.Point(0, 240);
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(440, 80);
            this.btnMedicos.TabIndex = 7;
            this.btnMedicos.Text = "Médicos";
            this.btnMedicos.UseVisualStyleBackColor = false;
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(192)))), ((int)(((byte)(204)))));
            this.btnCitas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitas.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitas.ForeColor = System.Drawing.Color.Black;
            this.btnCitas.Image = global::PruebaConexionDB.Properties.Resources.citas64;
            this.btnCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCitas.Location = new System.Drawing.Point(0, 160);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(440, 80);
            this.btnCitas.TabIndex = 6;
            this.btnCitas.Text = "Citas";
            this.btnCitas.UseVisualStyleBackColor = false;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(192)))), ((int)(((byte)(204)))));
            this.btnPacientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.ForeColor = System.Drawing.Color.Black;
            this.btnPacientes.Image = global::PruebaConexionDB.Properties.Resources.paciente64;
            this.btnPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.Location = new System.Drawing.Point(0, 80);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(440, 80);
            this.btnPacientes.TabIndex = 5;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = false;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // menuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 728);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlBarraControl);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.lblMensajeAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Menu.ResumeLayout(false);
            this.pnlBarraControl.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMensajeAdmin;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Panel pnlBarraControl;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.Button btnRecetas;
        private System.Windows.Forms.Button btnMedicos;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBienvenida;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}