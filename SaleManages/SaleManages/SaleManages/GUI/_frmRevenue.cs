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

namespace SaleManages.GUI
{
    public partial class _frmRevenue : Form
    {
        public _frmRevenue()
        {
            InitializeComponent();
        }

        private void _frmRevenue_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            
            for (int i = 0; i < date.Month; i++)
            {
                int ii = i + 1;
                string Query = "SELECT HD.TRIGIA " +
                    "FROM HOADON AS HD " +
                    "WHERE MONTH(HD.NGHD) = '" + ii + "' " +
                    "AND YEAR(HD.NGHD) = '"+date.Year+"' ";
                DataTable dataTable = DataProvider.Instance.ExecuteQuery(Query);
                double Tong = 0;
                if (dataTable.Rows.Count > 0)
                {
                    for (int j = 0; j < dataTable.Rows.Count; j++)
                    {
                        DataRow dr = dataTable.Rows[j];
                        Tong += Convert.ToDouble(dr.ItemArray[0].ToString());
                    }
                }
                Tong /= 1000000;
                    ChartBDC.Series["ChartBDC"].Points.Add(Tong);
                    ChartBDC.Series["ChartBDC"].Points[i].Label = Tong.ToString();
                    ChartBDC.Series["ChartBDC"].Points[i].Color = Color.Blue;
                    ChartBDC.Series["ChartBDC"].Points[i].AxisLabel = (i + 1).ToString();
                
            }
            if (date.Month != 12)
            {
                for (int i = date.Month; i < 12; i++)
                {
                    ChartBDC.Series["ChartBDC"].Points.Add(0);
                    ChartBDC.Series["ChartBDC"].Points[i].Label = "0";
                    ChartBDC.Series["ChartBDC"].Points[i].Color = Color.Blue;
                    ChartBDC.Series["ChartBDC"].Points[i].AxisLabel = (i+1).ToString();
                }
            }
            
        }
    }
}
