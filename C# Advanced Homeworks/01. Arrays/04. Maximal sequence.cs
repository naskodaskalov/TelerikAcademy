//Write a program that finds the length of the maximal sequence of equal elements in an array of N integers.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            numbers[0] = int.Parse(Console.ReadLine());
            int maxSequence = 0;
            int currentSequence = 1;

            for (int i = 1; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                if (numbers[i] == numbers[i-1])
                {
                    currentSequence += 1;
                    maxSequence = Math.Max(currentSequence, maxSequence);
                } else
                {
                    currentSequence = 1;
                }
            }
            Console.WriteLine(maxSequence);

        }
    }
}
