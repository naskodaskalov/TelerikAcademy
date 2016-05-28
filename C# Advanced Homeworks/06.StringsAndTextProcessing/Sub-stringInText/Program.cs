﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Sub_stringInText
{

    class Sub_stringInText
    {
        static void Main(string[] args)
        {
            string search = Console.ReadLine();
            string input = Console.ReadLine();
            int numberOfOccurences = 0;
            for (int i = 0; i < input.Length - search.Length + 1; i++)
            {
                if (input.Substring(i, search.Length).Equals(search, StringComparison.OrdinalIgnoreCase))
                {
                    numberOfOccurences++;
                }
            }

            Console.WriteLine(numberOfOccurences);
        }
    }
}