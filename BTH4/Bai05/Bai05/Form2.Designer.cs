namespace Bai05
{
    partial class formThemSinhVien
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
            this.label_MSSV = new System.Windows.Forms.Label();
            this.label_TenSinhVien = new System.Windows.Forms.Label();
            this.label_Khoa = new System.Windows.Forms.Label();
            this.label_DTB = new System.Windows.Forms.Label();
            this.textBox_MSSV = new System.Windows.Forms.TextBox();
            this.textBox_TenSinhVien = new System.Windows.Forms.TextBox();
            this.textBox_DTB = new System.Windows.Forms.TextBox();
            this.comboBox_Khoa = new System.Windows.Forms.ComboBox();
            this.button_ThemMoi = new System.Windows.Forms.Button();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_MSSV
            // 
            this.label_MSSV.AutoSize = true;
            this.label_MSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_MSSV.Location = new System.Drawing.Point(60, 83);
            this.label_MSSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MSSV.Name = "label_MSSV";
            this.label_MSSV.Size = new System.Drawing.Size(160, 25);
            this.label_MSSV.TabIndex = 0;
            this.label_MSSV.Text = "Mã Số Sinh Viên";
            // 
            // label_TenSinhVien
            // 
            this.label_TenSinhVien.AutoSize = true;
            this.label_TenSinhVien.Location = new System.Drawing.Point(60, 139);
            this.label_TenSinhVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TenSinhVien.Name = "label_TenSinhVien";
            this.label_TenSinhVien.Size = new System.Drawing.Size(137, 25);
            this.label_TenSinhVien.TabIndex = 0;
            this.label_TenSinhVien.Text = "Tên Sinh Viên";
            // 
            // label_Khoa
            // 
            this.label_Khoa.AutoSize = true;
            this.label_Khoa.Location = new System.Drawing.Point(60, 202);
            this.label_Khoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Khoa.Name = "label_Khoa";
            this.label_Khoa.Size = new System.Drawing.Size(59, 25);
            this.label_Khoa.TabIndex = 0;
            this.label_Khoa.Text = "Khoa";
            // 
            // label_DTB
            // 
            this.label_DTB.AutoSize = true;
            this.label_DTB.Location = new System.Drawing.Point(60, 255);
            this.label_DTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DTB.Name = "label_DTB";
            this.label_DTB.Size = new System.Drawing.Size(88, 25);
            this.label_DTB.TabIndex = 0;
            this.label_DTB.Text = "Điểm TB";
            // 
            // textBox_MSSV
            // 
            this.textBox_MSSV.Location = new System.Drawing.Point(286, 78);
            this.textBox_MSSV.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_MSSV.Name = "textBox_MSSV";
            this.textBox_MSSV.Size = new System.Drawing.Size(321, 30);
            this.textBox_MSSV.TabIndex = 0;
            this.textBox_MSSV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_MSSV_KeyDown);
            // 
            // textBox_TenSinhVien
            // 
            this.textBox_TenSinhVien.Location = new System.Drawing.Point(288, 136);
            this.textBox_TenSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_TenSinhVien.Name = "textBox_TenSinhVien";
            this.textBox_TenSinhVien.Size = new System.Drawing.Size(487, 30);
            this.textBox_TenSinhVien.TabIndex = 1;
            this.textBox_TenSinhVien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_TenSinhVien_KeyDown);
            // 
            // textBox_DTB
            // 
            this.textBox_DTB.Location = new System.Drawing.Point(286, 255);
            this.textBox_DTB.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_DTB.Name = "textBox_DTB";
            this.textBox_DTB.Size = new System.Drawing.Size(132, 30);
            this.textBox_DTB.TabIndex = 3;
            this.textBox_DTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_DTB_KeyDown);
            // 
            // comboBox_Khoa
            // 
            this.comboBox_Khoa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox_Khoa.FormattingEnabled = true;
            this.comboBox_Khoa.Items.AddRange(new object[] {
            "Khoa Công Nghệ Phần Mềm",
            "Khoa Mạng Máy Tính Và Truyền Thông",
            "Khoa Khoa Học Và Kĩ Thuật Thông Tin",
            "Khoa Khoa Học Máy Tính",
            "Khoa Kỹ Thuật Máy Tính",
            "Khoa Hệ Thống Thông Tin"});
            this.comboBox_Khoa.Location = new System.Drawing.Point(286, 199);
            this.comboBox_Khoa.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Khoa.Name = "comboBox_Khoa";
            this.comboBox_Khoa.Size = new System.Drawing.Size(487, 33);
            this.comboBox_Khoa.TabIndex = 2;
            this.comboBox_Khoa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_Khoa_KeyDown);
            // 
            // button_ThemMoi
            // 
            this.button_ThemMoi.AutoSize = true;
            this.button_ThemMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_ThemMoi.Location = new System.Drawing.Point(526, 340);
            this.button_ThemMoi.Margin = new System.Windows.Forms.Padding(4);
            this.button_ThemMoi.Name = "button_ThemMoi";
            this.button_ThemMoi.Size = new System.Drawing.Size(110, 35);
            this.button_ThemMoi.TabIndex = 3;
            this.button_ThemMoi.Text = "Thêm Mới";
            this.button_ThemMoi.UseVisualStyleBackColor = false;
            this.button_ThemMoi.Click += new System.EventHandler(this.button_ThemMoi_Click);
            // 
            // button_Thoat
            // 
            this.button_Thoat.AutoSize = true;
            this.button_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Thoat.Location = new System.Drawing.Point(675, 340);
            this.button_Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(100, 35);
            this.button_Thoat.TabIndex = 3;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = false;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // formThemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 464);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.button_ThemMoi);
            this.Controls.Add(this.comboBox_Khoa);
            this.Controls.Add(this.textBox_DTB);
            this.Controls.Add(this.textBox_TenSinhVien);
            this.Controls.Add(this.textBox_MSSV);
            this.Controls.Add(this.label_DTB);
            this.Controls.Add(this.label_Khoa);
            this.Controls.Add(this.label_TenSinhVien);
            this.Controls.Add(this.label_MSSV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formThemSinhVien";
            this.Text = "Thêm Sinh Viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_MSSV;
        private System.Windows.Forms.Label label_TenSinhVien;
        private System.Windows.Forms.Label label_Khoa;
        private System.Windows.Forms.Label label_DTB;
        private System.Windows.Forms.TextBox textBox_MSSV;
        private System.Windows.Forms.TextBox textBox_TenSinhVien;
        private System.Windows.Forms.TextBox textBox_DTB;
        private System.Windows.Forms.ComboBox comboBox_Khoa;
        private System.Windows.Forms.Button button_ThemMoi;
        private System.Windows.Forms.Button button_Thoat;
    }
}