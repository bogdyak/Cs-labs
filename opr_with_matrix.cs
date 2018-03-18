/*****************************TASK*****************************/

// Given a real matrix of size n × m, all elements of which are different.
// In each line, the element with the lowest value is selected, then
// the largest is selected among these numbers. Indicate the indices
 // of the element with the value found.

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
            Console.WriteLine("Width, please!");
            int w = 0, h = 0;
            int.TryParse(Console.ReadLine(), out w);
            if (w < 1)
            {
                Console.WriteLine("Wrong, guess again.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("And now height?!");
            int.TryParse(Console.ReadLine(), out h);
            if (h < 1)
            {
                Console.WriteLine("Wrong, guess again.");
                Console.ReadLine();
                return;
            }
            double[,] matrix = new double[w, h];
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    matrix[i, j] = rand.NextDouble();
                    Console.WriteLine("Element at " + i + " : " + j + " is " + matrix[i, j]);
                }
            }
            List<SmallestOnLine> smallestests = new List<SmallestOnLine>();
            for (int i = 0; i < w; i++)
            {
                smallestests.Add(new SmallestOnLine());
                smallestests[i].val = double.MaxValue;
                for (int j = 0; j < h; j++)
                {
                    if (matrix[i, j] < smallestests[i].val)
                    {
                        smallestests[i].val = matrix[i, j];
                        smallestests[i].x = i;
                        smallestests[i].y = j;
                    }
                }
                Console.WriteLine("The smallest on line " + i + " is " + smallestests[i].val + " at " + smallestests[i].x + " : " + smallestests[i].y);
            }
            SmallestOnLine actuallybiggestEverywhere = new SmallestOnLine();
            actuallybiggestEverywhere.val = double.MinValue;
            foreach (var a in smallestests)
            {
                if (a.val > actuallybiggestEverywhere.val)
                {
                    actuallybiggestEverywhere = a;
                }
            }

            Console.WriteLine("The greatest among the smallest per lines is " + actuallybiggestEverywhere.val + " at " + actuallybiggestEverywhere.x + " : " + actuallybiggestEverywhere.y);
            Console.Read();
        }

        public class SmallestOnLine
        {
            public int x;
            public int y;
            public double val;
        }
    }
}
