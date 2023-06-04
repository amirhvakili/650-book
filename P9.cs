namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P9
        {
            public P9()
            {
                Console.Write("Please enter the number of employees here: ");
                var numberOfEmployees = Convert.ToInt32(Console.ReadLine());

                for (var i = 0; i < numberOfEmployees; i++)
                {
                    Console.Write("Please enter employee's ID here: ");
                    var id = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Please enter hourly wage here: ");
                    var hourlyWage = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Please enter the number of hours the employee has worked here: ");
                    var numberOfHours = Convert.ToInt32(Console.ReadLine());

                    var totalMoney = hourlyWage * numberOfHours;

                    if (numberOfHours > 40)
                    {
                        var extra = 0.5 * hourlyWage * (numberOfHours - 40);
                        Console.WriteLine("The total money for this employee is: {0}", totalMoney + extra);
                    }
                    else
                    {
                        Console.WriteLine("The total money paid to this employee is: {0}", totalMoney);
                    }
                }
            }
        }
    }
}


