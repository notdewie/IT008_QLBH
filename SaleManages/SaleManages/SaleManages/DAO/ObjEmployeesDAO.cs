using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaleManages.DTO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SaleManages.GUI;

namespace SaleManages.DAO
{
    public class ObjEmployeesDAO
    {
        private static ObjEmployeesDAO instance;

        public static ObjEmployeesDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ObjEmployeesDAO();
                }
                return instance;
            }
            set { instance = value; }
        }
        private ObjEmployeesDAO() { }
        public ObjEmployees employees = new ObjEmployees();
        string LoadQuery = "SELECT * FROM NHANVIEN";
        public DataTable LoadEmployeesData()
        {

            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(LoadQuery);
            return data;

        }
        bool CheckMaNV(string MaNV)
        {
            string query = "SELECT MANV FROM NHANVIEN WHERE MANV = '" + MaNV + "' ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
                return false;
            else return true;
        }
        public void Add()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
            string tbname = ((_frmSalesManage)f).tbNameNv.Text;
            string tbmaso = ((_frmSalesManage)f).tbCodeNv.Text;
            string tbdc = ((_frmSalesManage)f).tbAddNv.Text;
            string tbemail = ((_frmSalesManage)f).tbEmailNv.Text;
            string tbsdt = ((_frmSalesManage)f).tbPhoneNv.Text;
            string tbbirth = ((_frmSalesManage)f).dateNv.Value.ToString();
            string tbbegin = ((_frmSalesManage)f).dateBegin.Value.ToString();
            if (((_frmSalesManage)f).rbNamNV.Checked == true)
            {
                employees.Sex = "NAM";
            }
            else if (((_frmSalesManage)f).rbNuNV.Checked == true)
            {
                employees.Sex = "NU";
            }
            else
            {
                employees.Sex = "KHAC";
            }
            if (((_frmSalesManage)f).rbMuc1.Checked == true)
            {
                employees.Level = "1";
            }
            else if (((_frmSalesManage)f).rbMuc2.Checked == true)
            {
                employees.Level = "2";
            }
            else
            {
                employees.Level = "3";
            }
            employees.Name = tbname;
            employees.Code = tbmaso;
            employees.Birthday = tbbirth;
            employees.Address = tbdc;
            employees.Email = tbemail;
            employees.Phone = tbsdt;
            employees.DayToDo = tbbegin;
            if (employees.Code.Length < 5)
            {
                if (CheckMaNV(employees.Code) == true)
                {
                    string AddQuery = "INSERT INTO NHANVIEN(MANV,HOTEN,DCHI,SODT,NGSINH,NGVL,GT,Email,MucDo)" +
                        "VALUES('" + employees.Code + "', '" + employees.Name + "', '" + employees.Address + "', '" + employees.Phone + "', '" + employees.Birthday + "','" + employees.DayToDo + "', '" + employees.Sex + "', '" + employees.Email + "', '" + employees.Level + "')";
                    int result = DataProvider.Instance.ExecuteNonQuery(AddQuery);
                    if (result > 0)
                    {
                        MessageBox.Show("Nhân viên đã được thêm,bấm xem để xem dữ liệu mới", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else MessageBox.Show("Mã nhân viên đã tồn tại", "Thông báp", MessageBoxButtons.OK);
            }
            else MessageBox.Show("Mã nhân viên phải nhỏ hơn 5 kí tự", "Thông báo", MessageBoxButtons.OK);
        }
        public void Delete()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
            string tbmaso = ((_frmSalesManage)f).tbCodeNv.Text;
            string CheckQuery = "SELECT * " +
                "FROM HOADON WHERE MANV = '"+tbmaso+"' ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(CheckQuery);
            if (dt.Rows.Count == 0)
            {
                string DeleteQuery = "DELETE FROM NHANVIEN WHERE MANV = '" + tbmaso + "'";
                int result = DataProvider.Instance.ExecuteNonQuery(DeleteQuery);
                if (result > 0)
                {
                    MessageBox.Show("Nhân viên đã bị xoá,bấm xem để xem dữ liệu mới", "Thông báo", MessageBoxButtons.OK);
                }
            }
            
        }
        public void Update()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
            string tbname = ((_frmSalesManage)f).tbNameNv.Text;
            string tbmaso = ((_frmSalesManage)f).tbCodeNv.Text;
            string tbdc = ((_frmSalesManage)f).tbAddNv.Text;
            string tbemail = ((_frmSalesManage)f).tbEmailNv.Text;
            string tbsdt = ((_frmSalesManage)f).tbPhoneNv.Text;
            string tbbirth = ((_frmSalesManage)f).dateNv.Value.ToString();
            string tbbegin = ((_frmSalesManage)f).dateBegin.Value.ToString();
            if (((_frmSalesManage)f).rbNamNV.Checked == true)
            {
                employees.Sex = "NAM";
            }
            else if (((_frmSalesManage)f).rbNuNV.Checked == true)
            {
                employees.Sex = "NU";
            }
            else
            {
                employees.Sex = "KHAC";
            }
            if (((_frmSalesManage)f).rbMuc1.Checked == true)
            {
                employees.Level = "1";
            }
            else if (((_frmSalesManage)f).rbMuc2.Checked == true)
            {
                employees.Level = "2";
            }
            else
            {
                employees.Level = "3";
            }
            employees.Name = tbname;
            employees.Code = tbmaso;
            employees.Birthday = tbbirth;
            employees.Address = tbdc;
            employees.Email = tbemail;
            employees.Phone = tbsdt;
            employees.DayToDo = tbbegin;

            string AddQuery = "UPDATE NHANVIEN " +
                "SET MANV = '" + employees.Code + "', HOTEN = '" + employees.Name + "',DCHI = '" + employees.Address + "',SODT = '" + employees.Phone + "', NGSINH = '" + employees.Birthday + "',NGVL = '" + employees.DayToDo + "', GT = '" + employees.Sex + "', Email = '" + employees.Email + "', MucDo ='" + employees.Level + "'" +
                "WHERE MANV = '" + employees.Code + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(AddQuery);
            if (result > 0)
            {
                MessageBox.Show("Nhân viên đã được thêm,bấm xem để xem dữ liệu mới", "Thông báo", MessageBoxButtons.OK);
            }

        }
        public DataTable FindEmployeesData()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmFindEmployeesData"];
            string nameEmployees = ((_frmFindEmployeesData)f).tbFindemData.Text;
            string FindQuery = "SELECT MANV AS N'Mã Nhân Viên',HOTEN AS N'Họ Tên',SODT AS N'Số Điện Thoại'," +
                    "DCHI AS N'Địa Chỉ',NGSINH AS N'Ngày Sinh', NGVL AS N'Ngày Vào Làm'," +
                    "GT AS N'Giới Tính',Email ,MucDO AS N'Mức độ' FROM NHANVIEN " +
                   "WHERE HOTEN = '" + nameEmployees + "' ";
            DataTable data = DataProvider.Instance.ExecuteQuery(FindQuery);
            return data;
        }
        public void Bindings()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
            ((_frmSalesManage)f).tbAddNv.DataBindings.Clear();
            ((_frmSalesManage)f).tbNameNv.DataBindings.Clear();
            ((_frmSalesManage)f).tbCodeNv.DataBindings.Clear();
            ((_frmSalesManage)f).tbEmailNv.DataBindings.Clear();
            ((_frmSalesManage)f).tbPhoneNv.DataBindings.Clear();
            ((_frmSalesManage)f).dateNv.DataBindings.Clear();
            ((_frmSalesManage)f).dateBegin.DataBindings.Clear();
            ((_frmSalesManage)f).tbNameNv.DataBindings.Add(new Binding("Text", ((_frmSalesManage)f).dtgvNhanvien.DataSource, "HOTEN"));
            ((_frmSalesManage)f).tbCodeNv.DataBindings.Add(new Binding("Text", ((_frmSalesManage)f).dtgvNhanvien.DataSource, "MANV"));
            ((_frmSalesManage)f).tbEmailNv.DataBindings.Add(new Binding("Text", ((_frmSalesManage)f).dtgvNhanvien.DataSource, "Email"));
            ((_frmSalesManage)f).tbPhoneNv.DataBindings.Add(new Binding("Text", ((_frmSalesManage)f).dtgvNhanvien.DataSource, "SODT"));
            ((_frmSalesManage)f).dateNv.DataBindings.Add(new Binding("value", ((_frmSalesManage)f).dtgvNhanvien.DataSource, "NGSINH"));
            ((_frmSalesManage)f).dateBegin.DataBindings.Add(new Binding("value", ((_frmSalesManage)f).dtgvNhanvien.DataSource, "NGVL"));
            ((_frmSalesManage)f).tbAddNv.DataBindings.Add(new Binding("Text", ((_frmSalesManage)f).dtgvNhanvien.DataSource, "DCHI"));
            string MaNv = ((_frmSalesManage)f).tbCodeNv.Text;
            string query1 = "SELECT GT FROM NHANVIEN WHERE MANV = N'" + MaNv + "' ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query1);
            
            string query2 = "SELECT MucDo FROM NHANVIEN WHERE MANV = N'" + MaNv + "' ";
            DataTable dt1 = DataProvider.Instance.ExecuteQuery(query2);
            
            if (dt.Rows.Count > 0 && dt1.Rows.Count > 0)
            {
                DataRow dr1 = dt1.Rows[0];
                DataRow dr = dt.Rows[0];
                string sex = dr.ItemArray[0].ToString();
                string MucDo = dr1.ItemArray[0].ToString();
                int mucdo = Convert.ToInt32(MucDo);
                if (sex == "NAM")
                {
                    ((_frmSalesManage)f).rbNamNV.Checked = true;
                }
                else if (sex == "NU")
                {
                    ((_frmSalesManage)f).rbNuNV.Checked = true;
                }
                else { ((_frmSalesManage)f).rbKhacNV.Checked = true; }

                if (mucdo == 1)
                {
                    ((_frmSalesManage)f).rbMuc1.Checked = true;
                }
                else if (mucdo == 2)
                {
                    ((_frmSalesManage)f).rbMuc2.Checked = true;
                }
                else { ((_frmSalesManage)f).rbMuc3.Checked = true; }
            ((_frmSalesManage)f).DataBindings.Clear();
            }
        }
    }
}
