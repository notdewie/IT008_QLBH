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
using System.Text.RegularExpressions;
namespace SaleManages.DAO
{
    public class ObjBillDAO
    {
        private static ObjBillDAO instance;

        public static ObjBillDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ObjBillDAO();
                }
                return instance;
            }
            private set { instance = value; }
        }
        private ObjBillDAO() { }
        ObjBill objBill = new ObjBill();
        
        
        public bool Check(string MaNV,string MaKH)
        {
            
            string CheckNVQueyry = "SELECT MANV FROM NHANVIEN " +
                "WHERE MANV = '"+MaNV+"' ";
            string CheckKHQuery = "SELECT MAKH FROM KHACHHANG " +
                "WHERE MAKH = '"+MaKH+"' ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(CheckNVQueyry);
            DataTable dt1 = DataProvider.Instance.ExecuteQuery(CheckKHQuery);
            if (dt.Rows.Count > 0 && dt1.Rows.Count > 0)
            { return true; }
            else return false;
        }

        public DataTable LoadBillData()
        {
            string LoadQuery = "SELECT * FROM HOADON";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(LoadQuery);
            return data;
        }

        public void Add()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
            string SoHD = ((_frmSalesManage)f).tbCodeHD.Text;
            string MaKH = ((_frmSalesManage)f).tbCodeKH_HD.Text;
            string MaNV = ((_frmSalesManage)f).tbCodeNV_HD.Text;
            string dateHD = ((_frmSalesManage)f).dateHD.Value.ToString();
            string TriGia = ((_frmSalesManage)f).tbTriGia.Text;
            if (IsNumber(SoHD)) { 
                if (CheckSoHD(SoHD))
                {
                    if (Check(MaNV, MaKH))
                    {
                        string AddQuery = "INSERT INTO HOADON(SOHD,NGHD,MAKH,MANV,TRIGIA) " +
                            "VALUES('" + SoHD + "', '" + dateHD + "', '" + MaKH + "', '" + MaNV + "', '" + TriGia + "')";
                        int result = DataProvider.Instance.ExecuteNonQuery(AddQuery);
                        if (result > 0)
                        {
                            MessageBox.Show("Hoá đơn đã được thêm,bấm xem để xem dữ liệu mới", "Thông báo", MessageBoxButtons.OK);
                        }
                    }
                    else MessageBox.Show("Nhập sai mã khách hàng hoặc mã nhân viên", "Thông báo", MessageBoxButtons.OK);
                }
                else MessageBox.Show("Số hoá đơn đã tồn tại hoặc không phải chuỗi số", "Thông báo", MessageBoxButtons.OK);
            }
        }

        public void Update()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
            string SoHD = ((_frmSalesManage)f).tbCodeHD.Text;
            string NGHD = ((_frmSalesManage)f).dateHD.Value.ToString();
            string MaKH = ((_frmSalesManage)f).tbCodeKH_HD.Text;
            string MaNV = ((_frmSalesManage)f).tbCodeNV_HD.Text;
            string TriGia = ((_frmSalesManage)f).tbTriGia.Text;


            string UpdateQuery = "UPDATE SANPHAM " +
                "SET SOHD = '" + SoHD + "', NGHD ='" + NGHD + "',MAKH = '" + MaKH + "',MANV = '" + MaNV + "',TRIGIA = '" + TriGia + "' " +
                "WHERE SOHD = '" + SoHD + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(UpdateQuery);
            if (result > 0)
            {
                MessageBox.Show("Hoá đơn đã được thêm,bấm xem để xem dữ liệu mới", "Thông báo", MessageBoxButtons.OK);
            }
        }

        public void Delete()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
            string SOHD = ((_frmSalesManage)f).tbCodeHD.Text;
            string DeleteQuery = "DELETE FROM SANPHAM WHERE MASP = '" + SOHD + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(DeleteQuery);
            if (result > 0)
            {
                MessageBox.Show("Hoá Đơn đã bị xoá,bấm Xem để xem dữ liệu mới", "Thông báo", MessageBoxButtons.OK);
            }
        }

        public DataTable FindBillData()
        {
            DataTable data = new DataTable();
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmFindBillData"];
            string SoHD = ((_frmFindBillData)f).tbFindbillData.Text;
            if (IsNumber(SoHD) == true)
            {
                string FindQuery = "SELECT SOHD AS N'Số Hoá Đơn' ,MAKH AS N'Mã Khách Hàng', MANV AS N'Mã Nhân Viên' ," +
                       "TRIGIA AS N'Trị Giá',NGHD AS N'Ngày Hoá Đơn' FROM HOADON " +
                       "WHERE SOHD = '" + SoHD + "' ";
                data = DataProvider.Instance.ExecuteQuery(FindQuery);
                return data;
            }
            else MessageBox.Show("Số hoá đơn phải là chuỗi sô", "Thông báo", MessageBoxButtons.OK);
            return data;
        }

        public void Bindings()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
            ((_frmSalesManage)f).tbCodeHD.DataBindings.Clear();
            ((_frmSalesManage)f).tbCodeKH_HD.DataBindings.Clear();
            ((_frmSalesManage)f).tbCodeNV_HD.DataBindings.Clear();
            ((_frmSalesManage)f).tbTriGia.DataBindings.Clear();
            ((_frmSalesManage)f).dateHD.DataBindings.Clear();
            ((_frmSalesManage)f).tbCodeHD.DataBindings.Add(new Binding("Text", ((_frmSalesManage)f).dtgvHoadon.DataSource, "SOHD"));
            ((_frmSalesManage)f).tbCodeKH_HD.DataBindings.Add(new Binding("Text", ((_frmSalesManage)f).dtgvHoadon.DataSource, "MAKH"));
            ((_frmSalesManage)f).tbCodeNV_HD.DataBindings.Add(new Binding("Text", ((_frmSalesManage)f).dtgvHoadon.DataSource, "MANV"));
            ((_frmSalesManage)f).tbTriGia.DataBindings.Add(new Binding("Text", ((_frmSalesManage)f).dtgvHoadon.DataSource, "TRIGIA"));
            ((_frmSalesManage)f).dateHD.DataBindings.Add(new Binding("value", ((_frmSalesManage)f).dtgvHoadon.DataSource, "NGHD"));
            ((_frmSalesManage)f).DataBindings.Clear();
        }

        
        public DataTable LoadBillDetail()
        {
            DataTable data = new DataTable();
            System.Windows.Forms.Form f1 = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
            string SoHD = ((_frmSalesManage)f1).tbCodeHD.Text;
            
            
            if (SoHD.Length > 0)
            {
                
                string LoadQuery = "SELECT * " +
                    "FROM CTHD " +
                    "WHERE SOHD = '"+SoHD+"' ";
                data = DataProvider.Instance.ExecuteQuery(LoadQuery);
                
            }
            return data;
        }

        public void BindingsBillDetail()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmDetail"];
            System.Windows.Forms.Form f1 = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
            string SoHD = ((_frmSalesManage)f1).tbCodeHD.Text;
            ((_frmDetail)f).tbMaSP_detail.DataBindings.Clear();
            ((_frmDetail)f).tbSoLuong_detail.DataBindings.Clear();
            ((_frmDetail)f).tbSoHD.DataBindings.Clear();
            ((_frmDetail)f).tbSoHD.DataBindings.Add(new Binding("Text", ((_frmDetail)f).dtgvDetail.DataSource, "SOHD"));
            ((_frmDetail)f).tbMaSP_detail.DataBindings.Add(new Binding("Text", ((_frmDetail)f).dtgvDetail.DataSource, "MASP"));
            ((_frmDetail)f).tbSoLuong_detail.DataBindings.Add(new Binding("Text", ((_frmDetail)f).dtgvDetail.DataSource, "SL"));
            ((_frmDetail)f).DataBindings.Clear();


        }
        public bool IsNumber(string pText)
        {
            Regex regex = null;
            try
            {
                regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$"); return regex.IsMatch(pText);
            }
            catch (Exception ex)
            {
                return regex.IsMatch(pText);
            }
        }
        bool CheckSoHD(string SOHD)
        {
            string query = "SELECT SOHD FROM HOADON WHERE SOHD = '"+SOHD+"' ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
                return false;
            else return true;
        }
        public void Add_BillDetail()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmDetail"];
            string SoHD = ((_frmDetail)f).tbSoHD.Text;
            string MaSP = ((_frmDetail)f).tbMaSP_detail.Text;
            string SL = ((_frmDetail)f).tbSoLuong_detail.Text;
            string checkMa = "SELECT * FROM CTHD WHERE MASP = '"+MaSP+"' AND SOHD = '"+SoHD+"' ";
            DataTable data = DataProvider.Instance.ExecuteQuery(checkMa);
            if (data.Rows.Count == 0)
            {
                if (CheckMaSP(MaSP))
                {
                    if (IsNumber(SL))
                    {
                        string AddQuery = "INSERT INTO CTHD (SOHD,MASP,SL) " +
                            "VALUES ('" + SoHD + "', '" + MaSP + "','" + SL + "' ) ";
                        int rs = DataProvider.Instance.ExecuteNonQuery(AddQuery);
                        if (rs > 0) MessageBox.Show("CTHD đã được thêm thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else MessageBox.Show("Số lượng phải là số", "Thông báo", MessageBoxButtons.OK);
                }
                else MessageBox.Show("Sai mã sản phẩm", "Thông báo", MessageBoxButtons.OK);
            }
            else MessageBox.Show("Mã sản phẩm này đã tồn tại , mời cập nhật lại", "Thông báo", MessageBoxButtons.OK);
        }
        public void Delete_BillDetail()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmDetail"];
            string SoHD = ((_frmDetail)f).tbSoHD.Text;
            string MaSP = ((_frmDetail)f).tbMaSP_detail.Text;
            string SL = ((_frmDetail)f).tbSoLuong_detail.Text;
            string DeleteQuery = "DELETE FROM CTHD " +
                "WHERE SOHD = '"+SoHD+"' " +
                "AND MASP = '"+MaSP+"' ";
            int result = DataProvider.Instance.ExecuteNonQuery(DeleteQuery);
            if (result > 0)
            {
                MessageBox.Show("CTHD đã bị xoá,bấm Xem để xem dữ liệu mới", "Thông báo", MessageBoxButtons.OK);
            }
        }
        public bool CheckMaSP(string MaSP)
        {
            string CheckQuery = "SELECT MASP FROM SANPHAM " +
                "WHERE MASP = '"+MaSP+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(CheckQuery);
            if (data.Rows.Count > 0) { return true; }
            else { return false; }
        }
        public void Update_BillDetail()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmDetail"];
            string SoHD = ((_frmDetail)f).tbSoHD.Text;
            string MaSP = ((_frmDetail)f).tbMaSP_detail.Text;
            string SL = ((_frmDetail)f).tbSoLuong_detail.Text;
            if (CheckMaSP(MaSP))
            {
                if (IsNumber(SL))
                {
                    string UpdateQuery = "UPDATE CTHD " +
                    "SET MASP ='" + MaSP + "', SL = '"+SL+"' " +
                    "WHERE SOHD = '"+SoHD+"' ";
                    int rs = DataProvider.Instance.ExecuteNonQuery(UpdateQuery);
                    if (rs > 0) MessageBox.Show("CTHD đã được thêm thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else MessageBox.Show("Số lượng phải là số", "Thông báo", MessageBoxButtons.OK);
            }
            else MessageBox.Show("Sai mã sản phẩm", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
