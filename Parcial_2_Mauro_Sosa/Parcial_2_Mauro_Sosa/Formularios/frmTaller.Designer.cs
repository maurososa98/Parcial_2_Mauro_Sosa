namespace Parcial_2_Mauro_Sosa.Formularios
{
    partial class frmTaller
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
            label1 = new Label();
            btnCargarBarco = new Button();
            btnReparar = new Button();
            btnGuardarRegistro = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.1194019F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(112, 41);
            label1.TabIndex = 0;
            label1.Text = "TALLER";
            // 
            // btnCargarBarco
            // 
            btnCargarBarco.Font = new Font("Segoe UI", 19.8805962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargarBarco.Location = new Point(248, 176);
            btnCargarBarco.Name = "btnCargarBarco";
            btnCargarBarco.Size = new Size(353, 81);
            btnCargarBarco.TabIndex = 10;
            btnCargarBarco.Text = "Cargar Barco";
            btnCargarBarco.UseVisualStyleBackColor = true;
            btnCargarBarco.Click += btnCargarBarco_Click;
            // 
            // btnReparar
            // 
            btnReparar.Font = new Font("Segoe UI", 19.8805962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReparar.Location = new Point(248, 293);
            btnReparar.Name = "btnReparar";
            btnReparar.Size = new Size(353, 81);
            btnReparar.TabIndex = 12;
            btnReparar.Text = "Reparar";
            btnReparar.UseVisualStyleBackColor = true;
            btnReparar.Click += btnReparar_Click;
            // 
            // btnGuardarRegistro
            // 
            btnGuardarRegistro.Font = new Font("Segoe UI", 19.8805962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarRegistro.Location = new Point(248, 411);
            btnGuardarRegistro.Name = "btnGuardarRegistro";
            btnGuardarRegistro.Size = new Size(353, 81);
            btnGuardarRegistro.TabIndex = 13;
            btnGuardarRegistro.Text = "Guardar Registro";
            btnGuardarRegistro.UseVisualStyleBackColor = true;
            btnGuardarRegistro.Click += btnGuardarRegistro_Click;
            // 
            // frmTaller
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 648);
            Controls.Add(btnGuardarRegistro);
            Controls.Add(btnReparar);
            Controls.Add(btnCargarBarco);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTaller";
            Text = "frmInformes";
            Load += frmTaller_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCargarBarco;
        private Button btnReparar;
        private Button btnGuardarRegistro;
    }
}