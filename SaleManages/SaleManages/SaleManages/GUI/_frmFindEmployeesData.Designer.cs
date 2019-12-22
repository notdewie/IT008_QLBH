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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_frmFindEmployeesData));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFindemData = new Bunifu.Framework.UI.BunifuTileButton();
            this.tbFindemData = new System.Windows.Forms.TextBox();
            this.lbFindemData = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
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
            this.btnFindemData.BackColor = System.Drawing.Color.White;
            this.btnFindemData.color = System.Drawing.Color.White;
            this.btnFindemData.colorActive = System.Drawing.Color.LightSkyBlue;
            this.btnFindemData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindemData.Font = new System.Drawing.Font("Segoe UI Light", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindemData.ForeColor = System.Drawing.Color.Black;
            this.btnFindemData.Image = ((System.Drawing.Image)(resources.GetObject("btnFindemData.Image")));
            this.btnFindemData.ImagePosition = 12;
            this.btnFindemData.ImageZoom = 50;
            this.btnFindemData.LabelPosition = 0;
            this.btnFindemData.LabelText = "";
            this.btnFindemData.Location = new System.Drawing.Point(361, 54);
            this.btnFindemData.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFindemData.Name = "btnFindemData";
            this.btnFindemData.Size = new System.Drawing.Size(50, 49);
            this.btnFindemData.TabIndex = 36;
            this.btnFindemData.Click += new System.EventHandler(this.btnFindemData_Click_1);
            // 
            // tbFindemData
            // 
            this.tbFindemData.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFindemData.Location = new System.Drawing.Point(125, 66);
            this.tbFindemData.Name = "tbFindemData";
            this.tbFindemData.Size = new System.Drawing.Size(219, 25);
            this.tbFindemData.TabIndex = 1;
            // 
            // lbFindemData
            // 
            this.lbFindemData.AutoSize = true;
            this.lbFindemData.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFindemData.Location = new System.Drawing.Point(27, 68);
            this.lbFindemData.Name = "lbFindemData";
            this.lbFindemData.Size = new System.Drawing.Size(97, 19);
            this.lbFindemData.TabIndex = 0;
            this.lbFindemData.Text = "Tên nhân viên:";
            // 
            // _frmFindEmployeesData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(485, 159);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "_frmFindEmployeesData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm nhân viên";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox tbFindemData;
        private System.Windows.Forms.Label lbFindemData;
        private Bunifu.Framework.UI.BunifuTileButton btnFindemData;
    }
}