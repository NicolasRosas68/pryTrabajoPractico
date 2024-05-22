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
    public partial class FrmONAS : Form
    {
        public FrmONAS()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnReservarAsientos_Click(object sender, EventArgs e)
        {
            FrmDatosPersonales frmDatosPersonales = new FrmDatosPersonales();
            frmDatosPersonales.ShowDialog();
          
        }

        private void FrmONAS_Load(object sender, EventArgs e)
        {
            lstAzul.Items.Clear();

            // Agregamos los números del 1 al 40 al ListBox
            for (int i = 1; i <= 40; i++)
            {
                lstAzul.Items.Add(i);
            }
        }
    }
}
