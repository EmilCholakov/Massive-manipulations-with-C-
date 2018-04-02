using System;
using System.Linq;

namespace upr05_06MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 1;
            int counterMax = 0;
            int numberMax = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    counter++;
                }
                else
                {
                if (counter > counterMax)
                {
                    counterMax = counter;
                    numberMax = arr[i];
                }
                counter = 1;
                }
                if (i + 1 == arr.Length - 1)
                {
                    if (counter > counterMax)
                    {
                    counterMax = counter;
                    numberMax = arr[i];
                    }
                counter = 1;
                }
            }
            for (int i = 0; i < counterMax; i++)
            {
                Console.Write(numberMax + " ");
            }
        }
    }
}
