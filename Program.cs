﻿using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var p1 = new P1_2();
            Console.WriteLine("The second highest average is {0} and the student's id is {1}", p1.max2, p1.id2);
        }
    }
}


