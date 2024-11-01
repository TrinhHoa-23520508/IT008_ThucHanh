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

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form click.");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            MessageBox.Show("Form Activated");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form Load");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Form Shown");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Form Closing");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Form Closed");
        }
    }
}
