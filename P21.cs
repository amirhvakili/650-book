namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P21
        {
            public P21()
            {

                while(true)
                {
                    Console.Write("Please enter a key on your keyboard: ");
                    var userInput = Console.ReadKey().Key.ToString().ToLower();
                    Console.WriteLine();

                    switch (userInput)
                    {
                        case "w":
                            Console.WriteLine("You love white");
                            break;
                        case "y":
                            Console.WriteLine("You love yellow");
                            break;
                        case "r":
                            Console.WriteLine("You love red");
                            break;
                        case "b":
                            Console.WriteLine("Youlove blue");
                            break;
                        case "g":
                            Console.WriteLine("You love green");
                            break;
                        case "e":
                            break;
                        default:
                            Console.WriteLine("No color is chosen");
                            break;
                    }
                    if (userInput == "e")
                        break;
                    else
                        continue;
                }
                
            }
        }
    }
}

