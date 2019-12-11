namespace SaleManages
{
    partial class frmSanpham
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
            this.dtgvSanpham = new System.Windows.Forms.DataGridView();
            this.lbNameSp = new System.Windows.Forms.Label();
            this.lbCodeSp = new System.Windows.Forms.Label();
            this.lbDateSp = new System.Windows.Forms.Label();
            this.lbNcc = new System.Windows.Forms.Label();
            this.tbNameSp = new System.Windows.Forms.TextBox();
            this.tbCodeSp = new System.Windows.Forms.TextBox();
            this.tbDateSp = new System.Windows.Forms.DateTimePicker();
            this.tbNcc = new System.Windows.Forms.TextBox();
            this.bttAddSp = new System.Windows.Forms.Button();
            this.bttEraSp = new System.Windows.Forms.Button();
            this.bttFixSp = new System.Windows.Forms.Button();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbDonvi = new System.Windows.Forms.Label();
            this.lbSaleoff = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbDonvi = new System.Windows.Forms.TextBox();
            this.tbCTKM = new System.Windows.Forms.TextBox();
            this.lbHsdSp = new System.Windows.Forms.Label();
            this.tbHsd = new System.Windows.Forms.TextBox();
            this.groupbox_InfoKH = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SanphamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KhachangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NhanvienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quênMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanpham)).BeginInit();
            this.groupbox_InfoKH.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvSanpham
            // 
            this.dtgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSanpham.Location = new System.Drawing.Point(9, 292);
            this.dtgvSanpham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvSanpham.Name = "dtgvSanpham";
            this.dtgvSanpham.RowTemplate.Height = 24;
            this.dtgvSanpham.Size = new System.Drawing.Size(908, 282);
            this.dtgvSanpham.TabIndex = 6;
            // 
            // lbNameSp
            // 
            this.lbNameSp.AutoSize = true;
            this.lbNameSp.Location = new System.Drawing.Point(27, 38);
            this.lbNameSp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNameSp.Name = "lbNameSp";
            this.lbNameSp.Size = new System.Drawing.Size(103, 17);
            this.lbNameSp.TabIndex = 0;
            this.lbNameSp.Text = "Tên sản phẩm:";
            // 
            // lbCodeSp
            // 
            this.lbCodeSp.AutoSize = true;
            this.lbCodeSp.Location = new System.Drawing.Point(27, 79);
            this.lbCodeSp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCodeSp.Name = "lbCodeSp";
            this.lbCodeSp.Size = new System.Drawing.Size(116, 17);
            this.lbCodeSp.TabIndex = 1;
            this.lbCodeSp.Text = "Mã số sản phẩm:";
            // 
            // lbDateSp
            // 
            this.lbDateSp.AutoSize = true;
            this.lbDateSp.Location = new System.Drawing.Point(27, 119);
            this.lbDateSp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDateSp.Name = "lbDateSp";
            this.lbDateSp.Size = new System.Drawing.Size(40, 17);
            this.lbDateSp.TabIndex = 2;
            this.lbDateSp.Text = "NSX:";
            // 
            // lbNcc
            // 
            this.lbNcc.AutoSize = true;
            this.lbNcc.Location = new System.Drawing.Point(27, 201);
            this.lbNcc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNcc.Name = "lbNcc";
            this.lbNcc.Size = new System.Drawing.Size(40, 17);
            this.lbNcc.TabIndex = 3;
            this.lbNcc.Text = "NCC:";
            // 
            // tbNameSp
            // 
            this.tbNameSp.Location = new System.Drawing.Point(128, 33);
            this.tbNameSp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNameSp.Name = "tbNameSp";
            this.tbNameSp.Size = new System.Drawing.Size(151, 23);
            this.tbNameSp.TabIndex = 5;
            // 
            // tbCodeSp
            // 
            this.tbCodeSp.Location = new System.Drawing.Point(128, 76);
            this.tbCodeSp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCodeSp.Name = "tbCodeSp";
            this.tbCodeSp.Size = new System.Drawing.Size(150, 23);
            this.tbCodeSp.TabIndex = 6;
            // 
            // tbDateSp
            // 
            this.tbDateSp.Location = new System.Drawing.Point(128, 119);
            this.tbDateSp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDateSp.Name = "tbDateSp";
            this.tbDateSp.Size = new System.Drawing.Size(151, 23);
            this.tbDateSp.TabIndex = 7;
            // 
            // tbNcc
            // 
            this.tbNcc.Location = new System.Drawing.Point(128, 196);
            this.tbNcc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNcc.Name = "tbNcc";
            this.tbNcc.Size = new System.Drawing.Size(150, 23);
            this.tbNcc.TabIndex = 8;
            // 
            // bttAddSp
            // 
            this.bttAddSp.Location = new System.Drawing.Point(590, 223);
            this.bttAddSp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttAddSp.Name = "bttAddSp";
            this.bttAddSp.Size = new System.Drawing.Size(88, 31);
            this.bttAddSp.TabIndex = 20;
            this.bttAddSp.Text = "Thêm";
            this.bttAddSp.UseVisualStyleBackColor = true;
            // 
            // bttEraSp
            // 
            this.bttEraSp.Location = new System.Drawing.Point(692, 223);
            this.bttEraSp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttEraSp.Name = "bttEraSp";
            this.bttEraSp.Size = new System.Drawing.Size(82, 31);
            this.bttEraSp.TabIndex = 21;
            this.bttEraSp.Text = "Xóa";
            this.bttEraSp.UseVisualStyleBackColor = true;
            // 
            // bttFixSp
            // 
            this.bttFixSp.Location = new System.Drawing.Point(787, 223);
            this.bttFixSp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttFixSp.Name = "bttFixSp";
            this.bttFixSp.Size = new System.Drawing.Size(91, 30);
            this.bttFixSp.TabIndex = 22;
            this.bttFixSp.Text = "Sửa";
            this.bttFixSp.UseVisualStyleBackColor = true;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(410, 32);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(74, 17);
            this.lbPrice.TabIndex = 23;
            this.lbPrice.Text = "Giá thành:";
            // 
            // lbDonvi
            // 
            this.lbDonvi.AutoSize = true;
            this.lbDonvi.Location = new System.Drawing.Point(410, 76);
            this.lbDonvi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDonvi.Name = "lbDonvi";
            this.lbDonvi.Size = new System.Drawing.Size(52, 17);
            this.lbDonvi.TabIndex = 24;
            this.lbDonvi.Text = "Đơn vị:";
            // 
            // lbSaleoff
            // 
            this.lbSaleoff.AutoSize = true;
            this.lbSaleoff.Location = new System.Drawing.Point(411, 120);
            this.lbSaleoff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSaleoff.Name = "lbSaleoff";
            this.lbSaleoff.Size = new System.Drawing.Size(50, 17);
            this.lbSaleoff.TabIndex = 25;
            this.lbSaleoff.Text = "CTKM:";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(513, 29);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(166, 23);
            this.tbPrice.TabIndex = 26;
            // 
            // tbDonvi
            // 
            this.tbDonvi.Location = new System.Drawing.Point(515, 71);
            this.tbDonvi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDonvi.Name = "tbDonvi";
            this.tbDonvi.Size = new System.Drawing.Size(164, 23);
            this.tbDonvi.TabIndex = 27;
            // 
            // tbCTKM
            // 
            this.tbCTKM.Location = new System.Drawing.Point(515, 114);
            this.tbCTKM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCTKM.Name = "tbCTKM";
            this.tbCTKM.Size = new System.Drawing.Size(164, 23);
            this.tbCTKM.TabIndex = 28;
            // 
            // lbHsdSp
            // 
            this.lbHsdSp.AutoSize = true;
            this.lbHsdSp.Location = new System.Drawing.Point(27, 161);
            this.lbHsdSp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHsdSp.Name = "lbHsdSp";
            this.lbHsdSp.Size = new System.Drawing.Size(41, 17);
            this.lbHsdSp.TabIndex = 29;
            this.lbHsdSp.Text = "HSD:";
            // 
            // tbHsd
            // 
            this.tbHsd.Location = new System.Drawing.Point(128, 159);
            this.tbHsd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbHsd.Name = "tbHsd";
            this.tbHsd.Size = new System.Drawing.Size(150, 23);
            this.tbHsd.TabIndex = 30;
            // 
            // groupbox_InfoKH
            // 
            this.groupbox_InfoKH.BackColor = System.Drawing.Color.Bisque;
            this.groupbox_InfoKH.Controls.Add(this.tbHsd);
            this.groupbox_InfoKH.Controls.Add(this.lbHsdSp);
            this.groupbox_InfoKH.Controls.Add(this.tbCTKM);
            this.groupbox_InfoKH.Controls.Add(this.tbDonvi);
            this.groupbox_InfoKH.Controls.Add(this.tbPrice);
            this.groupbox_InfoKH.Controls.Add(this.lbSaleoff);
            this.groupbox_InfoKH.Controls.Add(this.lbDonvi);
            this.groupbox_InfoKH.Controls.Add(this.lbPrice);
            this.groupbox_InfoKH.Controls.Add(this.bttFixSp);
            this.groupbox_InfoKH.Controls.Add(this.bttEraSp);
            this.groupbox_InfoKH.Controls.Add(this.bttAddSp);
            this.groupbox_InfoKH.Controls.Add(this.tbNcc);
            this.groupbox_InfoKH.Controls.Add(this.tbDateSp);
            this.groupbox_InfoKH.Controls.Add(this.tbCodeSp);
            this.groupbox_InfoKH.Controls.Add(this.tbNameSp);
            this.groupbox_InfoKH.Controls.Add(this.lbNcc);
            this.groupbox_InfoKH.Controls.Add(this.lbDateSp);
            this.groupbox_InfoKH.Controls.Add(this.lbCodeSp);
            this.groupbox_InfoKH.Controls.Add(this.lbNameSp);
            this.groupbox_InfoKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_InfoKH.Location = new System.Drawing.Point(9, 26);
            this.groupbox_InfoKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupbox_InfoKH.Name = "groupbox_InfoKH";
            this.groupbox_InfoKH.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupbox_InfoKH.Size = new System.Drawing.Size(908, 261);
            this.groupbox_InfoKH.TabIndex = 5;
            this.groupbox_InfoKH.TabStop = false;
            this.groupbox_InfoKH.Text = "                                                                                 " +
    "                                                                      ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem5});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(926, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SanphamToolStripMenuItem,
            this.KhachangToolStripMenuItem,
            this.NhanvienToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(74, 20);
            this.toolStripMenuItem1.Text = "Danh mục";
            // 
            // SanphamToolStripMenuItem
            // 
            this.SanphamToolStripMenuItem.Name = "SanphamToolStripMenuItem";
            this.SanphamToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.SanphamToolStripMenuItem.Text = "Sản phẩm";
            this.SanphamToolStripMenuItem.Click += new System.EventHandler(this.SanphamToolStripMenuItem_Click);
            // 
            // KhachangToolStripMenuItem
            // 
            this.KhachangToolStripMenuItem.Name = "KhachangToolStripMenuItem";
            this.KhachangToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.KhachangToolStripMenuItem.Text = "Khách hàng";
            this.KhachangToolStripMenuItem.Click += new System.EventHandler(this.KhachangToolStripMenuItem_Click);
            // 
            // NhanvienToolStripMenuItem
            // 
            this.NhanvienToolStripMenuItem.Name = "NhanvienToolStripMenuItem";
            this.NhanvienToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.NhanvienToolStripMenuItem.Text = "Nhân viên";
            this.NhanvienToolStripMenuItem.Click += new System.EventHandler(this.NhanvienToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem,
            this.quênMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(72, 20);
            this.toolStripMenuItem5.Text = "Tài khoản ";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // quênMậtKhẩuToolStripMenuItem
            // 
            this.quênMậtKhẩuToolStripMenuItem.Name = "quênMậtKhẩuToolStripMenuItem";
            this.quênMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.quênMậtKhẩuToolStripMenuItem.Text = "Quên mật khẩu";
            this.quênMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.quênMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // frmSanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 579);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dtgvSanpham);
            this.Controls.Add(this.groupbox_InfoKH);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSanpham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.frmSanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanpham)).EndInit();
            this.groupbox_InfoKH.ResumeLayout(false);
            this.groupbox_InfoKH.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvSanpham;
        private System.Windows.Forms.Label lbNameSp;
        private System.Windows.Forms.Label lbCodeSp;
        private System.Windows.Forms.Label lbDateSp;
        private System.Windows.Forms.Label lbNcc;
        private System.Windows.Forms.TextBox tbNameSp;
        private System.Windows.Forms.TextBox tbCodeSp;
        private System.Windows.Forms.DateTimePicker tbDateSp;
        private System.Windows.Forms.TextBox tbNcc;
        private System.Windows.Forms.Button bttAddSp;
        private System.Windows.Forms.Button bttEraSp;
        private System.Windows.Forms.Button bttFixSp;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbDonvi;
        private System.Windows.Forms.Label lbSaleoff;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbDonvi;
        private System.Windows.Forms.TextBox tbCTKM;
        private System.Windows.Forms.Label lbHsdSp;
        private System.Windows.Forms.TextBox tbHsd;
        private System.Windows.Forms.GroupBox groupbox_InfoKH;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SanphamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KhachangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NhanvienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quênMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}