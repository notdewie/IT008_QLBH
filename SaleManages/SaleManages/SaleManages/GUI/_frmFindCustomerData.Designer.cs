namespace SaleManages.GUI
{
    partial class _frmFindCustomerData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_frmFindCustomerData));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFindemData = new Bunifu.Framework.UI.BunifuTileButton();
            this.tbFindemData = new System.Windows.Forms.TextBox();
            this.lbFindcusData = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnFindemData);
            this.panel1.Controls.Add(this.tbFindemData);
            this.panel1.Controls.Add(this.lbFindcusData);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 298);
            this.panel1.TabIndex = 0;
            // 
            // btnFindemData
            // 
            this.btnFindemData.BackColor = System.Drawing.Color.White;
            this.btnFindemData.color = System.Drawing.Color.White;
            this.btnFindemData.colorActive = System.Drawing.Color.LightSkyBlue;
            this.btnFindemData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindemData.Font = new System.Drawing.Font("Segoe UI Light", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindemData.ForeColor = System.Drawing.Color.Black;
            this.btnFindemData.Image = ((System.Drawing.Image)(resources.GetObject("btnFindemData.Image")));
            this.btnFindemData.ImagePosition = 15;
            this.btnFindemData.ImageZoom = 55;
            this.btnFindemData.LabelPosition = 0;
            this.btnFindemData.LabelText = "";
            this.btnFindemData.Location = new System.Drawing.Point(724, 94);
            this.btnFindemData.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFindemData.Name = "btnFindemData";
            this.btnFindemData.Size = new System.Drawing.Size(100, 106);
            this.btnFindemData.TabIndex = 37;
            this.btnFindemData.Click += new System.EventHandler(this.btnFindemData_Click);
            // 
            // tbFindemData
            // 
            this.tbFindemData.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFindemData.Location = new System.Drawing.Point(290, 127);
            this.tbFindemData.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbFindemData.Name = "tbFindemData";
            this.tbFindemData.Size = new System.Drawing.Size(420, 43);
            this.tbFindemData.TabIndex = 1;
            // 
            // lbFindcusData
            // 
            this.lbFindcusData.AutoSize = true;
            this.lbFindcusData.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFindcusData.Location = new System.Drawing.Point(54, 131);
            this.lbFindcusData.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbFindcusData.Name = "lbFindcusData";
            this.lbFindcusData.Size = new System.Drawing.Size(206, 37);
            this.lbFindcusData.TabIndex = 0;
            this.lbFindcusData.Text = "Tên khách hàng:";
            // 
            // _frmFindCustomerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(970, 306);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "_frmFindCustomerData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm khách hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox tbFindemData;
        private System.Windows.Forms.Label lbFindcusData;
        private Bunifu.Framework.UI.BunifuTileButton btnFindemData;
    }
}