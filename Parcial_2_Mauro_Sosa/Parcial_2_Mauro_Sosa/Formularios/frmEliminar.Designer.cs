namespace Parcial_2_Mauro_Sosa.Formularios
{
    partial class frmEliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEliminar));
            btnCancelar = new Button();
            labelTripulacion = new Label();
            labelTipo = new Label();
            labelNombre = new Label();
            btnEliminar = new Button();
            txtNombre = new TextBox();
            txtTipo = new TextBox();
            txtTripulacion = new TextBox();
            listBoxEliminar = new ListBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(435, 262);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(136, 59);
            btnCancelar.TabIndex = 33;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // labelTripulacion
            // 
            labelTripulacion.AutoSize = true;
            labelTripulacion.Font = new Font("Segoe UI", 11.8208952F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTripulacion.Location = new Point(195, 186);
            labelTripulacion.Name = "labelTripulacion";
            labelTripulacion.Size = new Size(117, 30);
            labelTripulacion.TabIndex = 32;
            labelTripulacion.Text = "Tripulacion";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Segoe UI", 11.8208952F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTipo.Location = new Point(256, 134);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(56, 30);
            labelTipo.TabIndex = 31;
            labelTipo.Text = "Tipo";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 11.8208952F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(218, 85);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(94, 30);
            labelNombre.TabIndex = 30;
            labelNombre.Text = "Nombre";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(218, 262);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(136, 59);
            btnEliminar.TabIndex = 29;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(342, 88);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(225, 30);
            txtNombre.TabIndex = 28;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(342, 137);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(225, 30);
            txtTipo.TabIndex = 27;
            // 
            // txtTripulacion
            // 
            txtTripulacion.Location = new Point(342, 189);
            txtTripulacion.Name = "txtTripulacion";
            txtTripulacion.Size = new Size(225, 30);
            txtTripulacion.TabIndex = 26;
            // 
            // listBoxEliminar
            // 
            listBoxEliminar.Dock = DockStyle.Bottom;
            listBoxEliminar.FormattingEnabled = true;
            listBoxEliminar.Location = new Point(0, 378);
            listBoxEliminar.Name = "listBoxEliminar";
            listBoxEliminar.Size = new Size(800, 257);
            listBoxEliminar.TabIndex = 38;
            listBoxEliminar.SelectedIndexChanged += listBoxEliminar_SelectedIndexChanged;
            // 
            // formEliminar
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 635);
            Controls.Add(listBoxEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(labelTripulacion);
            Controls.Add(labelTipo);
            Controls.Add(labelNombre);
            Controls.Add(btnEliminar);
            Controls.Add(txtNombre);
            Controls.Add(txtTipo);
            Controls.Add(txtTripulacion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formEliminar";
            Text = "formEliminar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Label labelTripulacion;
        private Label labelTipo;
        private Label labelNombre;
        private Button btnEliminar;
        private TextBox txtNombre;
        private TextBox txtTipo;
        private TextBox txtTripulacion;
        private ListBox listBoxEliminar;
    }
}