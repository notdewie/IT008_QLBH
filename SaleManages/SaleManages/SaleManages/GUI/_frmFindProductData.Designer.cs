namespace SaleManages.GUI
{
    partial class _frmFindProductData
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
            this.btnFindproData = new System.Windows.Forms.Button();
            this.tbFindproData = new System.Windows.Forms.TextBox();
            this.lbFindproData = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFindproData);
            this.panel1.Controls.Add(this.tbFindproData);
            this.panel1.Controls.Add(this.lbFindproData);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 155);
            this.panel1.TabIndex = 1;
            // 
            // btnFindproData
            // 
            this.btnFindproData.Location = new System.Drawing.Point(366, 69);
            this.btnFindproData.Name = "btnFindproData";
            this.btnFindproData.Size = new System.Drawing.Size(75, 23);
            this.btnFindproData.TabIndex = 2;
            this.btnFindproData.Text = "Tìm";
            this.btnFindproData.UseVisualStyleBackColor = true;
            this.btnFindproData.Click += new System.EventHandler(this.btnFindproData_Click);
            // 
            // tbFindproData
            // 
            this.tbFindproData.Location = new System.Drawing.Point(120, 71);
            this.tbFindproData.Name = "tbFindproData";
            this.tbFindproData.Size = new System.Drawing.Size(219, 20);
            this.tbFindproData.TabIndex = 1;
            // 
            // lbFindproData
            // 
            this.lbFindproData.AutoSize = true;
            this.lbFindproData.Location = new System.Drawing.Point(28, 74);
            this.lbFindproData.Name = "lbFindproData";
            this.lbFindproData.Size = new System.Drawing.Size(78, 13);
            this.lbFindproData.TabIndex = 0;
            this.lbFindproData.Text = "Tên sản phẩm:";
            // 
            // _frmFindProductData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 159);
            this.Controls.Add(this.panel1);
            this.Name = "_frmFindProductData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_frmFindProductData";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFindproData;
        public System.Windows.Forms.TextBox tbFindproData;
        private System.Windows.Forms.Label lbFindproData;
    }
}