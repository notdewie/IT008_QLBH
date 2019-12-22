using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaleManages.DTO;
using SaleManages.Resources;

namespace SaleManages.GUI
{
    public partial class Print : DevExpress.XtraEditors.XtraForm
    {
        public Print()
        {
            InitializeComponent();
            PrintInvoice();
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = height;
            this.Width = width;
        }
        string checklang;
        private void PrintInvoice()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
            checklang = ((_frmSalesManage)f).lbNameKh.Text;
            if (checklang == "Họ Tên:")
            {
                Bill_vi bill_vi = new Bill_vi();
                documentViewer1.DocumentSource = bill_vi;
                bill_vi.CreateDocument();
            }
            else
            {
                Bill_en bill_en = new Bill_en();
                documentViewer1.DocumentSource = bill_en;
                bill_en.CreateDocument();
            }
        }
        public void PrintBill(ObjBill objBill,List<ObjBillDetail> objBillDetail)
        {
            Bill_vi report = new Bill_vi();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;
            report.InitData(objBill.SOHD,objBill.NGHD,objBill.TenKH,objBill.DchiKH,objBill.MANV,objBill.TenNV,objBill.TRIGIA,objBillDetail);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
            
        }
        private void Print_Load(object sender, EventArgs e)
        {

        }
    }
}
