/*****************************TASK*****************************/

// Two one-dimensional arrays with a different number of elements and
// a natural number k are given. Combine them into one array, including
// the second array between the k-th and (k + 1) -th elements of the first,
// without using an additional array.

/***************************************************************/


using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] arrA = new int[100];
            Console.WriteLine("Initializing arrays.");
            for (int a = 0; a < arrA.Length; a++)
            {
                arrA[a] = rand.Next(100);
                Console.WriteLine("First array now includes this number: " + arrA[a]);
            }
            int[] arrB = new int[20];
            for (int a = 0; a < arrB.Length; a++)
            {
                arrB[a] = rand.Next(100);
                Console.WriteLine("Second array now includes this number: " + arrB[a]);
            }
            Console.WriteLine("Would you please give me a number between 0 and 100 exclusive?");
            int k = -1;
            int.TryParse(Console.ReadLine(), out k);
            if (k <= 0 || k >= arrA.Length)
            {
                Console.WriteLine("That was not right :/");
                Console.ReadKey();
            }
            else
            {
                for (int i = arrA.Length - 1; i > k && i - arrB.Length >= 0; i--)
                {
                    arrA[i] = arrA[i - arrB.Length];
                }
                for (int i = 0, j = k; j < arrA.Length && i < arrB.Length; j++, i++)
                {
                    arrA[j] = arrB[i];
                }
                for (int i = 0; i < arrA.Length; i++)
                {
                    Console.WriteLine("And now it goes like dis: " + arrA[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
