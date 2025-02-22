using Microsoft.Data.SqlClient;
using POS;
using System.Data;
using WinForms.MDI;


namespace WinFormMiniMart
{
    public partial class frmMinima : Form
    {
        public frmMinima()
        {
            InitializeComponent();
            this.Load += FrmCategories_Load;
            dgvCategories.CellMouseUp += DgvCategories_CellMouseUp;
            
        }
       

        private void DgvCategories_CellMouseUp(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvCategories.CurrentRow != null)
            {
                txtCategoryID.Text = dgvCategories.CurrentRow.Cells["CategoryID"].Value?.ToString();
                txtCategoryName.Text = dgvCategories.CurrentRow.Cells["CategoryName"].Value?.ToString();
                txtDescription.Text = dgvCategories.CurrentRow.Cells["Description"].Value?.ToString();
            }
        }

        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand com;

        private void FrmCategories_Load(object? sender, EventArgs e)
        {
            conn = connectDB.ConnectMiniMart();
            showdata();
            txtCategoryID.Enabled = false;
        }

        private void showdata()
        {
            string sql = "Select * from Categories";
            com = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(com);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dgvCategories.DataSource = dataSet.Tables[0];
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            txtCategoryID.Text = string.Empty;
            txtCategoryName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtCategoryName.Focus();
            txtCategoryID.Enabled = false;
        }

        private void btninsert_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageBox.Show("กรุณากรอกชื่อหมวดหมู่", "แจ้งเตือน");
                return;
            }

            string sql = "Insert into Categories values(@categoryName, @Description)";
            com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@categoryName", txtCategoryName.Text.Trim());
            com.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
            if (com.ExecuteNonQuery() > 0)
            {
                showdata();
                btnClearForm.PerformClick();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryID.Text))
            {
                MessageBox.Show("กรุณาเลือกหมวดหมู่ที่ต้องการแก้ไข", "แจ้งเตือน");
                return;
            }
            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageBox.Show("กรุณากรอกชื่อหมวดหมู่", "แจ้งเตือน");
                return;
            }

            string sql = "Update Categories set CategoryName = @categoryName,"
                                             + " description = @Description "
                                             + " where CategoryID = @categoryID";
            com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@categoryName", txtCategoryName.Text.Trim());
            com.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
            com.Parameters.AddWithValue("@categoryID", txtCategoryID.Text);
            if (com.ExecuteNonQuery() > 0)
            {
                showdata();
                btnClearForm.PerformClick();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryID.Text))
            {
                MessageBox.Show("กรุณาเลือกหมวดหมู่ที่ต้องการลบ", "แจ้งเตือน");
                return;
            }

            if (MessageBox.Show("คุณแน่ใจหรือไม่ว่าต้องการลบหมวดหมู่นี้?", "ยืนยันการลบ", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            string sql = "delete from Categories where CategoryID = @categoryID";
            com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@categoryID", txtCategoryID.Text);
            try
            {
                if (com.ExecuteNonQuery() > 0)
                {
                    showdata();
                    btnClearForm.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการลบข้อมูล:\n" + Environment.NewLine + ex.Message, "ข้อผิดพลาด");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmMain f = new FrmMain();
            f.status = "insert";
            f.ShowDialog();
            showdata();
        }

       

        private void dgvCategories_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmMain f = new FrmMain();
            f.status = "update";
            var dgv = dgvCategories.CurrentRow.Cells;
            f.categoryID = Convert.ToInt16(dgv["categoryID"].Value);
            f.categoryName = dgv["categoryName"].Value.ToString();
            f.description = dgv["description"].Value.ToString();
            f.ShowDialog();            
            showdata();
        }
    }
}
