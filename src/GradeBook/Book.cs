using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {

        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            this.grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.High = double.MinValue;
            result.Low = double.MaxValue;
           
            foreach (var number in grades)
            {
                result.Low = Math.Min(number, result.Low);
                result.High = Math.Max(number, result.High);
                result.Average += number;
            }
            result.Average /= grades.Count;
            
            return result;
        }

        private List<double> grades;
        private string name;
    }
}