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
using SaleManages.DAO;

namespace SaleManages.GUI
{
    public partial class _frmInfoAcc : Form
    {
        string checklang;
        CultureInfo culture;

        public _frmInfoAcc()
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
                ResourceManager("SaleManages.Resources.MyResource", typeof(_frmSalesManage).Assembly);
            lbTitle.Text = rm.GetString("info_lbTitle", culture);
            lbName.Text = rm.GetString("info_ten", culture);
            lbAddress.Text = rm.GetString("info_diachi", culture);
            lbBirth.Text = rm.GetString("info_ngaysinh", culture);
            lbPhone.Text = rm.GetString("info_sdt", culture);
            lbChangePass.Text = rm.GetString("info_doimatkhau", culture);
            btnAccept.Text = rm.GetString("info_xacnhan", culture);
            lbSex.Text = rm.GetString("info_gioitinh", culture);
            linkLabel1.Text = rm.GetString("capnhat", culture);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbChangePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _frmChangePass f = new _frmChangePass();
            f.ShowDialog();
        }

        private void _frmInfoAcc_Load(object sender, EventArgs e)
        {
            AccountDAO.Instance.LoadInfoAcc();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _frmUpdateInfo f = new _frmUpdateInfo();
            f.Show();
        }
    }
}
