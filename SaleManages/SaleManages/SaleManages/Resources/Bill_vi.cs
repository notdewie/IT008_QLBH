using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using SaleManages.DTO;

namespace SaleManages.Resources
{
    public partial class Bill_vi : DevExpress.XtraReports.UI.XtraReport
    {
        public Bill_vi()
        {
            InitializeComponent();
        }
        public void InitData(string sohd,  DateTime Nghd,string TenKh,string DchiKH,string MaNV,string TenNV,string TriGia,List<ObjBillDetail>data)
        {
            vendorName.Value = TenNV;
            vendorContactName.Value = MaNV;
            customerName.Value = TenKh;
            customerAddress.Value = DchiKH;
            invoiceNumber.Value = sohd;
            invoiceDate.Value = Nghd.Date;
            total.Value = TriGia;
            objectDataSource2.DataSource = data;
        }
    }
}
