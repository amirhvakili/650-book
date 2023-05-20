namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P52
        {
            public float grade { get; private set; }
            public P52()
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Please enter student's grade here (must be between 0 and 20): ");
                        grade = Convert.ToSingle(Console.ReadLine());
                        if(grade < 0 || grade > 20)
                        {
                            throw new Exception();
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid input");
                    }
                }
                
            }
            public string Evaluate()
            {
                return this.grade < 10 ? "Failed" : "Passed";
            }
        }
    }
}


