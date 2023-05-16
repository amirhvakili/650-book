﻿using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var p47 = new P47();
            Console.WriteLine("The total distance is {0} meters and {1} kilometers.", p47.TotalDistanceInMeters(), p47.TotalDistanceInMeters() / 1000);
        }
    }
}


