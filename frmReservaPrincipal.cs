﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryPrimerTPLab3_SignorileBautista
{
    public partial class frmReservaPrincipal : Form
    {
        public frmReservaPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            frmReservaRealizada oReservasRealizadas = new frmReservaRealizada();
            oReservasRealizadas.Show();
        }
    }
}
