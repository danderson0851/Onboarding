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
                Console.WriteLine($"\nIt seems you are not the account owner, Mr or Ms {lastName}, so we're done here. Good day to you");
            }
            else
                Console.WriteLine("Invalid Response.");

            if (isOwner == true)
            {
                Console.WriteLine($"Okay, Mr/Ms account owner (aka) {firstName} {lastName}, if that is your real name...");
                Console.WriteLine($"\n What might your pin number be???");
                Console.WriteLine("** DISCLAIMER ** This is not a request for your actual pin, merely program input");
                var pin = "";

                pin = Console.ReadLine();
                Console.WriteLine($"Your answer ({pin}) has been assigned to a variable called pin");
                //TODO: Create loop to handle non numerical input from pin
                
            }



            Console.WriteLine("\n\n\n This is the end of the app! Please press any key to exit...");
            Console.ReadLine();
         

        }
    }
}
