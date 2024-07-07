using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Parcial_2_Mauro_Sosa.Formularios
{
    public partial class frmBarcos : Form
    {
        List<Barco> listaEntidades;
        public frmBarcos()
        {
            InitializeComponent();

            txtId.Enabled = false;
            txtTipo.Enabled = false;

            listaEntidades = AccesoDatos.Seleccionar();

            listBoxBarcos.DataSource = listaEntidades;

        }

        private void limpiarTextBoxes()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Clear();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar miFormulario = new frmAgregar();
            if (miFormulario.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    AccesoDatos.Insertar(miFormulario.EntidadFormulario);

                    listaEntidades = AccesoDatos.Seleccionar();
                    listBoxBarcos.DataSource = listaEntidades;

                    MessageBox.Show("La accion se realizó con éxito!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Accion cancelada!");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminar miFormulario = new frmEliminar();
            if (miFormulario.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    AccesoDatos.Eliminar(miFormulario.NombreEntidadEliminada);

                    listaEntidades = AccesoDatos.Seleccionar();
                    listBoxBarcos.DataSource = listaEntidades;

                    MessageBox.Show("La accion se realizó con éxito!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Accion cancelada!");
            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarTextBoxes();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string nombre = txtNombre.Text;
            string tipo = txtTipo.Text;
            int tripulacion = int.Parse(txtTripulacion.Text);

            Barco entidadModificada;

            var mapeo = new Dictionary<string, ETipoBarco>
            {
                {"Pirata", ETipoBarco.Pirata},
                {"Marina", ETipoBarco.Marina}
            };

            ETipoBarco tipoBarco = mapeo.TryGetValue(tipo, out ETipoBarco tipoB) ? tipoB : ETipoBarco.nulo;

            if (tipoBarco != ETipoBarco.nulo)
            {
                entidadModificada = tipoBarco == ETipoBarco.Pirata ? new Pirata(id, nombre, tripulacion)
                                                                      : new Marina(id, nombre, tripulacion);
                try
                {
                    AccesoDatos.Modificar(entidadModificada);

                    listaEntidades = AccesoDatos.Seleccionar();
                    listBoxBarcos.DataSource = listaEntidades;

                    MessageBox.Show("La accion se realizó con éxito!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Tpo de barco no valido!");
            }

            

        }

        private void listBoxBarcos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxBarcos.SelectedIndex;
            Barco barco = listaEntidades[index];

            ETipoBarco tipo = barco is Pirata ? ETipoBarco.Pirata : ETipoBarco.Marina;

            txtId.Text = barco.Id.ToString();
            txtNombre.Text = barco.Nombre.ToString();
            txtTipo.Text = tipo.ToString();
            txtTripulacion.Text = barco.Tripulacion.ToString();
        }
    }
}
