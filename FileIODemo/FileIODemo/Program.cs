using System;
using System.IO;

namespace FileIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\fellowship\DAY_15\TXt.txt";

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

            //Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
        }
            static void ReadAllText(string path)
            {
                string lines;
                lines = File.ReadAllText(path); ;
                Console.WriteLine(lines);
            }
        
    }
}
    
