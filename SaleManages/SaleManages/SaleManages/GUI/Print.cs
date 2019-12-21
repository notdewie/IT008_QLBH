using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaleManages.Resources;

namespace SaleManages.GUI
{
    public partial class Print : DevExpress.XtraEditors.XtraForm
    {
        public Print()
        {
            InitializeComponent();
            PrintInvoice();
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
    }
}
