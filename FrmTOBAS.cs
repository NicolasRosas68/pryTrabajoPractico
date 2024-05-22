using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTrabajoPractico
{
    public partial class FrmTOBAS : Form
    {
        public FrmTOBAS()
        {
            InitializeComponent();
        }

        private void btnReservarAsientos_Click(object sender, EventArgs e)
        {
            FrmDatosPersonales frmDatosPersonales = new FrmDatosPersonales();
            frmDatosPersonales.ShowDialog();
          
        }

        private void FrmTOBAS_Load(object sender, EventArgs e)
        {

        }
    }
}
