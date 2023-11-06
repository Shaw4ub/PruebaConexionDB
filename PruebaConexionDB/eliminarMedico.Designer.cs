namespace PruebaConexionDB
{
    partial class eliminarMedico
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
            this.btnMedicos = new System.Windows.Forms.Button();
            this.btnEliminarMedico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMedicos
            // 
            this.btnMedicos.FlatAppearance.BorderSize = 0;
            this.btnMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicos.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicos.Image = global::PruebaConexionDB.Properties.Resources.Doctor_Female_icon_icons_com_75050;
            this.btnMedicos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMedicos.Location = new System.Drawing.Point(-64, 8);
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(424, 56);
            this.btnMedicos.TabIndex = 32;
            this.btnMedicos.Text = "Eliminar médicos";
            this.btnMedicos.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMedico
            // 
            this.btnEliminarMedico.BackColor = System.Drawing.Color.Black;
            this.btnEliminarMedico.FlatAppearance.BorderSize = 0;
            this.btnEliminarMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMedico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMedico.ForeColor = System.Drawing.Color.White;
            this.btnEliminarMedico.Location = new System.Drawing.Point(496, 408);
            this.btnEliminarMedico.Name = "btnEliminarMedico";
            this.btnEliminarMedico.Size = new System.Drawing.Size(184, 48);
            this.btnEliminarMedico.TabIndex = 30;
            this.btnEliminarMedico.Text = "Eliminar Médico";
            this.btnEliminarMedico.UseVisualStyleBackColor = false;
            this.btnEliminarMedico.Click += new System.EventHandler(this.btnEliminarMedico_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 29;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(480, 184);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(112, 27);
            this.txtId.TabIndex = 28;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(99)))));
            this.lblId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(418, 184);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 19);
            this.lblId.TabIndex = 27;
            this.lblId.Text = "Id";
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecialidad.Location = new System.Drawing.Point(480, 272);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(112, 27);
            this.txtEspecialidad.TabIndex = 26;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(480, 232);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(112, 27);
            this.txtNombre.TabIndex = 25;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(99)))));
            this.lblEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEspecialidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.ForeColor = System.Drawing.Color.White;
            this.lblEspecialidad.Location = new System.Drawing.Point(344, 272);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(110, 19);
            this.lblEspecialidad.TabIndex = 24;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(99)))));
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(376, 232);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 19);
            this.lblNombre.TabIndex = 23;
            this.lblNombre.Text = "Nombre";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(248, 408);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(184, 48);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::PruebaConexionDB.Properties.Resources.closeWindow;
            this.btnCerrar.Location = new System.Drawing.Point(1168, 8);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(44, 32);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 79;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PruebaConexionDB.Properties.Resources.botonFondo;
            this.pictureBox1.Location = new System.Drawing.Point(240, 400);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PruebaConexionDB.Properties.Resources.botonFondo;
            this.pictureBox2.Location = new System.Drawing.Point(488, 400);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 82;
            this.pictureBox2.TabStop = false;
            // 
            // eliminarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(192)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1222, 710);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMedicos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminarMedico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "eliminarMedico";
            this.Text = "eliminarMedico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMedicos;
        private System.Windows.Forms.Button btnEliminarMedico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}