//Write a program that reads two integer numbers N and K and an array of N elements from the console. Find the maximal sum of K elements in the array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalKSum
{
    class MaximalKSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] arrayNumbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                arrayNumbers[i] = int.Parse(Console.ReadLine());
            }

            int maxSum = 0;

            Array.Sort(arrayNumbers);
            Array.Reverse(arrayNumbers);

            for (int i = 0; i < k; i++)
            {
                maxSum += arrayNumbers[i];
            }

            Console.WriteLine(maxSum);

        }
    }
}

