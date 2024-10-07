using System;
using System.IO;
namespace Bai02
{
    class Program
    {
        public static void Main(string[] args)
        {
            string Link;
            Console.Write("Please enter the directory path: ");
            Link = Console.ReadLine();
            DirectoryInfo direc = new DirectoryInfo(Link);
            if (direc.Exists)
            {
                Console.WriteLine("File: ");
                FileInfo[] file = direc.GetFiles();
                foreach(FileInfo fi in file)
                {
                    Console.WriteLine(fi.CreationTime+"    "+fi.Name);
                }
                DirectoryInfo[] subdir = direc.GetDirectories();
                Console.WriteLine("Subdirectory: ");
                foreach(DirectoryInfo temp in subdir)
                {
                    Console.WriteLine(temp.CreationTime+"    "+temp.Name);
                }


            }
            else
            {
                Console.WriteLine($"The directory{Link} does not exit.");
            }
        }
    }
}
