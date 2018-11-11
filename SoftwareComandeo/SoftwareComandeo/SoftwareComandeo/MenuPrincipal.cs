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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListadoComandas form = new frmListadoComandas();
            form.ShowDialog();
        }

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        private void btnCerrarSesionMenu_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal.ActiveForm.Close();
        }
=======
<<<<<<< HEAD
=======
>>>>>>> 1a94512f8e8afb0944e7ad0072c3c47efcc86002
<<<<<<< HEAD
=======
>>>>>>> 1a94512f8e8afb0944e7ad0072c3c47efcc86002
        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
=======
        
>>>>>>> 304a8df6c1189f1b01ab9040793ad325b79b4aa4
=======
        
>>>>>>> 304a8df6c1189f1b01ab9040793ad325b79b4aa4
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 1a94512f8e8afb0944e7ad0072c3c47efcc86002
=======
>>>>>>> 1a94512f8e8afb0944e7ad0072c3c47efcc86002
=======
>>>>>>> 1a94512f8e8afb0944e7ad0072c3c47efcc86002
    }
}
