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
        static int foldersCount = 0;
        static void Main(string[] args)
        {
        }

        static void FoldersCountByPathRecursion(string path)
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

        static void Task1()
        {
            const string PATH = @"C:\Windows\System32";
            long totalSize = 0;
            FoldersCountByPathRecursion(PATH);
            Console.WriteLine($"Amount of directories: {foldersCount}");
            string[] files = Directory.GetFiles(PATH);
            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                totalSize += fileInfo.Length;
            }
            Console.WriteLine($"Total size of directories: {totalSize} bytes");
        }

        static void Task2()
        {
            const string FOLDER_PATH = @"C:\Temp";
            const string FILE_PATH = @"C:\Temp\userText.txt";
            Console.Write("Enter text: ");
            string userInput = Console.ReadLine();
            if (!Directory.Exists(FOLDER_PATH))
            {
                Directory.CreateDirectory(FOLDER_PATH);
            }
            File.WriteAllText(FILE_PATH, userInput);
        }

        static void Task3(string path)
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
