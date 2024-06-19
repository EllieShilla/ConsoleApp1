using System.Numerics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileReader fileReader = new FileReader();
            int[] randomNumbers = fileReader.readFile();

            FileSaver fileSaver= new FileSaver();
            MathOperations mathOperations= new MathOperations();

            fileSaver.saveToFile("\nМаксимальне число в файлі: " + mathOperations.maxNum(randomNumbers));
            fileSaver.saveToFile("\nМінімальне число в файлі: " + mathOperations.minNum(randomNumbers));
            fileSaver.saveToFile("\nМедіана: " + mathOperations.mediana(randomNumbers));
            fileSaver.saveToFile("\nСереднє арифметичне значення: " + mathOperations.averageNum(randomNumbers));

            Tuple<long, long> average = mathOperations.getRowAsc(randomNumbers);
            List<long> resultList = mathOperations.getNumberList(average.Item1, average.Item2, randomNumbers);

            fileSaver.saveToFile("\nНайбільшу послідовність чисел (які ідуть один за одним), яка збільшується:");
            fileSaver.saveListToFile(resultList);

            resultList.Clear();

            average = mathOperations.getRowDesc(randomNumbers);
            resultList = mathOperations.getNumberList(average.Item1, average.Item2, randomNumbers);

            fileSaver.saveToFile("\nНайбільшу послідовність чисел (які ідуть один за одним), яка зменшується:");
            fileSaver.saveListToFile(resultList);
        }
    }
}