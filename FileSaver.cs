using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FileSaver
    {
        public void saveToFile(string data)  //https://stackoverflow.com/questions/2837020/open-existing-file-append-a-single-line
        {
            string path = @"D:\Asp.net\TestTask\ConsoleApp1\result.txt";

            if (File.Exists(path))
            {
                using (StreamWriter w = File.AppendText(path))
                    w.WriteLine(data);
            }
            else
            {
                using (StreamWriter writetext = new StreamWriter(path))
                    writetext.WriteLine(data);
            }
        }

        public void saveListToFile(List<long> array)
        {
            foreach (var i in array)
            {
                saveToFile(i.ToString());
            }
        }
    }
}