using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int TongTien = 0;
        int GiaHangA = 5000;
        int GiaHangB = 6500;
        int GiaHangC = 8000;
        Dictionary<string, int> GheDangChon = new Dictionary<string, int>();
        private void A_ghe1_Click(object sender, EventArgs e)
        {
            if(A_ghe1.BackColor == Color.White)
            {
                A_ghe1.BackColor = Color.Blue;
                TinhTien(GiaHangA);
                GheDangChon.Add("1", 1);

            }
            else if(A_ghe1.BackColor == Color.Blue)
            {
                A_ghe1.BackColor = Color.White;
                TinhTien(GiaHangA * -1);
                GheDangChon.Remove("1");
            }
            else if(A_ghe1.BackColor == Color.Yellow)
            {
                MessageBox.Show("Vé ở vị trí này đã được bán!");
            }
        }

        private void A_ghe2_Click(object sender, EventArgs e)
        {
            if (A_ghe2.BackColor == Color.White)
            {
                A_ghe2.BackColor = Color.Blue;
                TinhTien(GiaHangA);
                GheDangChon.Add("2", 2);

            }
            else if (A_ghe2.BackColor == Color.Blue)
            {
                A_ghe2.BackColor = Color.White;
                TinhTien(GiaHangA * -1);
                GheDangChon.Remove("2");
            }
            else if (A_ghe2.BackColor == Color.Yellow)
            {
                MessageBox.Show("Vé ở vị trí này đã được bán!");
            }
        }

        private void A_ghe3_Click(object sender, EventArgs e)
        {
            if (A_ghe3.BackColor == Color.White)
            {
                A_ghe3.BackColor = Color.Blue;
                TinhTien(GiaHangA);
                GheDangChon.Add("3", 3);
            }
            else if (A_ghe3.BackColor == Color.Blue)
            {
                A_ghe3.BackColor = Color.White;
                TinhTien(GiaHangA * -1);
                GheDangChon.Remove("3");
            }
            else if (A_ghe3.BackColor == Color.Yellow)
            {
                MessageBox.Show("Vé ở vị trí này đã được bán!");
            }
        }

        private void A_ghe4_Click(object sender, EventArgs e)
        {
            if (A_ghe4.BackColor == Color.White)
            {
                A_ghe4.BackColor = Color.Blue;
                TinhTien(GiaHangA);
                GheDangChon.Add("4",4);

            }
            else if (A_ghe4.BackColor == Color.Blue)
            {
                A_ghe4.BackColor = Color.White;
                TinhTien(GiaHangA * -1);
                GheDangChon.Remove("4");
            }
            else if (A_ghe4.BackColor == Color.Yellow)
            {
                MessageBox.Show("Vé ở vị trí này đã được bán!");
            }
        }

        private void A_ghe5_Click(object sender, EventArgs e)
        {
            if (A_ghe5.BackColor == Color.White)
            {
                A_ghe5.BackColor = Color.Blue;
                TinhTien(GiaHangA);
                GheDangChon.Add("5", 5);
            }
            else if (A_ghe5.BackColor == Color.Blue)
            {
                A_ghe5.BackColor = Color.White;
                TinhTien(GiaHangA * -1);
                GheDangChon.Remove("5");
            }
            else if (A_ghe5.BackColor == Color.Yellow)
            {
                MessageBox.Show("Vé ở vị trí này đã được bán!");
            }
        }

        private void B_ghe6_Click(object sender, EventArgs e)
        {
            if (B_ghe6.BackColor == Color.White)
            {
                B_ghe6.BackColor = Color.Blue;
                TinhTien(GiaHangB);
                GheDangChon.Add("6", 6);
            }
            else if (B_ghe6.BackColor == Color.Blue)
            {
                B_ghe6.BackColor = Color.White;
                TinhTien(GiaHangB * -1);
                GheDangChon.Remove("6");
            }
            else if (B_ghe6.BackColor == Color.Yellow)
            {
                MessageBox.Show("Vé ở vị trí này đã được bán!");
            }
        }

        private void B_ghe7_Click(object sender, EventArgs e)
        {
            if (B_ghe7.BackColor == Color.White)
            {
                B_ghe7.BackColor = Color.Blue;
                TinhTien(GiaHangB);
                GheDangChon.Add("7", 7);
            }
            else if (B_ghe7.BackColor == Color.Blue)
            {
                B_ghe7.BackColor = Color.White;
                TinhTien(GiaHangB * -1);
                GheDangChon.Remove("7");
            }
            else if (B_ghe7.BackColor == Color.Yellow)
            {
                MessageBox.Show("Vé ở vị trí này đã được bán!");
            }
        }

        private void B_ghe8_Click(object sender, EventArgs e)
        {
            if (B_ghe8.BackColor == Color.White)
            {
                B_ghe8.BackColor = Color.Blue;
                TinhTien(GiaHangB);
                GheDangChon.Add("8",8);
            }
            else if (B_ghe8.BackColor == Color.Blue)
            {
                B_ghe8.BackColor = Color.White;
                TinhTien(GiaHangB * -1);
                GheDangChon.Remove("8");
            }
            else if (B_ghe8.BackColor == Color.Yellow)
            {
                MessageBox.Show("Vé ở vị trí này đã được bán!");
            }
        }

        private void B_ghe9_Click(object sender, EventArgs e)
        {
            if (B_ghe9.BackColor == Color.White)
            {
                B_ghe9.BackColor = Color.Blue;
                TinhTien(GiaHangB);
                GheDangChon.Add("9",9);
            }
            else if (B_ghe9.BackColor == Color.Blue)
            {
                B_ghe9.BackColor = Color.White;
                TinhTien(GiaHangB * -1);
                GheDangChon.Remove("9");
            }
            else if (B_ghe9.BackColor == Color.Yellow)
            {
                MessageBox.Show("Vé ở vị trí này đã được bán!");
            }
        }

        private void B_ghe10_Click(object sender, EventArgs e)
        {
            if (B_ghe10.BackColor == Color.White)
            {
                B_ghe10.BackColor = Color.Blue;
                TinhTien(GiaHangB);
                GheDangChon.Add("10", 10);
            }
            else if (B_ghe10.BackColor == Color.Blue)
            {
                B_ghe10.BackColor = Color.White;
                TinhTien(GiaHangB * -1);
                GheDangChon.Remove("10");
            }
            else if (B_ghe10.BackColor == Color.Yellow)
            {
                MessageBox.Show("Vé ở vị trí này đã được bán!");
            }
        }

        private void C_ghe11_Click(object sender, EventArgs e)
        {
            if (C_ghe11.BackColor == Color.White)
            {
                C_ghe11.BackColor = Color.Blue;
                TinhTien(GiaHangC);
                GheDangChon.Add("11",11);
            }
            else if (C_ghe11.BackColor == Color.Blue)
            {
                C_ghe11.BackColor = Color.White;
                TinhTien(GiaHangC * -1);
                GheDangChon.Remove("11");
            }
            else if (C_ghe11.BackColor == Color.Yellow)
            {
                MessageBox.Show("Vé ở vị trí này đã được bán!");
            }
        }

        private void C_ghe12_Click(object sender, EventArgs e)
        {
            if (C_ghe12.BackColor == Color.White)
            {
                C_ghe12.BackColor = Color.Blue;
                TinhTien(GiaHangC);
                GheDangChon.Add("12", 12);
            }
            else if (C_ghe12.BackColor == Color.Blue)
            {
                C_ghe12.BackColor = Color.White;
                TinhTien(GiaHangC * -1);
                GheDangChon.Remove("12");
            }
            else if (C_ghe12.BackColor == Color.Yellow)
            {
                MessageBox.Show("Vé ở vị trí này đã được bán!");
            }
        }

        private void C_ghe13_Click(object sender, EventArgs e)
        {
            if (C_ghe13.BackColor == Color.White)
            {
                C_ghe13.BackColor = Color.Blue;
                TinhTien(GiaHangC);
                GheDangChon.Add("13",13);
            }
            else if (C_ghe13.BackColor == Color.Blue)
            {
                C_ghe13.BackColor = Color.White;
                TinhTien(GiaHangC * -1);
                GheDangChon.Remove("13");
            }
            else if (C_ghe13.BackColor == Color.Yellow)
            {
                MessageBox.Show("Vé ở vị trí này đã được bán!");
            }
        }

        private void C_ghe14_Click(object sender, EventArgs e)
        {
            if (C_ghe14.BackColor == Color.White)
            {
                C_ghe14.BackColor = Color.Blue;
                TinhTien(GiaHangC);
                GheDangChon.Add("14",14);
            }
            else if (C_ghe14.BackColor == Color.Blue)
            {
                C_ghe14.BackColor = Color.White;
                TinhTien(GiaHangC * -1);
                GheDangChon.Remove("14");
            }
            else if (C_ghe14.BackColor == Color.Yellow)
            {
                MessageBox.Show("Vé ở vị trí này đã được bán!");
            }
        }

        private void C_ghe15_Click(object sender, EventArgs e)
        {
            if (C_ghe15.BackColor == Color.White)
            {
                C_ghe15.BackColor = Color.Blue;
                TinhTien(GiaHangC);
                GheDangChon.Add("15", 15);
            }
            else if (C_ghe15.BackColor == Color.Blue)
            {
                C_ghe15.BackColor = Color.White;
                TinhTien(GiaHangC * -1);
                GheDangChon.Remove("15");
            }
            else if (C_ghe15.BackColor == Color.Yellow)
            {
                MessageBox.Show("Vé ở vị trí này đã được bán!");
            }
        }

       

        private void Cancel_Click(object sender, EventArgs e)
        {
            foreach (var entry in GheDangChon)
            {
                switch (entry.Value)
                {
                    case 1: A_ghe1.BackColor = Color.White; break;
                    case 2: A_ghe2.BackColor = Color.White; break;
                    case 3: A_ghe3.BackColor = Color.White; break;
                    case 4: A_ghe4.BackColor = Color.White; break;
                    case 5: A_ghe5.BackColor = Color.White; break;
                    case 6: B_ghe6.BackColor = Color.White; break;
                    case 7: B_ghe7.BackColor = Color.White; break;
                    case 8: B_ghe8.BackColor = Color.White; break;
                    case 9: B_ghe9.BackColor = Color.White; break;
                    case 10: B_ghe10.BackColor = Color.White; break;
                    case 11: C_ghe11.BackColor = Color.White; break;
                    case 12: C_ghe12.BackColor = Color.White; break;
                    case 13: C_ghe13.BackColor = Color.White; break;
                    case 14: C_ghe14.BackColor = Color.White; break;
                    case 15: C_ghe15.BackColor = Color.White; break;
                }
            }
            GheDangChon.Clear();
            ThanhTien.Text = "0";
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            if(TongTien == 0)
            {
                MessageBox.Show("Bạn chưa chọn ghế!");
            }  
            else if(GheDangChon.Count!=0)
            {
                MessageBox.Show("Bạn chưa chọn ghế. Bạn vẫn muốn thoát chứ?");
                foreach (var entry in GheDangChon)
                {
                    switch (entry.Value)
                    {
                        case 1: A_ghe1.BackColor = Color.White; break;
                        case 2: A_ghe2.BackColor = Color.White; break;
                        case 3: A_ghe3.BackColor = Color.White; break;
                        case 4: A_ghe4.BackColor = Color.White; break;
                        case 5: A_ghe5.BackColor = Color.White; break;
                        case 6: B_ghe6.BackColor = Color.White; break;
                        case 7: B_ghe7.BackColor = Color.White; break;
                        case 8: B_ghe8.BackColor = Color.White; break;
                        case 9: B_ghe9.BackColor = Color.White; break;
                        case 10: B_ghe10.BackColor = Color.White; break;
                        case 11: C_ghe11.BackColor = Color.White; break;
                        case 12: C_ghe12.BackColor = Color.White; break;
                        case 13: C_ghe13.BackColor = Color.White; break;
                        case 14: C_ghe14.BackColor = Color.White; break;
                        case 15: C_ghe15.BackColor = Color.White; break;
                    }
                }
                ThanhTien.Clear();
                GheDangChon.Clear();
                TongTien = 0;
            }   
            else
            {
                
                ThanhTien.Clear();
                MessageBox.Show($"Số tiền vé ban cần thanh toán là {TongTien}. Xin cảm ơn quý khách!");
                TongTien = 0;
            }    

        }
        private void TinhTien(int x)
        {
            TongTien += x;
            ThanhTien.Text = TongTien.ToString();
        }

        private void DONE_Click(object sender, EventArgs e)
        {
            foreach (var entry in GheDangChon)
            {
                switch (entry.Value)
                {
                    case 1: A_ghe1.BackColor = Color.Yellow; break;
                    case 2: A_ghe2.BackColor = Color.Yellow; break;
                    case 3: A_ghe3.BackColor = Color.Yellow; break;
                    case 4: A_ghe4.BackColor = Color.Yellow; break;
                    case 5: A_ghe5.BackColor = Color.Yellow; break;
                    case 6: B_ghe6.BackColor = Color.Yellow; break;
                    case 7: B_ghe7.BackColor = Color.Yellow; break;
                    case 8: B_ghe8.BackColor = Color.Yellow; break;
                    case 9: B_ghe9.BackColor = Color.Yellow; break;
                    case 10: B_ghe10.BackColor = Color.Yellow; break;
                    case 11: C_ghe11.BackColor = Color.Yellow; break;
                    case 12: C_ghe12.BackColor = Color.Yellow; break;
                    case 13: C_ghe13.BackColor = Color.Yellow; break;
                    case 14: C_ghe14.BackColor = Color.Yellow; break;
                    case 15: C_ghe15.BackColor = Color.Yellow; break;
                }
            }
            GheDangChon.Clear();
        }
    }
}
