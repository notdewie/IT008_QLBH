namespace SaleManages.GUI
{
    partial class _frmCreateAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_frmCreateAcc));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnReg = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbUseTerm = new System.Windows.Forms.Label();
            this.lbAccept = new System.Windows.Forms.Label();
            this.rbElse = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.dateBirth = new MetroFramework.Controls.MetroDateTime();
            this.tbEmail = new SaleManages.DTO.PlaceHolderTextBox();
            this.tbCheckPass = new SaleManages.DTO.PlaceHolderTextBox();
            this.tbName = new SaleManages.DTO.PlaceHolderTextBox();
            this.tbPass = new SaleManages.DTO.PlaceHolderTextBox();
            this.tbUsername = new SaleManages.DTO.PlaceHolderTextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.epUserName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epFullName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epEMail = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPass = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCheckPass = new System.Windows.Forms.ErrorProvider(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCheckPass)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnReg);
            this.bunifuGradientPanel1.Controls.Add(this.lbUseTerm);
            this.bunifuGradientPanel1.Controls.Add(this.lbAccept);
            this.bunifuGradientPanel1.Controls.Add(this.rbElse);
            this.bunifuGradientPanel1.Controls.Add(this.rbFemale);
            this.bunifuGradientPanel1.Controls.Add(this.rbMale);
            this.bunifuGradientPanel1.Controls.Add(this.dateBirth);
            this.bunifuGradientPanel1.Controls.Add(this.tbEmail);
            this.bunifuGradientPanel1.Controls.Add(this.tbCheckPass);
            this.bunifuGradientPanel1.Controls.Add(this.tbName);
            this.bunifuGradientPanel1.Controls.Add(this.tbPass);
            this.bunifuGradientPanel1.Controls.Add(this.tbUsername);
            this.bunifuGradientPanel1.Controls.Add(this.lbTitle);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.LightSteelBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.LightSteelBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Indigo;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(300, 400);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btnReg
            // 
            this.btnReg.Activecolor = System.Drawing.Color.Transparent;
            this.btnReg.BackColor = System.Drawing.Color.Transparent;
            this.btnReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReg.BorderRadius = 0;
            this.btnReg.ButtonText = "Đăng Ký";
            this.btnReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReg.DisabledColor = System.Drawing.Color.Gray;
            this.btnReg.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReg.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReg.Iconimage")));
            this.btnReg.Iconimage_right = null;
            this.btnReg.Iconimage_right_Selected = null;
            this.btnReg.Iconimage_Selected = null;
            this.btnReg.IconMarginLeft = 0;
            this.btnReg.IconMarginRight = 0;
            this.btnReg.IconRightVisible = true;
            this.btnReg.IconRightZoom = 0D;
            this.btnReg.IconVisible = true;
            this.btnReg.IconZoom = 80D;
            this.btnReg.IsTab = false;
            this.btnReg.Location = new System.Drawing.Point(140, 310);
            this.btnReg.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.btnReg.Name = "btnReg";
            this.btnReg.Normalcolor = System.Drawing.Color.Transparent;
            this.btnReg.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnReg.OnHoverTextColor = System.Drawing.Color.Red;
            this.btnReg.selected = false;
            this.btnReg.Size = new System.Drawing.Size(164, 41);
            this.btnReg.TabIndex = 10;
            this.btnReg.TabStop = false;
            this.btnReg.Text = "Đăng Ký";
            this.btnReg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReg.Textcolor = System.Drawing.Color.White;
            this.btnReg.TextFont = new System.Drawing.Font("Segoe UI Light", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // lbUseTerm
            // 
            this.lbUseTerm.AutoSize = true;
            this.lbUseTerm.BackColor = System.Drawing.Color.Transparent;
            this.lbUseTerm.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUseTerm.ForeColor = System.Drawing.Color.DarkRed;
            this.lbUseTerm.Location = new System.Drawing.Point(1, 379);
            this.lbUseTerm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUseTerm.Name = "lbUseTerm";
            this.lbUseTerm.Size = new System.Drawing.Size(206, 30);
            this.lbUseTerm.TabIndex = 29;
            this.lbUseTerm.Text = "Điều khoản sử dụng";
            this.lbUseTerm.Click += new System.EventHandler(this.lbUseTerm_Click);
            // 
            // lbAccept
            // 
            this.lbAccept.AutoSize = true;
            this.lbAccept.BackColor = System.Drawing.Color.Transparent;
            this.lbAccept.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccept.ForeColor = System.Drawing.Color.Black;
            this.lbAccept.Location = new System.Drawing.Point(1, 360);
            this.lbAccept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAccept.Name = "lbAccept";
            this.lbAccept.Size = new System.Drawing.Size(414, 30);
            this.lbAccept.TabIndex = 28;
            this.lbAccept.Text = "Bằng việc nhấn nút đăng kí tôi đã đồng ý ";
            // 
            // rbElse
            // 
            this.rbElse.AutoSize = true;
            this.rbElse.BackColor = System.Drawing.Color.Transparent;
            this.rbElse.ForeColor = System.Drawing.Color.White;
            this.rbElse.Location = new System.Drawing.Point(208, 290);
            this.rbElse.Name = "rbElse";
            this.rbElse.Size = new System.Drawing.Size(101, 41);
            this.rbElse.TabIndex = 9;
            this.rbElse.Text = "Khác";
            this.rbElse.UseVisualStyleBackColor = false;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.BackColor = System.Drawing.Color.Transparent;
            this.rbFemale.ForeColor = System.Drawing.Color.White;
            this.rbFemale.Location = new System.Drawing.Point(135, 290);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(82, 41);
            this.rbFemale.TabIndex = 8;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = false;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.BackColor = System.Drawing.Color.Transparent;
            this.rbMale.ForeColor = System.Drawing.Color.White;
            this.rbMale.Location = new System.Drawing.Point(70, 290);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(102, 41);
            this.rbMale.TabIndex = 7;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = false;
            // 
            // dateBirth
            // 
            this.dateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBirth.Location = new System.Drawing.Point(80, 240);
            this.dateBirth.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(140, 43);
            this.dateBirth.TabIndex = 6;
            this.dateBirth.TabStop = false;
            this.dateBirth.MouseHover += new System.EventHandler(this.metroDateTime1_MouseHover);
            // 
            // tbEmail
            // 
            this.tbEmail.CausesValidation = false;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Italic);
            this.tbEmail.ForeColor = System.Drawing.Color.Gray;
            this.tbEmail.Location = new System.Drawing.Point(80, 156);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PlaceHolderText = null;
            this.tbEmail.Size = new System.Drawing.Size(140, 31);
            this.tbEmail.TabIndex = 3;
            this.tbEmail.TabStop = false;
            this.tbEmail.Text = "Nhập email";
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            // 
            // tbCheckPass
            // 
            this.tbCheckPass.CausesValidation = false;
            this.tbCheckPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Italic);
            this.tbCheckPass.ForeColor = System.Drawing.Color.Gray;
            this.tbCheckPass.Location = new System.Drawing.Point(80, 212);
            this.tbCheckPass.Name = "tbCheckPass";
            this.tbCheckPass.PlaceHolderText = null;
            this.tbCheckPass.Size = new System.Drawing.Size(140, 31);
            this.tbCheckPass.TabIndex = 5;
            this.tbCheckPass.TabStop = false;
            this.tbCheckPass.Text = "Xác nhận mật khẩu";
            this.tbCheckPass.Validating += new System.ComponentModel.CancelEventHandler(this.tbCheckPass_Validating);
            // 
            // tbName
            // 
            this.tbName.CausesValidation = false;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Italic);
            this.tbName.ForeColor = System.Drawing.Color.Gray;
            this.tbName.Location = new System.Drawing.Point(80, 128);
            this.tbName.Name = "tbName";
            this.tbName.PlaceHolderText = null;
            this.tbName.Size = new System.Drawing.Size(140, 31);
            this.tbName.TabIndex = 3;
            this.tbName.TabStop = false;
            this.tbName.Text = "Nhập họ tên";
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // tbPass
            // 
            this.tbPass.CausesValidation = false;
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Italic);
            this.tbPass.ForeColor = System.Drawing.Color.Gray;
            this.tbPass.Location = new System.Drawing.Point(80, 184);
            this.tbPass.Name = "tbPass";
            this.tbPass.PlaceHolderText = null;
            this.tbPass.Size = new System.Drawing.Size(140, 31);
            this.tbPass.TabIndex = 4;
            this.tbPass.TabStop = false;
            this.tbPass.Text = "Nhập mật khẩu";
            this.tbPass.Validating += new System.ComponentModel.CancelEventHandler(this.tbPass_Validating);
            // 
            // tbUsername
            // 
            this.tbUsername.CausesValidation = false;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Italic);
            this.tbUsername.ForeColor = System.Drawing.Color.Gray;
            this.tbUsername.Location = new System.Drawing.Point(80, 100);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PlaceHolderText = null;
            this.tbUsername.Size = new System.Drawing.Size(140, 31);
            this.tbUsername.TabIndex = 2;
            this.tbUsername.TabStop = false;
            this.tbUsername.Text = "Nhập tên đăng nhập";
            this.tbUsername.Validating += new System.ComponentModel.CancelEventHandler(this.tbUsername_Validating);
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(92, 33);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(159, 51);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Đăng Ký";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(5, 5);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // epUserName
            // 
            this.epUserName.ContainerControl = this;
            // 
            // epFullName
            // 
            this.epFullName.ContainerControl = this;
            // 
            // epEMail
            // 
            this.epEMail.ContainerControl = this;
            // 
            // epPass
            // 
            this.epPass.ContainerControl = this;
            // 
            // epCheckPass
            // 
            this.epCheckPass.ContainerControl = this;
            // 
            // _frmCreateAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "_frmCreateAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_frmCreateAcc";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCheckPass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lbTitle;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        public DTO.PlaceHolderTextBox tbUsername;
        public DTO.PlaceHolderTextBox tbPass;
        public DTO.PlaceHolderTextBox tbCheckPass;
        public DTO.PlaceHolderTextBox tbName;
        public DTO.PlaceHolderTextBox tbEmail;
        public MetroFramework.Controls.MetroDateTime dateBirth;
        public System.Windows.Forms.RadioButton rbElse;
        public System.Windows.Forms.RadioButton rbFemale;
        public System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lbUseTerm;
        private System.Windows.Forms.Label lbAccept;
        private Bunifu.Framework.UI.BunifuFlatButton btnReg;
        private System.Windows.Forms.ErrorProvider epUserName;
        private System.Windows.Forms.ErrorProvider epFullName;
        private System.Windows.Forms.ErrorProvider epEMail;
        private System.Windows.Forms.ErrorProvider epPass;
        private System.Windows.Forms.ErrorProvider epCheckPass;
    }
}