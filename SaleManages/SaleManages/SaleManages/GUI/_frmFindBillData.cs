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
    public partial class _frmFindBillData : Form
    {
        string checklang;
        CultureInfo culture;
        public _frmFindBillData()
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
            lbFindbillData.Text = rm.GetString("sohd", culture);
            this.Text = rm.GetString("formTimHD", culture);
        }

        private void btnFindnillData_Click(object sender, EventArgs e)
        {

            if (tbFindbillData.Text != "")
            {
                System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
                ((_frmSalesManage)f).dtgvHoadon.DataSource = ObjBillDAO.Instance.FindBillData();
                this.Close();
            }
            else
            {
                if (checklang == "Họ Tên:")
                    MessageBox.Show("Nhập số hoá đơn", "Thông báo", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Enter the invoice number", "Notification", MessageBoxButtons.OK);
            }
        }
    }
}
