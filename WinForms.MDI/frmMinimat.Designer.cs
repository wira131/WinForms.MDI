namespace WinFormMiniMart
{
    partial class frmMinima
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvCategories = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCategoryID = new TextBox();
            txtCategoryName = new TextBox();
            txtDescription = new TextBox();
            btninsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClearForm = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToDeleteRows = false;
            dgvCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(13, 12);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.Size = new Size(544, 621);
            dgvCategories.TabIndex = 0;
            dgvCategories.CellContentDoubleClick += dgvCategories_CellContentDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(597, 39);
            label1.Name = "label1";
            label1.Size = new Size(121, 23);
            label1.TabIndex = 1;
            label1.Text = "รหัสประเภทสินค้า";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(597, 92);
            label2.Name = "label2";
            label2.Size = new Size(114, 23);
            label2.TabIndex = 2;
            label2.Text = "ชื่อประเภทสินค้า";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(597, 145);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 3;
            label3.Text = "รายละเอียด";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(597, 62);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(153, 27);
            txtCategoryID.TabIndex = 4;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(597, 115);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(327, 27);
            txtCategoryName.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(597, 168);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(342, 123);
            txtDescription.TabIndex = 6;
            // 
            // btninsert
            // 
            btninsert.BackColor = Color.FromArgb(128, 255, 128);
            btninsert.Location = new Point(612, 321);
            btninsert.Name = "btninsert";
            btninsert.Size = new Size(91, 46);
            btninsert.TabIndex = 7;
            btninsert.Text = "เพิ่ม";
            btninsert.UseVisualStyleBackColor = false;
            btninsert.Click += btninsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 255, 128);
            btnUpdate.Location = new Point(605, 391);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(99, 42);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "แก้ไข";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.Location = new Point(709, 321);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(91, 46);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "ลบ";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClearForm
            // 
            btnClearForm.BackColor = Color.FromArgb(128, 128, 255);
            btnClearForm.Location = new Point(710, 391);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.Size = new Size(91, 42);
            btnClearForm.TabIndex = 10;
            btnClearForm.Text = "เคลีย์";
            btnClearForm.UseVisualStyleBackColor = false;
            btnClearForm.Click += btnClearForm_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 192, 128);
            btnAdd.Location = new Point(605, 448);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(98, 43);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "นำเข้า";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmMinima
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(957, 645);
            Controls.Add(btnAdd);
            Controls.Add(btnClearForm);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btninsert);
            Controls.Add(txtDescription);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvCategories);
            Name = "frmMinima";
            Text = "จัดการข้อมูลหมวดหมูสินค้า";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategories;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCategoryID;
        private TextBox txtCategoryName;
        private TextBox txtDescription;
        private Button btninsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClearForm;
        private Button btnAdd;
    }
}
