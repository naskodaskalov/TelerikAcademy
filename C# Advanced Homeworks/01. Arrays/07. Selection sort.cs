//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(arr[j]);
            }
        }
    }
}
