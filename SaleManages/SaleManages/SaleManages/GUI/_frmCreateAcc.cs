using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManages.GUI
{
    public partial class _frmCreateAcc : Form
    {
        public _frmCreateAcc()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void metroDateTime1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.Show("Ngày sinh", dateBirth);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng ký thành công , chờ quản lý duyệt để đăng nhập .", "Thông báo ", MessageBoxButtons.OK);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
            this.Close();
           
        }
    }
}
