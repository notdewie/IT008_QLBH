using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaleManages.DTO;
using System.Data;
using System.Data.SqlClient;
using SaleManages.DAO;
using SaleManages.GUI;
using SaleManages.DTO;
using System.Windows.Forms;

namespace SaleManages.DAO
{
    public class ObjCustomerDAO
    {
        private static ObjCustomerDAO instance;

        public static ObjCustomerDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ObjCustomerDAO();
                }
                return instance;
            }
            set { instance = value; }
        }
        private ObjCustomerDAO() { }

        public ObjCustomer customer = new ObjCustomer();
        string LoadQuery = "SELECT * FROM KHACHHANG";
        public DataTable LoadCustomerData()
        {

            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(LoadQuery);
            return data;

        }
        
        bool CheckMaKH(string MaKH)
        {
            string query = "SELECT MAKH FROM KHACHHANG WHERE MAKH = '" + MaKH + "' ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
                return false;
            else return true;
        }
        public void Add()
        {
            
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
            string tbname = ((_frmSalesManage)f).tbNameKh.Text;
            string tbmaso = ((_frmSalesManage)f).tbCodeKh.Text;
            string tbdc = ((_frmSalesManage)f).tbAddKh.Text;
            string tbemail = ((_frmSalesManage)f).tbEmailKh.Text;
            string tbsdt = ((_frmSalesManage)f).tbNameKh.Text;
            string tbbirth = ((_frmSalesManage)f).dateKh.Value.ToString();
            if(((_frmSalesManage)f).rbNam.Checked == true)
            {
                customer.Sex = "NAM";
            }
            else if (((_frmSalesManage)f).rbNu.Checked == true)
            {
                customer.Sex = "NU";
            }
            else 
            {
                customer.Sex = "KHAC";
            }
            if (((_frmSalesManage)f).radioButton4.Checked == true)
            {
                customer.Level = "1";
            }
            else if (((_frmSalesManage)f).radioButton5.Checked == true)
            {
                customer.Level = "2";
            }
            else 
            {
                customer.Level = "3";
            }
            customer.Name = tbname;
            customer.Code = tbmaso;
            customer.Birthday = tbbirth;
            customer.Address = tbdc;
            customer.Email = tbemail;
            customer.Phone = tbsdt;
            int len = customer.Code.Length;
            if (len < 5 && len >0)
            {
                if (CheckMaKH(customer.Code) == true)
                {
                    string AddQuery = "INSERT INTO KHACHHANG(MAKH,HOTEN,DCHI,SODT,NGSINH,GT,Email,MucDo)" +
                        "VALUES('" + customer.Code + "', '" + customer.Name + "', '" + customer.Address + "', '" + customer.Phone + "', '" + customer.Birthday + "', '" + customer.Sex + "', '" + customer.Email + "', '" + customer.Level + "')";
                    int result = DataProvider.Instance.ExecuteNonQuery(AddQuery);
                    if (result > 0)
                    {
                        MessageBox.Show("Khách hàng đã được thêm,bấm xem để xem dữ liệu mới", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else MessageBox.Show("Mã khách hàng đã tồn tại", "Thông báo", MessageBoxButtons.OK);
            }
            else MessageBox.Show("Mã khách hàng phải nhỏ hơn 5 và lớn hơn 0 kí tự ", "Thông báo", MessageBoxButtons.OK);
        }
        public void Delete()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
            string tbmaso = ((_frmSalesManage)f).tbCodeKh.Text;
            string DeleteQuery = "DELETE FROM KHACHHANG WHERE MAKH = '"+tbmaso+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(DeleteQuery);
            if (result > 0)
            {
                MessageBox.Show("Khách hàng đã bị xoá,bấm xem để xem dữ liệu mới", "Thông báo", MessageBoxButtons.OK);
            }
            LoadCustomerData();
        }
        public void Update()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
            string tbname = ((_frmSalesManage)f).tbNameKh.Text;
            string tbmaso = ((_frmSalesManage)f).tbCodeKh.Text;
            string tbdc = ((_frmSalesManage)f).tbAddKh.Text;
            string tbemail = ((_frmSalesManage)f).tbEmailKh.Text;
            string tbsdt = ((_frmSalesManage)f).tbPhone.Text;
            string tbbirth = ((_frmSalesManage)f).dateKh.Value.ToString();
            if (((_frmSalesManage)f).rbNam.Checked == true)
            {
                customer.Sex = "NAM";
            }
            else if (((_frmSalesManage)f).rbNu.Checked == true)
            {
                customer.Sex = "NU";
            }
            else
            {
                customer.Sex = "KHAC";
            }
            if (((_frmSalesManage)f).radioButton4.Checked == true)
            {
                customer.Level = "1";
            }
            else if (((_frmSalesManage)f).radioButton5.Checked == true)
            {
                customer.Level = "2";
            }
            else
            {
                customer.Level = "3";
            }
            customer.Name = tbname;
            customer.Code = tbmaso;
            customer.Birthday = tbbirth;
            customer.Address = tbdc;
            customer.Email = tbemail;
            customer.Phone = tbsdt;
            string UpdateQuery = "UPDATE KHACHHANG " +
                "SET HOTEN = '" + customer.Name + "',DCHI = '" + customer.Address + "',SODT = '" + customer.Phone + "',NGSINH = '" + customer.Birthday + "',GT = '" + customer.Sex + "',Email = '" + customer.Email + "',MucDo = '" + customer.Level + "'" +
                "WHERE MAKH = '"+customer.Code+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(UpdateQuery);
            if (result > 0)
            {
                MessageBox.Show("Khách hàng đã được sửa,bấm Xem để xem dữ liệu mới", "Thông báo", MessageBoxButtons.OK);
            }
           
        }
        public DataTable FindCusomerData()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmFindCustomerData"];
            string nameCustomer = ((_frmFindCustomerData)f).tbFindemData.Text;
            string FindQuery = "SELECT * FROM KHACHHANG " +
                   "WHERE HOTEN = '"+nameCustomer+"' ";
            DataTable data = DataProvider.Instance.ExecuteQuery(FindQuery);
            return data;
        }
        public void Bindings()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
            ((_frmSalesManage)f).tbAddKh.DataBindings.Clear();
            ((_frmSalesManage)f).tbNameKh.DataBindings.Clear();
            ((_frmSalesManage)f).tbCodeKh.DataBindings.Clear();
            ((_frmSalesManage)f).tbEmailKh.DataBindings.Clear();
            ((_frmSalesManage)f).tbPhone.DataBindings.Clear();
            ((_frmSalesManage)f).dateKh.DataBindings.Clear();
            ((_frmSalesManage)f).tbNameKh.DataBindings.Add(new Binding("Text", ((_frmSalesManage)f).dtgvKhachhang.DataSource, "HOTEN"));
            ((_frmSalesManage)f).tbCodeKh.DataBindings.Add(new Binding("Text", ((_frmSalesManage)f).dtgvKhachhang.DataSource, "MAKH"));
            ((_frmSalesManage)f).tbEmailKh.DataBindings.Add(new Binding("Text", ((_frmSalesManage)f).dtgvKhachhang.DataSource, "Email"));
            ((_frmSalesManage)f).tbPhone.DataBindings.Add(new Binding("Text", ((_frmSalesManage)f).dtgvKhachhang.DataSource, "SODT"));
            ((_frmSalesManage)f).dateKh.DataBindings.Add(new Binding("value", ((_frmSalesManage)f).dtgvKhachhang.DataSource, "NGSINH"));
            ((_frmSalesManage)f).tbAddKh.DataBindings.Add(new Binding("Text", ((_frmSalesManage)f).dtgvKhachhang.DataSource, "DCHI"));
            string MaKH = ((_frmSalesManage)f).tbCodeKh.Text;
            string query1 = "SELECT GT FROM KHACHHANG WHERE MAKH = N'" + MaKH + "' ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query1);
            string query2 = "SELECT MucDo FROM KHACHHANG WHERE MAKH = N'" + MaKH + "' ";
            DataTable dt1 = DataProvider.Instance.ExecuteQuery(query2);
            if (dt.Rows.Count > 0 && dt1.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                string sex = dr.ItemArray[0].ToString();

                DataRow dr1 = dt1.Rows[0];
                string MucDo = dr1.ItemArray[0].ToString();
                int mucdo = Convert.ToInt32(MucDo);
                if (sex == "NAM")
                {
                    ((_frmSalesManage)f).rbNam.Checked = true;
                }
                else if (sex == "NU")
                {
                    ((_frmSalesManage)f).rbNu.Checked = true;
                }
                else { ((_frmSalesManage)f).rbElse.Checked = true; }

                if (mucdo == 1)
                {
                    ((_frmSalesManage)f).radioButton4.Checked = true;
                }
                else if (mucdo == 2)
                {
                    ((_frmSalesManage)f).radioButton5.Checked = true;
                }
                else { ((_frmSalesManage)f).radioButton6.Checked = true; }
            ((_frmSalesManage)f).DataBindings.Clear();
            }
        }
    }
}
