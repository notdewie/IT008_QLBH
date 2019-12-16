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
        string LoadQuery = "SELECT SOHD AS N'Số Hoá Đơn' ,MAKH AS N'Mã Khách Hàng', MANV AS N'Mã Nhân Viên' ," +
                   "TRIGIA AS N'Trị Giá',NGHD AS N'Ngày Hoá Đơn' FROM HOADON";
        
        public bool Check(string MaNV,string MaKH)
        {
            
            string CheckNVQueyry = "SELECT MANV FROM NHANVIEN " +
                "WHERE MANV = '"+MaNV+"' ";
            string CheckKHQuery = "SELECT MAKH FROM KHACHHANG " +
                "WHERE MAKH = '"+MaKH+"' ";
            int KHrs = DataProvider.Instance.ExecuteNonQuery(CheckNVQueyry);
            int NVrs = DataProvider.Instance.ExecuteNonQuery(CheckKHQuery);
            if (KHrs > 0 && NVrs > 0)
            { return true; }
            else return false;
        }
        public DataTable LoadBillData()
        {
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
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmFindBillData"];
            string SoHD = ((_frmFindBillData)f).tbFindbillData.Text;
            string FindQuery = "SELECT SOHD AS N'Số Hoá Đơn' ,MAKH AS N'Mã Khách Hàng', MANV AS N'Mã Nhân Viên' ," +
                   "TRIGIA AS N'Trị Giá',NGHD AS N'Ngày Hoá Đơn' FROM KHACHHANG" +
                   "WHERE SOHD = '" + SoHD + "' ";
            DataTable data = DataProvider.Instance.ExecuteQuery(FindQuery);
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
            ((_frmSalesManage)f).tbCodeHD.DataBindings.Add(new Binding("Text", ((_frmSalesManage)f).dtgvHoadon.DataSource, "Số Hoá Đơn"));
            ((_frmSalesManage)f).tbCodeKH_HD.DataBindings.Add(new Binding("Text", ((_frmSalesManage)f).dtgvHoadon.DataSource, "Mã Khách Hàng"));
            ((_frmSalesManage)f).tbCodeNV_HD.DataBindings.Add(new Binding("Text", ((_frmSalesManage)f).dtgvHoadon.DataSource, "Mã Nhân Viên"));
            ((_frmSalesManage)f).tbTriGia.DataBindings.Add(new Binding("Text", ((_frmSalesManage)f).dtgvHoadon.DataSource, "Trị Giá"));
            ((_frmSalesManage)f).dateHD.DataBindings.Add(new Binding("value", ((_frmSalesManage)f).dtgvHoadon.DataSource, "Ngày Hoá Đơn"));
            ((_frmSalesManage)f).DataBindings.Clear();
        }
    }
}
