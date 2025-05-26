namespace btln21
{
    partial class formNhapKH
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
            btnConfirm = new Button();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            inputAddress_customer = new TextBox();
            label6 = new Label();
            inputPhone_customer = new TextBox();
            inputName_customer = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            inputID_customer = new TextBox();
            inputYob_customer = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(18, 565);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(440, 55);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Hủy bỏ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnConfirm.BackColor = Color.DeepSkyBlue;
            btnConfirm.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(18, 504);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(440, 55);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 20);
            label1.Name = "label1";
            label1.Size = new Size(231, 30);
            label1.TabIndex = 5;
            label1.Text = "Thông tin khách hàng";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64F));
            tableLayoutPanel1.Controls.Add(inputAddress_customer, 1, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 4);
            tableLayoutPanel1.Controls.Add(inputPhone_customer, 1, 3);
            tableLayoutPanel1.Controls.Add(inputName_customer, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(inputID_customer, 1, 0);
            tableLayoutPanel1.Controls.Add(inputYob_customer, 1, 2);
            tableLayoutPanel1.Location = new Point(6, 99);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(452, 200);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // inputAddress_customer
            // 
            inputAddress_customer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputAddress_customer.Font = new Font("Segoe UI", 12F);
            inputAddress_customer.Location = new Point(165, 163);
            inputAddress_customer.Name = "inputAddress_customer";
            inputAddress_customer.Size = new Size(284, 29);
            inputAddress_customer.TabIndex = 9;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(3, 160);
            label6.Name = "label6";
            label6.Size = new Size(156, 40);
            label6.TabIndex = 8;
            label6.Text = "Địa chỉ";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // inputPhone_customer
            // 
            inputPhone_customer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputPhone_customer.Font = new Font("Segoe UI", 12F);
            inputPhone_customer.Location = new Point(165, 123);
            inputPhone_customer.Name = "inputPhone_customer";
            inputPhone_customer.Size = new Size(284, 29);
            inputPhone_customer.TabIndex = 7;
            // 
            // inputName_customer
            // 
            inputName_customer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputName_customer.Font = new Font("Segoe UI", 12F);
            inputName_customer.Location = new Point(165, 43);
            inputName_customer.Name = "inputName_customer";
            inputName_customer.Size = new Size(284, 29);
            inputName_customer.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(156, 40);
            label2.TabIndex = 0;
            label2.Text = "ID khách hàng";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 40);
            label3.Name = "label3";
            label3.Size = new Size(156, 40);
            label3.TabIndex = 1;
            label3.Text = "Tên khách hàng";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(3, 80);
            label4.Name = "label4";
            label4.Size = new Size(156, 40);
            label4.TabIndex = 2;
            label4.Text = "Năm sinh";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(3, 120);
            label5.Name = "label5";
            label5.Size = new Size(156, 40);
            label5.TabIndex = 3;
            label5.Text = "Số điện thoại";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // inputID_customer
            // 
            inputID_customer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputID_customer.Font = new Font("Segoe UI", 12F);
            inputID_customer.Location = new Point(165, 3);
            inputID_customer.Name = "inputID_customer";
            inputID_customer.Size = new Size(284, 29);
            inputID_customer.TabIndex = 4;
            // 
            // inputYob_customer
            // 
            inputYob_customer.DropDownStyle = ComboBoxStyle.DropDownList;
            inputYob_customer.Font = new Font("Segoe UI", 12F);
            inputYob_customer.FormattingEnabled = true;
            inputYob_customer.Items.AddRange(new object[] { "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980", "1979", "1978", "1977", "1976", "1975", "1974", "1973", "1972", "1971", "1970", "1969", "1968", "1967", "1966", "1965", "1964", "1963", "1962", "1961", "1960", "1959", "1958", "1957", "1956", "1955", "1954", "1953", "1952", "1951", "1950" });
            inputYob_customer.Location = new Point(165, 83);
            inputYob_customer.Name = "inputYob_customer";
            inputYob_customer.Size = new Size(284, 29);
            inputYob_customer.TabIndex = 10;
            // 
            // formNhapKH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(464, 641);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Name = "formNhapKH";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formNhapKH";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnConfirm;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox inputPhone_customer;
        private TextBox inputLP_vehicle;
        private TextBox inputDes_vehicle;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox inputID_customer;
        private TextBox inputAddress_customer;
        private Label label6;
        private ComboBox inputYob_customer;
        private TextBox inputName_customer;
    }
}