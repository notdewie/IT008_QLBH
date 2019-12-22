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
    public partial class _frmFindCustomerData : Form
    {
        string checklang;
        CultureInfo culture;
        public _frmFindCustomerData()
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
            this.Text = rm.GetString("formTimKH", culture);
            lbFindcusData.Text = rm.GetString("tenKH", culture);
        }

        private void btnFindcusData_Click(object sender, EventArgs e)
        {
            if (tbFindemData.Text != "")
            {
                System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
                ((_frmSalesManage)f).dtgvKhachhang.DataSource = ObjCustomerDAO.Instance.FindCusomerData();
                this.Close();
            }
            else
            {
                if (checklang == "Họ Tên:")
                    MessageBox.Show("Nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Enter the customer name", "Notification", MessageBoxButtons.OK);
            }
        }

        private void btnFindemData_Click(object sender, EventArgs e)
        {
            if (tbFindemData.Text != "")
            {
                System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
                ((_frmSalesManage)f).dtgvKhachhang.DataSource = ObjCustomerDAO.Instance.FindCusomerData();
                this.Close();
            }
            else
            {
                if (checklang == "Họ Tên:")
                    MessageBox.Show("Nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Enter the customer name", "Notification", MessageBoxButtons.OK);

            }
        }
    }
}
