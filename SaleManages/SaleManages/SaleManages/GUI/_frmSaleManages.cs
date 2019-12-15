using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaleManages.DAO;
using SaleManages.GUI;
using SaleManages.DTO;
using System.Resources;
using System.Globalization;

namespace SaleManages.GUI
{
    public partial class _frmSalesManage : Form
    {
        string checklang;
        CultureInfo culture;
        public _frmSalesManage()
        {
            InitializeComponent();
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmLogin"];
            checklang = ((_frmLogin)f).lbTitle.Text;
            culture = CultureInfo.CurrentCulture;
            if (checklang == "Đăng Nhập") SetLanguage("vi-VN");
            else SetLanguage("en-US");
        }

        private void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("SaleManages.Resources.MyResource", typeof(_frmLogin).Assembly);
            btnAdd.LabelText = rm.GetString("them", culture);
            btnEra.LabelText = rm.GetString("xoa", culture);
            btnFix.LabelText = rm.GetString("sua", culture);
            btnView.LabelText = rm.GetString("xem", culture);
            btnFind.LabelText = rm.GetString("tim", culture);
            metroTabPage1.Text = rm.GetString("khachhang", culture);
            metroTabPage2.Text = rm.GetString("nhanvien", culture);
            metroTabPage3.Text = rm.GetString("sanpham", culture);
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
            label1.Text = rm.GetString("gioitinh", culture);
            rbNam.Text = rm.GetString("nam", culture);
            rbNu.Text = rm.GetString("nu", culture);
            rbElse.Text = rm.GetString("khac", culture);
            rbNamNV.Text = rm.GetString("nam", culture);
            rbNuNV.Text = rm.GetString("nu", culture);
            rbKhacNV.Text = rm.GetString("khac", culture);
            lbMucdo.Text = rm.GetString("mucdo", culture);
            label2.Text = rm.GetString("mucdo", culture);
            backToolStripMenuItem.Text = rm.GetString("hethong", culture);
            windowToolStripMenuItem.Text = rm.GetString("thongtin", culture);
            tàiKhoảnToolStripMenuItem.Text = rm.GetString("taikhoan", culture);
            tùyChọnToolStripMenuItem.Text = rm.GetString("tuychon", culture);
            ngônNgữToolStripMenuItem.Text = rm.GetString("ngonngu", culture);
            tiếngViệtToolStripMenuItem.Text = rm.GetString("tiengviet", culture);
            tiếngAnhToolStripMenuItem.Text = rm.GetString("tienganh", culture);
            thôngTinỨngDụngToolStripMenuItem.Text = rm.GetString("thongtinungdung", culture);
            lbNameSp.Text = rm.GetString("tensp", culture);
            lbCodeSp.Text = rm.GetString("masp", culture);
            lbDateSp.Text = rm.GetString("nsx", culture);
            lbHsdSp.Text = rm.GetString("hsd", culture);
            lbNcc.Text = rm.GetString("ncc", culture);
            lbPrice.Text = rm.GetString("giathanh", culture);
            lbDonvi.Text = rm.GetString("donvi", culture);
            lbSaleoff.Text = rm.GetString("ctkm", culture);
            xuấtHóaĐơnToolStripMenuItem.Text = rm.GetString("hoadon", culture);
            inToolStripMenuItem.Text = rm.GetString("in", culture);
            điềuKhoảnToolStripMenuItem.Text = rm.GetString("dieukhoan", culture);
            đăngXuấtToolStripMenuItem.Text = rm.GetString("btnLogout", culture);
            thôngTinToolStripMenuItem.Text = rm.GetString("btnInfo", culture);
            đổiMậtKhẩuToolStripMenuItem.Text = rm.GetString("idoimatkhau", culture);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ValidateChildren(ValidationConstraints.Enabled);
            int rs = CheckTabPage();
            if(rs == 0)
            {
                ObjCustomerDAO.Instance.Add();
            }
            else if(rs == 1)
            {
                ObjEmployeesDAO.Instance.Add();
            }
            else
            {
                ObjProductDAO.Instance.Add();
            }
        }
        int CheckTabPage()
        {
            int result = 5;
            if (metroTabControl1.SelectedIndex == 0) 
            {
                result = 0;
            }
            else if(metroTabControl1.SelectedIndex ==1)
            {
                result = 1;
            }
            else if(metroTabControl1.SelectedIndex ==2)
            {
                result = 2;
            }
            return result;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int check = CheckTabPage();
            if(check == 0)
            {
               
                dtgvKhachhang.DataSource = ObjCustomerDAO.Instance.LoadCustomerData();
                ObjCustomerDAO.Instance.Bindings();
            }
            else if (check == 1)
            {

                dtgvNhanvien.DataSource = ObjEmployeesDAO.Instance.LoadEmployeesData();
                ObjEmployeesDAO.Instance.Bindings();
            }
            else 
            {
                dtgvSanpham.DataSource = ObjProductDAO.Instance.LoadProductData();
                ObjProductDAO.Instance.Bindings();
                
            }
        }

