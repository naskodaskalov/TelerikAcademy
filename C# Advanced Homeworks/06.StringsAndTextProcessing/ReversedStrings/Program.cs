using System;
using System.Linq;

namespace ReversedString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join("", Console.ReadLine().Reverse()));
        }
    }
}