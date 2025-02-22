namespace WinForms.MDI
{
    partial class Form2
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
            label3 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label8 = new Label();
            btnSave = new Button();
            button1 = new Button();
            cmbTitle = new ComboBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            txtFirstName = new TextBox();
            txtEmployeeID = new TextBox();
            cboPosition = new ComboBox();
            txtLastName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 84);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 14;
            label3.Text = "ชื่อ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(395, 178);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 15;
            label7.Text = "รหัสผ่าน";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 178);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 16;
            label6.Text = "ชื่อผู้ใช้";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 260);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 17;
            label5.Text = "ตำแหน่ง";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 84);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 18;
            label2.Text = "คำนำหน้า";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(341, 9);
            label8.Name = "label8";
            label8.Size = new Size(82, 20);
            label8.TabIndex = 19;
            label8.Text = "รหัสพนักงาน";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 255, 128);
            btnSave.Location = new Point(395, 365);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(178, 61);
            btnSave.TabIndex = 11;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Location = new Point(595, 365);
            button1.Name = "button1";
            button1.Size = new Size(178, 61);
            button1.TabIndex = 12;
            button1.Text = "ยกเลิก";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cmbTitle
            // 
            cmbTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTitle.FormattingEnabled = true;
            cmbTitle.Items.AddRange(new object[] { "นาย", "นาง", "นางสาว" });
            cmbTitle.Location = new Point(21, 107);
            cmbTitle.Name = "cmbTitle";
            cmbTitle.Size = new Size(171, 45);
            cmbTitle.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(395, 201);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(378, 43);
            txtPassword.TabIndex = 5;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(21, 201);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(353, 43);
            txtUserName.TabIndex = 6;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(213, 107);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(254, 43);
            txtFirstName.TabIndex = 8;
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmployeeID.Location = new Point(300, 32);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.ReadOnly = true;
            txtEmployeeID.Size = new Size(171, 43);
            txtEmployeeID.TabIndex = 9;
            // 
            // cboPosition
            // 
            cboPosition.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboPosition.FormattingEnabled = true;
            cboPosition.Items.AddRange(new object[] { "Sale Manager", "Sale Representative" });
            cboPosition.Location = new Point(21, 283);
            cboPosition.Name = "cboPosition";
            cboPosition.Size = new Size(286, 45);
            cboPosition.TabIndex = 20;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(473, 109);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(300, 43);
            txtLastName.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(473, 84);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 22;
            label1.Text = "นามสกุล";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtLastName);
            Controls.Add(cboPosition);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(btnSave);
            Controls.Add(button1);
            Controls.Add(cmbTitle);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtFirstName);
            Controls.Add(txtEmployeeID);
            Name = "Form2";
            Text = "ระบบจัดการพนักงาน";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label8;
        private Button btnSave;
        private Button button1;
        private ComboBox cmbTitle;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private TextBox txtFirstName;
        private TextBox txtEmployeeID;
        private ComboBox cboPosition;
        private TextBox txtLastName;
        private Label label1;
    }
}