namespace Parcial_2_Mauro_Sosa.Formularios
{
    partial class frmCargarBarco
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
            cmbTipo = new ComboBox();
            btnCancelar = new Button();
            labelOperacion = new Label();
            labelTipo = new Label();
            labelNombre = new Label();
            btnAgregar = new Button();
            txtNombre = new TextBox();
            cmbOperacion = new ComboBox();
            SuspendLayout();
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(238, 146);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(225, 31);
            cmbTipo.TabIndex = 34;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(331, 288);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(136, 59);
            btnCancelar.TabIndex = 33;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // labelOperacion
            // 
            labelOperacion.AutoSize = true;
            labelOperacion.Font = new Font("Segoe UI", 11.8208952F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOperacion.Location = new Point(91, 198);
            labelOperacion.Name = "labelOperacion";
            labelOperacion.Size = new Size(114, 30);
            labelOperacion.TabIndex = 32;
            labelOperacion.Text = "Operacion";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Segoe UI", 11.8208952F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTipo.Location = new Point(152, 146);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(56, 30);
            labelTipo.TabIndex = 31;
            labelTipo.Text = "Tipo";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 11.8208952F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(114, 97);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(94, 30);
            labelNombre.TabIndex = 30;
            labelNombre.Text = "Nombre";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(114, 288);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(136, 59);
            btnAgregar.TabIndex = 29;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(238, 100);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(225, 30);
            txtNombre.TabIndex = 28;
            // 
            // cmbOperacion
            // 
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Location = new Point(238, 198);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(225, 31);
            cmbOperacion.TabIndex = 35;
            // 
            // frmCargarBarco
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 450);
            Controls.Add(cmbOperacion);
            Controls.Add(cmbTipo);
            Controls.Add(btnCancelar);
            Controls.Add(labelOperacion);
            Controls.Add(labelTipo);
            Controls.Add(labelNombre);
            Controls.Add(btnAgregar);
            Controls.Add(txtNombre);
            Name = "frmCargarBarco";
            Text = "frmCargarBarco";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTipo;
        private Button btnCancelar;
        private Label labelOperacion;
        private Label labelTipo;
        private Label labelNombre;
        private Button btnAgregar;
        private TextBox txtNombre;
        private ComboBox cmbOperacion;
    }
}