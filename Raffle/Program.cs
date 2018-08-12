using System;

namespace Raffle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that asks the user to enter up to 30 names. 
            //If the user hits enter without entering a name, assume they are done and stop asking them.  
            //Then you will randomly choose a name from the array and write it to the console as the winner.  
            // We haven't learned how to randomize yet, so you'll need to stretch your Googling skills. 
            //Then you will write the list of other names that did not win. 


            Console.WriteLine("Enter up to 30 names");


            string[] names = new string[30];

            int namesEntered;

            for (namesEntered = 0; namesEntered < 30; namesEntered++) 

            {
                names[namesEntered] = Console.ReadLine();

                if (names[namesEntered] == "") 
                {
                    break;
                }
            }
            var randomizer = new Random();
            var winner = randomizer.Next(0, namesEntered);
            Console.WriteLine($"The winner is{names[winner]}!");//$ means putting variables in the string

            foreach (string name in names)
            {
                if (name == "") break;
                if (names[winner] == name) continue;
                Console.WriteLine($"{name} lost. ");
            }

            Console.ReadLine();



        }
    }
}
