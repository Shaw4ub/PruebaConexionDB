namespace PruebaConexionDB
{
    partial class menuUsuarios
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblMensajeUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(312, 280);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(125, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "BIENVENIDO USUARIO";
            // 
            // lblMensajeUsuario
            // 
            this.lblMensajeUsuario.AutoSize = true;
            this.lblMensajeUsuario.Location = new System.Drawing.Point(360, 208);
            this.lblMensajeUsuario.Name = "lblMensajeUsuario";
            this.lblMensajeUsuario.Size = new System.Drawing.Size(0, 13);
            this.lblMensajeUsuario.TabIndex = 1;
            // 
            // menuUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMensajeUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Name = "menuUsuarios";
            this.Text = "menuUsuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblMensajeUsuario;
    }
}