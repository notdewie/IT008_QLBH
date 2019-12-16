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

namespace SaleManages.GUI
{
    public partial class _frmFindBillData : Form
    {
        public _frmFindBillData()
        {
            InitializeComponent();
        }

        private void btnFindnillData_Click(object sender, EventArgs e)
        {
           
            if (tbFindbillData.Text != "")
            {
                System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
                ((_frmSalesManage)f).dtgvHoadon.DataSource = ObjBillDAO.Instance.FindBillData();
                this.Close();
            }
            else MessageBox.Show("Nhập số hoá đơn", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
