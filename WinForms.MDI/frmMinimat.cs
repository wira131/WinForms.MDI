using Microsoft.Data.SqlClient;
using POS;
using System.Data;
using WinForms.MDI;

namespace WinFormMiniMart
{
    public partial class frmMinimat : Form
    {
        public frmMinimat()
        {
            InitializeComponent();
            this.Load += FrmCategories_Load;
            dgvCategories.CellMouseUp += DgvCategories_CellMouseUp;
        }

        private void DgvCategories_CellMouseUp(object? sender, DataGridViewCellMouseEventArgs e)
        {
            txtCategoryID.Text = dgvCategories.CurrentRow.Cells["CategoryID"].Value.ToString();
            txtCategoryName.Text = dgvCategories.CurrentRow.Cells["CategoryName"].Value.ToString();
            txtDescription.Text = dgvCategories.CurrentRow.Cells["Description"].Value.ToString();
        }

        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;

        private void FrmCategories_Load(object? sender, EventArgs e)
        {
            conn = connectDB.ConnectMiniMart();
            showdata();
            txtCategoryID.Enabled = false;
        }

        private void showdata()
        {
            string sql = "Select * from Categories";
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);
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
                MessageBox.Show("ชื่อประเภทสินค้าต้องว่าง");
                return;
            }

            string sql = "Insert into Categories values (@categroyName,@Description)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@categroyName", txtCategoryName.Text.Trim());
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());

            if (cmd.ExecuteNonQuery() > 0)
            {
                showdata();
                btnClearForm.PerformClick();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryID.Text))
            {
                MessageBox.Show("กรุณาเลือกข้อมูลก่อน");
                return;
            }
            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageBox.Show("ชื่อประเภทสินค้าต้องว่าง");
                return;
            }

            string sql = "Update Categories set CategoryName = @categroyName, Description = @Description where CategoryID = @categoryID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@categoryID", txtCategoryID.Text.Trim());
            cmd.Parameters.AddWithValue("@categroyName", txtCategoryName.Text.Trim());
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());


            if (cmd.ExecuteNonQuery() > 0)
            {
                showdata();
                btnClearForm.PerformClick();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryID.Text))
            {
                MessageBox.Show("กรุณาเลือกข้อมูลก่อน");
                return;
            }
            if (MessageBox.Show("ต้องการลบข้อมูลนี้หรือไม่", "โปรดยืนยัน", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            string sql = "delete from Categories where CategoryID = @categoryID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@categoryID", txtCategoryID.Text.Trim());
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    showdata();
                    btnClearForm.PerformClick();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("เกิดข้อผิดพลาด :" + Environment.NewLine + ex.Message, "ไม่สามารถลบข้อมูลได้");
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
