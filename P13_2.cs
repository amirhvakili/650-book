namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P13_2
        {
            public P13_2()
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Please enter a whole number here: ");
                        var number = Console.ReadLine();

                        string reversed = "";

                        for (var i = number.Length - 1; i >= 0; i--)
                        {
                            reversed += number[i];
                        }

                        if (Convert.ToInt64(reversed) == Convert.ToInt64(number))
                            Console.WriteLine("yes");
                        else
                            Console.WriteLine("no");
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }

            }
        }
    }
}


