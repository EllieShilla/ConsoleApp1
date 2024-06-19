using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MathOperations
    {
        public double averageNum(int[] arr)
        {
            double average = 0;
            foreach (int num in arr)
                average += num;

            return average / arr.Length;
        }

        public int maxNum(int[] arr)
        {
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                    max = arr[i];
            }

            return max;
        }

        public int minNum(int[] arr)
        {
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                    min = arr[i];
            }

            return min;
        }
        public Tuple<long, long> getRowAsc(int[] arr)
        {
            int startValue = arr[0];
            int index = 0;
            int count = 0;
            int maxCount = 0;
            long maxIndexStart = 0;
            long maxIndexEnd = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (startValue <= arr[i])
                {
                    startValue = arr[i];
                    count += 1;

                    if (i == arr.Length - 1)
                    {
                        if (count >= maxCount)
                        {
                            maxCount = count;
                            maxIndexStart = index;
                            maxIndexEnd = arr.Length;
                        }
                    }
                }
                else
                {
                    if (count >= maxCount)
                    {
                        maxCount = count;
                        maxIndexStart = index;
                        maxIndexEnd = i;
                    }
                    startValue = arr[i];
                    index = i;
                    count = 0;
                }
            }

            return new Tuple<long, long>(maxIndexStart, maxIndexEnd);
        }

        public Tuple<long, long> getRowDesc(int[] arr)
        {
            int startValue = arr[0];
            int index = 0;
            int count = 0;
            int maxCount = 0;
            long maxIndexStart = 0;
            long maxIndexEnd = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (startValue >= arr[i])
                {
                    startValue = arr[i];
                    count += 1;

                    if (i == arr.Length - 1)
                    {
                        if (count >= maxCount)
                        {
                            maxCount = count;
                            maxIndexStart = index;
                            maxIndexEnd = arr.Length;
                        }
                    }
                }
                else
                {
                    if (count >= maxCount)
                    {
                        maxCount = count;
                        maxIndexStart = index;
                        maxIndexEnd = i;
                    }
                    startValue = arr[i];
                    index = i;
                    count = 0;
                }
            }

            return new Tuple<long, long>(maxIndexStart, maxIndexEnd);
        }

        public List<long> getNumberList(long startIndex, long endIndex, int[] arr)
        {
            List<long> list = new List<long>();

            for (long i = startIndex; i < endIndex; i++)
                list.Add(arr[i]);

            return list;
        }

        public double mediana(int[] arr)
        {
            int countNum = 0;
            List<int> average = new List<int>();
            int index = 0;
            double mediana = 0;
            int[] sortedArr = arr.OrderBy(n => n).ToArray(); //https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.orderby?view=net-8.0

            if ((sortedArr.Length % 2) == 0)
                countNum = 2;
            else
                countNum = 1;

            switch (countNum)
            {
                case 1:
                    index = sortedArr.Length / 2;
                    average.Add(sortedArr[index]);
                    break;
                case 2:
                    index = (sortedArr.Length / 2) - 1;
                    average.Add(sortedArr[index]);
                    average.Add(sortedArr[index + 1]);
                    break;
            }

            for (int i = 0; i < average.Count; i++)
                mediana += average[i];

            if (average.Count > 1)
                return mediana / 2;

            return mediana;
        }
    }
}