//Write a program that reads two integer arrays of size N from the console and compares them element by element.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArr = new int[n];
            int[] secondArr = new int[n];

            //enter numbers in first array
            for (int i = 0; i < n; i++)
            {
                firstArr[i] = int.Parse(Console.ReadLine());
            }

            //enter numbers in second array
            for (int j = 0; j < n; j++)
            {
                secondArr[j] = int.Parse(Console.ReadLine());
            }

            //compare the numbers in both arrays
            bool isEqual = false;
            for (int l = 0; l < n; l++)
            {
                if (firstArr[l] == secondArr[l])
                {
                    isEqual = true;
                } else
                {
                    isEqual = false;
                    break;
                }
            }
            Console.WriteLine(isEqual ? "Equal" : "Not equal");
        }
    }
}
