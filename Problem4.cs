using System;
using System.Linq;

namespace DBSCADraft
{
    internal class Problem4
    {
        static void Main(string[] args)
        {
            //Asking the user to enter the number of movies to be stored in the array
            Console.Write("Enter number of movies: ");
            int numItems = Int32.Parse(Console.ReadLine());

            string[] movieArray = new string[numItems];

            string input = "";

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
