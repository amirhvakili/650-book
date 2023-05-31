namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P13_1
        {
            public P13_1()
            {
                long number = Convert.ToInt64 (Console.ReadLine());

                long temp = number;

                long reversed = 0;

                int i = 0;

                while(temp != 0)
                {
                    reversed += (temp % 10) * (long)Math.Pow(10,i);
                    temp /= 10;
                    i++;
                }

                if(number == reversed)
                    Console.WriteLine("yes");
                else
                    Console.WriteLine("no");
            }
        }
    }
}


