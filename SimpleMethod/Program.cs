//Console.WriteLine("Hello, OS");

//using System;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SimpleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");

            Console.WriteLine("What is your first name? ");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name? ");
            string lastName = Console.ReadLine();

            Console.WriteLine("What is your city name? ");
            string cityName = Console.ReadLine();

            displayResult(reverseString(firstName), reverseString(lastName), reverseString(cityName));

            Console.WriteLine();

            displayResult(reverseString(firstName) + " " + reverseString(lastName) + " " + reverseString(cityName));


        }

        private static string reverseString(string word)
        {
            char[] charArray = word.ToCharArray();
            
            Array.Reverse(charArray);

            return String.Concat(charArray);

        }

        private static void displayResult(
            string reverseFirstName, 
            string reverseLastName, 
            string reverseCityName)
        {
            Console.Write("Results: ");
            Console.Write(String.Format("{0} {1} {2}", reverseFirstName, reverseLastName, reverseCityName));
        }

        private static void displayResult(string message)
        {
            Console.Write("Results: ");
            Console.Write(message);
        }




        /*
            string reverseFirstName = reverseString(firstName);
            string reverseLastName = reverseString(lastName);
            string reverseCityName = reverseString(cityName);
            Console.WriteLine("My first name is R-{0}, " +
                              "my last name is R-{1} and " +
                              "my city is R-{2}",
                reverseFirstName, reverseLastName, reverseCityName);
        */

        //method 1 Inline Conversion: C# Array to String with LINQ
        //string result = string.Concat(charArray.Select(x => x.ToString()));

        //method 2 Array to String C#: String.Join in Action
        //string separator = "";
        //string result2 = String.Join(separator, charArray);


        /*
        Console.WriteLine("My first name is R-{0}, " +
                          "my last name is R-{1} and " +
                          "my city is R-{2}",
            result1, result2, result3);
        */
    }
}