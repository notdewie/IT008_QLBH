using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;


namespace SaleManages.GUI
{
    public partial class _frmChangePass : Form
    {
        string checklang;
        CultureInfo culture;
        public _frmChangePass()
        {
            InitializeComponent();
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
            checklang = ((_frmSalesManage)f).lbNameKh.Text;
            culture = CultureInfo.CurrentCulture;
            if (checklang == "Họ Tên:") SetLanguage("vi-VN");
            else SetLanguage("en-US");
        }
        private void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("SaleManages.Resources.MyResource", typeof(_frmLogin).Assembly);
            btTitle.Text = rm.GetString("doimatkhau", culture);
            lbOldPass.Text = rm.GetString("change_matkhaucu", culture);
            lbNewPass.Text = rm.GetString("change_matkhaumoi", culture);
            lbCheckPass.Text = rm.GetString("change_xacnhan", culture);
            btnAccept.Text = rm.GetString("info_xacnhan", culture);
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
