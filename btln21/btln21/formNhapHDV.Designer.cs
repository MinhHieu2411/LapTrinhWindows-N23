namespace btln21
{
    partial class formNhapHDV
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
            tableLayoutPanel1 = new TableLayoutPanel();
            inputSalary_hdv = new TextBox();
            inputYears_hdv = new TextBox();
            inputAddress_hdv = new TextBox();
            inputPhone_hdv = new TextBox();
            inputName_hdv = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            inputID_hdv = new TextBox();
            label7 = new Label();
            inputYob_hdv = new ComboBox();
            label8 = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            lbNhapHdv = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(inputSalary_hdv, 1, 6);
            tableLayoutPanel1.Controls.Add(inputYears_hdv, 1, 5);
            tableLayoutPanel1.Controls.Add(inputAddress_hdv, 1, 4);
            tableLayoutPanel1.Controls.Add(inputPhone_hdv, 1, 3);
            tableLayoutPanel1.Controls.Add(inputName_hdv, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(inputID_hdv, 1, 0);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(inputYob_hdv, 1, 2);
            tableLayoutPanel1.Location = new Point(0, 108);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(452, 286);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // inputSalary_hdv
            // 
            inputSalary_hdv.Dock = DockStyle.Fill;
            inputSalary_hdv.Enabled = false;
            inputSalary_hdv.Font = new Font("Segoe UI", 12F);
            inputSalary_hdv.Location = new Point(138, 243);
            inputSalary_hdv.Name = "inputSalary_hdv";
            inputSalary_hdv.ReadOnly = true;
            inputSalary_hdv.Size = new Size(311, 29);
            inputSalary_hdv.TabIndex = 13;
            // 
            // inputYears_hdv
            // 
            inputYears_hdv.Dock = DockStyle.Fill;
            inputYears_hdv.Font = new Font("Segoe UI", 12F);
            inputYears_hdv.Location = new Point(138, 203);
            inputYears_hdv.Name = "inputYears_hdv";
            inputYears_hdv.Size = new Size(311, 29);
            inputYears_hdv.TabIndex = 12;
            inputYears_hdv.TextChanged += inputYears_hdv_TextChanged;
            inputYears_hdv.KeyPress += inputYears_hdv_KeyPress;
            // 
            // inputAddress_hdv
            // 
            inputAddress_hdv.Dock = DockStyle.Fill;
            inputAddress_hdv.Font = new Font("Segoe UI", 12F);
            inputAddress_hdv.Location = new Point(138, 163);
            inputAddress_hdv.Name = "inputAddress_hdv";
            inputAddress_hdv.Size = new Size(311, 29);
            inputAddress_hdv.TabIndex = 11;
            // 
            // inputPhone_hdv
            // 
            inputPhone_hdv.Dock = DockStyle.Fill;
            inputPhone_hdv.Font = new Font("Segoe UI", 12F);
            inputPhone_hdv.Location = new Point(138, 123);
            inputPhone_hdv.Name = "inputPhone_hdv";
            inputPhone_hdv.Size = new Size(311, 29);
            inputPhone_hdv.TabIndex = 10;
            inputPhone_hdv.KeyPress += inputYears_hdv_KeyPress;
            // 
            // inputName_hdv
            // 
            inputName_hdv.Dock = DockStyle.Fill;
            inputName_hdv.Font = new Font("Segoe UI", 12F);
            inputName_hdv.Location = new Point(138, 43);
            inputName_hdv.Name = "inputName_hdv";
            inputName_hdv.Size = new Size(311, 29);
            inputName_hdv.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 40);
            label1.TabIndex = 0;
            label1.Text = "ID";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 40);
            label2.Name = "label2";
            label2.Size = new Size(129, 40);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 80);
            label3.Name = "label3";
            label3.Size = new Size(129, 40);
            label3.TabIndex = 2;
            label3.Text = "Năm sinh";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(3, 120);
            label4.Name = "label4";
            label4.Size = new Size(129, 40);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(3, 160);
            label5.Name = "label5";
            label5.Size = new Size(129, 40);
            label5.TabIndex = 4;
            label5.Text = "Địa chỉ";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(3, 200);
            label6.Name = "label6";
            label6.Size = new Size(129, 40);
            label6.TabIndex = 5;
            label6.Text = "Thâm niên (năm)";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // inputID_hdv
            // 
            inputID_hdv.Dock = DockStyle.Fill;
            inputID_hdv.Font = new Font("Segoe UI", 12F);
            inputID_hdv.Location = new Point(138, 3);
            inputID_hdv.Name = "inputID_hdv";
            inputID_hdv.Size = new Size(311, 29);
            inputID_hdv.TabIndex = 7;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(3, 240);
            label7.Name = "label7";
            label7.Size = new Size(129, 46);
            label7.TabIndex = 6;
            label7.Text = "Lương cơ bản";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // inputYob_hdv
            // 
            inputYob_hdv.DropDownStyle = ComboBoxStyle.DropDownList;
            inputYob_hdv.Font = new Font("Segoe UI", 12F);
            inputYob_hdv.FormattingEnabled = true;
            inputYob_hdv.Items.AddRange(new object[] { "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980", "1979", "1978", "1977", "1976", "1975", "1974", "1973", "1972", "1971", "1970", "1969", "1968", "1967", "1966", "1965", "1964", "1963", "1962", "1961", "1960", "1959", "1958", "1957", "1956", "1955", "1954", "1953", "1952", "1951", "1950" });
            inputYob_hdv.Location = new Point(138, 83);
            inputYob_hdv.Name = "inputYob_hdv";
            inputYob_hdv.Size = new Size(311, 29);
            inputYob_hdv.TabIndex = 14;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label8.Location = new Point(91, 38);
            label8.Name = "label8";
            label8.Size = new Size(286, 30);
            label8.TabIndex = 1;
            label8.Text = "Thông tin Hướng dẫn viên";
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnConfirm.BackColor = Color.DeepSkyBlue;
            btnConfirm.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(12, 513);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(440, 55);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.BackColor = Color.Transparent;
            btnCancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(12, 574);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(440, 55);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Quay lại";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbNhapHdv
            // 
            lbNhapHdv.AutoSize = true;
            lbNhapHdv.Location = new Point(175, 453);
            lbNhapHdv.Name = "lbNhapHdv";
            lbNhapHdv.Size = new Size(0, 15);
            lbNhapHdv.TabIndex = 4;
            lbNhapHdv.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formNhapHDV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(464, 641);
            Controls.Add(lbNhapHdv);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(label8);
            Controls.Add(tableLayoutPanel1);
            Name = "formNhapHDV";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thông tin Hướng dẫn viên";
            Load += formNhapHDV_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox inputSalary_hdv;
        private TextBox inputYears_hdv;
        private TextBox inputAddress_hdv;
        private TextBox inputPhone_hdv;
        private TextBox inputID_hdv;
        private Label label8;
        private Button btnConfirm;
        private Button btnCancel;
        private Label lbNhapHdv;
        private TextBox inputName_hdv;
        private ComboBox inputYob_hdv;
    }
}