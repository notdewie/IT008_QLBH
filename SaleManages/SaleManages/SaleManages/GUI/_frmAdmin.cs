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
    public partial class _frmAdmin : Form
    {
        string checklang;
        CultureInfo culture;
        public _frmAdmin()
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
            this.Text = rm.GetString("formAdmin", culture);
            label1.Text = rm.GetString("albTitle", culture);
            label2.Text = rm.GetString("sohd", culture);
            btnAdmin.Text = rm.GetString("btnaccept", culture);
        }

        private void _frmAdmin_Load(object sender, EventArgs e)
        {
            string query = "SELECT TAIKHOAN AS N'Tài Khoản',MATKHAU AS N'Mật Khẩu',TRANGTHAI AS N'Trạng Thái' FROM TAIKHOAN " +
                "WHERE TRANGTHAI = 0";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if(dt.Rows.Count>0)
            {
                dtgvAccount.DataSource = dt;
                tbAdmin.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Tài Khoản"));
            }
            else
            {
                if (checklang == "Họ Tên:")
                    MessageBox.Show("Không có tài khoản nào cần phê duyệt", "Thông báo", MessageBoxButtons.OK);
                else
                    MessageBox.Show("No accounts need approval", "Notification", MessageBoxButtons.OK);
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AccountDAO.Instance.Duyet();
        }
    }
}
