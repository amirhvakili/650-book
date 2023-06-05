using System.Diagnostics.CodeAnalysis;

namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P20
        {
            public P20()
            {
                for (var i = 1000; i <= 1100; i++)
                {
                    var n = i;
                    var sum = 0;

                    while(n != 0)
                    {
                        sum += n % 10;
                        n /= 10;
                    }
                    
                    if(sum % 9 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}

