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


            if (string.IsNullOrEmpty(txtEmployeeID.Text))
            {
                MessageBox.Show("กรุณาเลือกข้อมูลก่อน");
                return;
            }
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("ชื่อประเภทสินค้าต้องว่าง");
                return;
            }

            string sql = "Update Employees set Title = @Title, FirstName = @FirstName, LastName = @LastName, Position = @Position, UserName = @UserName, Password = @Password where EmployeeID = @EmployeeID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text.Trim());
            cmd.Parameters.AddWithValue("@Title", cmbTitle.Text.Trim());
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
            cmd.Parameters.AddWithValue("@Position", cboPosition.Text.Trim());
            cmd.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
            cmd.ExecuteNonQuery();
            this.Close();
        }
        private void insertEmployees()
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("กรุณากรอกชื่อพนักงาน");
                return;
            }

            try
            {
                string sql = "INSERT INTO Employees (Title, FirstName, LastName, Position, UserName, Password) " +
                             "VALUES (@Title, @FirstName, @LastName, @Position, @UserName, @Password)";

                using (cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Title", cmbTitle.Text.Trim());
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Position", cboPosition.Text.Trim());
                    cmd.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());

                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("เพิ่มข้อมูลพนักงานเรียบร้อย");
                    }
                    else
                    {
                        MessageBox.Show("เกิดข้อผิดพลาดในการเพิ่มข้อมูล");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
            }
            finally
            {
                conn.Close(); // ปิดการเชื่อมต่อ
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
