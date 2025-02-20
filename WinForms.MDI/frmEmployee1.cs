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
    public partial class frmEmployees : Form
    {
        public frmEmployees()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;



        private void showdata()
        {
            string sql = "Select * from Employees";
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dgvEmployees.DataSource = dataSet.Tables[0];
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (dgvEmployees.DataSource == null || !(dgvEmployees.DataSource is DataTable))
                return; // ถ้า DataSource เป็น null หรือไม่ใช่ DataTable ให้หยุดทำงาน

            string searchText = txtName.Text.Trim();
            string filter = string.Format(
                "Convert(EmployeeID, 'System.String') LIKE '%{0}%' OR " +
                "Title LIKE '%{0}%' OR " +
                "FirstName LIKE '%{0}%' OR " +
                "LastName LIKE '%{0}%' OR " +
                "Position LIKE '%{0}%' OR " +
                "UserName LIKE '%{0}%'",
                searchText
            );

            ((DataTable)dgvEmployees.DataSource).DefaultView.RowFilter = filter;


        }

        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2 f = new Form2();
            f.status = "update";
            var dgv = dgvEmployees.CurrentRow.Cells;
            f.EmployeeID = Convert.ToInt16(dgv["EmployeeID"].Value);
            f.Title = dgv["Title"].Value.ToString();
            f.FirstName = dgv["FirstName"].Value.ToString();
            f.LastName = dgv["LastName"].Value.ToString();
            f.Position = dgv["Position"].Value.ToString();
            f.UserName = dgv["UserName"].Value.ToString();
            f.Password = dgv["Password"].Value.ToString();
            f.ShowDialog();
            showdata();


        }

        private void btnInset_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.status = "insert";
            f.ShowDialog();
            showdata();
        }

        private void btnDelcet_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("กรุณาเลือกข้อมูลพนักงานที่ต้องการลบ");
                return;
            }

            // แสดงข้อความยืนยันก่อนลบ
            if (MessageBox.Show("ต้องการลบข้อมูลพนักงานนี้หรือไม่?", "โปรดยืนยัน", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            // ดึง EmployeeID จากแถวที่เลือกใน DataGridView
            string employeeID = dgvEmployees.SelectedRows[0].Cells["EmployeeID"].Value.ToString();

            // สร้างคำสั่ง SQL สำหรับการลบข้อมูล
            string sql = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

            try
            {
                // ดำเนินการลบข้อมูล
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("ลบข้อมูลพนักงานเรียบร้อย");
                    showdata();  // รีเฟรชข้อมูลใน DataGridView
                }
                else
                {
                    MessageBox.Show("ไม่สามารถลบข้อมูลได้");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
            }
            
        }

        private void btnClaer_Click(object sender, EventArgs e)
        {
            txtName.Clear(); 
            txtName.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMiniMart();
            showdata();
        }
    }
}
