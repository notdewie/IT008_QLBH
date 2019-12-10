using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManages
{
    public partial class frmCreateAcc : Form
    {
        public frmCreateAcc()
        {
            InitializeComponent();
        }
        private void frmCreateAcc_Load(object sender, EventArgs e)
        {

        }
        private void lbUseTerm_Click(object sender, EventArgs e)
        {
            frmUseTerm f = new frmUseTerm();
            f.ShowDialog();

        }

        private void lbBack_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Hide();
            f.ShowDialog();
        }
    }
}
