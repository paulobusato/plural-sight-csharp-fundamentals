using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            this.grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            this.grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach(double number in grades)
            {
                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The lowest grade is {lowGrade:N2}");
            Console.WriteLine($"The highest grade is {highGrade:N2}");
            Console.WriteLine($"The average grade is {result:N2}");
        }

        List<double> grades;
        private readonly string name;
    }
}
