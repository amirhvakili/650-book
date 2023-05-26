namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P7
        {
            public P7()
            {
                string response;
                do
                {
                    Console.Write("Please enter a number here: ");
                    var number = Console.ReadLine();

                    Console.WriteLine("Integer Part = {0}, Decimal Part = {1}", number.Split('.')[0], number.Split('.')[1]);

                    Console.Write("Do you want to continue: ");
                    response = Console.ReadLine().ToLower();
                }
                while(response == "yes");
            }
        }
    }
}


