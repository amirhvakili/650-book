using System.Diagnostics.CodeAnalysis;

namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P15
        {
            public P15()
            {
                Console.Write("How many numbers do you want to check: ");
                var n = Convert.ToInt64(Console.ReadLine());

                for(var i = 0; i < n; i++)
                {
                    Console.Write("Enter number: ");
                    var number = Convert.ToInt64(Console.ReadLine());

                    var temp = number;
                    long sum = 0;

                    while(temp > 0)
                    {
                        sum += temp % 10;
                        temp /= 10;
                    }

                    if(sum % 9 == 0)
                        Console.WriteLine(number);
                }
            }
        }
    }
}


