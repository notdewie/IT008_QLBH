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
    public partial class _frmFindProductData : Form
    {
        public _frmFindProductData()
        {
            InitializeComponent();
        }

        private void btnFindproData_Click(object sender, EventArgs e)
        {
            if (tbFindproData.Text != "")
            {
                System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
                ((_frmSalesManage)f).dtgvSanpham.DataSource = ObjProductDAO.Instance.FindProductData();
                this.Close();
            }
            else MessageBox.Show("Nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK);
        }
        
    }
}
