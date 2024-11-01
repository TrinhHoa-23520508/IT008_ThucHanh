using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool Check_Info()
        {
            if (TextBox_MSSV.Text == "" || !Check_MSSV())
            {
                return false;
            }
            if (TextBox_HoTen.Text == "" || !Check_Name())
            {
                return false;
            }
            if (!Check_ChuyenNganh())
            {
                return false;
            }
            if (CheckBox_Nu.Checked == false && CheckBox_Nam.Checked == false)
            {
                return false;
            }
            return true;
        }

        private void TextBox_MSSV_TextChanged(object sender, EventArgs e)
        {
            if (!Check_MSSV()) MessageBox.Show("Mã số sinh viên không được có kí tự!");
        }

        private void TextBox_HoTen_TextChanged(object sender, EventArgs e)
        {
            if(!Check_Name()) MessageBox.Show("Họ và tên không được chứa số!");
        }

       

        private void CheckBox_Nam_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckBox_Nam.Checked&&CheckBox_Nu.Checked)
            {
                CheckBox_Nu.Checked = !CheckBox_Nu.Checked;
            }    
          
        }

        private void CheckBox_Nu_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_Nam.Checked && CheckBox_Nu.Checked)
            {
                CheckBox_Nam.Checked = !CheckBox_Nam.Checked;
            }

        }
        private bool Check_MSSV()
        {
            foreach (var number in TextBox_MSSV.Text)
            {
                if (Convert.ToInt32(number) < 48 || Convert.ToInt32(number) > 57)
                {
                    return false;
                }
            }
            return true;
        }
        private bool Check_Name()
        {
            foreach (var number in TextBox_HoTen.Text)
            {
                if (Convert.ToInt32(number) >= 48 && Convert.ToInt32(number) <= 57)
                {
                    return false;
                }
            }
            return true;
        }
        private bool Check_ChuyenNganh()
        {
            if(ComboBoxChuyenNganh.Text=="")
            {
                return false;
            }
            bool check = false;
            foreach(string temp in ComboBoxChuyenNganh.Items)
            {
                if (ComboBoxChuyenNganh.Text == temp) return true;
            }
            return check;
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if(!Check_Info())
            {
                MessageBox.Show("Thông tin nhập vào chưa chính xác hoặc bị để trống. Vui lòng kiểm tra lại!");
            }
            else
            {
                string MSSV = TextBox_MSSV.Text;
                string HoTen = TextBox_HoTen.Text;
                string ChuyenNganh = ComboBoxChuyenNganh.Text;
                string GioiTinh;
                string SoMon = RightBox.Items.Count.ToString();
                if (CheckBox_Nu.Checked)
                    GioiTinh = "Nữ";
                else GioiTinh = "Nam";
                DataTable.Rows.Add(MSSV, HoTen, ChuyenNganh, GioiTinh, SoMon);
                foreach(var temp in RightBox.Items)
                {
                    LeftBox.Items.Add(temp);
                }
                RightBox.Items.Clear();
                TextBox_HoTen.Clear();
                TextBox_MSSV.Clear();
                CheckBox_Nam.Checked = false;
                CheckBox_Nu.Checked = false;
                ComboBoxChuyenNganh.Text = "";
                
            }    
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in DataTable.SelectedRows)
            {
                DataTable.Rows.Remove(row);
            }    
        }

        private void ToRightButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i<LeftBox.SelectedItems.Count; i++)
            {
                RightBox.Items.Add(LeftBox.SelectedItems[i]);
                LeftBox.Items.Remove(LeftBox.SelectedItems[i]);
            }    
        }

        private void ToLeftButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < RightBox.SelectedItems.Count; i++)
            {
                LeftBox.Items.Add(RightBox.SelectedItems[i]);
                RightBox.Items.Remove(RightBox.SelectedItems[i]);
            }
        }
       
    }
}
