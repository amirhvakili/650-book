using System.Security.Cryptography.X509Certificates;

namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P22
        {
            public P22()
            {
                Console.Write("Enter the first number here: ");
                var x = Convert.ToInt64(Console.ReadLine());

                Console.Write("Enter the second number here: ");
                var y = Convert.ToInt64(Console.ReadLine());

                var max = x > y ? x : y;
                var min = x < y ? x : y;
                var result = max - min;

                var i = 0;

                while(result > 0)
                {
                    i++;
                    result -= min;
                }

                Console.WriteLine("{0} / {1} = {2}",max, min, i);
                
            }
        }
    }
}

