namespace WinForms.MDI
{
    partial class FrmMain
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
            btnCancel = new Button();
            btnSave = new Button();
            txtDescription = new TextBox();
            txtCategoryName = new TextBox();
            txtCategoryID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 128, 128);
            btnCancel.Location = new Point(593, 147);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(147, 58);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "ยกเลิก";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 255, 128);
            btnSave.Location = new Point(593, 35);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(147, 58);
            btnSave.TabIndex = 21;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(125, 134);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(429, 123);
            txtDescription.TabIndex = 20;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(125, 66);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(327, 27);
            txtCategoryName.TabIndex = 19;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Enabled = false;
            txtCategoryID.Location = new Point(125, 18);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(153, 27);
            txtCategoryID.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 137);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 17;
            label3.Text = "รายละเอียด";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 16;
            label2.Text = "ชื่อประเภทสินค้า";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 18);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 15;
            label4.Text = "รหัสประเภทสินค้า";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 297);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Name = "FrmMain";
            Text = "จัดการและปรับปรุงหมวดหมู่สินค้า";
            Load += FrmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private TextBox txtDescription;
        private TextBox txtCategoryName;
        private TextBox txtCategoryID;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}