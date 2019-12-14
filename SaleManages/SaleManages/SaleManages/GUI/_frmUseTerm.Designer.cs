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
            this.rtbUseTerm = new System.Windows.Forms.RichTextBox();
            this.lbUseTerm = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbUseTerm
            // 
            this.rtbUseTerm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbUseTerm.Location = new System.Drawing.Point(74, 121);
            this.rtbUseTerm.Margin = new System.Windows.Forms.Padding(6);
            this.rtbUseTerm.Name = "rtbUseTerm";
            this.rtbUseTerm.Size = new System.Drawing.Size(824, 533);
            this.rtbUseTerm.TabIndex = 0;
            this.rtbUseTerm.Text = "";
            // 
            // lbUseTerm
            // 
            this.lbUseTerm.AutoSize = true;
            this.lbUseTerm.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUseTerm.Location = new System.Drawing.Point(62, 43);
            this.lbUseTerm.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbUseTerm.Name = "lbUseTerm";
            this.lbUseTerm.Size = new System.Drawing.Size(527, 72);
            this.lbUseTerm.TabIndex = 1;
            this.lbUseTerm.Text = "Điều khoản sử dụng";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(752, 685);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 44);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // _frmUseTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(968, 752);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbUseTerm);
            this.Controls.Add(this.rtbUseTerm);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "_frmUseTerm";
            this.Text = "_frmUseTerm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbUseTerm;
        private System.Windows.Forms.Label lbUseTerm;
        private System.Windows.Forms.Button btnClose;
    }
}