using System;
using System.Linq;

namespace upr05_02RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rotating Arrays and summing them after.
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numOfRotations = int.Parse(Console.ReadLine());
            int[] sum = new int[numbers.Length];

            for (int i = 0; i < numOfRotations; i++)
            {
                numbers = Rotate(numbers);
                for (int j = 0; j < numbers.Length; j++)
                {
                    sum[j] += numbers[j];
                }
            }
            Console.WriteLine(string.Join(" ", sum));
        }

        //RotationMethod.
        static int[] Rotate(int[] num)
        {
            int[] rotated = new int[num.Length];
            int last = num[num.Length - 1];
            for (int i = 1; i < rotated.Length; i++)
            {
                rotated[i] = num[i - 1];
            }
            rotated[0] = last;
            return rotated;
        }
    }
}
