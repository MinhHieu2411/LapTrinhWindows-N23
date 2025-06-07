namespace btln21
{
    partial class formDoiMK
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            mkCu = new TextBox();
            mkMoi = new TextBox();
            nhapLai = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            txtusername = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(mkCu, 1, 0);
            tableLayoutPanel1.Controls.Add(mkMoi, 1, 1);
            tableLayoutPanel1.Controls.Add(nhapLai, 1, 2);
            tableLayoutPanel1.Controls.Add(button1, 0, 3);
            tableLayoutPanel1.Controls.Add(button2, 1, 3);
            tableLayoutPanel1.Location = new Point(1, 81);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(315, 199);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(151, 40);
            label2.TabIndex = 0;
            label2.Text = "Mật khẩu cũ";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(3, 40);
            label3.Name = "label3";
            label3.Size = new Size(151, 40);
            label3.TabIndex = 1;
            label3.Text = "Mật khẩu mới";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(3, 80);
            label4.Name = "label4";
            label4.Size = new Size(151, 40);
            label4.TabIndex = 2;
            label4.Text = "Nhập lại mật khẩu";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // mkCu
            // 
            mkCu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mkCu.Font = new Font("Segoe UI", 11.25F);
            mkCu.Location = new Point(160, 3);
            mkCu.Name = "mkCu";
            mkCu.Size = new Size(152, 27);
            mkCu.TabIndex = 3;
            mkCu.UseSystemPasswordChar = true;
            // 
            // mkMoi
            // 
            mkMoi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mkMoi.Font = new Font("Segoe UI", 11.25F);
            mkMoi.Location = new Point(160, 43);
            mkMoi.Name = "mkMoi";
            mkMoi.Size = new Size(152, 27);
            mkMoi.TabIndex = 4;
            mkMoi.UseSystemPasswordChar = true;
            // 
            // nhapLai
            // 
            nhapLai.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nhapLai.Font = new Font("Segoe UI", 11.25F);
            nhapLai.Location = new Point(160, 83);
            nhapLai.Name = "nhapLai";
            nhapLai.Size = new Size(152, 27);
            nhapLai.TabIndex = 5;
            nhapLai.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 123);
            button1.Name = "button1";
            button1.Size = new Size(151, 54);
            button1.TabIndex = 6;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(160, 123);
            button2.Name = "button2";
            button2.Size = new Size(152, 54);
            button2.TabIndex = 7;
            button2.Text = "Hủy bỏ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 30);
            label1.TabIndex = 1;
            label1.Text = "Đổi mật khẩu";
            // 
            // txtusername
            // 
            txtusername.AutoSize = true;
            txtusername.Location = new Point(29, 51);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(73, 15);
            txtusername.TabIndex = 2;
            txtusername.Text = "txtUsername";
            txtusername.Visible = false;
            // 
            // formDoiMK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(316, 280);
            Controls.Add(txtusername);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Name = "formDoiMK";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private TextBox mkCu;
        private TextBox mkMoi;
        private TextBox nhapLai;
        private Button button1;
        private Button button2;
        private Label txtusername;
    }
}