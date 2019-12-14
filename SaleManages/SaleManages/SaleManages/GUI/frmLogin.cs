﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaleManages.DAO;
using SaleManages.GUI;

namespace SaleManages
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.MouseDown += Login_MouseDown;
            _frmLogin form2;
            form2 = new _frmLogin();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
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
            SalesManage f = new SalesManage();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        bool LoginCheck(string userName,string passWord)
        {
            return AccountDAO.Instance.LoginCheck(userName,passWord);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình ? ","Thông báo",MessageBoxButtons.OKCancel)!=System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }


        private void lbLogin_Click(object sender, EventArgs e)
        {

        }

        private void lbPassWord_Click(object sender, EventArgs e)
        {

        }

        //Drag Move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lbReg_Click(object sender, EventArgs e)
        {
            frmCreateAcc f = new frmCreateAcc();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
