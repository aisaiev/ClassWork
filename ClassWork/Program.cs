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
        private static int foldersCount = 0;
        private static void Main(string[] args)
        {
        }

        private static void FoldersCountByPathRecursion(string path)
        {
            try
            {
                foreach (var folder in Directory.GetDirectories(path))
                {
                    foldersCount++;
                    FoldersCountByPathRecursion(folder);
                }
            }
            catch (UnauthorizedAccessException)
            {
            }
        }

        private static void Task1()
        {
            const string path = @"C:\Windows\System32";
            long totalSize = 0;
            FoldersCountByPathRecursion(path);
            Console.WriteLine($"Amount of directories: {foldersCount}");
            string[] files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                totalSize += fileInfo.Length;
            }
            Console.WriteLine($"Total size of directories: {totalSize} bytes");
        }

        private static void Task2()
        {
            const string FolderPath = @"C:\Temp";
            const string FilePath = @"C:\Temp\userText.txt";
            Console.Write("Enter text: ");
            string userInput = Console.ReadLine();
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }
            File.WriteAllText(FilePath, userInput);
        }

        private static void Task3(string path)
        {
            string fileText = File.ReadAllText(path);
            int lineCount = fileText.Split(new string[] { "\r\n" }, StringSplitOptions.None).Length;
            int charactercCount = fileText.Replace(" ", "").Replace("\r\n", "").Length;
            int wordCount = fileText.Replace("\r\n", " ").Split(new string[] { " " }, StringSplitOptions.None).Length;
            Console.WriteLine($"Line count: {lineCount}");
            Console.WriteLine($"Characters count: {charactercCount}");
            Console.WriteLine($"Words count: {wordCount}");
        }
    }
}
