using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void Task1()
        {
            const string PATH = @"C:\Windows\System32";
            long totalSize = 0;
            string[] directories = Directory.GetDirectories(PATH);
            Console.WriteLine($"Amount of directories: {directories.Length}");
            string[] files = Directory.GetFiles(PATH);
            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                totalSize += fileInfo.Length;
            }
            Console.WriteLine($"Total size of directories: {totalSize} bytes");
        }
    }
}
