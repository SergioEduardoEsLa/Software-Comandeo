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
    public partial class MAQUILLAJES : Form
    {
        public MAQUILLAJES()
        {
            InitializeComponent();
        }

        private void btnRegresarMaquillajes_Click(object sender, EventArgs e)
        {
            MAQUILLAJES.ActiveForm.Close();
        }
    }
}
