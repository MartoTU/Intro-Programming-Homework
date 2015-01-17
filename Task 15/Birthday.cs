using System;
// Task: Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
class Burthday
{
    static void Main()
    {
        Console.Write("Enter your birth date: ");
        DateTime BirthDay = DateTime.Parse(Console.ReadLine());
        int age = (int)((DateTime.Now - BirthDay).TotalDays / 365.242199);
        Console.WriteLine("You are " + age + " year(s) old");
        Console.WriteLine("After ten years you will be at the age of " + (age + 10));
    }
}