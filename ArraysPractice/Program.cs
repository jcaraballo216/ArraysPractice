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
            //int[] myFirstArray;
            ////declaring and initialzing a second array
            //string[] myStringArray = { "First", "Second", "Third", "Fourth" };
            ////declare and initialize a char array with the letters of your last name
            //char[] myName = { 'c', 'a', 'r', 'a', 'b', 'a', 'l', 'l', 'o' };
            ////I want my console to print three elements of my array
            //Console.WriteLine(myName[0]);
            //Console.WriteLine(myName[1]);
            //Console.WriteLine(myName[2]);
            //create the following arrays and print using the correct index numbers:
            //Array of top 10 vacation spots
            //print the first and last vacation spots
            //Array of the ages of 3 children you know
            //print each childs age
            //Array of gpa on 4.0 scale of 8 students-dont have to print
            //Array of the First letter of 4 of your classmates names who are sitting near you
            //print all four on the same line
            //string[] vacationSpots = { "Mexico", "Florida", "Hawaii", "Italy", "Myrtle Beach", "Las Vegas", "Aruba", "New York", "London", "Bahamas" };
            //Console.WriteLine(vacationSpots[0]);
            //Console.WriteLine(vacationSpots[9]);
            //int[] ages = { 11, 4, 3 };
            //Console.WriteLine(ages[0]);
            //Console.WriteLine(ages[1]);
            //Console.WriteLine(ages[2]);
            //double[] gpa = { 2.0, 2.5, 2.7, 3.0, 3.2, 3.5, 3.8, 4.0 };
            //char[] firstInitials = { 'c', 'm', 'j', 's' };
            //Console.Write(firstInitials[0]);
            //Console.Write(firstInitials[1]);
            //Console.Write(firstInitials[2]);
            //Console.Write(firstInitials[3]);
            //string[] studentsInClass = new string[21];
            //int[] numberOfSeats = new int[21];
            //studentsInClass[0] = "Jordan";
            ////ask user for input
            //Console.WriteLine("Please enter in the name of the next student.");
            //studentsInClass[1] = Console.ReadLine();
            //Console.WriteLine("Please enter the age of the person in the first seat.");
            ////create a new int array with 21 spots and call it ageOfStudent
            //int[] ageOfStudent = new int[21];
            ////assign the value of the int at the 0 index of ageOfStudent to....
            ////...the users input converted into an int
            //ageOfStudent[0] = int.Parse(Console.ReadLine());
            ////create a new string variable and set it equal to the int at the index of 0 and convert it into a string.

            //string[] dinersInMall = { "Subway", "Sakkio", "Dunkin Donuts", "Red Lobster", "Chick Fil-A" };
            //Console.WriteLine(dinersInMall.Length);
            ////for review
            //int[] myIntArrayAgain;
            ////decleare an array when i know the elements
            //char[] lettersInName = { 'j', 'e', 'r', 'o', 'm', 'e' };
            ////declare and initialize an array when i dont know the elements but know how many there will be
            //string[] variableName = new string[10];
            ////to practice using .Length create a char array of the letters in your middle name...
            //// and print the number of char's to the console.
            //char[] middleName = { 's', 'a', 'm', 'u', 'e', 'l' };
            //Console.WriteLine(middleName.Length);

            ////declara and initialize a string array
            ////using the .Length property, print the Second to last element in the array
            //string[] basketballTeams = { "cavs" , "pistons","browns","indians","pirates"};
            //int numBasket = (basketballTeams.Length);
            //Console.WriteLine(basketballTeams[numBasket - 2]);

            //Index of is a method used to search an array for a specified value and returns...
            //the index position of the first matching value found.
            //int[] bestYearsEver = { 1982, 1999, 1991, 2000, 2005 };
            //Console.WriteLine(Array.IndexOf(bestYearsEver, 2000));
            ////LastIndexOf is a method used to search an array for a specified value and returns...
            ////the index position of the last matching value.
            //Console.WriteLine(Array.LastIndexOf(bestYearsEver, 2000));

            //reverse method
            //int[] palindromeNum = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine(palindromeNum[0]); //will return 1
            //Array.Reverse(palindromeNum);//reverses the order
            //Console.WriteLine(palindromeNum[0]);//will return 7

            //sort
            //will sort numbers in an array from lowest to highest
            //will sort char's and stings in alphabetical order from A-Z
            //string[] powerRangers = { "green", "yellow", "red", "pink", "blue", "black" };
            //Console.WriteLine(powerRangers[0]);//will print green
            //Array.Sort(powerRangers);//sort by alphabetical order
            //Console.WriteLine(powerRangers[0]);//will print black

            //Practice Do It problems
            string[] firstNames = { "Jerome", "Mike", "Sam" };
            Console.WriteLine(Array.IndexOf(firstNames, "Jerome"));
            int[] luckyNum = { 2, 2, 3,3, 4,4, 6, 6, 7,7, 8,8, 9,9 };
            Console.WriteLine(Array.LastIndexOf(luckyNum, 7));
            char[] alphaBet = { 'j', 's', 'c', 'i', 'o' };
            Console.WriteLine(alphaBet[1]);
            Array.Reverse(alphaBet);
            Console.WriteLine(alphaBet[1]);

            string[] studentName = { "jerome", "mike", "clair", "Frank" };
            Array.Sort(studentName);
            Console.Write(studentName[0] + " ");
            Console.WriteLine(studentName[3]);

            int[] randomNum = { 5, 8, 6, 3, 8, 10, 23, 45, 2, 1 };
            Array.Sort(randomNum);
            Console.WriteLine(randomNum[0] + " " + randomNum[9]);






        }
    }
}
