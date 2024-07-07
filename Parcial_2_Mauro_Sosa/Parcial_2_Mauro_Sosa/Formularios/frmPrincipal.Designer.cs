namespace Parcial_2_Mauro_Sosa
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnTaller = new Button();
            btnBarcos = new Button();
            mainPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnTaller);
            panel1.Controls.Add(btnBarcos);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 648);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.barco;
            pictureBox1.Location = new Point(59, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnTaller
            // 
            btnTaller.BackColor = Color.FromArgb(64, 64, 64);
            btnTaller.FlatAppearance.BorderSize = 0;
            btnTaller.FlatStyle = FlatStyle.Flat;
            btnTaller.Font = new Font("Century Gothic", 13.970149F, FontStyle.Bold);
            btnTaller.ForeColor = Color.White;
            btnTaller.Location = new Point(0, 382);
            btnTaller.Name = "btnTaller";
            btnTaller.Size = new Size(300, 41);
            btnTaller.TabIndex = 2;
            btnTaller.Text = "TALLER";
            btnTaller.UseVisualStyleBackColor = false;
            btnTaller.Click += btnTaller_Click;
            // 
            // btnBarcos
            // 
            btnBarcos.BackColor = Color.FromArgb(64, 64, 64);
            btnBarcos.FlatAppearance.BorderSize = 0;
            btnBarcos.FlatStyle = FlatStyle.Flat;
            btnBarcos.Font = new Font("Century Gothic", 13.970149F, FontStyle.Bold);
            btnBarcos.ForeColor = Color.White;
            btnBarcos.Location = new Point(0, 335);
            btnBarcos.Name = "btnBarcos";
            btnBarcos.Size = new Size(300, 41);
            btnBarcos.TabIndex = 1;
            btnBarcos.Text = "BARCOS";
            btnBarcos.UseVisualStyleBackColor = false;
            btnBarcos.Click += btnBarcos_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackgroundImage = Properties.Resources.Titanic;
            mainPanel.BackgroundImageLayout = ImageLayout.Stretch;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(300, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(890, 648);
            mainPanel.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 648);
            Controls.Add(mainPanel);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            FormClosing += frmPrincipal_FormClosing;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnBarcos;
        private Button btnTaller;
        private PictureBox pictureBox1;
        private Panel mainPanel;
    }
}
