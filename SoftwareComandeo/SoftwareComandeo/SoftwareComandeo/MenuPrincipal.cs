﻿using System;
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

        private void btnCerrarSesionMenu_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal.ActiveForm.Close();
        }
    }
}
