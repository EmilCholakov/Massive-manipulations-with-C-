using System;
using System.Linq;

namespace upr05_01LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordsOne = Console.ReadLine().Split(' ').ToArray();
            string[] wordsTwo = Console.ReadLine().Split(' ').ToArray();
            int leftCount = 0;
            int rightCount = 0;

            for (int i = 0; i < Math.Min(wordsOne.Length, wordsTwo.Length); i++)
            {
                if (wordsOne[i] == wordsTwo[i])
                {
                    leftCount++;
                }
                else
                {
                    break;
                }
            }
            for (int i = 0; i < Math.Min(wordsOne.Length, wordsTwo.Length); i++)
            {
                if (wordsOne[wordsOne.Length - 1 - i] == wordsTwo[wordsTwo.Length - 1 - i])
                {
                    rightCount++;
                }
                else
                {
                    break;
                }
            }
            if (leftCount > rightCount)
            {
                Console.WriteLine(leftCount);
            }
            else
            {
                Console.WriteLine(rightCount);
            }
        }
    }
}
