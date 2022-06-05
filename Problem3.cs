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

            //Asking the user to enter a number of Ints into the array.
            Console.WriteLine($"Input {numItems} elements in the array");

            int[] elements = new int[numItems];

            //Creating a boolean array called counted.
            bool[] counted = new bool[elements.Length];
            //int counter = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write("element - {0} : ", i);
                elements[i] = Int32.Parse(Console.ReadLine());
            }

            //Sort the elements array into ascending order.
            Array.Sort(elements);

            Console.WriteLine("The frequency of all elements of the array");

            int[] uniqueArray = elements.Distinct().ToArray();

            foreach (int unique in uniqueArray)
            {
                int counter = 0;
                foreach (int element in elements)
                {
                    if (unique == element)
                    {
                        counter++;
                    }
                }
                Console.WriteLine("{0} appears {1} times", unique, counter);
            }
        }
    }
}
