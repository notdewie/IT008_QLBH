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
    public partial class _frmFindEmployeesData : Form
    {
        public _frmFindEmployeesData()
        {
            InitializeComponent();
        }

        private void btnFindemData_Click(object sender, EventArgs e)
        {
            if (tbFindemData.Text != "")
            {
                System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
                ((_frmSalesManage)f).dtgvNhanvien.DataSource = ObjEmployeesDAO.Instance.FindEmployeesData();
                this.Close();
            }
            else MessageBox.Show("Nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
