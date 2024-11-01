using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(1, 500);
            int y = rnd.Next(1, 500);
            Graphics g = this.CreateGraphics();
            Font font = new Font("Arial", 16);
            Brush brush = new SolidBrush(Color.Black);
            PointF point = new PointF(x, y);
            g.DrawString("Paint Event", font, brush, point);
            g.Dispose();
            font.Dispose();
            brush.Dispose();
          
        }
    }
}
