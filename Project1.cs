namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class Project1
        {
            public int a { get; set; }
            public int b { get; set; }
            public int c { get; set; }
            public int d { get; set; }
            public int e { get; set; }
            public Project1()
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Please enter a here: ");
                        this.a = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Please enter b here: ");
                        this.b = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Please enter c here: ");
                        this.c = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Please enter d here: ");
                        this.d = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Please enter e here: ");
                        this.e = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                }
                
            }
            public int Max()
            {
                int max;
                max = this.b > this.a ? this.b : this.a;
                max = this.c > max ? this.c : max;
                max = this.d > max ? this.d : max;
                max = this.e > max ? this.e : max;
                return max;
            }
        }
    }
}


