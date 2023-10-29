namespace ChuongTrinhQuanLiSinhVien
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridTenLopHocPhan = new System.Windows.Forms.DataGridView();
            this.tenLopHocPhanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopHocPhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlisinhvienDataSet = new ChuongTrinhQuanLiSinhVien.quanlisinhvienDataSet();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridSinhVien = new System.Windows.Forms.DataGridView();
            this.maSinhVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoDemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queQuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlisinhvienDataSet1 = new ChuongTrinhQuanLiSinhVien.quanlisinhvienDataSet1();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblMinMax = new System.Windows.Forms.Label();
            this.lblGiaoVienPhuTrach = new System.Windows.Forms.Label();
            this.lblMaLopHocPhan = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lopHocPhanTableAdapter = new ChuongTrinhQuanLiSinhVien.quanlisinhvienDataSetTableAdapters.LopHocPhanTableAdapter();
            this.sinhVienTableAdapter = new ChuongTrinhQuanLiSinhVien.quanlisinhvienDataSet1TableAdapters.SinhVienTableAdapter();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTenLopHocPhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocPhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlisinhvienDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlisinhvienDataSet1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbMonHoc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 73);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(574, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(128, 23);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(213, 24);
            this.cmbMonHoc.TabIndex = 1;
            this.cmbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cmbMonHoc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn môn học :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridTenLopHocPhan);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 382);
            this.panel2.TabIndex = 1;
            // 
            // gridTenLopHocPhan
            // 
            this.gridTenLopHocPhan.AutoGenerateColumns = false;
            this.gridTenLopHocPhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTenLopHocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTenLopHocPhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenLopHocPhanDataGridViewTextBoxColumn});
            this.gridTenLopHocPhan.DataSource = this.lopHocPhanBindingSource;
            this.gridTenLopHocPhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTenLopHocPhan.Location = new System.Drawing.Point(0, 27);
            this.gridTenLopHocPhan.Name = "gridTenLopHocPhan";
            this.gridTenLopHocPhan.RowHeadersWidth = 51;
            this.gridTenLopHocPhan.RowTemplate.Height = 24;
            this.gridTenLopHocPhan.Size = new System.Drawing.Size(387, 355);
            this.gridTenLopHocPhan.TabIndex = 1;
            this.gridTenLopHocPhan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.gridTenLopHocPhan.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridTenLopHocPhan_CellMouseClick);
            // 
            // tenLopHocPhanDataGridViewTextBoxColumn
            // 
            this.tenLopHocPhanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenLopHocPhanDataGridViewTextBoxColumn.DataPropertyName = "TenLopHocPhan";
            this.tenLopHocPhanDataGridViewTextBoxColumn.HeaderText = "Tên Lớp Học Phần";
            this.tenLopHocPhanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenLopHocPhanDataGridViewTextBoxColumn.Name = "tenLopHocPhanDataGridViewTextBoxColumn";
            // 
            // lopHocPhanBindingSource
            // 
            this.lopHocPhanBindingSource.DataMember = "LopHocPhan";
            this.lopHocPhanBindingSource.DataSource = this.quanlisinhvienDataSet;
            // 
            // quanlisinhvienDataSet
            // 
            this.quanlisinhvienDataSet.DataSetName = "quanlisinhvienDataSet";
            this.quanlisinhvienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton3,
            this.toolStripButton2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(387, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridSinhVien);
            this.panel3.Controls.Add(this.toolStrip2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(387, 203);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(659, 252);
            this.panel3.TabIndex = 2;
            // 
            // gridSinhVien
            // 
            this.gridSinhVien.AutoGenerateColumns = false;
            this.gridSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSinhVienDataGridViewTextBoxColumn,
            this.hoDemDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.queQuanDataGridViewTextBoxColumn});
            this.gridSinhVien.DataSource = this.sinhVienBindingSource;
            this.gridSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSinhVien.Location = new System.Drawing.Point(0, 27);
            this.gridSinhVien.Name = "gridSinhVien";
            this.gridSinhVien.RowHeadersWidth = 51;
            this.gridSinhVien.RowTemplate.Height = 24;
            this.gridSinhVien.Size = new System.Drawing.Size(659, 225);
            this.gridSinhVien.TabIndex = 1;
            this.gridSinhVien.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridSinhVien_CellMouseClick);
            // 
            // maSinhVienDataGridViewTextBoxColumn
            // 
            this.maSinhVienDataGridViewTextBoxColumn.DataPropertyName = "MaSinhVien";
            this.maSinhVienDataGridViewTextBoxColumn.HeaderText = "Mã Sinh Viên";
            this.maSinhVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSinhVienDataGridViewTextBoxColumn.Name = "maSinhVienDataGridViewTextBoxColumn";
            // 
            // hoDemDataGridViewTextBoxColumn
            // 
            this.hoDemDataGridViewTextBoxColumn.DataPropertyName = "HoDem";
            this.hoDemDataGridViewTextBoxColumn.HeaderText = "Họ Đệm";
            this.hoDemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoDemDataGridViewTextBoxColumn.Name = "hoDemDataGridViewTextBoxColumn";
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.tenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày Sinh";
            this.ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            // 
            // queQuanDataGridViewTextBoxColumn
            // 
            this.queQuanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.queQuanDataGridViewTextBoxColumn.DataPropertyName = "QueQuan";
            this.queQuanDataGridViewTextBoxColumn.HeaderText = "Quê Quán";
            this.queQuanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.queQuanDataGridViewTextBoxColumn.Name = "queQuanDataGridViewTextBoxColumn";
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.quanlisinhvienDataSet1;
            // 
            // quanlisinhvienDataSet1
            // 
            this.quanlisinhvienDataSet1.DataSetName = "quanlisinhvienDataSet1";
            this.quanlisinhvienDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripButton6,
            this.toolStripButton5,
            this.toolStripButton4});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(659, 27);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblSoLuong);
            this.panel4.Controls.Add(this.lblMinMax);
            this.panel4.Controls.Add(this.lblGiaoVienPhuTrach);
            this.panel4.Controls.Add(this.lblMaLopHocPhan);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(387, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(659, 130);
            this.panel4.TabIndex = 3;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(219, 88);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(75, 16);
            this.lblSoLuong.TabIndex = 11;
            this.lblSoLuong.Text = "lblSoLuong";
            // 
            // lblMinMax
            // 
            this.lblMinMax.AutoSize = true;
            this.lblMinMax.Location = new System.Drawing.Point(219, 56);
            this.lblMinMax.Name = "lblMinMax";
            this.lblMinMax.Size = new System.Drawing.Size(67, 16);
            this.lblMinMax.TabIndex = 10;
            this.lblMinMax.Text = "lblMinMax";
            // 
            // lblGiaoVienPhuTrach
            // 
            this.lblGiaoVienPhuTrach.AutoSize = true;
            this.lblGiaoVienPhuTrach.Location = new System.Drawing.Point(446, 25);
            this.lblGiaoVienPhuTrach.Name = "lblGiaoVienPhuTrach";
            this.lblGiaoVienPhuTrach.Size = new System.Drawing.Size(135, 16);
            this.lblGiaoVienPhuTrach.TabIndex = 9;
            this.lblGiaoVienPhuTrach.Text = "lblGiaoVienPhuTrach";
            // 
            // lblMaLopHocPhan
            // 
            this.lblMaLopHocPhan.AutoSize = true;
            this.lblMaLopHocPhan.Location = new System.Drawing.Point(144, 25);
            this.lblMaLopHocPhan.Name = "lblMaLopHocPhan";
            this.lblMaLopHocPhan.Size = new System.Drawing.Size(119, 16);
            this.lblMaLopHocPhan.TabIndex = 8;
            this.lblMaLopHocPhan.Text = "lblMaLopHocPhan";
            this.lblMaLopHocPhan.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Giáo viên phụ trách :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số lượng sinh viên đăng ký :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Định mức sinh viên (min/max) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã lớp học phần :";
            // 
            // lopHocPhanTableAdapter
            // 
            this.lopHocPhanTableAdapter.ClearBeforeFill = true;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Image = global::ChuongTrinhQuanLiSinhVien.Properties.Resources._309041_users_group_people_icon;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(164, 24);
            this.toolStripLabel2.Text = "Danh Sách Sinh Viên";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(59, 24);
            this.toolStripButton6.Text = "Xóa";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(141, 24);
            this.toolStripButton5.Text = "Đăng ký vào lớp";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(58, 24);
            this.toolStripButton4.Text = "Sửa";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = global::ChuongTrinhQuanLiSinhVien.Properties.Resources._352268_class_icon;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(119, 24);
            this.toolStripLabel1.Text = "Lớp học phần";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(59, 24);
            this.toolStripButton3.Text = "Xóa";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(70, 24);
            this.toolStripButton2.Text = "Thêm";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(58, 24);
            this.toolStripButton1.Text = "Sửa";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 455);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHƯƠNG TRÌNH QUẢN LÝ SINH VIÊN - MAI CHIẾM ĐỨC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTenLopHocPhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocPhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlisinhvienDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlisinhvienDataSet1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridTenLopHocPhan;
        private System.Windows.Forms.DataGridView gridSinhVien;
        private quanlisinhvienDataSet quanlisinhvienDataSet;
        private System.Windows.Forms.BindingSource lopHocPhanBindingSource;
        private quanlisinhvienDataSetTableAdapters.LopHocPhanTableAdapter lopHocPhanTableAdapter;
        private quanlisinhvienDataSet1 quanlisinhvienDataSet1;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private quanlisinhvienDataSet1TableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSinhVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoDemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn queQuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLopHocPhanDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblMaLopHocPhan;
        private System.Windows.Forms.Label lblGiaoVienPhuTrach;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblMinMax;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

