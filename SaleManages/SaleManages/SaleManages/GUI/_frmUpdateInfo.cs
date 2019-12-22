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
using System.Timers;
using System.Resources;
using System.Globalization;

namespace SaleManages.GUI
{
    public partial class _frmUpdateInfo : Form
    {
        string checklang;
        CultureInfo culture;
        public _frmUpdateInfo()
        {
            InitializeComponent();
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmSalesManage"];
            checklang = ((_frmSalesManage)f).lbNameKh.Text;
            culture = CultureInfo.CurrentCulture;
            if (checklang == "Họ Tên:") SetLanguage("vi-VN");
            else SetLanguage("en-US");
            LoadForm();
            
        }
        private void SetLanguage(string cultureName)
        {
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("SaleManages.Resources.MyResource", typeof(_frmSalesManage).Assembly);
            lbTitle.Text = rm.GetString("info_lbTitle", culture);
            lbName.Text = rm.GetString("info_ten", culture);
            lbAddress.Text = rm.GetString("info_diachi", culture);
            lbSex.Text = rm.GetString("info_gioitinh", culture);
            lbBirth.Text = rm.GetString("info_ngaysinh", culture);
            lbPhone.Text = rm.GetString("info_sdt", culture);
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        void LoadForm()
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["_frmInfoAcc"];
            tbName.Text = ((_frmInfoAcc)f).lbNameS.Text;
            tbSex.Text = ((_frmInfoAcc)f).lbSexS.Text;
            tbEmail.Text = ((_frmInfoAcc)f).lbEmailS.Text;
            tbAddress.Text = ((_frmInfoAcc)f).lbAddressS.Text;
            tbPhone.Text = ((_frmInfoAcc)f).lbPhoneS.Text;
            string birthstr = ((_frmInfoAcc)f).lbBirthS.Text;
            if (birthstr.Length != 0)
            {
                DateTime Birth = Convert.ToDateTime(birthstr);
                dateBirth.Value = Birth;
            }
        }
        private void _frmUpdateInfo_Load(object sender, EventArgs e)
        {
           
        }

        private void _frmUpdateInfo_Load_1(object sender, EventArgs e)
        {
           
                

        }

        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            AccountDAO.Instance.UpdateAcc();
            AccountDAO.Instance.LoadInfoAcc();
            this.Hide();
        }
    }
}
