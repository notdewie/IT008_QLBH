namespace SaleManages.GUI
{
    partial class _frmListBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_frmListBill));
            this.dtgvViewBill = new System.Windows.Forms.DataGridView();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbSoHD_ViewBill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvViewBill)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvViewBill
            // 
            this.dtgvViewBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvViewBill.BackgroundColor = System.Drawing.Color.White;
            this.dtgvViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvViewBill.Location = new System.Drawing.Point(26, 28);
            this.dtgvViewBill.Name = "dtgvViewBill";
            this.dtgvViewBill.RowTemplate.Height = 33;
            this.dtgvViewBill.Size = new System.Drawing.Size(414, 248);
            this.dtgvViewBill.TabIndex = 0;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Xem Thêm";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(300, 303);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(9, 13, 9, 13);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Red;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(140, 63);
            this.bunifuFlatButton1.TabIndex = 62;
            this.bunifuFlatButton1.Text = "Xem Thêm";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // tbSoHD_ViewBill
            // 
            this.tbSoHD_ViewBill.Location = new System.Drawing.Point(124, 322);
            this.tbSoHD_ViewBill.Name = "tbSoHD_ViewBill";
            this.tbSoHD_ViewBill.ReadOnly = true;
            this.tbSoHD_ViewBill.Size = new System.Drawing.Size(164, 43);
            this.tbSoHD_ViewBill.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 37);
            this.label2.TabIndex = 63;
            this.label2.Text = "Số Hóa Đơn:";
            // 
            // _frmListBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(474, 379);
            this.Controls.Add(this.tbSoHD_ViewBill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.dtgvViewBill);
            this.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "_frmListBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách hoá đơn";
            this.Load += new System.EventHandler(this._frmListBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvViewBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvViewBill;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        public System.Windows.Forms.TextBox tbSoHD_ViewBill;
        private System.Windows.Forms.Label label2;
    }
}