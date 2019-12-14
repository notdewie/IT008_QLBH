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
    public partial class _frm : Form
    {
        CultureInfo culture;
        public _frm()
        {
            InitializeComponent();
            culture = CultureInfo.CurrentCulture;
        }



        private void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("SaleManages.Resources.MyResource", typeof(_frm).Assembly);
             btnAdd.LabelText = rm.GetString("them", culture);
             btnEra.LabelText = rm.GetString("xoa", culture);
             btnFix.LabelText = rm.GetString("sua", culture);
             btnView.LabelText = rm.GetString("xem", culture);
             btnFind.LabelText = rm.GetString("tim", culture);
             tabKh.Text = rm.GetString("khachhang", culture);
             tabNv.Text = rm.GetString("nhanvien", culture);
             tabSp.Text = rm.GetString("sanpham", culture);
             lbNameKh.Text = rm.GetString("hoten", culture);
             lbNameNh.Text = rm.GetString("hoten", culture);
             lbCodeKh.Text = rm.GetString("maso", culture);
             lbCodeNh.Text = rm.GetString("maso", culture);
             lbBirth.Text = rm.GetString("ngaysinh", culture);
             lbBirthNv.Text = rm.GetString("ngaysinh", culture);
             lbAddKh.Text = rm.GetString("diachi", culture);
             lbAddNv.Text = rm.GetString("diachi", culture);
             lbPhone.Text = rm.GetString("sdt", culture);
             lbPhoneNv.Text = rm.GetString("sdt", culture);
             lbBeginday.Text = rm.GetString("ngayvaolam", culture);
             lbSex.Text = rm.GetString("gioitinh", culture);
             lbSexNv.Text = rm.GetString("gioitinh", culture);
             rbNam.Text = rm.GetString("nam", culture);
             rbNu.Text = rm.GetString("nu", culture);
             rbElse.Text = rm.GetString("khac", culture);
             rbNamNv.Text = rm.GetString("nam", culture);
             rbNuNv.Text = rm.GetString("nu", culture);
             rbElseNv.Text = rm.GetString("khac", culture);
             lbMucdo.Text = rm.GetString("mucdo", culture);
             lbMucdoNv.Text = rm.GetString("mucdo", culture);
             iSystem.Text = rm.GetString("hethong", culture);
             iInfomation.Text = rm.GetString("thongtin", culture);
             iAccount.Text = rm.GetString("taikhoan", culture);
             iSelection.Text = rm.GetString("tuychon", culture);
             iLanguage.Text = rm.GetString("ngonngu", culture);
             btnVi.Text = rm.GetString("tiengviet", culture);
             btnEn.Text = rm.GetString("tienganh", culture);
             iInfo.Text = rm.GetString("thongtinungdung", culture);
             lbNameSp.Text = rm.GetString("tensp", culture);
             lbCodeSp.Text = rm.GetString("masp", culture);
             lbDateSp.Text = rm.GetString("nsx", culture);
             lbHsdSp.Text = rm.GetString("hsd", culture);
             lbNcc.Text = rm.GetString("ncc", culture);
             lbPrice.Text = rm.GetString("giathanh", culture);
             lbDonvi.Text = rm.GetString("donvi", culture);
             lbSaleoff.Text = rm.GetString("ctkm", culture);
             iBill.Text = rm.GetString("hoadon", culture);
             iPrint.Text = rm.GetString("in", culture);
             iTerm.Text = rm.GetString("dieukhoan", culture);
             btnLogout.Text = rm.GetString("btnLogout", culture);
             btnInfo.Text = rm.GetString("btnInfo", culture);
         }

        private void btnVi_Click(object sender, EventArgs e)
        {
            SetLanguage("vi-VN");
        }

        private void btnEn_Click(object sender, EventArgs e)
        {
            SetLanguage("en-US");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _frmLogin form1 = new _frmLogin();
            this.Hide();
            form1.Show();
        }

        private void iTerm_Click(object sender, EventArgs e)
        {
            this.Hide();
            _frmUseTerm frmUseTerm = new _frmUseTerm();
            frmUseTerm.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            _frmInfoAcc frmInfoAcc = new _frmInfoAcc();
            frmInfoAcc.Show();
        }
    }
}
