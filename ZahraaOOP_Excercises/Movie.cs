using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZahraaOOP_Excercises
{
    //Exercise 12: Create a Movie class with attributes title, director, and year.
    //Add a method show_details().

    internal class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }

        public Movie(string title, string director, int year)
        {
            Title = title;
            Director = director;
            Year = year;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Title: {Title}, Director: {Director}, Year: {Year}");
        }


    }
}
