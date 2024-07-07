namespace Parcial_2_Mauro_Sosa.Formularios
{
    partial class frmBarcos
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
            btnAgregar = new Button();
            btnEliminar = new Button();
            listBoxBarcos = new ListBox();
            labelTripulacion = new Label();
            labelTipo = new Label();
            labelNombre = new Label();
            txtNombre = new TextBox();
            txtTipo = new TextBox();
            txtTripulacion = new TextBox();
            btnLimpiar = new Button();
            btnModificar = new Button();
            labelId = new Label();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.1194019F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(97, 41);
            label1.TabIndex = 1;
            label1.Text = "CRUD";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(581, 120);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(136, 59);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(581, 221);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(136, 59);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // listBoxBarcos
            // 
            listBoxBarcos.Dock = DockStyle.Bottom;
            listBoxBarcos.FormattingEnabled = true;
            listBoxBarcos.Location = new Point(0, 391);
            listBoxBarcos.Name = "listBoxBarcos";
            listBoxBarcos.Size = new Size(890, 257);
            listBoxBarcos.TabIndex = 45;
            listBoxBarcos.SelectedIndexChanged += listBoxBarcos_SelectedIndexChanged;
            // 
            // labelTripulacion
            // 
            labelTripulacion.AutoSize = true;
            labelTripulacion.Font = new Font("Segoe UI", 11.8208952F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTripulacion.Location = new Point(150, 221);
            labelTripulacion.Name = "labelTripulacion";
            labelTripulacion.Size = new Size(117, 30);
            labelTripulacion.TabIndex = 42;
            labelTripulacion.Text = "Tripulacion";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Segoe UI", 11.8208952F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTipo.Location = new Point(211, 165);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(56, 30);
            labelTipo.TabIndex = 41;
            labelTipo.Text = "Tipo";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 11.8208952F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(173, 116);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(94, 30);
            labelNombre.TabIndex = 40;
            labelNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(297, 119);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(225, 30);
            txtNombre.TabIndex = 39;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(297, 168);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(225, 30);
            txtTipo.TabIndex = 38;
            // 
            // txtTripulacion
            // 
            txtTripulacion.Location = new Point(297, 220);
            txtTripulacion.Name = "txtTripulacion";
            txtTripulacion.Size = new Size(225, 30);
            txtTripulacion.TabIndex = 37;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(371, 275);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(145, 55);
            btnLimpiar.TabIndex = 36;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(173, 275);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(145, 55);
            btnModificar.TabIndex = 35;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 11.8208952F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelId.Location = new Point(233, 66);
            labelId.Name = "labelId";
            labelId.Size = new Size(34, 30);
            labelId.TabIndex = 47;
            labelId.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(297, 69);
            txtId.Name = "txtId";
            txtId.Size = new Size(225, 30);
            txtId.TabIndex = 46;
            // 
            // frmBarcos
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 648);
            Controls.Add(labelId);
            Controls.Add(txtId);
            Controls.Add(listBoxBarcos);
            Controls.Add(labelTripulacion);
            Controls.Add(labelTipo);
            Controls.Add(labelNombre);
            Controls.Add(txtNombre);
            Controls.Add(txtTipo);
            Controls.Add(txtTripulacion);
            Controls.Add(btnLimpiar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBarcos";
            Text = "frmEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAgregar;
        private Button btnEliminar;
        private ListBox listBoxBarcos;
        private Label labelTripulacion;
        private Label labelTipo;
        private Label labelNombre;
        private TextBox txtNombre;
        private TextBox txtTipo;
        private TextBox txtTripulacion;
        private Button btnLimpiar;
        private Button btnModificar;
        private Label labelId;
        private TextBox txtId;
    }
}