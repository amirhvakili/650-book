using System.Text.RegularExpressions;

namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P49
        {
            public string letter { get; set; }
            public P49()
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Please enter a letter from a to z here (Make sure the letter is in lower case): ");
                        this.letter = Console.ReadLine();
                        if (this.letter.Length != 1 || !Regex.IsMatch(this.letter, @"^[a-z]+$"))
                        {
                            throw new Exception();
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter the corrected input.");
                    }
                }
            }
            public char ToUpperChar()
            {
                var character = new List<char>();
                foreach (char c in this.letter)
                {
                    character.Add(c);
                }
                return (char)(character[0] - 32);
            }
        }
    }
}


