﻿namespace SaleManages.GUI
{
    partial class _frmDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_frmDetail));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSoHD = new System.Windows.Forms.TextBox();
            this.tbMaSP_detail = new System.Windows.Forms.TextBox();
            this.tbSoLuong_detail = new System.Windows.Forms.TextBox();
            this.dtgvDetail = new System.Windows.Forms.DataGridView();
            this.btnEra = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnFix = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT HÓA ĐƠN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số Hóa Đơn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Sản Phẩm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Lượng:";
            // 
            // tbSoHD
            // 
            this.tbSoHD.Location = new System.Drawing.Point(146, 120);
            this.tbSoHD.Name = "tbSoHD";
            this.tbSoHD.ReadOnly = true;
            this.tbSoHD.Size = new System.Drawing.Size(282, 25);
            this.tbSoHD.TabIndex = 4;
            // 
            // tbMaSP_detail
            // 
            this.tbMaSP_detail.Location = new System.Drawing.Point(146, 182);
            this.tbMaSP_detail.Name = "tbMaSP_detail";
            this.tbMaSP_detail.Size = new System.Drawing.Size(282, 25);
            this.tbMaSP_detail.TabIndex = 5;
            // 
            // tbSoLuong_detail
            // 
            this.tbSoLuong_detail.Location = new System.Drawing.Point(146, 249);
            this.tbSoLuong_detail.Name = "tbSoLuong_detail";
            this.tbSoLuong_detail.Size = new System.Drawing.Size(282, 25);
            this.tbSoLuong_detail.TabIndex = 6;
            // 
            // dtgvDetail
            // 
            this.dtgvDetail.BackgroundColor = System.Drawing.Color.White;
            this.dtgvDetail.Location = new System.Drawing.Point(53, 298);
            this.dtgvDetail.Name = "dtgvDetail";
            this.dtgvDetail.RowTemplate.Height = 33;
            this.dtgvDetail.Size = new System.Drawing.Size(375, 221);
            this.dtgvDetail.TabIndex = 7;
            // 
            // btnEra
            // 
            this.btnEra.BackColor = System.Drawing.Color.White;
            this.btnEra.color = System.Drawing.Color.White;
            this.btnEra.colorActive = System.Drawing.Color.LightSkyBlue;
            this.btnEra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEra.Font = new System.Drawing.Font("Segoe UI Light", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEra.ForeColor = System.Drawing.Color.Black;
            this.btnEra.Image = ((System.Drawing.Image)(resources.GetObject("btnEra.Image")));
            this.btnEra.ImagePosition = 12;
            this.btnEra.ImageZoom = 35;
            this.btnEra.LabelPosition = 25;
            this.btnEra.LabelText = "Xóa";
            this.btnEra.Location = new System.Drawing.Point(318, 528);
            this.btnEra.Margin = new System.Windows.Forms.Padding(6);
            this.btnEra.Name = "btnEra";
            this.btnEra.Size = new System.Drawing.Size(80, 80);
            this.btnEra.TabIndex = 36;
            this.btnEra.Click += new System.EventHandler(this.btnEra_Click);
            // 
            // btnFix
            // 
            this.btnFix.BackColor = System.Drawing.Color.White;
            this.btnFix.color = System.Drawing.Color.White;
            this.btnFix.colorActive = System.Drawing.Color.LightSkyBlue;
            this.btnFix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFix.Font = new System.Drawing.Font("Segoe UI Light", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFix.ForeColor = System.Drawing.Color.Black;
            this.btnFix.Image = ((System.Drawing.Image)(resources.GetObject("btnFix.Image")));
            this.btnFix.ImagePosition = 12;
            this.btnFix.ImageZoom = 35;
            this.btnFix.LabelPosition = 25;
            this.btnFix.LabelText = "Sửa";
            this.btnFix.Location = new System.Drawing.Point(199, 528);
            this.btnFix.Margin = new System.Windows.Forms.Padding(6);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(80, 80);
            this.btnFix.TabIndex = 35;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.color = System.Drawing.Color.White;
            this.btnAdd.colorActive = System.Drawing.Color.LightSkyBlue;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Light", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImagePosition = 12;
            this.btnAdd.ImageZoom = 35;
            this.btnAdd.LabelPosition = 25;
            this.btnAdd.LabelText = "Thêm";
            this.btnAdd.Location = new System.Drawing.Point(76, 528);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 80);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // _frmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(474, 629);
            this.Controls.Add(this.btnEra);
            this.Controls.Add(this.btnFix);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgvDetail);
            this.Controls.Add(this.tbSoLuong_detail);
            this.Controls.Add(this.tbMaSP_detail);
            this.Controls.Add(this.tbSoHD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "_frmDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_frmDetail";
            this.Load += new System.EventHandler(this._frmDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbSoHD;
        public System.Windows.Forms.TextBox tbMaSP_detail;
        public System.Windows.Forms.TextBox tbSoLuong_detail;
        public System.Windows.Forms.DataGridView dtgvDetail;
        private Bunifu.Framework.UI.BunifuTileButton btnEra;
        private Bunifu.Framework.UI.BunifuTileButton btnFix;
        private Bunifu.Framework.UI.BunifuTileButton btnAdd;
    }
}