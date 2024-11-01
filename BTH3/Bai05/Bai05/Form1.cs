using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool isValidNumber()
        {
            double a;
            if(String.IsNullOrEmpty(Number1.Text)||String.IsNullOrEmpty(Number2.Text))
            {
                MessageBox.Show("Không được để trống");
                return false;
            }    
            try
            {
                a = double.Parse(Number1.Text) + double.Parse(Number2.Text);
            }
            catch(FormatException)
            {
                Number1.Text = Number2.Text = "";
                MessageBox.Show("Giá trị nhập vào không hợp lệ!");
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (isValidNumber())
            {
                textBox3.Text = (double.Parse(Number1.Text) + double.Parse(Number2.Text)).ToString();
                Number1.Clear();
                Number2.Clear();
            }
              
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isValidNumber())
            {
                textBox3.Text = (double.Parse(Number1.Text) - double.Parse(Number2.Text)).ToString();
                Number1.Clear();
                Number2.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isValidNumber())
            {
                textBox3.Text = (double.Parse(Number1.Text) * double.Parse(Number2.Text)).ToString();
                Number1.Clear();
                Number2.Clear();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isValidNumber())
            {
                textBox3.Text = (double.Parse(Number1.Text) / double.Parse(Number2.Text)).ToString();
                Number1.Clear();
                Number2.Clear();
            }
        }

        private void Number1_ContextMenuStripChanged(object sender, EventArgs e)
        {

            textBox3.Clear();

        }

        private void Number2_ContextMenuStripChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
      
        }
    }
}
