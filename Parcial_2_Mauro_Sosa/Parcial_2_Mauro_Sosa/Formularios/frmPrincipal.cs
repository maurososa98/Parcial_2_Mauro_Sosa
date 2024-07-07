using Entidades;
using Parcial_2_Mauro_Sosa.Formularios;

namespace Parcial_2_Mauro_Sosa
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void CargarFormulario(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        private void btnTaller_Click(object sender, EventArgs e)
        {
            frmTaller frmInformes = new frmTaller();
            CargarFormulario(frmInformes);
        }

        private void btnBarcos_Click(object sender, EventArgs e)
        {
            frmBarcos frmBarcos = new frmBarcos();
            CargarFormulario(frmBarcos);
        }


        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que deseas salir?", "Cierre del formulario", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
