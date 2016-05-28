using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.Replace("\\", string.Empty);
            string result = input.PadRight(20, '*');
            Console.WriteLine(result);
        }
    }
}
