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

<<<<<<< HEAD
        private void ComandaGeneral_Load(object sender, EventArgs e)
        {

=======
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
>>>>>>> 6946eb61e7c08bcb0395c59ea194358007fec77a
        }
    }
}
