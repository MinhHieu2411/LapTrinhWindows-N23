namespace btln21
{
    partial class formNhapTour
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
            inputDuration_tour = new ComboBox();
            inputCN_tour = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            inputID_tour = new TextBox();
            inputRevenue_tour = new TextBox();
            inputCus_tour = new ComboBox();
            inputHdv_tour = new ComboBox();
            inputVehicle_tour = new ComboBox();
            inputStart_tour = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64F));
            tableLayoutPanel1.Controls.Add(inputDuration_tour, 1, 2);
            tableLayoutPanel1.Controls.Add(inputCN_tour, 1, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 4);
            tableLayoutPanel1.Controls.Add(label7, 0, 5);
            tableLayoutPanel1.Controls.Add(label8, 0, 6);
            tableLayoutPanel1.Controls.Add(label9, 0, 7);
            tableLayoutPanel1.Controls.Add(inputID_tour, 1, 0);
            tableLayoutPanel1.Controls.Add(inputRevenue_tour, 1, 7);
            tableLayoutPanel1.Controls.Add(inputCus_tour, 1, 4);
            tableLayoutPanel1.Controls.Add(inputHdv_tour, 1, 5);
            tableLayoutPanel1.Controls.Add(inputVehicle_tour, 1, 6);
            tableLayoutPanel1.Controls.Add(inputStart_tour, 1, 1);
            tableLayoutPanel1.Location = new Point(0, 108);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(452, 321);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // inputDuration_tour
            // 
            inputDuration_tour.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputDuration_tour.DropDownStyle = ComboBoxStyle.DropDownList;
            inputDuration_tour.Font = new Font("Segoe UI", 12F);
            inputDuration_tour.FormattingEnabled = true;
            inputDuration_tour.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7" });
            inputDuration_tour.Location = new Point(165, 83);
            inputDuration_tour.Name = "inputDuration_tour";
            inputDuration_tour.Size = new Size(284, 29);
            inputDuration_tour.TabIndex = 19;
            inputDuration_tour.TextChanged += inputDuration_tour_TextChanged;
            // 
            // inputCN_tour
            // 
            inputCN_tour.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputCN_tour.DropDownStyle = ComboBoxStyle.DropDownList;
            inputCN_tour.Font = new Font("Segoe UI", 12F);
            inputCN_tour.FormattingEnabled = true;
            inputCN_tour.Items.AddRange(new object[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26" });
            inputCN_tour.Location = new Point(165, 123);
            inputCN_tour.Name = "inputCN_tour";
            inputCN_tour.Size = new Size(284, 29);
            inputCN_tour.TabIndex = 18;
            inputCN_tour.TextChanged += inputCN_tour_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(156, 40);
            label1.TabIndex = 0;
            label1.Text = "ID Tour";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 40);
            label2.Name = "label2";
            label2.Size = new Size(156, 40);
            label2.TabIndex = 1;
            label2.Text = "Ngày khởi hành";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 80);
            label3.Name = "label3";
            label3.Size = new Size(156, 40);
            label3.TabIndex = 2;
            label3.Text = "Thời lượng (Ngày)";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(3, 120);
            label5.Name = "label5";
            label5.Size = new Size(156, 40);
            label5.TabIndex = 4;
            label5.Text = "Số lượng khách";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(3, 160);
            label6.Name = "label6";
            label6.Size = new Size(156, 40);
            label6.TabIndex = 5;
            label6.Text = "Khách đặt";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(3, 200);
            label7.Name = "label7";
            label7.Size = new Size(156, 40);
            label7.TabIndex = 6;
            label7.Text = "Hướng dẫn viên";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(3, 240);
            label8.Name = "label8";
            label8.Size = new Size(156, 40);
            label8.TabIndex = 7;
            label8.Text = "Phương tiện";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(3, 280);
            label9.Name = "label9";
            label9.Size = new Size(156, 41);
            label9.TabIndex = 8;
            label9.Text = "Doanh thu";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // inputID_tour
            // 
            inputID_tour.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputID_tour.Font = new Font("Segoe UI", 12F);
            inputID_tour.Location = new Point(165, 3);
            inputID_tour.Name = "inputID_tour";
            inputID_tour.Size = new Size(284, 29);
            inputID_tour.TabIndex = 9;
            // 
            // inputRevenue_tour
            // 
            inputRevenue_tour.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputRevenue_tour.Enabled = false;
            inputRevenue_tour.Font = new Font("Segoe UI", 12F);
            inputRevenue_tour.Location = new Point(165, 283);
            inputRevenue_tour.Name = "inputRevenue_tour";
            inputRevenue_tour.ReadOnly = true;
            inputRevenue_tour.Size = new Size(284, 29);
            inputRevenue_tour.TabIndex = 13;
            // 
            // inputCus_tour
            // 
            inputCus_tour.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputCus_tour.DropDownStyle = ComboBoxStyle.DropDownList;
            inputCus_tour.Font = new Font("Segoe UI", 12F);
            inputCus_tour.FormattingEnabled = true;
            inputCus_tour.Location = new Point(165, 163);
            inputCus_tour.Name = "inputCus_tour";
            inputCus_tour.Size = new Size(284, 29);
            inputCus_tour.TabIndex = 15;
            // 
            // inputHdv_tour
            // 
            inputHdv_tour.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputHdv_tour.DropDownStyle = ComboBoxStyle.DropDownList;
            inputHdv_tour.Font = new Font("Segoe UI", 12F);
            inputHdv_tour.FormattingEnabled = true;
            inputHdv_tour.Location = new Point(165, 203);
            inputHdv_tour.Name = "inputHdv_tour";
            inputHdv_tour.Size = new Size(284, 29);
            inputHdv_tour.TabIndex = 16;
            // 
            // inputVehicle_tour
            // 
            inputVehicle_tour.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputVehicle_tour.DropDownStyle = ComboBoxStyle.DropDownList;
            inputVehicle_tour.Font = new Font("Segoe UI", 12F);
            inputVehicle_tour.FormattingEnabled = true;
            inputVehicle_tour.Location = new Point(165, 243);
            inputVehicle_tour.Name = "inputVehicle_tour";
            inputVehicle_tour.Size = new Size(284, 29);
            inputVehicle_tour.TabIndex = 17;
            // 
            // inputStart_tour
            // 
            inputStart_tour.CalendarFont = new Font("Segoe UI", 12F);
            inputStart_tour.Location = new Point(165, 43);
            inputStart_tour.Name = "inputStart_tour";
            inputStart_tour.Size = new Size(284, 23);
            inputStart_tour.TabIndex = 14;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 513);
            button1.Name = "button1";
            button1.Size = new Size(440, 55);
            button1.TabIndex = 1;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 574);
            button2.Name = "button2";
            button2.Size = new Size(440, 55);
            button2.TabIndex = 2;
            button2.Text = "Hủy bỏ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(123, 35);
            label4.Name = "label4";
            label4.Size = new Size(233, 30);
            label4.TabIndex = 3;
            label4.Text = "Thông tin Tour du lịch";
            // 
            // formNhapTour
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(464, 641);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel1);
            Name = "formNhapTour";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin Tour";
            Load += formNhapTour_Load;
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
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button1;
        private Button button2;
        private TextBox inputID_tour;
        private TextBox input;
        private TextBox inputRevenue_tour;
        private DateTimePicker inputStart_tour;
        private Label label4;
        private ComboBox inputCus_tour;
        private ComboBox inputHdv_tour;
        private ComboBox inputVehicle_tour;
        private ComboBox inputCN_tour;
        private ComboBox inputDuration_tour;
    }
}