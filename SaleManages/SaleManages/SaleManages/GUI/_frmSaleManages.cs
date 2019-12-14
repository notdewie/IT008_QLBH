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

namespace SaleManages.GUI
{
    public partial class _frmSalesManage : Form
    {
        public _frmSalesManage()
        {
            InitializeComponent();
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


    }
}
