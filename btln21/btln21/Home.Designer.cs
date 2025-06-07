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
            tableLayoutPanel18 = new TableLayoutPanel();
            tableLayoutPanel19 = new TableLayoutPanel();
            tableLayoutPanel20 = new TableLayoutPanel();
            label11 = new Label();
            txtSearchCustomer = new TextBox();
            label4 = new Label();
            tableLayoutPanel21 = new TableLayoutPanel();
            tableLayoutPanel22 = new TableLayoutPanel();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            dgvCustomers = new DataGridView();
            customer_id = new DataGridViewTextBoxColumn();
            customer_name = new DataGridViewTextBoxColumn();
            customer_Yob = new DataGridViewTextBoxColumn();
            customer_phone = new DataGridViewTextBoxColumn();
            customer_address = new DataGridViewTextBoxColumn();
            label7 = new Label();
            tpTours = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel16 = new TableLayoutPanel();
            label10 = new Label();
            txtSearchTour = new TextBox();
            label3 = new Label();
            tableLayoutPanel17 = new TableLayoutPanel();
            tableLayoutPanel14 = new TableLayoutPanel();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label6 = new Label();
            dgvTours = new DataGridView();
            tpVehicle = new TabPage();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            label9 = new Label();
            txtSearchVehicle = new TextBox();
            label2 = new Label();
            dgvVehicles = new DataGridView();
            vehicle_id = new DataGridViewTextBoxColumn();
            vehicleDes = new DataGridViewTextBoxColumn();
            vehicle_lp = new DataGridViewTextBoxColumn();
            vehicle_cap = new DataGridViewTextBoxColumn();
            tableLayoutPanel8 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnDeleteVehicle = new Button();
            btnEditVehicle = new Button();
            btnAddVehicle = new Button();
            label5 = new Label();
            tpHDV = new TabPage();
            tableLayoutPanel9 = new TableLayoutPanel();
            tableLayoutPanel10 = new TableLayoutPanel();
            tableLayoutPanel11 = new TableLayoutPanel();
            label8 = new Label();
            txtSearchHdv = new TextBox();
            lTB_Hdv = new Label();
            dgvHDV = new DataGridView();
            hdv_id = new DataGridViewTextBoxColumn();
            hdv_name = new DataGridViewTextBoxColumn();
            hdv_Yob = new DataGridViewTextBoxColumn();
            hdv_phone = new DataGridViewTextBoxColumn();
            hdv_address = new DataGridViewTextBoxColumn();
            hdv_works = new DataGridViewTextBoxColumn();
            hdv_salary = new DataGridViewTextBoxColumn();
            tableLayoutPanel12 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnDeleteHdv = new Button();
            btnEditHdv = new Button();
            btnAddHdv = new Button();
            label1 = new Label();
            tpHome = new TabPage();
            tableLayoutPanel15 = new TableLayoutPanel();
            button7 = new Button();
            button8 = new Button();
            tableLayoutPanel13 = new TableLayoutPanel();
            label12 = new Label();
            txtAdminUsername = new Label();
            button1 = new Button();
            btnAddAdmin = new Button();
            btnLogOut = new Button();
            btnChangePassword = new Button();
            tabControl1 = new TabControl();
            tour_ID = new DataGridViewTextBoxColumn();
            tour_StartDate = new DataGridViewTextBoxColumn();
            tour_Duration = new DataGridViewTextBoxColumn();
            tour_NumCus = new DataGridViewTextBoxColumn();
            tour_Cus = new DataGridViewTextBoxColumn();
            tour_hdv = new DataGridViewTextBoxColumn();
            tour_Vehicle = new DataGridViewTextBoxColumn();
            tour_Revenue = new DataGridViewTextBoxColumn();
            tour_Status = new DataGridViewTextBoxColumn();
            tpCustomer.SuspendLayout();
            tableLayoutPanel18.SuspendLayout();
            tableLayoutPanel19.SuspendLayout();
            tableLayoutPanel20.SuspendLayout();
            tableLayoutPanel21.SuspendLayout();
            tableLayoutPanel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            tpTours.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel16.SuspendLayout();
            tableLayoutPanel17.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTours).BeginInit();
            tpVehicle.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).BeginInit();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tpHDV.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHDV).BeginInit();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tpHome.SuspendLayout();
            tableLayoutPanel15.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tpCustomer
            // 
            tpCustomer.BackColor = Color.Linen;
            tpCustomer.Controls.Add(tableLayoutPanel18);
            tpCustomer.Location = new Point(4, 29);
            tpCustomer.Name = "tpCustomer";
            tpCustomer.Padding = new Padding(3);
            tpCustomer.Size = new Size(1075, 461);
            tpCustomer.TabIndex = 4;
            tpCustomer.Text = "Khách hàng";
            // 
            // tableLayoutPanel18
            // 
            tableLayoutPanel18.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel18.ColumnCount = 1;
            tableLayoutPanel18.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel18.Controls.Add(tableLayoutPanel19, 0, 2);
            tableLayoutPanel18.Controls.Add(tableLayoutPanel21, 0, 1);
            tableLayoutPanel18.Controls.Add(dgvCustomers, 0, 3);
            tableLayoutPanel18.Controls.Add(label7, 0, 0);
            tableLayoutPanel18.Location = new Point(0, 3);
            tableLayoutPanel18.Name = "tableLayoutPanel18";
            tableLayoutPanel18.RowCount = 4;
            tableLayoutPanel18.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel18.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel18.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel18.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel18.Size = new Size(1075, 455);
            tableLayoutPanel18.TabIndex = 13;
            // 
            // tableLayoutPanel19
            // 
            tableLayoutPanel19.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel19.ColumnCount = 3;
            tableLayoutPanel19.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel19.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel19.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel19.Controls.Add(tableLayoutPanel20, 2, 0);
            tableLayoutPanel19.Controls.Add(label4, 0, 0);
            tableLayoutPanel19.Location = new Point(3, 98);
            tableLayoutPanel19.Name = "tableLayoutPanel19";
            tableLayoutPanel19.RowCount = 1;
            tableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel19.Size = new Size(1069, 34);
            tableLayoutPanel19.TabIndex = 0;
            // 
            // tableLayoutPanel20
            // 
            tableLayoutPanel20.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel20.ColumnCount = 2;
            tableLayoutPanel20.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel20.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel20.Controls.Add(label11, 0, 0);
            tableLayoutPanel20.Controls.Add(txtSearchCustomer, 1, 0);
            tableLayoutPanel20.Location = new Point(715, 3);
            tableLayoutPanel20.Name = "tableLayoutPanel20";
            tableLayoutPanel20.RowCount = 1;
            tableLayoutPanel20.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel20.Size = new Size(351, 28);
            tableLayoutPanel20.TabIndex = 0;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(99, 28);
            label11.TabIndex = 11;
            label11.Text = "Tìm kiếm";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSearchCustomer
            // 
            txtSearchCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchCustomer.Location = new Point(108, 3);
            txtSearchCustomer.Name = "txtSearchCustomer";
            txtSearchCustomer.Size = new Size(240, 27);
            txtSearchCustomer.TabIndex = 10;
            txtSearchCustomer.TextChanged += txtSearchCustomer_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(350, 34);
            label4.TabIndex = 4;
            label4.Text = "Danh sách khách hàng";
            // 
            // tableLayoutPanel21
            // 
            tableLayoutPanel21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel21.ColumnCount = 2;
            tableLayoutPanel21.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.4444427F));
            tableLayoutPanel21.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.5555573F));
            tableLayoutPanel21.Controls.Add(tableLayoutPanel22, 0, 0);
            tableLayoutPanel21.Location = new Point(3, 38);
            tableLayoutPanel21.Name = "tableLayoutPanel21";
            tableLayoutPanel21.RowCount = 1;
            tableLayoutPanel21.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel21.Size = new Size(1069, 54);
            tableLayoutPanel21.TabIndex = 1;
            // 
            // tableLayoutPanel22
            // 
            tableLayoutPanel22.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel22.ColumnCount = 3;
            tableLayoutPanel22.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel22.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel22.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel22.Controls.Add(button9, 2, 0);
            tableLayoutPanel22.Controls.Add(button10, 1, 0);
            tableLayoutPanel22.Controls.Add(button11, 0, 0);
            tableLayoutPanel22.Location = new Point(3, 3);
            tableLayoutPanel22.Name = "tableLayoutPanel22";
            tableLayoutPanel22.RowCount = 1;
            tableLayoutPanel22.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel22.Size = new Size(469, 48);
            tableLayoutPanel22.TabIndex = 11;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button9.BackColor = Color.LightGray;
            button9.Location = new Point(315, 3);
            button9.Name = "button9";
            button9.Size = new Size(151, 42);
            button9.TabIndex = 2;
            button9.Text = "Xóa";
            button9.UseVisualStyleBackColor = false;
            button9.Click += btnDeleteCustomer_Click;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button10.BackColor = Color.LightGray;
            button10.Location = new Point(159, 3);
            button10.Name = "button10";
            button10.Size = new Size(150, 42);
            button10.TabIndex = 1;
            button10.Text = "Sửa";
            button10.UseVisualStyleBackColor = false;
            button10.Click += btnEditCustomer_Click;
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button11.BackColor = Color.DeepSkyBlue;
            button11.Location = new Point(3, 3);
            button11.Name = "button11";
            button11.Size = new Size(150, 42);
            button11.TabIndex = 0;
            button11.Text = "Thêm";
            button11.UseVisualStyleBackColor = false;
            button11.Click += btnAddCustomer_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { customer_id, customer_name, customer_Yob, customer_phone, customer_address });
            dgvCustomers.Location = new Point(3, 138);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.Size = new Size(1069, 314);
            dgvCustomers.TabIndex = 0;
            dgvCustomers.CellDoubleClick += dgvCustomers_CellDoubleClick;
            // 
            // customer_id
            // 
            customer_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customer_id.FillWeight = 80F;
            customer_id.HeaderText = "ID ";
            customer_id.Name = "customer_id";
            customer_id.ReadOnly = true;
            // 
            // customer_name
            // 
            customer_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customer_name.FillWeight = 120F;
            customer_name.HeaderText = "Tên khách hàng";
            customer_name.Name = "customer_name";
            customer_name.ReadOnly = true;
            // 
            // customer_Yob
            // 
            customer_Yob.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customer_Yob.FillWeight = 80F;
            customer_Yob.HeaderText = "Năm sinh";
            customer_Yob.Name = "customer_Yob";
            customer_Yob.ReadOnly = true;
            // 
            // customer_phone
            // 
            customer_phone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customer_phone.HeaderText = "Số điện thoại";
            customer_phone.Name = "customer_phone";
            customer_phone.ReadOnly = true;
            // 
            // customer_address
            // 
            customer_address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customer_address.HeaderText = "Địa chỉ";
            customer_address.Name = "customer_address";
            customer_address.ReadOnly = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(1069, 35);
            label7.TabIndex = 5;
            label7.Text = "Quản lý khách hàng";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tpTours
            // 
            tpTours.BackColor = Color.Linen;
            tpTours.Controls.Add(tableLayoutPanel3);
            tpTours.Location = new Point(4, 29);
            tpTours.Name = "tpTours";
            tpTours.Padding = new Padding(3);
            tpTours.Size = new Size(1075, 461);
            tpTours.TabIndex = 3;
            tpTours.Text = "Tours";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel17, 0, 1);
            tableLayoutPanel3.Controls.Add(label6, 0, 0);
            tableLayoutPanel3.Controls.Add(dgvTours, 0, 3);
            tableLayoutPanel3.Location = new Point(0, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel3.Size = new Size(1075, 455);
            tableLayoutPanel3.TabIndex = 11;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel16, 2, 0);
            tableLayoutPanel4.Controls.Add(label3, 0, 0);
            tableLayoutPanel4.Location = new Point(3, 98);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1069, 34);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel16
            // 
            tableLayoutPanel16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel16.ColumnCount = 2;
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel16.Controls.Add(label10, 0, 0);
            tableLayoutPanel16.Controls.Add(txtSearchTour, 1, 0);
            tableLayoutPanel16.Location = new Point(715, 3);
            tableLayoutPanel16.Name = "tableLayoutPanel16";
            tableLayoutPanel16.RowCount = 1;
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel16.Size = new Size(351, 28);
            tableLayoutPanel16.TabIndex = 0;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(3, 0);
            label10.Name = "label10";
            label10.Size = new Size(99, 28);
            label10.TabIndex = 9;
            label10.Text = "Tìm kiếm";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSearchTour
            // 
            txtSearchTour.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchTour.Location = new Point(108, 3);
            txtSearchTour.Name = "txtSearchTour";
            txtSearchTour.Size = new Size(240, 27);
            txtSearchTour.TabIndex = 8;
            txtSearchTour.TextChanged += txtSearchTour_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(350, 34);
            label3.TabIndex = 4;
            label3.Text = "Danh sách Tour tổ chức";
            // 
            // tableLayoutPanel17
            // 
            tableLayoutPanel17.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel17.ColumnCount = 2;
            tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.4444427F));
            tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.5555573F));
            tableLayoutPanel17.Controls.Add(tableLayoutPanel14, 0, 0);
            tableLayoutPanel17.Location = new Point(3, 38);
            tableLayoutPanel17.Name = "tableLayoutPanel17";
            tableLayoutPanel17.RowCount = 1;
            tableLayoutPanel17.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel17.Size = new Size(1069, 54);
            tableLayoutPanel17.TabIndex = 1;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel14.ColumnCount = 3;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel14.Controls.Add(button4, 2, 0);
            tableLayoutPanel14.Controls.Add(button5, 1, 0);
            tableLayoutPanel14.Controls.Add(button6, 0, 0);
            tableLayoutPanel14.Location = new Point(3, 3);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 1;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.Size = new Size(469, 48);
            tableLayoutPanel14.TabIndex = 10;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.BackColor = Color.LightGray;
            button4.Location = new Point(315, 3);
            button4.Name = "button4";
            button4.Size = new Size(151, 42);
            button4.TabIndex = 2;
            button4.Text = "Xóa";
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnDeleteTour_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button5.BackColor = Color.LightGray;
            button5.Location = new Point(159, 3);
            button5.Name = "button5";
            button5.Size = new Size(150, 42);
            button5.TabIndex = 1;
            button5.Text = "Sửa";
            button5.UseVisualStyleBackColor = false;
            button5.Click += btnEditTour_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button6.BackColor = Color.DeepSkyBlue;
            button6.Location = new Point(3, 3);
            button6.Name = "button6";
            button6.Size = new Size(150, 42);
            button6.TabIndex = 0;
            button6.Text = "Thêm";
            button6.UseVisualStyleBackColor = false;
            button6.Click += btnAddTour_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(1069, 35);
            label6.TabIndex = 5;
            label6.Text = "Quản lý Tour";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click;
            // 
            // dgvTours
            // 
            dgvTours.AllowUserToAddRows = false;
            dgvTours.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTours.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTours.Columns.AddRange(new DataGridViewColumn[] { tour_ID, tour_StartDate, tour_Duration, tour_NumCus, tour_Cus, tour_hdv, tour_Vehicle, tour_Revenue, tour_Status });
            dgvTours.Location = new Point(3, 138);
            dgvTours.Name = "dgvTours";
            dgvTours.ReadOnly = true;
            dgvTours.Size = new Size(1069, 314);
            dgvTours.TabIndex = 0;
            dgvTours.CellDoubleClick += dgvTours_CellDoubleClick;
            // 
            // tpVehicle
            // 
            tpVehicle.BackColor = Color.Linen;
            tpVehicle.Controls.Add(tableLayoutPanel5);
            tpVehicle.Location = new Point(4, 29);
            tpVehicle.Name = "tpVehicle";
            tpVehicle.Padding = new Padding(3);
            tpVehicle.Size = new Size(1075, 461);
            tpVehicle.TabIndex = 2;
            tpVehicle.Text = "Phương tiện";
            tpVehicle.Click += tpVehicle_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel5.Controls.Add(dgvVehicles, 0, 3);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel8, 0, 1);
            tableLayoutPanel5.Controls.Add(label5, 0, 0);
            tableLayoutPanel5.Location = new Point(0, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 4;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel5.Size = new Size(1075, 455);
            tableLayoutPanel5.TabIndex = 8;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 2, 0);
            tableLayoutPanel6.Controls.Add(label2, 0, 0);
            tableLayoutPanel6.Location = new Point(3, 98);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(1069, 34);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel7.Controls.Add(label9, 0, 0);
            tableLayoutPanel7.Controls.Add(txtSearchVehicle, 1, 0);
            tableLayoutPanel7.Location = new Point(715, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(351, 28);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.ImageAlign = ContentAlignment.TopCenter;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(99, 28);
            label9.TabIndex = 7;
            label9.Text = "Tìm kiếm";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSearchVehicle
            // 
            txtSearchVehicle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchVehicle.Location = new Point(108, 3);
            txtSearchVehicle.Name = "txtSearchVehicle";
            txtSearchVehicle.Size = new Size(240, 27);
            txtSearchVehicle.TabIndex = 6;
            txtSearchVehicle.TextChanged += txtSearchVehicle_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(350, 34);
            label2.TabIndex = 3;
            label2.Text = "Danh sách phương tiện";
            // 
            // dgvVehicles
            // 
            dgvVehicles.AllowUserToAddRows = false;
            dgvVehicles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVehicles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicles.Columns.AddRange(new DataGridViewColumn[] { vehicle_id, vehicleDes, vehicle_lp, vehicle_cap });
            dgvVehicles.Location = new Point(3, 138);
            dgvVehicles.Name = "dgvVehicles";
            dgvVehicles.ReadOnly = true;
            dgvVehicles.Size = new Size(1069, 314);
            dgvVehicles.TabIndex = 1;
            dgvVehicles.CellDoubleClick += dgvVehicles_CellDoubleClick;
            // 
            // vehicle_id
            // 
            vehicle_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            vehicle_id.FillWeight = 56.16361F;
            vehicle_id.HeaderText = "ID";
            vehicle_id.Name = "vehicle_id";
            vehicle_id.ReadOnly = true;
            // 
            // vehicleDes
            // 
            vehicleDes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            vehicleDes.FillWeight = 160F;
            vehicleDes.HeaderText = "Mô tả";
            vehicleDes.Name = "vehicleDes";
            vehicleDes.ReadOnly = true;
            // 
            // vehicle_lp
            // 
            vehicle_lp.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            vehicle_lp.FillWeight = 71.066F;
            vehicle_lp.HeaderText = "Biển số";
            vehicle_lp.Name = "vehicle_lp";
            vehicle_lp.ReadOnly = true;
            // 
            // vehicle_cap
            // 
            vehicle_cap.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            vehicle_cap.HeaderText = "Lượng khách tối đa";
            vehicle_cap.Name = "vehicle_cap";
            vehicle_cap.ReadOnly = true;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.4444427F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.5555573F));
            tableLayoutPanel8.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel8.Location = new Point(3, 38);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(1069, 54);
            tableLayoutPanel8.TabIndex = 1;
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
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(469, 48);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // btnDeleteVehicle
            // 
            btnDeleteVehicle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDeleteVehicle.BackColor = Color.LightGray;
            btnDeleteVehicle.Location = new Point(315, 3);
            btnDeleteVehicle.Name = "btnDeleteVehicle";
            btnDeleteVehicle.Size = new Size(151, 42);
            btnDeleteVehicle.TabIndex = 2;
            btnDeleteVehicle.Text = "Xóa";
            btnDeleteVehicle.UseVisualStyleBackColor = false;
            btnDeleteVehicle.Click += btnDeleteVehicle_Click;
            // 
            // btnEditVehicle
            // 
            btnEditVehicle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEditVehicle.BackColor = Color.LightGray;
            btnEditVehicle.Location = new Point(159, 3);
            btnEditVehicle.Name = "btnEditVehicle";
            btnEditVehicle.Size = new Size(150, 42);
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
            btnAddVehicle.Size = new Size(150, 42);
            btnAddVehicle.TabIndex = 0;
            btnAddVehicle.Text = "Thêm";
            btnAddVehicle.UseVisualStyleBackColor = false;
            btnAddVehicle.Click += btnAddVehicle_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(1069, 35);
            label5.TabIndex = 4;
            label5.Text = "Quản lý phương tiện";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tpHDV
            // 
            tpHDV.BackColor = Color.Linen;
            tpHDV.Controls.Add(tableLayoutPanel9);
            tpHDV.Location = new Point(4, 29);
            tpHDV.Name = "tpHDV";
            tpHDV.Padding = new Padding(3);
            tpHDV.Size = new Size(1075, 461);
            tpHDV.TabIndex = 1;
            tpHDV.Text = "Hướng dẫn viên";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(tableLayoutPanel10, 0, 2);
            tableLayoutPanel9.Controls.Add(dgvHDV, 0, 3);
            tableLayoutPanel9.Controls.Add(tableLayoutPanel12, 0, 1);
            tableLayoutPanel9.Controls.Add(label1, 0, 0);
            tableLayoutPanel9.Location = new Point(0, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 4;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel9.Size = new Size(1075, 455);
            tableLayoutPanel9.TabIndex = 9;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel10.ColumnCount = 3;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel10.Controls.Add(tableLayoutPanel11, 2, 0);
            tableLayoutPanel10.Controls.Add(lTB_Hdv, 0, 0);
            tableLayoutPanel10.Location = new Point(3, 98);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Size = new Size(1069, 34);
            tableLayoutPanel10.TabIndex = 0;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel11.Controls.Add(label8, 0, 0);
            tableLayoutPanel11.Controls.Add(txtSearchHdv, 1, 0);
            tableLayoutPanel11.Location = new Point(715, 3);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.Size = new Size(351, 28);
            tableLayoutPanel11.TabIndex = 0;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(99, 28);
            label8.TabIndex = 5;
            label8.Text = "Tìm kiếm";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSearchHdv
            // 
            txtSearchHdv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchHdv.Location = new Point(108, 3);
            txtSearchHdv.Name = "txtSearchHdv";
            txtSearchHdv.Size = new Size(240, 27);
            txtSearchHdv.TabIndex = 4;
            txtSearchHdv.TextChanged += txtSearchHdv_TextChanged;
            // 
            // lTB_Hdv
            // 
            lTB_Hdv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lTB_Hdv.AutoSize = true;
            lTB_Hdv.Location = new Point(3, 0);
            lTB_Hdv.Name = "lTB_Hdv";
            lTB_Hdv.Size = new Size(350, 34);
            lTB_Hdv.TabIndex = 3;
            lTB_Hdv.Text = "Danh sách hướng dẫn viên";
            // 
            // dgvHDV
            // 
            dgvHDV.AllowUserToAddRows = false;
            dgvHDV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHDV.Columns.AddRange(new DataGridViewColumn[] { hdv_id, hdv_name, hdv_Yob, hdv_phone, hdv_address, hdv_works, hdv_salary });
            dgvHDV.Location = new Point(3, 138);
            dgvHDV.Name = "dgvHDV";
            dgvHDV.ReadOnly = true;
            dgvHDV.Size = new Size(1069, 314);
            dgvHDV.TabIndex = 0;
            dgvHDV.CellDoubleClick += dgvHDV_CellDoubleClick;
            // 
            // hdv_id
            // 
            hdv_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            hdv_id.FillWeight = 60F;
            hdv_id.HeaderText = "ID";
            hdv_id.Name = "hdv_id";
            hdv_id.ReadOnly = true;
            // 
            // hdv_name
            // 
            hdv_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            hdv_name.FillWeight = 149.2032F;
            hdv_name.HeaderText = "Họ và tên";
            hdv_name.Name = "hdv_name";
            hdv_name.ReadOnly = true;
            // 
            // hdv_Yob
            // 
            hdv_Yob.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            hdv_Yob.FillWeight = 71.066F;
            hdv_Yob.HeaderText = "Năm sinh";
            hdv_Yob.Name = "hdv_Yob";
            hdv_Yob.ReadOnly = true;
            // 
            // hdv_phone
            // 
            hdv_phone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            hdv_phone.HeaderText = "Số điện thoại";
            hdv_phone.Name = "hdv_phone";
            hdv_phone.ReadOnly = true;
            // 
            // hdv_address
            // 
            hdv_address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            hdv_address.FillWeight = 120F;
            hdv_address.HeaderText = "Địa chỉ";
            hdv_address.Name = "hdv_address";
            hdv_address.ReadOnly = true;
            // 
            // hdv_works
            // 
            hdv_works.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            hdv_works.FillWeight = 70F;
            hdv_works.HeaderText = "Thâm niên (Năm)";
            hdv_works.Name = "hdv_works";
            hdv_works.ReadOnly = true;
            // 
            // hdv_salary
            // 
            hdv_salary.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            hdv_salary.FillWeight = 105.89183F;
            hdv_salary.HeaderText = "Lương cơ bản";
            hdv_salary.Name = "hdv_salary";
            hdv_salary.ReadOnly = true;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel12.ColumnCount = 2;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.4444427F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.5555573F));
            tableLayoutPanel12.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel12.Location = new Point(3, 38);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Size = new Size(1069, 54);
            tableLayoutPanel12.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tableLayoutPanel1.Controls.Add(btnDeleteHdv, 2, 0);
            tableLayoutPanel1.Controls.Add(btnEditHdv, 1, 0);
            tableLayoutPanel1.Controls.Add(btnAddHdv, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(469, 48);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnDeleteHdv
            // 
            btnDeleteHdv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDeleteHdv.BackColor = Color.LightGray;
            btnDeleteHdv.Location = new Point(311, 3);
            btnDeleteHdv.Name = "btnDeleteHdv";
            btnDeleteHdv.Size = new Size(155, 42);
            btnDeleteHdv.TabIndex = 2;
            btnDeleteHdv.Text = "Xóa";
            btnDeleteHdv.UseVisualStyleBackColor = false;
            btnDeleteHdv.Click += btnDeleteHdv_Click;
            // 
            // btnEditHdv
            // 
            btnEditHdv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEditHdv.BackColor = Color.LightGray;
            btnEditHdv.Location = new Point(157, 3);
            btnEditHdv.Name = "btnEditHdv";
            btnEditHdv.Size = new Size(148, 42);
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
            btnAddHdv.Size = new Size(148, 42);
            btnAddHdv.TabIndex = 0;
            btnAddHdv.Text = "Thêm";
            btnAddHdv.UseVisualStyleBackColor = false;
            btnAddHdv.Click += btnAddHdv_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(1069, 35);
            label1.TabIndex = 2;
            label1.Text = "Quản lý hướng dẫn viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tpHome
            // 
            tpHome.BackColor = Color.Linen;
            tpHome.Controls.Add(tableLayoutPanel15);
            tpHome.Controls.Add(btnAddAdmin);
            tpHome.Controls.Add(btnLogOut);
            tpHome.Controls.Add(btnChangePassword);
            tpHome.Location = new Point(4, 29);
            tpHome.Name = "tpHome";
            tpHome.Padding = new Padding(3);
            tpHome.Size = new Size(1075, 461);
            tpHome.TabIndex = 0;
            tpHome.Text = "Trang chủ";
            // 
            // tableLayoutPanel15
            // 
            tableLayoutPanel15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel15.ColumnCount = 3;
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel15.Controls.Add(button7, 1, 1);
            tableLayoutPanel15.Controls.Add(button8, 1, 2);
            tableLayoutPanel15.Controls.Add(tableLayoutPanel13, 1, 0);
            tableLayoutPanel15.Controls.Add(button1, 1, 3);
            tableLayoutPanel15.Location = new Point(0, 0);
            tableLayoutPanel15.Name = "tableLayoutPanel15";
            tableLayoutPanel15.RowCount = 5;
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel15.Size = new Size(1075, 455);
            tableLayoutPanel15.TabIndex = 3;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button7.BackColor = Color.DeepSkyBlue;
            button7.Location = new Point(361, 110);
            button7.Name = "button7";
            button7.Size = new Size(352, 74);
            button7.TabIndex = 0;
            button7.Text = "Thêm quản trị viên";
            button7.UseVisualStyleBackColor = false;
            button7.Click += btnAddAdmin_Click;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button8.BackColor = Color.LightGray;
            button8.Location = new Point(361, 190);
            button8.Name = "button8";
            button8.Size = new Size(352, 74);
            button8.TabIndex = 1;
            button8.Text = "Đổi mật khẩu";
            button8.UseVisualStyleBackColor = false;
            button8.Click += btnChangePassword_Click;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel13.ColumnCount = 2;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Controls.Add(label12, 0, 1);
            tableLayoutPanel13.Controls.Add(txtAdminUsername, 1, 1);
            tableLayoutPanel13.Location = new Point(361, 3);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 2;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel13.Size = new Size(352, 101);
            tableLayoutPanel13.TabIndex = 2;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(3, 61);
            label12.Name = "label12";
            label12.Size = new Size(170, 40);
            label12.TabIndex = 0;
            label12.Text = "Xin chào ";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtAdminUsername
            // 
            txtAdminUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAdminUsername.AutoSize = true;
            txtAdminUsername.Location = new Point(179, 61);
            txtAdminUsername.Name = "txtAdminUsername";
            txtAdminUsername.Size = new Size(170, 40);
            txtAdminUsername.TabIndex = 1;
            txtAdminUsername.Text = "tên admin";
            txtAdminUsername.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.DarkGray;
            button1.Location = new Point(361, 270);
            button1.Name = "button1";
            button1.Size = new Size(352, 74);
            button1.TabIndex = 3;
            button1.Text = "Đăng xuất";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnLogOut_Click;
            // 
            // btnAddAdmin
            // 
            btnAddAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAddAdmin.BackColor = Color.LightGray;
            btnAddAdmin.Location = new Point(359, 307);
            btnAddAdmin.Name = "btnAddAdmin";
            btnAddAdmin.Size = new Size(371, 0);
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
            btnLogOut.Size = new Size(371, 0);
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
            btnChangePassword.Size = new Size(371, 0);
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
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1083, 494);
            tabControl1.TabIndex = 0;
            // 
            // tour_ID
            // 
            tour_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tour_ID.FillWeight = 60F;
            tour_ID.HeaderText = "ID Tours";
            tour_ID.Name = "tour_ID";
            tour_ID.ReadOnly = true;
            // 
            // tour_StartDate
            // 
            tour_StartDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tour_StartDate.HeaderText = "Ngày khởi hành";
            tour_StartDate.Name = "tour_StartDate";
            tour_StartDate.ReadOnly = true;
            // 
            // tour_Duration
            // 
            tour_Duration.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tour_Duration.FillWeight = 60F;
            tour_Duration.HeaderText = "Thời gian (Ngày)";
            tour_Duration.Name = "tour_Duration";
            tour_Duration.ReadOnly = true;
            // 
            // tour_NumCus
            // 
            tour_NumCus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tour_NumCus.FillWeight = 60F;
            tour_NumCus.HeaderText = "Số khách";
            tour_NumCus.Name = "tour_NumCus";
            tour_NumCus.ReadOnly = true;
            // 
            // tour_Cus
            // 
            tour_Cus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tour_Cus.HeaderText = "Khách đặt";
            tour_Cus.Name = "tour_Cus";
            tour_Cus.ReadOnly = true;
            // 
            // tour_hdv
            // 
            tour_hdv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tour_hdv.HeaderText = "Hướng dẫn viên";
            tour_hdv.Name = "tour_hdv";
            tour_hdv.ReadOnly = true;
            // 
            // tour_Vehicle
            // 
            tour_Vehicle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tour_Vehicle.HeaderText = "Phương tiện";
            tour_Vehicle.Name = "tour_Vehicle";
            tour_Vehicle.ReadOnly = true;
            // 
            // tour_Revenue
            // 
            tour_Revenue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tour_Revenue.HeaderText = "Doanh thu";
            tour_Revenue.Name = "tour_Revenue";
            tour_Revenue.ReadOnly = true;
            // 
            // tour_Status
            // 
            tour_Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tour_Status.FillWeight = 140F;
            tour_Status.HeaderText = "Tình trạng";
            tour_Status.Name = "tour_Status";
            tour_Status.ReadOnly = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 492);
            Controls.Add(tabControl1);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Travel Company Managerment";
            Load += Home_Load;
            tpCustomer.ResumeLayout(false);
            tableLayoutPanel18.ResumeLayout(false);
            tableLayoutPanel18.PerformLayout();
            tableLayoutPanel19.ResumeLayout(false);
            tableLayoutPanel19.PerformLayout();
            tableLayoutPanel20.ResumeLayout(false);
            tableLayoutPanel20.PerformLayout();
            tableLayoutPanel21.ResumeLayout(false);
            tableLayoutPanel22.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            tpTours.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel16.ResumeLayout(false);
            tableLayoutPanel16.PerformLayout();
            tableLayoutPanel17.ResumeLayout(false);
            tableLayoutPanel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTours).EndInit();
            tpVehicle.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).EndInit();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tpHDV.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHDV).EndInit();
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tpHome.ResumeLayout(false);
            tableLayoutPanel15.ResumeLayout(false);
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel13.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tpCustomer;
        private DataGridView dgvCustomers;
        private TabPage tpTours;
        private DataGridView dgvTours;
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
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel9;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel11;
        private TableLayoutPanel tableLayoutPanel12;
        private TableLayoutPanel tableLayoutPanel14;
        private Button button4;
        private Button button5;
        private Button button6;
        private TableLayoutPanel tableLayoutPanel15;
        private Button button7;
        private Button button8;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel16;
        private TableLayoutPanel tableLayoutPanel17;
        private TableLayoutPanel tableLayoutPanel18;
        private TableLayoutPanel tableLayoutPanel19;
        private TableLayoutPanel tableLayoutPanel20;
        private TableLayoutPanel tableLayoutPanel21;
        private TableLayoutPanel tableLayoutPanel22;
        private Button button9;
        private Button button10;
        private Button button11;
        private TableLayoutPanel tableLayoutPanel13;
        private Label label12;
        private Label txtAdminUsername;
        private Button button1;
        private DataGridViewTextBoxColumn tour_ID;
        private DataGridViewTextBoxColumn tour_StartDate;
        private DataGridViewTextBoxColumn tour_Duration;
        private DataGridViewTextBoxColumn tour_NumCus;
        private DataGridViewTextBoxColumn tour_Cus;
        private DataGridViewTextBoxColumn tour_hdv;
        private DataGridViewTextBoxColumn tour_Vehicle;
        private DataGridViewTextBoxColumn tour_Revenue;
        private DataGridViewTextBoxColumn tour_Status;
    }
}