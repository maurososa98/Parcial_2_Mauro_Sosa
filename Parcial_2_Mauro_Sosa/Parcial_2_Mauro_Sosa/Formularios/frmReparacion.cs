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
    public partial class frmReparacion : Form
    {
        Taller tallerFrmReparacion;
        public frmReparacion(Taller taller)
        {
            InitializeComponent();
            tallerFrmReparacion = taller;
            taller.Repapar(tallerFrmReparacion);
        }

        private void FrmReparacion_Load(object sender, EventArgs e)
        {
            List<Barco> listaBarcos = tallerFrmReparacion.Barcos;

            foreach (Barco barco in listaBarcos)
            {
                listBoxTaller.Items.Add(barco.ToString());
            }

        }
    }
}
