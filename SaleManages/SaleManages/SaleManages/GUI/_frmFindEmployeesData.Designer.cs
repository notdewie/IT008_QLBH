namespace SaleManages.GUI
{
    partial class _frmFindEmployeesData
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
            this.lbFindemData = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFindemData);
            this.panel1.Controls.Add(this.tbFindemData);
            this.panel1.Controls.Add(this.lbFindemData);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 155);
            this.panel1.TabIndex = 1;
            // 
            // btnFindemData
            // 
            this.btnFindemData.Location = new System.Drawing.Point(366, 69);
            this.btnFindemData.Name = "btnFindemData";
            this.btnFindemData.Size = new System.Drawing.Size(75, 23);
            this.btnFindemData.TabIndex = 2;
            this.btnFindemData.Text = "Tìm";
            this.btnFindemData.UseVisualStyleBackColor = true;
            this.btnFindemData.Click += new System.EventHandler(this.btnFindemData_Click);
            // 
            // tbFindemData
            // 
            this.tbFindemData.Location = new System.Drawing.Point(120, 71);
            this.tbFindemData.Name = "tbFindemData";
            this.tbFindemData.Size = new System.Drawing.Size(219, 20);
            this.tbFindemData.TabIndex = 1;
            // 
            // lbFindemData
            // 
            this.lbFindemData.AutoSize = true;
            this.lbFindemData.Location = new System.Drawing.Point(28, 74);
            this.lbFindemData.Name = "lbFindemData";
            this.lbFindemData.Size = new System.Drawing.Size(79, 13);
            this.lbFindemData.TabIndex = 0;
            this.lbFindemData.Text = "Tên nhân viên:";
            // 
            // _frmFindEmployeesData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 159);
            this.Controls.Add(this.panel1);
            this.Name = "_frmFindEmployeesData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_frmFindEmployeesData";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFindemData;
        public System.Windows.Forms.TextBox tbFindemData;
        private System.Windows.Forms.Label lbFindemData;
    }
}