namespace SaleManages.GUI
{
    partial class _frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_frmAdmin));
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.tbAdmin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdmin = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvAccount.BackgroundColor = System.Drawing.Color.White;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(26, 57);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.RowTemplate.Height = 33;
            this.dtgvAccount.Size = new System.Drawing.Size(414, 219);
            this.dtgvAccount.TabIndex = 1;
            // 
            // tbAdmin
            // 
            this.tbAdmin.BackColor = System.Drawing.Color.White;
            this.tbAdmin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdmin.Location = new System.Drawing.Point(137, 316);
            this.tbAdmin.Name = "tbAdmin";
            this.tbAdmin.ReadOnly = true;
            this.tbAdmin.Size = new System.Drawing.Size(141, 25);
            this.tbAdmin.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 65;
            this.label2.Text = "Số Hóa Đơn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 17);
            this.label1.TabIndex = 67;
            this.label1.Text = "Danh sách tài khoản chưa phê duyệt : ";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Activecolor = System.Drawing.Color.Transparent;
            this.btnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdmin.BorderRadius = 0;
            this.btnAdmin.ButtonText = "Duyệt";
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdmin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Iconimage")));
            this.btnAdmin.Iconimage_right = null;
            this.btnAdmin.Iconimage_right_Selected = null;
            this.btnAdmin.Iconimage_Selected = null;
            this.btnAdmin.IconMarginLeft = 0;
            this.btnAdmin.IconMarginRight = 0;
            this.btnAdmin.IconRightVisible = true;
            this.btnAdmin.IconRightZoom = 0D;
            this.btnAdmin.IconVisible = true;
            this.btnAdmin.IconZoom = 50D;
            this.btnAdmin.IsTab = false;
            this.btnAdmin.Location = new System.Drawing.Point(295, 300);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAdmin.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAdmin.OnHoverTextColor = System.Drawing.Color.Red;
            this.btnAdmin.selected = false;
            this.btnAdmin.Size = new System.Drawing.Size(130, 53);
            this.btnAdmin.TabIndex = 68;
            this.btnAdmin.Text = "Duyệt";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Textcolor = System.Drawing.Color.Black;
            this.btnAdmin.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // _frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(474, 379);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgvAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "_frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phê Duyệt Tài Khoản";
            this.Load += new System.EventHandler(this._frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvAccount;
        public System.Windows.Forms.TextBox tbAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdmin;
    }
}