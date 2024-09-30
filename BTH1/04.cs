//Viết chương trình nhập vào tháng năm in ra số ngày của tháng đó
using System;
namespace Bai04
{
    class Program
    {
        public static void Main(string[] args)
        {
            int Thang;
            int Nam;
            Console.Write("Nhap vao thang: ");
            Thang = int.Parse(Console.ReadLine());
            Console.Write("\nNhap vao nam: ");
            Nam = int.Parse(Console.ReadLine());
            Console.Write("\nSo ngay cua thang do la: " + NgayTrongThang(Thang, Nam) + " ngay");
        }
        public static int NgayTrongThang(int Thang, int Nam)
        {
            int[] Ngay = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (Nam % 400 == 0 || (Nam % 4 == 0 && Nam % 100 != 0)) Ngay[2] = 29;
            return Ngay[Thang];
        }
    }
}
