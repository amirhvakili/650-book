﻿using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var p49 = new P49();
            Console.WriteLine(p49.ToUpperChar());
        }
    }
}


