using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManages

{
    public partial class frmUseTerm : Form
    {
        public frmUseTerm()
        {
            InitializeComponent();
        }
        private void frmUseTerm_Load(object sender, EventArgs e)
        {
            /*OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                rtbUseTerm.Text = op.FileName;
            }*/
        }

        private void bttSignBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
