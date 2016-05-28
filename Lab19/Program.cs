using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
// File/Project Prolog
// Name: Matthew Vaughan
// CS 1400 Section 003
// Project: Lab 19
// Date: 03/10/2016 09:15:19 am
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
namespace Lab19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create random class
            Random r = new Random();

            //Declare some variables
            string userInput = "";
            string yes = "y";
            string no = "n";
            int rollOne = 0;
            int rollTwo = 0;
            int boxCar = 6;
            int snakeEye = 1;

            //Ask user if they would like to roll the dice and store their input in a variable
            WriteLine("Would you like to roll the dice? (y/n):");
            userInput = ReadLine();

            //Create a do while loop that kick out users who do NOT want to roll the dice
            do
            {
                //Create a while loop that rolls the dice for users who would like to roll the dice
                while (userInput == yes)
                {
                    //Call the random number generator and store the numbers in variables
                    rollOne = r.Next(1, 7);
                    rollTwo = r.Next(1, 7);
                    
                    //If the random numbers are both 6's inform the user they rolled boxcars
                    if (rollOne == boxCar && rollTwo == boxCar)
                    {
                        WriteLine($"You rolled Box Cars");
                    }

                    //If the random numbers are both 1's inform the user they rolled snake eyes
                    else if (rollOne == snakeEye && rollTwo == snakeEye)
                    {
                        WriteLine($"You rolled Snake Eyes");
                    }

                    //Otherwise inform the user of the random numbers generated
                    else
                    {
                        WriteLine($"You rolled a {rollOne} & {rollTwo}");
                    }
                    //Always invite ask the user if they would like to give it another go
                    WriteLine("Would you like to roll the dice again? (y/n)");
                    userInput = ReadLine();
                }
                
                //Create a while loop for invalid answers
                while (userInput != yes && userInput != no)
                {
                    //Inform the user no valid option was received and to try again.
                    //Store the users response in the userInput variable
                    WriteLine("Invalid Response\nPlease enter (y/n):");
                    userInput = ReadLine();
                }
            } while (userInput != no);

            //Bid farewell to the user
            WriteLine("Alright, thank you for playing with me! Goodbye!");
            ReadLine();
        }
    }
}
