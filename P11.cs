namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P11
        {
            public P11()
            {
                float s = 0;

                Console.Write("Please enter x here: ");
                int x = Convert.ToInt32(Console.ReadLine());

                float sum = 0;

                for (var i = 1; i <= 10; i++)
                {
                    sum += i * (float)Math.Pow(x, i);

                    if (i % 2 == 0)
                    {
                        s -= 1 / sum;
                    }
                    else
                    {
                        s += 1 / sum;
                    }
                }
                Console.WriteLine("s = {0}", s);
            }
        }
    }
}


