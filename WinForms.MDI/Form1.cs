using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;

namespace WinForms.MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin f = new FrmLogin();
            f.ShowDialog();
            if (f.EmployeeID == 0) //กรณี Login ไม่ผ่าน
            {
                return;
            }
            label1.Text += f.EmployeeID.ToString() + Environment.NewLine;
            label1.Text += f.EmpName + Environment.NewLine;
            label1.Text += f.Position + Environment.NewLine;
            label1.Text += f.UserName + Environment.NewLine;
            this.Text = "ชื่อผู้ใช้ :" + f.EmpName + "ตำแหน่ง :" + f.Position;
            button1.Visible = false;
            button2.Visible = true;
            label1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = false;
            label1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = true;
            menuStrip2.Visible = false;
            menuStrip3.Visible = false;
        }
        public void ShowHideMenu(Boolean start, Boolean mgrMenu, Boolean selMenu)
        {
            menuStrip1.Visible = start;
            menuStrip2.Visible = mgrMenu;
            menuStrip3.Visible = selMenu;
        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            FrmLogin f = new FrmLogin();
            f.ShowDialog();
            if (f.EmployeeID == 0) //กรณี Login ไม่ผ่าน
            {
                return;
            }
            this.Text = "ชื่อผู้ใช้ ;" + f.EmpName + " ตำแหน่ง " + f.Position;
            if (f.Position == "Sale Manager")
            {
                ShowHideMenu(false, true, false);
            }
            else if (f.Position == "Sale Representative")
            {
                ShowHideMenu(false, false, true);
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("ปิดโปรแกรม", "โปรยืนยัน", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }



        private void mnuSellProducts_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuSalesReport_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuManageProduct_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuProductCategory_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuManagerLogout_Click(object sender, EventArgs e)
        {
            foreach (var child in MdiChildren)
            {
                child.Close();
            }
            ShowHideMenu(true, false, false);
            this.Text = "ระบบ Minlmart";
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            foreach (var child in MdiChildren)
            {
                child.Close();
            }
            ShowHideMenu(true, false, false);
            this.Text = "ระบบ Minlmart";
        }
        private void 
    }
}
