namespace SaleManages
{
    partial class frmCreateAcc
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
            this.lbCreateAcc = new System.Windows.Forms.Label();
            this.pnlCreateAcc = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbUseTerm = new System.Windows.Forms.Label();
            this.lbAccept = new System.Windows.Forms.Label();
            this.bttCreateAccSign = new System.Windows.Forms.Button();
            this.rbCreateAccKhac = new System.Windows.Forms.RadioButton();
            this.rbCreateAccNu = new System.Windows.Forms.RadioButton();
            this.rbCreateAccNam = new System.Windows.Forms.RadioButton();
            this.dtpCreateAccBirth = new System.Windows.Forms.DateTimePicker();
            this.lbCreateAccSex = new System.Windows.Forms.Label();
            this.txboxCreateAccRePass = new System.Windows.Forms.TextBox();
            this.txbCreateAccPass = new System.Windows.Forms.TextBox();
            this.txbCreateAccTK = new System.Windows.Forms.TextBox();
            this.lbCreateAccBirth = new System.Windows.Forms.Label();
            this.txbCreateAccName = new System.Windows.Forms.TextBox();
            this.lbBack = new System.Windows.Forms.Label();
            this.pnlCreateAcc.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCreateAcc
            // 
            this.lbCreateAcc.AutoSize = true;
            this.lbCreateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreateAcc.Location = new System.Drawing.Point(246, 60);
            this.lbCreateAcc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCreateAcc.Name = "lbCreateAcc";
            this.lbCreateAcc.Size = new System.Drawing.Size(289, 39);
            this.lbCreateAcc.TabIndex = 0;
            this.lbCreateAcc.Text = "Đăng kí tài khoản ";
            // 
            // pnlCreateAcc
            // 
            this.pnlCreateAcc.Controls.Add(this.textBox1);
            this.pnlCreateAcc.Controls.Add(this.lbUseTerm);
            this.pnlCreateAcc.Controls.Add(this.lbAccept);
            this.pnlCreateAcc.Controls.Add(this.bttCreateAccSign);
            this.pnlCreateAcc.Controls.Add(this.rbCreateAccKhac);
            this.pnlCreateAcc.Controls.Add(this.rbCreateAccNu);
            this.pnlCreateAcc.Controls.Add(this.rbCreateAccNam);
            this.pnlCreateAcc.Controls.Add(this.dtpCreateAccBirth);
            this.pnlCreateAcc.Controls.Add(this.lbCreateAccSex);
            this.pnlCreateAcc.Controls.Add(this.txboxCreateAccRePass);
            this.pnlCreateAcc.Controls.Add(this.txbCreateAccPass);
            this.pnlCreateAcc.Controls.Add(this.txbCreateAccTK);
            this.pnlCreateAcc.Controls.Add(this.lbCreateAccBirth);
            this.pnlCreateAcc.Controls.Add(this.txbCreateAccName);
            this.pnlCreateAcc.Location = new System.Drawing.Point(230, 93);
            this.pnlCreateAcc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlCreateAcc.Name = "pnlCreateAcc";
            this.pnlCreateAcc.Size = new System.Drawing.Size(493, 426);
            this.pnlCreateAcc.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(22, 119);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(447, 30);
            this.textBox1.TabIndex = 28;
            this.textBox1.Text = "Email";
            // 
            // lbUseTerm
            // 
            this.lbUseTerm.AutoSize = true;
            this.lbUseTerm.BackColor = System.Drawing.Color.Bisque;
            this.lbUseTerm.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUseTerm.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbUseTerm.Location = new System.Drawing.Point(20, 392);
            this.lbUseTerm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUseTerm.Name = "lbUseTerm";
            this.lbUseTerm.Size = new System.Drawing.Size(136, 16);
            this.lbUseTerm.TabIndex = 27;
            this.lbUseTerm.Text = "Điều khoản sử dụng";
            this.lbUseTerm.Click += new System.EventHandler(this.lbUseTerm_Click);
            // 
            // lbAccept
            // 
            this.lbAccept.AutoSize = true;
            this.lbAccept.Font = new System.Drawing.Font("Arial", 10F);
            this.lbAccept.Location = new System.Drawing.Point(20, 377);
            this.lbAccept.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAccept.Name = "lbAccept";
            this.lbAccept.Size = new System.Drawing.Size(271, 16);
            this.lbAccept.TabIndex = 26;
            this.lbAccept.Text = "Bằng việc nhấn nút đăng kí tôi đã đồng ý ";
            // 
            // bttCreateAccSign
            // 
            this.bttCreateAccSign.BackColor = System.Drawing.Color.RoyalBlue;
            this.bttCreateAccSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCreateAccSign.ForeColor = System.Drawing.Color.White;
            this.bttCreateAccSign.Location = new System.Drawing.Point(331, 362);
            this.bttCreateAccSign.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttCreateAccSign.Name = "bttCreateAccSign";
            this.bttCreateAccSign.Size = new System.Drawing.Size(138, 46);
            this.bttCreateAccSign.TabIndex = 25;
            this.bttCreateAccSign.Text = "Đăng kí";
            this.bttCreateAccSign.UseVisualStyleBackColor = false;
            // 
            // rbCreateAccKhac
            // 
            this.rbCreateAccKhac.AutoSize = true;
            this.rbCreateAccKhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCreateAccKhac.Location = new System.Drawing.Point(287, 320);
            this.rbCreateAccKhac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbCreateAccKhac.Name = "rbCreateAccKhac";
            this.rbCreateAccKhac.Size = new System.Drawing.Size(76, 29);
            this.rbCreateAccKhac.TabIndex = 24;
            this.rbCreateAccKhac.TabStop = true;
            this.rbCreateAccKhac.Text = "Khác";
            this.rbCreateAccKhac.UseVisualStyleBackColor = true;
            // 
            // rbCreateAccNu
            // 
            this.rbCreateAccNu.AutoSize = true;
            this.rbCreateAccNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCreateAccNu.Location = new System.Drawing.Point(216, 320);
            this.rbCreateAccNu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbCreateAccNu.Name = "rbCreateAccNu";
            this.rbCreateAccNu.Size = new System.Drawing.Size(55, 29);
            this.rbCreateAccNu.TabIndex = 23;
            this.rbCreateAccNu.TabStop = true;
            this.rbCreateAccNu.Text = "Nữ";
            this.rbCreateAccNu.UseVisualStyleBackColor = true;
            // 
            // rbCreateAccNam
            // 
            this.rbCreateAccNam.AutoSize = true;
            this.rbCreateAccNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCreateAccNam.Location = new System.Drawing.Point(123, 320);
            this.rbCreateAccNam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbCreateAccNam.Name = "rbCreateAccNam";
            this.rbCreateAccNam.Size = new System.Drawing.Size(71, 29);
            this.rbCreateAccNam.TabIndex = 22;
            this.rbCreateAccNam.TabStop = true;
            this.rbCreateAccNam.Text = "Nam";
            this.rbCreateAccNam.UseVisualStyleBackColor = true;
            // 
            // dtpCreateAccBirth
            // 
            this.dtpCreateAccBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCreateAccBirth.Location = new System.Drawing.Point(123, 275);
            this.dtpCreateAccBirth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpCreateAccBirth.Name = "dtpCreateAccBirth";
            this.dtpCreateAccBirth.Size = new System.Drawing.Size(305, 26);
            this.dtpCreateAccBirth.TabIndex = 21;
            // 
            // lbCreateAccSex
            // 
            this.lbCreateAccSex.AutoSize = true;
            this.lbCreateAccSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreateAccSex.Location = new System.Drawing.Point(19, 322);
            this.lbCreateAccSex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCreateAccSex.Name = "lbCreateAccSex";
            this.lbCreateAccSex.Size = new System.Drawing.Size(88, 25);
            this.lbCreateAccSex.TabIndex = 6;
            this.lbCreateAccSex.Text = "Giới tính:";
            // 
            // txboxCreateAccRePass
            // 
            this.txboxCreateAccRePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txboxCreateAccRePass.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txboxCreateAccRePass.Location = new System.Drawing.Point(22, 228);
            this.txboxCreateAccRePass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txboxCreateAccRePass.Name = "txboxCreateAccRePass";
            this.txboxCreateAccRePass.Size = new System.Drawing.Size(405, 30);
            this.txboxCreateAccRePass.TabIndex = 20;
            this.txboxCreateAccRePass.Text = "Xác nhận mật khẩu";
            // 
            // txbCreateAccPass
            // 
            this.txbCreateAccPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCreateAccPass.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbCreateAccPass.Location = new System.Drawing.Point(22, 176);
            this.txbCreateAccPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbCreateAccPass.Name = "txbCreateAccPass";
            this.txbCreateAccPass.Size = new System.Drawing.Size(447, 30);
            this.txbCreateAccPass.TabIndex = 18;
            this.txbCreateAccPass.Text = "Mật khẩu";
            // 
            // txbCreateAccTK
            // 
            this.txbCreateAccTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCreateAccTK.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbCreateAccTK.Location = new System.Drawing.Point(22, 65);
            this.txbCreateAccTK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbCreateAccTK.Name = "txbCreateAccTK";
            this.txbCreateAccTK.Size = new System.Drawing.Size(447, 30);
            this.txbCreateAccTK.TabIndex = 17;
            this.txbCreateAccTK.Text = "Tài khoản";
            // 
            // lbCreateAccBirth
            // 
            this.lbCreateAccBirth.AutoSize = true;
            this.lbCreateAccBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreateAccBirth.Location = new System.Drawing.Point(19, 276);
            this.lbCreateAccBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCreateAccBirth.Name = "lbCreateAccBirth";
            this.lbCreateAccBirth.Size = new System.Drawing.Size(105, 25);
            this.lbCreateAccBirth.TabIndex = 3;
            this.lbCreateAccBirth.Text = "Ngày sinh:";
            // 
            // txbCreateAccName
            // 
            this.txbCreateAccName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCreateAccName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbCreateAccName.Location = new System.Drawing.Point(22, 15);
            this.txbCreateAccName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbCreateAccName.Name = "txbCreateAccName";
            this.txbCreateAccName.Size = new System.Drawing.Size(447, 30);
            this.txbCreateAccName.TabIndex = 16;
            this.txbCreateAccName.Text = "Họ tên đầy đủ";
            // 
            // lbBack
            // 
            this.lbBack.AutoSize = true;
            this.lbBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBack.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbBack.Location = new System.Drawing.Point(9, 7);
            this.lbBack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(93, 39);
            this.lbBack.TabIndex = 18;
            this.lbBack.Text = "Back";
            this.lbBack.Click += new System.EventHandler(this.lbBack_Click);
            // 
            // frmCreateAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(926, 579);
            this.Controls.Add(this.lbBack);
            this.Controls.Add(this.pnlCreateAcc);
            this.Controls.Add(this.lbCreateAcc);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCreateAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCreateAcc";
            this.pnlCreateAcc.ResumeLayout(false);
            this.pnlCreateAcc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbCreateAcc;
        private System.Windows.Forms.Panel pnlCreateAcc;
        private System.Windows.Forms.Label lbUseTerm;
        private System.Windows.Forms.Label lbAccept;
        private System.Windows.Forms.Button bttCreateAccSign;
        private System.Windows.Forms.RadioButton rbCreateAccKhac;
        private System.Windows.Forms.RadioButton rbCreateAccNu;
        private System.Windows.Forms.RadioButton rbCreateAccNam;
        private System.Windows.Forms.DateTimePicker dtpCreateAccBirth;
        private System.Windows.Forms.Label lbCreateAccSex;
        private System.Windows.Forms.TextBox txboxCreateAccRePass;
        private System.Windows.Forms.TextBox txbCreateAccPass;
        private System.Windows.Forms.TextBox txbCreateAccTK;
        private System.Windows.Forms.Label lbCreateAccBirth;
        private System.Windows.Forms.TextBox txbCreateAccName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbBack;
    }
}