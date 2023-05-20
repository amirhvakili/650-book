using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var project1 = new Project1();
            Console.WriteLine("The maximum number is {0}", project1.Max());
        }
    }
}


