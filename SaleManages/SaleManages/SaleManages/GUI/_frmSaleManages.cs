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
using SaleManages.GUI;
using SaleManages.DTO;

namespace SaleManages.GUI
{
    public partial class _frmSalesManage : Form
    {
        public _frmSalesManage()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int rs = CheckTabPage();
            if(rs == 0)
            {
                ObjCustomerDAO.Instance.Add();
            }
            else if(rs == 1)
            {
                MessageBox.Show("tabpage 2");
            }
            else
            {
                MessageBox.Show("tabpage 3");
            }
        }
        int CheckTabPage()
        {
            int result = 5;
            if (metroTabControl1.SelectedIndex == 0) 
            {
                result = 0;
            }
            else if(metroTabControl1.SelectedIndex ==1)
            {
                result = 1;
            }
            else if(metroTabControl1.SelectedIndex ==2)
            {
                result = 2;
            }
            return result;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int check = CheckTabPage();
            if(check == 0)
            {
               
                dtgvKhachhang.DataSource = ObjCustomerDAO.Instance.LoadCustomerData();
                ObjCustomerDAO.Instance.Bindings();
            }
            else if (check == 1)
            {
                string query = "SELECT MANV AS N'Mã Nhân Viên',HOTEN AS N'Họ Tên'," +
                    "DCHI AS N'Địa Chỉ',NGSINH AS N'Ngày Sinh', NGVL AS N'Ngày Vào Làm'," +
                    "GT AS N'Giới Tính',Email ,MucDO AS N'Mức độ' FROM NHANVIEN";
                dtgvNhanvien.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            else 
            {
                string query = "SELECT MASP AS N'Mã Sản Phẩm',TENSP AS N'Tên Sản Phẩm'," +
                    "DVT AS N'Đơn Vị Tính',NSX AS N'Nước Sản Xuất',NCC AS N'Nhà Cung Cấp'," +
                    "GIA AS N'Giá',CTKM AS N'Khuyến Mãi' FROM SANPHAM";
                dtgvSanpham.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
        }

        private void dtgvKhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ObjCustomerDAO.Instance.Bindings();
        }

        private void btnEra_Click(object sender, EventArgs e)
        {
            int check = CheckTabPage();
            if (check == 0)
            {
                ObjCustomerDAO.Instance.Delete();
            }
            else if (check == 1)
            {
               
            }
            else
            {
                
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            int check = CheckTabPage();
            if (check == 0)
            {
                ObjCustomerDAO.Instance.Update();
            }
            else if (check == 1)
            {

            }
            else
            {

            }
        }

        private void lbSex_Click(object sender, EventArgs e)
        {

        }

        private void lbMucdo_Click(object sender, EventArgs e)
        {

        }
    }
}
