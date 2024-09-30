using System;
namespace Bai6
{
    public class Programe
    {
        public static void Main(string[] args)
        {
            int n = 0;
            int m = 0;
            int[,] arr  = null;
            NhapMang(ref arr, ref n, ref m);
            XuatMang(arr, n, m);
            Console.Write("\nPhan tu nho nhat trong mang la: " + PhanTuNhoNhat(arr, n, m));
            Console.Write("\nDong co tong lon nhat la dong: " + DongCoTongLonNhat(arr, n, m));
            Console.Write("\nTong cac so nguyen to co trong mang la: " + TinhTongCacSoKhongPhaiNguyenTo(arr, n, m));




        }
        public static void NhapMang(ref int[,] arr,ref  int n,ref  int m)
        {
            Console.Write("\nHay nhap vao so hang n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("\nHay nhap vao so cot m = ");
            m = int.Parse(Console.ReadLine());
            arr = new int[n, m];
            Console.WriteLine("\nNhap vao cac phan tu cua mang: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public static void XuatMang(int[,] arr, int n, int m)
        {
            Console.Write("\nCac phan tu cua mang la arr: \n");
            for(int i = 0; i<n; i++)
            {
                for(int j = 0; j<m; j++)
                {
                    Console.Write(arr[i, j]+" ");
                }
                Console.Write("\n");
            }    
        }
        public static int PhanTuNhoNhat(int[,] arr, int n, int m)
        {
            int min = arr[0, 0];
            for(int i = 0; i<n; i++)
            {
                for(int j = 0; j<m; j++)
                {
                    if (arr[i, j] < min) min = arr[i, j];
                }
            }
            return min;
        }
        public static int DongCoTongLonNhat(int[,] arr, int n, int m)
        {
            int Tong ;
            int Max = 0;
            int index = 0;
            for(int i = 0; i<n; i++)
            {
                Tong = 0;
                for(int j = 0; j<m; j++)
                {
                    Tong += arr[i, j];
                }
                if(Tong>Max)
                {
                    Max = Tong;
                    index = i;
                }

            }
            return index+1;
        }
        public static bool LaSoNguyenTo(int x)
        {
            if (x < 2) return false;
            for(int i = 2; i<=Math.Sqrt(x); i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
        public static int TinhTongCacSoKhongPhaiNguyenTo(int[,] arr, int n, int m)
        {
            int Tong = 0;
            for(int i = 0; i<n; i++)
            {
                for(int j = 0; j<m; j++)
                {
                    if (!LaSoNguyenTo(arr[i,j])) Tong += arr[i, j];
                }
            }
            return Tong;
        }

    }
}
  