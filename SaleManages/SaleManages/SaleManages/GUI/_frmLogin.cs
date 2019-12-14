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
    public partial class _frmLogin : Form
    {
        string checklang;
        CultureInfo culture;

        public _frmLogin()
        {
            InitializeComponent();
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frm"];
            checklang = ((_frm)f).lbNameKh.Text;
            culture = CultureInfo.CurrentCulture;
            if (checklang == "Họ Tên:") SetLanguage("vi-VN");
            else SetLanguage("en-US");
        }
        private void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("SaleManages.Resources.MyResource", typeof(_frm).Assembly);
            lbTitle.Text = rm.GetString("login_dangnhap", culture);
            lbUsername.Text = rm.GetString("login_tendangnhap", culture);
            lbPass.Text = rm.GetString("login_matkhau", culture);
            btnLogin.Text = rm.GetString("login_btnLogin", culture);
            lbReg.Text = rm.GetString("login_btnReg", culture);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVi_Click(object sender, EventArgs e)
        {
            SetLanguage("vi-VN");
        }

        private void btnEn_Click(object sender, EventArgs e)
        {
            SetLanguage("en-US");
        }

        private void lbReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            _frmCreateAcc frmCreateAcc = new _frmCreateAcc();
            frmCreateAcc.Show();
        }
    }
}
