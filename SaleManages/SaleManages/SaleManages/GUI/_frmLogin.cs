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
using System.Resources;
using System.Globalization; 

namespace SaleManages.GUI
{
    public partial class _frmLogin : Form
    {
        CultureInfo culture;    
        public _frmLogin()
        {
            InitializeComponent();
           
            culture = CultureInfo.CurrentCulture;
            if (lbTitle.Text == "Đăng Nhập") SetLanguage("vi-VN");
            else SetLanguage("en-US");
            this.MouseDown += _frmLogin_MouseDown;
        }
        private void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("SaleManages.Resources.MyResource", typeof(_frmSalesManage).Assembly);
            lbTitle.Text = rm.GetString("login_dangnhap", culture);
            lbUsername.Text = rm.GetString("login_tendangnhap", culture);
            lbPass.Text = rm.GetString("login_matkhau", culture);
            btnLogin.Text = rm.GetString("login_btnLogin", culture);
            lbReg.Text = rm.GetString("login_btnReg", culture);
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
                    
                    if (LoginCheck())
                    {
                        _frmSalesManage f = new _frmSalesManage();
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                    
                }
        }
        bool LoginCheck()
        {
            return AccountDAO.Instance.LoginCheck();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void _frmLogin_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (lbUsername.Text == "Tên đăng nhập:")
            {
                if (MessageBox.Show("Bạn có muốn thoát chương trình ? ", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                if (MessageBox.Show("Are you sure ? ", "Alert", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                    e.Cancel = true;
                }
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
                if (lbUsername.Text == "Tên đăng nhập:")
                    epUser.SetError(tbUsername, "Vui lòng điền tên đăng nhập!");
                else epUser.SetError(tbUsername, "Please enter your username!");
                e.Cancel = false;
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
                tbPass.Invalidate();
                if (lbUsername.Text == "Tên đăng nhập:")
                    epPass.SetError(tbPass, "Vui lòng điền mật khẩu!");
                else epPass.SetError(tbPass, "Please enter your password!");
                e.Cancel = false;
            }
            else
            {
                e.Cancel = false;
                epPass.SetError(tbPass, null);
            }
        }

        private void btnVi_Click(object sender, EventArgs e)
        {
            SetLanguage("vi-VN");
        }

        private void btnEn_Click(object sender, EventArgs e)
        {
            SetLanguage("en-US");
        }

        private void tbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                ValidateChildren(ValidationConstraints.Enabled);
                if (!string.IsNullOrEmpty(tbUsername.Text))
                    if (!string.IsNullOrEmpty(tbPass.Text))
                    {
                       
                        if (LoginCheck())
                        {
                            _frmSalesManage f = new _frmSalesManage();
                            this.Hide();
                            f.ShowDialog();
                            this.Show();
                        }

                    }
            }
        }

        private void tbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                ValidateChildren(ValidationConstraints.Enabled);
                if (!string.IsNullOrEmpty(tbUsername.Text))
                    if (!string.IsNullOrEmpty(tbPass.Text))
                    {
                        string userName = tbUsername.Text;
                        string passWord = tbPass.Text;
                        if (LoginCheck())
                        {
                            _frmSalesManage f = new _frmSalesManage();
                            this.Hide();
                            f.ShowDialog();
                            this.Show();
                        }

                    }
            }
        }


    }
}
