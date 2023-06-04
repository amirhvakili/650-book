namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P3
        {
            public P3()
            {
                int first = 1;
                int second = 1;
                int sum = 0;

                Console.Write("Please enter N here: ");
                var n = Convert.ToInt32(Console.ReadLine());

                if (n == 1)
                {
                    Console.Write("The first N numbers of the fibunacci series are as follows: ");
                    Console.WriteLine(first);
                }
                else if (n == 2)
                {
                    Console.Write("The first N numbers of the fibunacci series are as follows: ");
                    Console.Write(first + " ");
                    Console.WriteLine(second);
                }
                else
                {
                    Console.Write("The first N numbers of the fibunacci series are as follows: ");
                    Console.Write(first + " ");
                    Console.Write(second + " ");
                    for (var i = 3; i <= n; i++)
                    {
                        sum = first + second;
                        first = second;
                        second = sum;
                        Console.Write(sum + " ");
                    }
                }
            }
        }
    }
}


