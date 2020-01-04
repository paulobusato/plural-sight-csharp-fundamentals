using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Scott's Grade Book");
            book.AddGrade(50);
            book.AddGrade(200);
            book.AddGrade(100);
            book.ShowStatistics();
        }
    }
}
