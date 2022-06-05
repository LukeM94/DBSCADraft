using System;
using System.Linq;

namespace DBSCADraft
{
    internal class Problem3
    {
        static void Main(string[] args)
        {
            //Asking the user to enter the number of elements to be stored in the array
            Console.Write("Input the number of elements to be stored in the array: ");
            int numItems = Int32.Parse(Console.ReadLine());

            //Asking the user to enter a number of Ints into the array
            Console.WriteLine($"Input {numItems} elements in the array");

            int[] elements = new int[numItems];

            //Creating a boolean array called counted
            bool[] counted = new bool[elements.Length];
            //int counter = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write("element - {0} : ", i);
                elements[i] = Int32.Parse(Console.ReadLine());
            }

            //Sort the elements array into ascending order
            Array.Sort(elements);

            Console.WriteLine("The frequency of all elements of the array");

            int[] uniqueArray = elements.Distinct().ToArray();

            //foreach (int unique in uniqueArray)
            //{
            //    Console.WriteLine(unique);
            //}

            //foreach (int element in elements)
            //{
            //    Console.WriteLine(element);
            //}

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

            //for (int y = 0; y < uniqueArray.Length; y++) 
            //{
            //    for (int x = 0; x < elements.Length; x++)
            //    {
            //        if (uniqueArray[y] == elements[x])
            //        {
            //            counter += 1;
            //        }
            //        Console.WriteLine("{0} appears {1} times", uniqueArray[y], counter);
            //    }
            //    //Console.WriteLine("{0} appears {1} times", uniqueArray[y], counter);
            //}


            //for (int x = 0; x < elements.Length; x++)
            //{
            //    for(int y = 0; y < uniqueArray.Length; y++)
            //    {
            //        if (elements[x] == uniqueArray[x])
            //        {
            //            counter++;
            //            Console.WriteLine("{0} appears {1} times", elements[x], counter);
            //        }

            //    }
            //}

            //foreach (int element in elements)
            //{
            //    Console.WriteLine(element);
            //    foreach (int unique in uniqueArray)
            //    {
            //        Console.WriteLine(unique);
            //        if(element == unique)
            //        {
            //            counter++;
            //        }
            //        Console.WriteLine("{0} appears {1} times", element, counter);

            //    }

            //}

            //foreach (int element in elements)
            //{
            //    foreach(int unique in uniqueArray)
            //    {
            //        counter++;
            //        Console.WriteLine("{0} appears {1} times", element, counter);

            //    }

            //}

            //for (int x = 1; x < elements.Length; x++)
            //{
            //    if (elements[x] > elements[x - 1] ||)
            //        continue;

            //    counter = 0;

            //    for (int y = 0; y < elements.Length; y++)
            //    {
            //        Console.WriteLine(elements[x]);
            //        if (elements[x] == elements[y])
            //        {
            //            counted[y] = true;
            //            counter++;
            //        }
            //    }
            //    Console.WriteLine("{0} appears {1} times", elements[x], counter);
            //}

            //This is working too!!
            //for (int x = 0; x < elements.Length; x++)
            //{
            //    if (counted[x] == true)
            //        continue;

            //    counter = 0;

            //    for (int y = 0; y < elements.Length; y++)
            //    {
            //        if (elements[x] == elements[y])
            //        {
            //            counted[y] = true;
            //            counter++;
            //        }
            //    }
            //    Console.WriteLine("{0} appears {1} times", elements[x], counter);
            //}

            //This is working!!
            //for (int n = 0; n < elements.Length; n++)
            //{
            //    counter = 0;
            //    if ((n == 0) || (elements[n] > elements[n - 1]))
            //    // if (counted[element] == false)
            //    {
            //        for (int i = 0; i < elements.Length; i++)
            //        {
            //            if (elements[n] == elements[i])
            //            {
            //                counted[i] = true;
            //                counter++;
            //            }
            //        }
            //    Console.WriteLine("{0} appears {1} times", elements[n], counter);
            //    }
            //}
        }
    }
}
