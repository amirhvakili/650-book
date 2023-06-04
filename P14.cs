namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P14
        {
            public P14()
            {
                Console.Write("Please insert m here: ");
                var m = Convert.ToInt64(Console.ReadLine());

                Console.Write("Please insert n here: ");
                var n = Convert.ToInt64(Console.ReadLine());

                long temp = m;
                long sum = 0;

                for (var i = 1; i < n; i++)
                {
                    sum = 0;

                    for (var j = 1; j <= m; j++)
                    {
                        sum += temp;
                    }

                    temp = sum;
                }
                Console.WriteLine("{0} ^ {1} = {2}", m, n, sum);
            }
        }
    }
}


