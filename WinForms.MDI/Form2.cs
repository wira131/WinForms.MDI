using Microsoft.Data.SqlClient;
using POS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.MDI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int EmployeeID { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string status { get; set; }

        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMiniMart();
            txtEmployeeID.Text = EmployeeID.ToString();
            cmbTitle.Text = Title;
            txtFirstName.Text = FirstName;
            txtLastName.Text = LastName;
            cboPosition.Text = Position;
            txtUserName.Text = UserName;
            txtPassword.Text = Password;
            this.Text += "(" + status + ")";
            txtFirstName.Focus();


        }
        private void UpdateEmployees()
        {

            if(string.IsNullOrEmpty(txtEmployeeID.Text))
    {
                MessageBox.Show("กรุณาเลือกข้อมูลก่อน");
                return;
            }
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("ชื่อพนักงานต้องไม่ว่าง");
                return;
            }

            string sql = "UPDATE Employees SET Title = @Title, FirstName = @FirstName, LastName = @LastName, Position = @Position, UserName = @UserName, Password = @Password WHERE EmployeeID = @EmployeeID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text.Trim());
            cmd.Parameters.AddWithValue("@Title", cmbTitle.Text.Trim());
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
            cmd.Parameters.AddWithValue("@Position", cboPosition.Text.Trim());
            cmd.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
            cmd.ExecuteNonQuery();

            // ✅ แจ้งเตือนเมื่อบอัพเดต
            MessageBox.Show($"อัพเดตข้อมูลผู้ใช้ {txtUserName.Text} สำเร็จแล้ว", "อัพเดตสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void insertEmployees()
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("กรุณากรอกชื่อพนักงาน");
                return;
            }

            string sql = "INSERT INTO Employees (Title, FirstName, LastName, Position, UserName, Password) " +
                         "VALUES (@Title, @FirstName, @LastName, @Position, @UserName, @Password)";

            try
            {
                using (SqlConnection conn = connectDB.ConnectMiniMart())
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", cmbTitle.Text.Trim());
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Position", cboPosition.Text.Trim());
                        cmd.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());



                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("เพิ่มข้อมูลพนักงานเรียบร้อย", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("เกิดข้อผิดพลาดในการเพิ่มข้อมูล", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (status == "insert")
            {
                insertEmployees();
            }
            else if (status == "update")
            {
                UpdateEmployees();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
