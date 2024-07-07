using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2_Mauro_Sosa.Formularios
{
    public partial class frmAgregar : Form
    {
        Barco entidadFormulario;
        public Barco EntidadFormulario
        {
            get => entidadFormulario;
        }
        public frmAgregar()
        {
            InitializeComponent();
            foreach (ETipoBarco tipo in Enum.GetValues(typeof(ETipoBarco)))
            {
                cmbTipo.Items.Add(tipo);
            }
            cmbTipo.SelectedIndex = 0;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            ETipoBarco tipoBarcoSeleccionado = (ETipoBarco)cmbTipo.SelectedItem;
            int tripulacion = int.Parse(txtTripulacion.Text);

            entidadFormulario = tipoBarcoSeleccionado == ETipoBarco.Pirata ? new Pirata(nombre) 
                                                                           : new Marina(nombre);
            entidadFormulario.Tripulacion = tripulacion;

            this.DialogResult = DialogResult.OK;
        }


    }
}
