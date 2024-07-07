namespace Parcial_2_Mauro_Sosa.Formularios
{
    partial class frmReparacion
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
            listBoxTaller = new ListBox();
            SuspendLayout();
            // 
            // listBoxTaller
            // 
            listBoxTaller.Dock = DockStyle.Bottom;
            listBoxTaller.FormattingEnabled = true;
            listBoxTaller.Location = new Point(0, 193);
            listBoxTaller.Name = "listBoxTaller";
            listBoxTaller.Size = new Size(800, 257);
            listBoxTaller.TabIndex = 39;
            // 
            // FrmReparacion
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxTaller);
            Name = "FrmReparacion";
            Text = "FrmReparacion";
            Load += FrmReparacion_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxTaller;
    }
}