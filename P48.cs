namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P48
        {
            public int x { get; set; }
            public int y { get; set; }
            public P48()
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Please enter x here: ");
                        this.x = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter the correct input.");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.Write("Please enter y here: ");
                        this.y = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter the correct input.");
                    }
                }
            }
            public int Z()
            {
                return this.x++ * y / x++;
            }
        }
    }
}


