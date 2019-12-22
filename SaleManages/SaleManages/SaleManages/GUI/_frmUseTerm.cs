using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;

namespace SaleManages.GUI
{
    public partial class _frmUseTerm : Form
    {
        CultureInfo culture;
        string checklang;
        //string checklangCA;
        public _frmUseTerm()
        {
            InitializeComponent();
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmLogin"];
            checklang = ((_frmLogin)f).lbTitle.Text;
            culture = CultureInfo.CurrentCulture;
            if (checklang == "Đăng nhập") SetLanguage("vi-VN");
            else SetLanguage("en-US");
            /*System.Windows.Forms.Form fCA = System.Windows.Forms.Application.OpenForms["_frmCreateAcc"];
            checklangCA = ((_frmCreateAcc)fCA).rbElse.Text;
            culture = CultureInfo.CurrentCulture;
            if (checklangCA == "Khác") SetLanguage("vi-VN");
            else SetLanguage("en-US");*/
        }
        private void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("SaleManages.Resources.MyResource", typeof(_frmSalesManage).Assembly);
            lbUseTerm.Text = rm.GetString("reg_lbUseTerm", culture);
            button1.Text = rm.GetString("dong", culture);
            this.Text = rm.GetString("formTerm", culture);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
