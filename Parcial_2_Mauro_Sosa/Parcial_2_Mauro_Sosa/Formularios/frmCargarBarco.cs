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
    public partial class frmCargarBarco : Form
    {
        Barco entidadFormulario;
        public Barco EntidadFormulario
        {
            get => entidadFormulario;
        }
        public frmCargarBarco()
        {
            InitializeComponent();
            foreach (ETipoBarco tipo in Enum.GetValues(typeof(ETipoBarco)))
            {
                cmbTipo.Items.Add(tipo);
            }
            cmbTipo.SelectedIndex = 0;

            foreach (EOperacion tipo in Enum.GetValues(typeof(EOperacion)))
            {
                cmbOperacion.Items.Add(tipo);
            }
            cmbOperacion.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            ETipoBarco tipoBarcoSeleccionado = (ETipoBarco)cmbTipo.SelectedItem;
            EOperacion tipoOperacionSeleccionado = (EOperacion)cmbTipo.SelectedItem;

            entidadFormulario = tipoBarcoSeleccionado == ETipoBarco.Pirata ? new Pirata(nombre)
                                                                           : new Marina(nombre);
            entidadFormulario.Id = 0;
            entidadFormulario.CalcularCosto();
            entidadFormulario.EstadoReparado = false;
            entidadFormulario.Operacion = tipoOperacionSeleccionado;
            entidadFormulario.Tripulacion = 0;
            

            this.DialogResult = DialogResult.OK;
        }
    }
}
