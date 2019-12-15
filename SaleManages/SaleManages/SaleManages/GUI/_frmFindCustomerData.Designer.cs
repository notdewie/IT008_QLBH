namespace SaleManages.GUI
{
    partial class _frmFindCustomerData
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFindemData = new System.Windows.Forms.Button();
            this.tbFindemData = new System.Windows.Forms.TextBox();
            this.lbFindcusData = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFindemData);
            this.panel1.Controls.Add(this.tbFindemData);
            this.panel1.Controls.Add(this.lbFindcusData);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 155);
            this.panel1.TabIndex = 0;
            // 
            // btnFindemData
            // 
            this.btnFindemData.Location = new System.Drawing.Point(366, 69);
            this.btnFindemData.Name = "btnFindemData";
            this.btnFindemData.Size = new System.Drawing.Size(75, 23);
            this.btnFindemData.TabIndex = 2;
            this.btnFindemData.Text = "Tìm";
            this.btnFindemData.UseVisualStyleBackColor = true;
            this.btnFindemData.Click += new System.EventHandler(this.btnFindcusData_Click);
            // 
            // tbFindemData
            // 
            this.tbFindemData.Location = new System.Drawing.Point(120, 71);
            this.tbFindemData.Name = "tbFindemData";
            this.tbFindemData.Size = new System.Drawing.Size(219, 20);
            this.tbFindemData.TabIndex = 1;
            // 
            // lbFindcusData
            // 
            this.lbFindcusData.AutoSize = true;
            this.lbFindcusData.Location = new System.Drawing.Point(28, 74);
            this.lbFindcusData.Name = "lbFindcusData";
            this.lbFindcusData.Size = new System.Drawing.Size(89, 13);
            this.lbFindcusData.TabIndex = 0;
            this.lbFindcusData.Text = "Tên khách hàng:";
            // 
            // _frmFindCustomerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 159);
            this.Controls.Add(this.panel1);
            this.Name = "_frmFindCustomerData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm khách hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFindemData;
        public System.Windows.Forms.TextBox tbFindemData;
        private System.Windows.Forms.Label lbFindcusData;
    }
}