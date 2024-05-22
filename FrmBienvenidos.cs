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
    public partial class FrmBienvenidos : Form
    {
        public FrmBienvenidos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmQUENAKEN frmQUENAKEN = new FrmQUENAKEN();
            frmQUENAKEN.ShowDialog();
            
            
        }

        private void btnOnas_Click(object sender, EventArgs e)
        {
            FrmONAS frmONAS = new FrmONAS();
            frmONAS.ShowDialog();
          
        }

        private void btnTobas_Click(object sender, EventArgs e)
        {
            FrmTOBAS frmTOBAS = new FrmTOBAS();
            frmTOBAS.ShowDialog();
           
        }
    }
}
