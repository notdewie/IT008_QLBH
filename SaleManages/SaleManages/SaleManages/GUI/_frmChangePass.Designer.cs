namespace SaleManages.GUI
{
    partial class _frmChangePass
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_frmChangePass));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAccept = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbCheckPass = new System.Windows.Forms.TextBox();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.lbCheckPass = new System.Windows.Forms.Label();
            this.lbNewPass = new System.Windows.Forms.Label();
            this.tbOldPass = new System.Windows.Forms.TextBox();
            this.lbOldPass = new System.Windows.Forms.Label();
            this.btTitle = new System.Windows.Forms.Label();
            this.epOldPass = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNewPass = new System.Windows.Forms.ErrorProvider(this.components);
            this.epReNewPass = new System.Windows.Forms.ErrorProvider(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epOldPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNewPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epReNewPass)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.Controls.Add(this.btnAccept);
            this.bunifuGradientPanel1.Controls.Add(this.tbCheckPass);
            this.bunifuGradientPanel1.Controls.Add(this.tbNewPass);
            this.bunifuGradientPanel1.Controls.Add(this.lbCheckPass);
            this.bunifuGradientPanel1.Controls.Add(this.lbNewPass);
            this.bunifuGradientPanel1.Controls.Add(this.tbOldPass);
            this.bunifuGradientPanel1.Controls.Add(this.lbOldPass);
            this.bunifuGradientPanel1.Controls.Add(this.btTitle);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.LightSteelBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.LightSteelBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Indigo;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(300, 416);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(9, 10);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(22, 24);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 8;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAccept.BackColor = System.Drawing.Color.Transparent;
            this.btnAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccept.BorderRadius = 0;
            this.btnAccept.ButtonText = "Xác Nhận";
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.DisabledColor = System.Drawing.Color.Gray;
            this.btnAccept.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAccept.Iconimage = null;
            this.btnAccept.Iconimage_right = null;
            this.btnAccept.Iconimage_right_Selected = null;
            this.btnAccept.Iconimage_Selected = null;
            this.btnAccept.IconMarginLeft = 0;
            this.btnAccept.IconMarginRight = 0;
            this.btnAccept.IconRightVisible = true;
            this.btnAccept.IconRightZoom = 0D;
            this.btnAccept.IconVisible = true;
            this.btnAccept.IconZoom = 90D;
            this.btnAccept.IsTab = false;
            this.btnAccept.Location = new System.Drawing.Point(67, 344);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAccept.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAccept.OnHoverTextColor = System.Drawing.Color.Red;
            this.btnAccept.selected = false;
            this.btnAccept.Size = new System.Drawing.Size(151, 48);
            this.btnAccept.TabIndex = 7;
            this.btnAccept.Text = "Xác Nhận";
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAccept.Textcolor = System.Drawing.Color.White;
            this.btnAccept.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // tbCheckPass
            // 
            this.tbCheckPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCheckPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCheckPass.Location = new System.Drawing.Point(49, 301);
            this.tbCheckPass.Margin = new System.Windows.Forms.Padding(2);
            this.tbCheckPass.Name = "tbCheckPass";
            this.tbCheckPass.Size = new System.Drawing.Size(188, 22);
            this.tbCheckPass.TabIndex = 6;
            this.tbCheckPass.Validating += new System.ComponentModel.CancelEventHandler(this.tbCheckPass_Validating);
            // 
            // tbNewPass
            // 
            this.tbNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNewPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPass.Location = new System.Drawing.Point(49, 242);
            this.tbNewPass.Margin = new System.Windows.Forms.Padding(2);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.Size = new System.Drawing.Size(188, 22);
            this.tbNewPass.TabIndex = 5;
            this.tbNewPass.Validating += new System.ComponentModel.CancelEventHandler(this.tbNewPass_Validating);
            // 
            // lbCheckPass
            // 
            this.lbCheckPass.AutoSize = true;
            this.lbCheckPass.BackColor = System.Drawing.Color.Transparent;
            this.lbCheckPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckPass.ForeColor = System.Drawing.Color.White;
            this.lbCheckPass.Location = new System.Drawing.Point(45, 281);
            this.lbCheckPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCheckPass.Name = "lbCheckPass";
            this.lbCheckPass.Size = new System.Drawing.Size(151, 20);
            this.lbCheckPass.TabIndex = 4;
            this.lbCheckPass.Text = "Xác nhận mật khẩu:";
            // 
            // lbNewPass
            // 
            this.lbNewPass.AutoSize = true;
            this.lbNewPass.BackColor = System.Drawing.Color.Transparent;
            this.lbNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPass.ForeColor = System.Drawing.Color.White;
            this.lbNewPass.Location = new System.Drawing.Point(45, 222);
            this.lbNewPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNewPass.Name = "lbNewPass";
            this.lbNewPass.Size = new System.Drawing.Size(108, 20);
            this.lbNewPass.TabIndex = 3;
            this.lbNewPass.Text = "Mật khẩu mới:";
            // 
            // tbOldPass
            // 
            this.tbOldPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOldPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOldPass.Location = new System.Drawing.Point(49, 184);
            this.tbOldPass.Margin = new System.Windows.Forms.Padding(2);
            this.tbOldPass.Name = "tbOldPass";
            this.tbOldPass.Size = new System.Drawing.Size(188, 22);
            this.tbOldPass.TabIndex = 2;
            this.tbOldPass.Validating += new System.ComponentModel.CancelEventHandler(this.tbOldPass_Validating);
            // 
            // lbOldPass
            // 
            this.lbOldPass.AutoSize = true;
            this.lbOldPass.BackColor = System.Drawing.Color.Transparent;
            this.lbOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldPass.ForeColor = System.Drawing.Color.White;
            this.lbOldPass.Location = new System.Drawing.Point(45, 162);
            this.lbOldPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOldPass.Name = "lbOldPass";
            this.lbOldPass.Size = new System.Drawing.Size(100, 20);
            this.lbOldPass.TabIndex = 1;
            this.lbOldPass.Text = "Mật khẩu cũ:";
            // 
            // btTitle
            // 
            this.btTitle.AutoSize = true;
            this.btTitle.BackColor = System.Drawing.Color.Transparent;
            this.btTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTitle.ForeColor = System.Drawing.Color.White;
            this.btTitle.Location = new System.Drawing.Point(53, 103);
            this.btTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btTitle.Name = "btTitle";
            this.btTitle.Size = new System.Drawing.Size(185, 37);
            this.btTitle.TabIndex = 0;
            this.btTitle.Text = "Đổi Mật Khẩu";
            // 
            // epOldPass
            // 
            this.epOldPass.ContainerControl = this;
            // 
            // epNewPass
            // 
            this.epNewPass.ContainerControl = this;
            // 
            // epReNewPass
            // 
            this.epReNewPass.ContainerControl = this;
            // 
            // _frmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 416);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "_frmChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_frmChangePass";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epOldPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNewPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epReNewPass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label btTitle;
        private Bunifu.Framework.UI.BunifuFlatButton btnAccept;
        public System.Windows.Forms.TextBox tbCheckPass;
        public System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.Label lbCheckPass;
        private System.Windows.Forms.Label lbNewPass;
        public System.Windows.Forms.TextBox tbOldPass;
        private System.Windows.Forms.Label lbOldPass;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.ErrorProvider epOldPass;
        private System.Windows.Forms.ErrorProvider epNewPass;
        private System.Windows.Forms.ErrorProvider epReNewPass;
    }
}