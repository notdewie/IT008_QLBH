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
    public partial class _frmAdmin : Form
    {
        public _frmAdmin()
        {
            InitializeComponent();
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
                MessageBox.Show("Không có tài khoản nào cần phê duyệt", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AccountDAO.Instance.Duyet();
        }
    }
}
