namespace SaleManages
{
    partial class frmUseTerm
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
            this.label1 = new System.Windows.Forms.Label();
            this.bttSignBack = new System.Windows.Forms.Button();
            this.rtbUseTerm = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điều khoản sử dụng";
            // 
            // bttSignBack
            // 
            this.bttSignBack.BackColor = System.Drawing.Color.RoyalBlue;
            this.bttSignBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSignBack.ForeColor = System.Drawing.Color.White;
            this.bttSignBack.Location = new System.Drawing.Point(755, 500);
            this.bttSignBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttSignBack.Name = "bttSignBack";
            this.bttSignBack.Size = new System.Drawing.Size(152, 60);
            this.bttSignBack.TabIndex = 26;
            this.bttSignBack.Text = "Quay lại";
            this.bttSignBack.UseVisualStyleBackColor = false;
            this.bttSignBack.Click += new System.EventHandler(this.bttSignBack_Click);
            // 
            // rtbUseTerm
            // 
            this.rtbUseTerm.Location = new System.Drawing.Point(24, 81);
            this.rtbUseTerm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbUseTerm.Name = "rtbUseTerm";
            this.rtbUseTerm.Size = new System.Drawing.Size(855, 388);
            this.rtbUseTerm.TabIndex = 27;
            this.rtbUseTerm.Text = "";
            // 
            // frmUseTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(926, 579);
            this.Controls.Add(this.rtbUseTerm);
            this.Controls.Add(this.bttSignBack);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmUseTerm";
            this.Text = "frmUseTerm";
            this.Load += new System.EventHandler(this.frmUseTerm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttSignBack;
        private System.Windows.Forms.RichTextBox rtbUseTerm;
    }
}