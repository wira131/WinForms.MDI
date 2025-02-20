namespace WinFormMiniMart
{
    partial class main
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
            menuStrip1 = new MenuStrip();
            จดการToolStripMenuItem = new ToolStripMenuItem();
            mnu_Employees = new ToolStripMenuItem();
            mnu_Products = new ToolStripMenuItem();
            mnu_Categories = new ToolStripMenuItem();
            mnu_logout2 = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            mnu_Login = new ToolStripMenuItem();
            mnu_off = new ToolStripMenuItem();
            menuStrip3 = new MenuStrip();
            mnu_sell = new ToolStripMenuItem();
            mnu_logout1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            menuStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(255, 255, 128);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { จดการToolStripMenuItem, mnu_logout2 });
            menuStrip1.Location = new Point(0, 56);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // จดการToolStripMenuItem
            // 
            จดการToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnu_Employees, mnu_Products, mnu_Categories });
            จดการToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            จดการToolStripMenuItem.Name = "จดการToolStripMenuItem";
            จดการToolStripMenuItem.Size = new Size(67, 24);
            จดการToolStripMenuItem.Text = "จัดการ";
            // 
            // mnu_Employees
            // 
            mnu_Employees.Name = "mnu_Employees";
            mnu_Employees.Size = new Size(222, 26);
            mnu_Employees.Text = "จัดการพนักงาน";
            mnu_Employees.Click += จดการToolStripMenuItem1_Click;
            // 
            // mnu_Products
            // 
            mnu_Products.Name = "mnu_Products";
            mnu_Products.Size = new Size(222, 26);
            mnu_Products.Text = "จัดการสินค้า";
            mnu_Products.Click += พนกงานToolStripMenuItem_Click;
            // 
            // mnu_Categories
            // 
            mnu_Categories.Name = "mnu_Categories";
            mnu_Categories.Size = new Size(222, 26);
            mnu_Categories.Text = "จัดการประเภทสินค้า";
            mnu_Categories.Click += สนคToolStripMenuItem_Click;
            // 
            // mnu_logout2
            // 
            mnu_logout2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mnu_logout2.Name = "mnu_logout2";
            mnu_logout2.Size = new Size(108, 24);
            mnu_logout2.Text = "ออกจากระบบ";
            mnu_logout2.Click += mnu_logout2_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.FromArgb(128, 255, 128);
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { mnu_Login, mnu_off });
            menuStrip2.Location = new Point(0, 28);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 28);
            menuStrip2.TabIndex = 4;
            menuStrip2.Text = "menuStrip2";
            menuStrip2.ItemClicked += menuStrip2_ItemClicked;
            // 
            // mnu_Login
            // 
            mnu_Login.BackColor = Color.FromArgb(128, 255, 128);
            mnu_Login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mnu_Login.Name = "mnu_Login";
            mnu_Login.Size = new Size(88, 24);
            mnu_Login.Text = "เข้าสู่ระบบ";
            mnu_Login.Click += mnu_Login_Click;
            // 
            // mnu_off
            // 
            mnu_off.BackColor = Color.FromArgb(255, 128, 128);
            mnu_off.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mnu_off.Name = "mnu_off";
            mnu_off.Size = new Size(100, 24);
            mnu_off.Text = "ปิดโปรแกรม";
            mnu_off.Click += mnu_off_Click;
            // 
            // menuStrip3
            // 
            menuStrip3.BackColor = Color.FromArgb(128, 255, 255);
            menuStrip3.ImageScalingSize = new Size(20, 20);
            menuStrip3.Items.AddRange(new ToolStripItem[] { mnu_sell, mnu_logout1 });
            menuStrip3.Location = new Point(0, 0);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.Size = new Size(800, 28);
            menuStrip3.TabIndex = 5;
            menuStrip3.Text = "menuStrip3";
            // 
            // mnu_sell
            // 
            mnu_sell.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mnu_sell.Name = "mnu_sell";
            mnu_sell.Size = new Size(89, 24);
            mnu_sell.Text = "ขายสินค้า";
            mnu_sell.Click += mnu_sell_Click;
            // 
            // mnu_logout1
            // 
            mnu_logout1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mnu_logout1.Name = "mnu_logout1";
            mnu_logout1.Size = new Size(108, 24);
            mnu_logout1.Text = "ออกจากระบบ";
            mnu_logout1.Click += mnu_logout1_Click;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            Controls.Add(menuStrip3);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "main";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "หน้าเมนูหลัก";
            WindowState = FormWindowState.Maximized;
            FormClosing += main_FormClosing;
            Load += main_Load;
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

        private MenuStrip menuStrip1;
        private ToolStripMenuItem จดการToolStripMenuItem;
        private ToolStripMenuItem mnu_Employees;
        private ToolStripMenuItem mnu_Products;
        private ToolStripMenuItem mnu_Categories;
        private MenuStrip menuStrip2;
        private MenuStrip menuStrip3;
        private ToolStripMenuItem mnu_Login;
        private ToolStripMenuItem mnu_off;
        private ToolStripMenuItem mnu_sell;
        private ToolStripMenuItem mnu_logout2;
        private ToolStripMenuItem mnu_logout1;
    }
}