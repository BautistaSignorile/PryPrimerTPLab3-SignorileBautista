using System;
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
    public partial class frmPrincipaloObras : Form
    {
        public frmPrincipaloObras()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReservaPrincipal oReservaPrincipal = new frmReservaPrincipal();
            oReservaPrincipal.ShowDialog();
            Close();
        }
    }
}
