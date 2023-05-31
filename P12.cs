namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P12
        {
            public P12()
            {
                
                int x;
                int y;
                var result = 0;

                do
                {
                    Console.Write("Enter your first number here: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    
                    Console.Write("Enter your second number here: ");
                    y = Convert.ToInt32(Console.ReadLine());

                    if (x == 0 && y == 0)
                        break;

                    for (var i = 1; i <= y; i++)
                    {
                        result += x;
                    }

                    Console.WriteLine("{0} multiplied by {1} equals = {2}", x, y, result);
                }
                while (true);
            }
        }
    }
}


