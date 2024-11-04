using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class FormQuanLySinhVien : Form
    {
        public FormQuanLySinhVien()
        {
            InitializeComponent();
            DataTable SinhVien = new DataTable("SinhVien");
            SinhVien.Columns.Add("MSSV", typeof(string));
            SinhVien.Columns.Add("HoTen", typeof(string));
            SinhVien.Columns.Add("Khoa", typeof(string));
            SinhVien.Columns.Add("DTB", typeof(string));
            database.Tables.Add(SinhVien);

        }

        private void MenuAdd_Click(object sender, EventArgs e)
        {
            formThemSinhVien form = new formThemSinhVien(this.database);
            form.ShowDialog();
        }

        private void AddImage_Click(object sender, EventArgs e)
        {
            formThemSinhVien form = new formThemSinhVien(this.database);
            form.ShowDialog();
            
        }

        private void labelAdd_Click(object sender, EventArgs e)
        {
            formThemSinhVien form = new formThemSinhVien(this.database);
            form.ShowDialog();
        }

        private void SearchImage_Click(object sender, EventArgs e)
        {
            dataGrid.Rows.Clear();

            if(!String.IsNullOrEmpty(textBoxSearch.Text))
            {
                int STT = 0;
                foreach (DataRow s in database.Tables["SinhVien"].Rows)
                {
                    
                    string Name = s["HoTen"].ToString();
                    if(Name.Contains(textBoxSearch.Text))
                    {
                        dataGrid.Rows.Add(STT.ToString(),s["MSSV"], s["HoTen"], s["Khoa"], s["DTB"]);
                        STT++;
                    }    
                }    
            } 
            else
            {
                MessageBox.Show("Không được để trống. Vui lòng nhập từ cần tìm kiếm !");

            }    
        }

        private void toolStripTextBox2_Enter(object sender, EventArgs e)
        {

        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát chứ?", "Xác nhận", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }    
        }
    }
}
