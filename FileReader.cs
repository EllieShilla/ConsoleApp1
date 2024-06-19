namespace ConsoleApp1
{
    public class FileReader
    {
        public int[] readFile()  //https://www.codeproject.com/Questions/1252879/Text-file-read-into-arrays
        {
            int[] arrNumbers = File.ReadLines(@"D:\Asp.net\TestTask\ConsoleApp1\10m.txt").Select(line => int.Parse(line)).ToArray();

            return arrNumbers;
        }
    }
}