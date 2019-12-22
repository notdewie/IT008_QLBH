using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;
using SaleManages.DAO;

namespace SaleManages.GUI
{
    public partial class _frmCreateAcc : Form
    {
        string checklang;
        CultureInfo culture;
        public _frmCreateAcc()
        {
            InitializeComponent();
            
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmLogin"];
            checklang = ((_frmLogin)f).lbTitle.Text;
            culture = CultureInfo.CurrentCulture;
            if (checklang == "Đăng Nhập") SetLanguage("vi-VN");
            else SetLanguage("en-US");
        }
        private void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("SaleManages.Resources.MyResource", typeof(_frmLogin).Assembly);
            lbTitle.Text = rm.GetString("reg_lbTitle", culture);
            tbUsername.Text = rm.GetString("reg_tbUsername", culture);
            tbName.Text = rm.GetString("reg_tbName", culture);
            tbEmail.Text = rm.GetString("reg_tbEmail", culture);
            tbPass.Text = rm.GetString("reg_tbPass", culture);
            tbCheckPass.Text = rm.GetString("reg_tbCheckPass", culture);
            btnReg.Text = rm.GetString("reg_btnReg", culture);
            rbMale.Text = rm.GetString("reg_rbMale", culture);
            rbFemale.Text = rm.GetString("reg_rbFemale", culture);
            rbElse.Text = rm.GetString("reg_rbElse", culture);
            lbAccept.Text = rm.GetString("reg_lbAccept", culture);
            lbUseTerm.Text = rm.GetString("reg_lbUseTerm", culture);
            btnReg.Text = rm.GetString("reg_lbTitle", culture);
        }

        private void metroDateTime1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            if (checklang == "Đăng Nhập")
                tooltip.Show("Ngày sinh", dateBirth);
            else
                tooltip.Show("Date of birth", dateBirth);
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
                if (checklang == "Đăng Nhập")
                    epUserName.SetError(tbUsername, "Vui lòng điền tên đăng nhập!");
                else
                    epUserName.SetError(tbUsername, "Please enter your username!");
                e.Cancel = false;
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
                if (checklang == "Đăng Nhập")
                    epFullName.SetError(tbName, "Vui lòng điền họ tên!");
                else
                    epFullName.SetError(tbName, "Please enter your full name!");
                e.Cancel = false;
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
                if (checklang == "Đăng Nhập")
                    epEMail.SetError(tbEmail, "Vui lòng điền email!");
                else
                    epEMail.SetError(tbEmail, "Please enter your email!");
                e.Cancel = false;
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
                if (checklang == "Đăng Nhập")
                    epPass.SetError(tbPass, "Vui lòng điền mật khẩu!");
                else
                    epPass.SetError(tbPass, "Please enter the password!");
                e.Cancel = false;
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
                if (checklang == "Đăng Nhập")
                    epCheckPass.SetError(tbCheckPass, "Vui lòng điền lại mật khẩu!");
                else
                    epCheckPass.SetError(tbCheckPass, "Please enter your password again!");
                e.Cancel = false;
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
            {
                if (checklang == "Đăng Nhập")
                    MessageBox.Show("Vui lòng điền tên đăng nhập", "Thông báo", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Please enter your username", "Notification", MessageBoxButtons.OK);
            }
            else
                if (string.IsNullOrEmpty(tbName.Text))
            {
                if (checklang == "Đăng Nhập")
                    MessageBox.Show("Vui lòng điền họ và tên", "Thông báo", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Please enter your full name", "Notification", MessageBoxButtons.OK);
            }
            else
                    if (string.IsNullOrEmpty(tbEmail.Text))
            {
                if (checklang == "Đăng Nhập")
                    MessageBox.Show("Vui lòng điền email", "Thông báo", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Please enter your email", "Notification", MessageBoxButtons.OK);
            }
            else
                        if (string.IsNullOrEmpty(tbPass.Text))
            {
                if (checklang == "Đăng Nhập")
                    MessageBox.Show("Vui lòng điền mật khẩu", "Thông báo", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Please enter the password", "Notification", MessageBoxButtons.OK);
            }
            else
                            if (string.IsNullOrEmpty(tbCheckPass.Text))
            {
                if (checklang == "Đăng Nhập")
                    MessageBox.Show("Vui lòng điền lại mật khẩu", "Thông báo", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Please enter your password again", "Notification", MessageBoxButtons.OK);
            }
            else
            {
                AccountDAO.Instance.CreateAcc();
            }
                        
                    
                
            
             
        }

        private void lbUseTerm_Click(object sender, EventArgs e)
        {
            _frmUseTerm f = new _frmUseTerm();
            f.ShowDialog();
        }
    }
}
