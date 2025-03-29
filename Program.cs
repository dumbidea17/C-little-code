using System;

public class Program
{
    // function == method
    // tester method-> allows you to write and see code on the output/console
    public static void Main(string[] args)
    {
        // title
        Console.WriteLine("---------------------");
        Console.WriteLine("Han, Paper, Scissors!");
        Console.WriteLine("---------------------");
        Console.WriteLine(" ");
        Console.WriteLine("do you want to play the game?(type yes to start)");
        string playGame = Console.ReadLine();
        if (playGame == "yes")
        {
            Console.WriteLine("perfect.");
        }
        else
        {
            Console.WriteLine("WRONG ANSWER. you will play the game.");
        }
        int cpuPoints = 0;
        int points = 0;
        while ((points <= 3) && (cpuPoints <= 3))
        {
            // code to store players choice.  
            Console.WriteLine("which do your pick, rock, paper, or scissor! (pick bellow)");
            string response = Console.ReadLine();
            // string[] means list, this has all the ai choices.
            string[] cpuChoice = { "rock", "paper", "scissor" };
            //This picks the ai's choice. New make a new object(make an object class). We can use this object as a key for the random class. 
            Random rand = new Random();
            //This make the range at which the cpu can pick from.

            int cpuPick = rand.Next(0, 3);
            //This line prints the cpu's choice and 
            Console.WriteLine(cpuChoice[cpuPick]);
            //and in c# is && 
            //If one of them is false the whole thing fails.
            //or is ||
            // checks if the cpu and the player ties, uses cpuChoice[cpuPick] so they are both strings. 
            if (response == cpuChoice[cpuPick] || response == cpuChoice[cpuPick] + "s")
            {
                Console.WriteLine("Tie!");
            } //checks if player wins using rock
            else if ((response == "rock" || response == "rocks" || response == "Rock") &&
                     cpuChoice[cpuPick] == "scissor")
            {
                Console.WriteLine("Player got a crushing wins!");
                points += 1;
            } //checks if player wins using paper
            else if ((response == "paper" || response == "papers" || response == "Paper") &&
                     cpuChoice[cpuPick] == "rock")
            {
                Console.WriteLine("Player wraped up the CPU!");
                points += 1;
            } //checks if player wins using paper
            else if ((response == "scissor" || response == "scissors" || response == "Scissor") &&
                     cpuChoice[cpuPick] == "paper")
            {
                Console.WriteLine("Player slices up the victory!");
                points += 1;
            }
            else if ((response == "scissor" || response == "scissors" || response == "Scissor") &&
                     cpuChoice[cpuPick] == "rock")
            {
                Console.WriteLine("Cpu proves why they rock!");
                cpuPoints += 1;
            }
            else if ((response == "rock" || response == "rocks" || response == "Rock") && cpuChoice[cpuPick] == "paper")
            {
                Console.WriteLine("Cpu gave player a paper cut!");
                cpuPoints += 1;
            }
            else if ((response == "paper" || response == "papers" || response == "Paper") &&
                     cpuChoice[cpuPick] == "scissor")
            {
                Console.WriteLine("Cpu made a scherenschnitte out of the player!");
                cpuPoints += 1;
            }
            else if (response == "han" || response == "Han" || response == "hans")
            {
                Console.WriteLine(
                    "https://en.wikipedia.org/wiki/Rock_paper_scissors#:~:text=The%20first%20known%20mention%20of,206%20BCE%20%E2%80%93%20220%20CE).");
                cpuPoints += 1;
                points += 1;
            }
            else if(response != "paper" && response != "han" && response != "scissor" && response != "rock" && response != "Paper" && response != "Rock" && response != "Scissor" && response != "Han"  && response != "rocks" && response != "hans" && response != "papers" && response != "scissors") 
            {
                Console.WriteLine("Sorry, This is not an action, try again. OR ELSE, NOTHING WILL HAPPEN!");
            }

        Console.WriteLine($"Player points {points}, Cpu points {cpuPoints}");
            // We will add a point system today
        }

        if (points < cpuPoints)
        {
            Console.WriteLine($"CPU won with a {cpuPoints} amount.");

        }
        else if (points > cpuPoints)
        {
            Console.WriteLine($"Player won with a {points} amount.");
        }
       else if (points == cpuPoints)
        {
            Console.WriteLine($"you got a tie with CPU having {cpuPoints}, and you having {points}.");
        }
    }	
}
