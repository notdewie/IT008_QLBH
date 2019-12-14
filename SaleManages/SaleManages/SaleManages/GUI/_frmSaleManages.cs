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
    }
}
