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
using System.Resources;
using System.Globalization;

namespace SaleManages.GUI
{
    public partial class _frmFindEmployeesData : Form
    {
        string checklang;
        CultureInfo culture;
        public _frmFindEmployeesData()

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
            this.Text = rm.GetString("formTimNV", culture);
            lbFindemData.Text = rm.GetString("tenNV", culture);
        }

        private void btnFindemData_Click_1(object sender, EventArgs e)
        {
            if (tbFindemData.Text != "")
            {
                System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
                ((_frmSalesManage)f).dtgvNhanvien.DataSource = ObjEmployeesDAO.Instance.FindEmployeesData();
                this.Close();
            }
            else
            {
                if (checklang == "Họ Tên:")
                    MessageBox.Show("Nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Enter the employee name", "Notification", MessageBoxButtons.OK);
            }
        }
    }
}
