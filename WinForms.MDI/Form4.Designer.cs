namespace WinForms.MDI
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numUD_UnitsInStock = new NumericUpDown();
            numUD_UnitPrice = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label7 = new Label();
            btnSave = new Button();
            btnDelcet = new Button();
            cmbDiscontinued = new ComboBox();
            cmbCategoryID = new ComboBox();
            txtProductName = new TextBox();
            txtProductID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numUD_UnitsInStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUD_UnitPrice).BeginInit();
            SuspendLayout();
            // 
            // numUD_UnitsInStock
            // 
            numUD_UnitsInStock.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numUD_UnitsInStock.Location = new Point(292, 126);
            numUD_UnitsInStock.Name = "numUD_UnitsInStock";
            numUD_UnitsInStock.Size = new Size(250, 43);
            numUD_UnitsInStock.TabIndex = 33;
            // 
            // numUD_UnitPrice
            // 
            numUD_UnitPrice.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numUD_UnitPrice.Location = new Point(293, 32);
            numUD_UnitPrice.Name = "numUD_UnitPrice";
            numUD_UnitPrice.Size = new Size(249, 43);
            numUD_UnitPrice.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(291, 9);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 27;
            label4.Text = "ราคา";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 172);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 28;
            label3.Text = "ชื่อสินค้า";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(589, 9);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 29;
            label6.Text = "สถานะจำหน่าย";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(291, 99);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 30;
            label5.Text = "จำนวน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 99);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 31;
            label2.Text = "ประเภทสินค้า";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 9);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 32;
            label7.Text = "รหัสสินค้า";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 255, 128);
            btnSave.Location = new Point(589, 172);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(169, 53);
            btnSave.TabIndex = 25;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelcet
            // 
            btnDelcet.BackColor = Color.FromArgb(255, 128, 128);
            btnDelcet.Location = new Point(589, 247);
            btnDelcet.Name = "btnDelcet";
            btnDelcet.Size = new Size(161, 53);
            btnDelcet.TabIndex = 26;
            btnDelcet.Text = "ยกเลิก";
            btnDelcet.UseVisualStyleBackColor = false;
            btnDelcet.Click += btnDelcet_Click;
            // 
            // cmbDiscontinued
            // 
            cmbDiscontinued.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDiscontinued.FormattingEnabled = true;
            cmbDiscontinued.Items.AddRange(new object[] { "มีสินค้าในสต็อก", "สินค้าหมด" });
            cmbDiscontinued.Location = new Point(589, 32);
            cmbDiscontinued.Name = "cmbDiscontinued";
            cmbDiscontinued.Size = new Size(203, 45);
            cmbDiscontinued.TabIndex = 23;
            // 
            // cmbCategoryID
            // 
            cmbCategoryID.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategoryID.FormattingEnabled = true;
            cmbCategoryID.Location = new Point(22, 124);
            cmbCategoryID.Name = "cmbCategoryID";
            cmbCategoryID.Size = new Size(184, 45);
            cmbCategoryID.TabIndex = 24;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(22, 195);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(453, 43);
            txtProductName.TabIndex = 21;
            // 
            // txtProductID
            // 
            txtProductID.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductID.Location = new Point(22, 32);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(184, 43);
            txtProductID.TabIndex = 22;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 321);
            Controls.Add(numUD_UnitsInStock);
            Controls.Add(numUD_UnitPrice);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(btnSave);
            Controls.Add(btnDelcet);
            Controls.Add(cmbDiscontinued);
            Controls.Add(cmbCategoryID);
            Controls.Add(txtProductName);
            Controls.Add(txtProductID);
            Name = "Form4";
            Text = "เพิ่ม|แก้ไขสินค้า";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)numUD_UnitsInStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUD_UnitPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numUD_UnitsInStock;
        private NumericUpDown numUD_UnitPrice;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label7;
        private Button btnSave;
        private Button btnDelcet;
        private ComboBox cmbDiscontinued;
        private ComboBox cmbCategoryID;
        private TextBox txtProductName;
        private TextBox txtProductID;
    }
}