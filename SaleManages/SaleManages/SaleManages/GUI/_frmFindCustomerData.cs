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
    public partial class _frmFindCustomerData : Form
    {
        public _frmFindCustomerData()
        {
            InitializeComponent();
        }

        private void btnFindcusData_Click(object sender, EventArgs e)
        {
            if (tbFindemData.Text != "")
            {
                System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
                ((_frmSalesManage)f).dtgvKhachhang.DataSource = ObjCustomerDAO.Instance.FindCusomerData();
                this.Close();
            }
            else MessageBox.Show("Nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
