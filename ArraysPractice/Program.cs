using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring an array without initializing
            int[] myFirstArray;
            //declaring and initialzing a second array
            string[] myStringArray = { "First", "Second", "Third", "Fourth" };
            //declare and initialize a char array with the letters of your last name
            char[] myName = { 'c', 'a', 'r', 'a', 'b', 'a', 'l', 'l', 'o' };
            //I want my console to print three elements of my array
            Console.WriteLine(myName[0]);
            Console.WriteLine(myName[1]);
            Console.WriteLine(myName[2]);
            //create the following arrays and print using the correct index numbers:
            //Array of top 10 vacation spots
            //print the first and last vacation spots
            //Array of the ages of 3 children you know
            //print each childs age
            //Array of gpa on 4.0 scale of 8 students-dont have to print
            //Array of the First letter of 4 of your classmates names who are sitting near you
            //print all four on the same line
            string[] vacationSpots = { "Mexico", "Florida", "Hawaii", "Italy", "Myrtle Beach", "Las Vegas", "Aruba", "New York", "London", "Bahamas" };
            Console.WriteLine(vacationSpots[0]);
            Console.WriteLine(vacationSpots[9]);
            int[] ages = { 11, 4, 3 };
            Console.WriteLine(ages[0]);
            Console.WriteLine(ages[1]);
            Console.WriteLine(ages[2]);
            double[] gpa = { 2.0, 2.5, 2.7, 3.0, 3.2, 3.5, 3.8, 4.0 };
            char[] firstInitials = { 'c', 'm', 'j', 's' };
            Console.Write(firstInitials[0]);
            Console.Write(firstInitials[1]);
            Console.Write(firstInitials[2]);
            Console.Write(firstInitials[3]);
        }
    }
}
