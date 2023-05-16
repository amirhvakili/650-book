namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P50
        {
            public char Letter { get; set; }
            public P50()
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Please enter a character here: ");
                        this.Letter = char.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter only one charachter here.");
                    }
                }
            }
            public bool BetweenZeroAndNine()
            {
                if(Char.GetNumericValue(this.Letter) >= 0 && Char.GetNumericValue(this.Letter) <= 9)
                {
                    return true;
                }
                return false;
            }
        }
    }
}


