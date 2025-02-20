using POS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.MDI;

namespace WinFormMiniMart
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            //menuStrip1.Visible = false;
            //menuStrip2.Visible = true;
            //menuStrip3.Visible = false;

            showHideMenu(true, false, false);
        }


        void showHideMenu(Boolean S, Boolean M, Boolean E)
        {
            menuStrip1.Visible = M;
            menuStrip2.Visible = S;
            menuStrip3.Visible = E;
        }

        private void จดการToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmEmployees>();
            //Form1 frm = new Form1();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void พนกงานToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm<Form3>();
            //Form3 frm = new Form3();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void สนคToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmMinimat>();
            //frmCategories frm = new frmCategories();
            //frm.MdiParent = this;
            //frm.Show();
        }






        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnu_Login_Click(object sender, EventArgs e)
        {
            FrmLogin f = new FrmLogin();
            f.ShowDialog();
            if (f.EmployeeID == 0)
            {
                return;
            }

            this.Text = "ชื่อผู้ใช้ :" + f.EmpName + " ตำแหน่ง : " + f.Position;
            if (f.Position == "Sale Manager")
            {
                showHideMenu(false, true, false);
            }
            else if (f.Position == "Sale Representative")
            {
                
                showHideMenu(false, false, true);
            }
            else if (f.Position == "Admin")
            {
                showHideMenu(false, true, true);
                mnu_logout2.Visible = false;
            }
        }

        private void mnu_off_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("ปิดโปรแกรม", "โปรดยืนยัน", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void mnu_logout2_Click(object sender, EventArgs e)
        {
            this.Text = "main";
            showHideMenu(true, false, false);
            foreach (var child in MdiChildren)
            {
                child.Close();
            }
        }

        private void mnu_logout1_Click(object sender, EventArgs e)
        {
            this.Text = "main";
            showHideMenu(true, false, false);
            foreach (var child in MdiChildren)
            {
                child.Close();
            }
        }

        private void mnu_sell_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmCategories>();
            //frmPos frm = new frmPos();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void OpenChildForm<T>() where T : Form, new()
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is T)
                {
                    child.Activate();
                    return;
                }
            }

            T newChild = new T
            {
                MdiParent = this,
                StartPosition = FormStartPosition.CenterScreen
            };
            newChild.Show();

        }
    }
}
