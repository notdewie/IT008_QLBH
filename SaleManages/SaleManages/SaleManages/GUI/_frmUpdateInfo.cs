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

namespace SaleManages.GUI
{
    public partial class _frmUpdateInfo : Form
    {
        public _frmUpdateInfo()
        {
            InitializeComponent();
            LoadForm();
            
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            AccountDAO.Instance.UpdateAcc();
            AccountDAO.Instance.LoadInfoAcc();
            this.Hide();
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
    }
}
