using System;

namespace NestedLoopExercise01
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
                Console.WriteLine($"Enter player {bowlerCounter}'s scores: ");
                for (int scoreCounter = 1; scoreCounter <= SCORES_PER_BOWLER; scoreCounter++)
                {
                    // Loop 2 Scores
                    Console.WriteLine($"Score #{scoreCounter}: ");
                    int inputScore = Convert.ToInt32(Console.ReadLine());
                    playerScore += inputScore;
                }
                totalTeamScore += playerScore;
                double averageScore = (double)playerScore / SCORES_PER_BOWLER;
                Console.WriteLine($"The average score for player {bowlerCounter} is {averageScore}");
            }
            // The average of averages
            averageTeamScore = totalTeamScore / (BOWLERS * SCORES_PER_BOWLER);
            Console.WriteLine($"Average team score: {averageTeamScore}");
        }
    }
}
