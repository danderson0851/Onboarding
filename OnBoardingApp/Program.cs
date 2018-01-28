using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBoardingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            var firstName = Console.ReadLine();
            Console.WriteLine($"\nAwesome, hi {firstName}! Your first name has been stored in a variable.");
            Console.WriteLine("\nNow, what is your last name?");
            var lastName = Console.ReadLine();
            Console.WriteLine($"\nSweet! It's nice to meet you, {firstName} {lastName}.");
            Console.WriteLine("\nYour last name has also been stored in a variable.");

            bool isOwner = false;
            Console.WriteLine($"\n{firstName}, are you the account owner? | y/n");
            

            Console.WriteLine("(we are going to give value to a boolean variable named 'isOwner' based on your response)");

            var response = Console.ReadLine();

            if (response == "y")
            {
                isOwner = true;
                Console.WriteLine($"Your response was {response}");
                Console.WriteLine($"The bool variable isOwner = {isOwner}");
            }
            else if (response == "n")
            {
                isOwner = false;
                Console.WriteLine($"Your response was {response}");
                Console.WriteLine($"The bool variable isOwner = {isOwner}");
            }
            
            Console.WriteLine("\n\n\n This is the end of the app! press any key to exit!");
            Console.ReadLine();
         

        }
    }
}
