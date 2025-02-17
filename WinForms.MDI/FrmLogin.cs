using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using POS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinForms.MDI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public int EmployeeID { get; set; }
        public string EmpName { get; set; }
        public string Position { get; set; }
        public string UserName { get; set; }

        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMiniMart();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EmployeeID = 0;
            EmpName = string.Empty;
            Position = string.Empty;
            UserName = string.Empty;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string sql = "select EmployeeID ,EmpName = title + FirstName + ' ' + LastName,Position,UserName  from Employees where UserName = @username and Password = @password ";

            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", txtUserName.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
            {
                EmployeeID = Convert.ToInt16(ds.Tables[0].Rows[0]["EmployeeID"]);
                EmpName = ds.Tables[0].Rows[0]["EmpName"].ToString();
                Position = ds.Tables[0].Rows[0][" Position"].ToString();
                UserName = ds.Tables[0].Rows[0][" UserName"].ToString();
                MessageBox.Show(EmployeeID + Environment.NewLine + EmpName + Environment.NewLine + Position, "ยินดีต้อนรับ");
            }
            else
            {
                MessageBox.Show("ชื่อผู้ใช้ หรือ รหัสผ่าน ไม่ถูกต้อง", "เกิดข้อผิดพลาด");
                EmployeeID = 0;
                EmpName = string.Empty;
                Position = string.Empty;
                UserName =string.Empty;
            }
            this.Close();
        }
    }
}
