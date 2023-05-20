namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P53
        {
            public int x { get; private set; }
            public int y { get; private set; }
            public P53()
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Please enter x here (must be an integer number): ");
                        x = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.Write("Please enter y here (must be an integer number): ");
                        y = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                }
            }
            public void ReversingValues()
            {
                this.x = this.x + this.y;
                this.y = this.x - this.y;
                this.x = this.x - this.y;
            }
        }
    }
}


