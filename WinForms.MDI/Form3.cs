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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;

        private void showdata()
        {
            // คำสั่ง SQL สำหรับดึงข้อมูลจาก Products
            string sql = "Select * from Products";
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);

            // แปลง UnitPrice ให้เป็นทศนิยม 2 ตำแหน่ง
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                decimal unitPrice = Convert.ToDecimal(row["UnitPrice"]);
                row["UnitPrice"] = unitPrice.ToString("F2"); // รูปแบบเป็น 2 ตำแหน่งทศนิยม
            }

            dgvProducts.DataSource = dataSet.Tables[0];
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtName.Text.Trim();

            // ตรวจสอบว่าค่าใน searchText เป็นตัวเลขหรือไม่ (สำหรับ UnitPrice หรือ UnitsInStock)
            bool isNumeric = decimal.TryParse(searchText, out decimal numericValue);

            string filter;

            if (isNumeric)  // หากเป็นตัวเลข
            {
                filter = string.Format(
                    "ProductID LIKE '%{0}%' OR " +
                    "ProductName LIKE '%{0}%' OR " +
                    "UnitPrice = {0} OR " +
                    "UnitsInStock = {0}",
                    numericValue
                );
            }
            else  // หากไม่ใช่ตัวเลข
            {
                filter = string.Format(
                    "ProductID LIKE '%{0}%' OR " +
                    "ProductName LIKE '%{0}%'",
                    searchText
                );
            }

            (dgvProducts.DataSource as DataTable).DefaultView.RowFilter = filter;
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form4 f = new Form4();
            f.status = "update";
            var dgv = dgvProducts.CurrentRow.Cells;
            f.ProductID = dgv["ProductID"].Value.ToString();
            f.ProductName = dgv["ProductName"].Value.ToString();
            f.UnitPrice = Convert.ToDecimal(dgv["UnitPrice"].Value);
            f.UnitsInStock = Convert.ToInt32(dgv["UnitsInStock"].Value);
            f.CategoryID = Convert.ToInt32(dgv["CategoryID"].Value);
            f.Discontinued = Convert.ToBoolean(dgv["Discontinued"].Value);
            f.ShowDialog();
            showdata();
        }

        private void btnClaer_Click(object sender, EventArgs e)
        {
            txtName.Clear();  // ล้างข้อความใน TextBox
            txtName.Focus();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.status = "insert";
            f.ShowDialog();
            showdata();
        }

        private void btnDelcet_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่าเลือกแถวใน DataGridView หรือยัง
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("กรุณาเลือกข้อมูลสินค้าที่ต้องการลบ");
                return;
            }

            // แสดงข้อความยืนยันก่อนลบ
            if (MessageBox.Show("ต้องการลบข้อมูลสินค้านี้หรือไม่?", "โปรดยืนยัน", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            // ดึง ProductID จากแถวที่เลือกใน DataGridView
            string productID = dgvProducts.SelectedRows[0].Cells["ProductID"].Value.ToString();

            // สร้างคำสั่ง SQL สำหรับการลบข้อมูล
            string sql = "DELETE FROM Products WHERE ProductID = @ProductID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ProductID", productID);

            try
            {
                // ดำเนินการลบข้อมูล
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("ลบข้อมูลสินค้าเรียบร้อย");
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

        private void Form3_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMiniMart();
            showdata();
        }
    }
}