        private void dtgvKhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ObjCustomerDAO.Instance.Bindings();
        }

        private void btnEra_Click(object sender, EventArgs e)
        {
            int check = CheckTabPage();
            if (check == 0)
            {
                ObjCustomerDAO.Instance.Delete();
            }
            else if (check == 1)
            {
                ObjEmployeesDAO.Instance.Delete();
            }
            else
            {
                ObjProductDAO.Instance.Delete();
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            int check = CheckTabPage();
            if (check == 0)
            {
                ObjCustomerDAO.Instance.Update();
            }
            else if (check == 1)
            {
                ObjEmployeesDAO.Instance.Update();
            }
            else
            {
                ObjProductDAO.Instance.Update();
            }
        }

        private void lbSex_Click(object sender, EventArgs e)
        {

        }

        private void lbMucdo_Click(object sender, EventArgs e)
        {

        }

        private void dtgvNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ObjEmployeesDAO.Instance.Bindings();
        }

        private void _frmSalesManage_Load(object sender, EventArgs e)
        {

        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmInfoAcc f = new _frmInfoAcc();
            f.ShowDialog();
        }

        private void điềuKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmUseTerm f = new _frmUseTerm();
            f.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmChangePass f = new _frmChangePass();
            f.ShowDialog();
        }

        private void tbNameSp_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbNameSp.Text))
            {
                e.Cancel = true;
                tbNameSp.Focus();
                epTenSanPham.SetError(tbNameSp, "Vui lòng điền tên sản phẩm!");
            }
            else
            {
                e.Cancel = false;
                epTenSanPham.SetError(tbNameSp, null);
            }
        }

        private void tbCodeSp_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbCodeSp.Text))
            {
                e.Cancel = true;
                tbCodeSp.Focus();
                epMaSanPham.SetError(tbCodeSp, "Vui lòng điền mã sản phẩm!");
            }
            else
            {
                e.Cancel = false;
                epMaSanPham.SetError(tbCodeSp, null);
            }
        }

        private void tbDateSp_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbDateSp.Text))
            {
                e.Cancel = true;
                tbDateSp.Focus();
                epNSX.SetError(tbDateSp, "NSX phải nhỏ hơn HSD!");
            }
            else
            {
                e.Cancel = false;
                epNSX.SetError(tbDateSp, null);
            }
        }

        private void tbNcc_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbNcc.Text))
            {
                e.Cancel = true;
                tbNcc.Focus();
                epNCC.SetError(tbNcc, "Vui lòng điền tên NCC!");
            }
            else
            {
                e.Cancel = false;
                epNCC.SetError(tbNcc, null);
            }
        }

        private void tbPrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPrice.Text))
            {
                e.Cancel = true;
                tbPrice.Focus();
                epPrice.SetError(tbPrice, "Vui lòng điền giá thành!");
            }
            else
            {
                e.Cancel = false;
                epPrice.SetError(tbPrice, null);
            }
        }

        private void tbDonvi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbDonvi.Text))
            {
                e.Cancel = true;
                tbDonvi.Focus();
                epDonVi.SetError(tbDonvi, "Vui lòng điền đơn vị!");
            }
            else
            {
                e.Cancel = false;
                epDonVi.SetError(tbDonvi, null);
            }

        }

        private void tiếngViệtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetLanguage("vi-VN");
        }

        private void tiếngAnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetLanguage("en-US");
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _frmLogin frmLogin = new _frmLogin();
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmLogin"];
            if (lbNameKh.Text == "Họ Tên:")
                ((_frmLogin)f).lbTitle.Text = "Đăng Nhập";
            else ((_frmLogin)f).lbTitle.Text = "Login";
            frmLogin.Show();
        }
    }
}
