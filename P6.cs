namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P6
        {
            public P6 ()
            {
                string response;
                do
                {
                    Console.Write("Please enter the amount of money that the customer wants here: ");
                    var customersRequiredMoney = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Please enter the number of installments here: ");
                    var numberOfInstallments = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Please enter the interest rate here: ");
                    var interestRate = Convert.ToSingle(Console.ReadLine());

                    var totalMoney = 12 * customersRequiredMoney / (12 - numberOfInstallments * interestRate / 100);
                    var moneyPerMonth = totalMoney / numberOfInstallments;

                    Console.WriteLine("Total money = {0}, Money_To_Pay_Per_Month = {1}", totalMoney, moneyPerMonth);

                    Console.Write("Do you want to continue? Please answer yes or no here: ");
                    response = Console.ReadLine().ToLower();
                }
                while (response == "yes");
            }
        }
    }
}


