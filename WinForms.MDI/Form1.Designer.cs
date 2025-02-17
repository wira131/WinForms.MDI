namespace WinForms.MDI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            mnuLogin = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            mnuManageProduct = new ToolStripMenuItem();
            mnuProductCategory = new ToolStripMenuItem();
            mnuEmployee = new ToolStripMenuItem();
            mnuReport = new ToolStripMenuItem();
            mnuLogout = new ToolStripMenuItem();
            menuStrip3 = new MenuStrip();
            mnuSellProducts = new ToolStripMenuItem();
            mnuSalesReport = new ToolStripMenuItem();
            mnuManagerLogout = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            menuStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(927, 470);
            button1.Name = "button1";
            button1.Size = new Size(99, 49);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(1032, 463);
            button2.Name = "button2";
            button2.Size = new Size(95, 56);
            button2.TabIndex = 1;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(991, 432);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuLogin, mnuExit });
            menuStrip1.Location = new Point(0, 56);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1139, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuLogin
            // 
            mnuLogin.Name = "mnuLogin";
            mnuLogin.Size = new Size(80, 24);
            mnuLogin.Text = "เข้าสู่ระบบ";
            mnuLogin.Click += mnuLogin_Click;
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(90, 24);
            mnuExit.Text = "ปิดโปรแกรม";
            mnuExit.Click += mnuExit_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { mnuManageProduct, mnuProductCategory, mnuEmployee, mnuReport, mnuLogout });
            menuStrip2.Location = new Point(0, 28);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1139, 28);
            menuStrip2.TabIndex = 5;
            menuStrip2.Text = "menuStrip2";
            // 
            // mnuManageProduct
            // 
            mnuManageProduct.Name = "mnuManageProduct";
            mnuManageProduct.Size = new Size(128, 24);
            mnuManageProduct.Text = "จัดการข้อมูลสินค้า";
            mnuManageProduct.Click += mnuManageProduct_Click;
            // 
            // mnuProductCategory
            // 
            mnuProductCategory.Name = "mnuProductCategory";
            mnuProductCategory.Size = new Size(178, 24);
            mnuProductCategory.Text = "จัดการข้อมูลหมวดหมู่สินค้า";
            mnuProductCategory.Click += mnuProductCategory_Click;
            // 
            // mnuEmployee
            // 
            mnuEmployee.Name = "mnuEmployee";
            mnuEmployee.Size = new Size(145, 24);
            mnuEmployee.Text = "จัดการข้อมูลพนักงาน";
            // 
            // mnuReport
            // 
            mnuReport.Name = "mnuReport";
            mnuReport.Size = new Size(112, 24);
            mnuReport.Text = "รายงานการขาย";
            // 
            // mnuLogout
            // 
            mnuLogout.Name = "mnuLogout";
            mnuLogout.Size = new Size(101, 24);
            mnuLogout.Text = "ออกจากระบบ";
            mnuLogout.Click += mnuLogout_Click;
            // 
            // menuStrip3
            // 
            menuStrip3.ImageScalingSize = new Size(20, 20);
            menuStrip3.Items.AddRange(new ToolStripItem[] { mnuSellProducts, mnuSalesReport, mnuManagerLogout });
            menuStrip3.Location = new Point(0, 0);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.Size = new Size(1139, 28);
            menuStrip3.TabIndex = 6;
            menuStrip3.Text = "menuStrip3";
            // 
            // mnuSellProducts
            // 
            mnuSellProducts.Name = "mnuSellProducts";
            mnuSellProducts.Size = new Size(80, 24);
            mnuSellProducts.Text = "ขายสินค้า";
            mnuSellProducts.Click += mnuSellProducts_Click;
            // 
            // mnuSalesReport
            // 
            mnuSalesReport.Name = "mnuSalesReport";
            mnuSalesReport.Size = new Size(115, 24);
            mnuSalesReport.Text = "รายงานยอดขาย";
            mnuSalesReport.Click += mnuSalesReport_Click;
            // 
            // mnuManagerLogout
            // 
            mnuManagerLogout.Name = "mnuManagerLogout";
            mnuManagerLogout.Size = new Size(101, 24);
            mnuManagerLogout.Text = "ออกจากระบบ";
            mnuManagerLogout.Click += mnuManagerLogout_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 531);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            Controls.Add(menuStrip3);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Login";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            menuStrip3.ResumeLayout(false);
            menuStrip3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private MenuStrip menuStrip3;
        private ToolStripMenuItem mnuLogin;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuManageProduct;
        private ToolStripMenuItem mnuProductCategory;
        private ToolStripMenuItem mnuEmployee;
        private ToolStripMenuItem mnuReport;
        private ToolStripMenuItem mnuSellProducts;
        private ToolStripMenuItem mnuSalesReport;
        private ToolStripMenuItem mnuManagerLogout;
        private ToolStripMenuItem mnuLogout;
    }
}
