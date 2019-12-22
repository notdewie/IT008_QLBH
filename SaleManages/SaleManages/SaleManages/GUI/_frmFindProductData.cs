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
    public partial class _frmFindProductData : Form
    {
        string checklang;
        CultureInfo culture;
        public _frmFindProductData()
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
            this.Text = rm.GetString("formTimSP", culture);
            lbFindproData.Text = rm.GetString("tensp", culture);
        }

        private void btnFindproData_Click_1(object sender, EventArgs e)
        {
            if (tbFindproData.Text != "")
            {
                System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
                ((_frmSalesManage)f).dtgvSanpham.DataSource = ObjProductDAO.Instance.FindProductData();
                this.Close();
            }
            else
            {
                if (checklang == "Họ Tên:")
                    MessageBox.Show("Nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Enter the product name", "Notification", MessageBoxButtons.OK);
            }
        }
    }
}
