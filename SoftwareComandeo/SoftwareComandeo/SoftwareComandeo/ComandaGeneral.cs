using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareComandeo
{
    public partial class ComandaGeneral : Form
    {
        public ComandaGeneral()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            pnlCliente.Visible=true;
            pnlServicios.Visible = false;
            pnlColaborador.Visible = false;
            
        }

        private void btnServicio_Click(object sender, EventArgs e)
        {
            pnlCliente.Visible = false;
            pnlColaborador.Visible = false;
            pnlServicios.Visible = true;
        }

        private void btnColaborador_Click(object sender, EventArgs e)
        {
            pnlCliente.Visible = false;
            pnlServicios.Visible = false;
            pnlColaborador.Visible = true;
        }

        private void btnCorte_Click(object sender, EventArgs e)
        {
            CORTES form = new CORTES();
            form.ShowDialog();
        }

        private void btnMaquillaje_Click(object sender, EventArgs e)
        {
            MAQUILLAJES form = new MAQUILLAJES();
            form.ShowDialog();
        }

        private void btnPeinado_Click(object sender, EventArgs e)
        {
            PEINADOS form = new PEINADOS();
            form.ShowDialog();
        }

        private void btnRegresarComanda_Click(object sender, EventArgs e)
        {
            ComandaGeneral.ActiveForm.Close();
        }
    }
}
