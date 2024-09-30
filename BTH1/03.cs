//Viết chương trình nhập ngày tháng năm cho biết ngày tháng năm đó có hợp lệ không
using System;
using System.Collections.Specialized;
namespace Bai03
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
            if (LaNgayDung(Ngay, Thang, Nam)) Console.Write("\nNgay thang nam nhap vao hop le!");
            else Console.Write("\nNgay thang nam nhap vao khong hop le!");
        }
        public static bool LaNgayDung(int Ngay, int Thang, int Nam)
        {
            if (Nam <= 0) return false;
            if (Thang <= 0 || Thang > 12) return false;
            if (Ngay < 1 || Ngay > NgayTrongThang(Thang, Nam)) return false;
            return true;
        }
        public static int NgayTrongThang(int Thang, int Nam)
        {
            int[] Ngay = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (Nam % 400 == 0 || (Nam % 4 == 0 && Nam % 100 != 0)) Ngay[2] = 29;
            return Ngay[Thang];
        }
    }
}
