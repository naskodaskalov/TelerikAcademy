﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseURL
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = Console.ReadLine();
            Console.WriteLine(UrlParser(url));
        }

        private static string UrlParser(string url)
        {
            Uri uri = new Uri(url);

            string server = uri.Host;
   
            string protocol = uri.Scheme;

            string resource = uri.LocalPath;

            StringBuilder result = new StringBuilder();
            result.Append("[protocol] = ")
                  .Append(protocol + "\n")
                  .Append("[server] = ")
                  .Append(server + "\n")
                  .Append("[resource] = ")
                  .Append(resource + "\n");
            return result.ToString();
        }
    }
}
