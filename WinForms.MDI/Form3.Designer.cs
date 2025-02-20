namespace WinForms.MDI
{
    partial class Form3
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
            txtName = new TextBox();
            btnDelcet = new Button();
            btnInsert = new Button();
            btnClaer = new Button();
            dgvProducts = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(12, 43);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(518, 42);
            txtName.TabIndex = 12;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // btnDelcet
            // 
            btnDelcet.BackColor = Color.FromArgb(255, 128, 128);
            btnDelcet.FlatStyle = FlatStyle.Popup;
            btnDelcet.Location = new Point(606, 174);
            btnDelcet.Name = "btnDelcet";
            btnDelcet.Size = new Size(125, 52);
            btnDelcet.TabIndex = 9;
            btnDelcet.Text = "ลบ";
            btnDelcet.UseVisualStyleBackColor = false;
            btnDelcet.Click += btnDelcet_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(128, 255, 128);
            btnInsert.FlatStyle = FlatStyle.Popup;
            btnInsert.Location = new Point(606, 116);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(125, 52);
            btnInsert.TabIndex = 10;
            btnInsert.Text = "เพิ่ม";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnClaer
            // 
            btnClaer.BackColor = Color.Silver;
            btnClaer.FlatStyle = FlatStyle.Popup;
            btnClaer.Location = new Point(622, 232);
            btnClaer.Name = "btnClaer";
            btnClaer.Size = new Size(83, 55);
            btnClaer.TabIndex = 11;
            btnClaer.Text = "เคลียร์";
            btnClaer.UseVisualStyleBackColor = false;
            btnClaer.Click += btnClaer_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 91);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(588, 426);
            dgvProducts.TabIndex = 8;
            dgvProducts.CellDoubleClick += dgvProducts_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 14);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 13;
            label1.Text = "ค้นหา";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 529);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(btnDelcet);
            Controls.Add(btnInsert);
            Controls.Add(btnClaer);
            Controls.Add(dgvProducts);
            Name = "Form3";
            Text = "จัดการสินค้า";
            WindowState = FormWindowState.Maximized;
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtName;
        private Button btnDelcet;
        private Button btnInsert;
        private Button btnClaer;
        private DataGridView dgvProducts;
        private Label label1;
    }
}