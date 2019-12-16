using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SaleManages.DTO;
using System.Windows.Forms;
using SaleManages.GUI;

namespace SaleManages.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null)
                {
                    instance = new AccountDAO();
                }
                return instance;
            }
            private set { instance = value; }
        }
        private AccountDAO() { }

        Account account = new Account();
        
        public bool LoginCheck()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmLogin"];
            string userName = ((_frmLogin)f).tbUsername.Text;
            string passWord = ((_frmLogin)f).tbPass.Text;
            string query = "SELECT TRANGTHAI FROM TAIKHOAN WHERE TAIKHOAN = N'" + userName + "' AND MATKHAU = '" + passWord + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            if (result.Rows.Count > 0)
            {
                DataRow dr = result.Rows[0];

                if (dr.ItemArray[0].ToString() != "1")
                {
                    MessageBox.Show("Tài khoản chưa được phê duyệt", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu !", "Thông báo!", MessageBoxButtons.OK);
                return false;
            }
            
        }

        public void LoadInfoAcc()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmLogin"];
            string userName = ((_frmLogin)f).tbUsername.Text;
            string passWord = ((_frmLogin)f).tbPass.Text;
            string query = "SELECT * FROM TAIKHOAN WHERE TAIKHOAN = N'" + userName + "' AND MATKHAU = '" + passWord + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            DataRow dr = result.Rows[0];
            System.Windows.Forms.Form f1 = System.Windows.Forms.Application.OpenForms["_frmInfoAcc"];
            ((_frmInfoAcc)f1).lbNameS.Text = dr.ItemArray[1].ToString();
            ((_frmInfoAcc)f1).lbSexS.Text = dr.ItemArray[2].ToString();
            ((_frmInfoAcc)f1).lbBirthS.Text = dr.ItemArray[5].ToString();
            ((_frmInfoAcc)f1).lbEmailS.Text = dr.ItemArray[3].ToString();
            ((_frmInfoAcc)f1).lbAddressS.Text = dr.ItemArray[6].ToString();
            ((_frmInfoAcc)f1).lbPhoneS.Text = dr.ItemArray[7].ToString();
        }
        public int ChangePass()
        {
            int result = 0;
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmChangePass"];
            System.Windows.Forms.Form f1 = System.Windows.Forms.Application.OpenForms["_frmLogin"];
            string userName = ((_frmLogin)f1).tbUsername.Text;
            string passWord = ((_frmLogin)f1).tbPass.Text;
            string Pass = ((_frmChangePass)f).tbOldPass.Text;
            string newPass = ((_frmChangePass)f).tbNewPass.Text;
            string RePass = ((_frmChangePass)f).tbCheckPass.Text;
            if (newPass != RePass)
            {
                MessageBox.Show("Xác nhận mật khẩu không đúng","Thông báo",MessageBoxButtons.OK);
            }
            else
            {
                if (Pass == passWord)
                {
                    string ChangePassQuery = "UPDATE TAIKHOAN " +
                        "SET MATKHAU = '" + newPass + "' " +
                        "WHERE TAIKHOAN = '" + userName + "' ";
                    result = DataProvider.Instance.ExecuteNonQuery(ChangePassQuery);
                    
                }
                else MessageBox.Show("Nhập sai mật khẩu cũ", "Thông báo", MessageBoxButtons.OK);
            }
            return result;
        }
        public void CreateAcc()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmCreateAcc"];
            account.UserName = ((_frmCreateAcc)f).tbUsername.Text;
            account.PassWord = ((_frmCreateAcc)f).tbPass.Text;
            account.Name = ((_frmCreateAcc)f).tbName.Text;
            account.Email = ((_frmCreateAcc)f).tbEmail.Text;
            account.Birth = ((_frmCreateAcc)f).dateBirth.Value.ToString();
            account.status = false;
            string CheckQuery = "SELECT TAIKHOAN FROM TAIKHOAN WHERE TAIKHOAN = '" + account.UserName + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(CheckQuery);
            if (result.Rows.Count > 0)
            {
                MessageBox.Show("Tài khoản đã tồn tại ", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {

                string CreateAccQuery = "INSERT INTO TAIKHOAN(TAIKHOAN,HOTEN,Email,MATKHAU,NGSINH,TRANGTHAI) " +
                "VALUES('" + account.UserName + "','" + account.Name + "','" + account.Email + "','" + account.PassWord + "','" + account.Birth + "','0' )";
                int rs = DataProvider.Instance.ExecuteNonQuery(CreateAccQuery);
                if (rs > 0)
                {
                    MessageBox.Show("Đăng ký thành công , chờ quản lý duyệt để đăng nhập ", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
        public void UpdateAcc()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmUpdateInfo"];
            string Name = ((_frmUpdateInfo)f).tbName.Text;
            string Sex = ((_frmUpdateInfo)f).tbSex.Text;
            string Birth = ((_frmUpdateInfo)f).dateBirth.Value.ToString();
            string Address = ((_frmUpdateInfo)f).tbAddress.Text;
            string Email = ((_frmUpdateInfo)f).tbEmail.Text;
            string SDT = ((_frmUpdateInfo)f).tbPhone.Text;
            string UpdateQuery = "UPDATE TAIKHOAN " +
                "SET HOTEN = '"+Name+"' , Email = '"+Email+"', GT = '"+Sex+"', NGSINH = '"+Birth+"',DCHI = '"+Address+"',SDT = '"+SDT+"' ";
            int rs = DataProvider.Instance.ExecuteNonQuery(UpdateQuery);
            if (rs > 0) MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
        }

        public void Duyet()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmAdmin"];
            string TK = ((_frmAdmin)f).tbAdmin.Text;
            string query = "UPDATE TAIKHOAN " +
                "SET TRANGTHAI = 1 " +
                "WHERE TAIKHOAN = '"+TK+"' ";
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            if(rs>0)
            {
                MessageBox.Show("Tài khoản đã được phê duyệt","Thông báo",MessageBoxButtons.OK);
            }
        }
    }
}
