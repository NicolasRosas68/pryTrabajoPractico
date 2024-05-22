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
    public partial class FrmDatosPersonales : Form
    {
        public FrmDatosPersonales()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmBienvenidos frmBienvenidos = new FrmBienvenidos();
            frmBienvenidos.ShowDialog();
            this.Close();
            
        }

        private void FrmDatosPersonales_Load(object sender, EventArgs e)
        {

        }
    }
}
