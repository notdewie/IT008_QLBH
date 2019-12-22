namespace SaleManages.GUI
{
    partial class _frmFindBillData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_frmFindBillData));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFindnillData = new Bunifu.Framework.UI.BunifuTileButton();
            this.tbFindbillData = new System.Windows.Forms.TextBox();
            this.lbFindbillData = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnFindnillData);
            this.panel1.Controls.Add(this.tbFindbillData);
            this.panel1.Controls.Add(this.lbFindbillData);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 155);
            this.panel1.TabIndex = 1;
            // 
            // btnFindnillData
            // 
            this.btnFindnillData.BackColor = System.Drawing.Color.White;
            this.btnFindnillData.color = System.Drawing.Color.White;
            this.btnFindnillData.colorActive = System.Drawing.Color.LightSkyBlue;
            this.btnFindnillData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindnillData.Font = new System.Drawing.Font("Segoe UI Light", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindnillData.ForeColor = System.Drawing.Color.Black;
            this.btnFindnillData.Image = ((System.Drawing.Image)(resources.GetObject("btnFindnillData.Image")));
            this.btnFindnillData.ImagePosition = 15;
            this.btnFindnillData.ImageZoom = 50;
            this.btnFindnillData.LabelPosition = 0;
            this.btnFindnillData.LabelText = "";
            this.btnFindnillData.Location = new System.Drawing.Point(362, 49);
            this.btnFindnillData.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFindnillData.Name = "btnFindnillData";
            this.btnFindnillData.Size = new System.Drawing.Size(50, 55);
            this.btnFindnillData.TabIndex = 37;
            this.btnFindnillData.Click += new System.EventHandler(this.btnFindnillData_Click);
            // 
            // tbFindbillData
            // 
            this.tbFindbillData.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFindbillData.Location = new System.Drawing.Point(135, 66);
            this.tbFindbillData.Name = "tbFindbillData";
            this.tbFindbillData.Size = new System.Drawing.Size(212, 25);
            this.tbFindbillData.TabIndex = 1;
            // 
            // lbFindbillData
            // 
            this.lbFindbillData.AutoSize = true;
            this.lbFindbillData.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFindbillData.Location = new System.Drawing.Point(27, 68);
            this.lbFindbillData.Name = "lbFindbillData";
            this.lbFindbillData.Size = new System.Drawing.Size(82, 19);
            this.lbFindbillData.TabIndex = 0;
            this.lbFindbillData.Text = "Số hoá đơn:";
            // 
            // _frmFindBillData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 159);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "_frmFindBillData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm hoá đơn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTileButton btnFindnillData;
        public System.Windows.Forms.TextBox tbFindbillData;
        private System.Windows.Forms.Label lbFindbillData;
    }
}