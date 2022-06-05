/* Program that prompts the user to input a number of integer values.
 * The program stores the ints in an array, counts the frequency of each int and displays the frequency on the console.
 * For this solution, the System.Linq is imported. This allows us to use Distinct to find all the unique elements in the array. */

using System;
using System.Linq;

namespace DBSCADraft
{
    internal class Problem3
    {
        static void Main(string[] args)
        {
            //Asking the user to enter the number of elements to be stored in the array.
            Console.Write("Input the number of elements to be stored in the array: ");
            int numItems = Int32.Parse(Console.ReadLine());

            //Asking the user to enter a number of ints into the array called numItems.
            Console.WriteLine($"Input {numItems} elements in the array");

            // Creating an array, elements, and setting the length to the number specified by the user, numItems.
            int[] elements = new int[numItems];

            // A loop which asks the user to enter numbers into the elements array. The loop continues for the length of the array.
            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write("element - {0} : ", i);
                elements[i] = Int32.Parse(Console.ReadLine());
            }

            //Sort the elements array into ascending order.
            Array.Sort(elements);

            Console.WriteLine("The frequency of all elements of the array");

            // Creating an array, uniqueArray, which stores all the unique elements from the elements array.
            int[] uniqueArray = elements.Distinct().ToArray();


            // Creating a foreach loop which loops through each unique element. Another loop will loop through each element in the elements array, and if the unique element is equal to the current element, the counter will increment.
            foreach (int unique in uniqueArray)
            {   
                // Declaring & initialising the counter variable.
                int counter = 0;
                foreach (int element in elements)
                {
                    if (unique == element)
                    {
                        counter++;
                    }
                }

                // Outputting to the console the number of times that each unique element appears in the elements array.
                Console.WriteLine("{0} appears {1} times", unique, counter);
            }
        }
    }
}
