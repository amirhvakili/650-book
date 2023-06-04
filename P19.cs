namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P19
        {
            public P19()
            {
                Console.Write("How many times to play: ");
                var n = Convert.ToByte(Console.ReadLine());

                var player1Score = 0;
                var player2Score = 0;

                for (var i = 0; i < n; i++)
                {
                    Console.Write("Player 1 choose: ");
                    var player1schoice = Console.ReadLine();

                    Console.Write("Player 2 choose: ");
                    var player2schoice = Console.ReadLine();

                    if (
                        (player1schoice.ToLower() == "stone" && player2schoice.ToLower() == "scissors") ||

                        (player1schoice.ToLower() == "scissors" && player2schoice.ToLower() == "paper") ||

                        (player1schoice.ToLower() == "paper" && player2schoice.ToLower() == "stone")
                       )
                    {
                        player1Score++;
                        Console.WriteLine("Player 1 won this round.");
                    }

                    else if (
                                (player2schoice.ToLower() == "stone" && player1schoice.ToLower() == "scissors") ||

                                (player2schoice.ToLower() == "scissors" && player1schoice.ToLower() == "paper") ||

                                (player2schoice.ToLower() == "paper" && player1schoice.ToLower() == "stone")
                           )
                    {
                        player2Score++;
                        Console.WriteLine("Player 2 won this round.");
                    }
                    else
                        Console.WriteLine("Equal.");
                }

                if (player1Score > player2Score)
                    Console.WriteLine("player 1 is our winner.");
                else if (player2Score > player1Score)
                    Console.WriteLine("player 2 is our winner.");
                else
                    Console.WriteLine("No one won the match.");
            }
        }
    }
}

