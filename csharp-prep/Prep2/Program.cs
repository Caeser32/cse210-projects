using System;

namespace Prep2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your grade percentage: ");
            string gradeInput = Console.ReadLine();
            int grade = int.Parse(gradeInput);
            string letter = "";
           
            if (grade >= 90)
            {
                letter = "A";
            }
            else if (grade >= 80)
            {
                letter = "B";
            }
            else if (grade >= 70)
            {
                letter = "C";
            }
            else if (grade >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

     
            string sign = "";
            int lastDigit = grade % 10;
            if (lastDigit >= 7 && letter != "A" && letter != "F")
            {
                sign = "+";
            }
            else if (lastDigit < 3 && letter != "F")
            {
                sign = "-";
            }


            Console.WriteLine($"Your letter grade is {letter}{sign}");


            if (letter != "F" && grade >= 70)
            {
                Console.WriteLine("Congratulations! You passed the course.");
            }
            else
            {
                Console.WriteLine("You did not pass the course. Keep working hard!");
            }
        }
    }
}