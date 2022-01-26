using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO
{
    public class Streams
    {
        public void StreamReader()
        {
            string path = @"D:\BridgeLabz\FILE_IO\File_IO\STREAM.txt";
            using(StreamReader sr=File.OpenText(path))
            {
                string s = "";
                while((s=sr.ReadLine())!=null)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public void StreamWriter()
        {
            string path= @"D:\BridgeLabz\FILE_IO\File_IO\STREAM.txt";
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("\nTHIS IS .NET");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
        }



    }
}
