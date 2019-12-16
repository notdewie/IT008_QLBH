using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaleManages.DAO;
using System.Windows.Forms;
using System.Threading;

namespace SaleManages.GUI
{
    public partial class _frmDetail : Form
    {
        public _frmDetail()
        {
            InitializeComponent();
            DataTable data = ObjBillDAO.Instance.LoadBillDetail();
            if (data.Rows.Count > 0)
            {
                dtgvDetail.DataSource = data;
            }
            else
            {

                MessageBox.Show("CTHD trống", "Thông báo", MessageBoxButtons.OK);

            }

        }
        public _frmDetail(int a)
        {
            InitializeComponent();
            DataTable data = new DataTable();
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmListBill"];
            string SoHD = ((_frmListBill)f).tbSoHD_ViewBill.Text;
            
            if (SoHD != "")
            {
                string LoadQuery = "SELECT SOHD AS N'Số Hoá Đơn' , MASP AS N'Mã Sản Phẩm' ,SL AS N'Số Lượng' " +
                    "FROM CTHD " +
                    "WHERE SOHD = '" + SoHD + "' ";
                data = DataProvider.Instance.ExecuteQuery(LoadQuery);
                dtgvDetail.DataSource = data;
            }
        }
        private void _frmDetail_Load(object sender, EventArgs e)
        {

            Thread.Sleep(100);
            ObjBillDAO.Instance.BindingsBillDetail();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ObjBillDAO.Instance.Add_BillDetail();
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            ObjBillDAO.Instance.Update_BillDetail();
        }

        private void btnEra_Click(object sender, EventArgs e)
        {
            ObjBillDAO.Instance.Delete_BillDetail();
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
           
        }
    }
}
