using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManages.GUI
{
    public partial class _frmInfoAcc : Form
    {
        public _frmInfoAcc()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            _frmSalesManage f = new _frmSalesManage();
            this.Hide();
            f.ShowDialog();
        }

        private void lbChangePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _frmChangePass f = new _frmChangePass();
            this.Hide();
            f.ShowDialog();
        }
    }
}
