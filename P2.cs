namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P2
        {
            public P2()
            {
                while (true)
                {
                    Console.Write("Please enter your number here: ");
                    var number = Convert.ToInt32(Console.ReadLine());
                    var sum = 0;

                    for(var i = 1; i < number; i++)
                    {
                        if(number % i == 0)
                        {
                            sum += i;
                        }
                    }
                    if(sum == number)
                    {
                        Console.WriteLine("Perfected");
                        Console.Write("Do you want to continue? (Please answer with yes or no) ");
                        var response = Console.ReadLine();

                        if (response.ToLower() == "yes")
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not Perfected");
                        Console.Write("Do you want to continue? (Please answer with yes or no) ");

                        var response = Console.ReadLine();
                        if(response.ToLower() == "no")
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}


