namespace POS
{
    partial class Form1
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
            label1 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            lsvProducts = new ListView();
            txtTotal = new TextBox();
            txtQuantity = new TextBox();
            txtUnitPrice = new TextBox();
            txtProductName = new TextBox();
            txtProductID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            lblNetPrice = new Label();
            label9 = new Label();
            txtEmployeeID = new TextBox();
            txtEmployeeName = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 35);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "รหัสพนักงาน";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(345, 35);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 2;
            label3.Text = "ชื่อ-สกุล\r\n";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lsvProducts);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(txtProductID);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(62, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(586, 412);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "รายการสั่งซื้อ";
            // 
            // lsvProducts
            // 
            lsvProducts.Location = new Point(6, 110);
            lsvProducts.Name = "lsvProducts";
            lsvProducts.Size = new Size(574, 296);
            lsvProducts.TabIndex = 12;
            lsvProducts.UseCompatibleStateImageBehavior = false;
            lsvProducts.DoubleClick += lsvProduct_DoubleClick;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(437, 62);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(104, 27);
            txtTotal.TabIndex = 11;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(346, 62);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(85, 27);
            txtQuantity.TabIndex = 8;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(243, 62);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(97, 27);
            txtUnitPrice.TabIndex = 10;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(131, 62);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(106, 27);
            txtProductName.TabIndex = 9;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(6, 62);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(119, 27);
            txtProductID.TabIndex = 8;
            txtProductID.KeyDown += txtProductID_KeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(453, 39);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 8;
            label7.Text = "รวมเป็นเงิน";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(365, 39);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 7;
            label6.Text = "จำนวน";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(262, 39);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 6;
            label5.Text = "ราคาขาย";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(154, 39);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 5;
            label4.Text = "ชื่อสินค้า";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 39);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 4;
            label2.Text = "รหัสสินค้า";
            // 
            // lblNetPrice
            // 
            lblNetPrice.BackColor = Color.Blue;
            lblNetPrice.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNetPrice.Location = new Point(671, 35);
            lblNetPrice.Name = "lblNetPrice";
            lblNetPrice.Size = new Size(242, 39);
            lblNetPrice.TabIndex = 4;
            lblNetPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(671, 9);
            label9.Name = "label9";
            label9.Size = new Size(71, 20);
            label9.TabIndex = 5;
            label9.Text = "รวมเป็นเงิน";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(150, 28);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(125, 27);
            txtEmployeeID.TabIndex = 6;
            txtEmployeeID.KeyDown += txtEmployeeID_KeyDown;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(419, 28);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.ReadOnly = true;
            txtEmployeeName.Size = new Size(125, 27);
            txtEmployeeName.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(671, 96);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "เพิ่ม";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(671, 143);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 9;
            btnClear.Text = "clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(671, 211);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(671, 271);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(151, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "ยกเลิกรายการสังซื้อ\r\n";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 505);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtEmployeeName);
            Controls.Add(txtEmployeeID);
            Controls.Add(label9);
            Controls.Add(lblNetPrice);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "จำหน่ายสินค้า";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private GroupBox groupBox1;
        private ListView lsvProducts;
        private TextBox txtTotal;
        private TextBox txtQuantity;
        private TextBox txtUnitPrice;
        private TextBox txtProductName;
        private TextBox txtProductID;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label lblNetPrice;
        private Label label9;
        private TextBox txtEmployeeID;
        private TextBox txtEmployeeName;
        private Button btnAdd;
        private Button btnClear;
        private Button btnSave;
        private Button btnCancel;
    }
}
