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
    public partial class _frmListBill : Form
    {
        string checklang;
        CultureInfo culture;
        public _frmListBill()
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
            label2.Text = rm.GetString("sohd", culture);
            bunifuFlatButton1.Text = rm.GetString("xemthem", culture);
            this.Text = rm.GetString("formList", culture);
        }

        private void _frmListBill_Load(object sender, EventArgs e)
        {

            DataTable data = new DataTable();
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
            string MaKH = ((_frmSalesManage)f).tbCodeKh.Text;
            string LoadQuery = "SELECT SOHD AS N'Số Hoá Đơn' ,MAKH AS N'Mã Khách Hàng', MANV AS N'Mã Nhân Viên' ," +
                   "TRIGIA AS N'Trị Giá',NGHD AS N'Ngày Hoá Đơn' FROM HOADON " +
                   "WHERE MAKH = '" + MaKH + "' ";
            data = DataProvider.Instance.ExecuteQuery(LoadQuery);
            if (data.Rows.Count > 0)
            {
                dtgvViewBill.DataSource = data;
                tbSoHD_ViewBill.DataBindings.Add(new Binding("Text", dtgvViewBill.DataSource, "Số Hoá Đơn"));
            }
            else
            {
                if (checklang == "Họ Tên:")
                    MessageBox.Show("Danh sách hoá đơn trống", "Thông báo", MessageBoxButtons.OK);
                else
                    MessageBox.Show("The invoice list is empty", "Notification", MessageBoxButtons.OK);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            _frmDetail f = new _frmDetail(1);
            f.ShowDialog();
        }
    }
}
