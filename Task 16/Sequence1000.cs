using System;

// Task: Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …

namespace PrintSequence2
{
    class Sequence1000
    {
        static void Main()
        {
            for (int i = 2; i <= 1000; i++)
            {
                int val = i % 2 == 1 ? i * -1 : i;
                Console.WriteLine(val);
            }
        }
    }
}
