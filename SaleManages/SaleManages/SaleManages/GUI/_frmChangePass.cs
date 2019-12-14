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
    public partial class _frmChangePass : Form
    {
        string checklang;
        CultureInfo culture;
        public _frmChangePass()
        {
            InitializeComponent();
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmInfoAcc"];
            checklang = ((_frmInfoAcc)f).lbName.Text;
            culture = CultureInfo.CurrentCulture;
            if (checklang == "Tên:") SetLanguage("vi-VN");
            else SetLanguage("en-US");
        }
        private void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("SaleManages.Resources.MyResource", typeof(_frm).Assembly);
            btTitle.Text = rm.GetString("doimatkhau", culture);
            lbOldPass.Text = rm.GetString("change_matkhaucu", culture);
            lbNewPass.Text = rm.GetString("change_matkhaumoi", culture);
            lbCheckPass.Text = rm.GetString("change_xacnhan", culture);
            btnAccept.Text = rm.GetString("info_xacnhan", culture);
        }
    }
}
