using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardChallenges_W1D4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Declare and initialize variables. One of type int, one of type string, and one of type DateTime.
            int num = 13;
            string thisString = "This is a string!";
            DateTime today = DateTime.Now;

            Console.WriteLine("Declared and initialised vaiables:");
            Console.WriteLine("Int: {0}, String: {1} , DateTime: {2}.", num, thisString, today);
            Console.WriteLine("\n");

            // 2.Create a method that subtracts two numbers and returns the value.
            Console.WriteLine("Below is the difference found by a subtraction method:");
            MethodsForWhiteboard methodForWhiteboard = new MethodsForWhiteboard();
            Console.WriteLine( methodForWhiteboard.Subtract( 5, 2 ));
            Console.WriteLine("\n");

            // 3.Create a method that takes two strings from the user and outputs a string.
            Console.WriteLine("Below is a singular string created with a method concatenating two strings:");
            MethodsForWhiteboard methodTwoForWhiteboard = new MethodsForWhiteboard();
            Console.WriteLine(methodTwoForWhiteboard.Phrase( "Someone play a song.", "How about some Bowie?"));
            Console.WriteLine("\n");


            // 4.Write a switch case that asks the user if they are wearing clothes.
            Console.WriteLine("Are you wearing clothes? Yes or No");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "Yes":
                    Console.WriteLine("Thank god, you better be.");
                    break;
                case "No":
                    Console.WriteLine("What is WRONG with you!? Put some clothes on!");
                    break;
            }
            Console.WriteLine("\n");

            // 5.Write an if else statement that uses a boolean to check if the user is happy. 
            // You can start off with something like: bool happy = true;
            bool happy = true;
            Console.WriteLine("Are you happy or sad?");
            string mood = Console.ReadLine();
            if (mood == "happy")
            {
                Console.WriteLine($"You're doing well? I'm so glad that's {happy} for you!");
            }
            else
            {
                Console.WriteLine("I'm sorry you may not be feeling the best. Do something just for you!");
            }
            Console.WriteLine("\n");

            // 6.Write an if, else if, else that asks the user how much money they make a year. 
            // Check ranges between 1,000-10,000,  11,000-50,000, and 51,000-100,000.
            // Output to the test runner based on each salary range. 
            // Have a else statement to prepare for the user not giving their salary range or out of the ranges we are checking.
            Console.WriteLine("How much money do you make in a year? No $ is needed.");
            string money = Console.ReadLine();
            decimal earnings = Convert.ToDecimal(money);

            if (earnings > 100000)
            {
                Console.WriteLine("Woah, buddy you're too rich for this calculator.");
            }
            else if (earnings >= 51000 && earnings <= 100000)
            {
                Console.WriteLine("Look out everyone, we've got a baller up in here!");
            }
            else if (earnings >= 11000 && earnings <= 50000)
            {
                Console.WriteLine("Yay you have the pay of an average American who can barely survive in this economy.");
            }
            else if (earnings >= 1000 && earnings <= 10000)
            {
                Console.WriteLine("I'm sorry, we make the same money. Sucks doesn't it?");
            }
            else
            {
                Console.WriteLine("That amount is either too low or high to compute.");
            }



            Console.ReadLine();
        }
    }
}
