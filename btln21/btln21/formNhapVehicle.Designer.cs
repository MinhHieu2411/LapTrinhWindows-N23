namespace btln21
{
    partial class formNhapVehicle
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
            inputCap_vehicle = new TextBox();
            inputLP_vehicle = new TextBox();
            inputDes_vehicle = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            inputID_vehicle = new TextBox();
            label1 = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64F));
            tableLayoutPanel1.Controls.Add(inputCap_vehicle, 1, 3);
            tableLayoutPanel1.Controls.Add(inputLP_vehicle, 1, 2);
            tableLayoutPanel1.Controls.Add(inputDes_vehicle, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(inputID_vehicle, 1, 0);
            tableLayoutPanel1.Location = new Point(0, 108);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(452, 322);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // inputCap_vehicle
            // 
            inputCap_vehicle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputCap_vehicle.Location = new Point(165, 283);
            inputCap_vehicle.Name = "inputCap_vehicle";
            inputCap_vehicle.Size = new Size(284, 23);
            inputCap_vehicle.TabIndex = 7;
            // 
            // inputLP_vehicle
            // 
            inputLP_vehicle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputLP_vehicle.Location = new Point(165, 243);
            inputLP_vehicle.Name = "inputLP_vehicle";
            inputLP_vehicle.Size = new Size(284, 23);
            inputLP_vehicle.TabIndex = 6;
            // 
            // inputDes_vehicle
            // 
            inputDes_vehicle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputDes_vehicle.Location = new Point(165, 43);
            inputDes_vehicle.Multiline = true;
            inputDes_vehicle.Name = "inputDes_vehicle";
            inputDes_vehicle.Size = new Size(284, 194);
            inputDes_vehicle.TabIndex = 5;
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
            label2.Text = "ID Phương tiện";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 40);
            label3.Name = "label3";
            label3.Size = new Size(156, 200);
            label3.TabIndex = 1;
            label3.Text = "Mô tả";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(3, 240);
            label4.Name = "label4";
            label4.Size = new Size(156, 40);
            label4.TabIndex = 2;
            label4.Text = "Biển số";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(3, 280);
            label5.Name = "label5";
            label5.Size = new Size(156, 42);
            label5.TabIndex = 3;
            label5.Text = "Lượng khách tối đa";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // inputID_vehicle
            // 
            inputID_vehicle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputID_vehicle.Location = new Point(165, 3);
            inputID_vehicle.Name = "inputID_vehicle";
            inputID_vehicle.Size = new Size(284, 23);
            inputID_vehicle.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 29);
            label1.Name = "label1";
            label1.Size = new Size(239, 30);
            label1.TabIndex = 1;
            label1.Text = "Thông tin phương tiện";
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
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(12, 574);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(440, 55);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Hủy bỏ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // formNhapVehicle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(464, 641);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Name = "formNhapVehicle";
            Text = "Thông tin phương tiện";
            Load += formNhapVehicle_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox inputCap_vehicle;
        private TextBox inputLP_vehicle;
        private TextBox inputDes_vehicle;
        private TextBox inputID_vehicle;
        private Button btnConfirm;
        private Button btnCancel;
    }
}