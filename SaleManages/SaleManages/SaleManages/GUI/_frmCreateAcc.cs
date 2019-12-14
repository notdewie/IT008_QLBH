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
    public partial class _frmCreateAcc : Form
    {
        string checklang;
        CultureInfo culture;

        public _frmCreateAcc()
        {
            InitializeComponent();
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmLogin"];
            checklang = ((_frmLogin)f).lbTitle.Text;
            culture = CultureInfo.CurrentCulture;
            if (checklang == "Đăng Nhập") SetLanguage("vi-VN");
            else SetLanguage("en-US");
        }
        private void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("SaleManages.Resources.MyResource", typeof(_frm).Assembly);
            lbTitle.Text = rm.GetString("reg_lbTitle", culture);
            tbUsername.Text = rm.GetString("reg_tbUsername", culture);
            tbName.Text = rm.GetString("reg_tbName", culture);
            tbEmail.Text = rm.GetString("reg_tbEmail", culture);
            tbPass.Text = rm.GetString("reg_tbPass", culture);
            tbCheckPass.Text = rm.GetString("reg_tbCheckPass", culture);
            btnReg.Text = rm.GetString("reg_btnReg", culture);
            rbMale.Text = rm.GetString("reg_rbMale", culture);
            rbFemale.Text = rm.GetString("reg_rbFemale", culture);
            rbElse.Text = rm.GetString("reg_rbElse", culture);
            lbAccept.Text = rm.GetString("reg_lbAccept", culture);
            lbUseTerm.Text = rm.GetString("reg_lbUseTerm", culture);
            btnReg.Text = rm.GetString("reg_lbTitle", culture);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void metroDateTime1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.Show("Ngày sinh", dateBirth);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
