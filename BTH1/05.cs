//Viết chương trình nhập ngày tháng năm cho biết thứ trong tuần
using System;
namespace Bai05
{
    class Program
    {
        public static void Main(string[] args)
        {
            int Ngay;
            int Thang;
            int Nam;
            Console.Write("Nhap vao ngay: ");
            Ngay = int.Parse(Console.ReadLine());
            Console.Write("\nNhap vao thang: ");
            Thang = int.Parse(Console.ReadLine());
            Console.Write("\nNhap vao nam: ");
            Nam = int.Parse(Console.ReadLine());
            Console.Write("\nNgay " + Ngay + "/" + Thang + "/" + Nam + " la thu " + ThuTrongTuan(Ngay, Thang, Nam) + " trong tuan");

        }
        public static bool LaNamNhuan(int Nam)
        {
            return Nam % 400 == 0 || (Nam % 4 == 0 && Nam % 100 != 0);
        }
        public static int Tong_Ngay(int Ngay, int Thang, int Nam)
        {
            int TongNgay = 0;
            int[] NgayCuaThang = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (LaNamNhuan(Nam)) NgayCuaThang[2] = 29;
            for (int i = 1; i < Thang; i++)
            {
                TongNgay += NgayCuaThang[i];
            }
            TongNgay += Ngay;
            return TongNgay;
        }
        public static string ThuTrongTuan(int Ngay, int Thang, int Nam)
        {
            string[] Thu = { "Chu nhat", "Hai", "Ba", "Tu", "Nam", "Sau", "Bay" };
            int TongNgay = Tong_Ngay(Ngay, Thang, Nam);
            int ThuCuaTuan = (TongNgay + (Nam - 1) * 365 + (Nam - 1) / 4 - (Nam - 1) / 100 + (Nam - 1) / 400) % 7;
            return Thu[ThuCuaTuan];

        }
    }
}

