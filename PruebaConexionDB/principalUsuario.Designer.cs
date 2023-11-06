namespace PruebaConexionDB
{
    partial class principalUsuario
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnBienvenida = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(112, 392);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(168, 32);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Black;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(304, 392);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(168, 32);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(496, 392);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(168, 32);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Black;
            this.btnMostrar.FlatAppearance.BorderSize = 0;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.White;
            this.btnMostrar.Location = new System.Drawing.Point(688, 392);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(168, 32);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::PruebaConexionDB.Properties.Resources.closeWindow;
            this.btnCerrar.Location = new System.Drawing.Point(864, 8);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(44, 32);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(208, 120);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(536, 240);
            this.dgvUsuarios.TabIndex = 15;
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
            this.btnBienvenida.Image = global::PruebaConexionDB.Properties.Resources.users64;
            this.btnBienvenida.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBienvenida.Location = new System.Drawing.Point(320, 16);
            this.btnBienvenida.Name = "btnBienvenida";
            this.btnBienvenida.Size = new System.Drawing.Size(304, 80);
            this.btnBienvenida.TabIndex = 16;
            this.btnBienvenida.Text = "Menú Usuarios";
            this.btnBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBienvenida.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PruebaConexionDB.Properties.Resources.botonFondo;
            this.pictureBox1.Location = new System.Drawing.Point(104, 384);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PruebaConexionDB.Properties.Resources.botonFondo;
            this.pictureBox2.Location = new System.Drawing.Point(296, 384);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(184, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PruebaConexionDB.Properties.Resources.botonFondo;
            this.pictureBox3.Location = new System.Drawing.Point(488, 384);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(184, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PruebaConexionDB.Properties.Resources.botonFondo;
            this.pictureBox4.Location = new System.Drawing.Point(680, 384);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(184, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            // 
            // principalUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(192)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(928, 784);
            this.Controls.Add(this.btnBienvenida);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "principalUsuario";
            this.Text = "principalUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnBienvenida;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}