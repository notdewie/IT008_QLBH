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

        private void metroDateTime1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.Show("Ngày sinh", dateBirth);
        }

       

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
            this.Close();
           
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsername.Text))
            {
                e.Cancel = true;
                tbUsername.Focus();
                epUserName.SetError(tbUsername, "Vui lòng điền tên đăng nhập!");
            }
            else
            {
                e.Cancel = false;
                epUserName.SetError(tbUsername, null);
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
                e.Cancel = true;
                tbName.Focus();
                epFullName.SetError(tbName, "Vui lòng điền họ tên!");
            }
            else
            {
                e.Cancel = false;
                epFullName.SetError(tbName, null);
            }
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbEmail.Text))
            {
                e.Cancel = true;
                tbEmail.Focus();
                epEMail.SetError(tbEmail, "Vui lòng điền email!");
            }
            else
            {
                e.Cancel = false;
                epEMail.SetError(tbEmail, null);
            }
        }

        private void tbPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPass.Text))
            {
                e.Cancel = true;
                tbPass.Focus();
                epPass.SetError(tbPass, "Vui lòng điền mật khẩu!");
            }
            else
            {
                e.Cancel = false;
                epPass.SetError(tbPass, null);
            }
        }

        private void tbCheckPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbCheckPass.Text))
            {
                e.Cancel = true;
                tbCheckPass.Focus();
                epCheckPass.SetError(tbCheckPass, "Vui lòng điền lại mật khẩu!");
            }
            else
            {
                e.Cancel = false;
                epCheckPass.SetError(tbCheckPass, null);
            }
        }
        
        private void btnReg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsername.Text))
                MessageBox.Show("Vui lòng điền tên đăng nhập", "Thông báo", MessageBoxButtons.OK);
            else 
                if (string.IsNullOrEmpty(tbName.Text))
                    MessageBox.Show("Vui lòng điền họ và tên", "Thông báo", MessageBoxButtons.OK);
                else 
                    if (string.IsNullOrEmpty(tbEmail.Text))
                        MessageBox.Show("Vui lòng điền email", "Thông báo", MessageBoxButtons.OK);
                    else 
                        if (string.IsNullOrEmpty(tbPass.Text))
                            MessageBox.Show("Vui lòng điền mật khẩu", "Thông báo", MessageBoxButtons.OK);
                        else 
                            if (string.IsNullOrEmpty(tbCheckPass.Text))
                                MessageBox.Show("Vui lòng điền lại mật khẩu", "Thông báo", MessageBoxButtons.OK);
                            else
                            {
                                MessageBox.Show("Đăng kí thành công, xin chờ quản lí duyệt", "Thông báo", MessageBoxButtons.OK);
                            }
                        
                    
                
            
             
        }
    }
}
