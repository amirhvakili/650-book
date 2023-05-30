namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P10
        {
            public P10()
            {
                Console.Write("Please enter the price of the prodcut for this year here: ");
                var price = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please enter the inflation rate here: ");
                var inflationRate = Convert.ToSingle(Console.ReadLine()) / 100;

                Console.Write("Please enter the number of years here: ");
                var numberOfYears = Convert.ToInt32(Console.ReadLine());

                for(var i = 1; i <= numberOfYears ; i++)
                {
                    price += (int)(price * inflationRate);
                    Console.WriteLine("The price of the product in {0} years from now is {1}", i, price);
                }
            }
        }
    }
}


