namespace Bai05
{
    partial class FormQuanLySinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLySinhVien));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.AddImage = new System.Windows.Forms.ToolStripButton();
            this.labelAdd = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripLabel();
            this.textBoxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.SearchImage = new System.Windows.Forms.ToolStripButton();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.column_STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_TenSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_DTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.database = new System.Data.DataSet();
            this.menuStrip1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(845, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAdd,
            this.MenuExit});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(73, 29);
            this.Menu.Text = "Menu";
            // 
            // MenuAdd
            // 
            this.MenuAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MenuAdd.Name = "MenuAdd";
            this.MenuAdd.Size = new System.Drawing.Size(270, 34);
            this.MenuAdd.Text = "Thêm Mới";
            this.MenuAdd.Click += new System.EventHandler(this.MenuAdd_Click);
            // 
            // MenuExit
            // 
            this.MenuExit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(270, 34);
            this.MenuExit.Text = "Thoát";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddImage,
            this.labelAdd,
            this.toolStripTextBox1,
            this.textBoxSearch,
            this.SearchImage});
            this.toolStrip.Location = new System.Drawing.Point(3, 46);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip.Size = new System.Drawing.Size(894, 38);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // AddImage
            // 
            this.AddImage.AutoSize = false;
            this.AddImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddImage.Image = global::Bai05.Properties.Resources.add_group;
            this.AddImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddImage.Name = "AddImage";
            this.AddImage.Size = new System.Drawing.Size(34, 28);
            this.AddImage.Text = "Thêm mới";
            this.AddImage.Click += new System.EventHandler(this.AddImage_Click);
            // 
            // labelAdd
            // 
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(307, 33);
            this.labelAdd.Text = " Thêm Mới                                          ";
            this.labelAdd.Click += new System.EventHandler(this.labelAdd_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(185, 33);
            this.toolStripTextBox1.Text = " Tìm Kiếm Theo Tên    ";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(265, 33);
            this.textBoxSearch.Enter += new System.EventHandler(this.toolStripTextBox2_Enter);
            // 
            // SearchImage
            // 
            this.SearchImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SearchImage.Image = ((System.Drawing.Image)(resources.GetObject("SearchImage.Image")));
            this.SearchImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchImage.Name = "SearchImage";
            this.SearchImage.Size = new System.Drawing.Size(34, 33);
            this.SearchImage.Text = "toolStripButton1";
            this.SearchImage.Click += new System.EventHandler(this.SearchImage_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_STT,
            this.column_MSSV,
            this.column_TenSinhVien,
            this.column_Khoa,
            this.column_DTB});
            this.dataGrid.Location = new System.Drawing.Point(3, 121);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 62;
            this.dataGrid.RowTemplate.Height = 28;
            this.dataGrid.Size = new System.Drawing.Size(915, 441);
            this.dataGrid.TabIndex = 2;
            // 
            // column_STT
            // 
            this.column_STT.HeaderText = "STT";
            this.column_STT.MinimumWidth = 8;
            this.column_STT.Name = "column_STT";
            this.column_STT.Width = 150;
            // 
            // column_MSSV
            // 
            this.column_MSSV.HeaderText = "Mã số  sinh viên";
            this.column_MSSV.MinimumWidth = 8;
            this.column_MSSV.Name = "column_MSSV";
            this.column_MSSV.Width = 150;
            // 
            // column_TenSinhVien
            // 
            this.column_TenSinhVien.HeaderText = "Tên Sinh Viên";
            this.column_TenSinhVien.MinimumWidth = 8;
            this.column_TenSinhVien.Name = "column_TenSinhVien";
            this.column_TenSinhVien.Width = 150;
            // 
            // column_Khoa
            // 
            this.column_Khoa.HeaderText = "Khoa";
            this.column_Khoa.MinimumWidth = 8;
            this.column_Khoa.Name = "column_Khoa";
            this.column_Khoa.Width = 180;
            // 
            // column_DTB
            // 
            this.column_DTB.HeaderText = "Điểm TB";
            this.column_DTB.MinimumWidth = 8;
            this.column_DTB.Name = "column_DTB";
            this.column_DTB.Width = 150;
            // 
            // database
            // 
            this.database.DataSetName = " ";
            // 
            // FormQuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 562);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormQuanLySinhVien";
            this.Text = "Quản Lý Sinh Viên";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem MenuAdd;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton AddImage;
        private System.Windows.Forms.ToolStripLabel labelAdd;
        private System.Windows.Forms.ToolStripLabel toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.ToolStripButton SearchImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_TenSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_DTB;
        public System.Data.DataSet database;
    }
}

