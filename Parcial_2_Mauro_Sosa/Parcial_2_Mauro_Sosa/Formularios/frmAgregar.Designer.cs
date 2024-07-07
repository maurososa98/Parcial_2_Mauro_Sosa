namespace Parcial_2_Mauro_Sosa.Formularios
{
    partial class frmAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregar));
            labelTripulacion = new Label();
            labelTipo = new Label();
            labelNombre = new Label();
            btnAgregar = new Button();
            txtNombre = new TextBox();
            txtTripulacion = new TextBox();
            btnCancelar = new Button();
            cmbTipo = new ComboBox();
            SuspendLayout();
            // 
            // labelTripulacion
            // 
            labelTripulacion.AutoSize = true;
            labelTripulacion.Font = new Font("Segoe UI", 11.8208952F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTripulacion.Location = new Point(80, 186);
            labelTripulacion.Name = "labelTripulacion";
            labelTripulacion.Size = new Size(117, 30);
            labelTripulacion.TabIndex = 24;
            labelTripulacion.Text = "Tripulacion";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Segoe UI", 11.8208952F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTipo.Location = new Point(141, 134);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(56, 30);
            labelTipo.TabIndex = 23;
            labelTipo.Text = "Tipo";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 11.8208952F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(103, 85);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(94, 30);
            labelNombre.TabIndex = 22;
            labelNombre.Text = "Nombre";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(103, 276);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(136, 59);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(227, 88);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(225, 30);
            txtNombre.TabIndex = 18;
            // 
            // txtTripulacion
            // 
            txtTripulacion.Location = new Point(227, 189);
            txtTripulacion.Name = "txtTripulacion";
            txtTripulacion.Size = new Size(225, 30);
            txtTripulacion.TabIndex = 16;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(320, 276);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(136, 59);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(227, 137);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(225, 31);
            cmbTipo.TabIndex = 26;
            // 
            // formAgregar
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(582, 450);
            Controls.Add(cmbTipo);
            Controls.Add(btnCancelar);
            Controls.Add(labelTripulacion);
            Controls.Add(labelTipo);
            Controls.Add(labelNombre);
            Controls.Add(btnAgregar);
            Controls.Add(txtNombre);
            Controls.Add(txtTripulacion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formAgregar";
            Text = "formAgregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTripulacion;
        private Label labelTipo;
        private Label labelNombre;
        private Button btnAgregar;
        private TextBox txtNombre;
        private TextBox txtTripulacion;
        private Button btnCancelar;
        private ComboBox cmbTipo;
    }
}