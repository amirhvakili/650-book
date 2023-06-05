using System.Security.Cryptography.X509Certificates;

namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P23
        {
            public P23()
            {
                Console.Write("Please enter your number your: ");
                var n = Convert.ToInt32(Console.ReadLine());

                float sum = (float)1 / (float)this.Factorial(n);

                for(var i = 1; i < n; i++)
                {
                    sum += (float)1 / (float)this.Factorial(i);
                }
                Console.WriteLine(sum);
            }

            public int Factorial(int number)
            {
                var result = number;
                for(var i = 1; i < number; i++)
                {
                    result *= i;
                }
                return result;
            }
        }
    }
}

