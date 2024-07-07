using Entidades;
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

namespace Parcial_2_Mauro_Sosa.Formularios
{
    public partial class frmTaller : Form
    {
        Taller miTaller;
        XmlManager manejadorXml;
        public frmTaller()
        {
            InitializeComponent();
            miTaller = new Taller();
            miTaller.Barcos = new List<Barco>();
            manejadorXml = new XmlManager();
        }

        private void btnCargarBarco_Click(object sender, EventArgs e)
        {
            frmCargarBarco miFormulario = new frmCargarBarco();
            DialogResult resultado = miFormulario.ShowDialog();

            if (resultado == DialogResult.OK &&
                Taller.IngresarBarco(miTaller, miFormulario.EntidadFormulario) == true)
            {
                MessageBox.Show("La accion se realizó con éxito!");

            }
            else if (resultado == DialogResult.OK &&
                Taller.IngresarBarco(miTaller, miFormulario.EntidadFormulario) == false)
            {
                MessageBox.Show("El barco ingresado ya se encuentra en el taller!");
            }
            else if (resultado == DialogResult.Cancel)
            {
                MessageBox.Show("Accion cancelada!");
            }

        }

        private void btnReparar_Click(object sender, EventArgs e)
        {
            frmReparacion miFormulario = new frmReparacion(miTaller);
            miFormulario.Show();
        }

        private void btnGuardarRegistro_Click(object sender, EventArgs e)
        {
            string directorioProyecto = AppDomain.CurrentDomain.BaseDirectory;
            string rutaAchivo = Path.Combine(directorioProyecto, "taller.xml");

            string mensajeError;
            if (manejadorXml.Guardar(rutaAchivo, miTaller, out mensajeError))
            {
                MessageBox.Show($"Archivo XML guardado en: {rutaAchivo}");
            }
            else
            {
                MessageBox.Show($"Error al guardar registro: {mensajeError}");
            }
        }

        private void frmTaller_Load(object sender, EventArgs e)
        {
            string directorioProyecto = AppDomain.CurrentDomain.BaseDirectory;
            string rutaAchivo = Path.Combine(directorioProyecto, "taller.xml");

            string mensajeError;
            List<Barco> listaBarcosArchivo = manejadorXml.Leer(rutaAchivo, out mensajeError);

            if (File.Exists(rutaAchivo))
            {
                foreach (Barco barco in listaBarcosArchivo)
                {
                    Taller.IngresarBarco(miTaller, barco);
                }
                MessageBox.Show($"Se cargaron los barcos del Archivo XML: {rutaAchivo}");
            }
            else
            {
                MessageBox.Show($"Error al cargar barcos: {mensajeError}");
            }
        }
    }
}
