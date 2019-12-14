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
    public partial class _frmChangePass : Form
    {
        public _frmChangePass()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tbOldPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbOldPass.Text))
            {
                e.Cancel = true;
                tbOldPass.Focus();
                epOldPass.SetError(tbOldPass, "Vui lòng nhập mật khẩu cũ!");
            }
            else
            {
                e.Cancel = false;
                epOldPass.SetError(tbOldPass, null);
            }
        }

        private void tbNewPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbNewPass.Text))
            {
                e.Cancel = true;
                tbNewPass.Focus();
                epNewPass.SetError(tbNewPass, "Vui lòng điền mật khẩu mới!");
            }
            else
            {
                e.Cancel = false;
                epNewPass.SetError(tbNewPass, null);
            }
        }

        private void tbCheckPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbCheckPass.Text))
            {
                e.Cancel = true;
                tbCheckPass.Focus();
                epReNewPass.SetError(tbCheckPass, "Vui lòng nhập lại mật khẩu!");
            }
            else
            {
                e.Cancel = false;
                epReNewPass.SetError(tbCheckPass, null);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            ValidateChildren(ValidationConstraints.Enabled);
            if (!string.IsNullOrEmpty(tbOldPass.Text))
                if (!string.IsNullOrEmpty(tbNewPass.Text))
                    if (!string.IsNullOrEmpty(tbCheckPass.Text))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                       
        }
    }
}
