namespace SaleManages.GUI
{
    partial class _frmUseTerm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_frmUseTerm));
            this.rtbUseTerm = new System.Windows.Forms.RichTextBox();
            this.lbUseTerm = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbUseTerm
            // 
            this.rtbUseTerm.Location = new System.Drawing.Point(37, 63);
            this.rtbUseTerm.Name = "rtbUseTerm";
            this.rtbUseTerm.ReadOnly = true;
            this.rtbUseTerm.Size = new System.Drawing.Size(414, 279);
            this.rtbUseTerm.TabIndex = 0;
            this.rtbUseTerm.Text = resources.GetString("rtbUseTerm.Text");
            // 
            // lbUseTerm
            // 
            this.lbUseTerm.AutoSize = true;
            this.lbUseTerm.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUseTerm.Location = new System.Drawing.Point(31, 23);
            this.lbUseTerm.Name = "lbUseTerm";
            this.lbUseTerm.Size = new System.Drawing.Size(263, 37);
            this.lbUseTerm.TabIndex = 1;
            this.lbUseTerm.Text = "Điều khoản sử dụng";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(376, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _frmUseTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 391);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbUseTerm);
            this.Controls.Add(this.rtbUseTerm);
            this.Name = "_frmUseTerm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điều Khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbUseTerm;
        private System.Windows.Forms.Label lbUseTerm;
        private System.Windows.Forms.Button button1;
    }
}