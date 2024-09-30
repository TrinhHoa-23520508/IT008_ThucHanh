using System;
namespace Bai01
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int n;
            Console.Write("Nhap vao so phan tu cua mang n = ");
            n = int.Parse(Console.ReadLine());
            List<int> arr = new List<int>(n);
            for (int i = 0; i < n; i++)
            {
                arr.Add(rnd.Next(100));
            }
            Console.Write("Mang vua tao la arr[] = ");
            foreach (var x in arr)
            {
                Console.Write(x + " ");
            }
            Console.Write("\nTong cac so le co trong mang la: " + TongCacSoLe(arr));
            Console.Write("\nTrong mang co tat ca la " + DemSoNguyenTo(arr) + " so nguyen to");
            if (SoChinhPhuongNhoNhat(arr) == -1) Console.Write("\nMang khong ton tai so chinh phuong!");
            else Console.Write("\nSo chinh phuong nho nhat trong mang la: " + SoChinhPhuongNhoNhat(arr));
        }
        public static bool LaSoLe(int n)
        {
            return n % 2 != 0;
        }
        public static bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0) return false;
                }
                return true;
            }
        }
        public static bool LaSoChinhPhuong(int n)
        {
            int temp = (int)Math.Sqrt(n);
            return temp * temp == n;
        }
        public static int TongCacSoLe(List<int> arr)
        {
            int Tong = 0;
            foreach (int x in arr)
            {
                if (LaSoLe(x)) Tong += x;
            }
            return Tong;

        }
        public static int DemSoNguyenTo(List<int> arr)
        {
            int count = 0;
            foreach (int x in arr)
            {
                if (LaSoNguyenTo(x)) count++;
            }
            return count;
        }
        public static int SoChinhPhuongNhoNhat(List<int> arr)
        {
            int Min = -1;
            foreach (var x in arr)
            {
                if (LaSoChinhPhuong(x))
                {
                    if (Min == -1) Min = x;
                    else
                    {
                        if (x < Min) Min = x;
                    }
                }
            }
            return Min;
        }

    }
}

