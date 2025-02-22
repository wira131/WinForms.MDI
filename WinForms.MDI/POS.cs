using Microsoft.Data.SqlClient;
using System.Data;


namespace POS
{
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
        }

        SqlConnection conn;     
        SqlTransaction tr;


        private void ListViewFormat() // สำหรับจัดรูปแบบ ListView
        {
            lsvProducts.Columns.Add("รหัสสินค้า", 100, HorizontalAlignment.Left);
            lsvProducts.Columns.Add("สินค้า", 150, HorizontalAlignment.Left);
            lsvProducts.Columns.Add("ราคา", 65, HorizontalAlignment.Right);
            lsvProducts.Columns.Add("จำนวณ", 50, HorizontalAlignment.Right);
            lsvProducts.Columns.Add("รวมเป็นเงิน", 70, HorizontalAlignment.Right);
            lsvProducts.View = View.Details;
            lsvProducts.GridLines = true;
            lsvProducts.FullRowSelect = true;
        }

        private void ClearProductData() 
        {
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtUnitPrice.Text = "0";
            txtQuantity.Text = "1";
            txtTotal.Text = "0";
        }

        private void clearEmployeeData() 
        {
            txtEmployeeID.Text = "";
            txtEmployeeName.Text = "";
        }

        private void CalculateTotal() 
        {
            double total = Convert.ToDouble(txtUnitPrice.Text) * Convert.ToDouble(txtQuantity.Text);
            txtTotal.Text = total.ToString("#,##0.00");
            txtProductID.Focus();
        }

        private void CalulateNetPrice() 
        {
            int i = 0;
            double tmpNetPrice = 0.0;
            for (i = 0; i <= lsvProducts.Items.Count - 1; i++)
            {
                tmpNetPrice += Convert.ToDouble(lsvProducts.Items[i].SubItems[4].Text);
            }
            lblNetPrice.Text = tmpNetPrice.ToString("#,##0.00");
        }

        private void txtEmployeeID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sql = "Select EmployeeID,Title+FirstName+ SPACE(2)+ LastName as empName"
                + " , Position from employees where employeeID = @employeeID";
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@employeeID", txtEmployeeID.Text);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    txtEmployeeID.Text = dt.Rows[0][0].ToString();
                    txtEmployeeName.Text = dt.Rows[0][1].ToString();
                    txtProductID.Focus();
                }
                else
                {
                    clearEmployeeData();
                    txtEmployeeName.Focus();
                }
                dr.Close();
                conn.Close();
            }


        }

        private void txtProductID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sql = "Select ProductID, ProductName,unitPrice"
                + " from products where productID = @ProductID";
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@ProductID", txtProductID.Text);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    txtProductID.Text = dt.Rows[0][0].ToString();
                    txtProductName.Text = dt.Rows[0][1].ToString();
                    txtUnitPrice.Text = Convert.ToDouble(dt.Rows[0][2]).ToString("0.00");
                    CalculateTotal();
                    txtProductID.Focus();
                }
                else
                {
                    MessageBox.Show("ไมพบสินค้านี้", "ผิดพลาด");
                    ClearProductData();
                    txtProductID.Focus();
                }
                dr.Close();
                conn.Close();
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Trim() == "") txtQuantity.Text = "1";
            if (Convert.ToInt16(txtQuantity.Text) == 0) txtQuantity.Text = "1";
            CalculateTotal();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text.Trim() == "" || txtProductName.Text.Trim() == "")
            {
                txtProductID.Focus(); return;
            }
            if (Convert.ToInt16(txtQuantity.Text) == 0)
            {
                txtProductID.Focus(); return;
            }
            ListViewItem lvi;
            int i = 0; string tmpProductID = "";
            for (i = 0; i <= lsvProducts.Items.Count - 1; i++)
            {
                tmpProductID = lsvProducts.Items[i].SubItems[0].Text;
                if (txtProductID.Text.Trim() == tmpProductID)
                {
                    int qty = Convert.ToInt16(lsvProducts.Items[i].SubItems[3].Text)
                    + Convert.ToInt16(txtQuantity.Text);
                    double newTotal = Convert.ToDouble(lsvProducts.Items[i].SubItems[4].Text)
                    + Convert.ToDouble(txtTotal.Text); 
                    lsvProducts.Items[i].SubItems[3].Text = qty.ToString();
                    lsvProducts.Items[i].SubItems[4].Text = newTotal.ToString("#,##0.00");
                    ClearProductData();
                    CalculateTotal();
                    CalulateNetPrice();
                    return;
                }
            }
            string[] anyData;
            anyData = new string[] { txtProductID.Text, txtProductName.Text,
            Convert.ToDouble(txtUnitPrice.Text).ToString("0.00"), txtQuantity.Text, txtTotal.Text };
            lvi = new ListViewItem(anyData);
            lsvProducts.Items.Add(lvi);
            CalulateNetPrice(); ClearProductData(); btnSave.Enabled = true;
            txtProductID.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearProductData();
        }

        private void lsvProduct_DoubleClick(object sender, EventArgs e)
        {
            //double click ในรํายกํารสนิคํา้ จะลบรํายกํารออก
            int i = 0;
            for (i = 0; i <= lsvProducts.SelectedItems.Count - 1; i++)
            {
                ListViewItem lvi = lsvProducts.SelectedItems[i];
                lsvProducts.Items.Remove(lvi);
            }
            CalulateNetPrice();
            txtProductID.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lsvProducts.Clear(); 
            clearEmployeeData(); 
            ClearProductData(); 
            ListViewFormat(); 
            lblNetPrice.Text = "0.00"; 
            txtEmployeeID.Focus(); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int lastOrderID = 0;
            if (txtEmployeeID.Text.Trim() == "")
            {
                MessageBox.Show("โปรดระบุผู้ขายสินค้าก่อน", "มีข้อผิดพลาด");
                txtEmployeeID.Focus();
                return;
            }
            if (lsvProducts.Items.Count > 0)
            {
                // ตรวจสอบสินค้าที่หมดสต็อก
                List<string> outOfStockProducts = new List<string>();
                foreach (ListViewItem item in lsvProducts.Items)
                {
                    string productId = item.SubItems[0].Text;
                    string productName = item.SubItems[1].Text;

                    string sqlCheckStock = "SELECT UnitsInStock, Discontinued FROM Products WHERE ProductID = @ProductID";
                    using (SqlCommand cmdCheck = new SqlCommand(sqlCheckStock, conn))
                    {
                        conn.Open();
                        cmdCheck.Parameters.AddWithValue("@ProductID", productId);
                        SqlDataReader reader = cmdCheck.ExecuteReader();
                        if (reader.Read())
                        {
                            int unitsInStock = reader.GetInt32(reader.GetOrdinal("UnitsInStock"));
                            bool discontinued = reader.GetBoolean(reader.GetOrdinal("Discontinued"));

                            if (unitsInStock <= 0 || discontinued)
                            {
                                outOfStockProducts.Add(productName);
                            }
                        }
                        reader.Close();
                        conn.Close();
                    }
                }

                if (outOfStockProducts.Count > 0)
                {
                    MessageBox.Show("สินค้าต่อไปนี้หมดสต็อก:\n" + string.Join("\n", outOfStockProducts),
                                    "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("ต้องการบันทึกรายการสินค้าหรือไม่", "กรุณายืนยัน", MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    // ประกาศเริ่ม Transaction
                    conn.Open();
                    tr = conn.BeginTransaction();
                    string sql = "INSERT INTO Receipts(ReceiptDate,EmployeeID,TotalCash) VALUES (GETDATE(),@EmployeeID,@TotalCash)";
                    SqlCommand comm = new SqlCommand(sql, conn, tr);
                    comm.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text.Trim());
                    comm.Parameters.AddWithValue("@TotalCash", lblNetPrice.Text);
                    comm.ExecuteNonQuery();

                    string sql1 = "SELECT TOP 1 ReceiptID FROM Receipts ORDER BY ReceiptID DESC";
                    SqlCommand comm1 = new SqlCommand(sql1, conn, tr);
                    SqlDataReader dr = comm1.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        lastOrderID = dr.GetInt32(dr.GetOrdinal("ReceiptID"));
                    }
                    dr.Close();

                    for (int i = 0; i <= lsvProducts.Items.Count - 1; i++)
                    {
                        string sql2 = "INSERT INTO Details(ReceiptID,ProductID,UnitPrice,Quantity) " +
                                      "VALUES(@ReceiptID,@ProductID,@UnitPrice,@Quantity)";
                        SqlCommand comm3 = new SqlCommand(sql2, conn, tr);
                        comm3.Parameters.AddWithValue("@ReceiptID", lastOrderID);
                        comm3.Parameters.AddWithValue("@ProductID", lsvProducts.Items[i].SubItems[0].Text);
                        comm3.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(lsvProducts.Items[i].SubItems[2].Text).ToString("0.00"));
                        
                        comm3.Parameters.AddWithValue("@Quantity", lsvProducts.Items[i].SubItems[3].Text);
                        comm3.ExecuteNonQuery();
                    }
                    tr.Commit();
                    conn.Close();
                    MessageBox.Show("บันทึกรายการขายเรียบร้อยแล้ว", "ผลการทำงาน");
                   
                }
                btnCancel.PerformClick();
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMiniMart();
            ListViewFormat();
            ClearProductData();

            
        }
    }
    
}
