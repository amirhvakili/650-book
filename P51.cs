namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P51
        {
            public int x { get; private set; }
            public int y { get; private set; }
            public P51()
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Please enter x here (must be integer): ");
                        x = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid input.");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.Write("Please enter y here (must be integer): ");
                        y = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid input.");
                    }
                }
            }

            public int Z()
            {
                return x * x * x + 2 * x * x + 3 * y - 5;
            }
        }
    }
}


