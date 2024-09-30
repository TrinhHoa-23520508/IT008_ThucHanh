using System;
namespace Bai02
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap vao so nguyen duong n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("\nTong cac so nguyen to nho hon n la: " + TongCacSoNguyenToNhoHonN(n));

        }
        public static bool LaSoNguyenTo(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
        public static int TongCacSoNguyenToNhoHonN(int n)
        {
            int Tong = 0;
            for (int i = 2; i < n; i++)
            {
                if (LaSoNguyenTo(i)) Tong += i;
            }
            return Tong;
        }
    }
}