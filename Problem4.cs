/* Program that prompts the user to input a number of movies.
 * The program stores the movie names in an array and outputs what has been stored.
 * If the user enters the word "Exit" as a movie name, the program should stop prompting the user to enter any
 * more movie names, and output all the movies already in the array. */

using System;

namespace DBSCADraft
{
    internal class Problem4
    {
        static void Main(string[] args)
        {
            // Asking the user to enter the number of movies to be stored in the array, and storing this in a variable, numItems.
            Console.Write("Enter number of movies: ");
            int numItems = Int32.Parse(Console.ReadLine());

            // Declaring & initialising a String array, movieArray, and setting the length to the length specified by the user.
            string[] movieArray = new string[numItems];

            // Declaring & initialising a String variable, input.
            string input = "";

            // Creating a for loop, that asks the user to enter a movie name. The loop continues for the length specified by the user. The users input is assigned to a variable, input, and added to the current position in the array. If the input equals "Exit", the loop breaks.
            for (int i = 0; i < numItems; i++)
            {
                Console.WriteLine("Enter Movie Name: ");
                input = Console.ReadLine();
                movieArray[i] = input;

                if(input == "Exit")
                {
                    break;
                }
            }

            // Creating another for loop, that continues for the length of the movieArray, and outputs the movies to the console. If the current position in the movieArray is empty (null), or is "Exit", it's not displayed on the screen.
            for (int x = 0; x < movieArray.Length; x++)
            {
                if (movieArray[x] != null && movieArray[x] != "Exit")
                {
                    Console.WriteLine("Movie {0} is {1}", x + 1, movieArray[x]);
                }
            }

        }
    }
}
