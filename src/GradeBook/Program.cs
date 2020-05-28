using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var book = new Book("Simon's Grade Book");
            book.AddGrade(89.2);
            book.AddGrade(77.2);
            book.AddGrade(98.0);
            book.AddGrade(89.3);

            var statistics = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {statistics.Low}");
            Console.WriteLine($"The highest grade is {statistics.High}");
            Console.WriteLine($"The average grade is {statistics.Average:N1}");

        }
    }
}
