namespace Bai09
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Label_MSSV = new System.Windows.Forms.Label();
            this.Label_HoTen = new System.Windows.Forms.Label();
            this.Label_ChuyenNganh = new System.Windows.Forms.Label();
            this.Label_GioiTinh = new System.Windows.Forms.Label();
            this.Label_CacMonHoc = new System.Windows.Forms.Label();
            this.TextBox_MSSV = new System.Windows.Forms.TextBox();
            this.TextBox_HoTen = new System.Windows.Forms.TextBox();
            this.CheckBox_Nam = new System.Windows.Forms.CheckBox();
            this.CheckBox_Nu = new System.Windows.Forms.CheckBox();
            this.ToRightButton = new System.Windows.Forms.Button();
            this.ToLeftButton = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.ComboBoxChuyenNganh = new System.Windows.Forms.ComboBox();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftBox = new System.Windows.Forms.ListBox();
            this.RightBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.RightBox);
            this.groupBox1.Controls.Add(this.LeftBox);
            this.groupBox1.Controls.Add(this.ComboBoxChuyenNganh);
            this.groupBox1.Controls.Add(this.ButtonDelete);
            this.groupBox1.Controls.Add(this.ButtonSave);
            this.groupBox1.Controls.Add(this.ToLeftButton);
            this.groupBox1.Controls.Add(this.ToRightButton);
            this.groupBox1.Controls.Add(this.CheckBox_Nu);
            this.groupBox1.Controls.Add(this.CheckBox_Nam);
            this.groupBox1.Controls.Add(this.TextBox_HoTen);
            this.groupBox1.Controls.Add(this.TextBox_MSSV);
            this.groupBox1.Controls.Add(this.Label_CacMonHoc);
            this.groupBox1.Controls.Add(this.Label_GioiTinh);
            this.groupBox1.Controls.Add(this.Label_ChuyenNganh);
            this.groupBox1.Controls.Add(this.Label_HoTen);
            this.groupBox1.Controls.Add(this.Label_MSSV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(57, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1180, 559);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // Label_MSSV
            // 
            this.Label_MSSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_MSSV.AutoSize = true;
            this.Label_MSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_MSSV.Location = new System.Drawing.Point(212, 68);
            this.Label_MSSV.Name = "Label_MSSV";
            this.Label_MSSV.Size = new System.Drawing.Size(130, 25);
            this.Label_MSSV.TabIndex = 0;
            this.Label_MSSV.Text = "Mã Sinh Viên";
            this.Label_MSSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_HoTen
            // 
            this.Label_HoTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_HoTen.AutoSize = true;
            this.Label_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_HoTen.Location = new System.Drawing.Point(215, 120);
            this.Label_HoTen.Name = "Label_HoTen";
            this.Label_HoTen.Size = new System.Drawing.Size(77, 25);
            this.Label_HoTen.TabIndex = 1;
            this.Label_HoTen.Text = "Họ Tên";
            this.Label_HoTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_ChuyenNganh
            // 
            this.Label_ChuyenNganh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_ChuyenNganh.AutoSize = true;
            this.Label_ChuyenNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_ChuyenNganh.Location = new System.Drawing.Point(212, 178);
            this.Label_ChuyenNganh.Name = "Label_ChuyenNganh";
            this.Label_ChuyenNganh.Size = new System.Drawing.Size(144, 25);
            this.Label_ChuyenNganh.TabIndex = 1;
            this.Label_ChuyenNganh.Text = "Chuyên Ngành";
            this.Label_ChuyenNganh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_GioiTinh
            // 
            this.Label_GioiTinh.AutoSize = true;
            this.Label_GioiTinh.Location = new System.Drawing.Point(215, 239);
            this.Label_GioiTinh.Name = "Label_GioiTinh";
            this.Label_GioiTinh.Size = new System.Drawing.Size(90, 25);
            this.Label_GioiTinh.TabIndex = 1;
            this.Label_GioiTinh.Text = "Giới Tính";
            // 
            // Label_CacMonHoc
            // 
            this.Label_CacMonHoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_CacMonHoc.AutoSize = true;
            this.Label_CacMonHoc.Location = new System.Drawing.Point(212, 297);
            this.Label_CacMonHoc.Name = "Label_CacMonHoc";
            this.Label_CacMonHoc.Size = new System.Drawing.Size(276, 25);
            this.Label_CacMonHoc.TabIndex = 1;
            this.Label_CacMonHoc.Text = "Chọn Các Môn Học Tham Gia";
            // 
            // TextBox_MSSV
            // 
            this.TextBox_MSSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_MSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBox_MSSV.Location = new System.Drawing.Point(408, 67);
            this.TextBox_MSSV.Name = "TextBox_MSSV";
            this.TextBox_MSSV.Size = new System.Drawing.Size(144, 30);
            this.TextBox_MSSV.TabIndex = 0;
            this.TextBox_MSSV.TextChanged += new System.EventHandler(this.TextBox_MSSV_TextChanged);
            // 
            // TextBox_HoTen
            // 
            this.TextBox_HoTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_HoTen.Location = new System.Drawing.Point(408, 119);
            this.TextBox_HoTen.Name = "TextBox_HoTen";
            this.TextBox_HoTen.Size = new System.Drawing.Size(278, 30);
            this.TextBox_HoTen.TabIndex = 1;
            this.TextBox_HoTen.TextChanged += new System.EventHandler(this.TextBox_HoTen_TextChanged);
            // 
            // CheckBox_Nam
            // 
            this.CheckBox_Nam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CheckBox_Nam.AutoSize = true;
            this.CheckBox_Nam.Location = new System.Drawing.Point(408, 239);
            this.CheckBox_Nam.Name = "CheckBox_Nam";
            this.CheckBox_Nam.Size = new System.Drawing.Size(79, 29);
            this.CheckBox_Nam.TabIndex = 3;
            this.CheckBox_Nam.Text = "Nam";
            this.CheckBox_Nam.UseVisualStyleBackColor = true;
            this.CheckBox_Nam.CheckedChanged += new System.EventHandler(this.CheckBox_Nam_CheckedChanged);
            // 
            // CheckBox_Nu
            // 
            this.CheckBox_Nu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CheckBox_Nu.AutoSize = true;
            this.CheckBox_Nu.Location = new System.Drawing.Point(513, 238);
            this.CheckBox_Nu.Name = "CheckBox_Nu";
            this.CheckBox_Nu.Size = new System.Drawing.Size(63, 29);
            this.CheckBox_Nu.TabIndex = 4;
            this.CheckBox_Nu.Text = "Nữ";
            this.CheckBox_Nu.UseVisualStyleBackColor = true;
            this.CheckBox_Nu.CheckedChanged += new System.EventHandler(this.CheckBox_Nu_CheckedChanged);
            // 
            // ToRightButton
            // 
            this.ToRightButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ToRightButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ToRightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ToRightButton.Location = new System.Drawing.Point(622, 354);
            this.ToRightButton.Name = "ToRightButton";
            this.ToRightButton.Size = new System.Drawing.Size(84, 61);
            this.ToRightButton.TabIndex = 7;
            this.ToRightButton.Text = ">";
            this.ToRightButton.UseVisualStyleBackColor = false;
            this.ToRightButton.Click += new System.EventHandler(this.ToRightButton_Click);
            // 
            // ToLeftButton
            // 
            this.ToLeftButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ToLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ToLeftButton.Location = new System.Drawing.Point(622, 421);
            this.ToLeftButton.Name = "ToLeftButton";
            this.ToLeftButton.Size = new System.Drawing.Size(84, 54);
            this.ToLeftButton.TabIndex = 8;
            this.ToLeftButton.Text = "<";
            this.ToLeftButton.UseVisualStyleBackColor = false;
            this.ToLeftButton.Click += new System.EventHandler(this.ToLeftButton_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonSave.AutoSize = true;
            this.ButtonSave.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ButtonSave.Location = new System.Drawing.Point(499, 505);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(150, 35);
            this.ButtonSave.TabIndex = 9;
            this.ButtonSave.Text = "Lưu Thông Tin";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonDelete.AutoSize = true;
            this.ButtonDelete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ButtonDelete.Location = new System.Drawing.Point(670, 505);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(111, 35);
            this.ButtonDelete.TabIndex = 10;
            this.ButtonDelete.Text = "Xóa Chọn";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // DataTable
            // 
            this.DataTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.HoTen,
            this.ChuyenNganh,
            this.GioiTinh,
            this.SoMon});
            this.DataTable.Location = new System.Drawing.Point(57, 613);
            this.DataTable.Name = "DataTable";
            this.DataTable.RowHeadersWidth = 62;
            this.DataTable.RowTemplate.Height = 28;
            this.DataTable.Size = new System.Drawing.Size(1180, 313);
            this.DataTable.TabIndex = 1;
            // 
            // ComboBoxChuyenNganh
            // 
            this.ComboBoxChuyenNganh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBoxChuyenNganh.FormattingEnabled = true;
            this.ComboBoxChuyenNganh.Items.AddRange(new object[] {
            "Khoa học máy tính",
            "Kỹ thuật phần mềm",
            "Hệ thống thông tin",
            "An toàn thông tin",
            "Mạng máy tính và truyền thông",
            "Thương mại điện tử",
            "Khoa học dữ liệu",
            "Trí tuệ nhận tạo",
            "Kỹ thuật máy tính",
            "Công nghệ thông tin",
            "Thiết  kế vi mạch"});
            this.ComboBoxChuyenNganh.Location = new System.Drawing.Point(408, 175);
            this.ComboBoxChuyenNganh.Name = "ComboBoxChuyenNganh";
            this.ComboBoxChuyenNganh.Size = new System.Drawing.Size(278, 33);
            this.ComboBoxChuyenNganh.TabIndex = 11;
            // 
            // MSSV
            // 
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.MinimumWidth = 8;
            this.MSSV.Name = "MSSV";
            this.MSSV.Width = 150;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 8;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 200;
            // 
            // ChuyenNganh
            // 
            this.ChuyenNganh.HeaderText = "Chuyên Ngành";
            this.ChuyenNganh.MinimumWidth = 8;
            this.ChuyenNganh.Name = "ChuyenNganh";
            this.ChuyenNganh.Width = 200;
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 8;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 150;
            // 
            // SoMon
            // 
            this.SoMon.HeaderText = "Số môn";
            this.SoMon.MinimumWidth = 8;
            this.SoMon.Name = "SoMon";
            // 
            // LeftBox
            // 
            this.LeftBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LeftBox.FormattingEnabled = true;
            this.LeftBox.ItemHeight = 25;
            this.LeftBox.Items.AddRange(new object[] {
            "Anh Văn 1",
            "Anh Văn 2",
            "Anh Văn 3",
            "Cấu trúc dữ liệu và giải thuật",
            "Cấu trúc rời rạc",
            "Cơ sở dữ liệu",
            "Đại số tuyến tính",
            "Giải tích",
            "Hệ điều hành",
            "Lập trình hướng đối tượng",
            "Lập trình trực quan",
            "Lịch sử đảng",
            "Nhập môn lập trình",
            "Nhập môn mạng máy tính",
            "Pháp luật đại cương",
            "Tổ chức và cấu trúc máy tính",
            "Triết học",
            "Tư tưởng Hồ Chí Minh",
            "Xác suất thống kê"});
            this.LeftBox.Location = new System.Drawing.Point(217, 336);
            this.LeftBox.Name = "LeftBox";
            this.LeftBox.Size = new System.Drawing.Size(399, 154);
            this.LeftBox.Sorted = true;
            this.LeftBox.TabIndex = 12;
            // 
            // RightBox
            // 
            this.RightBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RightBox.FormattingEnabled = true;
            this.RightBox.ItemHeight = 25;
            this.RightBox.Location = new System.Drawing.Point(712, 336);
            this.RightBox.Name = "RightBox";
            this.RightBox.Size = new System.Drawing.Size(381, 154);
            this.RightBox.Sorted = true;
            this.RightBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 1000);
            this.Controls.Add(this.DataTable);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Nhập liệu sinh viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CheckBox_Nu;
        private System.Windows.Forms.CheckBox CheckBox_Nam;
        private System.Windows.Forms.TextBox TextBox_HoTen;
        private System.Windows.Forms.TextBox TextBox_MSSV;
        private System.Windows.Forms.Label Label_CacMonHoc;
        private System.Windows.Forms.Label Label_GioiTinh;
        private System.Windows.Forms.Label Label_ChuyenNganh;
        private System.Windows.Forms.Label Label_HoTen;
        private System.Windows.Forms.Label Label_MSSV;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ToLeftButton;
        private System.Windows.Forms.Button ToRightButton;
        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.ComboBox ComboBoxChuyenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuyenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoMon;
        private System.Windows.Forms.ListBox LeftBox;
        private System.Windows.Forms.ListBox RightBox;
    }
}

