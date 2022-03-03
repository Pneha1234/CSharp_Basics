using System;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.ReadLine();

            //declaring variables

            string characterName = "John";
            int charcaterAge = 35;

            Console.WriteLine("There once was a man named" + characterName);
            Console.WriteLine("He was" + charcaterAge + "years old!");
            Console.WriteLine("He really liked the name" + characterName);
            Console.WriteLine("But didn't liked beimg" + charcaterAge);

            Console.ReadLine();

            //DataTypes
            string phrase = "Test Project";
            char grade = 'a';
            int number = 30;
            bool isFemale = true;

            //Working with Strings

            Console.WriteLine("Test Project");
            // used for new line
            Console.Write("Test\nProject");
            //escape character
            Console.Write("Test\"Project");
            Console.WriteLine(phrase.Length);
            // can call methods
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());
            // checks for substrings
            Console.WriteLine(phrase.Contains("Test"));

            //can use indexing for accessing the characters
            Console.WriteLine(phrase[0]);

            // can use index of method
            Console.WriteLine(phrase.IndexOf("Project"));
            Console.Write(phrase.Substring(3, 2));
        }
    }
}
