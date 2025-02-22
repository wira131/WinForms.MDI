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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int CategoryID { get; set; }
        public bool Discontinued { get; set; }
        public string status { get; set; }

        SqlConnection conn;
        
        SqlCommand cmd;
SqlDataAdapter da;



        private void Form4_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMiniMart();

            numUD_UnitPrice.Minimum = 0;
            numUD_UnitPrice.Maximum = 1000000;
            numUD_UnitPrice.Value = 210;

            numUD_UnitsInStock.Minimum = 0;
            numUD_UnitsInStock.Maximum = 10000;
            numUD_UnitsInStock.Value = 100;
            
            // ดึงข้อมูลจากตาราง Categories
            LoadCategories();

            
            txtProductID.Text = ProductID;
            txtProductName.Text = ProductName;
            numUD_UnitPrice.Value = UnitPrice;
            numUD_UnitsInStock.Value = UnitsInStock;
            cmbCategoryID.SelectedValue = CategoryID;
            cmbDiscontinued.SelectedIndex = Discontinued ? 1 : 0;

            this.Text += "(" + status + ")";
            txtProductName.Focus();
        }
        private void LoadCategories()
        {
            // ดึงข้อมูลจากตาราง Categories
            string sql = "SELECT CategoryID, CategoryName FROM Categories";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // ตั้งค่า DataSource ให้กับ ComboBox
            cmbCategoryID.DataSource = dt;
            cmbCategoryID.DisplayMember = "CategoryName";
            cmbCategoryID.ValueMember = "CategoryID";
            cmbCategoryID.SelectedIndex = -1;
        }
        public static bool IsProductOutOfStock(string productId)
        {
            using (SqlConnection conn = connectDB.ConnectMiniMart())
            {
                string sql = "SELECT UnitsInStock, Discontinued FROM Products WHERE ProductID = @ProductID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProductID", productId);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int unitsInStock = reader.GetInt32(0);
                        bool discontinued = reader.GetBoolean(1);
                        return unitsInStock <= 0 || discontinued;
                    }
                }
                return false;
            }
        }
        private void UpdateProduct()
        {
            if (string.IsNullOrEmpty(txtProductID.Text))
            {
                MessageBox.Show("กรุณาเลือกข้อมูลก่อน");
                return;
            }
            if (string.IsNullOrEmpty(txtProductName.Text))
            {
                MessageBox.Show("ชื่อสินค้าต้องไม่ว่าง");
                return;
            }

            string checkSql = "SELECT COUNT(*) FROM Products WHERE ProductID = @NewProductID AND ProductID <> @OldProductID";
            SqlCommand checkCmd = new SqlCommand(checkSql, conn);
            checkCmd.Parameters.Clear();
            checkCmd.Parameters.AddWithValue("@NewProductID", txtProductID.Text.Trim());
            checkCmd.Parameters.AddWithValue("@OldProductID", ProductID);

            int count = Convert.ToInt32(checkCmd.ExecuteScalar());

            if (count > 0)
            {
                MessageBox.Show("รหัสสินค้านี้มีอยู่ในระบบแล้ว กรุณาใช้รหัสอื่น!", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = "UPDATE Products SET ProductID = @NewProductID, ProductName = @ProductName, UnitPrice = @UnitPrice, " +
                         "UnitsInStock = @UnitsInStock, CategoryID = @CategoryID, Discontinued = @Discontinued WHERE ProductID = @OldProductID";

            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@NewProductID", txtProductID.Text.Trim());
            cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text.Trim());
            cmd.Parameters.AddWithValue("@UnitPrice", numUD_UnitPrice.Value);
            cmd.Parameters.AddWithValue("@UnitsInStock", numUD_UnitsInStock.Value);
            cmd.Parameters.AddWithValue("@CategoryID", cmbCategoryID.SelectedValue);
            cmd.Parameters.AddWithValue("@Discontinued", cmbDiscontinued.SelectedIndex);
            cmd.Parameters.AddWithValue("@OldProductID", ProductID);

            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("อัปเดตข้อมูลสินค้าเรียบร้อย", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ไม่สามารถอัปเดตข้อมูลได้", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }
        private void InsertProduct()
        {
            if (string.IsNullOrEmpty(txtProductName.Text))
            {
                MessageBox.Show("ชื่อสินค้าต้องไม่ว่าง");
                return;
            }

            string[] productIds = txtProductID.Text.Trim().Split(',');

            foreach (var productId in productIds)
            {
                string trimmedProductId = productId.Trim();

                if (string.IsNullOrEmpty(trimmedProductId))
                {
                    MessageBox.Show("รหัสสินค้าต้องไม่ว่าง!", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string checkSql = "SELECT COUNT(*) FROM Products WHERE ProductID = @ProductID";
                SqlCommand checkCmd = new SqlCommand(checkSql, conn);
                checkCmd.Parameters.AddWithValue("@ProductID", trimmedProductId);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show($"รหัสสินค้า {trimmedProductId} มีอยู่ในระบบแล้ว กรุณาใช้รหัสอื่น!", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string sql = "INSERT INTO Products (ProductID, ProductName, UnitPrice, UnitsInStock, CategoryID, Discontinued) " +
                         "VALUES (@ProductID, @ProductName, @UnitPrice, @UnitsInStock, @CategoryID, @Discontinued)";

            foreach (var productId in productIds)
            {
                string trimmedProductId = productId.Trim();
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ProductID", trimmedProductId);
                cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text.Trim());
                cmd.Parameters.AddWithValue("@UnitPrice", numUD_UnitPrice.Value);
                cmd.Parameters.AddWithValue("@UnitsInStock", numUD_UnitsInStock.Value);
                cmd.Parameters.AddWithValue("@CategoryID", cmbCategoryID.SelectedValue);
                cmd.Parameters.AddWithValue("@Discontinued", cmbDiscontinued.SelectedIndex);

                try
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show($"เพิ่มข้อมูลสินค้ารหัส {trimmedProductId} เรียบร้อย", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"ไม่สามารถเพิ่มข้อมูลสินค้ารหัส {trimmedProductId} ได้", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (status == "insert")
            {
                InsertProduct();
            }
            else if (status == "update")
            {
                UpdateProduct();
            }
        }

        private void btnDelcet_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
