namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P55
        {
            public float h { get; private set; }
            public float p { get; private set; }
            public P55()
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Please enter h here: ");
                        h = Convert.ToSingle(Console.ReadLine());
                        if(h < 0)
                        {
                            throw new Exception();
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid input.");
                    }
                }
                while(true)
                {
                    try
                    {
                        Console.Write("Please enter p here: ");
                        p = Convert.ToSingle(Console.ReadLine());
                        if(p < 0)
                        {
                            throw new Exception();
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid input.");
                    }
                }
            }
            public float S()
            {
                return this.h * this.p / 2;
            }
        }
    }
}


