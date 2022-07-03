using System;

namespace NestedLoopExercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalTeamScore = 0;
            double averageTeamScore;
            const int BOWLERS = 5;
            const int SCORES_PER_BOWLER = 3;


            // Loop 1: Bowlers
            for (int bowlerCounter = 1; bowlerCounter <= BOWLERS; bowlerCounter++)
            {
                int playerScore = 0;
                
                Console.WriteLine($"Enter player {bowlerCounter}'s 1st game score: ");
                playerScore += Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Enter player {bowlerCounter}'s 2nd game score: ");
                playerScore += Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Enter player {bowlerCounter}'s 3rd game score: ");
                playerScore += Convert.ToInt32(Console.ReadLine());

                totalTeamScore += playerScore;
                double averageScore = (double)playerScore / SCORES_PER_BOWLER;
                Console.WriteLine();
                Console.WriteLine($"The average score for player {bowlerCounter} is {averageScore:N2}");
            }
            // The average of averages
            averageTeamScore = totalTeamScore / (BOWLERS * SCORES_PER_BOWLER);
            Console.WriteLine($"Average team score: {averageTeamScore:N2}");
        }
    }
}
