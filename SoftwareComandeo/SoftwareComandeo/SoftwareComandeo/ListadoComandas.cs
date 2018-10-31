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
    public partial class frmListadoComandas : Form
    {
        public frmListadoComandas()
        {
            InitializeComponent();
        }

        private void btn1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void bttnRegresarMenu_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.ShowDialog();
            Close();
        }
    }
}
