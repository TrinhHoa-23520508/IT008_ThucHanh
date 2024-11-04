using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testmedia1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            time.Start();
        }

        private void openMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Video Sound| *.avi; *.mpeg; *.wav; *.midi; *.mp4; *.mp3 ";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                this.Text = Path.GetFileName(ofd.FileName);
                MediaPlayer.URL = path;
                MediaPlayer.Ctlcontrols.play();
            }
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn thoát ứng dụng chứ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void time_Tick(object sender, EventArgs e)
        {
            string datetime = DateTime.Now.ToString("dd/MM/yyyy");
            string clock = DateTime.Now.ToString("HH:mm:ss tt");
            statusStrip.Text = "Hôm nay là ngày " + datetime + " - Bây giờ là " + clock;
        }
    }
}
