using System;
using System.IO;
namespace File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO FILE IO PROGRAMS");
            FileExists();
        }

        public static void FileExists()
        {
            string path = @"D:\SAMPLE.txt";
            if(File.Exists(path))
            {
                Console.WriteLine("FILE IS EXISTS");
            }
            Console.ReadLine();
        }
    }
}
