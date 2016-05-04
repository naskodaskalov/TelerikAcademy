//Write a program that compares two char arrays lexicographically (letter by letter).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] firstText = Console.ReadLine().ToCharArray();
            char[] secondText = Console.ReadLine().ToCharArray();

            bool areEqual = true;
            string result = string.Empty;

            if (firstText.Length != secondText.Length)
            {
                areEqual = false;
                result = (firstText.Length < secondText.Length) ? "<" : ">";
            } else
            {
                for (int i = 0; i < firstText.Length; i++)
                {
                    if (firstText[i] != secondText[i])
                    {
                        areEqual = false;
                        result = (firstText[i] < secondText[i]) ? "<" : ">";
                        break;
                    } 
                }
            }

            Console.WriteLine(areEqual ? "=" : result);
        }
    }
}
