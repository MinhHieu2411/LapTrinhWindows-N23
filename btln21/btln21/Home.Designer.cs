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
            tpCustomer = new TabPage();
            label11 = new Label();
            txtSearchCustomer = new TextBox();
            label7 = new Label();
            label4 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnDeleteCustomer = new Button();
            btnEditCustomer = new Button();
            btnAddCustomer = new Button();
            dgvCustomers = new DataGridView();
            customer_id = new DataGridViewTextBoxColumn();
            customer_name = new DataGridViewTextBoxColumn();
            customer_Yob = new DataGridViewTextBoxColumn();
            customer_phone = new DataGridViewTextBoxColumn();
            customer_address = new DataGridViewTextBoxColumn();
            tpTours = new TabPage();
            label10 = new Label();
            txtSearchTour = new TextBox();
            label6 = new Label();
            label3 = new Label();
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
            tpVehicle = new TabPage();
            label9 = new Label();
            txtSearchVehicle = new TextBox();
            label5 = new Label();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnDeleteVehicle = new Button();
            btnEditVehicle = new Button();
            btnAddVehicle = new Button();
            dgvVehicles = new DataGridView();
            vehicle_id = new DataGridViewTextBoxColumn();
            vehicleDes = new DataGridViewTextBoxColumn();
            vehicle_lp = new DataGridViewTextBoxColumn();
            vehicle_cap = new DataGridViewTextBoxColumn();
            tpHDV = new TabPage();
            label8 = new Label();
            txtSearchHdv = new TextBox();
            lTB_Hdv = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnDeleteHdv = new Button();
            btnEditHdv = new Button();
            btnAddHdv = new Button();
            dgvHDV = new DataGridView();
            hdv_id = new DataGridViewTextBoxColumn();
            hdv_name = new DataGridViewTextBoxColumn();
            hdv_Yob = new DataGridViewTextBoxColumn();
            hdv_phone = new DataGridViewTextBoxColumn();
            hdv_address = new DataGridViewTextBoxColumn();
            hdv_works = new DataGridViewTextBoxColumn();
            hdv_salary = new DataGridViewTextBoxColumn();
            tpHome = new TabPage();
            btnAddAdmin = new Button();
            btnLogOut = new Button();
            btnChangePassword = new Button();
            tabControl1 = new TabControl();
            tpCustomer.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            tpTours.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTours).BeginInit();
            tpVehicle.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).BeginInit();
            tpHDV.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHDV).BeginInit();
            tpHome.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tpCustomer
            // 
            tpCustomer.BackColor = Color.Linen;
            tpCustomer.Controls.Add(label11);
            tpCustomer.Controls.Add(txtSearchCustomer);
            tpCustomer.Controls.Add(label7);
            tpCustomer.Controls.Add(label4);
            tpCustomer.Controls.Add(tableLayoutPanel4);
            tpCustomer.Controls.Add(dgvCustomers);
            tpCustomer.Location = new Point(4, 29);
            tpCustomer.Name = "tpCustomer";
            tpCustomer.Padding = new Padding(3);
            tpCustomer.Size = new Size(1257, 650);
            tpCustomer.TabIndex = 4;
            tpCustomer.Text = "Khách hàng";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(856, 111);
            label11.Name = "label11";
            label11.Size = new Size(74, 20);
            label11.TabIndex = 11;
            label11.Text = "Tìm kiếm";
            // 
            // txtSearchCustomer
            // 
            txtSearchCustomer.Location = new Point(936, 108);
            txtSearchCustomer.Name = "txtSearchCustomer";
            txtSearchCustomer.Size = new Size(315, 27);
            txtSearchCustomer.TabIndex = 10;
            txtSearchCustomer.TextChanged += txtSearchCustomer_TextChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.Location = new Point(531, 3);
            label7.Name = "label7";
            label7.Size = new Size(203, 30);
            label7.TabIndex = 5;
            label7.Text = "Quản lý khách hàng";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(8, 111);
            label4.Name = "label4";
            label4.Size = new Size(165, 20);
            label4.TabIndex = 4;
            label4.Text = "Danh sách khách hàng";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.BackColor = Color.Linen;
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Controls.Add(btnDeleteCustomer, 2, 0);
            tableLayoutPanel4.Controls.Add(btnEditCustomer, 1, 0);
            tableLayoutPanel4.Controls.Add(btnAddCustomer, 0, 0);
            tableLayoutPanel4.Location = new Point(8, 45);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(400, 51);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDeleteCustomer.BackColor = Color.LightGray;
            btnDeleteCustomer.Location = new Point(269, 3);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(128, 45);
            btnDeleteCustomer.TabIndex = 2;
            btnDeleteCustomer.Text = "Xóa";
            btnDeleteCustomer.UseVisualStyleBackColor = false;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // btnEditCustomer
            // 
            btnEditCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEditCustomer.BackColor = Color.LightGray;
            btnEditCustomer.Location = new Point(136, 3);
            btnEditCustomer.Name = "btnEditCustomer";
            btnEditCustomer.Size = new Size(127, 45);
            btnEditCustomer.TabIndex = 1;
            btnEditCustomer.Text = "Sửa";
            btnEditCustomer.UseVisualStyleBackColor = false;
            btnEditCustomer.Click += btnEditCustomer_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAddCustomer.BackColor = Color.DeepSkyBlue;
            btnAddCustomer.Location = new Point(3, 3);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(127, 45);
            btnAddCustomer.TabIndex = 0;
            btnAddCustomer.Text = "Thêm";
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { customer_id, customer_name, customer_Yob, customer_phone, customer_address });
            dgvCustomers.Location = new Point(8, 143);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.Size = new Size(1243, 497);
            dgvCustomers.TabIndex = 0;
            dgvCustomers.CellDoubleClick += dgvCustomers_CellDoubleClick;
            // 
            // customer_id
            // 
            customer_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customer_id.FillWeight = 80F;
            customer_id.HeaderText = "ID ";
            customer_id.Name = "customer_id";
            // 
            // customer_name
            // 
            customer_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customer_name.FillWeight = 120F;
            customer_name.HeaderText = "Tên khách hàng";
            customer_name.Name = "customer_name";
            // 
            // customer_Yob
            // 
            customer_Yob.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customer_Yob.FillWeight = 80F;
            customer_Yob.HeaderText = "Năm sinh";
            customer_Yob.Name = "customer_Yob";
            // 
            // customer_phone
            // 
            customer_phone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customer_phone.HeaderText = "Số điện thoại";
            customer_phone.Name = "customer_phone";
            // 
            // customer_address
            // 
            customer_address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customer_address.HeaderText = "Địa chỉ";
            customer_address.Name = "customer_address";
            // 
            // tpTours
            // 
            tpTours.BackColor = Color.Linen;
            tpTours.Controls.Add(label10);
            tpTours.Controls.Add(txtSearchTour);
            tpTours.Controls.Add(label6);
            tpTours.Controls.Add(label3);
            tpTours.Controls.Add(tableLayoutPanel3);
            tpTours.Controls.Add(dgvTours);
            tpTours.Location = new Point(4, 29);
            tpTours.Name = "tpTours";
            tpTours.Padding = new Padding(3);
            tpTours.Size = new Size(1257, 650);
            tpTours.TabIndex = 3;
            tpTours.Text = "Tours";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(856, 110);
            label10.Name = "label10";
            label10.Size = new Size(74, 20);
            label10.TabIndex = 9;
            label10.Text = "Tìm kiếm";
            // 
            // txtSearchTour
            // 
            txtSearchTour.Location = new Point(936, 107);
            txtSearchTour.Name = "txtSearchTour";
            txtSearchTour.Size = new Size(315, 27);
            txtSearchTour.TabIndex = 8;
            txtSearchTour.TextChanged += txtSearchTour_TextChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(556, 3);
            label6.Name = "label6";
            label6.Size = new Size(136, 30);
            label6.TabIndex = 5;
            label6.Text = "Quản lý Tour";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(8, 110);
            label3.Name = "label3";
            label3.Size = new Size(173, 20);
            label3.TabIndex = 4;
            label3.Text = "Danh sách Tour tổ chức";
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
            btnDeleteTour.Click += btnDeleteTour_Click;
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
            btnEditTour.Click += btnEditTour_Click;
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
            // tpVehicle
            // 
            tpVehicle.BackColor = Color.Linen;
            tpVehicle.Controls.Add(label9);
            tpVehicle.Controls.Add(txtSearchVehicle);
            tpVehicle.Controls.Add(label5);
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(856, 109);
            label9.Name = "label9";
            label9.Size = new Size(74, 20);
            label9.TabIndex = 7;
            label9.Text = "Tìm kiếm";
            // 
            // txtSearchVehicle
            // 
            txtSearchVehicle.Location = new Point(936, 106);
            txtSearchVehicle.Name = "txtSearchVehicle";
            txtSearchVehicle.Size = new Size(315, 27);
            txtSearchVehicle.TabIndex = 6;
            txtSearchVehicle.TextChanged += txtSearchVehicle_TextChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(524, 3);
            label5.Name = "label5";
            label5.Size = new Size(211, 30);
            label5.TabIndex = 4;
            label5.Text = "Quản lý phương tiện";
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
            tableLayoutPanel2.Controls.Add(btnDeleteVehicle, 2, 0);
            tableLayoutPanel2.Controls.Add(btnEditVehicle, 1, 0);
            tableLayoutPanel2.Controls.Add(btnAddVehicle, 0, 0);
            tableLayoutPanel2.Location = new Point(8, 45);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(400, 51);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // btnDeleteVehicle
            // 
            btnDeleteVehicle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDeleteVehicle.BackColor = Color.LightGray;
            btnDeleteVehicle.Location = new Point(269, 3);
            btnDeleteVehicle.Name = "btnDeleteVehicle";
            btnDeleteVehicle.Size = new Size(128, 45);
            btnDeleteVehicle.TabIndex = 2;
            btnDeleteVehicle.Text = "Xóa";
            btnDeleteVehicle.UseVisualStyleBackColor = false;
            btnDeleteVehicle.Click += btnDeleteVehicle_Click;
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
            btnEditVehicle.Click += btnEditVehicle_Click;
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
            dgvVehicles.CellDoubleClick += dgvVehicles_CellDoubleClick;
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
            // tpHDV
            // 
            tpHDV.BackColor = Color.Linen;
            tpHDV.Controls.Add(label8);
            tpHDV.Controls.Add(txtSearchHdv);
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(856, 111);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 5;
            label8.Text = "Tìm kiếm";
            // 
            // txtSearchHdv
            // 
            txtSearchHdv.Location = new Point(936, 108);
            txtSearchHdv.Name = "txtSearchHdv";
            txtSearchHdv.Size = new Size(315, 27);
            txtSearchHdv.TabIndex = 4;
            txtSearchHdv.TextChanged += txtSearchHdv_TextChanged;
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
            tableLayoutPanel1.Controls.Add(btnDeleteHdv, 2, 0);
            tableLayoutPanel1.Controls.Add(btnEditHdv, 1, 0);
            tableLayoutPanel1.Controls.Add(btnAddHdv, 0, 0);
            tableLayoutPanel1.Location = new Point(8, 45);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(400, 51);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnDeleteHdv
            // 
            btnDeleteHdv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDeleteHdv.BackColor = Color.LightGray;
            btnDeleteHdv.Location = new Point(267, 3);
            btnDeleteHdv.Name = "btnDeleteHdv";
            btnDeleteHdv.Size = new Size(130, 45);
            btnDeleteHdv.TabIndex = 2;
            btnDeleteHdv.Text = "Xóa";
            btnDeleteHdv.UseVisualStyleBackColor = false;
            btnDeleteHdv.Click += btnDeleteHdv_Click;
            // 
            // btnEditHdv
            // 
            btnEditHdv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEditHdv.BackColor = Color.LightGray;
            btnEditHdv.Location = new Point(135, 3);
            btnEditHdv.Name = "btnEditHdv";
            btnEditHdv.Size = new Size(126, 45);
            btnEditHdv.TabIndex = 1;
            btnEditHdv.Text = "Sửa";
            btnEditHdv.UseVisualStyleBackColor = false;
            btnEditHdv.Click += btnEditHdv_Click;
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
            dgvHDV.CellDoubleClick += dgvHDV_CellDoubleClick;
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
            // tpHome
            // 
            tpHome.BackColor = Color.Linen;
            tpHome.Controls.Add(btnAddAdmin);
            tpHome.Controls.Add(btnLogOut);
            tpHome.Controls.Add(btnChangePassword);
            tpHome.Location = new Point(4, 29);
            tpHome.Name = "tpHome";
            tpHome.Padding = new Padding(3);
            tpHome.Size = new Size(1257, 650);
            tpHome.TabIndex = 0;
            tpHome.Text = "Trang chủ";
            // 
            // btnAddAdmin
            // 
            btnAddAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAddAdmin.BackColor = Color.LightGray;
            btnAddAdmin.Location = new Point(359, 307);
            btnAddAdmin.Name = "btnAddAdmin";
            btnAddAdmin.Size = new Size(454, 63);
            btnAddAdmin.TabIndex = 2;
            btnAddAdmin.Text = "Thêm quản trị viên";
            btnAddAdmin.UseVisualStyleBackColor = false;
            btnAddAdmin.Click += btnAddAdmin_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogOut.BackColor = Color.DarkGray;
            btnLogOut.Location = new Point(359, 401);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(454, 63);
            btnLogOut.TabIndex = 1;
            btnLogOut.Text = "Đăng xuất";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnChangePassword.BackColor = Color.DeepSkyBlue;
            btnChangePassword.Location = new Point(359, 215);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(454, 63);
            btnChangePassword.TabIndex = 0;
            btnChangePassword.Text = "Đổi mật khảu";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tpHome);
            tabControl1.Controls.Add(tpHDV);
            tabControl1.Controls.Add(tpVehicle);
            tabControl1.Controls.Add(tpTours);
            tabControl1.Controls.Add(tpCustomer);
            tabControl1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1265, 683);
            tabControl1.TabIndex = 0;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(tabControl1);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Travel Company Managerment";
            Load += Home_Load;
            tpCustomer.ResumeLayout(false);
            tpCustomer.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            tpTours.ResumeLayout(false);
            tpTours.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTours).EndInit();
            tpVehicle.ResumeLayout(false);
            tpVehicle.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).EndInit();
            tpHDV.ResumeLayout(false);
            tpHDV.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHDV).EndInit();
            tpHome.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tpCustomer;
        private DataGridView dgvCustomers;
        private TabPage tpTours;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnDeleteTour;
        private Button btnEditTour;
        private Button btnAddTour;
        private DataGridView dgvTours;
        private DataGridViewTextBoxColumn tour_ID;
        private DataGridViewTextBoxColumn tour_StartDate;
        private DataGridViewTextBoxColumn tour_Duration;
        private DataGridViewTextBoxColumn tour_NumCus;
        private DataGridViewTextBoxColumn tour_Cus;
        private DataGridViewTextBoxColumn tour_hdv;
        private DataGridViewTextBoxColumn tour_Vehicle;
        private DataGridViewTextBoxColumn tour_Revenue;
        private DataGridViewTextBoxColumn tour_Status;
        private TabPage tpVehicle;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnDeleteVehicle;
        private Button btnEditVehicle;
        private Button btnAddVehicle;
        private DataGridView dgvVehicles;
        private DataGridViewTextBoxColumn vehicle_id;
        private DataGridViewTextBoxColumn vehicleDes;
        private DataGridViewTextBoxColumn vehicle_lp;
        private DataGridViewTextBoxColumn vehicle_cap;
        private TabPage tpHDV;
        private Label lTB_Hdv;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnDeleteHdv;
        private Button btnEditHdv;
        private Button btnAddHdv;
        private DataGridView dgvHDV;
        private DataGridViewTextBoxColumn hdv_id;
        private DataGridViewTextBoxColumn hdv_name;
        private DataGridViewTextBoxColumn hdv_Yob;
        private DataGridViewTextBoxColumn hdv_phone;
        private DataGridViewTextBoxColumn hdv_address;
        private DataGridViewTextBoxColumn hdv_works;
        private DataGridViewTextBoxColumn hdv_salary;
        private TabPage tpHome;
        private Button btnLogOut;
        private Button btnChangePassword;
        private TabControl tabControl1;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnDeleteCustomer;
        private Button btnEditCustomer;
        private Button btnAddCustomer;
        private DataGridViewTextBoxColumn customer_id;
        private DataGridViewTextBoxColumn customer_name;
        private DataGridViewTextBoxColumn customer_Yob;
        private DataGridViewTextBoxColumn customer_phone;
        private DataGridViewTextBoxColumn customer_address;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label7;
        private TextBox txtSearchHdv;
        private Label label8;
        private Label label9;
        private TextBox txtSearchVehicle;
        private Label label10;
        private TextBox txtSearchTour;
        private Label label11;
        private TextBox txtSearchCustomer;
        private Button btnAddAdmin;
    }
}