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
    public partial class _frmInfoAcc : Form
    {
        string checklang;
        CultureInfo culture;

        public _frmInfoAcc()
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
            lbTitle.Text = rm.GetString("info_lbTitle", culture);
            lbName.Text = rm.GetString("info_ten", culture);
            lbAddress.Text = rm.GetString("info_diachi", culture);
            lbBirth.Text = rm.GetString("info_ngaysinh", culture);
            lbPhone.Text = rm.GetString("info_sdt", culture);
            lbChangePass.Text = rm.GetString("info_doimatkhau", culture);
            btnAccept.Text = rm.GetString("info_xacnhan", culture);
            lbSex.Text = rm.GetString("info_gioitinh", culture);
        }

        private void lbChangePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            _frmChangePass frmChangePass = new _frmChangePass();
            frmChangePass.Show();
        }
    }
}
