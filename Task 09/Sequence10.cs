using System;


// Task: Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

public class Test
{


    public static void Main()
    {
        for (int i = 2; i <= 11; i++)
        {
            int val = i % 2 == 1 ? i * -1 : i;
            Console.WriteLine(val);
        }
    }
}