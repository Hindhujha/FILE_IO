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
            ReadAllLines();
            ReadAllTexts();
            CopyFile();
            DeleteFile();
            Console.WriteLine("*****************************************************");
            Console.WriteLine("STREAM READER: ");
            Streams readwrite =new Streams();
            readwrite.StreamReader();
        }

        public static void FileExists()
        {
            string path = @"D:\SAMPLE.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("FILE IS EXISTS");
            }
        }

        public static void ReadAllLines()
        {
            string path = @"D:\SAMPLE.txt";
            string[] allLines;
            allLines = File.ReadAllLines(path);
            Console.WriteLine(allLines[0]);
            Console.WriteLine(allLines[2]);
        }

        public static void ReadAllTexts()
        {
            string path = @"D:\SAMPLE.txt";
            string allTexts = File.ReadAllText(path);

            Console.WriteLine(allTexts);
        }

        public static void CopyFile()
        {
            string path = @"D:\SAMPLE.txt";
            string copyPath = @"D:\BridgeLabz\SAMPLENEW.txt";
            File.Copy(path, copyPath);
        }

        public static void DeleteFile()
        {
            string path= @"D:\BridgeLabz\DEMO.txt";
            File.Delete(path);
        }

    }
}
