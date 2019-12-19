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
        int Check = 0;
        public _frmDetail()
        {
            InitializeComponent();
            DataTable data = ObjBillDAO.Instance.LoadBillDetail();
            if (data.Rows.Count > 0)
            {
                Check = 1;
                dtgvDetail.DataSource = data;  
            }
            else
            {
                Check = 0;
            }

        }
        public _frmDetail(int a)
        {
            InitializeComponent();
            DataTable data = new DataTable();
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmListBill"];
            string SoHD = ((_frmListBill)f).tbSoHD_ViewBill.Text;
            string LoadQuery = "SELECT * " +
                    "FROM CTHD " +
                    "WHERE SOHD = '" + SoHD + "' ";
            data = DataProvider.Instance.ExecuteQuery(LoadQuery);
            dtgvDetail.DataSource = data;
            Check = 1;
        }
        private void _frmDetail_Load(object sender, EventArgs e)
        {
            if (Check == 1)
            {
                ObjBillDAO.Instance.BindingsBillDetail();
            }
            else MessageBox.Show("CTHD trống", "Thông báo", MessageBoxButtons.OK);
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

        
    }
}
