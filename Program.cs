﻿using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var p48 = new P48();
            Console.WriteLine("Z= {0}",p48.Z());
        }
    }
}


