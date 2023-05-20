namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class Project2
        {
            public int Number { get; set; }
            public Project2()
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Please enter a 5 digit number here: ");
                        this.Number = Convert.ToInt32(Console.ReadLine());
                        if(this.Number < 10000 || this.Number > 99999)
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
            public string Digits()
            {
                var number = Convert.ToString(this.Number);
                return number[0] + " " + number[1] + " " + number[2] + " " + number[3] + " " + number[4];
            }
        }
    }
}


