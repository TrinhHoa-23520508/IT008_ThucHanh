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
    public partial class formThemSinhVien : Form
    {
        private DataSet _dataSet = new DataSet();
        public formThemSinhVien(DataSet dataSet)
        {
            InitializeComponent();
            _dataSet = dataSet;
        }
        public String MSSV;
        public String HoTen;
        public String Khoa;
        public String DTB;
        private bool KiemTraMSSV(string MSSV)
        {
            if(MSSV.Length==0)
            {
                return false;
            }    
            foreach(char x in MSSV)
            {
                if((int) x < (int) '0' || (int) x>(int)'9')
                {
                    return false;
                }    
            }
            return true;
        }
        private bool KiemTraHoTen(string HoTen)
        {
            if(HoTen.Length==0)
            {
                return false;
            }
            foreach (char x in HoTen)
            {
                if ((int)x >= (int)'0' && (int)x <= (int)'9')
                {
                    return false;
                }
            }
            return true;
        }
        private bool KiemTraDTB(string DTB)
        {
            bool result = true;
            if(DTB.Length==0)
            {
                result = false;
            }    
            foreach(char c in DTB)
            {
                if (((int)c < (int)'0' || (int)c > (int)'9')&&c!='.')
                {
                    result = false;
                }    
            }
            int dtb;
            Int32.TryParse(DTB, out dtb);
            if(dtb<0||dtb>10)
            {
                result = false;
            }
            return result;
        }
        private bool KiemTraKhoa(string Khoa)
        {
            bool result = false;
            foreach (var temp in comboBox_Khoa.Items)
            {
                if (string.Equals(Khoa, temp.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
        private void button_ThemMoi_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn thêm dữ liệu vào database chứ?", "Xác nhận", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                if(!(KiemTraKhoa(comboBox_Khoa.Text)&&KiemTraMSSV(textBox_MSSV.Text)&&KiemTraHoTen(textBox_TenSinhVien.Text)&&KiemTraDTB(textBox_DTB.Text)))
                {
                    MessageBox.Show("Thông tin nhập vào chưa đúng hoặc bị bỏ trống. Vui lòng nhập lại!");
                    textBox_DTB.Clear();
                    textBox_MSSV.Clear();
                    textBox_TenSinhVien.Clear();
                    comboBox_Khoa.Text = "";
                    textBox_MSSV.Focus();
                }   
                else
                {
                    MSSV = textBox_MSSV.Text;
                    HoTen = textBox_TenSinhVien.Text;
                    Khoa = comboBox_Khoa.Text;
                    DTB = textBox_DTB.Text;
                    DataTable dataTable = _dataSet.Tables["SinhVien"];
                    DataRow newRow = dataTable.NewRow();
                    newRow["MSSV"] = MSSV;
                    newRow["HoTen"] = HoTen;
                    newRow["Khoa"] = Khoa;
                    newRow["DTB"] = DTB;
                    dataTable.Rows.Add(newRow);
                    MessageBox.Show("Bạn đã thêm thông tin thành công!");
                    this.Close();

                   
                    

                }    
            }
            
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn thoát chứ? ", "Xác nhận", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }    
        }

        private void textBox_MSSV_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(!KiemTraMSSV(textBox_MSSV.Text))
                {
                    MessageBox.Show("Thông tin không hợp lệ hoặc bị bỏ trống. Vui lòng nhập lại!");
                    textBox_MSSV.Clear();
                }
                else
                {
                    e.SuppressKeyPress = true;
                    textBox_TenSinhVien.Focus();
                }
            } 
              
        }

        private void textBox_TenSinhVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!KiemTraHoTen(textBox_TenSinhVien.Text))
                {
                    MessageBox.Show("Thông tin không hợp lệ hoặc bị bỏ trống. Vui lòng nhập lại!");
                    textBox_TenSinhVien.Clear();
                }
                else
                {
                    e.SuppressKeyPress = true;
                    comboBox_Khoa.Focus();
                }
            }
             
        }

        private void textBox_DTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!KiemTraDTB(textBox_DTB.Text))
                {
                    MessageBox.Show("Thông tin không hợp lệ hoặc bị bỏ trống. Vui lòng nhập lại!");
                    textBox_DTB.Clear();
                    textBox_DTB.Focus();
                }
                else
                {
                    e.SuppressKeyPress = true;
                    comboBox_Khoa.Focus();
                } 
                    
            }
        }

        private void comboBox_Khoa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
               
                if (!KiemTraKhoa(comboBox_Khoa.Text))
                {
                    MessageBox.Show("Khoa bạn nhập vào không tồn tại. Vui lòng nhập lại!");
                    comboBox_Khoa.Text = "";
                    comboBox_Khoa.Focus();
                }
                else
                {
                    e.SuppressKeyPress = true;
                    textBox_DTB.Focus();
                }

            }    
        }
    }
}
