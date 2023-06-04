namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P18
        {
            public P18()
            {
                var counter = 7;

                for (var i = 1; i <= 7; i++)
                {
                    for (var j = counter; j > 0; j--)
                    {
                        Console.Write(j + " ");
                    }
                    counter--;
                    Console.WriteLine();
                }
            }
        }
    }
}

