/*****************************TASK*****************************/

// Find all natural numbers that do not exceed a given n,
// which are divided into each of their digits.

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
            List<int> result = new List<int>();
            int top = -1;
            Console.WriteLine("Would you please enter a number!");
            int.TryParse(Console.ReadLine(), out top);
            if (top == -1)
            {
                Console.WriteLine("That was not right.");
                Console.ReadKey();
            }
            else
            {
                if (top < 1)
                {
                    Console.WriteLine("That was also not right.");
                    Console.ReadKey();
                }
                else
                {
                    for (int i = 1; i <= top; i++)
                    {
                        string number = i.ToString();
                        bool okay = true;
                        for (int j = 0; j < number.Length; j++)
                        {
                            int k = -1;
                            int.TryParse("" + number[j], out k);
                            if (k == -1)
                            {
                                Console.WriteLine("wtf");
                                okay = false;
                            }
                            else
                            {
                                if (k == 0 || i % k != 0) okay = false;
                            }
                        }
                        if (okay)
                        {
                            result.Add(i);
                            Console.WriteLine("This one's okay: " + i);
                        }
                    }
                    Console.ReadKey();
                }
            }
        }
    }
}
