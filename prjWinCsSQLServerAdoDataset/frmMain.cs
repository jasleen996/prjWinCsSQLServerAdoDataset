using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsSQLServerAdoDataset
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuSearch_Click(object sender, EventArgs e)
        {
            frmSearch fs = new frmSearch();
            fs.MdiParent = this;
            fs.Show();
        }

        private void mnuCompany_Click(object sender, EventArgs e)
        {
            frmCompany fc = new frmCompany();
            fc.MdiParent = this;
            fc.Show();
        }
    }
}
