using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var p55 = new P55();
            Console.WriteLine("The area of the triangle is: {0}", p55.S());
        }
    }
}


