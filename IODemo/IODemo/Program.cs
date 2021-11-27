using System;
using System.IO;

namespace FileDemoIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\fellowship\DAY_15\TXt.txt";
            string path1 = @"E:\fellowship\DAY_15\TXt.txt1";
            Program.FileCopy(path, path1);

            Console.ReadKey();
        }
        static void FileExists(string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                Console.WriteLine("File NOt Exists");
            }
        }
        static void ReadAlllines(string path)
        {

            string[] lines;
            lines = File.ReadAllLines(path);

            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
        }
        static void ReadAllText(string path)
        {
            string lines;
            lines = File.ReadAllText(path); ;
            Console.WriteLine(lines);
        }
        static void FileCopy(string path, string path1)
        {
            File.Copy(path, path1);
            Console.WriteLine("=============");
            Console.ReadKey();
        }

    }
}