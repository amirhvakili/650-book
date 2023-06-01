namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P16
        {
            public P16()
            {
                Console.Write("Please enter the number of employees in the organization: ");
                var n = Convert.ToInt64(Console.ReadLine());

                var sum_m = 0;
                var sum_w = 0;
                long sum_salary_m = 0;
                long sum_salary_w = 0;

                for (var i = 0; i < n; i++)
                {
                    Console.Write("Please enter the gender here: ");
                    var m_w = Convert.ToByte(Console.ReadLine());

                    Console.Write("Please enter salary here: ");
                    var salary = Convert.ToInt64(Console.ReadLine());

                    if (m_w == 1)
                    {
                        sum_m++;
                        sum_salary_m += salary;
                    }
                    else
                    {
                        sum_w++;
                        sum_salary_w += salary;
                    }
                }

                Console.WriteLine("Number of men = {0}, Number of women = {1}, Average salary for men = {2}, Average salary for women = {3}", sum_m, sum_w, sum_salary_m / sum_m, sum_salary_w / sum_w);

            }
        }
    }
}


