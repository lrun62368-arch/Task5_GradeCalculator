using System;

namespace Task5_GradeCalculator
{
    // This class is for checking a student's grade.
    // It has one method that returns A, B, C, D, or F.

    class Program
    {
        static void Main(string[] args)
        {
            // Make an object of the StudentGrade class.
            StudentGrade sg = new StudentGrade();

            int mark = 0;
            bool valid = false;

            // We use try–catch so the program doesn't crash
            // if the user enters letters instead of numbers.
            while (!valid)
            {
                try
                {
                    Console.Write("Enter the student's mark (0–100): ");
                    mark = int.Parse(Console.ReadLine());

                    if (mark < 0 || mark > 100)
                    {
                        Console.WriteLine("Please enter a number between 0 and 100.");
                    }
                    else
                    {
                        valid = true;
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            // Call the Grade method
            string grade = sg.GetGrade(mark);
            Console.WriteLine("The student's mark is: " + mark);
            Console.WriteLine("The student's grade is: " + grade);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

           
        }
    }
}
