namespace WinForms.MDI
{
    partial class frmEmployees
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
            btnInset = new Button();
            btnClaer = new Button();
            dgvEmployees = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(143, 400);
            txtName.Name = "txtName";
            txtName.Size = new Size(297, 34);
            txtName.TabIndex = 7;
            // 
            // btnDelcet
            // 
            btnDelcet.BackColor = Color.FromArgb(255, 128, 128);
            btnDelcet.Location = new Point(446, 400);
            btnDelcet.Name = "btnDelcet";
            btnDelcet.Size = new Size(115, 36);
            btnDelcet.TabIndex = 4;
            btnDelcet.Text = "ลบ";
            btnDelcet.UseVisualStyleBackColor = false;
            btnDelcet.Click += btnDelcet_Click;
            // 
            // btnInset
            // 
            btnInset.BackColor = Color.FromArgb(128, 255, 128);
            btnInset.Location = new Point(12, 402);
            btnInset.Name = "btnInset";
            btnInset.Size = new Size(125, 36);
            btnInset.TabIndex = 5;
            btnInset.Text = "เพิ่ม";
            btnInset.UseVisualStyleBackColor = false;
            btnInset.Click += btnInset_Click;
            // 
            // btnClaer
            // 
            btnClaer.BackColor = Color.FromArgb(128, 128, 255);
            btnClaer.Location = new Point(578, 402);
            btnClaer.Name = "btnClaer";
            btnClaer.Size = new Size(73, 38);
            btnClaer.TabIndex = 6;
            btnClaer.Text = "เคลีย์";
            btnClaer.UseVisualStyleBackColor = false;
            btnClaer.Click += btnClaer_Click;
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(12, 20);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(776, 337);
            dgvEmployees.TabIndex = 3;
            dgvEmployees.CellDoubleClick += dgvEmployees_CellDoubleClick;
            // 
            // frmEmployees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtName);
            Controls.Add(btnDelcet);
            Controls.Add(btnInset);
            Controls.Add(btnClaer);
            Controls.Add(dgvEmployees);
            Name = "frmEmployees";
            Text = "ระบบจัดการพนักงาน";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Button btnDelcet;
        private Button btnInset;
        private Button btnClaer;
        private DataGridView dgvEmployees;
    }
}