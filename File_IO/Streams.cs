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
            string path = @"D:\BridgeLabz\.vs\STREAM.txt";
            using(StreamReader sr=File.OpenText(path))
            {
                string s = "";
                while((s=sr.ReadLine())!=null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
