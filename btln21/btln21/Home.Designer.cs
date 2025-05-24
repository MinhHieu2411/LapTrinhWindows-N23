namespace btln21
{
    partial class Home
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
            tabControl1 = new TabControl();
            tpHome = new TabPage();
            tpHDV = new TabPage();
            lTB_Hdv = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            button3 = new Button();
            button2 = new Button();
            btnAddHdv = new Button();
            dgvHDV = new DataGridView();
            hdv_id = new DataGridViewTextBoxColumn();
            hdv_name = new DataGridViewTextBoxColumn();
            hdv_Yob = new DataGridViewTextBoxColumn();
            hdv_phone = new DataGridViewTextBoxColumn();
            hdv_address = new DataGridViewTextBoxColumn();
            hdv_works = new DataGridViewTextBoxColumn();
            hdv_salary = new DataGridViewTextBoxColumn();
            tpVehicle = new TabPage();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            button6 = new Button();
            btnEditVehicle = new Button();
            btnAddVehicle = new Button();
            dgvVehicles = new DataGridView();
            vehicle_id = new DataGridViewTextBoxColumn();
            vehicleDes = new DataGridViewTextBoxColumn();
            vehicle_lp = new DataGridViewTextBoxColumn();
            vehicle_cap = new DataGridViewTextBoxColumn();
            tpTours = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnDeleteTour = new Button();
            btnEditTour = new Button();
            btnAddTour = new Button();
            dgvTours = new DataGridView();
            tour_ID = new DataGridViewTextBoxColumn();
            tour_StartDate = new DataGridViewTextBoxColumn();
            tour_Duration = new DataGridViewTextBoxColumn();
            tour_NumCus = new DataGridViewTextBoxColumn();
            tour_Cus = new DataGridViewTextBoxColumn();
            tour_hdv = new DataGridViewTextBoxColumn();
            tour_Vehicle = new DataGridViewTextBoxColumn();
            tour_Revenue = new DataGridViewTextBoxColumn();
            tour_Status = new DataGridViewTextBoxColumn();
            tpCustomer = new TabPage();
            tpAccount = new TabPage();
            button1 = new Button();
            button4 = new Button();
            tabControl1.SuspendLayout();
            tpHome.SuspendLayout();
            tpHDV.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHDV).BeginInit();
            tpVehicle.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).BeginInit();
            tpTours.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTours).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tpHome);
            tabControl1.Controls.Add(tpHDV);
            tabControl1.Controls.Add(tpVehicle);
            tabControl1.Controls.Add(tpTours);
            tabControl1.Controls.Add(tpCustomer);
            tabControl1.Controls.Add(tpAccount);
            tabControl1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1265, 683);
            tabControl1.TabIndex = 0;
            // 
            // tpHome
            // 
            tpHome.BackColor = Color.Linen;
            tpHome.Controls.Add(button4);
            tpHome.Controls.Add(button1);
            tpHome.Location = new Point(4, 29);
            tpHome.Name = "tpHome";
            tpHome.Padding = new Padding(3);
            tpHome.Size = new Size(1257, 650);
            tpHome.TabIndex = 0;
            tpHome.Text = "Trang chủ";
            // 
            // tpHDV
            // 
            tpHDV.BackColor = Color.Linen;
            tpHDV.Controls.Add(lTB_Hdv);
            tpHDV.Controls.Add(label1);
            tpHDV.Controls.Add(tableLayoutPanel1);
            tpHDV.Controls.Add(dgvHDV);
            tpHDV.Location = new Point(4, 29);
            tpHDV.Name = "tpHDV";
            tpHDV.Padding = new Padding(3);
            tpHDV.Size = new Size(1257, 650);
            tpHDV.TabIndex = 1;
            tpHDV.Text = "Hướng dẫn viên";
            // 
            // lTB_Hdv
            // 
            lTB_Hdv.AutoSize = true;
            lTB_Hdv.Location = new Point(8, 108);
            lTB_Hdv.Name = "lTB_Hdv";
            lTB_Hdv.Size = new Size(194, 20);
            lTB_Hdv.TabIndex = 3;
            lTB_Hdv.Text = "Danh sách hướng dẫn viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(495, 3);
            label1.Name = "label1";
            label1.Size = new Size(244, 30);
            label1.TabIndex = 2;
            label1.Text = "Quản lý hướng dẫn viên";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(btnAddHdv, 0, 0);
            tableLayoutPanel1.Location = new Point(8, 45);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(400, 51);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.BackColor = Color.LightGray;
            button3.Location = new Point(267, 3);
            button3.Name = "button3";
            button3.Size = new Size(130, 45);
            button3.TabIndex = 2;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.LightGray;
            button2.Location = new Point(135, 3);
            button2.Name = "button2";
            button2.Size = new Size(126, 45);
            button2.TabIndex = 1;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnAddHdv
            // 
            btnAddHdv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAddHdv.BackColor = Color.DeepSkyBlue;
            btnAddHdv.Location = new Point(3, 3);
            btnAddHdv.Name = "btnAddHdv";
            btnAddHdv.Size = new Size(126, 45);
            btnAddHdv.TabIndex = 0;
            btnAddHdv.Text = "Thêm";
            btnAddHdv.UseVisualStyleBackColor = false;
            btnAddHdv.Click += btnAddHdv_Click;
            // 
            // dgvHDV
            // 
            dgvHDV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHDV.Columns.AddRange(new DataGridViewColumn[] { hdv_id, hdv_name, hdv_Yob, hdv_phone, hdv_address, hdv_works, hdv_salary });
            dgvHDV.Location = new Point(8, 143);
            dgvHDV.Name = "dgvHDV";
            dgvHDV.Size = new Size(1243, 497);
            dgvHDV.TabIndex = 0;
            // 
            // hdv_id
            // 
            hdv_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            hdv_id.FillWeight = 60F;
            hdv_id.HeaderText = "ID";
            hdv_id.Name = "hdv_id";
            // 
            // hdv_name
            // 
            hdv_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            hdv_name.FillWeight = 149.2032F;
            hdv_name.HeaderText = "Họ và tên";
            hdv_name.Name = "hdv_name";
            // 
            // hdv_Yob
            // 
            hdv_Yob.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            hdv_Yob.FillWeight = 71.066F;
            hdv_Yob.HeaderText = "Năm sinh";
            hdv_Yob.Name = "hdv_Yob";
            // 
            // hdv_phone
            // 
            hdv_phone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            hdv_phone.HeaderText = "Số điện thoại";
            hdv_phone.Name = "hdv_phone";
            // 
            // hdv_address
            // 
            hdv_address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            hdv_address.FillWeight = 120F;
            hdv_address.HeaderText = "Địa chỉ";
            hdv_address.Name = "hdv_address";
            // 
            // hdv_works
            // 
            hdv_works.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            hdv_works.FillWeight = 70F;
            hdv_works.HeaderText = "Thâm niên (Năm)";
            hdv_works.Name = "hdv_works";
            // 
            // hdv_salary
            // 
            hdv_salary.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            hdv_salary.FillWeight = 105.89183F;
            hdv_salary.HeaderText = "Lương cơ bản";
            hdv_salary.Name = "hdv_salary";
            // 
            // tpVehicle
            // 
            tpVehicle.BackColor = Color.Linen;
            tpVehicle.Controls.Add(label2);
            tpVehicle.Controls.Add(tableLayoutPanel2);
            tpVehicle.Controls.Add(dgvVehicles);
            tpVehicle.Location = new Point(4, 29);
            tpVehicle.Name = "tpVehicle";
            tpVehicle.Padding = new Padding(3);
            tpVehicle.Size = new Size(1257, 650);
            tpVehicle.TabIndex = 2;
            tpVehicle.Text = "Phương tiện";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(11, 109);
            label2.Name = "label2";
            label2.Size = new Size(171, 20);
            label2.TabIndex = 3;
            label2.Text = "Danh sách phương tiện";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(button6, 2, 0);
            tableLayoutPanel2.Controls.Add(btnEditVehicle, 1, 0);
            tableLayoutPanel2.Controls.Add(btnAddVehicle, 0, 0);
            tableLayoutPanel2.Location = new Point(8, 45);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(400, 51);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button6.BackColor = Color.LightGray;
            button6.Location = new Point(269, 3);
            button6.Name = "button6";
            button6.Size = new Size(128, 45);
            button6.TabIndex = 2;
            button6.Text = "Xóa";
            button6.UseVisualStyleBackColor = false;
            // 
            // btnEditVehicle
            // 
            btnEditVehicle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEditVehicle.BackColor = Color.LightGray;
            btnEditVehicle.Location = new Point(136, 3);
            btnEditVehicle.Name = "btnEditVehicle";
            btnEditVehicle.Size = new Size(127, 45);
            btnEditVehicle.TabIndex = 1;
            btnEditVehicle.Text = "Sửa";
            btnEditVehicle.UseVisualStyleBackColor = false;
            // 
            // btnAddVehicle
            // 
            btnAddVehicle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAddVehicle.BackColor = Color.DeepSkyBlue;
            btnAddVehicle.Location = new Point(3, 3);
            btnAddVehicle.Name = "btnAddVehicle";
            btnAddVehicle.Size = new Size(127, 45);
            btnAddVehicle.TabIndex = 0;
            btnAddVehicle.Text = "Thêm";
            btnAddVehicle.UseVisualStyleBackColor = false;
            btnAddVehicle.Click += btnAddVehicle_Click;
            // 
            // dgvVehicles
            // 
            dgvVehicles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVehicles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicles.Columns.AddRange(new DataGridViewColumn[] { vehicle_id, vehicleDes, vehicle_lp, vehicle_cap });
            dgvVehicles.Location = new Point(8, 143);
            dgvVehicles.Name = "dgvVehicles";
            dgvVehicles.Size = new Size(1243, 497);
            dgvVehicles.TabIndex = 1;
            // 
            // vehicle_id
            // 
            vehicle_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            vehicle_id.FillWeight = 56.16361F;
            vehicle_id.HeaderText = "ID";
            vehicle_id.Name = "vehicle_id";
            // 
            // vehicleDes
            // 
            vehicleDes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            vehicleDes.FillWeight = 160F;
            vehicleDes.HeaderText = "Mô tả";
            vehicleDes.Name = "vehicleDes";
            // 
            // vehicle_lp
            // 
            vehicle_lp.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            vehicle_lp.FillWeight = 71.066F;
            vehicle_lp.HeaderText = "Biển số";
            vehicle_lp.Name = "vehicle_lp";
            // 
            // vehicle_cap
            // 
            vehicle_cap.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            vehicle_cap.HeaderText = "Lượng khách tối đa";
            vehicle_cap.Name = "vehicle_cap";
            // 
            // tpTours
            // 
            tpTours.BackColor = Color.Linen;
            tpTours.Controls.Add(tableLayoutPanel3);
            tpTours.Controls.Add(dgvTours);
            tpTours.Location = new Point(4, 29);
            tpTours.Name = "tpTours";
            tpTours.Padding = new Padding(3);
            tpTours.Size = new Size(1257, 650);
            tpTours.TabIndex = 3;
            tpTours.Text = "Tours";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(btnDeleteTour, 2, 0);
            tableLayoutPanel3.Controls.Add(btnEditTour, 1, 0);
            tableLayoutPanel3.Controls.Add(btnAddTour, 0, 0);
            tableLayoutPanel3.Location = new Point(8, 45);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(400, 51);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // btnDeleteTour
            // 
            btnDeleteTour.BackColor = Color.LightGray;
            btnDeleteTour.Location = new Point(269, 3);
            btnDeleteTour.Name = "btnDeleteTour";
            btnDeleteTour.Size = new Size(127, 45);
            btnDeleteTour.TabIndex = 2;
            btnDeleteTour.Text = "Xóa";
            btnDeleteTour.UseVisualStyleBackColor = false;
            // 
            // btnEditTour
            // 
            btnEditTour.BackColor = Color.LightGray;
            btnEditTour.Location = new Point(136, 3);
            btnEditTour.Name = "btnEditTour";
            btnEditTour.Size = new Size(127, 45);
            btnEditTour.TabIndex = 1;
            btnEditTour.Text = "Sửa";
            btnEditTour.UseVisualStyleBackColor = false;
            // 
            // btnAddTour
            // 
            btnAddTour.BackColor = Color.DeepSkyBlue;
            btnAddTour.Location = new Point(3, 3);
            btnAddTour.Name = "btnAddTour";
            btnAddTour.Size = new Size(127, 45);
            btnAddTour.TabIndex = 0;
            btnAddTour.Text = "Thêm";
            btnAddTour.UseVisualStyleBackColor = false;
            btnAddTour.Click += btnAddTour_Click;
            // 
            // dgvTours
            // 
            dgvTours.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTours.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTours.Columns.AddRange(new DataGridViewColumn[] { tour_ID, tour_StartDate, tour_Duration, tour_NumCus, tour_Cus, tour_hdv, tour_Vehicle, tour_Revenue, tour_Status });
            dgvTours.Location = new Point(8, 143);
            dgvTours.Name = "dgvTours";
            dgvTours.Size = new Size(1243, 497);
            dgvTours.TabIndex = 0;
            // 
            // tour_ID
            // 
            tour_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tour_ID.FillWeight = 60F;
            tour_ID.HeaderText = "ID Tours";
            tour_ID.Name = "tour_ID";
            // 
            // tour_StartDate
            // 
            tour_StartDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tour_StartDate.HeaderText = "Ngày khởi hành";
            tour_StartDate.Name = "tour_StartDate";
            // 
            // tour_Duration
            // 
            tour_Duration.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tour_Duration.HeaderText = "Thời gian (Ngày)";
            tour_Duration.Name = "tour_Duration";
            // 
            // tour_NumCus
            // 
            tour_NumCus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tour_NumCus.HeaderText = "Số khách";
            tour_NumCus.Name = "tour_NumCus";
            // 
            // tour_Cus
            // 
            tour_Cus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tour_Cus.HeaderText = "Khách đặt";
            tour_Cus.Name = "tour_Cus";
            // 
            // tour_hdv
            // 
            tour_hdv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tour_hdv.HeaderText = "Hướng dẫn viên";
            tour_hdv.Name = "tour_hdv";
            // 
            // tour_Vehicle
            // 
            tour_Vehicle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tour_Vehicle.HeaderText = "Phương tiện";
            tour_Vehicle.Name = "tour_Vehicle";
            // 
            // tour_Revenue
            // 
            tour_Revenue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tour_Revenue.HeaderText = "Doanh thu";
            tour_Revenue.Name = "tour_Revenue";
            // 
            // tour_Status
            // 
            tour_Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tour_Status.HeaderText = "Tình trạng";
            tour_Status.Name = "tour_Status";
            // 
            // tpCustomer
            // 
            tpCustomer.Location = new Point(4, 29);
            tpCustomer.Name = "tpCustomer";
            tpCustomer.Padding = new Padding(3);
            tpCustomer.Size = new Size(1257, 650);
            tpCustomer.TabIndex = 4;
            tpCustomer.Text = "Khách hàng";
            tpCustomer.UseVisualStyleBackColor = true;
            // 
            // tpAccount
            // 
            tpAccount.Location = new Point(4, 29);
            tpAccount.Name = "tpAccount";
            tpAccount.Padding = new Padding(3);
            tpAccount.Size = new Size(1257, 650);
            tpAccount.TabIndex = 5;
            tpAccount.Text = "Tài khoản";
            tpAccount.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.DeepSkyBlue;
            button1.Location = new Point(359, 299);
            button1.Name = "button1";
            button1.Size = new Size(454, 63);
            button1.TabIndex = 0;
            button1.Text = "Đổi mật khảu";
            button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.BackColor = Color.DarkGray;
            button4.Location = new Point(359, 401);
            button4.Name = "button4";
            button4.Size = new Size(454, 63);
            button4.TabIndex = 1;
            button4.Text = "Đăng xuất";
            button4.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(tabControl1);
            Name = "Home";
            Text = "Travel Company Managerment";
            tabControl1.ResumeLayout(false);
            tpHome.ResumeLayout(false);
            tpHDV.ResumeLayout(false);
            tpHDV.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHDV).EndInit();
            tpVehicle.ResumeLayout(false);
            tpVehicle.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).EndInit();
            tpTours.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTours).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpHome;
        private TabPage tpHDV;
        private TabPage tpVehicle;
        private TabPage tpTours;
        private TabPage tpCustomer;
        private TabPage tpAccount;
        private DataGridView dgvHDV;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button3;
        private Button button2;
        private Button btnAddHdv;
        private Label label1;
        private Label lTB_Hdv;
        private DataGridView dgvVehicles;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button6;
        private Button btnEditVehicle;
        private Button btnAddVehicle;
        private Label label2;
        private DataGridView dgvTours;
        private DataGridViewTextBoxColumn hdv_id;
        private DataGridViewTextBoxColumn hdv_name;
        private DataGridViewTextBoxColumn hdv_Yob;
        private DataGridViewTextBoxColumn hdv_phone;
        private DataGridViewTextBoxColumn hdv_address;
        private DataGridViewTextBoxColumn hdv_works;
        private DataGridViewTextBoxColumn hdv_salary;
        private DataGridViewTextBoxColumn vehicle_id;
        private DataGridViewTextBoxColumn vehicleDes;
        private DataGridViewTextBoxColumn vehicle_lp;
        private DataGridViewTextBoxColumn vehicle_cap;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridViewTextBoxColumn tour_ID;
        private DataGridViewTextBoxColumn tour_StartDate;
        private DataGridViewTextBoxColumn tour_Duration;
        private DataGridViewTextBoxColumn tour_NumCus;
        private DataGridViewTextBoxColumn tour_Cus;
        private DataGridViewTextBoxColumn tour_hdv;
        private DataGridViewTextBoxColumn tour_Vehicle;
        private DataGridViewTextBoxColumn tour_Revenue;
        private DataGridViewTextBoxColumn tour_Status;
        private Button btnDeleteTour;
        private Button btnEditTour;
        private Button btnAddTour;
        private Button button4;
        private Button button1;
    }
}