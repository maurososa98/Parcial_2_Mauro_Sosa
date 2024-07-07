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
    public partial class frmEliminar : Form
    {
        string nombreEntidadEliminada;
        List<Barco> listaEntidades;
        public string NombreEntidadEliminada
        {
            get => nombreEntidadEliminada;
        }
        public frmEliminar()
        {
            InitializeComponent();
            listaEntidades = AccesoDatos.Seleccionar();

            txtNombre.Enabled = false;
            txtTipo.Enabled = false;
            txtTripulacion.Enabled = false;

            listBoxEliminar.DataSource = listaEntidades;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            nombreEntidadEliminada = txtNombre.Text;
            this.DialogResult = DialogResult.OK;
        }


        private void listBoxEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxEliminar.SelectedIndex;
            Barco barco = listaEntidades[index];

            ETipoBarco tipo = barco is Pirata ? ETipoBarco.Pirata : ETipoBarco.Marina;

            txtNombre.Text = barco.Nombre.ToString();
            txtTipo.Text = tipo.ToString();
            txtTripulacion.Text = barco.Tripulacion.ToString();
        }
    }
}
