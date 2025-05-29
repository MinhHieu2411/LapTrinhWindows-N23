namespace btln21
{
    partial class formNhapAdmin
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
            reTypePassword = new TextBox();
            inputPassword = new TextBox();
            label1 = new Label();
            label3 = new Label();
            inputUsername = new TextBox();
            label2 = new Label();
            btnCancel = new Button();
            btnConfirm = new Button();
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
            tableLayoutPanel1.Controls.Add(reTypePassword, 1, 2);
            tableLayoutPanel1.Controls.Add(inputPassword, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(inputUsername, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Location = new Point(9, 111);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(440, 120);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // reTypePassword
            // 
            reTypePassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reTypePassword.Font = new Font("Segoe UI", 12F);
            reTypePassword.Location = new Point(161, 83);
            reTypePassword.Name = "reTypePassword";
            reTypePassword.Size = new Size(276, 29);
            reTypePassword.TabIndex = 5;
            // 
            // inputPassword
            // 
            inputPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputPassword.Font = new Font("Segoe UI", 12F);
            inputPassword.Location = new Point(161, 43);
            inputPassword.Name = "inputPassword";
            inputPassword.Size = new Size(276, 29);
            inputPassword.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 40);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 80);
            label3.Name = "label3";
            label3.Size = new Size(152, 40);
            label3.TabIndex = 2;
            label3.Text = "Nhập lại mật khẩu";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // inputUsername
            // 
            inputUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputUsername.Font = new Font("Segoe UI", 12F);
            inputUsername.Location = new Point(161, 3);
            inputUsername.Name = "inputUsername";
            inputUsername.Size = new Size(276, 29);
            inputUsername.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 40);
            label2.Name = "label2";
            label2.Size = new Size(152, 40);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.BackColor = Color.Transparent;
            btnCancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(9, 373);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(440, 57);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Quay lại";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnConfirm.BackColor = Color.DeepSkyBlue;
            btnConfirm.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(9, 312);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(440, 57);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(80, 38);
            label4.Name = "label4";
            label4.Size = new Size(308, 25);
            label4.TabIndex = 6;
            label4.Text = "Nhập tên đăng nhập và mật khẩu";
            // 
            // formNhapAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(464, 443);
            Controls.Add(label4);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(tableLayoutPanel1);
            Name = "formNhapAdmin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đăng kí quản trị viên mới";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnCancel;
        private Button btnConfirm;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox inputUsername;
        private TextBox reTypePassword;
        private TextBox inputPassword;
        private Label label4;
    }
}