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
    public partial class _frmLogin : Form
    {
        public _frmLogin()
        {
            InitializeComponent();
            this.MouseDown += _frmLogin_MouseDown;
        }
        //Drag Move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void _frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ValidateChildren(ValidationConstraints.Enabled);
            if (!string.IsNullOrEmpty(tbUsername.Text))
                if (!string.IsNullOrEmpty(tbPass.Text))
                {
                    string userName = tbUsername.Text;
                    string passWord = tbPass.Text;
                    /*if (LoginCheck(userName,passWord))
                    {
                        SalesManage f = new SalesManage();
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu !", "Thông báo!", MessageBoxButtons.OK);
                    }*/
                    _frmSalesManage f = new _frmSalesManage();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
        }
        bool LoginCheck(string userName, string passWord)
        {
            return AccountDAO.Instance.LoginCheck(userName, passWord);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void f(object sender, EventArgs e)
        {

        }

        private void _frmLogin_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ? ", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void lbReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _frmCreateAcc f = new _frmCreateAcc();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsername.Text))
            {
                e.Cancel = true;
                tbUsername.Focus();
                epUser.SetError(tbUsername, "Vui lòng điền tên đăng nhập!");
            }
            else
            {
                e.Cancel = false;
                epUser.SetError(tbUsername, null);
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
    }
}
