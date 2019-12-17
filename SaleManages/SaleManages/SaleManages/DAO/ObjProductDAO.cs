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
    public class ObjProductDAO
    {
        private static ObjProductDAO instance;

        public static ObjProductDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ObjProductDAO();
                }
                return instance;
            }
            set { instance = value; }
        }
        private ObjProductDAO() { }
        string LoadQuery = "SELECT MASP AS N'Mã Sản Phẩm',TENSP AS N'Tên Sản Phẩm'," +
                    "DVT AS N'Đơn Vị Tính',NSX AS N'Ngày Sản Xuất',HSD AS N'Hạn Sử Dụng',NCC AS N'Nhà Cung Cấp'," +
                    "GIA AS N'Giá',CTKM AS N'Khuyến Mãi' FROM SANPHAM";
        public DataTable LoadProductData()
        {
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(LoadQuery);
            return data;
        }
        public ObjProduct product = new ObjProduct();
        bool CheckMaSP(string MaSP)
        {
            string query = "SELECT MASP FROM SANPHAM WHERE MASP = '" + MaSP + "' ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
                return false;
            else return true;
        }
        public void Add()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
            string tbname = ((_frmSalesManage)f).tbNameSp.Text;
            string tbmaso = ((_frmSalesManage)f).tbCodeSp.Text;
            string tbnsx = ((_frmSalesManage)f).tbDateSp.Value.ToString();
            string tbhsd = ((_frmSalesManage)f).tbHsd.Value.ToString();
            string tbncc = ((_frmSalesManage)f).tbNcc.Text;
            string tbgia = ((_frmSalesManage)f).tbPrice.Text;
            string tbdonvi = ((_frmSalesManage)f).tbDonvi.Text;
            string tbctkm = ((_frmSalesManage)f).tbCTKM.Text;
            product.Name = tbname;
            product.Code = tbmaso;
            product.NSX = tbnsx;
            product.HSD = tbhsd;
            product.NCC = tbncc;
            product.Price = tbgia;
            product.Unit = tbdonvi;
            product.CTKM = tbctkm;
            if (product.Code.Length < 5)
            {
                if (CheckMaSP(product.Code))
                {
                    string AddQuery = "INSERT INTO SANPHAM(MASP,TENSP,DVT,NSX,HSD,NCC,GIA,CTKM) " +
                        "VALUES('" + product.Code + "', '" + product.Name + "', '" + product.Unit + "', '" + product.NSX + "', '" + product.HSD + "','" + product.NCC + "', '" + product.Price + "', '" + product.CTKM + "')";
                    int result = DataProvider.Instance.ExecuteNonQuery(AddQuery);
                    if (result > 0)
                    {
                        MessageBox.Show("Khách hàng đã được thêm,bấm xem để xem dữ liệu mới", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else MessageBox.Show("Mã sản phẩm đã tồn tại", "Thông báo", MessageBoxButtons.OK);
            }
            else MessageBox.Show("Mã sản phẩm phải nhỏ hơn 5 kí tự", "Thông báo", MessageBoxButtons.OK);
        }
        public void Delete()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
            string tbmaso = ((_frmSalesManage)f).tbCodeSp.Text;
            string DeleteQuery = "DELETE FROM SANPHAM WHERE MASP = '" + tbmaso + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(DeleteQuery);
            if (result > 0)
            {
                MessageBox.Show("Sản phẩm đã bị xoá,bấm Xem để xem dữ liệu mới", "Thông báo", MessageBoxButtons.OK);
            }
        }
        public void Update()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
            string tbname = ((_frmSalesManage)f).tbNameSp.Text;
            string tbmaso = ((_frmSalesManage)f).tbCodeSp.Text;
            string tbnsx = ((_frmSalesManage)f).tbDateSp.Value.ToString();
            string tbhsd = ((_frmSalesManage)f).tbHsd.Value.ToString();
            string tbncc = ((_frmSalesManage)f).tbNcc.Text;
            string tbgia = ((_frmSalesManage)f).tbPrice.Text;
            string tbdonvi = ((_frmSalesManage)f).tbDonvi.Text;
            string tbctkm = ((_frmSalesManage)f).tbCTKM.Text;
            product.Name = tbname;
            product.Code = tbmaso;
            product.NSX = tbnsx;
            product.HSD = tbhsd;
            product.NCC = tbncc;
            product.Price = tbgia;
            product.Unit = tbdonvi;
            product.CTKM = tbctkm;
            string UpdateQuery = "UPDATE SANPHAM " +
                "SET MASP = '" + product.Code + "', TENSP ='" + product.Name + "',DVT = '" + product.Unit + "',NSX = '" + product.NSX + "',HSD = '" + product.HSD + "',NCC = '" + product.NCC + "', GIA = '" + product.Price + "', CTKM = '" + product.CTKM + "' " +
                "WHERE MASP = '" + product.Code + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(UpdateQuery);
            if (result > 0)
            {
                MessageBox.Show("Khách hàng đã được thêm,bấm xem để xem dữ liệu mới", "Thông báo", MessageBoxButtons.OK);
            }
        }
        public DataTable FindProductData()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmFindProductData"];
            string nameProduct = ((_frmFindProductData)f).tbFindproData.Text;
            string FindQuery = "SELECT MASP AS N'Mã Sản Phẩm',TENSP AS N'Tên Sản Phẩm'," +
                    "DVT AS N'Đơn Vị Tính',NSX AS N'Ngày Sản Xuất',HSD AS N'Hạn Sử Dụng',NCC AS N'Nhà Cung Cấp'," +
                    "GIA AS N'Giá',CTKM AS N'Khuyến Mãi' FROM SANPHAM " +
                   "WHERE TENSP = '" + nameProduct + "' ";
            DataTable data = DataProvider.Instance.ExecuteQuery(FindQuery);
            return data;
        }
        public void Bindings()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
            ((_frmSalesManage)f).tbNameSp.DataBindings.Clear();
            ((_frmSalesManage)f).tbCodeSp.DataBindings.Clear();
            ((_frmSalesManage)f).tbDateSp.DataBindings.Clear();
            ((_frmSalesManage)f).tbHsd.DataBindings.Clear();
            ((_frmSalesManage)f).tbNcc.DataBindings.Clear();
            ((_frmSalesManage)f).tbPrice.DataBindings.Clear();
            ((_frmSalesManage)f).tbDonvi.DataBindings.Clear();
            ((_frmSalesManage)f).tbCTKM.DataBindings.Clear();
            ((_frmSalesManage)f).tbNameSp.DataBindings.Add(new Binding("Text", ((_frmSalesManage)f).dtgvSanpham.DataSource, "Tên Sản Phẩm"));
            ((_frmSalesManage)f).tbCodeSp.DataBindings.Add(new Binding("Text", ((_frmSalesManage)f).dtgvSanpham.DataSource, "Mã Sản Phẩm"));
            ((_frmSalesManage)f).tbDateSp.DataBindings.Add(new Binding("value", ((_frmSalesManage)f).dtgvSanpham.DataSource, "Ngày Sản Xuất"));
            ((_frmSalesManage)f).tbHsd.DataBindings.Add(new Binding("value", ((_frmSalesManage)f).dtgvSanpham.DataSource, "Hạn Sử Dụng"));
            ((_frmSalesManage)f).tbNcc.DataBindings.Add(new Binding("Text", ((_frmSalesManage)f).dtgvSanpham.DataSource, "Nhà Cung Cấp"));
            ((_frmSalesManage)f).tbPrice.DataBindings.Add(new Binding("Text", ((_frmSalesManage)f).dtgvSanpham.DataSource, "Giá"));
            ((_frmSalesManage)f).tbDonvi.DataBindings.Add(new Binding("Text", ((_frmSalesManage)f).dtgvSanpham.DataSource, "Đơn Vị Tính"));
            ((_frmSalesManage)f).tbCTKM.DataBindings.Add(new Binding("Text", ((_frmSalesManage)f).dtgvSanpham.DataSource, "Khuyến Mãi"));
            ((_frmSalesManage)f).DataBindings.Clear();
        }
    }
}
