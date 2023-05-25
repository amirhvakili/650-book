namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P4
        {
            public P4()
            {
                float max = 0;
                int Id = 0;
                Console.Write("Please enter the number of employees: ");
                var numberOfEmployees = Convert.ToInt32(Console.ReadLine());

                for(var i = 1; i <= numberOfEmployees; i++)
                {
                    Console.Write("ID = ");
                    var id = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Salary = ");
                    var salary = Convert.ToSingle(Console.ReadLine());

                    float tax;
                    float pay;

                    if (salary < 400000)
                        tax = 0;

                    else if(salary >= 400001 && salary < 500000)
                        tax = (float)(salary - 0.1 * salary);
                    
                    else if(salary >= 500000 && salary < 700000)
                        tax = (float)((500000 - 400001) * 0.1 + (salary - 500001) * 0.15);

                    else
                        tax = (float)((500000 - 400001) * 0.1 + (salary - 500001) * 0.15 + (salary - 700001) * 0.17);

                    pay = salary - tax;

                    if(pay > max)
                    {
                        max = pay;
                        Id = id;
                    }
                }
                Console.WriteLine("Maximum pay = {0}, ID = {1}", max, Id);
            }
        }
    }
}


