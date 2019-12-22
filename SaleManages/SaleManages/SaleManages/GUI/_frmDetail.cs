using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaleManages.DAO;
using System.Windows.Forms;
using System.Threading;
using SaleManages.DTO;
using System.Resources;
using System.Globalization;

namespace SaleManages.GUI
{
    public partial class _frmDetail : Form
    {
        DataTable data = new DataTable();
        int Check = 0;
        bool listBill = false;
        string checklang;
        CultureInfo culture;

        public _frmDetail()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmLogin"];
            checklang = ((_frmLogin)f).lbTitle.Text;
            culture = CultureInfo.CurrentCulture;
            if (checklang == "Đăng Nhập") SetLanguage("vi-VN");
            else SetLanguage("en-US");
            InitializeComponent();
           data = ObjBillDAO.Instance.LoadBillDetail();
            if (data.Rows.Count > 0)
            {
                Check = 1;
                dtgvDetail.DataSource = data;  
            }
            else
            {
                Check = 0;
            }

        }

        private void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("SaleManages.Resources.MyResource", typeof(_frmLogin).Assembly);
            label1.Text = rm.GetString("cthd", culture);
            label2.Text = rm.GetString("sohd", culture);
            label3.Text = rm.GetString("masp", culture);
            label4.Text = rm.GetString("sl", culture);
            btnAdd.LabelText = rm.GetString("them", culture);
            btnEra.LabelText = rm.GetString("xoa", culture);
            btnFix.LabelText = rm.GetString("sua", culture);
            button1.LabelText = rm.GetString("in", culture);
            dtgvDetail.Columns[0].HeaderText = rm.GetString("dtgvsohd", culture);
            dtgvDetail.Columns[1].HeaderText = rm.GetString("dtgvmasp", culture);
            dtgvDetail.Columns[3].HeaderText = rm.GetString("dtgvsl", culture);
            this.Text = rm.GetString("formcthd", culture);
        }

        public _frmDetail(int a)
        {
            InitializeComponent();
            LoadQuery();
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmListBill"];
            string SoHD = ((_frmListBill)f).tbSoHD_ViewBill.Text;
            Check = 1;
            listBill = true;
            
        }
        bool LoadQuery()
        { 
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmListBill"];
            string SoHD = ((_frmListBill)f).tbSoHD_ViewBill.Text;
            string LoadQuery = "SELECT * " +
                    "FROM CTHD " +
                    "WHERE SOHD = '" + SoHD + "' ";
            data = DataProvider.Instance.ExecuteQuery(LoadQuery);
            dtgvDetail.DataSource = data;
            if (data.Rows.Count > 0) return true;
            return false;
        }
        private void _frmDetail_Load(object sender, EventArgs e)
        {
            if(listBill == true)
            {
                if (LoadQuery() == false)
                {
                    System.Windows.Forms.Form f2 = System.Windows.Forms.Application.OpenForms["_frmListBill"];
                    string SoHD1 = ((_frmListBill)f2).tbSoHD_ViewBill.Text;
                    System.Windows.Forms.Form f3 = System.Windows.Forms.Application.OpenForms["_frmDetail"];
                    ((_frmDetail)f3).tbSoHD.Text = SoHD1;
                }
            }
            if (Check == 1)
            {
                
                ObjBillDAO.Instance.BindingsBillDetail();
            }
            else
            {
                
                System.Windows.Forms.Form f1 = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
                string SoHD = ((_frmSalesManage)f1).tbCodeHD.Text;
                System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmDetail"];
                ((_frmDetail)f).tbSoHD.Text = SoHD;
                if (checklang == "Đăng Nhập")
                    MessageBox.Show("CTHD trống", "Thông báo", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Invoice Details is blank", "Notification", MessageBoxButtons.OK);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ObjBillDAO.Instance.Add_BillDetail();
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            ObjBillDAO.Instance.Update_BillDetail();
        }

        private void btnEra_Click(object sender, EventArgs e)
        {
            ObjBillDAO.Instance.Delete_BillDetail();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            string Query = "SELECT HD.SOHD,NV.HOTEN,NV.MANV,KH.HOTEN,KH.DCHI,HD.NGHD,CT.SL,CT.MASP,SP.GIA,SP.TENSP " +
                "FROM HOADON AS HD " +
                "JOIN CTHD AS CT " +
                "ON HD.SOHD = CT.SOHD " +
                "JOIN NHANVIEN AS NV " +
                "ON HD.MANV = NV.MANV " +
                "JOIN KHACHHANG AS KH " +
                "ON KH.MAKH = HD.MAKH " +
                "JOIN SANPHAM AS SP " +
                "ON SP.MASP = CT.MASP " +
                "WHERE HD.SOHD = '" + tbSoHD.Text + "' ";
            DataTable data = DataProvider.Instance.ExecuteQuery(Query);
            DataRow dataRow = data.Rows[0];
            ObjBill objBill = new ObjBill();
            objBill.SOHD = dataRow.ItemArray[0].ToString();
            objBill.TenNV = dataRow.ItemArray[1].ToString();
            objBill.MANV = dataRow.ItemArray[2].ToString();
            objBill.TenKH = dataRow.ItemArray[3].ToString();
            objBill.DchiKH = dataRow.ItemArray[4].ToString();
            DateTime date = Convert.ToDateTime(dataRow.ItemArray[5].ToString());
            objBill.NGHD = date;
            int len = data.Rows.Count;
            double trigia = 0;
            List<ObjBillDetail> list = new List<ObjBillDetail>();
            for (int i = 0; i < len; i++)
            {
                DataRow dr = data.Rows[i];
                ObjBillDetail obj = new ObjBillDetail();
                obj.SL = dr.ItemArray[6].ToString();
                obj.MaSP = dr.ItemArray[7].ToString();
                obj.GIA = dr.ItemArray[8].ToString();
                obj.TenSP = dr.ItemArray[9].ToString();
                obj.Tong = (Convert.ToDouble(obj.SL) * Convert.ToDouble(obj.GIA)).ToString();
                trigia += Convert.ToDouble(obj.Tong);

                list.Add(obj);
            }
            objBill.TRIGIA = trigia.ToString();
            Print frm = new Print();
            frm.PrintBill(objBill, list);
            frm.Show();
        }
    }
}
