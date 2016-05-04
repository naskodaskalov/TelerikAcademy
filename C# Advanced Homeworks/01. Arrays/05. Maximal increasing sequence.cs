//Write a program that finds the length of the maximal increasing sequence in an array of N integers

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalIncreasingSequence
{
    class MaximalIncreasingSequence
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int[] numbers = new int[length];
            
            for (int i = 0; i < length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int maxSequence = 1;
            int firstNumber = numbers[0];
            int currentSequence = 1;

            for (int i = 1; i < length; i++)
            {
                if (numbers[i] > firstNumber)
                {
                    currentSequence++;
                }
                else
                {
                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                    }

                    firstNumber = numbers[i];
                    currentSequence = 1;
                }
            }

            if (currentSequence > maxSequence)
            {
                maxSequence = currentSequence;
            }

            Console.WriteLine(maxSequence);
        }
    }
}
