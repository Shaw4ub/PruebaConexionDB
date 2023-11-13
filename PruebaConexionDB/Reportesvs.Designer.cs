namespace PruebaConexionDB
{
    partial class Reportesvs
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
            this.cryviewerPacientes = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport11 = new PruebaConexionDB.Reportes.CrystalReport1();
            this.SuspendLayout();
            // 
            // cryviewerPacientes
            // 
            this.cryviewerPacientes.ActiveViewIndex = 0;
            this.cryviewerPacientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryviewerPacientes.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryviewerPacientes.DisplayStatusBar = false;
            this.cryviewerPacientes.DisplayToolbar = false;
            this.cryviewerPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryviewerPacientes.Location = new System.Drawing.Point(0, 0);
            this.cryviewerPacientes.Name = "cryviewerPacientes";
            this.cryviewerPacientes.ReportSource = this.CrystalReport11;
            this.cryviewerPacientes.Size = new System.Drawing.Size(1219, 898);
            this.cryviewerPacientes.TabIndex = 0;
            this.cryviewerPacientes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.ParameterPanel;
            // 
            // Reportesvs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 898);
            this.Controls.Add(this.cryviewerPacientes);
            this.Name = "Reportesvs";
            this.Text = "ReportesVisualizer";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryviewerPacientes;
        private Reportes.CrystalReport1 CrystalReport11;
    }
}