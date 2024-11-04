using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string keyCode;
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char x = e.KeyChar;
            MessageBox.Show("Bạn vừa nhấn phím " + x + " có mã ASCII là: " + (int)x + " và có key code là " + keyCode);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            MessageBox.Show("Chuột vừa được nhấn ở tọa độ (X, Y) = ("+ x+", "+ y+ ")");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            keyCode = e.KeyCode.ToString();
        }
    }
}
