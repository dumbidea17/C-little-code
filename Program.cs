﻿// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

// classes are containers that store your code
// only one public class within a c# file
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
     
      int points = 0;
      while (points <= 3){
        // code to store players choice. 
         Console.WriteLine("which do your pick, rock, paper, or scissor! (pick bellow)");
        string response = Console.ReadLine();
        // string[] means list, this has all the ai choices.
        string[] cpuChoice = {"rock", "paper", "scissor"};
        //This picks the ai's choice. New make a new object(make an object class). We can use this object as a key for the random class. 
        Random rand = new Random();
        //This make the range at which the cpu can pick from.
    
        int cpuPick = rand.Next(0,3);
        //This line prints the cpu's choice and 
        Console.WriteLine(cpuChoice[cpuPick]);
        //and in c# is && 
        //If one of them is false the whole thing fails.
        //or is ||
        // checks if the cpu and the player ties, uses cpuChoice[cpuPick] so they are both strings. 
        if(response == cpuChoice[cpuPick] || response == cpuChoice[cpuPick] + "s"){
            Console.WriteLine("Tie!");
        }
            //checks if player wins using rock
        else if(response == "rock" || response == "rocks" && cpuChoice[cpuPick] == "scissor"){
            Console.WriteLine("Player got a crushing wins!");
        }
            //checks if player wins using paper
        else if(response == "paper" || response == "papers"  && cpuChoice[cpuPick] == "rock"){
            Console.WriteLine("Player wraped up the CPU!");
        }
            //checks if player wins using paper
        else if(response == "scissor" || response == "scissors" && cpuChoice[cpuPick] == "paper"){
            Console.WriteLine("Player slices up the victory!");
        }
        else if(response == "scissor" || response == "scissors" && cpuChoice[cpuPick] == "rock"){
            Console.WriteLine("Cpu proves why they rock!");
        }
        else if(response == "rock" || response == "rocks" && cpuChoice[cpuPick] == "paper"){
            Console.WriteLine("Cpu gave player a paper cut!");
        }
        else if(response == "paper" || response == "papers" && cpuChoice[cpuPick] == "scissor"){
            Console.WriteLine("Cpu made a scherenschnitte out of the player!");
        }
        else if(response == "han"){ 
            Console.WriteLine("https://en.wikipedia.org/wiki/Rock_paper_scissors#:~:text=The%20first%20known%20mention%20of,206%20BCE%20%E2%80%93%20220%20CE).");
        }

    // We will add a point system today
	}
    }	
	}
