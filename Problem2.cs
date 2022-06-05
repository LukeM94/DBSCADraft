/* Program that prompts the user to input a delimited data row.
 * After entering the data row, with a delimiter, the user is asked to enter the delimiter.
 * After pressing enter, each data item is printed on a new line. */

using System;

namespace DBSCADraft
{
    internal class Problem2
    {
        static void Main(string[] args)
        {
            //Asking the user to enter their data row and storing in a string variable called dataRow.
            Console.WriteLine("Please enter the data row (seperated by a delimiter like | or \\)");
            string dataRow = Console.ReadLine();

            //Asking the user to enter the delimiter they used and storing in a string variable called delimiter.
            Console.WriteLine("Please enter the delimiter");
            string delimiter = Console.ReadLine();

            //Storing the words in the data row in an array called words. Finding where to split the string by passing in the delimiter.
            string[] words = dataRow.Split(delimiter);

            //Looping through the array of words and writing each word to a new line in the console.
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
